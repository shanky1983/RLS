
select * from   Stage2_MHL_T_02_GROUP_MASTER where 
select * from   Stage2_MHL_T_01_TESTMASTER 
select * from  Stage2_MHL_T_04_GROUP_TESTS
select * from  Stage2_MHL_T_03_Package_Master
select * from  Stage2_MHL_T_05_PACKAGE_TESTS

select IOG.displaytext as GroupName,temp.*,IOM.Displaytext as Investigationname,IOM.SampleCode,ISM.sampledesc,IOM.SampleContainerID,isc.ContainerName  from #tmp3 temp
inner join INVORGGROUP IOG on IOG.orggroupid=temp.groupid
inner join investigationorgmapping IOM on temp.investigationid=IOM.investigationid 
inner join InvSampleMaster ISM on IOM.samplecode=ISM.SampleCode and IOM.orgid=ISM.orgid
inner join InvestigationSampleContainer ISC on IOM.SampleContainerID=ISC.SampleContainerID and IOM.orgid=ISC.orgid
where IOM.orgid=146  and IOG.orgid=146 order by temp.groupid

select groupid,SampleCode,sampledesc,SampleContainerID,ContainerName,count(groupid) as Groupcount  from #tmp group by groupid,SampleCode,sampledesc,SampleContainerID,ContainerName
having count(groupid)>1 order by groupid

select * from #tmp where groupid in (select groupid from #tmp1) order by groupid

select groupid,count(groupid) as DuplicateGroup into #tmp2 from #tmp1 group by groupid having count(groupid)>1

select * from #tmp2 T
inner join INVOrggroup IOG on T.groupid=IOG.orggroupid
where IOG.orgid=146




SELECT *  into #tmp3 from invgroupmapmaster where GroupID in
(
       select        OrgGroupID
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID =146
       and                igm.Type = 'grp' and orggroupid in (select groupid from #tmp2)
       
) 

