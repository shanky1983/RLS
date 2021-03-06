--------------------------------------------------------------------------------------------------------------------
--Start of SP pGetResultValues
--------------------------------------------------------------------------------------------------------------------            
CREATE PROCEDURE [dbo].[pGetResultValues]                                                       
(                                                      
  @pVisitID bigint,                                                       
  @OrgID int,                                                       
  @TemplateID int,                                  
  @InvestigationID varchar(2000)                                  
)                                                      
AS BEGIN                                                      
DECLARE @pInvestigationID BIGINT                                                      
DECLARE @GroupID INT                                                      
DECLARE @PackageID INT                                                      
DECLARE @InnerPackageID INT                                                      
DECLARE @InnerGroupID INT                                                      
DECLARE @ParentLabelName VARCHAR(50)                                                      
DECLARE @DeptID INT        
DECLARE @DeptID1 INT                                                      
DECLARE @pDeptName VARCHAR (255)                                                      
DECLARE @pTitleName VARCHAR (255)                                                      
DECLARE @pPKGTitleName VARCHAR (255)    
DECLARE @grpInnerLoopInvID BIGINT    
DECLARE @grpInnerLoopParent CHAR(1)     
DECLARE @sequenceNo INT    
DECLARE @PKGContentID BIGINT    
DECLARE @PKGContentType VARCHAR(5)      
DECLARE @PKGContentSequence INT    

--Temp Table for Final Result Set                                                  
DECLARE @TempTableComplete Table                                                      
(                    
	RowID BIGINT IDENTITY(1,1),                                              
	Name VARCHAR(MAX),                                                      
	Result VARCHAR(MAX),                                                      
	Units VARCHAR(500),                                                      
	Description VARCHAR(MAX),                                                      
	ReferenceRange VARCHAR(MAX),                                                      
	InvestigationID BIGINT,                                                      
	InvestigationValuesID BIGINT,          
	GroupComment VARCHAR(MAX)                                                     
)      
--Temp Table to store Inner GroupID - Group Inside a Group                                                
DECLARE @TempTableForInnerGroup Table                                                        
(                                                       
	InnerGRPID INT                                                       
)      
--Temp Table to store Dept IDs of Investigations present inside a Group & Group Inside a Group                                                
DECLARE @TempTableDeptForGroup Table                                                        
(                                                       
	GRPDeptID INT                                                       
)          
--Temp Table to store Dept IDs of Individual Investigations                                            
DECLARE @TempTableDept Table                                                        
(                                     
	RowID int IDENTITY(1,1),                                                    
	DeptID INT,                                                      
	SequenceNo INT                                                       
)          
--Temp Table to store Sample Mapping for Investigations                                             
DECLARE @TempTableSampleMapping Table                                                      
(                                                      
	SampleCode INT,                                                      
	SampleName VARCHAR(255),                                                      
	SampleAttributes VARCHAR(255),                 
	SampleValue VARCHAR(500),                                                      
	SampleDesc VARCHAR(500),                                                      
	DeptID INT,                         
	DeptName VARCHAR(255),        
	Type VARCHAR(10),        
	SampleID BIGINT                                                      
)                     
--Temp Table to store Investigation details available in Patient Investigation Table for this Visit         
DECLARE @TempTableInvestigation Table                                                        
(               
	InvestigationID BIGINT,                                                      
	InvestigationName VARCHAR(500),                                                      
	GroupID INT,                                                  
	GroupName VARCHAR(500),                                                      
	Status VARCHAR(20),                                             
	Reason VARCHAR(MAX),                                                      
	ReferenceRange VARCHAR(MAX),                              
	SequenceNo INT,                                                      
	DeptID INT,                                                      
	DeptName VARCHAR(255),                                                      
	PackageID INT,                                                      
	PackageName VARCHAR(500),                                
	Type VARCHAR(10),          
	GroupComment VARCHAR(MAX)                                                      
)                                                      
--Temp Table to store Investigation value details available in Investigation Values Table for this Visit         
DECLARE @TempTableInvestigationValues Table                                                        
(                                                       
	InvestigationValuesID BIGINT,                                                      
	InvestigationID BIGINT,                                                      
	InvestigationName VARCHAR(500),                                          
	GroupID INT,                                                      
	GroupName VARCHAR(500),                                                      
	Value VARCHAR(MAX),                                                      
	UOMCode VARCHAR(255),                                                      
	PackageID INT,                                                      
	PackageName VARCHAR(500),                                              
	Type VARCHAR(10),                                                      
	SequenceNo INT          
)                                                      
--Temp Table to store Samples mapped for corresponding Investigations with ther Departments.                                                      
DECLARE @TempTableSamples Table                                                      
(                                                      
	InvestigationID BIGINT,                                                      
	InvestigationName VARCHAR(500),                                            
	GroupID INT,                                                      
	GroupName VARCHAR(500),                                                      
	DeptID int,                                                      
	DeptName VARCHAR(255),                                                      
	SampleCode INT,                                      
	SampleName VARCHAR(255)                                                      
)                                    
--Temp Table to store Accession Numbers, for the selected Investigations to be Rendered in Report                          
DECLARE @tblResultSelectID Table
(
	AccessionNo bigint
)      
INSERT INTO @tblResultSelectID (AccessionNo)                                  
SELECT item from fnSplit(@InvestigationID,',')  
                           
--Temp Table to store UID                          
DECLARE @tblResultSelectUID Table
(
	UID varchar(255)
)                                  
INSERT INTO @tblResultSelectUID (UID)                                  
SELECT DISTINCT OI.UID                                                      
FROM OrderedInvestigations OI                               
INNER JOIN @tblResultSelectID trs ON OI.AccessionNumber = trs.AccessionNo                                  
WHERE OI.VisitID = @pVisitID AND OI.OrgID = @OrgID                          
                                          
--This block Collects the Sample & its Attributes mapped for the Investigations                                                    
INSERT INTO @TempTableSampleMapping (DeptID,DeptName,SampleCode,SampleName,SampleAttributes,SampleValue,SampleDesc,Type,SampleID)                                                      
SELECT DISTINCT PISM.DeptID,IDM.DeptName,PIS.SampleCode,SA.AttributesName,                                                      
CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END AS SampleName,                 
SA.AttributesName+' - '+PISR.SampleValues AS SampleValues,PISR.SampleDesc,PISM.Type,PIS.SampleID                                                      
FROM PatientInvSample PIS                                                      
INNER JOIN PatientInvSampleResults PISR ON PISR.SampleCode = PIS.SampleID AND PISR.OrgID = PIS.OrgID AND PISR.VisitID = PIS.PatientVisitID                                                      
INNER JOIN InvSampleMaster ISM ON ISM.SampleCode = PIS.SampleCode                                                      
INNER JOIN SampleAttributes SA ON SA.AttributesID = PISR.AttributesID                                                      
LEFT JOIN PatientInvSampleMapping PISM ON PISM.SampleID = PISR.SampleCode AND PISM.VisitID = PISR.VisitID AND PISM.OrgID = PISR.OrgID                           
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = PISM.DeptID AND IDM.OrgID = PISM.OrgID                                                      
LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = PIS.SampleContainerID                          
WHERE PIS.OrgID = @OrgID AND PIS.PatientVisitID=@pVisitID                                   
                                                    
--This block Collects the DeptIDs for the Individual Investigations                                                      
INSERT INTO @TempTableDept (DeptID,SequenceNo)                                                      
SELECT DISTINCT ISNULL(IOM.DeptID,0) AS DeptID,IDM.SequenceNo                                                      
FROM OrderedInvestigations OI                                                      
INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = OI.ID AND IOM.OrgID = OI.OrgID                                         
INNER JOIN PatientInvestigation PInv ON PInv.InvestigationID = OI.ID AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID                                                      
INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                           
INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID AND IRM.OrgID = IOM.OrgID                          
INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                     
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID  and IOM.OrgID = IDM.OrgID                                                    
WHERE IRM.IsDefault = 'Y' AND                                                   
(OI.Status = 'Pending' OR OI.Status = 'Completed' OR OI.Status = 'SampleReceived' OR OI.Status = 'Approve') AND OI.Type='INV' AND OI.VisitID = @pVisitID AND OI.OrgID=@OrgID                                                      
ORDER BY IDM.SequenceNo   
                                                    
--This block Collects the DeptIDs for the Individual Investigations inside the Group    
INSERT INTO @TempTableDept (DeptID,SequenceNo)                                                      
SELECT DISTINCT ISNULL(IOM.DeptID,0) AS DeptID,IDM.SequenceNo                                                      
FROM OrderedInvestigations OI                                                      
INNER JOIN InvGroupMaster IGM ON IGM.GroupID = OI.ID AND IGM.Type = OI.Type                                                  
INNER JOIN InvOrgGroup OG ON OG.AttGroupID = IGM.GroupID AND OG.OrgID = OI.OrgID                                                    
INNER JOIN InvGroupMapMaster IGMM ON IGMM.GroupID = OG.OrgGroupID                                                    
INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IGMM.InvestigationID AND IOM.OrgID = OI.OrgID                                                      
INNER JOIN PatientInvestigation PInv ON PInv.GroupID = OI.ID AND PInv.PackageID = 0 AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID                                                      
INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                                                     
INNER JOIN InvestigationMaster IM ON IM.InvestigationID = IOM.InvestigationID                           
INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                     
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID   and IOM.OrgID = IDM.OrgID                                                    
WHERE IRM.IsDefault = 'Y' AND                                                   
(OI.Status = 'Pending' OR OI.Status = 'Completed' OR OI.Status = 'SampleReceived' OR OI.Status = 'Approve') AND OI.Type='GRP' AND OI.VisitID = @pVisitID AND OI.OrgID=@OrgID                                                      
ORDER BY IDM.SequenceNo  
                                 
--This block Collects the DeptIDs for the Individual Investigations in (Group Inside a Group)
INSERT INTO @TempTableDept (DeptID,SequenceNo)                                                      
SELECT DISTINCT ISNULL(IOM.DeptID,0) AS DeptID,IDM.SequenceNo                                                      
FROM OrderedInvestigations OI                                                      
INNER JOIN InvGroupMaster IGM ON IGM.Type = OI.Type                                                     
INNER JOIN InvOrgGroup OG ON OG.AttGroupID = IGM.GroupID AND OG.OrgID = OI.OrgID                                                    
INNER JOIN InvGroupMapMaster IGMM ON IGMM.GroupID = OG.OrgGroupID                                                       
INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IGMM.InvestigationID AND IOM.OrgID = OI.OrgID                                                      
INNER JOIN PatientInvestigation PInv ON PInv.GroupID != OI.ID AND PInv.GroupID != 0  AND PInv.PackageID = 0 AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID                                                  
INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID AND IRM.OrgID = IOM.OrgID                        
INNER JOIN InvestigationMaster IM ON IM.InvestigationID = IOM.InvestigationID                             
INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                   
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID  and IOM.OrgID = IDM.OrgID                                                     
WHERE IRM.IsDefault = 'Y' AND                                                   
(OI.Status = 'Pending' OR OI.Status = 'Completed' OR OI.Status = 'SampleReceived' OR OI.Status = 'Approve') AND OI.Type='GRP' AND OI.VisitID = @pVisitID AND OI.OrgID=@OrgID AND OG.OrgGroupID = PInv.GroupID                                                
ORDER BY IDM.SequenceNo                                                  
                                        
