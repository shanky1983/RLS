select top 5 * from sys.sysobjects where type='U' order by crdate desc


 select * from  [Excel_Enhancement_296]
CREATE   PROCEDURE pUploadClientFeeCustomization
(
@pOrgId INT
)
as
BEGIN 


If Exists(Select 1 From Sys.sysobjects(nolock) Where TYPE = 'U'	And name = 'ExcelTemp_RoomBasedFee')
		Begin
			Drop table ExcelTemp_RoomBasedFee
		End
-----excel import ExcelTemp_RoomBasedFee


select * into ExcelTemp_RoomBasedFee from [Excel_Enhancement_296]

Declare  @pOrgId int=296
UPDATE R SET R.ClientId=I.ClientID
FROM ExcelTemp_RoomBasedFee  R
JOIN ClientMaster I on 
R.ClientName=i.ClientName
and i.OrgID=@pOrgId


Declare  @OrgId int=296
UPDATE ExcelTemp_RoomBasedFee  
SET [FeeId]=Tmp.FeeId
from
(
SELECT T.[FeeType],G.GenBillID as [FeeId],G.GenBillName as [FeeDesc]
FROM ExcelTemp_RoomBasedFee T WITH (NOLOCK)
JOIN GeneralBillingMaster G on 
t.[FeeDescription]=g.GenBillName
where T.[FeeType]='GEN'
and g.OrgID=@OrgID
UNION ALL 


SELECT T.[FeeType],i.InvestigationID as [FeeId],I.displaytext [FeeDesc]
FROM ExcelTemp_RoomBasedFee T WITH (NOLOCK)
JOIN InvestigationOrgMapping i ON
 I.DISPLAYTEXT=T.[FeeDescription]
--JOIN InvRateMaster G ON 
--i.InvestigationID=g.ID
where T.[FeeType]='INV'
and I.OrgID=@OrgID

UNION ALL 



SELECT T.[FeeType],G.AttGroupID as [FeeId],G.DisplayText [FeeDesc]
FROM ExcelTemp_RoomBasedFee T WITH (NOLOCK)
JOIN InvOrgGroup G on 
t.[FeeDescription]=g.DisplayText
where T.[FeeType]='GRP'
and g.OrgID=@OrgID

UNION ALL 

SELECT T.[FeeType],G.AttGroupID as [FeeId],G.DisplayText[FeeDesc]
FROM ExcelTemp_RoomBasedFee T WITH (NOLOCK)
JOIN InvOrgGroup G on 
t.[FeeDescription]=g.DisplayText
where T.[FeeType]='PKG'
and g.OrgID=@OrgID
UNION ALL 


SELECT T.[FeeType],G.ProcedureID as [FeeId],G.ProcedureName[FeeDesc]
FROM ExcelTemp_RoomBasedFee T WITH (NOLOCK)
JOIN ProcedureMaster G on 
t.[FeeDescription]=g.ProcedureName
where T.[FeeType]='PRO'
and g.OrgID=@OrgID

UNION ALL 

SELECT T.[FeeType],G.OrgSpecialityID as [FeeId],G.Name[FeeDesc]
FROM ExcelTemp_RoomBasedFee T WITH (NOLOCK)
JOIN OrganizationSpeciality G on 
t.[FeeDescription]=g.Name
where  T.[FeeType]='SPE'
and g.OrgID=@OrgID
)Tmp 
WHERE [FeeDescription]=Tmp.[FeeDesc]

--select * from
update stg set stg.RoomtypeID=RT.RoomtypeID from ExcelTemp_RoomBasedFee stg
inner join Roomtype RT on stg.RoomName=RT.RoomTypeName
where RT.orgid=296

insert into ClientFeeTypeRateCustomization(ClientID,FeeType,RoomTypeID,DiscOrEnhancePercent,DiscOrEnhanceType,Applyby,FeeID)
select ClientID,[FeeType] FeeType,RoomTypeID,DiscOrEnhancePercent,DiscOrEnhanceType,Applyby,[FeeId]FeeID
 from ExcelTemp_RoomBasedFee
 where Clientid is not null
 and [feeid] is not null
 and RoomTypeID is not null

 
	

END 





