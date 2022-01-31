
-----------------------//*CREAT PK & UNIQUE CONSTRAINTS*//---------------------

declare @SchemaName varchar(100)
declare @TableName varchar(256)
declare @IndexName varchar(256)
declare @ColumnName varchar(100)
declare @is_unique_constraint varchar(100)
declare @IndexTypeDesc varchar(100)
declare @FileGroupName varchar(100)
declare @is_disabled varchar(100)
declare @IndexOptions varchar(max)
declare @IndexColumnId int
declare @IsDescendingKey int 
declare @IsIncludedColumn int
declare @TSQLScripCreationIndex varchar(max)
declare @TSQLScripDisableIndex varchar(max)
declare @is_primary_key varchar(100)
declare @PartitionColumn varchar(100)

declare CursorIndex cursor for
SELECT Schema_name(t.schema_id)             [schema_name],
       t.NAME,
       ix.NAME,
       CASE
         WHEN ix.is_unique_constraint = 1 THEN ' UNIQUE '
         ELSE ''
       END,
       CASE
         WHEN ix.is_primary_key = 1 THEN ' PRIMARY KEY '
         ELSE ''
       END,
       ix.type_desc,
       CASE WHEN ix.is_padded=1 THEN 'PAD_INDEX = ON, ' ELSE 'PAD_INDEX = OFF, ' END + CASE WHEN ix.allow_page_locks=1 
       THEN 'ALLOW_PAGE_LOCKS = ON, ' ELSE 'ALLOW_PAGE_LOCKS = OFF, ' END + CASE WHEN ix.allow_row_locks=1 
       THEN 'ALLOW_ROW_LOCKS = ON, ' ELSE 'ALLOW_ROW_LOCKS = OFF, ' END + CASE WHEN Indexproperty(t.object_id, ix.NAME, 'IsStatistics') = 1 
       THEN 'STATISTICS_NORECOMPUTE = ON, ' ELSE 'STATISTICS_NORECOMPUTE = OFF, ' END + CASE WHEN ix.ignore_dup_key=1 
       THEN 'IGNORE_DUP_KEY = ON, 'ELSE 'IGNORE_DUP_KEY = OFF, ' END
       + 'SORT_IN_TEMPDB = OFF, FILLFACTOR ='
       + Cast(ix.fill_factor AS VARCHAR(3)) AS IndexOptions,
       ds.NAME                              FileGroupName,
       CASE
         WHEN ds.type_desc = 'PARTITION_SCHEME' THEN (SELECT c.NAME
                                                        FROM sys.index_columns ic
                                                             INNER JOIN sys.columns c
                                                                     ON c.object_id = ix.object_id
                                                                        AND c.column_id = ic.column_id
                                                       WHERE ic.partition_ordinal = 1
                                                         AND ic.index_id = ix.index_id
                                                         AND ic.object_id = ix.object_id)
         ELSE NULL
       END                                  partition_column
  FROM sys.tables t
       INNER JOIN sys.indexes ix
               ON t.object_id = ix.object_id
       LEFT JOIN sys.data_spaces ds
              ON ds.data_space_id = ix.data_space_id
              and t.name not in('TRFfilemanager','IntegrationHistory')
 WHERE 1 = 1
   AND ix.type > 0
   AND ( ix.is_primary_key = 1
          OR ix.is_unique_constraint = 1 ) --and schema_name(tb.schema_id)= @SchemaName and tb.name=@TableName
   AND t.is_ms_shipped = 0
   AND t.NAME <> 'sysdiagrams' and t.name not like 'aspnet%'
 ORDER BY Schema_name(t.schema_id),
          t.NAME,
          ix.NAME  

