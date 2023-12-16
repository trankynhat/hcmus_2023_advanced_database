CREATE TABLE drug (
    code VARCHAR(20),
    name NVARCHAR(150),
    description NVARCHAR(250),
    price_unit NVARCHAR(10),
    price_per_unit FLOAT,
    is_deleted BIT NOT NULL DEFAULT 0,

	CONSTRAINT PK_drug PRIMARY KEY(code)
)
GO

CREATE TABLE drug_contraindication_info (
    record_id VARCHAR(50) NOT NULL,
    drug_code VARCHAR(20) NOT NULL,
    note NVARCHAR(250),

	CONSTRAINT PK_drug_contraindication_info PRIMARY KEY(record_id, drug_code)
)
GO

CREATE TABLE payment(
    id INT IDENTITY(0, 1),
    total_treatment_fee FLOAT,
    date_of_payment DATE,
    change FLOAT,
    note NVARCHAR(250),
    payment_method_code VARCHAR(50),

	CONSTRAINT PK_payment PRIMARY KEY(id) 
)
GO

CREATE TABLE payment_method (
    code VARCHAR(50),
    name NVARCHAR(150),
    [desc] NVARCHAR(2500),

	CONSTRAINT	PK_payment_method PRIMARY KEY(code)
)
GO

CREATE TABLE prescription(
	treatment_id INT NOT NULL,
	drug_code VARCHAR(20),

	CONSTRAINT PK_prescription PRIMARY KEY(treatment_id, drug_code)
)

CREATE TABLE patient_record(
    citizen_id VARCHAR(50),
    full_name NVARCHAR(200) NOT NULL,
    phone_number CHAR(12) NOT NULL,
    gender BIT NOT NULL,
    email VARCHAR(50) NULL,
    date_of_birth DATE NULL,
    permanent_address NVARCHAR(500) NULL,
    general_info_about_oral_health NVARCHAR(1000) NULL,
    note NVARCHAR(500) NULL,
    is_deleted BIT DEFAULT 0,

    CONSTRAINT PK_patient_record PRIMARY KEY (citizen_id)
)
GO

CREATE TABLE treatment(
    id INT IDENTITY(0, 1),
    description NVARCHAR(500) NULL,
    treatment_fee BIGINT NOT NULL DEFAULT 0,
    treatment_date DATE NOT NULL,
    payment_method_code VARCHAR(50) NOT NULL,
    payment_id INT NULL,
    dentist_id INT NOT NULL,

    CONSTRAINT CHK_treatment__treatment_fee CHECK (treatment_fee >= 0),
    CONSTRAINT PK_treatment PRIMARY KEY (id)
)
GO

CREATE TABLE single_treatment(
    treatment_id INT NOT NULL,
    record_id VARCHAR(50) NOT NULL,

    CONSTRAINT PK_single_treatment PRIMARY KEY (treatment_id)
)
GO

CREATE TABLE treatment_plan(
    id INT IDENTITY(0, 1),
    description NVARCHAR(500) NULL,
    note NVARCHAR(200) NULL,
    treatment_plan_status_id INT NOT NULL,
    treatment_type_id INT NOT NULL,
    record_id VARCHAR(50) NOT NULL,
    
    CONSTRAINT PK_treatment_plan PRIMARY KEY (id)
)
GO

CREATE TABLE treatment_phase(
    treatment_id INT NOT NULL,
    treatment_plan_id INT NOT NULL,

    CONSTRAINT PK_treatment_phase PRIMARY KEY (treatment_id)
)
GO

CREATE TABLE treatment_plan_status(
    id INT IDENTITY(0, 1),
    name NVARCHAR(50) NOT NULL,
    [desc] NVARCHAR(100) NOT NULL,
    symbolic_color CHAR(7) NOT NULL,

    CONSTRAINT PK_treatment_plan_status PRIMARY KEY (id)
)
GO

CREATE TABLE treatment_type(
    id INT IDENTITY(0, 1),
    name NVARCHAR(50) NOT NULL,
    [desc] NVARCHAR(100) NOT NULL,
    treatment_category_id INT NOT NULL,

    CONSTRAINT PK_treatment_type PRIMARY KEY (id)
)
GO

CREATE TABLE treatment_category(
    id INT IDENTITY(0, 1),
    name NVARCHAR(50) NOT NULL,
    [desc] NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_treatment_category PRIMARY KEY (id)
)
GO

