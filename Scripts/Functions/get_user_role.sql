CREATE FUNCTION get_user_role(@user_id INT)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @userRole NVARCHAR(50)

    IF EXISTS (SELECT 1 FROM branch WHERE admin_id = @user_id)
        SET @userRole = 'ADMIN'
    ELSE IF EXISTS (SELECT 1 FROM staff WHERE user_id = @user_id)
        SET @userRole = 'STAFF'
    ELSE IF EXISTS (SELECT 1 FROM dentist WHERE user_id = @user_id)
        SET @userRole = 'DENTIST'
    ELSE
        SET @userRole = 'UNKNOWN'

    RETURN @userRole
END;
GO