open CursorIndex
fetch next from CursorIndex into  @SchemaName, @TableName, @IndexName, @is_unique_constraint, @is_primary_key, @IndexTypeDesc, @IndexOptions, @FileGroupName, @PartitionColumn
while (@@fetch_status=0)
begin
   declare @IndexColumns varchar(max)
   declare @IncludedColumns varchar(max)
   set @IndexColumns=''
   set @IncludedColumns=''
   declare CursorIndexColumn cursor for 
   select col.name, ixc.is_descending_key, ixc.is_included_column
     from sys.tables             tb
    inner join sys.indexes       ix  on tb.object_id  = ix.object_id
    inner join sys.index_columns ixc on ix.object_id  = ixc.object_id and ix.index_id   = ixc.index_id
    inner join sys.columns       col on ixc.object_id = col.object_id and ixc.column_id = col.column_id
   where ix.type>0 and (ix.is_primary_key=1 or ix.is_unique_constraint=1)
     and schema_name(tb.schema_id)=@SchemaName and tb.name=@TableName and ix.name=@IndexName
     
    order by ixc.index_column_id
   open CursorIndexColumn 
   fetch next from CursorIndexColumn into  @ColumnName, @IsDescendingKey, @IsIncludedColumn
   while (@@fetch_status=0)
   begin
    if @IsIncludedColumn=0 
      set @IndexColumns=@IndexColumns + @ColumnName  + case when @IsDescendingKey=1  then ' DESC, ' else  ' ASC, ' end
    else 
     set @IncludedColumns=@IncludedColumns  + @ColumnName  +', ' 
       
    fetch next from CursorIndexColumn into @ColumnName, @IsDescendingKey, @IsIncludedColumn
   end
   close CursorIndexColumn
   deallocate CursorIndexColumn
   set @IndexColumns = substring(@IndexColumns, 1, len(@IndexColumns)-1)
   set @IncludedColumns = case when len(@IncludedColumns) >0 then substring(@IncludedColumns, 1, len(@IncludedColumns)-1) else '' end
  --  print @IndexColumns
  --  print @IncludedColumns
  
  set @TSQLScripCreationIndex =''
  set @TSQLScripDisableIndex =''
  set  @TSQLScripCreationIndex= ' If Exists ( select 1 from '+ QUOTENAME(@SchemaName)+ '.' + QUOTENAME(@TableName) +')'+ ' Begin '+
  'ALTER TABLE '+  QUOTENAME(@SchemaName) +'.'+ QUOTENAME(@TableName)+ ' ADD CONSTRAINT ' +  QUOTENAME(@IndexName) + @is_unique_constraint + @is_primary_key + +@IndexTypeDesc +  '('+@IndexColumns+') '+ 
   case when len(@IncludedColumns)>0 then CHAR(13) +'INCLUDE (' + @IncludedColumns+ ')' else '' end --+ CHAR(13)+'WITH (' + @IndexOptions+ ') ON ' + (QUOTENAME(@FileGroupName), '(' + @PartitionColumn + ')')  + ';'  
  +' End'
  print @TSQLScripCreationIndex
  print @TSQLScripDisableIndex

fetch next from CursorIndex into  @SchemaName, @TableName, @IndexName, @is_unique_constraint, @is_primary_key, @IndexTypeDesc, @IndexOptions, @FileGroupName, @PartitionColumn

end
close CursorIndex
deallocate CursorIndex


----------------//*CREAT FOREIGN KEY CONSTRAINTS*//----------------------------

