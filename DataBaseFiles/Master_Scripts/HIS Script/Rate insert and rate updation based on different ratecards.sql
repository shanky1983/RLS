Declare @rateid bigint
Declare @raterefid bigint
Declare @Ratename varchar(50)='GENERAL'
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
OPRate decimal(18,2),
IPRate decimal(18,2)
)
insert into @Rate_Update_Stg
select  E.Type,IRM.ID,@rateid,IRM.Rate,@raterefid,@orgid,E.[GENERAL_OP],[GENERAL_IP] --IRM.Rate,E.General,E.ID,IRM.ID,E.type,IRM.Type   
from [Excel_Rate_Updation] E
inner join invratemaster IRM  on E.ID=IRM.ID and E.type=IRM.Type
where rateid=@rateid and raterefid=@raterefid

select *    
--update IRM set IRM.Rate=E.OPRate,IRM.IPAmount=E.[IPRate]
from @Rate_Update_Stg E
inner join invratemaster IRM with (Nolock) on E.ID=IRM.ID and E.type=IRM.Type and e.RateID=irm.RateID and e.RateRefID=irm.RateRefID
where IRM.rateid=@rateid and IRM.raterefid=@raterefid



============================================================================
Declare @rateid bigint
Declare @raterefid bigint
Declare @Ratename varchar(50)='ECHS'
Declare @Orgid bigint=296

set @rateid= (select rateid from ratemaster where ratename=@Ratename and Orgid=@Orgid)
set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)



Declare  @Rate_Insert_Stg Table
(
Type varchar(10),
ID bigint,
RateID bigint,
Rate decimal(18,2),
IPAmount decimal(18,2),
RateRefID bigint,
CreatedBY int,
CreatedAt datetime,
isActive varchar(20),
versionid int,
OrgiD int
)

insert into @Rate_Insert_Stg
select  'INV',E.InvestigationID,@rateid,E.[ECHS_OP],E.[ECHS_IP],@raterefid,0,getdate(),'Y',0,@Orgid --IRM.Rate,E.General,E.ID,IRM.ID,E.type,IRM.Type   
from Stage_MHL_T_01_TESTMASTER E
left join invratemaster IRM on E.InvestigationID=IRM.ID and IRM.rateid=@rateid and irm.raterefid=@raterefid and IRM.Orgid=@OrgID
where IRM.id is null-- and IRM.Orgid=@OrgID



insert into invratemaster(Type,ID,RateID,Rate,IPAmount,RateRefID,CreatedBy,CreatedAt,IsActive,VersionID,OrgiD)
select * from  @Rate_Insert_Stg







 