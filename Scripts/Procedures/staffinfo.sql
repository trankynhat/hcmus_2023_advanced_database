CREATE PROCEDURE get_staff_info
    @p_user_id INT
AS
BEGIN
    DECLARE @user_role VARCHAR(20);

    -- Lấy vai trò của người dùng
    SELECT @user_role = get_user_role(@p_user_id);

    -- Kiểm tra xem người dùng có quyền Admin, Nha sĩ hoặc Nhân viên không
    IF @user_role NOT IN ('ADMIN', 'DENTIST', 'STAFF')
    BEGIN
        THROW 50000, 'You do not have access to view staff information', 1;
        RETURN;
    END

    -- Lấy thông tin nhân viên
    SELECT
        u.username,
        u.full_name,
        u.date_of_birth,
        u.phone_number,
        u.email,
        u.permanent_address,
        u.gender,
        s.jon_position
    FROM
        [user] u
    JOIN
        staff s ON u.id = s.user_id;
END;

begin
DECLARE @user_id INT = 1;

EXECUTE get_staff_info @p_user_id = @user_id;
end

--

CREATE PROCEDURE AddStaffMember
    @username VARCHAR(50),
    @password VARCHAR(300),
    @full_name NVARCHAR(150),
    @date_of_birth DATE,
    @phone_number VARCHAR(40),
    @email VARCHAR(50),
    @permanent_address NVARCHAR(200),
    @gender BIT,
    @working_branch_id INT,
    @job_position NVARCHAR(100),
    @p_user_id INT
AS
BEGIN
    DECLARE @user_role VARCHAR(20);

    -- Gọi hàm để lấy vai trò của người dùng
    SET @user_role = dbo.get_user_role(@p_user_id);

    -- Kiểm tra vai trò của người dùng
    IF @user_role NOT IN ('ADMIN' )
    BEGIN
        THROW 50000, 'You do not have access to add staff members', 1;
        RETURN;
    END

    -- Thêm thông tin người dùng mới vào bảng [user]
    INSERT INTO [user] (username, password, full_name, date_of_birth, phone_number, email, permanent_address, gender, working_branch_id)
    VALUES (@username, @password, @full_name, @date_of_birth, @phone_number, @email, @permanent_address, @gender, @working_branch_id);

    -- Lấy user_id của người dùng mới thêm
    DECLARE @user_id INT = SCOPE_IDENTITY();

    -- Thêm thông tin nhân viên vào bảng staff
    INSERT INTO staff (user_id, jon_position)
    VALUES (@user_id, @job_position);

    PRINT 'Staff member added successfully.';
END;
GO

--test

DECLARE @username VARCHAR(50) = 'new_staff_username';
DECLARE @password VARCHAR(300) = 'new_staff_password';
DECLARE @full_name NVARCHAR(150) = 'New Staff Name';
DECLARE @date_of_birth DATE = '1990-01-01'; -- Đặt ngày sinh theo định dạng YYYY-MM-DD
DECLARE @phone_number VARCHAR(40) = '123456789';
DECLARE @email VARCHAR(50) = 'new_staff@email.com';
DECLARE @permanent_address NVARCHAR(200) = 'New Staff Address';
DECLARE @gender BIT = 1; -- 1 là nam, 0 là nữ
DECLARE @working_branch_id INT = 1; -- Đặt id của chi nhánh làm việc
DECLARE @job_position NVARCHAR(100) = 'New Staff Position';
DECLARE @p_user_id INT = 1; -- Đặt id của người dùng thực hiện hành động


EXECUTE AddStaffMember
    @username,
    @password,
    @full_name,
    @date_of_birth,
    @phone_number,
    @email,
    @permanent_address,
    @gender,
    @working_branch_id,
    @job_position,
    @p_user_id;












	CREATE PROCEDURE UpdateStaffMember
    @user_id INT,
    @username VARCHAR(50),
    @password VARCHAR(300),
    @full_name NVARCHAR(150),
    @date_of_birth DATE,
    @phone_number VARCHAR(40),
    @email VARCHAR(50),
    @permanent_address NVARCHAR(200),
    @gender BIT,
    @working_branch_id INT,
    @job_position NVARCHAR(100),
    @p_user_id INT
AS
BEGIN
    DECLARE @user_role VARCHAR(20);

    -- Gọi hàm để lấy vai trò của người dùng
    SET @user_role = dbo.get_user_role(@p_user_id);

    -- Kiểm tra vai trò của người dùng
    IF @user_role NOT IN ('ADMIN')
    BEGIN
        THROW 50000, 'You do not have access to update staff members', 1;
        RETURN;
    END

    -- Cập nhật thông tin người dùng trong bảng [user]
    UPDATE [user]
    SET
        username = @username,
        password = @password,
        full_name = @full_name,
        date_of_birth = @date_of_birth,
        phone_number = @phone_number,
        email = @email,
        permanent_address = @permanent_address,
        gender = @gender,
        working_branch_id = @working_branch_id
    WHERE id = @user_id;

    -- Cập nhật thông tin nhân viên trong bảng staff
    UPDATE staff
    SET jon_position = @job_position
    WHERE user_id = @user_id;

    PRINT 'Staff member updated successfully.';
END;
GO
------------------------------test
-- Đặt các giá trị tham số cho việc cập nhật thông tin nhân viên
DECLARE @user_id INT = 1; -- Đặt id của nhân viên cần cập nhật
DECLARE @username VARCHAR(50) = 'updated_staff_username';
DECLARE @password VARCHAR(300) = 'updated_staff_password';
DECLARE @full_name NVARCHAR(150) = 'Updated Staff Name';
DECLARE @date_of_birth DATE = '1995-01-01'; -- Đặt ngày sinh theo định dạng YYYY-MM-DD
DECLARE @phone_number VARCHAR(40) = '987654321';
DECLARE @email VARCHAR(50) = 'updated_staff@email.com';
DECLARE @permanent_address NVARCHAR(200) = 'Updated Staff Address';
DECLARE @gender BIT = 0; -- 1 là nam, 0 là nữ
DECLARE @working_branch_id INT = 2; -- Đặt id của chi nhánh làm việc mới
DECLARE @job_position NVARCHAR(100) = 'Updated Staff Position';
DECLARE @p_user_id INT = 1; -- Đặt id của người dùng thực hiện hành động

-- Thực hiện stored procedure
EXECUTE UpdateStaffMember
    @user_id,
    @username,
    @password,
    @full_name,
    @date_of_birth,
    @phone_number,
    @email,
    @permanent_address,
    @gender,
    @working_branch_id,
    @job_position,
    @p_user_id;
