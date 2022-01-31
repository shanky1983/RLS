select Distinct PV.VisitNumber,PV.VisitDate,PV.Organizationid,OA.Location,FB.BillNumber,BD.FeeDescription as TestName,BD.FeeType,OI.Status,CM.Clientcode,
Cm.ClientName,
CM.IsCash,
BD.ActualAmount as MRPAmount,BD.amount As Billedamount 
from patientvisit(nolock) PV inner join orderedinvestigations(nolock) OI 
on PV.patientvisitid=oi.visitid
inner join finalbill(nolock) FB on FB.visitid=PV.patientvisitid
inner join visitclientmapping(nolock) VCM on PV.patientvisitid=VCM.visitid
inner join clientmaster(nolock) CM on VCM.clientid=CM.clientid
inner join billingdetails(nolock) BD on BD.finalbillid=fb.finalbillid and  OI.ID=BD.FeeId
inner join organizationaddress OA on OA.AddressID=oi.ResCaptureLoc
where   PV.organizationid in (77)
and CM.Iscash='Y' and OI.PKGID is null and PV.createdat between '01 APR 2016' and '30 Apr 2016 23:59' --and VisitNumber in ('16160406680')


union all


select Distinct PV.VisitNumber,PV.VisitDate,PV.Organizationid,OA.Location,FB.BillNumber,BD.FeeDescription as TestName,BD.Feetype,OI.Status,CM.Clientcode,
Cm.ClientName,
CM.IsCash,
BD.ActualAmount as MRPAmount,BD.amount As Billedamount 
from patientvisit(nolock) PV inner join orderedinvestigations(nolock) OI 
on PV.patientvisitid=oi.visitid
inner join finalbill(nolock) FB on FB.visitid=PV.patientvisitid
inner join visitclientmapping(nolock) VCM on PV.patientvisitid=VCM.visitid
inner join clientmaster(nolock) CM on VCM.clientid=CM.clientid
inner join billingdetails(nolock) BD on BD.finalbillid=fb.finalbillid and  OI.PKgid=BD.FeeId
inner join organizationaddress OA on OA.AddressID=oi.ResCaptureLoc
where   PV.organizationid=77
and CM.Iscash='Y' and OI.PkgID is not  null and PV.createdat between '01 Apr 2016' and '30 Apr 2016 23:59' -- and VisitNumber in ('16160406680')
Order by Visitnumber,Visitdate,Organizationid