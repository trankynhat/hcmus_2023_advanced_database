CREATE PROCEDURE list_of_drugs
AS
SELECT code, name, description, price_unit, price_per_unit
FROM drug
GO

