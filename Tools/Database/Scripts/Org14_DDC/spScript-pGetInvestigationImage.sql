
--pGetInvestigationImage 52181,14,2    
CREATE PROCEDURE [dbo].[pGetInvestigationImage]     
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
         
      SELECT  Pfiles.ImageID,Pfiles.ImageSource,Pfiles.FilePath   
      ,Pfiles.[type],Pfiles.PatientVisitID  
      ,TMP.InvestigationName  
      from PatientInvestigationFiles  Pfiles  
      INNER jOIN @Temp TMP   
      on TMP.InvestigationID = Pfiles.InvestigationID  
      and TMP.PatientVisitID = Pfiles.PatientVisitID  
      and Pfiles.OrgID=@OrgID  
      and Pfiles.PatientVisitID=@pVisitID  
      and TMP.TemplateID=@TemplateID  
    
END 