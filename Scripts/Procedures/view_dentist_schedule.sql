CREATE PROCEDURE ViewDentistSchedule
    @user_id INT,
    @user_role NVARCHAR(20),
    @schedule_type NVARCHAR(10)  -- 'DAY', 'WEEK', 'MONTH'
AS
BEGIN
    IF @user_role IN ('ADMIN', 'STAFF', 'DENTIST')
    BEGIN
        IF @schedule_type = 'DAY'
        BEGIN
            -- Xem lịch trình làm việc theo ngày
            SELECT * FROM DentistScheduleTable WHERE dentist_id = @user_id AND schedule_date = CONVERT(DATE, GETDATE())
        END
        ELSE IF @schedule_type = 'WEEK'
        BEGIN
            -- Xem lịch trình làm việc theo tuần
            SELECT * FROM DentistScheduleTable WHERE dentist_id = @user_id AND DATEPART(WEEK, schedule_date) = DATEPART(WEEK, GETDATE())
        END
        ELSE IF @schedule_type = 'MONTH'
        BEGIN
            -- Xem lịch trình làm việc theo tháng
            SELECT * FROM DentistScheduleTable WHERE dentist_id = @user_id AND DATEPART(MONTH, schedule_date) = DATEPART(MONTH, GETDATE())
        END
        ELSE
        BEGIN
            PRINT 'Loại lịch không hợp lệ. Sử dụng ''DAY'', ''WEEK'' hoặc ''MONTH''.'
        END
    END
    ELSE
    BEGIN
        PRINT 'Truy cập bị từ chối. Bạn không có quyền xem lịch trình nha sĩ.'
    END
END
