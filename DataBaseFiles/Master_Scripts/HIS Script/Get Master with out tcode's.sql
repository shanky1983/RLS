--select * from investigationorgmapping where orgid=78 --and displaytext is null


-----/* get investigation master*/--------------

select IM.investigationname,IOM.Displaytext as TestName,IOM.investigationid,IOM.Display,IDM.DeptName,IOM.Deptid,IH.HeaderName,IOM.HeaderID,IOM.UOMCode,
ISM.SampleDesc,SC.ContainerName
from investigationmaster IM
inner join investigationorgmapping IOM on IM.investigationid=IOM.investigationid
left join invdeptmaster IDM on IOM.deptid=IDM.Deptid and IOM.orgid=IDM.Orgid
left join InvestigationHeader IH on IH.HeaderID=IOM.HeaderID
left join InvSampleMaster ISM on ISM.SampleCode=IOM.SampleCode and ISM.orgid=IOM.Orgid
left join InvestigationSampleContainer SC on SC.SampleContainerID=IOM.SampleContainerID and SC.OrgID=IOM.OrgID
where iom.orgid=78 

--select * from invorggroup where orgid=78

-------/* Get Group master  */--------------------
select IGM.GroupName,IOG.AttGroupID,IOG.OrgGroupID,IOG.Displaytext as OrgGroupName,IOG.Orgid,IOG.SequenceNo,IOG.ValidationText  from InvGroupMaster IGM
inner join INVOrggroup IOG on IGM.GroupID=IOG.AttGroupID
where IOG.orgid=78 and IGM.Type='GRP'


------/* Get group content and asine into temp table  */--------------

select * --into #tmp 
from InvGroupMapMaster where groupid in (
select Orggroupid from invgroupmaster IGM
inner join InvOrgGroup IOG on IGM.Groupid=IOG.AttGroupID
where IOG.Orgid=78 and IGM.Type='GRP')


------/*  Get Group Content Master   */-----------------------

select * from (

select IGM.GroupName,T.Groupid,T.investigationid,T.parent,T.sequenceno,IGM.Groupname as Investigationname
from #tmp T
inner join invorggroup IOG  on T.groupid=IOG.orggroupid
inner join InvGroupMaster IGM on IOG.AttGroupID=IGM.GroupID
where IOG.Orgid=78 and T.Parent='Y'

union all

select IGM.GroupName,T.Groupid,T.investigationid,T.parent,T.sequenceno,IM.InvestigationName
from #tmp T
inner join invorggroup IOG  on T.groupid=IOG.orggroupid
inner join InvGroupMaster IGM on IOG.AttGroupID=IGM.GroupID
inner join Investigationorgmapping IOM on IOM.InvestigationID=T.investigationid 
inner join investigationmaster IM on IM.investigationid=IOM.investigationid
Where IOM.Orgid=78 and (T.parent='N' or T.parent is null)
) A order by groupid







