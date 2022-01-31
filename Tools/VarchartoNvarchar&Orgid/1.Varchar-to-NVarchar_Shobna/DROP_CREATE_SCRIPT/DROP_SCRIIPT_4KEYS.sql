-------------//*DROP FOREIGN KEY CONSTRAINTS*//-----------------

declare @ForeignKeyName varchar(4000)
declare @ParentTableName varchar(4000)
declare @ParentTableSchema varchar(4000)
declare @i  int=1
declare @TSQLDropFK varchar(max)

declare CursorFK cursor for select fk.name ForeignKeyName, schema_name(t.schema_id) ParentTableSchema, t.name ParentTableName
from sys.foreign_keys fk  inner join sys.tables t on fk.parent_object_id=t.object_id and t.name not like 'aspnet%'
and t.name not in('TRFfilemanager','IntegrationHistory')
open CursorFK
fetch next from CursorFK into  @ForeignKeyName, @ParentTableSchema, @ParentTableName
while (@@FETCH_STATUS=0)
begin

 set @TSQLDropFK =--'If exists ( Select 1 from sys.objects where name ='''+(@ForeignKeyName)+''')'+ 'Begin '+
 ' ALTER TABLE '+quotename(@ParentTableSchema)+'.'+quotename(@ParentTableName)+' DROP CONSTRAINT '+quotename(@ForeignKeyName)--+ char(13) +'END'
 
  
 print @TSQLDropFK
 
fetch next from CursorFK into  @ForeignKeyName, @ParentTableSchema, @ParentTableName
end
close CursorFK
deallocate CursorFK
go


---------------//*DROP PK & UNIQUE CONSTRAINTS*//------------------

DECLARE @SchemaName VARCHAR(256)
DECLARE @TableName VARCHAR(256)
DECLARE @IndexName VARCHAR(256)
DECLARE @TSQLDropIndex VARCHAR(MAX)
declare @i  int=1

DECLARE CursorIndexes CURSOR FOR

SELECT  schema_name(t.schema_id), t.name,  i.name 
FROM sys.indexes i
INNER JOIN sys.tables t ON t.object_id= i.object_id
WHERE i.type>0 and t.is_ms_shipped=0 and t.name<>'sysdiagrams'
and (is_primary_key=1 or is_unique_constraint=1) and t.name not like 'aspnet%'
and t.name not in('TRFfilemanager','IntegrationHistory')


OPEN CursorIndexes

FETCH NEXT FROM CursorIndexes INTO @SchemaName,@TableName,@IndexName

WHILE @@fetch_status = 0

BEGIN

  SET @TSQLDropIndex =-- ' If Exists ( select 1 from sys.objects where name ='''+ (@IndexName)+''')'+ ' Begin' +      
    ' ALTER TABLE '+QUOTENAME(@SchemaName)+ '.' + QUOTENAME(@TableName) + ' DROP CONSTRAINT ' +QUOTENAME(@IndexName)--+ ' End'
  
  

  PRINT @TSQLDropIndex
  FETCH NEXT FROM CursorIndexes INTO @SchemaName,@TableName,@IndexName
  
END

CLOSE CursorIndexes
DEALLOCATE CursorIndexes

GO



-----------//*Drop Default Constraint*//------------

DECLARE @Tbl_Name VARCHAR(256)
DECLARE @Cons_Name VARCHAR(256)
DECLARE @TSQLDropIndex VARCHAR(MAX)
declare @i  int=1

DECLARE CursorDefault CURSOR FOR

SELECT
      
      OBJECT_NAME(sc.id)as Tbl_Name, 
      OBJECT_NAME(sc.cdefault)AS Cons_Name
  FROM
      syscolumns sc
      INNER JOIN
      sysobjects as so on sc.cdefault = so.id
      INNER JOIN
      syscomments as sm on sc.cdefault = sm.id
  WHERE
      OBJECTPROPERTY(so.id, N'IsDefaultCnst') = 1  and uid<>4
      
      
OPEN CursorDefault

FETCH NEXT FROM CursorDefault INTO @Tbl_Name,@Cons_Name

WHILE @@fetch_status = 0

BEGIN

  SET @TSQLDropIndex = --' If Exists ( select 1 from sys.objects where name ='''+ (@Cons_Name) +''')'+ ' Begin'+
  'ALTER TABLE '+QUOTENAME(@Tbl_Name)+ ' DROP CONSTRAINT ' +QUOTENAME(@Cons_Name) --+ ' End'
  
   
  PRINT @TSQLDropIndex
  
  
  
FETCH NEXT FROM CursorDefault INTO @Tbl_Name,@Cons_Name

END

CLOSE CursorDefault
DEALLOCATE CursorDefault