CREATE TABLE tool_information(
    id INT IDENTITY(0, 1),
    note NVARCHAR(200) NOT NULL,
    condition NVARCHAR(200) NOT NULL,
    treatment_activity NVARCHAR(500) NOT NULL,
    treatment_id INT NOT NULL,
    tooth_number INT NOT NULL,
    tooth_surface_code CHAR(1) NOT NULL,

    CONSTRAINT PK_tool_information PRIMARY KEY (id)
)
GO

CREATE TABLE tooth_surface(
    code CHAR(1),
    name NVARCHAR(50) NOT NULL,
    [desc] NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_tooth_surface PRIMARY KEY (code)
)
GO

CREATE TABLE tooth(
    tooth_number INT,
    name NVARCHAR(50) NOT NULL,
    [desc] NVARCHAR(100) NOT NULL,

    CONSTRAINT PK_tooth PRIMARY KEY (tooth_number)
)
GO

CREATE TABLE work_timetable (
	id INT IDENTITY(0, 1),
	dentist_id INT NOT NULL,
	branch_id INT NOT NULL,

    CONSTRAINT PK_work_timetable PRIMARY KEY (id)
)
GO

CREATE TABLE shift (
	id INT IDENTITY(0, 1) NOT NULL,
	start_time TIME NOT NULL,
	end_time TIME NOT NULL,
	work_timetable_id INT NOT NULL,

	CONSTRAINT PK_shift PRIMARY KEY (id),
	CONSTRAINT UNQ_shift UNIQUE (start_time, end_time, work_timetable_id)
)
GO

CREATE TABLE individual_timetable (
	work_timetable_id INT NOT NULL,
	date DATE NOT NULL,

	CONSTRAINT PK_individual_timetable PRIMARY KEY (work_timetable_id, date)
)
GO

CREATE TABLE week_timetable (
	work_timetable_id INT NOT NULL,
	start_date DATE NOT NULL,
	end_date DATE NOT NULL,

	CONSTRAINT PK_week_timetable PRIMARY KEY (work_timetable_id),
	CONSTRAINT UNQ_week_timetable UNIQUE (start_date, end_date, work_timetable_id)
)
GO

CREATE TABLE weekday_timetable (
	week_timetable_id INT NOT NULL,
	weekday int NOT NULL,

	CONSTRAINT CHK_weekday_timetable__weekday CHECK (weekday >=2 or weekday <= 8),
	CONSTRAINT PK_weekday_timetable PRIMARY KEY (week_timetable_id, weekday)
)
GO

CREATE TABLE month_timetable (
	work_timetable_id INT NOT NULL,
	start_date DATE NOT NULL,
	end_date DATE NOT NULL,

	CONSTRAINT PK_month_timetable PRIMARY KEY (work_timetable_id),
	CONSTRAINT UNQ_month_timetable UNIQUE (start_date, end_date, work_timetable_id)
)
GO


CREATE TABLE day_in_month_timetable (
	month_timetable_id INT NOT NULL,
	day_in_month INT NOT NULL,

	CONSTRAINT CHK_day_in_month_timetable__day_in_month CHECK (day_in_month > 0 or day_in_month < 32),
	CONSTRAINT PK_day_in_month_timetable PRIMARY KEY (month_timetable_id, day_in_month)
)
GO

CREATE TABLE [user](
    id INT IDENTITY(0, 1),
    username VARCHAR(50) NOT NULL,
    password VARCHAR(300) NOT NULL,
    full_name NVARCHAR(150) NOT NULL,
    date_of_birth DATE NOT NULL,
    phone_number CHAR(11) NOT NULL,
    email VARCHAR(50) NOT NULL,
    permanent_address NVARCHAR(200) NULL,
    gender BIT NOT NULL,
	working_branch_id INT NOT NULL,

    CONSTRAINT PK_user PRIMARY KEY (id)
)
GO

CREATE TABLE branch(
	id INT IDENTITY(0, 1),
    admin_id INT NULL,
	address NVARCHAR(150) NOT NULL,

    CONSTRAINT PK_branch PRIMARY KEY (id)
)
GO

CREATE TABLE clinic(
    clinic_id INT IDENTITY(0, 1),
    branch_id INT NOT NULL,
	clinic_number INT NOT NULL,

    CONSTRAINT PK_clinic PRIMARY KEY (clinic_id),
    CONSTRAINT UNQ_clinic__branch_id__clinic_number UNIQUE(branch_id, clinic_number)
)
GO

CREATE TABLE staff(
    user_id INT NOT NULL,
    jon_position NVARCHAR(100) NOT NULL,
    
    CONSTRAINT PK_staff PRIMARY KEY (user_id)
)
GO

