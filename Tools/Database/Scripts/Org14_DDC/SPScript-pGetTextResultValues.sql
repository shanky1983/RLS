

/****** Object:  StoredProcedure [dbo].[pGetTextResultValues]    Script Date: 09/26/2009 12:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--pGetTextResultValues 38,15,1
CREATE PROCEDURE [dbo].[pGetTextResultValues] 
(
	@pVisitID bigint, 
	@OrgID int, 
	@TemplateID int 
)

AS BEGIN

Declare @Temp Table  

( 
	PatientVisitID bigint, 
	InvestigationID bigint, 
	InvestigationName varchar(255), 
	ReportName varchar(255), 
	TemplateID int,
	ReportStatus varchar(255) 

) 
insert into @Temp 

				SELECT piv.PatientVisitID,piv.InvestigationID 
				,piv.InvestigationName 
				,ISNULL (im.reporttemplatename, 
				(SELECT Reporttemplatename 
				FROM InvReportMaster 
				WHERE IsDefault='Y')) AS ReportName 
				,ISNULL(im.templateid, 
				(SELECT TemplateID from InvReportMaster 
				WHERE IsDefault='Y'))AS TemplateID ,piv.ReportStatus
				FROM PatientInvestigation piv 
				LEFT OUTER JOIN invreportmapping irm ON irm.investigationid = piv.InvestigationID 
				LEFT OUTER JOIN invreportmaster im ON im.templateid = irm.templateid 
				WHERE piv.PatientVisitID=@pVisitID 
				AND piv.OrgID=@OrgID 


				SELECT distinct (InvestigationValues.InvestigationID),InvestigationValues.InvestigationValueID, 
				InvestigationValues.Name, im.InvestigationName as InvestigationName,
				InvestigationValues.Value, 
				InvestigationValues.GroupName as GroupName, 
				dbo.fnGetInvComments(InvestigationValues.InvestigationID,InvestigationValues.PatientVisitID,InvestigationValues.Orgid) as Comments, 
				InvestigationValues.UOMCode ,irm.ReportStatus
				FROM InvestigationValues 
				inner join @Temp irm on irm.InvestigationID=InvestigationValues.InvestigationID 
				inner join InvestigationMaster im on im.InvestigationID = InvestigationValues.InvestigationID
				--inner join PatientInvestigation PIV on  PIV.PatientVisitID = InvestigationValues.InvestigationID
							--and PIV.OrgID = InvestigationValues.Orgid
				WHERE InvestigationValues.PatientVisitID=@pVisitID 
				and irm.TemplateID=@TemplateID order by InvestigationValues.InvestigationValueID
			
				--drop table #Temp 
END
