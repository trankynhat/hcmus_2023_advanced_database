CREATE TRIGGER tr_check_payment_id
ON treatment
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT payment_id
        FROM (
            SELECT payment_id, COUNT(*) AS cnt
            FROM inserted
            GROUP BY payment_id
        ) AS subquery
        WHERE cnt > 1 AND payment_id IS NOT NULL
    )
    BEGIN
        RAISERROR('Each payment_id must exist on at most one row.', 16, 1)
        ROLLBACK TRANSACTION
    END
END
