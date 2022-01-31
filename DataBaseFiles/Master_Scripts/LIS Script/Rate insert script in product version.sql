Declare @rateid bigint
Declare @raterefid bigint
Declare @Ratename varchar(50)='ARYA HOSPITAL'
Declare @Orgid bigint=106

set @rateid= (select rateid from ratemaster where ratename=@Ratename and Orgid=@Orgid)
set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)


Declare  @Rate_Insert_Stg Table
(
Type varchar(10),
ID bigint,
RateID bigint,
Rate decimal(18,2),
RateRefID bigint,
createdby bigint,
createdat datetime,
OrgiD int,
IsActive varchar(10)
)

insert into @Rate_Insert_Stg
select  E.Type,E.ID,@rateid,E.[ARYA HOSPITAL],@raterefid,0,getdate(),@Orgid,'Y'--IRM.Rate,E.General,E.ID,IRM.ID,E.type,IRM.Type   
from excel_rate_106 E
left join invratemaster IRM on E.ID=IRM.ID and E.type=IRM.Type and IRM.rateid=@rateid and irm.raterefid=@raterefid
where IRM.id is null  


--insert into invratemaster(Type,ID,RateID,Rate,RateRefID,Createdby,Createdat,OrgiD,IsActive)
select * from  @Rate_Insert_Stg
 

=============================================================================================================================================


Declare @rateid bigint
Declare @raterefid bigint
Declare @Ratename varchar(50)='ARYA HOSPITAL'
Declare @Orgid bigint=106

set @rateid= (select rateid from ratemaster where ratename=@Ratename and Orgid=@Orgid)
set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)


select *
--update IRM set IRM.rate=E.[ARYA HOSPITAL] 
from excel_rate_106 E
inner join invratemaster IRM on E.ID=IRM.ID and E.type=IRM.Type and IRM.rateid=@rateid and irm.raterefid=@raterefid

