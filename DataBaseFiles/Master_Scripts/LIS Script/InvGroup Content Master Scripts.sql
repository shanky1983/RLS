Declare @OrgID INT
Declare @OrgName varchar(255)
SET @orgID=OrgID----Give your OrgID
set @OrgName=OrgName---Give your OrgName
--------------------------- only investigation---------------------------------------------------
select @OrgName AS LAB,InvestigationCode as TestCode,InvestigationName as TestName,
iom.Displaytext,ih.HeaderName,iom.Display as IsOrderable,idm.DeptName,ISM.SampleDesc,ism1.ContainerName ,
imk.MethodName,UomCode,iom.InvestigationID from investigationorgmapping iom 
inner join Investigationmaster IM on IM.InvestigationID=iom.InvestigationID
left join invsamplemaster ism on iom.SampleCode=ism.Samplecode and iom.OrgID=ism.orgID
left join investigationsamplecontainer ism1 on iom.SampleContainerID=ism1.SampleContainerID and iom.OrgID=ism1.orgID
LEFT JOIN invdeptmaster idm on idm.DeptID=iom.DeptID and iom.OrgID=idm.orgID
left join Investigationmethod imk on imk.MethodID=iom.MethodID and IMK.OrgID=iom.OrgID
left join investigationheader ih on ih.HeaderID=IOM.HeaderID --and ih.OrgID=Iom.HeaderID
where iom.orgID=@OrgID 
 ---------------------------------------------------------------------------------------------
 
Declare @OrgID INT
Declare @OrgName varchar(255)
SET @orgID=OrgID----Give your OrgID
set @OrgName=OrgName---Give your OrgName
------------------------------Group and package --------------------------------------------
SELECT @OrgName AS LAB,IVG.DisplayText,igm.GroupName,ivg.IsNonorderable,Ivg.attgroupID,ivg.TestCode FROM invorggroup ivg 
inner join invgroupMaster igm on igm.GroupID=ivg.AttgroupID and igm.Type='GRP'
where IVG.ORGID=@OrgID
union

SELECT @OrgName AS LAB,IVG.DisplayText,igm.GroupName,ivg.IsNonorderable,Ivg.attgroupID,ivg.TestCode FROM invorggroup ivg 
inner join invgroupMaster igm on igm.GroupID=ivg.AttgroupID and igm.Type='PKG'
where IVG.ORGID=@OrgID
------------------------------------------------------------------------------------------------