--This block Collects the DeptIDs for the Individual Investigations in (Group) in Package & Insurance
INSERT INTO @TempTableDept (DeptID,SequenceNo)                                                      
SELECT DISTINCT ISNULL(IOM.DeptID,0) AS DeptID,IDM.SequenceNo                                            
FROM OrderedInvestigations OI                                                      
INNER JOIN InvGroupMaster IGP ON IGP.GroupID = OI.ID AND IGP.Type = OI.Type                                                    
INNER JOIN InvOrgGroup OG ON OG.AttGroupID = IGP.GroupID AND OG.OrgID = OI.OrgID                                                  
INNER JOIN InvPackageMapping IPM ON IPM.PackageID = OG.OrgGroupID AND IPM.Type = 'GRP'                                                    
INNER JOIN InvOrgGroup OG1 ON OG1.OrgGroupID = IPM.ID AND OG1.OrgID = OI.OrgID                                                  
INNER JOIN InvGroupMaster GMP1 ON GMP1.GroupID = OG1.AttGroupID AND GMP1.Type = IPM.Type                                                  
INNER JOIN invGroupMapMaster GMM ON GMM.GroupID = OG1.OrgGroupID                                                  
INNER JOIN InvestigationMaster IM ON IM.InvestigationID = GMM.InvestigationID                                                        
INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IM.InvestigationID AND IOM.OrgID = OI.OrgID                                                  
INNER JOIN PatientInvestigation PInv ON PInv.PackageID = OI.ID AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID                                                      
INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID AND IRM.OrgID = IOM.OrgID                            
INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                    
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID  and IOM.OrgID = IDM.OrgID                                                     
WHERE IRM.IsDefault = 'Y' AND                                                   
(OI.Status = 'Pending' OR OI.Status = 'Completed' OR OI.Status = 'SampleReceived' OR OI.Status = 'Approve') AND (OI.Type='PKG' OR OI.Type='INS') AND OI.VisitID = @pVisitID AND OI.OrgID=@OrgID                                                      
ORDER BY IDM.SequenceNo                                   
                                                       
--This block Collects the DeptIDs for the Individual Investigations in (Group Inside a Group) in Package & Insurance 
INSERT INTO @TempTableDept (DeptID,SequenceNo)                                                      
SELECT DISTINCT ISNULL(IOM.DeptID,0) AS DeptID,IDM.SequenceNo                                                      
FROM OrderedInvestigations OI                                         
INNER JOIN InvGroupMaster IGP ON IGP.GroupID = OI.ID AND IGP.Type = OI.Type                                                      
INNER JOIN InvPackageMapping IPM ON IPM.PackageID = IGP.GroupID AND IPM.Type = 'GRP'                                                      
INNER JOIN InvGroupMaster IGM ON IGM.GroupID = IPM.ID AND IGM.Type = IPM.Type                                     
INNER JOIN InvOrgGroup OG1 ON OG1.AttGroupID = IGM.GroupID AND OG1.OrgID = OI.OrgID                                                     
INNER JOIN InvGroupMapMaster IGMM ON IGMM.GroupID = OG1.OrgGroupID  AND (IGMM.Parent = 'Y' OR IGMM.Parent IS NULL)                                                      
INNER JOIN InvGroupMaster IGM1 ON IGM1.GroupID = IGMM.InvestigationID                                                     
INNER JOIN InvOrgGroup OG2 ON OG2.AttGroupID = IGM1.GroupID AND OG2.OrgID = OI.OrgID                                  
INNER JOIN InvGroupMapMaster IGMM1 ON IGMM1.GroupID = OG2.OrgGroupID                                                    
INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IGMM1.InvestigationID AND IOM.OrgID = OI.OrgID                                                      
INNER JOIN PatientInvestigation PInv ON PInv.PackageID = OI.ID AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID                                                      
INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                       
INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                                                     
INNER JOIN InvestigationMaster IM ON IM.InvestigationID = IOM.InvestigationID                            
INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                           
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID  and IOM.OrgID = IDM.OrgID                                                     
WHERE IRM.IsDefault = 'Y' AND                                                   
(OI.Status = 'Pending' OR OI.Status = 'Completed' OR OI.Status = 'SampleReceived' OR OI.Status = 'Approve') AND (OI.Type='PKG' OR OI.Type='INS') AND OI.VisitID = @pVisitID AND OI.OrgID=@OrgID                                  
ORDER BY IDM.SequenceNo                                   
 
--This block Collects the DeptIDs for the Individual Investigations in Package & Insurance                                                       
INSERT INTO @TempTableDept (DeptID,SequenceNo)                                                      
SELECT DISTINCT ISNULL(IOM.DeptID,0) AS DeptID,IDM.SequenceNo                                                      
FROM OrderedInvestigations OI                                                      
INNER JOIN InvGroupMaster GMP ON GMP.GroupID = OI.ID AND GMP.Type = OI.Type                          
INNER JOIN InvOrgGroup OG ON OG.AttGroupID = GMP.GroupID AND OG.OrgID = OI.OrgID                                                     
INNER JOIN InvPackageMapping IPM ON IPM.PackageID = OG.OrgGroupID AND IPM.Type = 'INV'                                                        
INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IPM.ID                                                    
INNER JOIN PatientInvestigation PInv ON PInv.PackageID = OI.ID AND PInv.OrgID = OI.OrgID AND PInv.PatientVisitID = OI.VisitID                                                      
INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                                                     
INNER JOIN InvestigationMaster IM ON IM.InvestigationID = IOM.InvestigationID                           
INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                     
LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID and IOM.OrgID = IDM.OrgID                                                      
WHERE IRM.IsDefault = 'Y' AND                                           
(OI.Status = 'Pending' OR OI.Status = 'Completed' OR OI.Status = 'SampleReceived' OR OI.Status = 'Approve') AND (OI.Type='PKG' OR OI.Type='INS') AND OI.VisitID = @pVisitID AND OI.OrgID=@OrgID                                                      
ORDER BY IDM.SequenceNo                                   
                                   
--Remove duplicate DeptIDs                                  
DELETE FROM @TempTableDept WHERE RowID in                                  
(SELECT Max(RowID) FROM @TempTableDept Group By DeptID Having Count(*)>1)                                    

----------------------------------------------------------------------------------------------------------------------
--This Cursor is used to Collect all Individual Investigations and its values available in Patient Investigation & Investigation Values Tables                                   
DECLARE InvestigationCursor CURSOR FOR                    
                                                       
	SELECT DISTINCT OI.ID                                                      
	FROM OrderedInvestigations OI                               
	INNER JOIN @tblResultSelectID trs ON OI.AccessionNumber = trs.AccessionNo                                  
	WHERE OI.VisitID = @pVisitID AND OI.OrgID = @OrgID AND OI.Type='INV'                                                    
                                                      
OPEN InvestigationCursor FETCH NEXT FROM InvestigationCursor INTO @pInvestigationID                             
WHILE @@FETCH_STATUS = 0                                                       
BEGIN    
                                                  
    --This block collects all Individual Investigations available in Patient Investigation Table                                                   
	INSERT INTO @TempTableInvestigation (InvestigationID,InvestigationName,GroupID,GroupName,Status,Reason,ReferenceRange,SequenceNo,DeptID,DeptName,Type,PackageID,PackageName,GroupComment)             
	SELECT DISTINCT PInv.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN PInv.InvestigationName                                                      
	ELSE PInv.InvestigationName + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                      
	+')' END AS InvestigationName                                                     
	,PInv.GroupID,PInv.GroupName,PInv.Status,PInv.Reason,PInv.ReferenceRange,IOM.SequenceNo, IOM.DeptID, IDM.DeptName,'INV','0','',''                                                      
	FROM PatientInvestigation PInv                                                      
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID                                                      
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID AND IDM.OrgID = IOM.OrgID                                                      
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                                                    
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                                      
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                           
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                     
	WHERE IRM.IsDefault = 'Y' AND                                                   
	PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.InvestigationID = @pInvestigationID AND PInv.GroupID = 0            
	AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                       
	ORDER BY IOM.SequenceNo 
	                                                     
    --This block collects all Individual Investigation Values available in Investigation Values Table                                  
	INSERT INTO @TempTableInvestigationValues (InvestigationValuesID,InvestigationID,InvestigationName,GroupID,GroupName,Value,UOMCode,Type,SequenceNo,PackageID,PackageName)                                                      
	SELECT DISTINCT                                                      
	IV.InvestigationValueID,IV.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN IV.Name                                                      
	ELSE CASE IV.Name WHEN ''                                     
	THEN ''                                     
	ELSE IV.Name + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                      
	+')'                                     
	END                                    
	END AS Name                                                      
	,IV.GroupID,IV.GroupName,IV.Value,IV.UOMCode,'INV',IV.SequenceNo,'0',''                                                   
	FROM InvestigationValues IV          
	INNER JOIN PatientInvestigation PInv ON PInv.OrgID = IV.Orgid AND PInv.PatientVisitID = IV.PatientVisitID AND PInv.UID = IV.UID AND PInv.InvestigationID = IV.InvestigationID                                                       
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IV.InvestigationID AND IOM.OrgID = IV.OrgID                                                      
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = IV.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                      
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(IV.UID,'') --Ramki                                                   
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                                      
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                                                      
	WHERE IRM.IsDefault = 'Y' AND                          
	IV.PatientVisitID = @pVisitID AND IV.OrgID = @OrgID AND IV.InvestigationID = @pInvestigationID AND IV.GroupID = 0  AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                       
	ORDER BY IV.SequenceNo                               
                                                         
FETCH NEXT FROM InvestigationCursor INTO @pInvestigationID                                                      
END                                                       

CLOSE InvestigationCursor                                                      
DEALLOCATE InvestigationCursor                                                      
------------------------------------------------------------------------------------------------------------------------                                          
                                                    
------------------------------------------------------------------------------------------------------------------------
--This Cursor is used to Collect all Investigations and its values of (Group & Group Inside a Group) available in Patient Investigation & Investigation Values Tables                                   
DECLARE GroupCursor CURSOR FOR                                                       
                         
	SELECT DISTINCT OG.AttGroupID                                             
	FROM PatientInvestigation PInv                                                      
	INNER JOIN InvOrgGroup OG ON OG.OrgGroupID = PInv.GroupID AND OG.OrgID = PInv.OrgID                                 
	INNER JOIN OrderedInvestigations OI ON OI.ID = OG.AttGroupID AND OI.OrgID=OG.OrgID                  
	INNER JOIN @tblResultSelectID tblTemp ON tblTemp.AccessionNo=OI.AccessionNumber                              
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                           
	WHERE PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.PackageID = 0                                             
	AND OI.Type='GRP'                          
	UNION ALL                          
	SELECT DISTINCT OG1.AttGroupID                                             
	FROM PatientInvestigation PInv                                                      
	INNER JOIN InvOrgGroup OG ON OG.OrgGroupID = PInv.GroupID AND OG.OrgID = PInv.OrgID                                 
	INNER JOIN OrderedInvestigations OI ON OI.ID = OG.AttGroupID AND OI.OrgID=OG.OrgID                              
	INNER JOIN @tblResultSelectID tblTemp ON tblTemp.AccessionNo=OI.AccessionNumber                            
	inner join InvGroupMapMaster IGM   on IGM.GroupID = OG.OrgGroupID and IGM.Parent='Y'                          
	inner join InvOrgGroup og1 on og1.OrgGroupID=IGM.InvestigationID and og1.OrgID = PInv.OrgID                            
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'')--Ramki                          
	WHERE PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.PackageID = 0                                             
	AND OI.Type='GRP'                                  
                                                      
