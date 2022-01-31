ALTER PROCEDURE [dbo].[pSetSurPKGFromSourceOrgToDestOrg1]     --EXEC pSetSurPKGFromSourceOrgToDestOrg1 12,11 
(      
@pSourceOrgID int,     
@pDestOrgID int    
)      
AS      
DECLARE @ret bigint  
DECLARE @PackageID bigint   
DECLARE @DestOrgPKGID bigint  
DECLARE @pDestOrgAddID int    
DECLARE @pRateID int 
DECLARE @pSurgeryPackageId int 
DECLARE @TempPKG Table            
(           
  PackageID BIGINT           
)     
 BEGIN            
    SET @ret = -1      
    
      
    DELETE FROM SurgeryPackageDetails WHERE PackageID IN (SELECT PackageID FROM SurgeryPackageMaster WHERE OrgID = @pDestOrgID)  
    DELETE FROM SurgeryPackageMaster WHERE OrgID = @pDestOrgID  
    DELETE FROM CommonSurgeryPackage WHERE OrgID=@pDestOrgID
    
    INSERT INTO CommonSurgeryPackage(PackageName,OrgID,DisplayText)
    SELECT PackageName,@pDestOrgID,DisplayText FROM CommonSurgeryPackage WHERE OrgID=@pSourceOrgID
      
    SELECT @pDestOrgAddID = AddressID FROM OrganizationAddress WHERE OrgID = @pDestOrgID        
      
    INSERT INTO @TempPKG  
    SELECT PackageID FROM SurgeryPackageMaster WHERE OrgID = @pSourceOrgID ORDER BY PackageID  
      
    DECLARE surPKGCursor CURSOR FOR           
           
 SELECT DISTINCT PackageID          
 FROM @TempPKG ORDER BY PackageID           
           
 OPEN surPKGCursor FETCH NEXT FROM surPKGCursor INTO @PackageID          
           
 WHILE @@FETCH_STATUS = 0           
 BEGIN        

SET @pRateID=(SELECT RateId FROM RateMaster 
                            WHERE orgid = @pDestOrgID 
                            and RateName = (SELECT RateName 
                                             FROM RateMaster 
                                             WHERE RateId = (SELECT RateId FROM 
                                                              SurgeryPackageMaster 
                                                              WHERE PackageID=@PackageID  AND OrgID= @pSourceOrgID)))
                                                              
                                                              
                                                         
       
INSERT INTO SurgeryPackageMaster (PackageCode,PackageName,Amount,OrgID,OrgAddID,PackageDays,NoFreeConsBefore,NoFreeConsAfter,FreeConsValidity,ActiveYN,CreatedBy,CreatedAt,RateID,SurgeryPackageID,ServiceCode)  
SELECT SPM.PackageCode,SPM.PackageName,SPM.Amount,@pDestOrgID,@pDestOrgAddID,SPM.PackageDays,SPM.NoFreeConsBefore,SPM.NoFreeConsAfter,SPM.FreeConsValidity,SPM.ActiveYN,0,GETDATE(),@pRateID,SPM.SurgeryPackageID  ,ServiceCode
FROM SurgeryPackageMaster SPM WHERE SPM.PackageID = @PackageID AND SPM.OrgID = @pSourceOrgID  
  
SELECT @DestOrgPKGID = MAX(PackageID) FROM SurgeryPackageMaster WHERE OrgID = @pDestOrgID  


INSERT INTO SurgeryPackageDetails (PackageID,Feetype,FeeID,DrugGenericID,SpecialtyID,PkgQuantity,ItemName,ActiveYN,CreatedBy,CreatedAt,Amount,RateID,IsReimbursable)  
SELECT @DestOrgPKGID,SPD.Feetype,SPD.FeeID,SPD.DrugGenericID,SPD.SpecialtyID,SPD.PkgQuantity,SPD.ItemName,SPD.ActiveYN,0,GETDATE(),SPD.Amount,@pRateID,SPD.IsReimbursable  
FROM SurgeryPackageDetails SPD WHERE SPD.PackageID = @PackageID  


       
FETCH NEXT FROM surPKGCursor INTO @PackageID          
           
 END           
           
 CLOSE surPKGCursor          
 DEALLOCATE surPKGCursor       

  UPDATE SurgeryPackageMaster SET SurgeryPackageID=CSP.SurgeryPackageID
  FROM CommonSurgeryPackage CSP INNER JOIN SurgeryPackageMaster SPM
  ON SPM.PackageName=CSP.DisplayText AND CSP.OrgID=@pDestOrgID AND SPM.OrgID= @pDestOrgID
   
      
    SET @ret = 0         
 RETURN @ret      
 END 