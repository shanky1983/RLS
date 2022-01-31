  
CREATE PROCEDURE pGetInvDeptMaster  
(  
 @pOrgId Bigint  
)  
AS  
BEGIN  
 SELECT DeptID,DeptName from InvDeptMaster where OrgID=@pOrgId  
END  