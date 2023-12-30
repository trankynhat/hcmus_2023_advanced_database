CREATE PROCEDURE ManageEmployeeInformation
    @employee_id INT,
    @employee_name NVARCHAR(100),
    @department_id INT,
    @operation_type NVARCHAR(10)  -- 'INSERT' or 'UPDATE'
AS
BEGIN
    IF EXISTS (SELECT 1 FROM UserRoles WHERE user_id = @employee_id AND role = 'ADMIN')
    BEGIN
        IF @operation_type = 'INSERT'
        BEGIN
            -- Thêm thông tin mới của nhân viên
            INSERT INTO EmployeeTable (employee_id, employee_name, department_id)
            VALUES (@employee_id, @employee_name, @department_id)
            
            PRINT 'Thông tin nhân viên được thêm thành công.'
        END
        ELSE IF @operation_type = 'UPDATE'
        BEGIN
            -- Cập nhật thông tin nhân viên đã tồn tại
            UPDATE EmployeeTable
            SET employee_name = @employee_name,
                department_id = @department_id
            WHERE employee_id = @employee_id
            
            PRINT 'Thông tin nhân viên được cập nhật thành công.'
        END
        ELSE
        BEGIN
            PRINT 'Loại thao tác không hợp lệ. Sử dụng ''INSERT'' hoặc ''UPDATE''.'
        END
    END
    ELSE
    BEGIN
        PRINT 'Truy cập bị từ chối. Chỉ có quản trị viên mới có thể quản lý thông tin nhân viên.'
    END
END