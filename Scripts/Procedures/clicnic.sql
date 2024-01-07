USE CQ_CSDLNC_05
GO

-- list of clinic of branch
CREATE OR ALTER PROC list_clinic_of_branch (@branch_id INT)
AS
BEGIN
	SELECT c.clinic_id, c.branch_id, c.clinic_number
	FROM clinic c
	WHERE c.branch_id = @branch_id
END
GO
EXEC list_clinic_of_branch @branch_id = 1
GO