-- get_user_role

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
END
GO

USE CQ_CSDLNC_05


SELECT U.username as dentist
FROM [user] U WHERE U.id = (SELECT top 1 D.user_id FROM dentist D)


SELECT U.username as staff
FROM [user] U WHERE U.id = (SELECT top 1 S.user_id FROM staff S)

SELECT U.username as admin

FROM [user] U WHERE U.id = (SELECT top 1 B.admin_id FROM branch B)