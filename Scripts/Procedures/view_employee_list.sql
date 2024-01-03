CREATE PROCEDURE ViewEmployeeList
    @user_id INT,
    @user_role NVARCHAR(20)
AS
BEGIN
    IF @user_role IN ('ADMIN', 'STAFF', 'DENTIST')
    BEGIN
        IF @user_role = 'ADMIN'
        BEGIN
            -- Xem danh sách toàn bộ nhân viên
            SELECT * FROM EmployeeTable
        END
        ELSE IF @user_role = 'STAFF'
        BEGIN
            -- Xem danh sách nhân viên chỉ trong phòng làm việc của nhân viên
            SELECT * FROM EmployeeTable WHERE department_id = (SELECT department_id FROM StaffTable WHERE user_id = @user_id)
        END
        ELSE IF @user_role = 'DENTIST'
        BEGIN
            -- Xem danh sách nhân viên trong phòng nha sĩ
            SELECT * FROM EmployeeTable WHERE department_id = (SELECT department_id FROM DentistTable WHERE user_id = @user_id)
        END
    END
    ELSE
    BEGIN
        PRINT 'Truy cập bị từ chối. Bạn không có quyền xem danh sách nhân viên.'
    END
END