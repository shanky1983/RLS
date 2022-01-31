

Declare @OrgID int=69
Declare @rateid table(rateid int)
insert into  @rateid
select ICM.rateid from visitclientmapping VM 
inner join Finalbill FB on FB.Finalbillid=Vm.finalbillid and FB.orgid=VM.orgid
inner join INVclientmaster ICM on ICM.clientid=VM.clientid  and ICM.ORGID=VM.orgid 
where VM.orgid=69 and fb.IsCreditBill='Y' and ICM.Priority<>1
--select * from @rateid

select PV.Visitnumber,P.name,CM.Clientname,CM.clientcode,BD.Amount as Amount,RM.RateName,PV.CreatedAT,OI.Name,PV.CreatedAT
from visitclientmapping VM WITH(NOLOCK)
inner join Finalbill FB WITH(NOLOCK) on FB.Finalbillid=Vm.finalbillid and FB.orgid=VM.Orgid
inner join clientmaster CM WITH(NOLOCK) on CM.Clientid=VM.clientid and CM.orgid=VM.orgid
inner join invclientmaster ICM WITH(NOLOCK) on ICM.clientid=VM.clientid and ICM.orgid=VM.orgid 
inner join Patientvisit PV WITH(NOLOCK) on PV.patientvisitid=VM.VisitID and PV.OrganizationID=VM.orgid
inner join Patient P WITH(NOLOCK) on P.Patientid=PV.patientid and PV.OrganizationID=p.OrganizationID
inner join orderedinvestigations OI WITH(NOLOCK) on PV.patientvisitid=OI.visitid and PV.OrganizationID=OI.Orgid
inner join BillingDetails BD WITH(NOLOCK) on FB.finalbillid=BD.finalbillid and BD.orgid=FB.orgid and BD.Feeid=OI.ID
inner join ratemaster RM WITH(NOLOCK) on BD.rateid=RM.Rateid and ICM.Orgid=RM.Orgid
where PV.OrganizationID=@Orgid and fb.IsCreditBill='Y' and ICM.rateid in (select rateid from @Rateid) and ICM.Priority<>1



