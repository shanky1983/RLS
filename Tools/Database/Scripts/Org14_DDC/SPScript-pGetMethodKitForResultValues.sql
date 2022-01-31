
/****** Object:  StoredProcedure [dbo].[pGetMethodKitForResultValues]    Script Date: 10/22/2009 10:12:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



--pGetMethodKitForResultValues 1,14,1
CREATE PROCEDURE [dbo].[pGetMethodKitForResultValues] 
(
	@pVisitID bigint, 
	@OrgID int, 
	@TemplateID int 
)
AS BEGIN
DECLARE @InvestigationID bigint
DECLARE @ID bigint

DECLARE @Temp Table  
( 
	PatientVisitID BIGINT, 
	InvestigationID BIGINT, 
	InvestigationName VARCHAR(255), 
	ReportName VARCHAR(255), 
	TemplateID INT,
	ReportStatus VARCHAR(255) 
) 
INSERT INTO @Temp 
SELECT PInv.PatientVisitID,PInv.InvestigationID 
,PInv.InvestigationName 
,ISNULL(IM.reporttemplatename, 
(SELECT Reporttemplatename 
FROM InvReportMaster 
WHERE IsDefault='Y')) AS ReportName 
,ISNULL(IM.templateid, 
(SELECT TemplateID FROM InvReportMaster 
WHERE IsDefault='Y'))AS TemplateID ,PInv.ReportStatus
FROM PatientInvestigation PInv 
LEFT OUTER JOIN invreportmapping IRM ON IRM.investigationid = PInv.InvestigationID 
LEFT OUTER JOIN invreportmaster IM ON IM.templateid = IRM.templateid 
WHERE PInv.PatientVisitID=@pVisitID
AND PInv.OrgID=@OrgID AND IM.TemplateID = @TemplateID

DECLARE @TempTable Table  
( 
	InvestigationName VARCHAR(500),
	GroupName VARCHAR(500),
	Name VARCHAR(500),
	Description VARCHAR(MAX)
) 

DECLARE methodKitCursor CURSOR FOR 

SELECT DISTINCT PInv.InvestigationID
FROM PatientInvestigation PInv
WHERE PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID

OPEN methodKitCursor FETCH NEXT FROM methodKitCursor INTO @InvestigationID

WHILE @@FETCH_STATUS = 0 
BEGIN

--INSERT INTO @TempTable (Name)
--SELECT InvestigationName
--FROM PatientInvestigation
--WHERE (MethodName!='' OR KitName!='' OR InstrumentName!='') AND
--PatientVisitID = @pVisitID AND OrgID = @OrgID AND InvestigationID = @InvestigationID

INSERT INTO @TempTable (Description)
SELECT DISTINCT '<B><U>'+PInv.InvestigationName+'</U></B>' AS Description
FROM PatientInvestigation PInv
INNER JOIN @Temp IRM ON IRM.InvestigationID=PInv.InvestigationID
WHERE PInv.MethodName!='' AND
PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @InvestigationID

INSERT INTO @TempTable (Description)
SELECT DISTINCT 'Principle/Method: '+PInv.MethodName AS Description
FROM PatientInvestigation PInv
INNER JOIN @Temp IRM ON IRM.InvestigationID=PInv.InvestigationID
WHERE PInv.MethodName!='' AND
PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @InvestigationID

INSERT INTO @TempTable (Description)
SELECT DISTINCT 'Kit Used: '+PInv.KitName AS Description
FROM PatientInvestigation PInv
INNER JOIN @Temp IRM ON IRM.InvestigationID=PInv.InvestigationID
WHERE PInv.KitName!='' AND
PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @InvestigationID

INSERT INTO @TempTable (Description)
SELECT DISTINCT 'Instrument Used: '+PInv.InstrumentName AS Description
FROM PatientInvestigation PInv
INNER JOIN @Temp IRM ON IRM.InvestigationID=PInv.InvestigationID
WHERE PInv.InstrumentName!='' AND
PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @InvestigationID

INSERT INTO @TempTable (Description)
SELECT DISTINCT 'Interpretation/Notes: '+PInv.Interpretation AS Description
FROM PatientInvestigation PInv
INNER JOIN @Temp IRM ON IRM.InvestigationID=PInv.InvestigationID
WHERE PInv.Interpretation !='' AND
PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @InvestigationID

FETCH NEXT FROM methodKitCursor INTO @InvestigationID

END 

CLOSE methodKitCursor
DEALLOCATE methodKitCursor

SELECT Name,Description
FROM @TempTable 
END


GO


