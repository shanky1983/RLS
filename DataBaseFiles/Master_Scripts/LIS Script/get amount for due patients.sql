select P.Patientid,P.Patientnumber,PV.Visitnumber,FB.AmountReceived,FB.DUE,P.name,PV.VisitDate,cm.Clientname,CM.iscash 
from patientvisit PV  (nolock) 
inner join Patient P (nolock) on PV.patientid=P.patientid and PV.OrganizationID=P.OrganizationID
inner join finalbill FB  (nolock) on PV.Patientvisitid=FB.Visitid and PV.OrganizationID=FB.OrgID
inner join visitclientmapping VCM (NoLock) on VCM.Visitid=PV.Patientvisitid and VCM.finalbillid=FB.FinalBillID
inner join clientmaster  CM on VCM.clientid=CM.clientid and VCM.OrgID=CM.Orgid
where PV.OrganizationID=69 and PV.VisitDate between '25 FEB 2016 00:00:00' and '25 FEB 2016 23:59:59' 

order by PV.patientid