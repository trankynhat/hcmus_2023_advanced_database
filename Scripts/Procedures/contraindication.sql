-- list_contraindication_by_record_id

CREATE PROC list_contraindication_by_record_id (@record_id VARCHAR(50))
AS
BEGIN
    SELECT record_id, drug_code, note
    FROM drug_contraindication_info
    WHERE record_id = @record_id AND is_deleted = 0
END
GO

-- delete_contraindication
CREATE PROC delete_contraindication (@record_id VARCHAR(50), @drug_code VARCHAR(20))
AS
BEGIN
    IF NOT EXISTS(SELECT * FROM patient_record WHERE citizen_id = @record_id)
        BEGIN 
            RAISERROR('invalid record_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM drug WHERE code = @drug_code)
        BEGIN 
            RAISERROR('invalid drug_code', 16, 1)
        END

    UPDATE drug_contraindication_info
    SET is_deleted = 1
    WHERE record_id = @record_id AND drug_code = @drug_code
END
GO

-- add_contraindication
CREATE PROC add_contraindication (@record_id VARCHAR(50), @drug_code VARCHAR(20), @note NVARCHAR(250))
AS
BEGIN
    DECLARE @check_is_delete BIT

    IF NOT EXISTS(SELECT * FROM patient_record WHERE citizen_id = @record_id)
        BEGIN 
            RAISERROR('invalid record_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM drug WHERE code = @drug_code)
        BEGIN 
            RAISERROR('invalid drug_code', 16, 1)
        END

    IF EXISTS(SELECT * FROM drug_contraindication_info WHERE record_id = @record_id AND drug_code = @drug_code)
        BEGIN
            SELECT @check_is_delete = is_deleted
            FROM drug_contraindication_info
            WHERE record_id = @record_id AND drug_code = @drug_code

            IF @check_is_delete = 0
                RAISERROR('Can not insert', 16, 1)
            ELSE
                UPDATE drug_contraindication_info
                SET is_deleted = 0, note = @note
                WHERE record_id = @record_id AND drug_code = @drug_code
        END
    ELSE
        INSERT INTO drug_contraindication_info(record_id, drug_code, note)
        VALUES(@record_id, @drug_code, @note)
END
GO