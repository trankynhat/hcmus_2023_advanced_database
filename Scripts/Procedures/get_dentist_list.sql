CREATE PROCEDURE GetDentistsList
    @p_user_id INT
AS
BEGIN
    DECLARE @user_role VARCHAR(20);

    -- Call the function to get the user role
    SET @user_role = dbo.get_user_role(@p_user_id);

    IF @user_role NOT IN ('ADMIN', 'STAFF', 'DENTIST')
 BEGIN
    THROW 50000, 'You do not have access to the list of dentists', 1;
    RETURN;
END
    -- Get the list of dentists
    SELECT d.*, u.full_name AS dentist_name
    FROM dentist d
    INNER JOIN [user] u ON d.user_id = u.id;
END;
GO