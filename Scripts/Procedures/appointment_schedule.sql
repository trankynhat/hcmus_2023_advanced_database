USE CQ_CSDLNC_05
GO
-- show_appointment_in_date
CREATE OR ALTER PROC show_appointment_in_date (@branch_id INT, @date DATE)
AS
BEGIN
	-- Mỗi cuộc hẹn gồm thông tin về thời gian và tên bệnh nhân, nha sĩ, trợ khám, phòng khám, tình trạng
	-- Nhân viên được quyền thêm, điều chỉnh, xoá cuộc hẹn, nha sĩ chỉ được phép xem thông tin cuộc hẹn
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, apm_s.note, 
		apm_s.record_id, c.clinic_number, apm_s.dentist_id, apm_s.medical_assistant_id, apm_s.treatment_id
	FROM appointment_schedule apm_s inner join clinic c on apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date and c.branch_id = @branch_id
END
exec show_appointment_in_date @branch_id=1,@date='2024-01-07 00:00:00'
-- add_new_appointment
GO
CREATE PROC add_new_appontment (@user_id INT, 
								@appointment_date DATE, 
								@ordinal INT,
								@patient_name)
AS
BEGIN
	---- Nhân viên mới được quyền thêm
	---- Get role
	--DECLARE @user_role VARCHAR(20)
	--SET @user_role = dbo.get_user_role(@user_id)
	--IF @user_role = 'STAFF'
	--BEGIN 
		
	--END


END
GO

-- update_appointment
CREATE PROC update_appointment
AS
BEGIN
	-- Nhân viên mới được quyền chỉnh sửa
END


-- delete_appointment
CREATE PROC delete_appointment
AS
BEGIN 
	-- Nhân viên mới được quyền xoá
END


-- filter_appointment_by_patient
CREATE PROC filter_appointment_by_patient (@branch_id INT, @date DATE, @patient_name NVARCHAR(150))
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, u_dentist.full_name as dentist_name,
			 u_assist.full_name as assist_name, c.clinic_number, apm_s.treatment_id
	FROM appointment_schedule apm_s
		join dentist d on apm_s.dentist_id = d.user_id 
		join dentist d_assist on apm_s.dentist_id = d_assist.user_id 
		join [user] u_dentist on d.user_id = u_dentist.id
		join [user] u_assist on d_assist.user_id = u_assist.id
		join clinic c on apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date and c.branch_id = @branch_id and apm_s.patient_name LIKE ('%' + @patient_name + '%')
END


-- filter_appointment_by_clinic
CREATE PROC filter_appointment_by_clinic (@branch_id INT, @date DATE, @clinic_number INT)
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, u_dentist.full_name as dentist_name,
			 u_assist.full_name as assist_name, c.clinic_number, apm_s.treatment_id
	FROM appointment_schedule apm_s
		join dentist d on apm_s.dentist_id = d.user_id 
		join dentist d_assist on apm_s.dentist_id = d_assist.user_id 
		join [user] u_dentist on d.user_id = u_dentist.id
		join [user] u_assist on d_assist.user_id = u_assist.id
		join clinic c on apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date and c.branch_id = @branch_id and c.clinic_number = @clinic_number
END


-- filter_appointment_by_dentist
CREATE PROC filter_appointment_by_dentist (@branch_id INT, @date DATE, @dentist_name NVARCHAR(150))
AS
BEGIN
	SELECT apm_s.appointment_date, apm_s.ordinal, apm_s.patient_name, u_dentist.full_name as dentist_name,
			 u_assist.full_name as assist_name, c.clinic_number, apm_s.treatment_id
	FROM appointment_schedule apm_s
		join dentist d on apm_s.dentist_id = d.user_id 
		join dentist d_assist on apm_s.dentist_id = d_assist.user_id 
		join [user] u_dentist on d.user_id = u_dentist.id
		join [user] u_assist on d_assist.user_id = u_assist.id
		join clinic c on apm_s.clinic_id = c.clinic_id
	WHERE apm_s.appointment_date = @date and c.branch_id = @branch_id and u_dentist.full_name LIKE ('%' + @dentist_name + '%')
END

