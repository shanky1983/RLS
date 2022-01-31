ALTER PROCEDURE [dbo].[pInsertProcedureSourceOrgToDestOrg]     --EXEC pInsertProcedureSourceOrgToDestOrg 12,11 
(      
@pSourceOrgID int,     
@pDestOrgID int    
)      
AS      


DECLARE @ret bigint 
DECLARE @RateID bigint  
DECLARE @DestRateID int 
DECLARE @ProcID bigint
DECLARE @TempRate Table            
(           
  RateId BIGINT           
)     
 BEGIN            
     
     SET @ret = -1    
      
    DELETE FROM ProcedureFee WHERE OrgID=@pDestOrgID     
    
    SELECT @ProcID=ProcedureID from ProcedureMaster WHERE ProcedureDesc='Treatment Procedure' AND OrgID=@pDestOrgID
    
      
    INSERT INTO @TempRate  
    SELECT RateId FROM RateMaster WHERE OrgID = @pSourceOrgID 
      
    DECLARE surPROCursor CURSOR FOR           
           
    SELECT DISTINCT RateId          
    FROM @TempRate ORDER BY RateId           
           
 OPEN surPROCursor FETCH NEXT FROM surPROCursor INTO @RateID          
           
 WHILE @@FETCH_STATUS = 0           
 BEGIN        

SET @DestRateID=(SELECT RateId FROM RateMaster 
                            WHERE orgid = @pDestOrgID 
                            and RateName = (SELECT RateName 
                                             FROM RateMaster 
                                             WHERE RateId = (@RateID)))
                                                              
                                                              
 INSERT INTO ProcedureFee  (ProcedureID,Amount,IsVariable,ProcedureDesc,RateID,OrgID,IPAmount)
 SELECT @ProcID,Amount,'Y',ProcedureDesc,@DestRateID,@pDestOrgID,IPAmount FROM ProcedureFee  WHERE RateID=@RateID 
                                                       


       
FETCH NEXT FROM surPROCursor INTO @RateID          
           
 END           
           
 CLOSE surPROCursor          
 DEALLOCATE surPROCursor       

   
      
    SET @ret = 0         
 RETURN @ret      
 END 