declare @ForeignKeyID int
declare @ForeignKeyName varchar(4000)
declare @ParentTableName varchar(4000)
declare @ParentColumn varchar(4000)
declare @ReferencedTable varchar(4000)
declare @ReferencedColumn varchar(4000)
declare @StrParentColumn varchar(max)
declare @StrReferencedColumn varchar(max)
declare @ParentTableSchema varchar(4000)
declare @ReferencedTableSchema varchar(4000)
declare @TSQLCreationFK varchar(max)
--Written by Percy Reyes www.percyreyes.com
declare CursorFK cursor for select object_id--, name, object_name( parent_object_id) 
from sys.foreign_keys
open CursorFK
fetch next from CursorFK into @ForeignKeyID
while (@@FETCH_STATUS=0)
begin
 set @StrParentColumn=''
 set @StrReferencedColumn=''
 declare CursorFKDetails cursor for
  select  fk.name ForeignKeyName, schema_name(t1.schema_id) ParentTableSchema,
  object_name(fkc.parent_object_id) ParentTable, c1.name ParentColumn,schema_name(t2.schema_id) ReferencedTableSchema,
   object_name(fkc.referenced_object_id) ReferencedTable,c2.name ReferencedColumn
  from 
  sys.foreign_keys fk 
  inner join sys.foreign_key_columns fkc on fk.object_id=fkc.constraint_object_id
  inner join sys.columns c1 on c1.object_id=fkc.parent_object_id and c1.column_id=fkc.parent_column_id 
  inner join sys.columns c2 on c2.object_id=fkc.referenced_object_id and c2.column_id=fkc.referenced_column_id 
  inner join sys.tables t1 on t1.object_id=fkc.parent_object_id  and t1.name not like 'aspnet%'
  inner join sys.tables t2 on t2.object_id=fkc.referenced_object_id   and t2.name not like 'aspnet%'
	and t2.name not in('TRFfilemanager','IntegrationHistory') 
	and t1.name not in('TRFfilemanager','IntegrationHistory')
  where fk.object_id=@ForeignKeyID
 open CursorFKDetails
 fetch next from CursorFKDetails into  @ForeignKeyName, @ParentTableSchema, @ParentTableName, @ParentColumn, @ReferencedTableSchema, @ReferencedTable, @ReferencedColumn
 while (@@FETCH_STATUS=0)
 begin    

  set @StrParentColumn=@StrParentColumn + ', ' + quotename(@ParentColumn)
  set @StrReferencedColumn=@StrReferencedColumn + ', ' + quotename(@ReferencedColumn)
  
     fetch next from CursorFKDetails into  @ForeignKeyName, @ParentTableSchema, @ParentTableName, @ParentColumn, @ReferencedTableSchema, @ReferencedTable, @ReferencedColumn
 end
 close CursorFKDetails
 deallocate CursorFKDetails
  if(@StrParentColumn!='' and @StrReferencedColumn!='')
  begin
 set @StrParentColumn=substring(@StrParentColumn,2,len(@StrParentColumn)-1)
  
 set @StrReferencedColumn=substring(@StrReferencedColumn,2,len(@StrReferencedColumn)-1)
  
 
 set @TSQLCreationFK=' If Exists ( Select 1 from ' +quotename(@ParentTableSchema)+'.'+quotename(@ParentTableName)+')'+ 
 'Begin '+' ALTER TABLE '+quotename(@ParentTableSchema)+'.'+quotename(@ParentTableName)+' WITH CHECK ADD CONSTRAINT '+ 
 quotename(@ForeignKeyName) + ' FOREIGN KEY('+ltrim(@StrParentColumn)+') '+ char(13) +'REFERENCES '+
 quotename(@ReferencedTableSchema)+'.'+quotename(@ReferencedTable)+' ('+ltrim(@StrReferencedColumn)+') ' +
 char(13)+' END' end 
 
 print @TSQLCreationFK
 
 --print @ForeignKeyID

fetch next from CursorFK into @ForeignKeyID 
end
close CursorFK
deallocate CursorFK


------//*Create Default Constraint*/---------

  SELECT
      'ALTER TABLE ' +
      QuoteName(OBJECT_NAME(sc.id)) +
      'WITH NOCHECK ADD CONSTRAINT ' +
      QuoteName(OBJECT_NAME(sc.cdefault))+
      ' DEFAULT ' +
      sm.text +
      ' FOR ' + QuoteName(sc.name)
      + CHAR(13)+CHAR(10)
  FROM
      syscolumns sc
      INNER JOIN
      sysobjects as so on sc.cdefault = so.id
      INNER JOIN
      syscomments as sm on sc.cdefault = sm.id
  WHERE
       OBJECTPROPERTY(so.id, N'IsDefaultCnst') = 1 and uid<>4