CREATE TABLE dentist(
    user_id INT NOT NULL,
    medical_practice_certificate_code VARCHAR(50) NOT NULL,

    CONSTRAINT PK_dentist PRIMARY KEY (user_id),
    CONSTRAINT UNQ_dentist__medical_practice_certificate_code UNIQUE(medical_practice_certificate_code)
)
GO

CREATE TABLE appointment_schedule(
    appointment_date DATE NOT NULL,
    ordinal INT NOT NULL,
    patient_name NVARCHAR(150) NOT NULL,
    note NVARCHAR(200) NOT NULL,
	record_id VARCHAR(50) NOT NULL,
	clinic_id INT NOT NULL,
	dentist_id INT NOT NULL,
	medical_assistant_id INT NOT NULL,

    CONSTRAINT PK_appointment_shedule PRIMARY KEY (appointment_date, ordinal)
)
GO

CREATE TABLE medical_assistant (
    treatment_id INT NOT NULL,
    dentist_id INT NOT NULL,

    CONSTRAINT PK_medical_assistant PRIMARY KEY(treatment_id, dentist_id)
)

ALTER TABLE medical_assistant
ADD CONSTRAINT FK_medical_assistant__dentist_id__dentist__user_id
FOREIGN KEY (treatment_id) REFERENCES dentist(user_id)
GO

ALTER TABLE medical_assistant
ADD CONSTRAINT FK_medical_assistant__treatment_id__treatment__id
FOREIGN KEY (treatment_id) REFERENCES treatment(id)
GO

-- treatment

ALTER TABLE treatment
ADD CONSTRAINT FK_treatment__payment_method_code__payment_method__code
FOREIGN KEY (payment_method_code) REFERENCES payment_method(code)
GO

ALTER TABLE treatment
ADD CONSTRAINT FK_treatment__payment_id__payment__id
FOREIGN KEY (payment_id) REFERENCES payment(id)
GO

ALTER TABLE treatment
ADD CONSTRAINT FK_treatment__dentist_id__dentist__user_id
FOREIGN KEY (dentist_id) REFERENCES dentist(user_id)
GO

-- single treatment

ALTER TABLE single_treatment
ADD CONSTRAINT FK_single_treatment__record_id__patient_record__citizen_id
FOREIGN KEY (record_id) REFERENCES patient_record(citizen_id)
GO

ALTER TABLE single_treatment
ADD CONSTRAINT FK_single_treatment__treatment_id__treatment__id
FOREIGN KEY (treatment_id) REFERENCES treatment(id)
GO

-- treatment plan

ALTER TABLE treatment_plan
ADD CONSTRAINT FK_treatment_plan__record_id__patient_record__citizen_id
FOREIGN KEY (record_id) REFERENCES patient_record(citizen_id)
GO

ALTER TABLE treatment_plan
ADD CONSTRAINT FK_treatment_plan__treatment_plan_status_id__treatment_plan_status__id
FOREIGN KEY (treatment_plan_status_id) REFERENCES treatment_plan_status(id)
GO

ALTER TABLE treatment_plan
ADD CONSTRAINT FK_treatment_plan__treatment_type_id__treatment_type__id
FOREIGN KEY (treatment_type_id) REFERENCES treatment_type(id)
GO

-- treatment phase

ALTER TABLE treatment_phase
ADD CONSTRAINT FK_treatment_phase__treatment_id__treatment__id
FOREIGN KEY (treatment_id) REFERENCES treatment(id)
GO

ALTER TABLE treatment_phase
ADD CONSTRAINT FK_treatment_phase__treatment_plan_id__treatment_plan__id
FOREIGN KEY (treatment_plan_id) REFERENCES treatment_plan(id)
GO

-- treatment type

ALTER TABLE treatment_type
ADD CONSTRAINT FK_treatment_type__treatment_category_id__treatment_category__id
FOREIGN KEY (treatment_category_id) REFERENCES treatment_category(id)
GO

-- tool information

ALTER TABLE tool_information
ADD CONSTRAINT FK_tool_information__treatment_id__treatment__id
FOREIGN KEY (treatment_id) REFERENCES treatment(id)
GO

ALTER TABLE tool_information
ADD CONSTRAINT FK_tool_information__tooth_number__tooth__tooth_number
FOREIGN KEY (tooth_number) REFERENCES tooth(tooth_number)
GO

ALTER TABLE tool_information
ADD CONSTRAINT FK_tool_information__tooth_surface_code__tooth_surface__code
FOREIGN KEY (tooth_surface_code) REFERENCES tooth_surface(code)
GO