OPEN GroupCursor FETCH NEXT FROM GroupCursor INTO @GroupID                                                      
WHILE @@FETCH_STATUS = 0                                                       
BEGIN                                                      
    
    --This block Collects all Investigations details of (Group & Group Inside a Group) available in Patient Investigation Table                                                                                     
	INSERT INTO @TempTableInvestigation (InvestigationID,InvestigationName,GroupID,GroupName,Status,Reason,ReferenceRange,SequenceNo,DeptID,DeptName,Type,PackageID,PackageName,GroupComment)                                                      
	SELECT DISTINCT PInv.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN PInv.InvestigationName                                                      
	ELSE PInv.InvestigationName + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                      
	+')' END AS InvestigationName                                                      
	,PInv.GroupID,PInv.GroupName,PInv.Status,PInv.Reason,PInv.ReferenceRange,IOM.SequenceNo, IOM.DeptID, IDM.DeptName,'GRP','0' ,'',PInv.GroupComment                                                      
	FROM PatientInvestigation PInv                                                      
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID                                                      
	INNER JOIN InvOrgGroup OG ON OG.OrgGroupID = PInv.GroupID AND OG.OrgID = PInv.OrgID                                                    
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID AND IDM.OrgID = IOM.OrgID                                           
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                         
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                      
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                                      
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                                                   
	WHERE IRM.IsDefault = 'Y' AND                                                   
	PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND OG.AttGroupID = @GroupID AND PInv.PackageID = 0    AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                    
	ORDER BY IOM.SequenceNo                                                      
    
    --This block Collects all Investigation values of (Group & Group Inside a Group) available in Investigation Values Table                                                                                                                 
	INSERT INTO @TempTableInvestigationValues (InvestigationValuesID,InvestigationID,InvestigationName,GroupID,GroupName,Value,UOMCode,Type,PackageID,PackageName,SequenceNo)                                                      
	SELECT DISTINCT                                                      
	IV.InvestigationValueID,IV.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN IV.Name                                                      
	ELSE CASE IV.Name WHEN ''                                     
	THEN ''                                     
	ELSE IV.Name + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                      
	+')'                                 
	END END AS Name                                                      
	,IV.GroupID,IV.GroupName,IV.Value,IV.UOMCode,'GRP','0','',IV.SequenceNo                                                      
	FROM InvestigationValues IV           
	INNER JOIN PatientInvestigation PInv ON PInv.OrgID = IV.Orgid AND PInv.PatientVisitID = IV.PatientVisitID AND PInv.UID = IV.UID AND PInv.InvestigationID = IV.InvestigationID                                                      
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IV.InvestigationID AND IOM.OrgID = IV.OrgID                                                    
	INNER JOIN InvOrgGroup OG ON OG.OrgGroupID = IV.GroupID AND OG.OrgID = IV.Orgid                                                    
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = IV.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                   
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(IV.UID,'') --Ramki                                                       
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                                      
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                                                      
	WHERE IRM.IsDefault = 'Y' AND                                                   
	IV.PatientVisitID = @pVisitID AND IV.OrgID = @OrgID AND IV.PackageID = 0 AND OG.AttGroupID = @GroupID AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                        
	ORDER BY IV.SequenceNo                        
                                                
FETCH NEXT FROM GroupCursor INTO @GroupID                                                      
END                                                       
                                                      
CLOSE GroupCursor                                                      
DEALLOCATE GroupCursor                                                      
--------------------------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------------------------------
--This Cursor is used to Collect all Investigations and its values of (Package) available in Patient Investigation & Investigation Values Tables                                   
DECLARE PKGCursor CURSOR FOR                                                       
                                                       
	SELECT DISTINCT OI.ID                                
	FROM OrderedInvestigations OI                               
	INNER JOIN @tblResultSelectID trs ON OI.AccessionNumber = trs.AccessionNo                                                      
	WHERE OI.VisitID = @pVisitID AND OI.OrgID = @OrgID AND OI.Type = 'PKG'                                                      
                                                      
OPEN PKGCursor FETCH NEXT FROM PKGCursor INTO @GroupID                                                      
WHILE @@FETCH_STATUS = 0                                                       
BEGIN                                                      
      
    --This block Collects all Investigations details of (Package) available in Patient Investigation Table                                                                                                                                        
	INSERT INTO @TempTableInvestigation (InvestigationID,InvestigationName,GroupID,GroupName,PackageID,PackageName,Status,Reason,ReferenceRange,SequenceNo,DeptID,DeptName,Type,GroupComment)                                                      
	SELECT DISTINCT PInv.InvestigationID,                                            
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN PInv.InvestigationName                                                      
	ELSE PInv.InvestigationName + ' - (' +                 
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc            
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                           
	+')' END AS InvestigationName                                                      
	,PInv.GroupID,PInv.GroupName,PInv.PackageID,PInv.PackageName,PInv.Status,PInv.Reason,PInv.ReferenceRange,IOM.SequenceNo, IOM.DeptID, IDM.DeptName,'PKG',''                                                       
	FROM PatientInvestigation PInv                                                      
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID                                                      
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID AND IDM.OrgID = IOM.OrgID                                                      
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                         INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID   AND IRM.OrgID = IOM.OrgID                   
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                                                     
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                          
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                                                      
	WHERE IRM.IsDefault = 'Y' AND                                                   
	PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.PackageID = @GroupID AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                        
	ORDER BY IOM.SequenceNo                                                      
      
    --This block Collects all Investigation values of (Package) available in Investigation Values Table                                                                                                                                                                    
	INSERT INTO @TempTableInvestigationValues (InvestigationValuesID,InvestigationID,InvestigationName,GroupID,GroupName,PackageID,PackageName,Value,UOMCode,Type,SequenceNo)                               
	SELECT DISTINCT                                                       
	IV.InvestigationValueID,IV.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN IV.Name                                                      
	ELSE CASE IV.Name WHEN ''                                     
	THEN ''                                     
	ELSE IV.Name + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                    
	+')'                                     
	END END AS Name                                          
	,IV.GroupID,IV.GroupName,IV.PackageID,IV.PackageName,IV.Value,IV.UOMCode,'PKG',IV.SequenceNo                                                      
	FROM InvestigationValues IV             
	INNER JOIN PatientInvestigation PInv ON PInv.OrgID = IV.Orgid AND PInv.PatientVisitID = IV.PatientVisitID AND PInv.UID = IV.UID AND PInv.InvestigationID = IV.InvestigationID                                                    
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IV.InvestigationID AND IOM.OrgID = IV.OrgID                                                      
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = IV.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                    
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(IV.UID,'') --Ramki                                                      
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode       LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                                                      
	WHERE IRM.IsDefault = 'Y' AND                                                   
	IV.PatientVisitID = @pVisitID AND IV.OrgID = @OrgID AND IV.PackageID = @GroupID AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                        
	ORDER BY IV.SequenceNo                                                      
                                                       
FETCH NEXT FROM PKGCursor INTO @GroupID                                                      
END                                                       
                                                      
CLOSE PKGCursor
DEALLOCATE PKGCursor                                
-----------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------
--This Cursor is used to Collect all Investigations and its values of (Insurance) available in Patient Investigation & Investigation Values Tables                                   
DECLARE INSCursor CURSOR FOR                                                       
                                                       
	SELECT DISTINCT OI.ID                                                      
	FROM OrderedInvestigations OI                               
	INNER JOIN @tblResultSelectID trs ON OI.AccessionNumber = trs.AccessionNo               
	WHERE OI.VisitID = @pVisitID AND OI.OrgID = @OrgID AND OI.Type = 'INS'                                        
                                                      
OPEN INSCursor FETCH NEXT FROM INSCursor INTO @GroupID                                                      
WHILE @@FETCH_STATUS = 0                                                       
BEGIN                                                      
    
    --This block Collects all Investigations details of (Insurance) available in Patient Investigation Table                                                                                                                                                                                           
	INSERT INTO @TempTableInvestigation (InvestigationID,InvestigationName,GroupID,GroupName,PackageID,PackageName,Status,Reason,ReferenceRange,SequenceNo,DeptID,DeptName,Type,GroupComment)                                                      
	SELECT DISTINCT PInv.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN PInv.InvestigationName                                                      
	ELSE PInv.InvestigationName + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                      
	+')' END AS InvestigationName                                                      
	,PInv.GroupID,PInv.GroupName,PInv.PackageID,PInv.PackageName,PInv.Status,PInv.Reason,PInv.ReferenceRange,IOM.SequenceNo, IOM.DeptID, IDM.DeptName,'INS',''                                                       
	FROM PatientInvestigation PInv                                                      
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID                                                      
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID AND IDM.OrgID = IOM.OrgID                                                      
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = PInv.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID   AND IRM.OrgID = IOM.OrgID                           
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(PInv.UID,'') --Ramki                        
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                                      
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID              
	WHERE IRM.IsDefault = 'Y' AND                                                   
	PInv.PatientVisitID = @pVisitID AND PInv.OrgID = @OrgID AND PInv.PackageID = @GroupID AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                        
	ORDER BY IOM.SequenceNo                                                      
    
    --This block Collects all Investigation values of (Insurance) available in Investigation Values Table                                                                                                                                                                                                                       
	INSERT INTO @TempTableInvestigationValues (InvestigationValuesID,InvestigationID,InvestigationName,GroupID,GroupName,PackageID,PackageName,Value,UOMCode,Type,SequenceNo)              
	SELECT DISTINCT                                                   
	IV.InvestigationValueID,IV.InvestigationID,                                                      
	CASE ISNULL(ISM.SampleCode,'') WHEN '' THEN IV.Name                                                  
	ELSE CASE IV.Name WHEN ''                                     
	THEN ''                                     
	ELSE IV.Name + ' - (' +                                                      
	CASE ISNULL(ISC.ContainerName,'') WHEN '' THEN ISM.SampleDesc                                                      
	ELSE ISM.SampleDesc + ' ['+ISC.ContainerName+']' END                                                      
	+')'                                     
	END END AS Name                                                      
	,IV.GroupID,IV.GroupName,IV.PackageID,IV.PackageName,IV.Value,IV.UOMCode,'INS',IV.SequenceNo                              
	FROM InvestigationValues IV              
	INNER JOIN PatientInvestigation PInv ON PInv.OrgID = IV.Orgid AND PInv.PatientVisitID = IV.PatientVisitID AND PInv.UID = IV.UID AND PInv.InvestigationID = IV.InvestigationID                                                   
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = IV.InvestigationID AND IOM.OrgID = IV.OrgID                                                      
	INNER JOIN InvReportMapping IRMP ON IRMP.InvestigationID = IV.InvestigationID                                                      
	INNER JOIN InvReportMaster IRM ON IRM.TemplateID = IRMP.TemplateID  AND IRM.OrgID = IOM.OrgID                    
	INNER JOIN @tblResultSelectUID RSU ON iSNULL(RSU.UID,'') = IsNULL(IV.UID,'') --Ramki                                                      
	LEFT JOIN InvSampleMaster ISM ON ISM.SampleCode = IOM.SampleCode                                                      
	LEFT JOIN InvestigationSampleContainer ISC ON ISC.SampleContainerID = IOM.SampleContainerID                          
	WHERE IRM.IsDefault = 'Y' AND                                                   
	IV.PatientVisitID = @pVisitID AND IV.OrgID = @OrgID AND IV.PackageID = @GroupID  AND (PInv.Status='Pending' OR PInv.Status='Completed' OR PInv.Status = 'Approve')                                                       
	ORDER BY IV.SequenceNo                                                      
                                                     
FETCH NEXT FROM INSCursor INTO @GroupID                                                      
END                                                       
                                                      
CLOSE INSCursor                                                      
DEALLOCATE INSCursor                                                      
----------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------
--This block Retrives All Individual Investigations, Groups belongs to Single Department wise  
--It takes Dept IDs one by one and Loop through the Investigations, Groups                                                        
SET @pDeptName = '' 
--This block collects the Sample Attributes Results (i.e color - red)                                                      
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
	SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                      
	FROM @TempTableSampleMapping TTSM                                                      
	WHERE TTSM.DeptID IS NULL                                                      
