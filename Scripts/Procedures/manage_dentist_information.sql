
CREATE PROCEDURE ManageDentistInformation
    @dentist_id INT,
    @dentist_name NVARCHAR(100),
    @specialization NVARCHAR(50),
    @operation_type NVARCHAR(10)  -- 'INSERT' or 'UPDATE'
AS
BEGIN
    IF EXISTS (SELECT 1 FROM UserRoles WHERE user_id = @dentist_id AND role = 'ADMIN')
    BEGIN
        IF @operation_type = 'INSERT'
        BEGIN
            -- Insert new dentist information
            INSERT INTO DentistTable (dentist_id, dentist_name, specialization)
            VALUES (@dentist_id, @dentist_name, @specialization)
            
            PRINT 'Dentist information added successfully.'
        END
        ELSE IF @operation_type = 'UPDATE'
        BEGIN
            -- Update existing dentist information
            UPDATE DentistTable
            SET dentist_name = @dentist_name,
                specialization = @specialization
            WHERE dentist_id = @dentist_id
            
            PRINT 'Dentist information updated successfully.'
        END
        ELSE
        BEGIN
            PRINT 'Invalid operation type. Use ''INSERT'' or ''UPDATE''.'
        END
    END
    ELSE
    BEGIN
        PRINT 'Access denied. Only administrators can manage dentist information.'
    END
END