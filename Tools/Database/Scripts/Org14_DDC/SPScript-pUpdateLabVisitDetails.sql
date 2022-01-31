
/****** Object:  StoredProcedure [dbo].[pUpdateLabVisitDetails]    Script Date: 09/18/2009 13:11:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

  
CREATE PROCEDURE [dbo].[pUpdateLabVisitDetails]  
(  
  @pPatientID bigint,  
  @pOrgID int,  
  @pPriorityID int,  
  @pReferingPhysicianID int,  
  @pReferingPhysicianName varchar(100),  
  @pHospitalID int,  
  @pHospitalName varchar(100),  
  @pClientID int,  
  @pClientName varchar(100),  
  @pModifiedBy bigint,  
  @pCollectionCentreID int,  
  @pCollectionCentreName varchar(100),  
  @pVisitID bigint 
  )  
AS  
DECLARE @pModifiedAt datetime  
DECLARE @ret bigint  
  
 BEGIN   
 SET @pModifiedAt=GETDATE()  
 SET @ret = -1  
      
      UPDATE PatientVisit SET HospitalID = @pHospitalID, HospitalName = @pHospitalName, 
      ModifiedBy = @pModifiedBy, ModifiedAt = @pModifiedAt
      WHERE PatientVisitId = @pVisitID AND OrgID = @pOrgID AND PatientID = @pPatientID
      
 SET @ret = 0     
 RETURN @ret  
 END  
  
GO