--This Cursor fetches the Dept IDs one by one & loop through with all Individual and Groups which have that single Department.                                           
DECLARE FinalCursor1 CURSOR FOR                                                       
                                                       
	SELECT DeptID                                               
	FROM @TempTableDept ORDER BY SequenceNo, DeptID                                                      
                                                      
OPEN FinalCursor1 FETCH NEXT FROM FinalCursor1 INTO @DeptID                                                      
WHILE @@FETCH_STATUS = 0                                                       
BEGIN                                                      
--This IF stmt checks & allows inside the loop, if only Investigations or Groups available for the fetched department      
	IF (EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
	FROM @TempTableInvestigation TTI                                                      
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
	WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='INV' ) OR (                                                      
	EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
	FROM @TempTableInvestigation TTI                                                      
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
	WHERE TTI.DeptID = @DeptID AND TTI.Type = 'GRP' AND TTI.PackageID = 0 )                                                      
	))                                          
	BEGIN                                                      
                                                        
        --This IF stmt checks & allows inside the loop, if only Investigations available or it directly goes to Group                                                
		IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
		FROM @TempTableInvestigation TTI                                                      
		INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
		WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='INV' )                                                      
		BEGIN                                                      
                                     
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
			SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
			FROM InvDeptMaster            
			WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
                                                       
			SELECT DISTINCT @pDeptName = DeptName                                                      
			FROM InvDeptMaster                                                      
			WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
			                                                        
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
			SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
			FROM @TempTableSampleMapping TTSM                                                  
			WHERE TTSM.DeptID = @DeptID          
                                                       
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
			SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
			FROM @TempTableInvestigation TTI           
			INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
			WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='INV' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                                      
			                                                        
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
			VALUES ('','','','','','','')                                                      
                                                       
		END                                                       
	END                                                      
                                                       
	SET @pPKGTitleName = ''                                                      
	--This Cursor fetches available Groups one by one, then loop through it with Current fetched Dept ID above.
	DECLARE PackageCursor CURSOR FOR                                                       
	SELECT DISTINCT TTI.GroupID                                      
	FROM @TempTableInvestigation TTI                                                      
	WHERE TTI.PackageID = 0 AND TTI.Type = 'GRP'                                                      
                                    
	OPEN PackageCursor FETCH NEXT FROM PackageCursor INTO @PackageID                                                      
	WHILE @@FETCH_STATUS = 0                                                       
	BEGIN                                                      
                                                        
		DELETE FROM @TempTableDeptForGroup                                                      
		INSERT INTO @TempTableDeptForGroup(GRPDeptID)                                                      
		SELECT DISTINCT TTI.DeptID                                   
		FROM @TempTableInvestigation TTI                                                      
		WHERE TTI.GroupID = @PackageID AND TTI.Type = 'GRP'                                                      
        --This fetches Groups one by one which has single Dept                                                  
		DECLARE FinalCursor2 CURSOR FOR                                                       
		
			SELECT DISTINCT TTI.GroupID                                                      
			FROM @TempTableInvestigation TTI                                                      
			WHERE TTI.GroupID = @PackageID AND TTI.Type = 'GRP'                                                       
			AND                                                       
			((                                                      
			SELECT COUNT(1)                                                      
			FROM @TempTableDeptForGroup TTDFG                                                      
			) < 2) --checks only for single Dept                                                     
                                                        
		OPEN FinalCursor2 FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
		WHILE @@FETCH_STATUS = 0                                                  
		BEGIN                                                      
                                                       
			SET @pTitleName = ''                                                      
            --This IF checks & allows inside the block, only if there is any Group avaible with the fetched Dept                                            
			IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
			FROM @TempTableInvestigation TTI                                                      
			INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
			WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'GRP' AND TTI.PackageID = 0 )                                                      
			BEGIN                                                      
                                                       
				IF EXISTS ( SELECT OI.ID                                                    
				FROM OrderedInvestigations OI                           
				INNER JOIN InvOrgGroup OG ON OG.AttGroupID = OI.ID AND OG.OrgID = OI.OrgID                                                     
				WHERE OG.OrgGroupID = @GroupID AND OI.Type = 'GRP' AND OI.OrgID = @OrgID AND OI.VisitID = @pVisitID)                                                      
				BEGIN                                                      
                                                       
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
					SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
					FROM InvDeptMaster                                                      
					WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
					                                                       
					SELECT DISTINCT @pDeptName = DeptName                                                      
					FROM InvDeptMaster                                                      
					WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
					                                                      
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
					SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                      
					FROM @TempTableInvestigation TTI                              
					INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
					WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0             
           
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
					SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
					FROM @TempTableInvestigation TTI                              
					INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
					WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0           
					AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''                                                   
					                                                      
					SELECT DISTINCT @pTitleName = TTI.GroupName                                                      
					FROM @TempTableInvestigation TTI                                                 
					INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
					WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0                   
					                                                       
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
					SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                    
					FROM @TempTableSampleMapping TTSM                                                  
					WHERE TTSM.DeptID = @DeptID                                                       
					--This IF block allows & loop through, only if that Group contains Inner Group content Sequence 
					IF EXISTS(SELECT SequenceNo FROM InvGroupMapMaster WHERE GroupID = @PackageID AND SequenceNo IS NOT NULL)    
					BEGIN          
           
						DECLARE grpInnerLoop CURSOR FOR             
            
							SELECT InvestigationID,Parent FROM InvGroupMapMaster WHERE GroupID = @PackageID ORDER BY SequenceNo        
            
						OPEN grpInnerLoop FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent            
						WHILE @@FETCH_STATUS = 0             
						BEGIN            
							--This block checks for Group Inside a Group, if available it loops through Inner group
							IF(@grpInnerLoopParent = 'Y') --Y indicates Group Inside a Group   
							BEGIN    

								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')    
                                                   
								SET @ParentLabelName = 'PARENTINNERLOOP_1'                                                  
								GOTO INNERLOOP_GROUP1                                                  
								PARENTINNERLOOP_1:    
       
							END     
							ELSE --This allows for normal Group Contents with Group Sequence  
							BEGIN     
       
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
								SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
								FROM @TempTableInvestigation TTI                                                  
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
								WHERE TTIV.InvestigationID = @grpInnerLoopInvID AND TTI.DeptID = @DeptID AND TTI.PackageID = 0 AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                              
       
							END      
     
						FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent             
						END             
            
						CLOSE grpInnerLoop            
						DEALLOCATE grpInnerLoop  
						    
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						VALUES ('','','','','','','')    
 
					END    
					ELSE --This allows normal looping of Group contents without Sequence   
					BEGIN      
                       
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.PackageID = 0 AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                  
						                                                       
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)   
						VALUES ('','','','','','','')                                                      
						                                                       
						DELETE FROM @TempTableForInnerGroup                                                      
						INSERT INTO @TempTableForInnerGroup (InnerGRPID)                                                      
						SELECT InvestigationID FROM InvGroupMapMaster WHERE GroupID = @PackageID AND (Parent = 'Y')                                    
                        --This IF checks for normal Group Inside a Group without Sequence & loop through Inner Group                             
						IF EXISTS (SELECT InnerGRPID FROM @TempTableForInnerGroup)                                                      
						BEGIN                                                      

							SET @ParentLabelName = 'PARENT_1'                                                      
							SET @InnerPackageID = 0                                                      
							GOTO INNER_GROUP1                                                      
                                 
						END      
					END                                                    
				END                                                      
			END                                                      
                                     
		PARENT_1: FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
		END                                                      
                                                      
		CLOSE FinalCursor2                                                      
		DEALLOCATE FinalCursor2                                                      
                                                       
	FETCH NEXT FROM PackageCursor INTO @PackageID                                                      
	END                                                       
                                                      
	CLOSE PackageCursor                                                      
	DEALLOCATE PackageCursor                                                      
                                                 
FETCH NEXT FROM FinalCursor1 INTO @DeptID --This again fetches next Dept & loop through Investigations & Groups one by one                                                     
END                                                       
                                                      
CLOSE FinalCursor1                                                      
DEALLOCATE FinalCursor1                                                      
                                                       
                                                       
----------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------
                                                       
----------------------------------------------------------------------------------------------------------------------
--This block picks up the Groups with Multiple Departments
--It loops through the GroupID in Outer Level, then loop through the departments one by one in Inner Level
----------------------------------------------------------------------------------------------------------------------
                          
SET @pPKGTitleName = ''                                                      
--This Cursor fetches the Groups with Multiple Depts
DECLARE PackageCursor CURSOR FOR                            

	SELECT DISTINCT TTI.GroupID                                                      
	FROM @TempTableInvestigation TTI                                                      
	WHERE TTI.PackageID = 0 AND TTI.Type = 'GRP'                                                      
                                                      
OPEN PackageCursor FETCH NEXT FROM PackageCursor INTO @PackageID                                                      
WHILE @@FETCH_STATUS = 0                          
BEGIN                                                      
                                                       
	DELETE FROM @TempTableDeptForGroup                                                      
	INSERT INTO @TempTableDeptForGroup(GRPDeptID)                                                      
	SELECT DISTINCT TTI.DeptID                                                      
	FROM @TempTableInvestigation TTI                                                      
	WHERE TTI.GroupID = @PackageID AND TTI.Type = 'GRP'                                                      
    --This cursor fetches Group one by one which has more than one Dept                                                      
	DECLARE FinalCursor2 CURSOR FOR                                                       
		
		SELECT DISTINCT TTI.GroupID                                                      
		FROM @TempTableInvestigation TTI                                                      
		WHERE TTI.GroupID = @PackageID AND TTI.Type = 'GRP'                                                       
		AND                                                       
		((                                                      
		SELECT COUNT(1)                                                      
		FROM @TempTableDeptForGroup TTDFG                                                     
		) > 1)--Checks more than one Dept                                        
                                                       
	OPEN FinalCursor2 FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
	WHILE @@FETCH_STATUS = 0                                                       
	BEGIN                                                      
                                                       
		IF EXISTS ( SELECT OI.ID                                                    
		FROM OrderedInvestigations OI                                                    
		INNER JOIN InvOrgGroup OG ON OG.AttGroupID = OI.ID AND OG.OrgID = OI.OrgID                                                     
		WHERE OG.OrgGroupID = @GroupID AND OI.Type = 'GRP' AND OI.OrgID = @OrgID AND OI.VisitID = @pVisitID)                                                      
		BEGIN                                                      
                                                       
			SET @pTitleName = ''                                                      
			--This Cursor fetches the Dept one by one, loop through it by its Sequence in InvDeptMaster
			--When looping it collects Individual Investigations, Group Inside a Group
			DECLARE FinalCursor4 CURSOR FOR                                                       
                                                       
				SELECT DISTINCT DeptID,SequenceNo                                                      
				FROM @TempTableDept ORDER BY SequenceNo,DeptID                                                      
                                                      
			OPEN FinalCursor4 FETCH NEXT FROM FinalCursor4 INTO @DeptID,@sequenceNo                                                      
			WHILE @@FETCH_STATUS = 0                                                       
			BEGIN                                                      
                                                       
				INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
				SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                      
				FROM @TempTableInvestigation TTI                                                    
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0                                                      
           
				INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
				SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
				FROM @TempTableInvestigation TTI                              
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0                                                    
				AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''          
                                                       
				SELECT DISTINCT @pTitleName = TTI.GroupName                                                      
				FROM @TempTableInvestigation TTI                                                      
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0                                                      
                --This IF checks for the Groups available in that fetched Dept, then allows inside the loop                                       
				IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                               
				FROM @TempTableInvestigation TTI                                                      
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'GRP' AND TTI.PackageID = 0 )                                                      
				BEGIN                                                      
                                                       
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
					SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
					FROM InvDeptMaster                                                      
					WHERE DeptID = @DeptID AND OrgID = @OrgID                                                      
					                                                      
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
					SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
					FROM @TempTableSampleMapping TTSM                                                  
					WHERE TTSM.DeptID = @DeptID                                                       
					--This IF checks, for Sequence inside the Group, if available allows inside 
					IF EXISTS(SELECT SequenceNo FROM InvGroupMapMaster WHERE GroupID = @PackageID AND SequenceNo IS NOT NULL)    
					BEGIN          
           
						DECLARE grpInnerLoop CURSOR FOR             
						            
						SELECT InvestigationID,Parent FROM InvGroupMapMaster WHERE GroupID = @PackageID ORDER BY SequenceNo        
						            
						OPEN grpInnerLoop FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent            
						WHILE @@FETCH_STATUS = 0             
						BEGIN            
							--This checks for the Group Inside a Group with Sequence No
							IF(@grpInnerLoopParent = 'Y')    
							BEGIN    

								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')    
                                                   
								SET @ParentLabelName = 'PARENTINNERLOOP_2'                                                  
								GOTO INNERLOOP_GROUP1                                                  
								PARENTINNERLOOP_2:    
       
							END     
							ELSE --This allows normal collecting of Group Individuals with Sequence    
							BEGIN     
       
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                     
								SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
								FROM @TempTableInvestigation TTI                                                  
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
								WHERE TTIV.InvestigationID = @grpInnerLoopInvID AND TTI.DeptID = @DeptID AND TTI.PackageID = 0 AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                              
       
							END      
     
						FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent             
						END             
            
						CLOSE grpInnerLoop            
						DEALLOCATE grpInnerLoop      

						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						VALUES ('','','','','','','')    

					END    
					ELSE--This allows collection of Individuals without Sequence    
					BEGIN                           
      
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                             
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.PackageID = 0 AND TTI.GroupID = @GroupID AND TTI.Type = 'GRP' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                                      
						                                                    
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						VALUES ('','','','','','','')                                                      
                                                       
					END                                                      
				END             
 
			FETCH NEXT FROM FinalCursor4 INTO @DeptID,@sequenceNo                                                      
			END                                                      
                                                     
			CLOSE FinalCursor4                                                      
			DEALLOCATE FinalCursor4                                                      

			DELETE FROM @TempTableForInnerGroup                                    
			INSERT INTO @TempTableForInnerGroup (InnerGRPID)                                                      
			SELECT InvestigationID FROM InvGroupMapMaster WHERE GroupID = @PackageID AND (Parent = 'Y')                                                      
            --This allows collection of Group Inside a Group without Sequence                                           
			IF EXISTS (SELECT InnerGRPID FROM @TempTableForInnerGroup)                                                      
			BEGIN                                         
			
				SET @InnerPackageID = 0                                                      
				SET @ParentLabelName = 'PARENT_2'                                                      
				GOTO INNER_GROUP1                                                      
                                                       
			END     
		END                                                     
                                                       
	PARENT_2:FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
	END                                                      
                                                      
	CLOSE FinalCursor2                                                      
	DEALLOCATE FinalCursor2                                                      
                                                     
