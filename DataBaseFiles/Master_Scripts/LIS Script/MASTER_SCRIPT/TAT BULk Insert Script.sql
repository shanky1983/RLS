


Select * from Excel_INV15A TM
Inner Join CodeMaster CM (Nolock) On CM.CodeName=TM.Tcode
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvestigationOrgMapping IOM (Nolock) ON IOM.InvestigationID=CP.IdentifyingID 
INNER JOIN InvestigationOrgAttributes IOA (Nolock) ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 
INNER JOIN InvestigationMaster IM (Nolock) ON IM.InvestigationID =IOM.InvestigationID 
WHERE CM.CodeSchemeID =1 
AND CP.IdentifyingType ='Investigations' 
AND IOM.OrgID =108



--------------------------------------------------------------------------------------------------------
Declare @Orgid int = 67


If Exists ( Select 1 From Sys.sysobjects (nolock) Where Type = 'U' And Name = 'TCodeInfo')
Begin
	Drop table TCodeInfo
End
If Exists (	Select 1 From Sys.sysobjects (nolock) Where Type = 'U' And Name = 'Stage_MicroTAT' )
Begin
	Drop table Stage_MicroTAT
End
--If Exists (	Select 1 From Sys.sysobjects (nolock) Where Type = 'U' And Name = 'MicroTAT' )
--Begin
--	Drop table MicroTAT
--End

IF  Exists (Select 1 From Sys.sysobjects(nolock) Where Type='U' And name = 'TmpDetail' )
Begin
	Drop table TmpDetail
End
IF  Exists (Select 1 From Sys.sysobjects(nolock) Where Type='U' And name = 'TempTATDet' )
Begin
	Drop table TempTATDet
End

--Select * From MicroTAT 
Declare @Orgid int = 108

	
	Create table TempTATDet 
	(
	 investigationid bigint,TestType varchar(10),TatType varchar(10),Labstart Decimal(18,2),LabEnd Decimal(18,2),
	 Reporttime Decimal(18,2),ProcessingTime int,Tatmode varchar(1),Daynam varchar(20)
	)

	 Insert TempTATDet(investigationid,TestType,TatType,Labstart,LabEnd,Reporttime,ProcessingTime,Tatmode,Daynam)
	 
	 Select grp.AttGroupID,tmp.Type,RB,Labstart,Labend,Earlyreport,HR,Case When Schedule='Weekly' then 'W' When Schedule='Daily' then 'D' Else 'M' End,TatDays  
	        From MicroTAT TMP
	             Inner join Invorggroup Grp on Grp.AttGroupID = TMP.ID
	             Where GRP.Orgid = @orgID and TMP.Type in ('PKG','GRP')
	 
	 Union all
	 
	 Select INVMAP.InvestigationID,tmp.Type,RB,Labstart,Labend,Earlyreport,HR,Case When Schedule='Weekly' then 'W' When Schedule='Daily' then 'D' Else 'M' End,TatDays  
	        From MicroTAT TMP
	             Inner join investigationOrgmapping INVMAP on TMP.ID = INVMAP.investigationid
	             Where INVMAP.Orgid = @orgID and TMP.Type = 'INV'
	
	
Create table TmpDetail 
( 
 Sno int,Orgid int,Investigationid bigint,TestType varchar(10),TAT Int,Recurrenceid int,RecurrenceCycleid int,
 ScheduleTemplateID int,ResouceTemplateid bigint,
 start Decimal(18,2),labend Decimal(18,2),reporttime Decimal(18,2),WeeklyProcess bit,Weekdays varchar(20),israndom bit 
)

insert TmpDetail
       Select row_Number() Over (Order by t1.investigationid ) ID,@Orgid,t1.investigationid,t1.TestType,t1.ProcessingTime as Tathrs,0,0,0,0,labstart,LabEnd,reporttime,
              case when tatmode = 'W' then 1 else 0 end,daynam,
              case when TatType = 'R' then 1 else 0 end
              From TempTATDet T1(nolock)

Declare @orgid int=108
Declare @Recurrenceid int,@RecurrenceCycleid int,@ScheduleTemplateID int,@ResouceTemplateid bigint

Select @Recurrenceid  = 0 ,@RecurrenceCycleid = 0 ,@ScheduleTemplateID = 0,@ResouceTemplateid  = 0
Select @Recurrenceid = MAX(RecurrenceID) From RecurrenceRelative (nolock)
Select @RecurrenceCycleid = MAX(RecurrenceCycleID) From RecurrenceAbsolute (nolock)
Select @ScheduleTemplateID = MAX(ScheduleTemplateID) From ScheduleTemplate (nolock)
Select @ResouceTemplateid = MAX(ResourceTemplateID) From SchedulableResource (nolock)

