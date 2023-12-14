-- list_dentists_info
CREATE PROCEDURE list_dentist_infos
AS
    SELECT U.id, U.full_name
    FROM dentist D
    JOIN [user] U
    ON D.user_id = U.id
GO

-- get_treatment_report

CREATE PROCEDURE get_treatment_report(
    @user_id INT,
    @start_date DATE,
    @end_date DATE
)
AS
    SELECT id, description, treatment_fee, treatment_date, payment_method_code, payment_id, dentist_id
    FROM treatment
    WHERE dentist_id = @user_id AND treatment_date >= @start_date AND @start_date <= @end_date
GO

-- get_appointment_report

CREATE PROCEDURE get_appointment_report(
    @user_id INT,
    @start_date DATE,
    @end_date DATE
)
AS
    SELECT appointment_date, ordinal, patient_name, note, record_id, clinic_id, dentist_id, medical_assistant_id
    FROM appointment_schedule
    WHERE (
        dentist_id = @user_id 
        OR medical_assistant_id = @user_id
    ) AND appointment_date >= @start_date AND @start_date <= @end_date
GO