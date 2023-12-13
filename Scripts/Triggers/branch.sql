CREATE TRIGGER trg_branch__check_admin_id
ON branch
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @branch_id INT
    DECLARE @admin_id INT

    SELECT @branch_id = id, @admin_id = admin_id
    FROM inserted

    IF @admin_id IS NOT NULL
    BEGIN
        DECLARE @user_working_branch_id INT

        SELECT @user_working_branch_id = working_branch_id
        FROM [user]
        WHERE id = @admin_id

        IF @user_working_branch_id <> @branch_id
        BEGIN
            RAISERROR('Admin user does not belong to the specified working branch.', 16, 1)
            ROLLBACK
        END

        IF EXISTS(
            SELECT * FROM dentist WHERE user_id = @admin_id
        ) OR EXISTS(
            SELECT * FROM staff WHERE user_id = @admin_id
        )
        BEGIN
            RAISERROR('User can not have more than one role.', 16, 1)
            ROLLBACK
        END
    END
END
