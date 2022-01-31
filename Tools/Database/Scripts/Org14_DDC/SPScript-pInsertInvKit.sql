
/****** Object:  StoredProcedure [dbo].[pInsertInvKit]    Script Date: 10/13/2009 16:34:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pInsertInvKit]
(
  @pOrgID int,
  @pKitName varchar(255),
  @pCreatedBy bigint,
  @pKitID bigint output
)
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	SET @pKitID = (SELECT ISNULL(MAX(KitID),0)+1 FROM InvKitMaster)
	
	INSERT INTO InvKitMaster(KitID,KitName,OrgID,CreatedBy,CreatedAt)
	VALUES (@pKitID,@pKitName,@pOrgID,@pCreatedBy,GETDATE())
		
	SET @ret = 0
    RETURN @ret
    END

GO


