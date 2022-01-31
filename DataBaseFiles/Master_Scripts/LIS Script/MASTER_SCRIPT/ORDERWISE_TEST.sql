



select cm.CodeName,im.InvestigationID,im.InvestigationName,iom.DisplayText,iom.OrgID, 
'Y'  as isorderable from codemaster cm
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join InvestigationOrgMapping iom on cp.IdentifyingID=iom.InvestigationID
inner join InvestigationMaster im on iom.InvestigationID=im.InvestigationID
where cm.CodeSchemeID=1 and iom.OrgID=70 and cp.IdentifyingType='investigations' and ISNULL(iom.IsOrderable,'1')='1'


select cm.CodeName,igm.GroupName,iog.DisplayText, iog.orggroupid,iog.OrgID, 
'Y'   as Isorderable from codemaster cm
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join invorggroup iog on cp.IdentifyingID=iog.OrgGroupID
inner join InvGroupMaster igm on iog.AttGroupID=igm.GroupID
where cm.CodeSchemeID=1 and iog.OrgID=70 and cp.IdentifyingType='grp' and isnull(iog.IsNonOrderable ,'N')='N'

select cm.CodeName,igm.GroupName,iog.DisplayText, iog.orggroupid,iog.OrgID,
'Y' as Isorderable from codemaster cm
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join invorggroup iog on cp.IdentifyingID=iog.OrgGroupID
inner join InvGroupMaster igm on iog.AttGroupID=igm.GroupID
where cm.CodeSchemeID=1 and iog.OrgID=70 and cp.IdentifyingType='pkg' and isnull(iog.IsNonOrderable ,'N')='N'