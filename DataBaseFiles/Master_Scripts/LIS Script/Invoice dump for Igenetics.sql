SELECT distinct invo.InvoiceNumber,Pv.visitnumber,Pv.visitdate,Ora.location, COnvert(varchar,invo.FromDate,103)+'-'+COnvert(varchar,invo.TODate,103) 
InvoicePeriod,
FM.Billnumber,P.NAme as PatienName,CM.ClientCode,CM.ClientName,ReferingPhysicianName,bd.FeeDescription,
BD.Actualamount MRPAmount,BD.Amount as NetAmount,BD.Feetype,OI.Status   from  invoice invo 
INNER join  InvoiceDetails ivD on  invo.Invoiceid=ivD.InvoiceID 
INNER join ClientMaster CM on CM.ClientID=Invo.ClientID and invo.OrgID=CM.ORGID
INNER join FinalBill FM(nolock) on FM.FinalBillID=ivD.FinalBillID  and FM.OrgID=CM.OrgID
Inner join Billingdetails bd(nolock) on bd.finalbillid=FM.finalbillid and bd.OrgID=FM.OrgID
INNER join PatientVisit PV(nolock) on PV.PatientVisitId=FM.VisitID and PV.OrganizationID=BD.OrgID
INNER join Patient P(nolock) on P.PatientId=PV.PatientId and PV.OrganizationID=P.OrganizationID
INNER join OrganizationAddress Ora on ORa.AddressID=PV.OrgAddressID and P.OrganizationID=Ora.OrganizationID
inner join OrderedInvestigations oi on PV.PatientVisitId=oi.VisitID and oi.id=bd.FeeId
left join AmountRefundDetails ARD on ARD.FinalBillID=FM.finalbillid and ard.BillingDetailsID=bd.BillingDetailsID and P.OrganizationID=ARD.OrgID
WHere PV.OrganizationID=77  and cm.ISCash='N' and invo.fromdate between '01 Apr 2016 00:00:00' and '30 Apr 2016 23:59:59'
    and     ARD.BillStatus is null  and OI.PKGID is null

UNION ALL

SELECT distinct invo.InvoiceNumber,Pv.visitnumber,Pv.visitdate,Ora.location, COnvert(varchar,invo.FromDate,103)+'-'+COnvert(varchar,invo.TODate,103) 
InvoicePeriod,
FM.Billnumber,P.NAme as PatienName,CM.ClientCode,CM.ClientName,ReferingPhysicianName,bd.FeeDescription,
BD.Actualamount MRPAmount,BD.Amount as NetAmount,BD.Feetype,OI.Status   from  invoice invo 
INNER join  InvoiceDetails ivD on  invo.Invoiceid=ivD.InvoiceID 
INNER join ClientMaster CM on CM.ClientID=Invo.ClientID and invo.OrgID=CM.ORGID
INNER join FinalBill FM(nolock) on FM.FinalBillID=ivD.FinalBillID  and FM.OrgID=CM.OrgID
Inner join Billingdetails bd(nolock) on bd.finalbillid=FM.finalbillid and bd.OrgID=FM.OrgID
INNER join PatientVisit PV(nolock) on PV.PatientVisitId=FM.VisitID and PV.OrganizationID=BD.OrgID
INNER join Patient P(nolock) on P.PatientId=PV.PatientId and PV.OrganizationID=P.OrganizationID
INNER join OrganizationAddress Ora on ORa.AddressID=PV.OrgAddressID and P.OrganizationID=Ora.OrganizationID
inner join OrderedInvestigations oi on PV.PatientVisitId=oi.VisitID and oi.PKGid=bd.FeeId
left join AmountRefundDetails ARD on ARD.FinalBillID=FM.finalbillid and ard.BillingDetailsID=bd.BillingDetailsID and P.OrganizationID=ARD.OrgID
WHere PV.OrganizationID=77  and cm.ISCash='N' and invo.fromdate between '01 Apr 2016 00:00:00' and '30 Apr 2016 23:59:59'
    and     ARD.BillStatus is null  and OI.PKGID is not null
order by InvoiceNumber,visitdate  


--select * from patientvisit where visitnumber='15100010839'

--select * from orderedinvestigations where visitid=48268 

--select * from finalbill where VisitID=48268 
--select * from billingdetails  where finalbillid=48586

--select * from billingdetails where visitid=48268 
