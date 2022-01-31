
Declare @orgid int =67
Declare @CodeSchemeID int=1

select Distinct CM.CODENAME AS TCODE,UPPER(SUBSTRING(CP.IdentifyingType,1,3))AS TYPE,VALUE AS TATDAYS,IOA.CUTOFFTIMEVALUE AS HR,
         Replace (convert(varchar(5),STARTTIME),':','.') AS LABSTART,
         Replace (convert(varchar(5),ENDTIME),':','.') AS LABEND,
         Replace (convert(varchar(5),IOA.REPORTTIME),':','.')AS EARLYREPORT,
         CASE WHEN IsTATrandom='0'THEN 'B'ELSE 'R'END AS RB,CASE WHEN UNIT='WD'THEN 'WEEKLY'ELSE 'DAILY'END AS SCHEDULE,
         IOM.INVESTIGATIONID 
         from CodeMaster CM WITH (NOLOCK) 
		 INNER JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
		 INNER Join InvestigationOrgMapping IOM WITH (NOLOCK) ON IOM.InvestigationID=CP.IdentifyingID 
		 INNER JOIN InvestigationOrgAttributes IOA WITH (NOLOCK) ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 
		 INNER JOIN InvestigationMaster IM WITH (NOLOCK) ON IM.InvestigationID =IOM.InvestigationID 
		 Inner join Schedulableresource rs WITH (NOLOCK)on IOA.investigationid = rs.resourceid  
		 and  SUBSTRING(CP.IdentifyingType,1,3)= rs.ResourceType and rs.OrganizationID = @orgid
		 Inner join Scheduletemplate Sche WITH (NOLOCK)on rs.ScheduleTemplateID = sche.ScheduleTemplateID
		 Inner join Schedules SS WITH (NOLOCK)on rs.ResourceTemplateID = ss.ResourceTemplateID
		 Inner join RecurrenceAbsolute ra WITH (NOLOCK) on sche.RecurrenceID = ra.RecurrenceID
		 Inner join Recurrencerelative rr WITH (NOLOCK)on ra.RecurrenceID = rr.RecurrenceID
		 WHERE CM.CodeSchemeID =@CodeSchemeID AND CP.IdentifyingType ='Investigations' AND IOM.OrgID =@orgid
		 --and CM.CodeName=@Codename
		 --And IOM.DeptID=@Deptid
	 
Union all
 		
Select Distinct  CM.CODENAME AS TCODE,CP.IdentifyingType AS TYPE,VALUE AS TATDAYS,IOM.CUTOFFTIMEVALUE AS HR,
         Replace (convert(varchar(5),STARTTIME),':','.') AS LABSTART,
         Replace (convert(varchar(5),ENDTIME),':','.') AS LABEND,
         Replace (convert(varchar(5),IOM.REPORTTIME),':','.')AS EARLYREPORT,
         CASE WHEN IsTATrandom='1'THEN 'R'ELSE 'B'END AS RB,CASE WHEN UNIT='WD'THEN 'WEEKLY'ELSE 'DAILY'END AS SCHEDULE,
         IOM.AttGroupID
         from CodeMaster CM WITH (NOLOCK) 
		 INNER JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
		 INNER Join InvOrgGroup  IOM WITH (NOLOCK) ON IOM.OrgGroupID =CP.IdentifyingID 
		 INNER JOIN InvGroupMaster IM WITH (NOLOCK) ON IM.GroupID  =IOM.AttGroupID 
		 Inner join Schedulableresource rs WITH (NOLOCK)on IOM.AttGroupID = rs.resourceid  
		 and  IdentifyingType= rs.ResourceType and rs.OrganizationID = @orgid
		 Inner join Scheduletemplate Sche WITH (NOLOCK)on rs.ScheduleTemplateID = sche.ScheduleTemplateID
		 Inner join Schedules SS WITH (NOLOCK)on rs.ResourceTemplateID = ss.ResourceTemplateID
		 Inner join RecurrenceAbsolute ra WITH (NOLOCK)on sche.RecurrenceID = ra.RecurrenceID
		 Inner join Recurrencerelative rr WITH (NOLOCK)on ra.RecurrenceID = rr.RecurrenceID	  
		 WHERE CM.CodeSchemeID =@CodeSchemeID AND CP.IdentifyingType ='GRP' AND IOM.OrgID =@orgid 
		 --And CM.codeName =@Codename
		 
	 
Union all

Select Distinct CM.CODENAME AS TCODE,CP.IdentifyingType AS TYPE,VALUE AS TATDAYS,IOM.CUTOFFTIMEVALUE AS HR,
         Replace (convert(varchar(5),STARTTIME),':','.') AS LABSTART,
         Replace (convert(varchar(5),ENDTIME),':','.') AS LABEND,
         Replace (convert(varchar(5),IOM.REPORTTIME),':','.')AS EARLYREPORT,
         CASE WHEN IsTATrandom='1'THEN 'R'ELSE 'B'END AS RB,CASE WHEN UNIT='WD'THEN 'WEEKLY'ELSE 'DAILY'END AS SCHEDULE,
         IOM.AttGroupID 
         from  CodeMaster CM WITH (NOLOCK) 
		 INNER JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
		 INNER Join InvOrgGroup  IOM WITH (NOLOCK) ON IOM.OrgGroupID =CP.IdentifyingID 
		 INNER JOIN InvGroupMaster IM WITH (NOLOCK) ON IM.GroupID  =IOM.AttGroupID 
		 Inner join Schedulableresource rs WITH (NOLOCK)on IOM.AttGroupID = rs.resourceid  
		 and  IdentifyingType= rs.ResourceType and rs.OrganizationID = @orgid
		 Inner join Scheduletemplate Sche WITH (NOLOCK)on rs.ScheduleTemplateID = sche.ScheduleTemplateID
		 Inner join Schedules SS WITH (NOLOCK)on rs.ResourceTemplateID = ss.ResourceTemplateID
		 Inner join RecurrenceAbsolute ra WITH (NOLOCK)on sche.RecurrenceID = ra.RecurrenceID
		 Inner join Recurrencerelative rr WITH (NOLOCK)on ra.RecurrenceID = rr.RecurrenceID	  
		 WHERE CM.CodeSchemeID =@CodeSchemeID AND CP.IdentifyingType ='PKG' AND IOM.OrgID =@orgid
		 --And CM.codeName =@Codename
         