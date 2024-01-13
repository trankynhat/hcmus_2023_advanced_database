create proc get_branch_id 
as
begin
	SELECT B.id FROM branch B
end

exec get_branch_id