ALTER TABLE shift
ADD CONSTRAINT FK_shift__work_timetable_id__work_timetable__id
FOREIGN KEY (work_timetable_id) REFERENCES work_timetable(id)
GO

ALTER TABLE individual_timetable
ADD CONSTRAINT FK_individual_timetable__work_timetable_id__work_timetable__id
FOREIGN KEY (work_timetable_id) REFERENCES work_timetable(id)
GO

ALTER TABLE week_timetable
ADD CONSTRAINT FK_week_timetable__work_timetable_id__work_timetable__id
FOREIGN KEY (work_timetable_id) REFERENCES work_timetable(id)
GO

ALTER TABLE weekday_timetable
ADD CONSTRAINT FK_weekday_timetable__week_timetable_id__week_timetable__work_timetable_id
FOREIGN KEY (week_timetable_id) REFERENCES week_timetable(work_timetable_id)
GO

ALTER TABLE month_timetable
ADD CONSTRAINT FK_month_timetable__work_timetable_id__work_timetable__id
FOREIGN KEY (work_timetable_id) REFERENCES work_timetable(id)
GO

ALTER TABLE day_in_month_timetable
ADD CONSTRAINT FK_day_in_month_timetable__month_timetable_id__month_timetable__work_timetable_id
FOREIGN KEY (month_timetable_id) REFERENCES month_timetable(work_timetable_id)
GO

-- user

ALTER TABLE [user]
ADD CONSTRAINT FK_user__working_branch_id__branch__id
FOREIGN KEY (working_branch_id) REFERENCES branch(id)
GO


-- branch

ALTER TABLE branch
ADD CONSTRAINT FK_branch__admin_id__user__id
FOREIGN KEY (admin_id) REFERENCES [user](id)
GO


-- clinic

ALTER TABLE clinic
ADD CONSTRAINT FK_clinic__branch_id__branch__id
FOREIGN KEY (branch_id) REFERENCES branch(id)
GO


-- staff

ALTER TABLE staff
ADD CONSTRAINT FK_staff__user_id__user__id
FOREIGN KEY (user_id) REFERENCES [user](id)
GO


-- dentist

ALTER TABLE dentist
ADD CONSTRAINT FK_dentist__user_id__user__id
FOREIGN KEY (user_id) REFERENCES [user](id)
GO

-- appointment_schedule

ALTER TABLE appointment_schedule
ADD CONSTRAINT FK_appointment_schedule__dentist_id__dentist__user_id
FOREIGN KEY (dentist_id) REFERENCES dentist(user_id)
GO

ALTER TABLE appointment_schedule
ADD CONSTRAINT FK_appointment_schedule__medical_assistant_id__dentist__user_id
FOREIGN KEY (medical_assistant_id) REFERENCES dentist(user_id)
GO

ALTER TABLE appointment_schedule
ADD CONSTRAINT FK_appointment_schedule_clinic_id__clinic__clinic_id
FOREIGN KEY (clinic_id) REFERENCES clinic(clinic_id)
GO

ALTER TABLE appointment_schedule
ADD CONSTRAINT FK_appointment_schedule_record_id__patient_record__citizen_id
FOREIGN KEY (record_id) REFERENCES patient_record(citizen_id)
GO

ALTER TABLE drug_contraindication_info
ADD CONSTRAINT FK_drug_contraindication_info__drug_code__drug__code
FOREIGN KEY (drug_code) REFERENCES drug(code)

ALTER TABLE drug_contraindication_info
ADD CONSTRAINT FK_drug_contraindication_info__record_id__patient_record__citizen_id
FOREIGN KEY (record_id) REFERENCES patient_record(citizen_id)

ALTER TABLE prescription
ADD CONSTRAINT FK_prescription_drug__drug_code__drug__code
FOREIGN KEY (drug_code) REFERENCES drug(code)

ALTER TABLE prescription
ADD CONSTRAINT FK_prescription_drug__treatment_id__treatment__id
FOREIGN KEY (treatment_id) REFERENCES treatment(id)

ALTER TABLE payment
ADD CONSTRAINT FK_payment__payment_method_code__payment_method__code
FOREIGN KEY (payment_method_code) REFERENCES payment_method(code)

ALTER TABLE work_timetable
ADD CONSTRAINT FK_work_timetable__dentist_id__detist__user_id
FOREIGN KEY (dentist_id) REFERENCES dentist(user_id)

ALTER TABLE work_timetable
ADD CONSTRAINT FK_work_timetable__branch_id__branch__id
FOREIGN KEY (branch_id) REFERENCES branch(id)