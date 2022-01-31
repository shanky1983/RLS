
-- =============================================    
-- Author:  <Venkatesh.K>    
-- Create date: <3-Nov>    
-- Description: <For labSummary Report>    
-- =============================================    
CREATE PROCEDURE pGetLabSummaryreportDetails     
(    
  @pOrgID int    
      
)    
AS    
BEGIN    
     
 --Load Client    
 EXEC pGetInvClientMaster @pOrgID,''     
     
 --Load Refering Physician    
 exec pGetReferingPhysician @pOrgID,'','D'    
     
 --Load Collection Center    
 exec pGetCollectionCentre @pOrgID    
     
 --Load Hospital/Branch    
 exec pGetLabRefOrg  @pOrgID,0,''       
     
 --Load Investigations     
 exec pGetInvestigationByClientID 0,@pOrgID,'INS'    
     
 --Load Report parameters    
 exec pGetLabSummaryReportParameter @pOrgID    
     
 --Load Department master    
 exec pGetInvDeptMaster @pOrgID       
     
END 