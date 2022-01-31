/****** Object:  StoredProcedure [dbo].[pUpdateInvMethod]    Script Date: 10/13/2009 16:35:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pUpdateInvMethod]
(
  @pMethodID bigint,
  @pOrgID int,
  @pStatus varchar(10),
  @pMethodName varchar(255),
  @pModifiedBy bigint
 )
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	IF(@pStatus='')
	BEGIN
	UPDATE InvestigationMethod 
	SET MethodName = @pMethodName,ModifiedBy = @pModifiedBy,ModifiedAt = GETDATE()
	WHERE OrgID = @pOrgID AND MethodID = @pMethodID
	END 
	
	IF(@pStatus!='')
	BEGIN
	UPDATE InvestigationMethod
	SET Status=@pStatus,ModifiedBy = @pModifiedBy,ModifiedAt = GETDATE()
	WHERE OrgID = @pOrgID AND MethodID = @pMethodID
	END
	
	SET @ret = 0
    RETURN @ret
    END

GO


