-- insert_new_drug
CREATE PROCEDURE insert_new_drug(
    @code VARCHAR(20), 
    @name NVARCHAR(150),
    @description NVARCHAR(250), 
    @price_unit NVARCHAR(10), 
    @price_per_unit FLOAT
)
AS
BEGIN
    INSERT INTO drug(code, name, description, price_unit, price_per_unit)
    VALUES (@code, @name, @description, @price_unit, @price_per_unit)
END
GO

-- delete_drug
CREATE PROCEDURE delete_drug(@code VARCHAR(20))
AS
BEGIN
    UPDATE drug SET is_deleted = 1 WHERE code = @code
END
GO

-- list_of_drugs
CREATE PROCEDURE list_of_drugs
    @page_num INT
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

    SET @sql = '
        SELECT code, name, description, price_unit, price_per_unit
        FROM drug
        WHERE is_deleted = 0
        ORDER BY name
        OFFSET ' + CAST((@page_num - 1) * 1000 AS NVARCHAR(MAX)) + ' ROWS 
        FETCH NEXT 1000 ROWS ONLY'

    EXEC sp_executesql @sql
END
GO

-- search_drugs
CREATE PROCEDURE search_drugs
    @page_num INT,
    @keyword VARCHAR(200)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

    SET @sql = '
        SELECT code, name, description, price_unit, price_per_unit
        FROM drug
        WHERE is_deleted = 0 AND name LIKE ''%' + @keyword + '%''
        ORDER BY name
        OFFSET ' + CAST((@page_num - 1) * 1000 AS NVARCHAR(MAX)) + ' ROWS 
        FETCH NEXT 1000 ROWS ONLY'

    EXEC sp_executesql @sql
END
GO

-- get_drug_info
CREATE PROCEDURE get_drug_info (@code VARCHAR(20))
AS
BEGIN
    SELECT code, name, description, price_unit, price_per_unit
    FROM drug
    WHERE code = @code
END
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