FETCH NEXT FROM PackageCursor INTO @PackageID                                                      
END                                     
                                                      
CLOSE PackageCursor                                                      
DEALLOCATE PackageCursor                                                      
----------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------
                                                       
----------------------------------------------------------------------------------------------------------------------
--This block picks up the Packages with Multiple Departments
--It loops through the PackageID in Outer Level, then loop through the departments one by one in Inner Level
----------------------------------------------------------------------------------------------------------------------
                                                       
SET @pPKGTitleName = ''                                                      
--This Cursor fetches the Packages one by one, loop through it 
DECLARE PackageCursor1 CURSOR FOR                                                       

	SELECT DISTINCT TTI.PackageID                                                     
	FROM @TempTableInvestigation TTI                                                      
	WHERE TTI.PackageID != 0 AND TTI.Type = 'PKG'                                                      
                                                       
OPEN PackageCursor1 FETCH NEXT FROM PackageCursor1 INTO @PackageID                                                      
WHILE @@FETCH_STATUS = 0                                                       
BEGIN         
    --This displays Package Name as Heading
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
	SELECT DISTINCT '<B>'+TTI.PackageName+' :'+'</B>' AS GroupName,'','','','','',''                                                      
	FROM @TempTableInvestigation TTI                                                      
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
	WHERE TTI.Type = 'PKG' AND TTI.PackageName != @pPKGTitleName AND TTI.PackageID = @PackageID                                                      
                                                       
	SELECT DISTINCT @pTitleName = TTI.PackageName                                     FROM @TempTableInvestigation TTI                                                      
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                 
	WHERE TTI.Type = 'PKG' AND TTI.PackageName != @pPKGTitleName AND TTI.PackageID = @PackageID    
   
	IF EXISTS(SELECT IPM.SequenceNo FROM InvPackageMapping IPM    
	INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IPM.PackageID    
	WHERE IOG.AttGroupID = @GroupID AND IPM.SequenceNo IS NOT NULL)      
	BEGIN       
		--This Cursor picks the Package contents one by one based on Package Inner Sequence 
		DECLARE PackageSequenceCursor CURSOR FOR                                                       

			SELECT DISTINCT IPM.ID, IPM.Type, IPM.SequenceNo FROM InvPackageMapping IPM  
			INNER JOIN InvOrgGroup IOG ON IOG.OrgGroupID = IPM.PackageID AND IOG.OrgID = @OrgID    
			WHERE IOG.AttGroupID =  @PackageID  ORDER BY IPM.SequenceNo                                                   
                                                       
		OPEN PackageSequenceCursor FETCH NEXT FROM PackageSequenceCursor INTO @PKGContentID, @PKGContentType, @PKGContentSequence                                                        
		WHILE @@FETCH_STATUS = 0                                                       
		BEGIN   
            --This Cursor fetches the Dept one by one & loop through it                                     
			DECLARE FinalCursor1 CURSOR FOR                                                       
                                                       
				SELECT DISTINCT DeptID,sequenceno                                                      
				FROM @TempTableDept ORDER BY SequenceNo, DeptID                                                     
                                                      
			OPEN FinalCursor1 FETCH NEXT FROM FinalCursor1 INTO @DeptID,@sequenceNo                                                       
			WHILE @@FETCH_STATUS = 0                                                       
			BEGIN                                                      
                --This IF checks for the contents available for fetched Dept                                         
				IF (EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
				FROM @TempTableInvestigation TTI                                                      
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='PKG' ) OR (                                                      
				EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
				FROM @TempTableInvestigation TTI                                                      
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.Type = 'PKG' AND TTI.GroupID = 0 AND TTI.PackageID = @PackageID )                                      
				))                                                      
				BEGIN                                                 
                                                        
                    --This IF checks for the Package Individual Investigations, available for the fetched Dept                          
					IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
					FROM @TempTableInvestigation TTI                                                      
					INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
					WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='PKG' AND TTI.InvestigationID = @PKGContentID AND @PKGContentType = 'INV')                                                      
					BEGIN                                                      
                         
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                
						SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
						FROM InvDeptMaster                                  
						WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
                                                       
						SELECT DISTINCT @pDeptName = DeptName                                                      
						FROM InvDeptMaster                                                      
						WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
                                                        
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
						SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
						FROM @TempTableSampleMapping TTSM                                                  
						WHERE TTSM.DeptID = @DeptID                                                          
                                                       
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                            
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='PKG' AND TTI.InvestigationID = @PKGContentID AND @PKGContentType = 'INV' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                             
                                                        
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						VALUES ('','','','','','','')                                
                                                 
					END                                
				END                                                      
                                    
				SET @pPKGTitleName = ''                                                      
				--This Cursor fetches the Groups inside the Package which belongs to single Dept one by one & loop through it
				DECLARE PackageCursor CURSOR FOR                                                       

					SELECT DISTINCT TTI.GroupID                                                      
					FROM @TempTableInvestigation TTI    
					INNER JOIN InvOrgGroup IOG ON IOG.AttGroupID = TTI.GroupID AND IOG.OrgID = @OrgID                                        
					WHERE TTI.PackageID = @PackageID AND TTI.Type = 'PKG' AND IOG.OrgGroupID = @PKGContentID AND @PKGContentType = 'GRP'                                                     
                                                       
				OPEN PackageCursor FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
				WHILE @@FETCH_STATUS = 0                                                       
				BEGIN                              
                                                       
					DELETE FROM @TempTableDeptForGroup                                                      
					INSERT INTO @TempTableDeptForGroup(GRPDeptID)                                                      
					SELECT DISTINCT TTI.DeptID                                  
					FROM @TempTableInvestigation TTI                                                      
					WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                      
                                                           
					DECLARE FinalCursor2 CURSOR FOR                                                       

						SELECT DISTINCT TTI.GroupID                                                      
						FROM @TempTableInvestigation TTI     
						WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                       
						AND                                                       
						((                                               
						SELECT COUNT(1)                                               
						FROM @TempTableDeptForGroup TTDFG                                         
						) < 2)-- checks for single Dept                                                      
                                                       
					OPEN FinalCursor2 FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
					WHILE @@FETCH_STATUS = 0                                                       
					BEGIN                                                      
                        --This checks for particular fetched Group exists in mapping      
						IF EXISTS(                                                  
						SELECT IPM.ID FROM InvGroupMaster GM                                                   
						INNER JOIN InvOrgGroup OG ON OG.AttGroupID = GM.GroupID AND OG.OrgID = @OrgID                                                
						INNER JOIN InvPackageMapping IPM ON IPM.PackageID = OG.OrgGroupID AND IPM.Type = 'GRP'    
						INNER JOIN InvOrgGroup OG1 ON OG1.AttGroupID = @GroupID AND OG1.OrgGroupID = IPM.ID  AND OG1.OrgID = @OrgID                                             
						WHERE GM.GroupID = @PackageID                                                  
						)                                                      
						BEGIN                                                      
                                     
							SET @pTitleName = ''                                                      
                            --This IF checks for Group content avaible for the fetched Dept                            
							IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
							FROM @TempTableInvestigation TTI                                                   
							INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
							WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.PackageID = @PackageID )                                                      
							BEGIN       
     
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
								FROM InvDeptMaster                                                      
								WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
								   
								SELECT DISTINCT @pDeptName = DeptName                                                      
								FROM InvDeptMaster                                                      
								WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
                                                        
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                      
								FROM @TempTableInvestigation TTI                                                      
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
								WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                                      
           
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
								FROM @TempTableInvestigation TTI                              
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
								WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0          
								AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''          
                                                       
								SELECT DISTINCT @pTitleName = TTI.GroupName                                                      
								FROM @TempTableInvestigation TTI                                                      
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
								WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                                      
                                                       
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
								SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
								FROM @TempTableSampleMapping TTSM                                                  
								WHERE TTSM.DeptID = @DeptID                                                  
								--This IF checks & allows if Group Inner sequence is present
								IF EXISTS(SELECT IGMM.SequenceNo FROM InvGroupMapMaster IGMM    
								INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
								WHERE IOG.AttGroupID = @GroupID AND IGMM.SequenceNo IS NOT NULL)      
								BEGIN            
             
									DECLARE grpInnerLoop CURSOR FOR               
     
										SELECT IGMM.InvestigationID,IGMM.Parent FROM InvGroupMapMaster IGMM    
										INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
										WHERE IOG.AttGroupID = @GroupID ORDER BY IGMM.SequenceNo    
              
									OPEN grpInnerLoop FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent              
									WHILE @@FETCH_STATUS = 0               
									BEGIN              
										--This checks for Group Inside a Group with current Group Sequence
										IF(@grpInnerLoopParent = 'Y')      
										BEGIN      
											
											INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
											VALUES ('','','','','','','')     
                                                     
											SET @ParentLabelName = 'PARENTINNERLOOP_3'                                                    
											GOTO INNERLOOP_GROUP1                                                    
											PARENTINNERLOOP_3:      
         
										END       
										ELSE --This collects contents for Individuals with current Group Sequence     
										BEGIN       
         
											INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                 
											SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
											FROM @TempTableInvestigation TTI                                                  
											INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
											WHERE TTIV.InvestigationID = @grpInnerLoopInvID AND TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                        
  
										END        
       
									FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent               
									END               
              
									CLOSE grpInnerLoop              
									DEALLOCATE grpInnerLoop  
									      
									INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
									VALUES ('','','','','','','')      
								
								END      
								ELSE--This ELSE allows current group Individual contents without current Group Sequence      
								BEGIN                         
                                                        
									INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                             
									SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
									FROM @TempTableInvestigation TTI                                                      
									INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
									WHERE TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                                      
                                                       
									INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
									VALUES ('','','','','','','')                                                      
                                                       
									DELETE FROM @TempTableForInnerGroup                                                      
									INSERT INTO @TempTableForInnerGroup (InnerGRPID)                                                      
									SELECT IGMM.InvestigationID FROM InvGroupMapMaster IGMM    
									INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IGMM.GroupID = IOG.OrgGroupID     
									WHERE IOG.AttGroupID = @GroupID AND (IGMM.Parent = 'Y')  
									--This IF checks for the Group Inside a Group without current Group Sequence                                                                  
									IF EXISTS (SELECT InnerGRPID FROM @TempTableForInnerGroup)                                                      
									BEGIN                                                      

										SET @InnerPackageID = @PackageID                                                      
										SET @ParentLabelName = 'PARENT_3'                                              
										GOTO INNER_GROUP1                                                      
									
									END                             
								END                
							END                                                      
						END                                                      
                                                       
					PARENT_3: FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
					END                                                      
                                                      
					CLOSE FinalCursor2                                                      
					DEALLOCATE FinalCursor2        
                                                       
				FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
				END                                                       
                                                      
			CLOSE PackageCursor                                                      
			DEALLOCATE PackageCursor                                                      
           
		FETCH NEXT FROM FinalCursor1 INTO @DeptID,@sequenceNo                                                       
		END                                                       
                                                      
		CLOSE FinalCursor1                                                      
		DEALLOCATE FinalCursor1                                                      
                                                       
                                                         
		SET @pPKGTitleName = ''                                                      
		--This Cursor fetches the Packages one by one which has more than one dept and loop through it
		DECLARE PackageCursor CURSOR FOR                                    

			SELECT DISTINCT TTI.GroupID                                                      
			FROM @TempTableInvestigation TTI   
			INNER JOIN InvOrgGroup IOG ON IOG.AttGroupID = TTI.GroupID AND IOG.OrgID = @OrgID                                                     
			WHERE TTI.PackageID = @PackageID AND TTI.Type = 'PKG' AND IOG.OrgGroupID = @PKGContentID AND @PKGContentType = 'GRP'                                                     
                                            
		OPEN PackageCursor FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
		WHILE @@FETCH_STATUS = 0                                                       
		BEGIN                                                      
                                      
			DELETE FROM @TempTableDeptForGroup                                                      
			INSERT INTO @TempTableDeptForGroup(GRPDeptID)                                                      
			SELECT DISTINCT TTI.DeptID                                                      
			FROM @TempTableInvestigation TTI                                                      
			WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                      
            --This Cursor fetches Packages which has more than one Dept                                           
			DECLARE FinalCursor2 CURSOR FOR                                                       

				SELECT DISTINCT TTI.GroupID                                                      
				FROM @TempTableInvestigation TTI                                                      
				WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                      
				AND                                                       
				((                      
				SELECT COUNT(1)                                                      
				FROM @TempTableDeptForGroup TTDFG                                                      
				) > 1)--checks for more than one                                                      
                                                       
			OPEN FinalCursor2 FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
			WHILE @@FETCH_STATUS = 0                                                 
			BEGIN                                       
                                                       
				IF EXISTS(                                                  
				SELECT IPM.ID FROM InvGroupMaster GM                                                   
				INNER JOIN InvOrgGroup OG ON OG.AttGroupID = GM.GroupID AND OG.OrgID = @OrgID                                                
				INNER JOIN InvPackageMapping IPM ON IPM.PackageID = OG.OrgGroupID AND IPM.Type = 'GRP'    
				INNER JOIN InvOrgGroup OG1 ON OG1.AttGroupID = @GroupID AND OG1.OrgGroupID = IPM.ID  AND OG1.OrgID = @OrgID                                             
				WHERE GM.GroupID = @PackageID                                                 
				 )                                                      
				BEGIN                                                      
                                                       
					SET @pTitleName = ''                                     
					--This Cursor fetches the Dept one by one & loop through it
					DECLARE FinalCursor4 CURSOR FOR                                                       
                                                       
						SELECT DISTINCT DeptID,sequenceno                                                      
						FROM @TempTableDept ORDER BY SequenceNo,DeptID                                                      
                                                      
					OPEN FinalCursor4 FETCH NEXT FROM FinalCursor4 INTO @DeptID,@sequenceNo                                                      
					WHILE @@FETCH_STATUS = 0                                                       
					BEGIN                                                      
                                                       
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                      
						FROM @TempTableInvestigation TTI                    
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                                      
           
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
						FROM @TempTableInvestigation TTI                              
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0          
						AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''          
                  
						SELECT DISTINCT @pTitleName = TTI.GroupName                                                      
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                       
                        --This IF checks for the Individual Investigations available for the fetched Dept                               
						IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                     
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.PackageID = @PackageID )                                                      
						BEGIN                                                      
                                                       
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
							SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
							FROM InvDeptMaster                                                      
							WHERE DeptID = @DeptID AND OrgID = @OrgID                                                      
							                                                       
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
							SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
							FROM @TempTableSampleMapping TTSM                                                  
							WHERE TTSM.DeptID = @DeptID                                                   
							--This IF checks for the Groups available with Inner Sequnce
							IF EXISTS(SELECT IGMM.SequenceNo FROM InvGroupMapMaster IGMM    
							INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
							WHERE IOG.AttGroupID = @GroupID AND IGMM.SequenceNo IS NOT NULL)      
							BEGIN            
             
								DECLARE grpInnerLoop CURSOR FOR               
     
									SELECT IGMM.InvestigationID,IGMM.Parent FROM InvGroupMapMaster IGMM    
									INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
									WHERE IOG.AttGroupID = @GroupID ORDER BY IGMM.SequenceNo         
              
								OPEN grpInnerLoop FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent              
								WHILE @@FETCH_STATUS = 0               
								BEGIN              
									--This IF checks for the Group Inside a Group with current Group Sequence
									IF(@grpInnerLoopParent = 'Y')      
									BEGIN      
		
										INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
										VALUES ('','','','','','','')     
                                                     
										SET @ParentLabelName = 'PARENTINNERLOOP_4'                                                    
										GOTO INNERLOOP_GROUP1                                                    
										PARENTINNERLOOP_4:      
         
									END       
									ELSE --This allows to collect Individuals of Group with current Group Sequence     
									BEGIN       
         
										INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
										SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                 
										FROM @TempTableInvestigation TTI                                                  
										INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
										WHERE TTIV.InvestigationID = @grpInnerLoopInvID AND TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                        
  
									END        
       
								FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent               
								END               
              
								CLOSE grpInnerLoop              
								DEALLOCATE grpInnerLoop        

								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')         

							END      
							ELSE--This allows to collect Individuals of current Group without sequence      
							BEGIN                       
                                                        
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
								FROM @TempTableInvestigation TTI                                                      
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
								WHERE TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                                      
                                          
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')                                                      
                                                       
							END                                                      
                                                       
						FETCH NEXT FROM FinalCursor4 INTO @DeptID,@sequenceNo                                                       
						END                                                      
                                                      
						CLOSE FinalCursor4                                                      
						DEALLOCATE FinalCursor4                                                      
                                                       
						DELETE FROM @TempTableForInnerGroup                                                      
						INSERT INTO @TempTableForInnerGroup (InnerGRPID)                                 
						SELECT IGMM.InvestigationID FROM InvGroupMapMaster IGMM    
						INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IGMM.GroupID = IOG.OrgGroupID     
						WHERE IOG.AttGroupID = @GroupID AND (IGMM.Parent = 'Y')                                                      
                        --This IF checks for the collection for Group Inside a Group without Sequence                               
						IF EXISTS (SELECT InnerGRPID FROM @TempTableForInnerGroup)                                                      
						BEGIN                                                      

							SET @InnerPackageID = @PackageID                                                      
							SET @ParentLabelName = 'PARENT_4'                                                      
							GOTO INNER_GROUP1                                                 

						END                                                      
					END                                                      
				END                               

			PARENT_4: FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
			END                                     
                                                      
			CLOSE FinalCursor2                                                      
			DEALLOCATE FinalCursor2                                                      
                                                       
		FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
		END                                                       
                                                      
		CLOSE PackageCursor                                                      
		DEALLOCATE PackageCursor                                                   
     
	FETCH NEXT FROM PackageSequenceCursor INTO @PKGContentID, @PKGContentType, @PKGContentSequence              
	END               
	              
	CLOSE PackageSequenceCursor              
	DEALLOCATE PackageSequenceCursor                                              

	END  
	ELSE  
	BEGIN   
        --This fetches Dept one by one, loop through it                                                  
		DECLARE FinalCursor1 CURSOR FOR                                                       
                                                       
			SELECT DISTINCT DeptID,sequenceno                                                      
			FROM @TempTableDept ORDER BY SequenceNo, DeptID                                                     
                                                      
		OPEN FinalCursor1 FETCH NEXT FROM FinalCursor1 INTO @DeptID,@sequenceNo                                                       
		WHILE @@FETCH_STATUS = 0                                                       
		BEGIN                                                      
            --This checks for the contents available for the fetched dept                                            
			IF (EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
			FROM @TempTableInvestigation TTI                                                      
			INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
			WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='PKG' ) OR (                                                      
			EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
			FROM @TempTableInvestigation TTI                                                      
			INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
			WHERE TTI.DeptID = @DeptID AND TTI.Type = 'PKG' AND TTI.GroupID = 0 AND TTI.PackageID = @PackageID )                                      
			))           
			BEGIN                                                 
                --It checks for Individual Investigations available for the fetched Dept                                       
				IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
				FROM @TempTableInvestigation TTI                                                      
				INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                                      
				WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='PKG' )                                                      
				BEGIN                                                      
                         
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                
					SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
					FROM InvDeptMaster                                  
					WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
                                                       
					SELECT DISTINCT @pDeptName = DeptName                                                      
					FROM InvDeptMaster                                                      
					WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
                                                        
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
					SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
					FROM @TempTableSampleMapping TTSM                                                  
					WHERE TTSM.DeptID = @DeptID                                                          
                                                       
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
					SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
					FROM @TempTableInvestigation TTI                                                      
					INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID                                            
					WHERE TTI.DeptID = @DeptID AND TTI.GroupID = 0 AND TTI.Type='PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                             
                                                        
					INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
					VALUES ('','','','','','','')                                
                                                 
				END                                
			END                                                      
                                    
			SET @pPKGTitleName = ''                                                      
			--This Cursor fetches the Packages one by one, loop through it
			DECLARE PackageCursor CURSOR FOR                                                       

			SELECT DISTINCT TTI.GroupID                                                      
			FROM @TempTableInvestigation TTI                                          
			WHERE TTI.PackageID = @PackageID AND TTI.Type = 'PKG'                                                      
                                                       
			OPEN PackageCursor FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
			WHILE @@FETCH_STATUS = 0                                                       
			BEGIN                              
                                                        
				DELETE FROM @TempTableDeptForGroup                                                      
				INSERT INTO @TempTableDeptForGroup(GRPDeptID)                                                      
				SELECT DISTINCT TTI.DeptID                                  
				FROM @TempTableInvestigation TTI                                                      
				WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                      
                --This fetches the Packages which belongs to single Dept                                           
				DECLARE FinalCursor2 CURSOR FOR                                                       

					SELECT DISTINCT TTI.GroupID                                                      
					FROM @TempTableInvestigation TTI     
					WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                       
					AND                                                       
					((                                               
					SELECT COUNT(1)                                               
					FROM @TempTableDeptForGroup TTDFG                                         
					) < 2)-- checks for single Dept                                                      
                                                       
				OPEN FinalCursor2 FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
				WHILE @@FETCH_STATUS = 0                                                       
				BEGIN                                                      
                              
					IF EXISTS(                                                  
					SELECT IPM.ID FROM InvGroupMaster GM                                                   
					INNER JOIN InvOrgGroup OG ON OG.AttGroupID = GM.GroupID AND OG.OrgID = @OrgID                                                
					INNER JOIN InvPackageMapping IPM ON IPM.PackageID = OG.OrgGroupID AND IPM.Type = 'GRP'    
					INNER JOIN InvOrgGroup OG1 ON OG1.AttGroupID = @GroupID AND OG1.OrgGroupID = IPM.ID  AND OG1.OrgID = @OrgID                                             
					WHERE GM.GroupID = @PackageID                                                  
					)                                                      
					BEGIN                                                      
                                     
						SET @pTitleName = ''                                                      
                        --This IF checks for contents available for fetched Dept                                
						IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
						FROM @TempTableInvestigation TTI                                                   
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.PackageID = @PackageID )                                                      
						BEGIN       
                                                      
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
							SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
							FROM InvDeptMaster                                                      
							WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
							                                                       
							SELECT DISTINCT @pDeptName = DeptName                                                      
							FROM InvDeptMaster                                                      
							WHERE DeptID = @DeptID AND OrgID = @OrgID AND DeptName != @pDeptName                                                      
							                                                        
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
							SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                      
							FROM @TempTableInvestigation TTI                                                      
							INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
							WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                                      
           
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
							SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
							FROM @TempTableInvestigation TTI                              
							INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
							WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0          
							AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''          
							                                                       
							SELECT DISTINCT @pTitleName = TTI.GroupName                                                      
							FROM @TempTableInvestigation TTI                                                      
							INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
							WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                                      
							                                                       
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
							SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
							FROM @TempTableSampleMapping TTSM                                                  
							WHERE TTSM.DeptID = @DeptID                                                  
							--This IF checks for the Group Inner Sequence     
							IF EXISTS(SELECT IGMM.SequenceNo FROM InvGroupMapMaster IGMM    
							INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
							WHERE IOG.AttGroupID = @GroupID AND IGMM.SequenceNo IS NOT NULL)      
							BEGIN            
             
								DECLARE grpInnerLoop CURSOR FOR               
								     
								SELECT IGMM.InvestigationID,IGMM.Parent FROM InvGroupMapMaster IGMM    
								INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
								WHERE IOG.AttGroupID = @GroupID ORDER BY IGMM.SequenceNo    
								              
								OPEN grpInnerLoop FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent              
								WHILE @@FETCH_STATUS = 0               
								BEGIN              
									--This checks for Group Inside a Group with Current Group sequence
									IF(@grpInnerLoopParent = 'Y')      
									BEGIN      

										INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
										VALUES ('','','','','','','')     
                                                     
										SET @ParentLabelName = 'PARENTINNERLOOP_5'                                                    
										GOTO INNERLOOP_GROUP1                                                    
										PARENTINNERLOOP_5:      
         
									END       
									ELSE --This collects the Individual Investigations in current Group with Sequence     
									BEGIN       
         
										INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                 
										SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
										FROM @TempTableInvestigation TTI                                                  
										INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
										WHERE TTIV.InvestigationID = @grpInnerLoopInvID AND TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                        
        
									END        
       
								FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent               
								END               
              
								CLOSE grpInnerLoop              
								DEALLOCATE grpInnerLoop        

								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')      

							END      
							ELSE --This allows to collect the Individual Investigations of Group without current Group Sequence     
							BEGIN                         
                                                        
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                             
								SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
								FROM @TempTableInvestigation TTI                                                      
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
								WHERE TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                                      
								                                                       
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')                                                      
                                                       
								DELETE FROM @TempTableForInnerGroup                                                      
								INSERT INTO @TempTableForInnerGroup (InnerGRPID)                                                      
								SELECT IGMM.InvestigationID FROM InvGroupMapMaster IGMM    
								INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IGMM.GroupID = IOG.OrgGroupID     
								WHERE IOG.AttGroupID = @GroupID AND (IGMM.Parent = 'Y')                                                                    
								--This collects the contents of Group Inside a Group without Sequence
								IF EXISTS (SELECT InnerGRPID FROM @TempTableForInnerGroup)                                                      
								BEGIN                                                      

									SET @InnerPackageID = @PackageID                                                      
									SET @ParentLabelName = 'PARENT_5'                                              
									GOTO INNER_GROUP1                                                      

								END                             
							END                
						END                                                      
					END                                                      
                                                       
				PARENT_5: FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
				END                                                      
                                                      
				CLOSE FinalCursor2                                                      
				DEALLOCATE FinalCursor2        
                                                       
			FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
			END                                                       
			                                                      
			CLOSE PackageCursor                                                      
			DEALLOCATE PackageCursor                                                      
                                                       
		FETCH NEXT FROM FinalCursor1 INTO @DeptID,@sequenceNo                                                       
		END                                                       
		                                                      
		CLOSE FinalCursor1                                                      
		DEALLOCATE FinalCursor1                                                      
                                                       
                                                         
		SET @pPKGTitleName = ''                                                      
		--This Cursor fetches the Packages with more than one Dept and loop through it
		DECLARE PackageCursor CURSOR FOR                                    

			SELECT DISTINCT TTI.GroupID                                                      
			FROM @TempTableInvestigation TTI                                                      
			WHERE TTI.PackageID = @PackageID AND TTI.Type = 'PKG'                                                      
                                                       
		OPEN PackageCursor FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
		WHILE @@FETCH_STATUS = 0                                                       
		BEGIN                                                      
                                                       
			DELETE FROM @TempTableDeptForGroup                                                      
			INSERT INTO @TempTableDeptForGroup(GRPDeptID)                                                      
			SELECT DISTINCT TTI.DeptID                                                      
			FROM @TempTableInvestigation TTI                                                      
			WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                      
            --This fetches the Packages with more than one Dept                                           
			DECLARE FinalCursor2 CURSOR FOR                                                       

				SELECT DISTINCT TTI.GroupID                                                      
				FROM @TempTableInvestigation TTI                                                    
				WHERE TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupID!=0                                                      
				AND                                                       
				((                      
				SELECT COUNT(1)                                                      
				FROM @TempTableDeptForGroup TTDFG                                                      
				) > 1)--checks for more than one Dept                                                      
                   
			OPEN FinalCursor2 FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
			WHILE @@FETCH_STATUS = 0                                                 
			BEGIN                                       
                                                       
				IF EXISTS(                                                  
				SELECT IPM.ID FROM InvGroupMaster GM                                                   
				INNER JOIN InvOrgGroup OG ON OG.AttGroupID = GM.GroupID AND OG.OrgID = @OrgID                                                
				INNER JOIN InvPackageMapping IPM ON IPM.PackageID = OG.OrgGroupID AND IPM.Type = 'GRP'    
				INNER JOIN InvOrgGroup OG1 ON OG1.AttGroupID = @GroupID AND OG1.OrgGroupID = IPM.ID  AND OG1.OrgID = @OrgID                                             
				WHERE GM.GroupID = @PackageID                                                 
				)                                                      
				BEGIN                                                      
                                                       
					SET @pTitleName = ''                                     
					--This fetches the Dept one by one, loop through it
					DECLARE FinalCursor4 CURSOR FOR                                                       
                                                       
						SELECT DISTINCT DeptID,sequenceno                                                      
						FROM @TempTableDept ORDER BY SequenceNo,DeptID                                                      
						                                                      
					OPEN FinalCursor4 FETCH NEXT FROM FinalCursor4 INTO @DeptID,@sequenceNo                                                      
					WHILE @@FETCH_STATUS = 0                                                       
					BEGIN                                                      
                                                       
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                      
						FROM @TempTableInvestigation TTI                    
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                                      
           
						INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
						SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
						FROM @TempTableInvestigation TTI                              
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0          
						AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''          
                                                       
						SELECT DISTINCT @pTitleName = TTI.GroupName                                                      
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.GroupName != @pTitleName AND TTI.PackageID = @PackageID                                       
						--This IF checks for the contents available for the fetched Dept                                                       
						IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                     
						FROM @TempTableInvestigation TTI                                                      
						INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
						WHERE TTI.DeptID = @DeptID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' AND TTI.PackageID = @PackageID )                                                      
						BEGIN                                                      
                                                       
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
							SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
							FROM InvDeptMaster                                                      
							WHERE DeptID = @DeptID AND OrgID = @OrgID                                                      
							                                                       
							INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
							SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
							FROM @TempTableSampleMapping TTSM                                                  
							WHERE TTSM.DeptID = @DeptID                                                   
							--This IF checks for the Inner Group Sequence
							IF EXISTS(SELECT IGMM.SequenceNo FROM InvGroupMapMaster IGMM    
							INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
							WHERE IOG.AttGroupID = @GroupID AND IGMM.SequenceNo IS NOT NULL)      
							BEGIN            
             
								DECLARE grpInnerLoop CURSOR FOR               
								     
								SELECT IGMM.InvestigationID,IGMM.Parent FROM InvGroupMapMaster IGMM    
								INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IOG.OrgGroupID = IGMM.GroupID    
								WHERE IOG.AttGroupID = @GroupID ORDER BY IGMM.SequenceNo         
								              
								OPEN grpInnerLoop FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent              
								WHILE @@FETCH_STATUS = 0               
								BEGIN              
									--This IF checks for the Group Inside a Group with current Group Inner Sequence
									IF(@grpInnerLoopParent = 'Y')      
									BEGIN      

										INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
										VALUES ('','','','','','','')     
                                                     
										SET @ParentLabelName = 'PARENTINNERLOOP_6'                                                    
										GOTO INNERLOOP_GROUP1                                                    
										PARENTINNERLOOP_6:      
         
									END       
									ELSE--This allows to collect the Individual Investigations of the Group with current Group Sequence       
									BEGIN       
         
										INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
										SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
										FROM @TempTableInvestigation TTI                                                  
										INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
										WHERE TTIV.InvestigationID = @grpInnerLoopInvID AND TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                        
  
          
       
									END        
       
								FETCH NEXT FROM grpInnerLoop INTO @grpInnerLoopInvID,@grpInnerLoopParent               
								END               
              
								CLOSE grpInnerLoop              
								DEALLOCATE grpInnerLoop        

								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')         

							END      
							ELSE -- This allows to collect the Individual Investigations of the current Group without Sequence     
							BEGIN                       
                                                        
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
								FROM @TempTableInvestigation TTI                                                      
								INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
								WHERE TTI.DeptID = @DeptID AND TTI.PackageID = @PackageID AND TTI.GroupID = @GroupID AND TTI.Type = 'PKG' ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                                      
                                          
								INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
								VALUES ('','','','','','','')                                                      
                                                       
							END                                                      
						END                                                      

					FETCH NEXT FROM FinalCursor4 INTO @DeptID,@sequenceNo                                                       
					END                                                      
                                                      
					CLOSE FinalCursor4                                                      
					DEALLOCATE FinalCursor4                                                      
                                                       
					DELETE FROM @TempTableForInnerGroup                                                      
					INSERT INTO @TempTableForInnerGroup (InnerGRPID)                                 
					SELECT IGMM.InvestigationID FROM InvGroupMapMaster IGMM    
					INNER JOIN InvOrgGroup IOG ON IOG.OrgID = @OrgID AND IGMM.GroupID = IOG.OrgGroupID     
					WHERE IOG.AttGroupID = @GroupID AND (IGMM.Parent = 'Y')                                                      
                    --This IF checks for the Group Inside a Group without Sequence                                   
					IF EXISTS (SELECT InnerGRPID FROM @TempTableForInnerGroup)                                                      
					BEGIN                                                      

						SET @InnerPackageID = @PackageID                                                      
						SET @ParentLabelName = 'PARENT_6'                                                      
						GOTO INNER_GROUP1    
						                                             
					END            
				END                                                      
                                    
			PARENT_6: FETCH NEXT FROM FinalCursor2 INTO @GroupID                                                      
			END                                     
                                                      
			CLOSE FinalCursor2                                                      
			DEALLOCATE FinalCursor2                                                      
                                                       
		FETCH NEXT FROM PackageCursor INTO @GroupID                                                      
		END                                                       
		                                                      
		CLOSE PackageCursor                                                      
		DEALLOCATE PackageCursor                                                   
                                 
	END  
                      
