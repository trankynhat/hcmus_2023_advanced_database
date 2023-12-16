-- Xem danh sách bệnh nhân
CREATE PROC xem_danh_sach_benh_nhan(@search_text NVARCHAR(150))
AS
BEGIN
    SELECT citizen_id, full_name, phone_number, gender, email, date_of_birth, permanent_address, general_info_about_oral_health, note
    FROM patient_record
    WHERE (
        @search_text IS NULL 
        OR citizen_id LIKE '%' + @search_text + '%'
        OR full_name LIKE '%' + @search_text + '%'
        OR phone_number LIKE '%' + @search_text + '%'
        OR email LIKE '%' + @search_text + '%'
    ) AND is_deleted = 0
END
GO

-- Xem chi tiết bệnh nhân
CREATE PROC xem_chi_tiet_benh_nhan(@citizen_id NVARCHAR(150))
AS
BEGIN
    SELECT TOP 1 citizen_id, full_name, phone_number, gender, email, date_of_birth, permanent_address, general_info_about_oral_health, note
    FROM patient_record
    WHERE citizen_id = @citizen_id
END
GO

-- Thêm bệnh nhân
CREATE PROC them_benh_nhan
    @citizen_id VARCHAR(50),
    @full_name NVARCHAR(200),
    @phone_number CHAR(12),
    @gender INT,
    @email VARCHAR(50),
    @date_of_birth DATE,
    @permanent_address NVARCHAR(500),
    @general_info_about_oral_health NVARCHAR(1000),
    @note NVARCHAR(500)
