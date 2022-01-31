select *  from clientmaster where orgid=296 and clientname<>'GENERAL' and clientcode<>'GENERAL'


/*===============insert data into clientmaster Table ============*/


--insert into clientmaster(clientcode,clientname,DespatchModeID,ApprovalRequired,Clientstatus,orgid,createdBy,CreatedAt,Orgaddressid,status,clienttypeID,
--attributes,ZonalID,salesManID,creditlimit,customertype,reporttemplateid,creditdays,gracelimit,gracedays,parentclientid,collectioncenterID,IsCash,IsParentPayer,HubID,Paymentdays,referingID,TodID,IsDiscount,Blockfrom,Blockto,IsMappedItem,
--AuthorizedBy,Transittimevalue,Transittimetype,DiscountpolicyID,VolID,RouteID,PromisedAmount)

select stg.ClientCode,stg.ClientName,0,'N','N',296,0,getdate(),100,'A',CT.clienttypeid,
'<ClientAttributes></ClientAttributes>',0,0,0,12866,0,0,0,0,0,0,stg.IScashClient,'N',0,0,0,0,'N','99991231 00:00:00.000','99991231 00:00:00.000','N',
0,0,0,0,0,0,0
from Excel_Client_296 stg
inner join invclienttype CT on stg.ClientType=CT.ClientTypeName
Left join clientmaster CM on stg.ClientCode=cm.ClientCode and stg.ClientName=cm.clientname and cm.Orgid=296
where cm.clientcode is null 








/*===============insert data into addressdetails Table ============*/

--select *  from addressdetails where orgid=296 and referencetype='client' and createdby<>7962

--insert into addressdetails(AddressTypeID,ReferenceID,ReferenceType,Address1,City,CountryID,StateID,EmailID,Phone,Mobile,FaxNumber,OrgID,IsCommunication,CreatedBy,CreatedAt,
--ISDCode,Name,ContactType,EmpID,SubUrban,CountryCode,StateCode,CityCode,AddLevel1,AddLevel2)

select 0,CM.clientid,'Client','','',0,0,'',1111,'','',296,'Y',0,getdate(),
0,'Client','CLT',-1,'',86,0,0,0,0 from clientmaster CM
inner join Excel_Client_296 stg on stg.clientcode=CM.clientcode and stg.clientname=cm.clientname
left join addressdetails AD on cm.ClientID=AD.ReferenceID  and AD.OrgID=296  and AD.AddressTypeID=0 and AD.referencetype='client'
where AD.ReferenceID is null 


--insert into addressdetails(AddressTypeID,ReferenceID,ReferenceType,Address1,City,CountryID,StateID,EmailID,Phone,Mobile,FaxNumber,OrgID,IsCommunication,CreatedBy,CreatedAt,
--ISDCode,Name,ContactType,EmpID,SubUrban,CountryCode,StateCode,CityCode,AddLevel1,AddLevel2)

select 1,clientid,'Client','Baroda','',0,0,'',1111,'','',296,'Y',0,getdate(),
0,'','CLT',0,'Y',86,0,0,0,0 from clientmaster CM
inner join Excel_Client_296 stg on stg.clientcode=CM.clientcode and stg.clientname=cm.clientname
left join addressdetails AD on cm.ClientID=AD.ReferenceID and AD.AddressTypeID=1 and AD.OrgID=296 and  AD.referencetype='client'
where AD.ReferenceID is null



/*===============insert data into InvClientMaster Table ============*/

--select *  from InvClientMaster where orgid=296 and  clientname<>'GENERAL' and clientid<>768

--insert into InvClientMaster(ClientID,Orgid,Clientname,clienttypeid,ActiveYN,Rateid,validfrom,validto,priority,createdby,createdat,validfromtime,validtotime,Transferrate,ApplicableDays,Baserate)
select CM.clientid,296,CM.Clientname,ICT.Clienttypeid,'Y',stg.RateID,'17530101 00:00:00.000','99990101 00:00:00.000',stg.priority,0,getdate(),'00:00:00.0000000','23:59:59.9990000','N','',stg.ISBaseRate
from Excel_Client_Mapping_296 stg
inner join Clientmaster CM on stg.Clientcode=CM.clientcode and stg.Clientname=CM.Clientname
inner join INVClienttype ICT On ICT.ClientTypeName=stg.ClientType 
left join InvClientMaster ICM on  CM.clientname=ICM.Clientname and stg.rateid=ICM.rateid and CM.clientid=ICM.Clientid and ICM.OrgID=296
where ICM.clientid is null



select top 20 * from sys.sysobjects where type='U' order by crdate desc 

  
select stg.* 
--update stg set stg.Rateid=RM.Rateid 
from Excel_Client_Mapping_296 stg
inner join ratemaster RM on stg.RateCardName=RM.RateName
where RM.Orgid=296
select * from Excel_Client_296



select MV.MetaValueID,MV.Value,MT.Code from MetaType_Common MT WITH(NOLOCK)          
  inner join MetaValue_Common MV WITH(NOLOCK) on MV.MetaTypeId=MT.MetaTypeId and MV.OrgID=296  
--  AND MetaValueID IN (13282)






