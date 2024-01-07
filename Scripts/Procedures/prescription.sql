-- get_prescription_by_phase_id
CREATE PROC get_prescription_by_phase_id(@phase_id INT)
AS
BEGIN
    SELECT treatment_id, drug_code, quantity, note
    FROM prescription
    WHERE treatment_id = @phase_id
END
GO

-- add_drug_to_prescription
CREATE PROC add_drug_to_prescription(@treatment_id INT, @drug_code VARCHAR(20), @quantity INT, @note NVARCHAR(250))
AS
BEGIN
    IF @quantity < 0
        BEGIN 
            RAISERROR('invalid quantity', 16, 1)
        END
    
    IF NOT EXISTS(SELECT * FROM treatment WHERE id = @treatment_id)
        BEGIN 
            RAISERROR('invalid treatment_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM drug WHERE code = @drug_code)
        BEGIN 
            RAISERROR('invalid drug_code', 16, 1)
        END

    INSERT INTO prescription(treatment_id, drug_code, quantity, note)
    VALUES(@treatment_id, @drug_code, @quantity, @note)
END
GO

-- delete_drug_in_prescription
CREATE PROC delete_drug_in_prescription(@treatment_id INT, @drug_code VARCHAR(20))
AS
BEGIN
    IF NOT EXISTS(SELECT * FROM treatment WHERE id = @treatment_id)
        BEGIN 
            RAISERROR('invalid treatment_id', 16, 1)
        END

    IF NOT EXISTS(SELECT * FROM drug WHERE code = @drug_code)
        BEGIN 
            RAISERROR('invalid drug_code', 16, 1)
        END
    
    UPDATE prescription SET is_deleted = 1 WHERE treatment_id = @treatment_id AND drug_code = @drug_code
END
GO