-- list_payment_methods
CREATE PROC list_payment_methods
AS
BEGIN
    SELECT code, name, [desc] FROM payment_method
END
GO