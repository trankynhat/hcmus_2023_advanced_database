USE CQ_CSDLNC_05
GO
-- list_payment_methods
CREATE PROC list_payment_methods
AS
BEGIN
    SELECT code, name, [desc] FROM payment_method
END
GO

-- list_payment_by_record_id
CREATE PROC list_payment_by_record_id(@record_id VARCHAR(50))
AS
BEGIN
    SELECT id, total_treatment_fee, date_of_payment, change, note, payment_method_code
    FROM payment
    WHERE id IN (
        SELECT DISTINCT T.payment_id
        FROM treatment T
        JOIN single_treatment ST
        ON T.id = ST.treatment_id
        WHERE ST.record_id = @record_id AND T.payment_id IS NOT NULL
    )
    OR id IN (
        SELECT DISTINCT payment_id
        FROM treatment T
        JOIN treatment_phase TP
        ON T.id = TP.treatment_id
        JOIN treatment_plan TPL
        ON TP.treatment_plan_id = TPL.id
        WHERE TPL.record_id = @record_id AND T.payment_id IS NOT NULL
    )
    ORDER BY date_of_payment
END
GO