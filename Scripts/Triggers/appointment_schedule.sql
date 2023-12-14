CREATE TRIGGER trg_appointment_schedule__increment_ordinal
ON appointment_schedule
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE a
    SET ordinal = ISNULL(b.max_ordinal, 0) + 1
    FROM appointment_schedule a
    INNER JOIN (
        SELECT appointment_date, MAX(ordinal) AS max_ordinal
        FROM appointment_schedule
        GROUP BY appointment_date
    ) b 
    ON a.appointment_date = b.appointment_date
    INNER JOIN inserted i 
    ON a.appointment_date = i.appointment_date 
        AND a.ordinal = i.ordinal 
        AND a.record_id = i.record_id;

END;