FETCH NEXT FROM PackageCursor1 INTO @PackageID                                                      
END                                                       
                                                      
CLOSE PackageCursor1                                                      
DEALLOCATE PackageCursor1                                                      
                                                       
--------------------------------------------------------------------------------------------------------                                                      
--After Executing all blocks it goes to the Result rendering block
--------------------------------------------------------------------------------------------------------                                                      

GOTO RESULT                                                      
                                          
---------------------------------------------------------------------------------------------------------------                                                      
--End of all Outer Loops
---------------------------------------------------------------------------------------------------------------                                                      
                                       
---------------------------------------------------------------------------------------------------------------
--Inner Loop starts here for Inner Groups execution
---------------------------------------------------------------------------------------------------------------
INNERLOOP_GROUP1: --Inner loop Group Inside a Group starts here                                             
                             
SET @pTitleName = ''                                                  
--This fetches the Dept one by one , loop through it                                                    
DECLARE FinalCursor4 CURSOR FOR                                                   

	SELECT DISTINCT DeptID,sequenceno    
	FROM @TempTableDept ORDER BY SequenceNo,DeptID                                                  
                                                   
OPEN FinalCursor4 FETCH NEXT FROM FinalCursor4 INTO @DeptID1,@sequenceNo                                                 
WHILE @@FETCH_STATUS = 0                                                   
BEGIN     
     
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
	SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                
	FROM @TempTableInvestigation TTI                                                  
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
	WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @grpInnerLoopInvID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') AND TTI.GroupName != @pTitleName --AND TTI.PackageID = @InnerPackageID                                                  
	       
	INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
	SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                  
	FROM @TempTableInvestigation TTI                          
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
	WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @grpInnerLoopInvID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0      
	AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''      
	                              
	SELECT DISTINCT @pTitleName = TTI.GroupName                                                  
	FROM @TempTableInvestigation TTI                                                  
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
	WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @grpInnerLoopInvID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') AND TTI.GroupName != @pTitleName --AND TTI.PackageID = @InnerPackageID                    
	--This IF checks for the contents available for the fetched dept                             
	IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
	FROM @TempTableInvestigation TTI                                                  
	INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
	WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @grpInnerLoopInvID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') --AND TTI.PackageID = @InnerPackageID     
	)                                                 
	BEGIN                                                  
                                                   
		INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
		SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                  
		FROM InvDeptMaster                                                  
		WHERE DeptID = @DeptID1 AND OrgID = @OrgID                                                  
		                                                   
		INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
		SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
		FROM @TempTableSampleMapping TTSM                                                  
		WHERE TTSM.DeptID = @DeptID1                                                   
		                                                    
		INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
		SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                  
		FROM @TempTableInvestigation TTI                                                  
		INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                  
		WHERE TTI.DeptID = @DeptID1 --AND TTI.PackageID = @InnerPackageID     
		AND TTI.GroupID = @grpInnerLoopInvID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                      
                
                                                   
		INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
		VALUES ('','','','','','','')                                       
                                        
	END                                                  

