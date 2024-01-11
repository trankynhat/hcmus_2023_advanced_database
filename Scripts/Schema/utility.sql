SELECT name as [File Group Name]
FROM sys.filegroups
WHERE type = 'FG'

SELECT name as [DB FileName],physical_name as [DB File Path]
FROM sys.database_files
where type_desc = 'ROWS'