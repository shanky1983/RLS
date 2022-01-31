
--select * from organization where name like '%triesta%'
Select * from 
(
Select O.Name ,O.Orgid,'TotalCount'as samples, count(PIS.samplecode)sampleCount ,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))MOnths,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))Year
from PatientVisit PV(Nolock)
Inner Join PatientInvsample PIS (Nolock) On PV.Patientvisitid=PIS.PAtientvisitid and PV.OrgID=PIS.Orgid
Inner Join Organization O (Nolock)ON O.OrgID=PV.OrgID
--Inner Join OrganizationAddress OA on OA.AddressId=PV.OrgAddressID and OA.OrgID=PV.OrgID
Where O.OrgID in (98)
Group By O.Name ,O.OrgID,Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3)), Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))
--order by o.OrgID asc
)TT 
Pivot
(
sum(samplecount) for Months in 
([JAN],[FEB],[MAR],[APR],[MAY],[JUN],[JUL],[AUG],[SEP],[OCT],[NOV],[DEC])
) As t 





Select * from 
(
Select O.Name ,O.OrgID,'TotalCount'as VisitCOUNTS,COUNT(PV.Patientvisitid)visitCount,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))MOnths, 
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))Year
from PatientVisit PV(Nolock)
Inner Join Organization O (Nolock)ON O.OrgID=PV.OrgID
--Inner Join OrganizationAddress OA on OA.AddressId=PV.OrgAddressID and OA.OrgID=PV.OrgID
Where O.OrgID in (98)
Group BY O.Name ,O.OrgID,Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3)),Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))
)TT
Pivot
(
sum(visitCount) for Months in 
([JAN],[FEB],[MAR],[APR],[MAY],[JUN],[JUL],[AUG],[SEP],[OCT],[NOV],[DEC])
) As t






Select * from 
(
Select O.Name ,O.OrgID,'TotalCount'as ApprovedVisits,COUNT(PV.Patientvisitid) visitCount,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))MOnths, 
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))Year
from PatientVisit PV(Nolock)
inner join (select visitid,Status,orgid from Orderedinvestigations group by Visitid,status,orgid )OI on PV.patientvisitid=OI.visitid and PV.orgid=OI.Orgid
Inner Join Organization O (Nolock)ON O.OrgID=PV.OrgID
--Inner Join OrganizationAddress OA on OA.AddressId=PV.OrgAddressID and OA.OrgID=PV.OrgID
Where O.OrgID in (98) and OI.Status='Approve'
Group BY O.Name ,O.OrgID,Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3)),Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))
)TT
Pivot
(
sum(visitCount) for Months in 
([JAN],[FEB],[MAR],[APR],[MAY],[JUN],[JUL],[AUG],[SEP],[OCT],[NOV],[DEC])
) As t





Select * from 
(
Select O.Name ,O.Orgid,'TotalCount'as samples, count(PIS.samplecode)sampleCount ,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))MOnths,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))Year
from PatientVisit PV(Nolock)
Inner Join PatientInvsample PIS (Nolock) On PV.Patientvisitid=PIS.PAtientvisitid and PV.OrgID=PIS.Orgid
inner join (select visitid,Status,orgid from Orderedinvestigations group by Visitid,status,orgid )OI on PV.patientvisitid=OI.visitid and PV.orgid=OI.Orgid
Inner Join Organization O (Nolock)ON O.OrgID=PV.OrgID
--Inner Join OrganizationAddress OA on OA.AddressId=PV.OrgAddressID and OA.OrgID=PV.OrgID
Where O.OrgID in (98) and OI.status='Approve'
Group By O.Name ,O.OrgID,Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3)), Upper(substring(CONVERT(varchar(13),pv.createdAT,107),9,5))
--order by o.OrgID asc
)TT 
Pivot
(
sum(samplecount) for Months in 
([JAN],[FEB],[MAR],[APR],[MAY],[JUN],[JUL],[AUG],[SEP],[OCT],[NOV],[DEC])
) As t 


