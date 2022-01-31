select * from sys.sysobjects where type='U' and name like '%lakotia%'order by crdate desc

select * from Excel_RateCard_Lakotia where type ='grp'id is null

select *   from invratemaster where orgid=296

select * from ratemaster where orgid=296  --186

select * from ratereforgmapping where rateid=186 ---204

select *   from invratemaster where orgid=293 where rateid=186 and orgid=304

insert into invratemaster 
select
'INV',
investigationid,
186,
Rate,
NULL,
204,
null,
368,
getdate(),
null,
null,
122,
'Y',
from Excel_INV_304  where type='INV'




insert into invratemaster 
select
'GRP',
orggroupid,
186,
Rates,
NULL,
204,
null,
368,
getdate(),
null,
null,
122,
'Y'
from Excel_GRP_304  where type='GRP'



insert into invratemaster 
select
'PKG',
testid,
260,
Rate,
NULL,
3339,
null,
368,
getdate(),
null,
null,
90,
'Y' 
from Excel_RateCard_Lakotia  where type='PKG'



update rm set rm.Rate= e.rate 
 from Excel_dishari_PKG_Rate E 
inner join invratemaster RM on rm.id=E.orggroupid where rm.type='PKG' and rm.rateid=1 and rm.RateRefID=1
 