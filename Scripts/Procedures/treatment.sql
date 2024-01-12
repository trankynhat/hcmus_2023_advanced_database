-- list_treatment_categories
CREATE PROC list_treatment_categories
AS
BEGIN
    SELECT id, name, [desc] FROM treatment_category
END
GO

-- get_treatment_type_by_category_id
CREATE PROC get_treatment_type_by_category_id(@category_id INT)
AS
BEGIN
    SELECT id, name, [desc], treatment_category_id
    FROM treatment_type
    WHERE treatment_category_id = @category_id
END
GO

-- get_treatment_type
CREATE PROC get_treatment_type(@id INT)
AS
BEGIN
    SELECT id, name, [desc], treatment_category_id
    FROM treatment_type
    WHERE id = @id
END
GO

-- get_treatment_status
CREATE PROC get_treatment_status(@id INT)
AS
BEGIN
    SELECT id, name, [desc], symbolic_color
    FROM treatment_plan_status
    WHERE id = @id
END
GO

-- get_treatment_phases_by_treatment_plan_id
CREATE PROC get_treatment_phases_by_treatment_plan_id(@plan_id INT)
AS
BEGIN
    SELECT T.id, T.description, T.treatment_fee, T.treatment_date, T.payment_method_code, T.payment_id, T.dentist_id, TP.treatment_id
    FROM treatment T
    RIGHT JOIN treatment_phase TP
    ON T.id = TP.treatment_id
    WHERE TP.treatment_plan_id = @plan_id AND TP.is_deleted = 0
    ORDER BY T.treatment_date
END
GO

-- delete_treatment_phase
CREATE PROC delete_treatment_phase(@phase_id INT)
AS
BEGIN
    UPDATE treatment_phase
    SET is_deleted = 1
    WHERE treatment_id = @phase_id
END
GO

-- create_new_treatment_plan
CREATE PROC create_new_treatment_plan(
    @description NVARCHAR(500),
    @note NVARCHAR(200),
    @treatment_type_id INT,
    @record_id VARCHAR(50)
)
AS
BEGIN
    IF NOT EXISTS(SELECT * FROM treatment_type WHERE id = @treatment_type_id)
        BEGIN
            RAISERROR('invalid treatment_type_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM patient_record WHERE citizen_id = @record_id)
        BEGIN
            RAISERROR('invalid record_id', 16, 1)
        END

    INSERT INTO treatment_plan(description, note, treatment_plan_status_id, treatment_type_id, record_id)
    VALUES(@description, @note, 0, @treatment_type_id, @record_id)
END
GO

-- update_treatment_plan
CREATE PROC update_treatment_plan(
    @id INT,
    @description NVARCHAR(500),
    @note NVARCHAR(200),
    @treatment_plan_status_id INT
)
AS
BEGIN
    IF NOT EXISTS(SELECT * FROM treatment_plan_status WHERE id = @treatment_plan_status_id)
        BEGIN
            RAISERROR('invalid treatment_plan_status_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM treatment_plan WHERE id = @id)
        BEGIN
            RAISERROR('invalid id', 16, 1)
        END

    UPDATE treatment_plan
    SET description = @description,
        note = @note,
        treatment_plan_status_id = @treatment_plan_status_id
    WHERE id = @id
END
GO

-- create_treatment_phase
CREATE PROC create_treatment_phase(
    @description NVARCHAR(500),
    @treatment_fee BIGINT,
    @treatment_date DATE,
    @payment_method_code VARCHAR(50),
    @dentist_id INT,
    @treatment_plan_id INT
)
AS
BEGIN
    IF NOT EXISTS(SELECT * from dentist WHERE user_id = @dentist_id)
        BEGIN
            RAISERROR('invalid dentist_id', 16, 1)
			RETURN
        END

    IF @treatment_fee < 0
        BEGIN
            RAISERROR('invalid treatment_fee', 16, 1)
			RETURN
        END

    IF NOT @treatment_date < GETDATE()
        BEGIN
            RAISERROR('invalid treatment_date', 16, 1)
			RETURN
        END

    IF NOT EXISTS(SELECT * FROM payment_method WHERE code = @payment_method_code)
        BEGIN
            RAISERROR('invalid payment_method_code', 16, 1)
			RETURN
        END

	DECLARE @new_row_id_table TABLE (id INT);

    INSERT INTO treatment(description, treatment_fee, treatment_date, payment_method_code, dentist_id)
	OUTPUT INSERTED.id INTO @new_row_id_table
    VALUES(@description, @treatment_fee, @treatment_date, @payment_method_code, @dentist_id)

	DECLARE @new_row_id INT;
    SELECT @new_row_id = id FROM @new_row_id_table;

    INSERT INTO treatment_phase(treatment_id, treatment_plan_id)
    VALUES(@new_row_id, @treatment_plan_id)
END
GO

-- pay_treatment_phase
CREATE PROC pay_treatment_phase(
    @total_treatment_fee BIGINT,
    @change BIGINT,
    @note NVARCHAR(250),
    @payment_method_code VARCHAR(50),
    @phase_id INT
)
AS
BEGIN
    IF NOT EXISTS(SELECT * FROM payment_method WHERE code = @payment_method_code)
        BEGIN
            RAISERROR('invalid payment_method_code', 16, 1)
			RETURN
        END

    IF @total_treatment_fee < 0
        BEGIN
            RAISERROR('invalid total_treatment_fee', 16, 1)
			RETURN
        END

    IF @change < 0
        BEGIN
            RAISERROR('invalid change', 16, 1)
			RETURN
        END

    IF NOT EXISTS(SELECT * FROM treatment_phase WHERE treatment_id = @phase_id)
        BEGIN
            RAISERROR('invalid phase_id', 16, 1)
			RETURN
        END

    DECLARE @new_row_id_table TABLE (id INT);

    INSERT INTO payment(total_treatment_fee, date_of_payment, change, note, payment_method_code)
    OUTPUT INSERTED.id INTO @new_row_id_table
    VALUES(@total_treatment_fee, GETDATE(), @change, @note, @payment_method_code)

    DECLARE @new_row_id INT;
    SELECT @new_row_id = id FROM @new_row_id_table;

    UPDATE treatment
    SET payment_id = @new_row_id
    WHERE id = @phase_id
END
GO


-- get_list_planning_treatment_plan
CREATE OR ALTER PROC get_list_planning_treatment_plan (@patient_id VARCHAR(50))
AS
BEGIN
	DECLARE @treatment_plan_status_id INT
	SET @treatment_plan_status_id = (SELECT TPS.id
					FROM treatment_plan_status TPS
					WHERE TPS.symbolic_color = '#0010D0')

	SELECT TP.id, TT.name
	FROM treatment_plan TP INNER JOIN treatment_type TT ON TP.treatment_type_id = TT.id 
	WHERE TP.treatment_plan_status_id = @treatment_plan_status_id AND TP.record_id = @patient_id
END
GO


-- get_treatment_planning_name
CREATE OR ALTER PROC get_treatment_plan_type_name (@treatment_plan_id INT) 
AS
BEGIN
	SELECT TT.name
	FROM treatment_plan TP INNER JOIN treatment_type TT ON TP.treatment_type_id = TT.id
	WHERE TP.id = @treatment_plan_id
END
GO