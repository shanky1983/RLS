
/****** Object:  StoredProcedure [dbo].[pUpdateDispatchDetails]    Script Date: 11/10/2009 14:33:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdateDispatchDetails]
(
@pVisitID bigint,
@pOrgID int
)
AS
DECLARE @ret bigint

	BEGIN     
	SET @ret = -1
	
	UPDATE ResultPublishing SET Status='Published' WHERE OrgID=@pOrgID AND PatientVisitID = @pVisitID 
  
	SET @ret = 0   
	RETURN @ret
	END	

GO


