SET NOCOUNT ON
GO

-- To allow xp_cmdshell execution.
PRINT 'Enabling xp_cmdshell utility...'
EXEC sp_configure 'show advanced options', 1
RECONFIGURE
EXEC sp_configure 'xp_cmdshell', 1
RECONFIGURE
GO

DECLARE @FileList Table (FileNumber int identity(1,1), FileName varchar(255), Command varchar(2048))
DECLARE @OutputTable Table (Output varchar(MAX))
DECLARE @BaseDir varchar(2048) 
DECLARE @FileName varchar(255)
DECLARE @Command varchar(2048) 
DECLARE @FileNum int

SET @BaseDir = 'D:\aaaa\'
SET @Command = 'ECHO Running Scripts Started %DATE% %TIME% > ' + @BaseDir + 'Output.txt'
EXEC xp_cmdshell @Command, NO_OUTPUT
SET @Command = 'DIR /B /O:-N ' + @BaseDir + '*.sql'
INSERT INTO @FileList (FileName) EXEC xp_cmdshell @Command 
DELETE FROM @FileList WHERE FileName IS NULL OR FileName NOT LIKE '%.sql'
UPDATE @FileList SET Command = 'sqlcmd -d kmh -i "' + @BaseDir + FileName + '" >> ' + @BaseDir + 'Output.txt'

PRINT ''
PRINT 'Running Scripts...'
SELECT @FileNum = MAX(FileNumber) FROM @FileList 
-- SELECT * FROM @FileList 
WHILE (@FileNum > 0)
BEGIN
	SELECT @FileName = FileName, @Command = Command FROM @FileList WHERE FileNumber = @FileNum 
	RAISERROR ('    Executing file %s',0, 0, @FileName) WITH NOWAIT
	SET @FileName = 'ECHO ' + @FileName + ': >> ' + @BaseDir + 'Output.txt'
	
	EXEC xp_cmdshell @FileName, NO_OUTPUT
	EXEC xp_cmdshell @Command, NO_OUTPUT
	
    SET @FileNum = @FileNum - 1
END
PRINT 'Running Scripts Complete'
PRINT ''

SET @Command = 'type "' + @BaseDir + 'Output.txt"'
 
INSERT INTO @OutputTable EXEC xp_cmdshell @Command 
SELECT * FROM @OutputTable WHERE Output IS NOT NULL
GO

-- To disable xp_cmdshell again once we are thru with our work.
PRINT 'Disabling xp_cmdshell utility...'
EXEC sp_configure 'xp_cmdshell', 0
RECONFIGURE
EXEC sp_configure 'show advanced options', 0
RECONFIGURE
GO