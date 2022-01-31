;With Indexinfo as 
(
select OBJECT_NAME(SC.id) as Tablename,Sc.Name as Colname ,ST.name as Datatype ,tp.name as IndexName,tp.indid
from sys.sysobjects SO 
Inner join sys.syscolumns SC on SO.id = sc.id
Inner join sys.systypes ST on SC.xusertype = ST.xusertype
outer apply
(
Select SI.name,SI.indid
from sys.partitions Pat
Inner join sys.sysindexes SI on Pat.object_id = SI.id and Pat.index_id = SI.indid
Inner join sys.sysindexkeys  IdxKey (nolock) on SI.id = IdxKey.id and SI.indid = IdxKey.indid
Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid
where Col.id = SO.id and Col.name = sc.name
) tp
where SO.type = 'U'
and SC.name in ('organizationid','Organisationid')

)
select Tablename,Colname,Datatype,IndexName,ind.indid
,' Drop index '+Ind.IndexName+' on '+Ind.Tablename as Dropindexscript,
'Alter table '+Ind.tablename+' Alter Column '+ind.colname+' int' as AlterScript,
'exec Sp_rename '''+Ind.tablename+'.'+ ind.colname+''', ''OrgID''' as AlterScript,
(Select 'Create '+case when idx.index_id = 1 then 'Clustered Index ' else 'NonClustered Index ' end+
'NIDX_'+obj.name+'_'+
stuff
(
(
Select
'_'+col.name
from sys.sysindexkeys  IdxKey (nolock)
Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid
where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id
and IdxKey.keyno <> 0
order by keyno
for xml path('')
)
,1,1,''
)+' on '+obj.name+' ('+
stuff
(
(
Select
','+Quotename(col.name)
from sys.sysindexkeys  IdxKey (nolock)
Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid
where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id
and IdxKey.keyno <> 0
order by keyno
for xml path('')),1,1,'')+')'+
Case when 
ISNULL(
stuff
(
(
Select
','+Quotename(col.name)
from sys.sysindexkeys  IdxKey (nolock)
Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid
where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id
and IdxKey.keyno = 0
order by keyno
for xml path('')
)
,1,1,''
),'') <> '' then ' Include ('+
ISNULL(
stuff
(
(
Select
','+Quotename(col.name)
from sys.sysindexkeys  IdxKey (nolock)
Inner join sys.syscolumns Col (nolock) on IdxKey.id = col.id  and IdxKey.colid = col.colid
where IdxKey.id = idx.object_id and IdxKey.indid = idx.index_id
and IdxKey.keyno = 0
order by keyno
for xml path('')
)
,1,1,''
),'')+')'
Else 
'' End 
From sys.sysobjects obj(nolock)
Inner Join sys.partitions Idx (nolock) on obj.id = idx.object_id
Inner join Sys.sysindexes SI (nolock) on idx.object_id = SI.id and idx.index_id = si.indid
Where obj.name = ind.Tablename and SI.name = ind.Indexname
) as Indexscript
from Indexinfo ind
Order by indid,Tablename
Go