FETCH NEXT FROM FinalCursor4 INTO @DeptID1,@sequenceNo                                                 
END                                                  

CLOSE FinalCursor4                                 
DEALLOCATE FinalCursor4                                         
                                                  
                                                 
IF(@ParentLabelName = 'PARENTINNERLOOP_1')                                                  
	GOTO PARENTINNERLOOP_1     
IF(@ParentLabelName = 'PARENTINNERLOOP_2')                                                  
	GOTO PARENTINNERLOOP_2    
IF(@ParentLabelName = 'PARENTINNERLOOP_3')                                                  
	GOTO PARENTINNERLOOP_3     
IF(@ParentLabelName = 'PARENTINNERLOOP_4')                                                  
	GOTO PARENTINNERLOOP_4    
IF(@ParentLabelName = 'PARENTINNERLOOP_5')                                                  
	GOTO PARENTINNERLOOP_5     
IF(@ParentLabelName = 'PARENTINNERLOOP_6')                                                  
	GOTO PARENTINNERLOOP_6                                                              
                                                                               
INNER_GROUP1: DECLARE FinalCursorINNER1 CURSOR FOR                                                       

	SELECT DISTINCT InnerGRPID                                                      
	FROM @TempTableForInnerGroup                                                       
	OPEN FinalCursorINNER1 FETCH NEXT FROM FinalCursorINNER1 INTO @InnerGroupID                                                      
                                                      
