 CREATE FUNCTION [dbo].[fnGetInvComments]   
 (  
 @pInvestigationID bigint,   
 @pPatientVisitID bigint,  
 @orgID int   
)  
RETURNS varchar(255) BEGIN  
DECLARE @Comments varchar(255)   
  
  SELECT  @Comments = case  Reason  
          
        When 'Comments' then ''  
        else Reason  
        end   
  FROM  PatientInvestigation   
  WHERE  InvestigationID = @pInvestigationID   
  AND   PatientVisitID = @pPatientVisitID   
  AND   OrgID=@orgID  
  
return @Comments   
END  