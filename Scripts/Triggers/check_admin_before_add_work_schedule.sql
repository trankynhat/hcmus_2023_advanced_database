CREATE TRIGGER tr_CheckAdminBeforeAddWorkSchedule
ON work_timetable
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @admin_id INT
    DECLARE @user_role VARCHAR(20)

    -- Lấy thông tin về người thực hiện thêm lịch
    SELECT TOP 1 @admin_id = i.dentist_id
    FROM INSERTED i

    -- Sử dụng hàm get_user_role để kiểm tra quyền truy cập
    SET @user_role = dbo.get_user_role(@admin_id)

    -- Kiểm tra quyền truy cập của người thực hiện thêm lịch
    IF @user_role <> 'ADMIN'
    BEGIN
        -- Nếu không phải là quản trị viên, thông báo lỗi và hủy bỏ thêm lịch
        THROW 50000, 'Truy cập bị từ chối. Chỉ có quản trị viên mới có thể thêm lịch làm việc cho nha sĩ.', 1;
    END
    ELSE
    BEGIN
        -- Nếu là quản trị viên, thực hiện thêm lịch làm việc
        INSERT INTO work_timetable (dentist_id, branch_id)
        SELECT dentist_id, branch_id
        FROM INSERTED
    END
END