Update	TmpDetail set Recurrenceid = isnull(@Recurrenceid,0) +Sno,RecurrenceCycleid = isnull(@RecurrenceCycleid,0) + sno,
		ScheduleTemplateID = isnull(@ScheduleTemplateID,0) + Sno,ResouceTemplateid = isnull(@ResouceTemplateid,0) + sno


Begin Try
 Begin tran
		Set IDENTITY_INSERT RecurrenceRelative ON

			Insert Into RecurrenceRelative(RecurrenceID,[Type],Interval)
			
			Select Recurrenceid,case when WeeklyProcess= 1 then 'W' Else 'D' END,1 From TmpDetail
			
		Set IDENTITY_INSERT RecurrenceRelative OFF

		Set IDENTITY_INSERT RecurrenceAbsolute ON

			Insert into RecurrenceAbsolute (RecurrenceCycleID,RecurrenceID,ParentRecurrenceCycleID,Unit,Value)
			
			Select RecurrenceCycleid,Recurrenceid,0,case when WeeklyProcess= 1 then 'WD' Else 'DD' END,case when WeeklyProcess= 1 then Weekdays Else '1,2,3,4,5,6' END
				   From TmpDetail 
			
		Set IDENTITY_INSERT RecurrenceAbsolute OFF

		Set IDENTITY_INSERT ScheduleTemplate ON
			
			Insert ScheduleTemplate(ScheduleTemplateID,StartTime,EndTime,SlotDuration,RecurrenceID,ParentID,[Level])
			
			Select ScheduleTemplateID,
			cast(case when len(start)= 1  then '0' Else '' End +replace(cast(start as varchar(5)),'.',':')+':00.0000000' as time),
			case when charindex('.',cast(Labend as varchar)) > 0 then  cast(replace(cast(Labend as varchar(5)),'.',':')+':00.0000000' as time) else cast(cast(Labend as varchar(5))+':00:00.0000000' as time) end, 
		   1 ,Recurrenceid,null,null
				   From TmpDetail 
			       
		Set IDENTITY_INSERT ScheduleTemplate OFF

		Set IDENTITY_INSERT SchedulableResource ON

			Insert SchedulableResource(	ResourceTemplateID,ResourceID,ResourceType,OrganizationID,ScheduleTemplateID,CreatedBy,CreatedAt,
										ModifiedBy,ModifiedAt,OrgAddressID,AdditionalContextKey )
			
			Select ResouceTemplateid,investigationid,TestType,Orgid,ScheduleTemplateID,1,GETDATE(),null,null,105,null
				   From TmpDetail T
			       
		Set IDENTITY_INSERT SchedulableResource OFF

			Insert Schedules
			
			select ResouceTemplateid,CAST(GETDATE() as date),CAST(GETDATE() as date),'A',0,GETDATE(),null,null,'Pending' From TmpDetail
			
			Update grp set CUtofftimeType='H',CutoffTimeValue = tmp.TAT,IsTATrandom = israndom
				  ,ReportTime = cast(case when len(tmp.reporttime)= 1  then '0' Else '' End +Replace(Cast(tmp.reporttime as varchar(5)),'.',':')+':00.0000000' as time)
				   --select cast(case when len(tmp.reporttime)= 1  then '0' Else '' End +Cast(tmp.reporttime as varchar)+':00:00.0000000' as time),grp.*
				   from TmpDetail tmp
				   Inner join InvOrgGroup grp (nolock) on tmp.Investigationid = grp.AttGroupID 
				   Where GRP.orgid = tmp.orgid
				   and tmp.TestType in ('GRP','PKG')
			
					Update invmap set CUtofftimeType='H',CutoffTimeValue = tmp.TAT,IsTATrandom = israndom
				   ,ReportTime = cast(case when len(tmp.reporttime)= 1  then '0' Else '' End +Replace(Cast(tmp.reporttime as varchar(5)),'.',':')+':00.0000000' as time)
				   --select cast(case when len(tmp.reporttime)= 1  then '0' Else '' End +Cast(tmp.reporttime as varchar)+':00:00.0000000' as time),inv.*
				   from TmpDetail tmp
				   Inner join investigationmaster inv (nolock) on tmp.Investigationid = inv.investigationid 
				   Inner join investigationorgattributes invmap on inv.investigationid = invmap.Investigationid and invmap.Orgid = tmp.orgid
				   Where 1=1
				   and tmp.TestType = 'INV'
	       
	Commit tran
End try

Begin Catch
	Select ERROR_LINE() 'ERROR_LINE',ERROR_MESSAGE() 'Error Msg'
	Set IDENTITY_INSERT RecurrenceRelative OFF
	Set IDENTITY_INSERT RecurrenceAbsolute OFF
	Set IDENTITY_INSERT ScheduleTemplate OFF
	Set IDENTITY_INSERT SchedulableResource OFF
	rollback tran
End Catch


