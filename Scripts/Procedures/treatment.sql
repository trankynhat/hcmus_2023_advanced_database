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
    SELECT T.id, T.description, T.treatment_fee, T.treatment_date, T.payment_method_code, T.payment_id, T.dentist_id
    FROM treatment T
    RIGHT JOIN treatment_phase TP
    ON T.id = TP.treatment_id
    WHERE TP.treatment_plan_id = @plan_id
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