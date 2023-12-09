-- insert_new_drug
CREATE PROCEDURE insert_new_drug(
    @code VARCHAR(20), 
    @name NVARCHAR(150),
    @description NVARCHAR(250), 
    @price_unit NVARCHAR(10), 
    @price_per_unit FLOAT
)
AS
    INSERT INTO drug(code, name, description, price_unit, price_per_unit)
    VALUES (@code, @name, @description, @price_unit, @price_per_unit)
GO

-- delete_drug
CREATE PROCEDURE delete_drug(@code VARCHAR(20))
AS
    UPDATE drug SET is_deleted = 1 WHERE code = @code
GO

-- list_of_drugs
CREATE PROCEDURE list_of_drugs
AS
    SELECT code, name, description, price_unit, price_per_unit
    FROM drug
    WHERE is_deleted = 0
GO

-- get_drug_info
CREATE PROCEDURE get_drug_info (@code VARCHAR(20))
AS
    SELECT code, name, description, price_unit, price_per_unit
    FROM drug
    WHERE code = @code
GO

-- update_drug
CREATE PROCEDURE update_drug(
    @code VARCHAR(20), 
    @name NVARCHAR(150),
    @description NVARCHAR(250), 
    @price_unit NVARCHAR(10), 
    @price_per_unit FLOAT,
    @rows_updated INT OUTPUT
)
AS
BEGIN
    UPDATE drug
    SET name = @name, description = @description, price_unit = @price_unit, price_per_unit = @price_per_unit
    WHERE code = @code

    SET @rows_updated = @@ROWCOUNT;
END
GO

