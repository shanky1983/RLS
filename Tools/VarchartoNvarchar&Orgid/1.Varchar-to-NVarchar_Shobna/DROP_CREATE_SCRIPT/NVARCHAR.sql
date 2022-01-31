Select 'ALTER TABLE ' + OBJECT_NAME(COL.id) + ' ALTER COLUMN [' + CASE 
WHEN COL.xtype = 167 AND COL.length != -1 AND COL.length < 4000 THEN COL.name + '] NVARCHAR(' + CONVERT(varchar, COL.length) + ')' 
WHEN COL.xtype = 167 AND COL.length = -1 THEN COL.name + '] NVARCHAR(MAX)'
WHEN COL.xtype = 167 AND COL.length >= 4000 THEN COL.name + '] NVARCHAR(MAX)'
WHEN COL.xtype = 175 AND COL.length != -1 THEN COL.name + '] NCHAR(' + CONVERT(varchar, COL.length) + ')' 
WHEN COL.xtype = 175 AND COL.length = -1 THEN COL.name + '] NCHAR(MAX)'
WHEN COL.xtype = 175 AND COL.length >= 4000 THEN COL.name + '] NCHAR(MAX)'
END
from sys.syscolumns COL, Sys.systypes TYP 
where COL.xtype = TYP.xtype
and COL.xtype in (167, 175)
And id in (Select id from sys.sysobjects where type = 'u' and name not like 'aspnet%' and name not in('TRFfilemanager','IntegrationHistory'))
Order by OBJECT_NAME(id)