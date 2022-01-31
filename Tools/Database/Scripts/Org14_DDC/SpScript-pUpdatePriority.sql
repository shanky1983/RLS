
/****** Object:  StoredProcedure [dbo].[pUpdatePriority]    Script Date: 07/13/2009 16:46:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdatePriority]
(
@pVisitID bigint,
@pOrgID int,
@pModifiedBy bigint,
@pPriorityID int
)
AS
 
 BEGIN     
  DECLARE @ret int
  DECLARE @pModifiedAt datetime
  SET @pModifiedAt=GETDATE()
  SET @ret = -1
    
  UPDATE PatientVisit SET PriorityID=@pPriorityID,ModifiedBy=@pModifiedBy,ModifiedAt=@pModifiedAt
  WHERE PatientVisitId=@pVisitID AND OrgID=@pOrgID
  
  SET @ret = 0   
  RETURN @ret
 END	


GO


