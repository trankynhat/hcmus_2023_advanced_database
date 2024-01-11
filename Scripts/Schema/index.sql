-- Table: USER
-- Column: username
-- Purpose: Increase login speed when querying by username
-- Procs/Funcs: get_user_info
CREATE INDEX idx_user__username ON [user] (username)

-- Table: patient_record
-- Column: citizen_id, full_name, phone_number, email
-- Purpose: Increase search speed
-- Procs/Funcs: xem_danh_sach_benh_nhan, them_benh_nhan
CREATE INDEX idx_patient_record__email ON patient_record (email)
CREATE INDEX idx_patient_record__full_name ON patient_record (full_name)
CREATE INDEX idx_patient_record__phone_number ON patient_record (phone_number)
CREATE INDEX idx_patient_record__is_deleted ON patient_record (is_deleted)

-- Table: drug_contraindication_info
-- Column: is_deleted
-- Purpose: Increase loading speed, prioritize reading
-- Procs/Funcs:
CREATE INDEX idx_drug_contraindication_info__is_deleted ON drug_contraindication_info (is_deleted)

-- Table: drug
-- Column: is_deleted, name
-- Purpose: Increase loading speed, prioritize reading
-- Procs/Funcs: delete_drug, list_of_drugs, search_drugs
CREATE INDEX idx_drug__is_deleted ON drug (is_deleted)
CREATE INDEX idx_drug__name ON drug (name)


----- Procedures do not prioritize index creation -----------------------------------------------------------------------------------------------------------------------------
-- get_treatment_report
-- get_appointment_report