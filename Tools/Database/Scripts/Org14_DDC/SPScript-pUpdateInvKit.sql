
/****** Object:  StoredProcedure [dbo].[pUpdateInvKit]    Script Date: 10/13/2009 16:35:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdateInvKit]
(
  @pKitID bigint,
  @pOrgID int,
  @pStatus varchar(10),
  @pKitName varchar(255),
  @pModifiedBy bigint
 )
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	IF(@pStatus='')
	BEGIN
	UPDATE InvKitMaster 
	SET KitName = @pKitName, ModifiedBy = @pModifiedBy,ModifiedAt = GETDATE()
	WHERE OrgID = @pOrgID AND KitID = @pKitID
	END 
	
	IF(@pStatus!='')
	BEGIN
	UPDATE InvKitMaster
	SET Status=@pStatus,ModifiedBy = @pModifiedBy,ModifiedAt = GETDATE()
	WHERE OrgID = @pOrgID AND KitID = @pKitID
	END
	
	SET @ret = 0
    RETURN @ret
    END

GO


