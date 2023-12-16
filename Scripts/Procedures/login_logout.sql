CREATE PROCEDURE get_user_info (@username VARCHAR(50))
AS
	SELECT id, username, password, full_name, date_of_birth, 
			phone_number, email, permanent_address, gender, working_branch_id
	FROM [user]
	WHERE username = @username
END
GO