AS
BEGIN
    -- Kiểm tra Id
    IF EXISTS (SELECT *
    FROM patient_record
    WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'ID CONG DAN DA TON TAI TRONG HE THONG'
        RETURN
    END

    -- Kiểm tra sđt
    IF EXISTS (SELECT *
    FROM patient_record
    WHERE phone_number = @phone_number)
    BEGIN
        PRINT 'SO DIEN THOAI DA TON TAI TRONG HE THONG'
        RETURN
    END

    -- Kiểm tra email
    IF EXISTS (SELECT *
    FROM patient_record
    WHERE email = @email)
    BEGIN
        PRINT 'EMAIL DA TON TAI TRONG HE THONG'
        RETURN
    END

    INSERT INTO patient_record
    VALUES
        (@citizen_id, @full_name, @phone_number, @gender, @email, @date_of_birth, @permanent_address, @general_info_about_oral_health, @note)
END
GO

-- Cập nhật bệnh nhân
CREATE PROC cap_nhat_benh_nhan
    @citizen_id VARCHAR(50),
    @full_name NVARCHAR(200),
    @phone_number CHAR(12),
    @gender INT,
    @email VARCHAR(50),
    @date_of_birth DATE,
    @permanent_address NVARCHAR(500),
    @general_info_about_oral_health NVARCHAR(1000),
    @note NVARCHAR(500)
AS
BEGIN
    -- Kiểm tra Id
    IF NOT EXISTS (SELECT *
    FROM patient_record
    WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY HO SO CUA BENH NHAN'
        RETURN
    END

    UPDATE patient_record SET 
        full_name = @full_name,
        phone_number = @phone_number,
        gender = @gender,
        email = @email,
        date_of_birth = @date_of_birth,
        permanent_address = @permanent_address,
        general_info_about_oral_health = @general_info_about_oral_health,
        note = @note
    WHERE citizen_id = @citizen_id
END
GO

-- Thêm thông tin chống chỉ định thuốc của bệnh nhân
CREATE PROC them_tt_chong_chi_dinh_thuoc_benh_nhan
    @citizen_id VARCHAR(50),
    @drug_code VARCHAR(20),
    @note NVARCHAR(250)
AS
BEGIN
    IF NOT EXISTS (SELECT *
    FROM drug
    WHERE drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN THUOC'
        RETURN
    END

    IF NOT EXISTS (SELECT *
    FROM patient_record
    WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CUA BENH NHAN'
        RETURN
    END

    INSERT INTO drug_contraindication_info
        (citizen_id, drug_code, note)
    VALUES
        (@citizen_id, @drug_code, @note)
END
GO

-- Xoá thông tin chống chỉ định thuốc của bệnh nhân
CREATE PROC xoa_tt_chong_chi_dinh_thuoc_benh_nhan
    @citizen_id VARCHAR(50),
    @drug_code VARCHAR(20)
AS
BEGIN
    IF NOT EXISTS (SELECT *
    FROM drug_contraindication_info
    WHERE citizen_id = @citizen_id AND drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CHONG CHI DINH THUOC CUA BENH NHAN'
        RETURN
    END

    DELETE FROM drug_contraindication_info WHERE citizen_id = @citizen_id AND drug_code = @drug_code
END
GO

-- Chỉnh sửa thông tin chống chỉ định thuốc của bệnh nhân
CREATE PROC cap_nhat_tt_chong_chi_dinh_thuoc_benh_nhan
    @citizen_id VARCHAR(50),
    @drug_code VARCHAR(20),
    @note NVARCHAR(250)
AS
BEGIN
    IF NOT EXISTS (SELECT *
    FROM drug
    WHERE drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN THUOC'
        RETURN
    END

    IF NOT EXISTS (SELECT *
    FROM patient_record
    WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CUA BENH NHAN'
        RETURN
    END

    IF NOT EXISTS (SELECT *
    FROM drug_contraindication_info
    WHERE citizen_id = @citizen_id AND drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CHONG CHI DINH THUOC CUA BENH NHAN'
        RETURN
    END

    UPDATE drug_contraindication_info SET note = @note WHERE citizen_id = @citizen_id AND drug_code = @drug_code
END
GO

-- Cập nhật thông tin tình trạng sức khỏe răng miệng của bệnh nhân
CREATE PROC cap_nhat_tinh_trang_suc_khoe_rang_mieng_cua_benh_nhan
    @citizen_id VARCHAR(50),
    @general_info_about_oral_health NVARCHAR(1000) NULL
AS
BEGIN
    IF NOT EXISTS (SELECT *
    FROM patient_record
    WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CUA BENH NHAN'
        RETURN
    END

    UPDATE patient_record
    SET general_info_about_oral_health = @general_info_about_oral_health
    WHERE citizen_id = @citizen_id
END
GO



-- Xem các kế hoạch điều trị của bệnh nhân
CREATE PROC xem_ds_ke_hoach_dieu_tri_cua_benh_nhan
    @record_id VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM treatment_plan
    WHERE record_id = @record_id
END
GO

-- Thêm kế hoạch điều trị của bệnh nhân: Việc thêm kế hoạch đều trị sẽ gồm 3 bước: 
-- Chọn liệu trình (Select Treatment), 
-- Chọn răng (Select Tooth) 
-- Xem lại thông tin điều trị (Review Treatment Information):
-- Tại bước chọn liệu trình (treatment), nhân viên sẽ thực hiện chọn 
-- ngày điều trị, 
-- chọn bác sĩ và 
-- trợ khám (nếu có), và 
-- chọn danh mục điều trị. 
-- Sau khi chọn danh mục điều trị, phầm mềm sẽ hiển thị tiếp các mã điều trị nằm trong danh mục đó để người dùng lựa chọn.

-- insert treatment_plan
CREATE PROC them_ds_ke_hoach_dieu_tri_cua_benh_nhan
    @treatment_date DATE,
    @dentist_id INT,
    @medical_assistant_id INT NULL,
    @treatment_type_id INT,
    -- Chọn được liệu trình -> treatment_id

    @treatment_plan_status_id INT,
    @citizen_id INT
AS
BEGIN
    IF NOT EXISTS (SELECT user_id
    FROM dentist
    WHERE user_id = @dentist_id)
    BEGIN
        PRINT 'KHONG TIM THAY NHA SI'
        RETURN
    END

    IF @medical_assistant_id IS NOT NULL AND NOT EXISTS (SELECT user_id
        FROM dentist
        WHERE user_id = @medical_assistant_id)
    BEGIN
        PRINT 'KHONG TIM THAY TRO KHAM'
        RETURN
    END

    IF NOT EXISTS (SELECT citizen_id
    FROM patient_record
    WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY HO SO BENH NHAN'
        RETURN
    END

    IF NOT EXISTS (SELECT id
    FROM treatment_type
    WHERE id = @treatment_type_id)
    BEGIN
        PRINT 'KHONG TIM THAY DANH MUC DIEU TRI'
        RETURN
    END

-- INSERT INTO treatment_plan
--     (id, description, treatment_type_id)
-- VALUES(1,  @description,  @treatment_type_id, )


END
GO