
-- =============================================  
-- Author:  Venaktesh.K 
-- Create date: <31-Oct>  
-- Description: <Check Exsisting Group name>  
-- =============================================  
CREATE PROCEDURE pGetSimilarGroupname  
(  
 @Groupname varchar(500),  
 @orgID int  
)  
AS  
BEGIN  
  
  
 SET NOCOUNT ON;  
 SELECT GroupID,GroupName FROM InvGroupMaster   
 WHERE SOUNDEX(@Groupname) = SOUNDEX(GroupName) and OrgID=@orgID  
   
      
END  