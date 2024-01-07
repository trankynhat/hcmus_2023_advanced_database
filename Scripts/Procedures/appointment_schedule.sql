USE CQ_CSDLNC_05
GO

-- show_appointment_in_date
CREATE OR ALTER PROC show_appointment_in_date (@branch_id INT, @date DATE)
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, apm_s.note, 
		apm_s.record_id, c.clinic_number, apm_s.dentist_id, apm_s.medical_assistant_id, apm_s.treatment_id
	FROM appointment_schedule apm_s INNER JOIN clinic c ON apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date AND c.branch_id = @branch_id
END
GO
EXEC show_appointment_in_date @branch_id = 1, @date = '2024-01-07'
GO


-- create_appointment
CREATE OR ALTER PROC add_new_appontment (@appointment_date DATE, 
								@ordinal INT,
								@patient_name NVARCHAR(150),
								@note NVARCHAR(200),
								@record_id VARCHAR(50),
								@clinic_id INT,
								@dentist_id INT,
								@medical_assistant_id INT,
								@treatment_id INT)
AS	
BEGIN
    IF NOT EXISTS(SELECT * FROM patient_record pr WHERE pr.citizen_id = @record_id)
        BEGIN
            RAISERROR('invalid record_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM clinic c WHERE c.clinic_id = @clinic_id)
        BEGIN
            RAISERROR('invalid clinic_id', 16, 1)
        END

	IF NOT EXISTS(SELECT * FROM dentist d WHERE d.user_id = @dentist_id)
        BEGIN
            RAISERROR('invalid dentist_id', 16, 1)
        END
	
	IF (@medical_assistant_id IS NOT NULL)
		BEGIN
			IF NOT EXISTS(SELECT * FROM dentist d WHERE d.user_id = @medical_assistant_id)
				BEGIN
					RAISERROR('invalid medical_dentist_id', 16, 1)
				END
		END
	

	IF (@treatment_id IS NOT NULL) 
		BEGIN
			IF NOT EXISTS(SELECT * FROM treatment t WHERE t.id = @treatment_id)
				BEGIN
					RAISERROR('invalid treatment_id', 16, 1)
				END
		END

    INSERT INTO appointment_schedule(appointment_date, ordinal, patient_name, note, record_id, 
		clinic_id, dentist_id, medical_assistant_id, treatment_id)
    VALUES(@appointment_date, @ordinal, @patient_name, @note, @record_id, @clinic_id,
		@dentist_id, @medical_assistant_id, @treatment_id)
END
GO
EXEC add_new_appontment @appointment_date = '2024-01-07', @ordinal = 2,
@patient_name = 'Latasha Meyer', @note = null, @record_id = '000012323', @clinic_id = 1,
@dentist_id = 2, @medical_assistant_id = null, @treatment_id = null
GO


-- delete_appointment
CREATE OR ALTER PROC delete_appointment (@appointment_date DATE, @ordinal INT)
AS
BEGIN 
	DELETE FROM appointment_schedule 
	WHERE appointment_date = @appointment_date AND ordinal = @ordinal
END
GO
EXEC delete_appointment @appointment_date = '2024-01-07', @ordinal = 2
GO


-- filter_appointment_by_patient
CREATE OR ALTER PROC filter_appointment_by_patient (@branch_id INT, @date DATE, @patient_name NVARCHAR(150))
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, apm_s.note, 
		apm_s.record_id, c.clinic_id, apm_s.dentist_id, apm_s.medical_assistant_id, apm_s.treatment_id
	FROM appointment_schedule apm_s INNER JOIN clinic c ON apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date AND c.branch_id = @branch_id AND apm_s.patient_name = @patient_name
END
GO
EXEC filter_appointment_by_patient @branch_id = 1, @date = '2024-01-07', @patient_name = 'Latasha Meyer'
GO


-- filter_appointment_by_clinic
CREATE OR ALTER PROC filter_appointment_by_clinic (@branch_id INT, @date DATE, @clinic_id INT)
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, apm_s.note, 
		apm_s.record_id, c.clinic_id, apm_s.dentist_id, apm_s.medical_assistant_id, apm_s.treatment_id
	FROM appointment_schedule apm_s INNER JOIN clinic c ON apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date AND c.branch_id = @branch_id AND apm_s.clinic_id = @clinic_id
END
GO
EXEC filter_appointment_by_clinic @branch_id = 1, @date = '2024-01-07', @clinic_id = '1'
GO


-- filter_appointment_by_dentist
CREATE OR ALTER PROC filter_appointment_by_dentist (@branch_id INT, @date DATE, @dentist_id INT)
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, apm_s.note, 
		apm_s.record_id, c.clinic_id, apm_s.dentist_id, apm_s.medical_assistant_id, apm_s.treatment_id
	FROM appointment_schedule apm_s INNER JOIN clinic c ON apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date AND c.branch_id = @branch_id AND apm_s.dentist_id = @dentist_id
END
GO
EXEC filter_appointment_by_dentist @branch_id = 1, @date = '2024-01-07', @dentist_id = 2
GO


-- filter_appointment
CREATE OR ALTER PROC filter_appointment (@branch_id INT, @date DATE, @patient_name NVARCHAR(150), 
										@clinic_id INT, @dentist_name NVARCHAR(150))
AS
BEGIN

	DECLARE @patient_id INT, @dentist_id INT, @filter_patient BIT, @filter_dentist BIT, @filter_clinic BIT
	SET @filter_patient = 1
	SET @filter_dentist = 1
	SET @filter_clinic = 1

	IF @patient_name LIKE '' SET @filter_patient = 0
	ELSE SET @patient_id = (SELECT P.citizen_id FROM patient_record P WHERE P.full_name LIKE @patient_name)

	IF @dentist_name LIKE '' SET @filter_dentist = 0
	ELSE SET @dentist_id = (SELECT U.id  FROM [user] U WHERE U.full_name LIKE @dentist_name)

	IF @clinic_id = -1 SET @filter_clinic = 0



	SELECT A.appointment_date, A.ordinal, A.patient_name, A.note, A.record_id, C.clinic_number, 
		A.dentist_id, A.medical_assistant_id, A.treatment_id
	FROM appointment_schedule A INNER JOIN clinic C ON A.clinic_id = C.clinic_id
	WHERE (@filter_patient <> 1 OR A.record_id = @patient_id)
			AND (@filter_dentist <> 1 OR A.dentist_id = @dentist_id)
			AND (@filter_clinic <> 1 OR C.clinic_id = @clinic_id)

END
GO
EXEC filter_appointment @branch_id = 1, @date = '2024-01-07', @patient_name = 'Latasha Meyer', @clinic_id = -1, @dentist_name = ''
GO