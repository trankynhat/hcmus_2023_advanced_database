CREATE TRIGGER trg_dentist__check_user_id
ON dentist
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @user_id INT

    SELECT @user_id = user_id
    FROM inserted
    
    IF EXISTS(
        SELECT * FROM staff WHERE user_id = @user_id
    ) OR EXISTS(
        SELECT * FROM branch WHERE admin_id = @user_id
    )
    BEGIN
        RAISERROR('User can not have more than one role.', 16, 1)
        ROLLBACK
    END
END
