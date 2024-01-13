CREATE PROCEDURE create_appointment
    @p_patient_name NVARCHAR(150),
    @p_appointment_date DATE,
    @p_ordinal INT,
    @p_note NVARCHAR(200),
    @p_clinic_id INT,
    @p_dentist_id INT,
    @p_medical_assistant_id INT
AS
BEGIN
    DECLARE @user_role VARCHAR(20);

    -- Call the function to get the user role
    SET @user_role = dbo.get_user_role(@p_dentist_id);

    IF @user_role NOT IN ('ADMIN')
    BEGIN
        THROW 50000, 'You do not have access to create a new appointment', 1;
        RETURN;
    END

    -- Check if the appointment date and ordinal combination is unique
    IF NOT EXISTS (
        SELECT 1
        FROM appointment_schedule
        WHERE appointment_date = @p_appointment_date
          AND ordinal = @p_ordinal
    )
    BEGIN
        -- Insert the new appointment
        INSERT INTO appointment_schedule (patient_name, appointment_date, ordinal, note, clinic_id, dentist_id, medical_assistant_id)
        VALUES (@p_patient_name, @p_appointment_date, @p_ordinal, @p_note, @p_clinic_id, @p_dentist_id, @p_medical_assistant_id);

        PRINT 'New appointment created successfully';
    END
    ELSE
    BEGIN
        THROW 50001, 'Appointment date and ordinal combination is not unique', 1;
        RETURN;
    END
END;
GO
