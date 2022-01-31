Declare @rateid bigint
Declare @raterefid bigint
Declare @Ratename varchar(50)='RATE CARD 30'
Declare @Orgid bigint=69

set @rateid= (select rateid from ratemaster where ratename=@Ratename and Orgid=@Orgid)
set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)
--select  @raterefid
--select @rateid
--select * from [Excel_Rate_Updation]

Declare @Rate_Update_Stg table
(
Type varchar(10),
ID bigint,
RateID bigint,
Rate decimal(18,2),
RateRefID bigint,
OrgiD int,
RatecardRate decimal(18,2)
)
insert into @Rate_Update_Stg
select  E.Type,IRM.ID,@rateid,IRM.Rate,@raterefid,@orgid,E.[RATE CARD 30] --IRM.Rate,E.General,E.ID,IRM.ID,E.type,IRM.Type   
from [Excel_Rate_Updation] E
inner join invratemaster IRM  on E.ID=IRM.ID and E.type=IRM.Type
where rateid=@rateid and raterefid=@raterefid

--select *    
update IRM set IRM.Rate=E.RatecardRate 
from @Rate_Update_Stg E
inner join invratemaster IRM with (Nolock) on E.ID=IRM.ID and E.type=IRM.Type and e.RateID=irm.RateID and e.RateRefID=irm.RateRefID
where IRM.rateid=@rateid and IRM.raterefid=@raterefid



============================================================================
Declare @rateid bigint
Declare @raterefid bigint
Declare @Ratename varchar(50)='RATE CARD 30'
Declare @Orgid bigint=69

set @rateid= (select rateid from ratemaster where ratename=@Ratename and Orgid=@Orgid)
set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)


Create Table Rate_Insert_Stg
(
Type varchar(10),
ID bigint,
RateID bigint,
Rate decimal(18,2),
RateRefID bigint,
Status varchar(20),
OrgiD int
)

insert into Rate_Insert_Stg
select  E.Type,E.ID,@rateid,E.[RATE CARD 30],@raterefid,'Y',@Orgid --IRM.Rate,E.General,E.ID,IRM.ID,E.type,IRM.Type   
from [Excel_Rate_Updation] E
left join invratemaster IRM on E.ID=IRM.ID and E.type=IRM.Type and IRM.rateid=@rateid and irm.raterefid=@raterefid
where IRM.id is null  

select * from Rate_Insert_Stg

insert into invratemaster(Type,ID,RateID,Rate,RateRefID,Status,OrgiD)
select * from  Rate_Insert_Stg
 
 
 --drop table Rate_Insert_Stg





 