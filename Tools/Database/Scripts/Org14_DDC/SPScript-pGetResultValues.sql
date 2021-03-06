

/****** Object:  StoredProcedure [dbo].[pGetResultValues]    Script Date: 09/26/2009 12:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--pGetResultValues 52177,14,1
CREATE PROCEDURE [dbo].[pGetResultValues] 
(
	@pVisitID bigint, 
	@OrgID int, 
	@TemplateID int 
)
AS BEGIN
DECLARE @InvestigationID BIGINT
DECLARE @GroupID INT
DECLARE @DeptID INT

DECLARE @TempTableComplete Table
(
Name VARCHAR(500),
Result VARCHAR(500),
Units VARCHAR(100),
Description VARCHAR(MAX),
ReferenceRange VARCHAR(MAX),
InvestigationID BIGINT,
InvestigationValuesID BIGINT
)

DECLARE @TempTableDept Table  
( 
	DeptID INT 
) 
DECLARE @TempTableSampleMapping Table
(
	SampleCode INT,
	SampleName VARCHAR(50),
	SampleAttributes VARCHAR(50),
	SampleValue VARCHAR(500),
	SampleDesc VARCHAR(500),
	DeptID INT,
	DeptName VARCHAR(30)
)
DECLARE @TempTableInvestigation Table  
( 
	InvestigationID BIGINT,
	InvestigationName VARCHAR(500),
	GroupID INT,
	GroupName VARCHAR(500),
	Status VARCHAR(20),
	Reason VARCHAR(500),
	ReferenceRange VARCHAR(MAX),
	SequenceNo INT,
	DeptID INT,
	DeptName VARCHAR(50)
)
	
DECLARE @TempTableInvestigationValues Table  
( 
	InvestigationValuesID BIGINT,
	InvestigationID BIGINT,
	InvestigationName VARCHAR(500),
	GroupID INT,
	GroupName VARCHAR(500),
	Value VARCHAR(MAX),
	UOMCode VARCHAR(30)
)

DECLARE @TempTableSamples Table
(
	InvestigationID BIGINT,
	InvestigationName VARCHAR(500),
	GroupID INT,
	GroupName VARCHAR(500),
	DeptID int,
	DeptName VARCHAR(50),
	SampleCode INT,
	SampleName VARCHAR(50)
)

	INSERT INTO @TempTableSampleMapping (DeptID,DeptName,SampleCode,SampleName,SampleAttributes,SampleValue,SampleDesc)
	SELECT DISTINCT PISM.DeptID,IDM.DeptName,PIS.SampleCode,SA.AttributesName,ISM.SampleDesc+' - '+SA.AttributesName AS SampleName,PISR.SampleValues,PISR.SampleDesc
	FROM PatientInvSample PIS
	INNER JOIN PatientInvSampleResults PISR ON PISR.SampleCode = PIS.SampleCode AND PISR.OrgID = PIS.OrgID AND PISR.VisitID = PIS.PatientVisitID
	INNER JOIN InvSampleMaster ISM ON ISM.SampleCode = PISR.SampleCode
	INNER JOIN SampleAttributes SA ON SA.AttributesID = PISR.AttributesID
	LEFT JOIN PatientInvSampleMapping PISM ON PISM.SampleID = PISR.SampleCode AND PISM.VisitID = PISR.VisitID AND PISM.OrgID = PISR.OrgID
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = PISM.DeptID AND IDM.OrgID = PISM.OrgID
	WHERE PIS.OrgID = @OrgID AND PIS.PatientVisitID=@pVisitID

	INSERT INTO @TempTableDept (DeptID)
	SELECT DISTINCT IOM.DeptID
	FROM OrderedInvestigations OI
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = OI.ID AND IOM.OrgID = OI.OrgID
	INNER JOIN PatientInvestigation PInv ON PInv.InvestigationID = OI.ID AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID
	WHERE IRM.IsDefault = 'Y' AND OI.Status = 'Paid' AND OI.Type='INV' AND OI.VisitID = @pVisitID	AND	OI.OrgID=@OrgID
	
	INSERT INTO @TempTableDept (DeptID)
	SELECT DISTINCT	ISNULL(IOM.DeptID,0) AS DeptID
	FROM OrderedInvestigations OI
	INNER JOIN InvGroupMaster IGM ON IGM.GroupID = OI.ID AND IGM.OrgID = OI.OrgID AND IGM.Type = OI.Type
	INNER JOIN InvGroupMapMaster IGMM ON IGMM.GroupID = IGM.GroupID
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IGMM.InvestigationID AND IOM.OrgID = OI.OrgID
	INNER JOIN PatientInvestigation PInv ON PInv.GroupID = OI.ID AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID
	INNER JOIN InvestigationMaster IM ON IM.InvestigationID = IOM.InvestigationID
	WHERE IRM.IsDefault = 'Y' AND OI.Status = 'Paid' AND OI.Type!='INV' AND OI.VisitID = @pVisitID	AND	OI.OrgID=@OrgID
	
	DECLARE InvestigationCursor CURSOR FOR 
	
	SELECT DISTINCT OI.ID
	FROM OrderedInvestigations OI
	WHERE OI.VisitID = @pVisitID AND OI.OrgID = @OrgID AND OI.Type='INV'

	OPEN InvestigationCursor FETCH NEXT FROM InvestigationCursor INTO @InvestigationID

	WHILE @@FETCH_STATUS = 0 
	BEGIN
	
	INSERT INTO @TempTableInvestigation (InvestigationID,InvestigationName,GroupID,GroupName,Status,Reason,ReferenceRange,SequenceNo,DeptID,DeptName)
	SELECT PInv.InvestigationID,PInv.InvestigationName,PInv.GroupID,PInv.GroupName,PInv.Status,PInv.Reason,PInv.ReferenceRange,IOM.SequenceNo, IOM.DeptID, IDM.DeptName 
	FROM PatientInvestigation PInv
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID AND IDM.OrgID = IOM.OrgID
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID
	WHERE IRM.IsDefault = 'Y' AND PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @InvestigationID AND PInv.GroupID = 0
	ORDER BY IOM.SequenceNo
	
	INSERT INTO @TempTableInvestigationValues (InvestigationValuesID,InvestigationID,InvestigationName,GroupID,GroupName,Value,UOMCode)
	SELECT 
	IV.InvestigationValueID,IV.InvestigationID,IV.Name,IV.GroupID,IV.GroupName,IV.Value,IV.UOMCode
	FROM InvestigationValues IV
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IV.InvestigationID AND IOM.OrgID = IV.OrgID
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = IV.InvestigationID
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID
	WHERE IRM.IsDefault = 'Y' AND IV.PatientVisitID = @pVisitID AND IV.OrgID = @OrgID AND IV.InvestigationID = @InvestigationID AND IV.GroupID = 0
	ORDER BY IOM.SequenceNo
			
	FETCH NEXT FROM InvestigationCursor INTO @InvestigationID

	END 

	CLOSE InvestigationCursor
	DEALLOCATE InvestigationCursor
	
	
	DECLARE GroupCursor CURSOR FOR 
	
	SELECT DISTINCT OI.ID
	FROM OrderedInvestigations OI
	WHERE OI.VisitID = @pVisitID AND OI.OrgID = @OrgID AND OI.Type!='INV'

	OPEN GroupCursor FETCH NEXT FROM GroupCursor INTO @GroupID

	WHILE @@FETCH_STATUS = 0 
	BEGIN
	
	INSERT INTO @TempTableInvestigation (InvestigationID,InvestigationName,GroupID,GroupName,Status,Reason,ReferenceRange,SequenceNo,DeptID,DeptName)
	SELECT PInv.InvestigationID,PInv.InvestigationName,PInv.GroupID,PInv.GroupName,PInv.Status,PInv.Reason,PInv.ReferenceRange,IOM.SequenceNo, IOM.DeptID, IDM.DeptName 
	FROM PatientInvestigation PInv
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID AND IDM.OrgID = IOM.OrgID
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID
	WHERE IRM.IsDefault = 'Y' AND PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.GroupID = @GroupID
	ORDER BY IOM.SequenceNo
	
	INSERT INTO @TempTableInvestigationValues (InvestigationValuesID,InvestigationID,InvestigationName,GroupID,GroupName,Value,UOMCode)
	SELECT 
	IV.InvestigationValueID,IV.InvestigationID,IV.Name,IV.GroupID,IV.GroupName,IV.Value,IV.UOMCode
	FROM InvestigationValues IV
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IV.InvestigationID AND IOM.OrgID = IV.OrgID
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = IV.InvestigationID
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID
	WHERE IRM.IsDefault = 'Y' AND IV.PatientVisitID = @pVisitID AND IV.OrgID = @OrgID AND IV.GroupID = @GroupID
	ORDER BY IOM.SequenceNo
	
	FETCH NEXT FROM GroupCursor INTO @GroupID

	END 

	CLOSE GroupCursor
	DEALLOCATE GroupCursor
	
	
	--SELECT * FROM @TempTableDept
	--SELECT * FROM @TempTableSampleMapping
	--SELECT * FROM @TempTableInvestigation
	--SELECT * FROM @TempTableInvestigationValues
	
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''
	FROM @TempTableSampleMapping TTSM
	WHERE TTSM.DeptID IS NULL
	
	DECLARE FinalCursor1 CURSOR FOR 
	
	SELECT DISTINCT DeptID
	FROM @TempTableDept

	OPEN FinalCursor1 FETCH NEXT FROM FinalCursor1 INTO @DeptID

	WHILE @@FETCH_STATUS = 0 
	BEGIN
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	SELECT DISTINCT '<B><U>'+DeptName+'</U></B>' AS DeptName,'','','','','',''
	FROM InvDeptMaster
	WHERE DeptID = @DeptID AND OrgID = @OrgID
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','','' 
	FROM @TempTableSampleMapping TTSM
	WHERE TTSM.DeptID = @DeptID
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID
	FROM @TempTableInvestigation TTI
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID
	WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0  ORDER BY TTI.SequenceNo
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	SELECT DISTINCT '<B>'+TTI.GroupName+'</B>' AS GroupName,'','','','','',''
	FROM @TempTableInvestigation TTI
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID
	WHERE TTI.DeptID = @DeptID AND TTI.GroupID != 0 
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID
	FROM @TempTableInvestigation TTI
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID
	WHERE TTI.DeptID = @DeptID AND TTI.GroupID != 0 ORDER BY TTI.SequenceNo
	
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)
	VALUES ('','','','','','','')
	
	FETCH NEXT FROM FinalCursor1 INTO @DeptID

	END 

	CLOSE FinalCursor1
	DEALLOCATE FinalCursor1
	
	UPDATE @TempTableComplete SET Description = '', ReferenceRange = '' WHERE InvestigationID = 4768 AND Result!='' AND Units!=''
	
	SELECT Name,Result,Units,Description,ReferenceRange FROM @TempTableComplete
		
END
