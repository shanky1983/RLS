



Select * from 
(
Select O.Name ,O.Organizationid,'TotalCount'as samples, count(PIS.samplecode)sampleCount ,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))MOnths
from PatientVisit PV(Nolock)
Inner Join PatientInvsample PIS (Nolock) On PV.Patientvisitid=PIS.PAtientvisitid and PV.Organizationid=PIS.Orgid
Inner Join Organization O (Nolock)ON O.Organizationid=PV.Organizationid
Where O.Organizationid in (69,77,80)
Group By O.Name ,O.Organizationid,Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))
--order by Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))
)TT
Pivot
(
sum(samplecount) for Months in 
([JAN],[FEB],[MAR],[APR],[MAY],[JUN],[JUL],[AUG],[SEP],[OCT],[NOV],[DEC])
) As t



Select * from 
(
Select O.Name ,O.Organizationid,'TotalCount'as VisitCOUNTS,COUNT(PV.Patientvisitid)visitCount,
Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))MOnths from PatientVisit PV(Nolock)
Inner Join Organization O (Nolock)ON O.Organizationid=PV.Organizationid
Where O.Organizationid in (69,77,80)
Group BY O.Name ,O.Organizationid,Upper(substring(CONVERT(varchar(13),pv.createdAT,107),1,3))
)TT
Pivot
(
sum(visitCount) for Months in 
([JAN],[FEB],[MAR],[APR],[MAY],[JUN],[JUL],[AUG],[SEP],[OCT],[NOV],[DEC])
) As t

