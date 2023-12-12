-- Xem danh sách bệnh nhân
CREATE PROC XEM_DANH_SACH_BENH_NHAN
AS
BEGIN
    SELECT * FROM patient_record;
END;
GO

-- Thêm bệnh nhân
CREATE PROC THEM_BENH_NHAN
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
    IF EXISTS (SELECT * FROM patient_record WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'ID CONG DAN DA TON TAI TRONG HE THONG';
        RETURN;
    END

    -- Kiểm tra sđt
    IF EXISTS (SELECT * FROM patient_record WHERE phone_number = @phone_number)
    BEGIN
        PRINT 'SO DIEN THOAI DA TON TAI TRONG HE THONG';
        RETURN;
    END

    -- Kiểm tra email
    IF EXISTS (SELECT * FROM patient_record WHERE email = @email)
    BEGIN
        PRINT 'EMAIL DA TON TAI TRONG HE THONG';
        RETURN;
    END

    INSERT INTO patient_record 
    VALUES (@citizen_id, @full_name, @phone_number, @gender, @email, @date_of_birth, @permanent_address, @general_info_about_oral_health, @note);
END;
GO

-- Cập nhật bệnh nhân
CREATE PROC CAP_NHAT_BENH_NHAN
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
    IF NOT EXISTS (SELECT * FROM patient_record WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY HO SO CUA BENH NHAN';
        RETURN;
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
    WHERE citizen_id = @citizen_id;
END;
GO

-- Thêm thông tin chống chỉ định thuốc của bệnh nhân
CREATE PROC THEM_TT_CHONG_CHI_DINH_THUOC_BENH_NHAN
    @citizen_id VARCHAR(50),
    @drug_code VARCHAR(20),
    @note NVARCHAR(250)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM drug WHERE drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN THUOC';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM patient_record WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CUA BENH NHAN';
        RETURN;
    END

    INSERT INTO drug_contraindication_info (citizen_id, drug_code, note)
    VALUES (@citizen_id, @drug_code, @note);
END;
GO

-- Xoá thông tin chống chỉ định thuốc của bệnh nhân
CREATE PROC XOA_TT_CHONG_CHI_DINH_THUOC_BENH_NHAN
    @citizen_id VARCHAR(50),
    @drug_code VARCHAR(20)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM drug_contraindication_info WHERE citizen_id = @citizen_id AND drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CHONG CHI DINH THUOC CUA BENH NHAN';
        RETURN;
    END

    DELETE FROM drug_contraindication_info WHERE citizen_id = @citizen_id AND drug_code = @drug_code;
END;
GO

-- Chỉnh sửa thông tin chống chỉ định thuốc của bệnh nhân
CREATE PROC CAP_NHAT_TT_CHONG_CHI_DINH_THUOC_BENH_NHAN
    @citizen_id VARCHAR(50),
    @drug_code VARCHAR(20),
    @note NVARCHAR(250)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM drug WHERE drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN THUOC';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM patient_record WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CUA BENH NHAN';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM drug_contraindication_info WHERE citizen_id = @citizen_id AND drug_code = @drug_code)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CHONG CHI DINH THUOC CUA BENH NHAN';
        RETURN;
    END

    UPDATE drug_contraindication_info SET note = @note WHERE citizen_id = @citizen_id AND drug_code = @drug_code;
END;
GO

-- Cập nhật thông tin tình trạng sức khỏe răng miệng của bệnh nhân
CREATE PROC CAP_NHAT_TINH_TRANG_SUC_KHOE_RANG_MIENG_CUA_BENH_NHAN
    @citizen_id VARCHAR(50),
    general_info_about_oral_health NVARCHAR(1000) NULL,
AS
    IF NOT EXISTS (SELECT * FROM patient_record WHERE citizen_id = @citizen_id)
    BEGIN
        PRINT 'KHONG TIM THAY THONG TIN CUA BENH NHAN';
        RETURN;
    END

    UPDATE patient_record SET general_info_about_oral_health = @general_info_about_oral_health WHERE citizen_id = @citizen_id;
GO


-- Xem các kế hoạch điều trị của bệnh nhân
CREATE PROC XEM_DS_KE_HOACH_DIEU_TRI_CUA_BENH_NHAN
    @record_id VARCHAR(50),
AS
BEGIN
    SELECT * FROM treatment_plan WHERE @record_id = record_id;
END;
GO

-- Thêm kế hoạch điều trị của bệnh nhân
CREATE PROC THEM_DS_KE_HOACH_DIEU_TRI_CUA_BENH_NHAN
    @description NVARCHAR(500),
    @note NVARCHAR(200),
    @treatment_plan_status_id INT,
    @treatment_type_id INT,
    @record_id VARCHAR(50),
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM treatment_plan_status WHERE id = @treatment_plan_status_id)
    BEGIN
        PRINT 'KHONG TIM THAY TRANG THAI KE HOACH DIEU TRI';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM treatment_type WHERE i = @treatment_type_id)
    BEGIN
        PRINT 'KHONG TIM THAY LOAI DIEU TRI';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM patient_record WHERE record_id = @record_id)
    BEGIN
        PRINT 'KHONG TIM THAY HO SO BENH NHAN';
        RETURN;
    END

        INSERT INTO treatment_plan 
    VALUES (@description, @note, @treatment_plan_status_id, @treatment_type_id, @record_id);
END;
GO

-- Cập nhật kế hoạch điều trị của bệnh nhân
CREATE PROC THEM_DS_KE_HOACH_DIEU_TRI_CUA_BENH_NHAN
    @description NVARCHAR(500),
    @note NVARCHAR(200),
    @treatment_plan_status_id INT,
    @treatment_type_id INT,
    @record_id VARCHAR(50),
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM treatment_plan_status WHERE id = @treatment_plan_status_id)
    BEGIN
        PRINT 'KHONG TIM THAY TRANG THAI KE HOACH DIEU TRI';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM treatment_type WHERE i = @treatment_type_id)
    BEGIN
        PRINT 'KHONG TIM THAY LOAI DIEU TRI';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM patient_record WHERE record_id = @record_id)
    BEGIN
        PRINT 'KHONG TIM THAY HO SO BENH NHAN';
        RETURN;
    END

        UPDATE treatment_plan 
        SET
        description = @description
        note = @note
        treatment_plan_status_id = @treatment_plan_status_id
        treatment_type_id = @treatment_type_id
        WHERE record_id = @record_id
END;
GO