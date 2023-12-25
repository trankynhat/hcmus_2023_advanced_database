CREATE TRIGGER trg_prescription__check_is_deleted
ON prescription
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @treatment_id INT
    DECLARE @drug_code VARCHAR(20)
	DECLARE @counter INT

    SELECT @treatment_id = treatment_id, @drug_code = drug_code
    FROM inserted

    SELECT * FROM prescription
    WHERE treatment_id = @treatment_id AND drug_code = @drug_code AND is_deleted = 0

    SELECT @counter = COUNT(*) FROM prescription
    WHERE treatment_id = @treatment_id AND drug_code = @drug_code AND is_deleted = 0

	IF @counter > 1
        BEGIN
            RAISERROR('trg_prescription__check_is_deleted', 16, 1)
            ROLLBACK
        END
END
GO