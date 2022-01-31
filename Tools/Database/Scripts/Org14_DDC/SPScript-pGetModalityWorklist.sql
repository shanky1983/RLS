--pGetModalityWorklist 'All','09/23/2009',17  
CREATE PROCEDURE [dbo].[pGetModalityWorklist]   
(  
 @pModalityName varchar(100),  
 @pDate datetime,  
 @pOrgID int   
   
)  
AS  
BEGIN  
  
declare @returnStatus int  
SET @returnStatus=-1  
  --IF(@pModalityName='')  
  -- BEGIN  
  --  SET @pModalityName=NULL  
  -- END  
IF(@pModalityName='All')  
   
 BEGIN  
  SELECT DISTINCT  
    PT.Name as PatientName  
    ,PT.PatientID    
    ,PT.Age  
    --,PT.DOB as birthdate  
    ,PT.SEX  
    ,LBV.ReferingPhysicianName  
    ,ord.AccessionNumber  
    ,MD.ModalityName  
    ,ord.Name as ReqProcedureDescription  
    ,ord.CreatedAt as SchProcStepStartDate  
    ,ord.StudyInstanceUId  
     
  FROM modality MD  
  INNER JOIN InvDeptMaster IDM on IDM.DeptID = MD.departmentID  
  INNER JOIN InvestigationOrgMapping IORGM on IDM.DeptID = IORGM.DeptID  
  INNER JOIN OrderedInvestigations ord on ord.ID = IORGM.InvestigationID  
  INNER JOIN PatientVisit LBV on LBV.PatientVisitId = ord.VisitID AND LBV.OrgID = ord.OrgID   
  INNER JOIN Patient PT on PT.PatientID = LBV.PatientID and PT.OrgID= LBV.OrgID  
  WHERE CONVERT(varchar,ord.CreatedAt,103) =CONVERT(varchar,@pDate,103)  
  AND ord.OrgID = @pOrgID  
  AND ord.Status !='Completed'   
    
  select distinct O.AccessionNumber,p.PatientVisitID  
  from PatientInvestigation p  
   inner join OrderedInvestigations O on O.VisitID = p.PatientVisitID  
   and O.OrgID = p.OrgID  
   and O.ID = p.InvestigationID  
   inner join InvestigationOrgMapping IO on IO.InvestigationID = p.InvestigationID  
   inner join InvDeptMaster IDM on IDM.DeptID = IO.DeptID  
   inner join Modality MD on MD.DepartmentID = IDM.DeptID  
   WHERE   
   --MD.ModalityName = 'MR' or MD.ModalityName = 'CT'  
   --AND  
   CONVERT(varchar,O.CreatedAt,103) =CONVERT(varchar,@pDate,103)  
   AND O.OrgID = @pOrgID  
   AND P.WorklistDeletedStatus='Pending'   
   and P.Status='Completed'  
  set @returnStatus=0  
    
  IF(@returnStatus=0)  
   BEGIN  
    update PatientInvestigation set WorklistDeletedStatus='Sent'  
     from PatientInvestigation p  
    inner join OrderedInvestigations O on O.VisitID = p.PatientVisitID  
    and O.OrgID = p.OrgID  
    inner join InvestigationOrgMapping IO on IO.InvestigationID = p.InvestigationID  
    inner join InvDeptMaster IDM on IDM.DeptID = IO.DeptID  
    inner join Modality MD on MD.DepartmentID = IDM.DeptID  
    WHERE   
    --MD.ModalityName = 'MR' or MD.ModalityName = 'CT'  
    --AND  
    CONVERT(varchar,O.CreatedAt,103) =CONVERT(varchar,@pDate,103)  
    AND O.OrgID = @pOrgID  
    AND P.WorklistDeletedStatus='Pending'   
    and P.Status='Completed'  
     
   END  
  END  
    
  ELSE  
    begin  
      
      SELECT DISTINCT  
      PT.Name as PatientName  
      ,PT.PatientID    
      ,PT.Age  
      --,PT.DOB as birthdate  
      ,PT.SEX  
      ,LBV.ReferingPhysicianName  
      ,ord.AccessionNumber  
      ,MD.ModalityName  
      ,ord.Name as ReqProcedureDescription  
      ,ord.CreatedAt as SchProcStepStartDate  
      ,ord.StudyInstanceUId  
       
    FROM modality MD  
    INNER JOIN InvDeptMaster IDM on IDM.DeptID = MD.departmentID  
    INNER JOIN InvestigationOrgMapping IORGM on IDM.DeptID = IORGM.DeptID  
    INNER JOIN OrderedInvestigations ord on ord.ID = IORGM.InvestigationID  
    INNER JOIN PatientVisit LBV on LBV.PatientVisitId = ord.VisitID AND LBV.OrgID = ord.OrgID   
    INNER JOIN Patient PT on PT.PatientID = LBV.PatientID and PT.OrgID= LBV.OrgID  
    WHERE MD.ModalityName = @pModalityName  
    AND CONVERT(varchar,ord.CreatedAt,103) =@pDate  
    AND ord.OrgID = @pOrgID  
    AND ord.Status !='Completed'   
    
     select distinct O.AccessionNumber,p.PatientVisitID  
     from PatientInvestigation p  
      inner join OrderedInvestigations O on O.VisitID = p.PatientVisitID  
      and O.OrgID = p.OrgID  
      and O.ID = p.InvestigationID  
      inner join InvestigationOrgMapping IO on IO.InvestigationID = p.InvestigationID  
      inner join InvDeptMaster IDM on IDM.DeptID = IO.DeptID  
      inner join Modality MD on MD.DepartmentID = IDM.DeptID  
      WHERE MD.ModalityName = @pModalityName  
      AND CONVERT(varchar,O.CreatedAt,103) =@pDate  
      AND O.OrgID = @pOrgID  
      AND P.WorklistDeletedStatus='Pending'   
      and P.Status='Completed'  
     set @returnStatus=0  
       
     IF(@returnStatus=0)  
     BEGIN  
        
      update PatientInvestigation set WorklistDeletedStatus='Sent'  
       from PatientInvestigation p  
      inner join OrderedInvestigations O on O.VisitID = p.PatientVisitID  
      and O.OrgID = p.OrgID  
      inner join InvestigationOrgMapping IO on IO.InvestigationID = p.InvestigationID  
      inner join InvDeptMaster IDM on IDM.DeptID = IO.DeptID  
      inner join Modality MD on MD.DepartmentID = IDM.DeptID  
      WHERE MD.ModalityName = @pModalityName  
      AND CONVERT(varchar,O.CreatedAt,103) =@pDate  
      AND O.OrgID = @pOrgID  
      AND P.WorklistDeletedStatus='Pending'   
      and P.Status='Completed'  
        
     END  
       
   END  
END  