WHILE @@FETCH_STATUS = 0                                                       
BEGIN                                                      
                                                       
	SET @pTitleName = ''                                                      
	                                                       
	DECLARE FinalCursor4 CURSOR FOR                                                       

		SELECT DISTINCT DeptID,sequenceno                                                      
		FROM @TempTableDept ORDER BY SequenceNo,DeptID                                                      
	                                                       
	OPEN FinalCursor4 FETCH NEXT FROM FinalCursor4 INTO @DeptID1,@sequenceNo                                                      
	WHILE @@FETCH_STATUS = 0                                                       
	BEGIN                                                      
                                                       
		INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
		SELECT DISTINCT '<B><I>'+TTIV.GroupName+' '+'</I></B>' AS GroupName,'','','','','',''                                                   
		FROM @TempTableInvestigation TTI                                                      
		INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
		WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @InnerGroupID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') AND TTI.GroupName != @pTitleName AND TTI.PackageID = @InnerPackageID                                                      
		           
		INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
		SELECT DISTINCT TTI.GroupComment AS GroupName,'','','','','',''                                                      
		FROM @TempTableInvestigation TTI                              
		INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
		WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @PackageID AND TTI.Type = 'GRP' AND TTI.GroupName != @pTitleName AND TTI.PackageID = 0          
		AND TTI.GroupComment IS NOT NULL AND TTI.GroupComment !=''          
                                                       
		SELECT DISTINCT @pTitleName = TTI.GroupName                           
		FROM @TempTableInvestigation TTI                                                      
		INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                       
		WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @InnerGroupID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') AND TTI.GroupName != @pTitleName AND TTI.PackageID = @InnerPackageID                        
		                                 
		IF EXISTS ( SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
		FROM @TempTableInvestigation TTI                                                      
		INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
		WHERE TTI.DeptID = @DeptID1 AND TTI.GroupID = @InnerGroupID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') AND TTI.PackageID = @InnerPackageID )                                                     
		BEGIN                                                      
                                                       
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
			SELECT DISTINCT '<B><U><font size=3>'+DeptName+'</font></U></B>' AS DeptName,'','','','','',''                                                      
			FROM InvDeptMaster        
			WHERE DeptID = @DeptID1 AND OrgID = @OrgID                                                      
			                                                       
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                  
			SELECT TTSM.SampleAttributes,TTSM.SampleValue,'',TTSM.SampleDesc,'','',''                                                   
			FROM @TempTableSampleMapping TTSM                                                  
			WHERE TTSM.DeptID = @DeptID1                                                
			                                                        
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
			SELECT TTIV.InvestigationName,TTIV.Value,TTIV.UOMCode,TTI.Reason,TTI.ReferenceRange,TTIV.InvestigationID,TTIV.InvestigationValuesID                                                      
			FROM @TempTableInvestigation TTI                                                      
			INNER JOIN @TempTableInvestigationValues TTIV ON TTIV.InvestigationID = TTI.InvestigationID AND TTIV.GroupID=TTI.GroupID AND TTIV.PackageID=TTI.PackageID                                                      
			WHERE TTI.DeptID = @DeptID1 AND TTI.PackageID = @InnerPackageID AND TTI.GroupID = @InnerGroupID AND (TTI.Type = 'GRP' OR TTI.Type = 'PKG' OR TTI.Type = 'INS') ORDER BY TTI.SequenceNo,TTIV.InvestigationID, TTIV.SequenceNo                                 
                                                       
			INSERT INTO @TempTableComplete (Name,Result,Units,Description,ReferenceRange,InvestigationID,InvestigationValuesID)                                                      
			VALUES ('','','','','','','')                                           
                                            
		END                                                      

	FETCH NEXT FROM FinalCursor4 INTO @DeptID1,@sequenceNo                                                      
	END                                                      

	CLOSE FinalCursor4                                     
	DEALLOCATE FinalCursor4                                             
    
FETCH NEXT FROM FinalCursorINNER1 INTO @InnerGroupID                           
END                                                      
                                                      
CLOSE FinalCursorINNER1                                                      
DEALLOCATE FinalCursorINNER1                                                      

IF(@ParentLabelName = 'PARENT_1')                                                      
	GOTO PARENT_1                                                      
IF(@ParentLabelName = 'PARENT_2')                                                      
	GOTO PARENT_2                                        
IF(@ParentLabelName = 'PARENT_3')                                                      
	GOTO PARENT_3                                                      
IF(@ParentLabelName = 'PARENT_4')                                          
	GOTO PARENT_4       
IF(@ParentLabelName = 'PARENT_5')                                          
	GOTO PARENT_5   
IF(@ParentLabelName = 'PARENT_6')                                          
	GOTO PARENT_6                                                  
                                                       
RESULT: UPDATE @TempTableComplete SET Description = '', ReferenceRange = '' WHERE InvestigationID = 4768 AND Result!='' AND Units!=''                                                      
                                     
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 2013 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 2043 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 2045 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(2) InvestigationValuesID from @TempTableComplete where InvestigationID = 4872 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 4728 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 4870 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 4151 order by InvestigationValuesID desc)      
UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete where InvestigationValuesID IN (select TOP(1) InvestigationValuesID from @TempTableComplete where InvestigationID = 4874 order by InvestigationValuesID desc)      
  
IF((Select COUNT(*)  from @TempTableComplete where InvestigationID = 5085) <> 0)  
BEGIN  

	UPDATE @TempTableComplete SET Description = '', ReferenceRange ='' FROM @TempTableComplete 
	WHERE InvestigationValuesID IN (SELECT TOP(SELECT COUNT(*) - 1  FROM @TempTableComplete WHERE InvestigationID = 5085)   
	InvestigationValuesID FROM @TempTableComplete   
	WHERE InvestigationID = 5085 order by InvestigationValuesID DESC)   

END              
                                          
SELECT  RowID,Name,Result,Units,Description,ReferenceRange,InvestigationID FROM @TempTableComplete ORDER BY RowID                            
 
END         
------------------------------------------------------------------------------------------------------------------
--End of SP pGetResultValues
------------------------------------------------------------------------------------------------------------------