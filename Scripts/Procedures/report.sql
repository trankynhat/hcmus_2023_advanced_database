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
    SELECT 
GO