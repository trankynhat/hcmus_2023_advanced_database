USE CQ_CSDLNC_05

-- get_dentist_name
GO
CREATE OR ALTER PROC get_dentist_name (@dentist_id INT) 
AS
BEGIN
	SELECT U.full_name
	FROM [user] U
	WHERE U.id = @dentist_id
END
GO
EXEC get_dentist_name @dentist_id = 24
GO