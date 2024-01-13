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

-- get_info_appointment
CREATE OR ALTER PROC get_info_appointment (@appointment_date DATE, @ordinal INT)
AS
BEGIN
	SELECT A.patient_name, A.note, A.record_id, C.clinic_number, A.dentist_id, A.medical_assistant_id, A.treatment_id
	FROM appointment_schedule A INNER JOIN clinic C ON A.clinic_id = C.clinic_id
	WHERE A.appointment_date = @appointment_date AND A.ordinal = @ordinal
END
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
	IF @treatment_id = -1 SET @treatment_id = NULL
	IF @medical_assistant_id = -1 SET @medical_assistant_id = NULL
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
			IF NOT EXISTS(SELECT * FROM treatment_plan TP WHERE TP.id = @treatment_id)
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

-- delete_appointment
CREATE OR ALTER PROC delete_appointment (@appointment_date DATE, @ordinal INT)
AS
BEGIN
	
	DELETE FROM appointment_schedule 
	WHERE appointment_date = @appointment_date AND ordinal = @ordinal
END
GO


-- filter_appointment
CREATE OR ALTER PROC filter_appointment (@branch_id INT, @date DATE, @patient_id VARCHAR(50), 
										@clinic_id INT, @dentist_id INT)
AS
BEGIN

	DECLARE @filter_patient BIT, @filter_dentist BIT, @filter_clinic BIT, @dentist_name NVARCHAR(150)
	SET @filter_patient = 1
	SET @filter_dentist = 1
	SET @filter_clinic = 1
	--SET @dentist_name = (SELECT U.full_name FROM [user] U WHERE @dentist_id = U.id)

	IF @patient_id = '-1' SET @filter_patient = 0
	IF @dentist_id = -1 SET @filter_dentist = 0
	IF @clinic_id = -1 SET @filter_clinic = 0



	SELECT A.appointment_date, A.ordinal, A.patient_name, A.note, A.record_id, C.clinic_number, 
		A.dentist_id, A.medical_assistant_id, A.treatment_id
	FROM appointment_schedule A INNER JOIN clinic C ON A.clinic_id = C.clinic_id
	WHERE C.branch_id = @branch_id AND A.appointment_date = @date
			AND (@filter_patient <> 1 OR A.record_id = @patient_id)
			AND (@filter_dentist <> 1 OR A.dentist_id = @dentist_id)
			AND (@filter_clinic <> 1 OR C.clinic_id = @clinic_id) 

END
GO
EXEC filter_appointment @branch_id = 1, @date = '2024-01-09', @patient_id = 'a23vbas1', @dentist_id = -1, @clinic_id = -1

-- get_next_ordinal
CREATE OR ALTER PROC get_next_ordinal (@appointment_date DATE)
AS
BEGIN
	SELECT (A.ordinal + 1) FROM appointment_schedule A WHERE A.appointment_date = @appointment_date
END	
GO


-- edit_appointment
CREATE OR ALTER PROC edit_appointment (@appointment_date DATE, @ordinal INT, 
										@note NVARCHAR(200),
										@clinic_id INT,
										@dentist_id INT,
										@medical_assistant_id INT
)
AS 
BEGIN
	IF @medical_assistant_id = -1 SET @medical_assistant_id = NULL
	UPDATE appointment_schedule 
	SET note = @note, clinic_id = @clinic_id, dentist_id = @dentist_id, medical_assistant_id = @medical_assistant_id
	WHERE appointment_date = @appointment_date AND ordinal = @ordinal
END
GO