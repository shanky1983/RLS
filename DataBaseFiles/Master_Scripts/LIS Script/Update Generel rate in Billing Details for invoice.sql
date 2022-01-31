Pssrsinvoiceprintingreport 205,153,234,7315,'Original'

select * from invoice where orgid=153

select * from login where orgid=153

select * from   ClientName like '%Adarsh%' and clientid=7335

select * from patientvisit where orgid=153 and visitnumber='66096'
select * from invclientmaster where orgid=153 and clientid=7315
select * from finalbill where visitid=66096
select * from billingdetails where orgid=153 and FeeType='GRP' and iscreditbill='Y'  finalbillid=60172
select * from visitclientmapping where visitid=66096
select bd.amount,Actualamount,irm.rate from billingdetails bd inner join invratemaster irm on irm.id=bd.feeid and irm.type=bd.feetype  
 where irm.type='INV' and irm.rateid=419 and  finalbillid=60172

 update bd set actualamount=irm.rate from billingdetails bd inner join invratemaster irm on irm.id=bd.feeid and irm.type=bd.feetype  
 where irm.type='INV' and irm.rateid=419 and  finalbillid=60172



 



 select bd.actualamount,irm.rate,bd.amount,BD.Iscreditbill,BD.FeeDescription,BD.FeeType,BD.Feeid 
 --update BD set BD.ActualAmount=irm.rate 
 from patientvisit PV
 inner join finalbill FB on FB.visitid=PV.patientvisitid and FB.patientid=PV.Patientid and FB.Orgid=PV.Orgid
 inner join Billingdetails BD on FB.FinalBillID=BD.FinalBillID and FB.Orgid=BD.Orgid
 --inner join INVORGGROUP IOG ON IOG.Attgroupid=BD.feeid and IOG.orgid=BD.orgid
 inner join invratemaster irm on irm.id=BD.Feeid and irm.type=bd.feetype
 where IRM.type='INV' and irm.rateid=419 and BD.feetype='INV' and PV.Orgid=153 and BD.Iscreditbill='Y'



 select bd.actualamount,irm.rate,bd.amount,BD.Iscreditbill,BD.FeeDescription,BD.FeeType,BD.Feeid 
 --update BD set BD.ActualAmount=irm.rate 
 from patientvisit PV
 inner join finalbill FB on FB.visitid=PV.patientvisitid and FB.patientid=PV.Patientid and FB.Orgid=PV.Orgid
 inner join Billingdetails BD on FB.FinalBillID=BD.FinalBillID and FB.Orgid=BD.Orgid
 inner join INVORGGROUP IOG ON IOG.Attgroupid=BD.feeid and IOG.orgid=BD.orgid
 inner join invratemaster irm on irm.id=IOG.Orggroupid and irm.type=bd.feetype
 where IRM.type='GRP' and irm.rateid=419 and BD.feetype='GRP' and PV.Orgid=153 and BD.Iscreditbill='Y'



 
 select bd.actualamount,irm.rate,bd.amount,BD.Iscreditbill,BD.FeeDescription,BD.FeeType,BD.Feeid 
 --update BD set BD.ActualAmount=irm.rate 
 from patientvisit PV
 inner join finalbill FB on FB.visitid=PV.patientvisitid and FB.patientid=PV.Patientid and FB.Orgid=PV.Orgid
 inner join Billingdetails BD on FB.FinalBillID=BD.FinalBillID and FB.Orgid=BD.Orgid
 inner join INVORGGROUP IOG ON IOG.Attgroupid=BD.feeid and IOG.orgid=BD.orgid
 inner join invratemaster irm on irm.id=IOG.Orggroupid and irm.type=bd.feetype
 where IRM.type='PKG' and irm.rateid=419 and BD.feetype='PKG' and PV.Orgid=153 and BD.Iscreditbill='Y'



 select * from ratemaster where orgid=153

select * from invclientmaster where clientid=7315
select * from invratemaster where rateid=419 and id=31755
select * from invratemaster where rateid=419 and id=25701
select * from invratemaster where rateid=419 and id=25674
select * from invratemaster where rateid=428 and id=25674
select * from ratemaster where rateid=428
select * from ratemaster where rateid=419
select * from invclientmaster where clientid=7285