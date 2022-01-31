select *    from clientmaster where orgid=80 and clientname<>'GENERAL' and clientcode<>'GENERAL'
select * from organizationaddress where orgid=80




/*===============insert data into clientmaster Table ============*/


insert into clientmaster(clientcode,clientname,DespatchModeID,ApprovalRequired,Clientstatus,orgid,createdBy,CreatedAt,Orgaddressid,status,clienttypeID,
attributes,ZonalID,salesManID,creditlimit,customertype,reporttemplateid,creditdays,gracelimit,gracedays,parentclientid,collectioncenterID,IsCash,IsParentPayer,HubID,Paymentdays,referingID,TodID,IsDiscount,Blockfrom,Blockto,IsMappedItem,
AuthorizedBy,Transittimevalue,Transittimetype,DiscountpolicyID,VolID,RouteID,PromisedAmount,invoicecycle,printorgaddressid,invoiceorgid)

select stg.ClientCode,stg.ClientName,0,'N','N',80,0,getdate(),128,stg.status,stg.clienttypeid,
'<ClientAttributes></ClientAttributes>',stg.zonalid,0,0,3356,stg.reporttemplateid,stg.creditdays,0,0,0,0,stg.IScash,'N',0,0,0,0,'N','1753-01-01 00:00:00.000','1753-01-01 00:00:00.000','N',
0,0,0,0,0,0,0,null,0,80
from Excel_Client_80 stg
--inner join invclienttype CT on stg.ClientType=CT.ClientTypeName
Left join clientmaster CM on stg.ClientCode=cm.ClientCode and stg.ClientName=cm.clientname and cm.Orgid=159
where cm.clientcode is null 



 
/*===============insert data into addressdetails Table ============*/

--select *    from  addressdetails  where orgid=77 and referencetype='client' and referenceid<>3558


insert into addressdetails(AddressTypeID,ReferenceID,ReferenceType,Address1,City,CountryID,StateID,EmailID,Phone,Mobile,FaxNumber,OrgID,IsCommunication,CreatedBy,CreatedAt,
ISDCode,Name,ContactType,EmpID,SubUrban)

select 0,CM.clientid,'Client',stg.address1,stg.city,75,stg.StateID,stg.EmailID,stg.phone,stg.mobile,stg.FaxNumber,80,stg.iscommunication,0,getdate(),
stg.ISDCode,'Client','CLT',stg.empid,'' from clientmaster CM
inner join Excel_Address_80 stg on stg.clientcode=CM.clientcode and stg.clientname=cm.clientname
left join addressdetails AD on cm.ClientID=AD.ReferenceID  and AD.OrgID=80 and AD.referencetype='client'and AD.AddressTypeID=0 
where AD.ReferenceID is null and cm.orgid=80


--insert into addressdetails(AddressTypeID,ReferenceID,ReferenceType,Address1,City,CountryID,StateID,EmailID,Phone,Mobile,FaxNumber,OrgID,IsCommunication,CreatedBy,CreatedAt,
--ISDCode,Name,ContactType,EmpID,SubUrban)

select 1,CM.clientid,'Client',stg.address,stg.city,75,31,'',stg.phone,stg.mobile,'',127,'Y',0,getdate(),
0,'Client','CLT',-1,'' from clientmaster CM
inner join Excel_Clinet_127 stg on stg.clientcode=CM.clientcode and stg.clientname=cm.clientname
left join addressdetails AD on cm.ClientID=AD.ReferenceID  and AD.OrgID=127  and AD.AddressTypeID=0 and AD.referencetype='client'
where AD.ReferenceID is null 


/*===============insert data into InvClientMaster Table ============*/

--select *  from InvClientMaster where orgid=80 and  clientname<>'GENERAL' and clientid<>3558

--insert into InvClientMaster(ClientID,Orgid,Clientname,clienttypeid,ActiveYN,Rateid,validfrom,validto,priority,createdby,createdat,validfromtime,validtotime,Transferrate,Baserate)
select CM.clientid,80,CM.Clientname,stg.Clienttypeid,'Y',stg.RateID,'17530101 00:00:00.000','99990101 00:00:00.000',stg.priority,0,getdate(),'00:00:00.0000000','23:59:59.9990000','N',stg.BaseRate
from Excel_ClinetMapping_80 stg
inner join Clientmaster CM on stg.Clientcode=CM.clientcode and stg.Clientname=CM.Clientname
left join InvClientMaster ICM on ICM.clientid=cm.clientid --and ICM.OrgID=159
where ICM.clientid is null and cm.orgid=80



select top 20 * from sys.sysobjects where type='U' order by crdate desc 

  
select stg.* 
--update stg set stg.Rateid=RM.Rateid 
from Excel_Client_Mapping_296 stg
inner join ratemaster RM on stg.RateCardName=RM.RateName
where RM.Orgid=296
select * from Excel_Client_296

select * from organization

select MV.MetaValueID,MV.Value,MT.Code from MetaType_Common MT WITH(NOLOCK)          
  inner join MetaValue_Common MV WITH(NOLOCK) on MV.MetaTypeId=MT.MetaTypeId and MV.OrgID=80  and value like '%LAB%'
--  AND MetaValueID IN (13282)






