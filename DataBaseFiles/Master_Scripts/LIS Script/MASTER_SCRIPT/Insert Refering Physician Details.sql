select * from ReferingPhysician_bck from ReferingPhysician where OrgID=85

--delete from ReferingPhysician where OrgID=85
Excel_RefPhy_127


select * from ReferingPhysician where OrgID=67

select *  from ReferingPhysician where orgid=146

select * from addressdetails where orgid=67 and referencetype='refphy'
select * from Excel_Ref_Phy_67

insert into ReferingPhysician(physicianname,orgid,salutation,isactive,registrationtype,parentreferingphysicianid,PhysicianCode)
select PhysicianName,67,14,'Y','P',0,physiciancode from Excel_Ref_Phy_67
select * from country where countryname like '%sri%'

--insert into addressdetails(ReferenceID,ReferenceType,EmailID,OrgID,IsCommunication,CreatedBy,CreatedAt,countryid)
select rp.ReferingPhysicianID,
'RefPhy',
'',
67,
'Y',
368,
GETDATE(),
158
from ReferingPhysician rp
inner join Excel_Ref_Phy_67 DRP on rp.PhysicianCode=DRP.PhysicianCode 
left join addressdetails AD on rp.ReferingPhysicianID=AD.ReferenceID
where AD.ReferenceID is null and rp.orgid=67


select * from organizationaddress where orgid=67

select * from invclienttype

select * from clientmaster where orgid=67

--insert into clientmaster(clientcode,clientname,approvalrequired,clientstatus,orgid,createdby,createdat,orgaddressid,status,clienttypeid,attributes,zonalid,customertype,reporttemplateid,iscash,isparentpayer,isdiscount,
blockfrom,blockto,ismappeditem,printorgaddressid,invoiceorgid)
select ClientCode,ClientName,'N','N',67,368,getdate(),104,'A',4,'<ClientAttributes></ClientAttributes>',0,64,16,'N','N','N','1753-01-01 00:00:00.000','1753-01-01 00:00:00.000','N',104,67 from Excel_Client_67


--insert into addressdetails(addresstypeid,ReferenceID,ReferenceType,EmailID,OrgID,IsCommunication,CreatedBy,CreatedAt,countryid,stateid)
select 0,
cm.clientid,
'client',
'',
67,
'Y',
368,
GETDATE(),
158,
3028
from clientmaster cm
inner join Excel_Client_67 DRP on cm.ClientCode=DRP.ClientCode 
left join addressdetails AD on cm.clientid=AD.ReferenceID
where AD.ReferenceID is null and cm.orgid=67


select * from addressdetails where orgid=67 and referencetype='Client'

select * from invclientmaster where orgid=67

insert into invclientmaster(clientid,orgid,clientname,clienttypeid,activeYN,rateid,validfrom,validto,priority,createdby,createdat,transferrate,baserate)
select Clientid,67,ClientName,4,'Y',rateid,'20131001 00:00:00.000','99991231 00:00:00.000',1,368,getdate(),'Y','N' from Excel_Client_Mapping_67



