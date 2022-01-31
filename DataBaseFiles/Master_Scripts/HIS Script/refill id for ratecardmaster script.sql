-------------Query to Get General Ratecard Master for ORGs------------

--select * from codingschemeorgmapping where orgid=90
--select * from ratemaster where orgid=109

update e set e.id=iom.investigationid from Discount_INV_90 E
inner join codemaster cm on E.tcode=cm.codename
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join InvestigationOrgMapping iom on cp.IdentifyingID=iom.InvestigationID
inner join InvestigationMaster igm on iom.InvestigationID=igm.InvestigationID
--left join invratemaster IRM on IRM.ID=iom.InvestigationID and IRM.Type='INV' and IRM.RateID=280
where cp.IdentifyingType='investigations' and cm.CodeSchemeID=10 and iom.OrgID=90 and e.type='INV'

update e set e.id=iog.orggroupid, e.type='GRP' from Discount_GRP_90 E
inner join codemaster cm on E.tcode=cm.codename
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join INVORGGROUP iog on cp.IdentifyingID=iog.OrgGroupID
inner join InvGroupMaster igm on iog.AttGroupID=igm.GroupID
--left join invratemaster IRM on IRM.ID=iog.OrgGroupID and IRM.Type='GRP' and IRM.RateID=280
where cp.IdentifyingType='grp' and cm.CodeSchemeID=10 and iog.OrgID=90 and e.type='GRP'


update e set e.id=iog.orggroupid,e.type='PKG' from Discount_GRP_90 E
inner join codemaster cm on E.tcode=cm.codename
inner join CodeMapper cp on cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType
inner join INVORGGROUP iog on cp.IdentifyingID=iog.OrgGroupID
inner join InvGroupMaster igm on iog.AttGroupID=igm.GroupID
--left join invratemaster IRM on IRM.ID=iog.OrgGroupID and IRM.Type='PKG' and IRM.RateID=280
where cp.IdentifyingType='pkg' and cm.CodeSchemeID=10 and iog.OrgID=90 and e.type='PKG'