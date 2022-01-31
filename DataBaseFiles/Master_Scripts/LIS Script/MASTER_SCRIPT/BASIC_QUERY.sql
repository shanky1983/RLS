-------------Query to Get General Ratecard Master for ORGs------------


--select * from ratemaster where orgid=109
select cm.CodeName,cp.IdentifyingType,iom.InvestigationID,igm.InvestigationName,IRM.rate from codemaster cm
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join InvestigationOrgMapping iom on cp.IdentifyingID=iom.InvestigationID
inner join InvestigationMaster igm on iom.InvestigationID=igm.InvestigationID
left join invratemaster IRM on IRM.ID=iom.InvestigationID and IRM.Type='INV' and IRM.RateID=280
where cp.IdentifyingType='investigations' and cm.CodeSchemeID=26 and iom.OrgID=109

select cm.CodeName,igm.GroupName,igm.GroupID,iog.OrgID,IRM.rate from codemaster cm
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join INVORGGROUP iog on cp.IdentifyingID=iog.OrgGroupID
inner join InvGroupMaster igm on iog.AttGroupID=igm.GroupID
left join invratemaster IRM on IRM.ID=iog.OrgGroupID and IRM.Type='GRP' and IRM.RateID=280
where cp.IdentifyingType='grp' and cm.CodeSchemeID=26 and iog.OrgID=109 


select cm.CodeName,igm.GroupName,igm.GroupID,iog.OrgID,IRM.rate from codemaster cm
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join INVORGGROUP iog on cp.IdentifyingID=iog.OrgGroupID
inner join InvGroupMaster igm on iog.AttGroupID=igm.GroupID
left join invratemaster IRM on IRM.ID=iog.OrgGroupID and IRM.Type='PKG' and IRM.RateID=280
where cp.IdentifyingType='pkg' and cm.CodeSchemeID=26 and iog.OrgID=109