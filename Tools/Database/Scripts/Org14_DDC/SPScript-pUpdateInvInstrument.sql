
/****** Object:  StoredProcedure [dbo].[pUpdateInvInstrument]    Script Date: 10/13/2009 16:35:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdateInvInstrument]
(
  @pInstrumentID bigint,
  @pOrgID int,
  @pStatus varchar(10),
  @pInstrumentName varchar(255),
  @pModifiedBy bigint
 )
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	IF(@pStatus='')
	BEGIN
	UPDATE InvInstrumentMaster 
	SET InstrumentName = @pInstrumentName, ModifiedBy = @pModifiedBy,ModifiedAt = GETDATE()
	WHERE OrgID = @pOrgID AND InstrumentID = @pInstrumentID
	END 
	
	IF(@pStatus!='')
	BEGIN
	UPDATE InvInstrumentMaster
	SET Status=@pStatus,ModifiedBy = @pModifiedBy,ModifiedAt = GETDATE()
	WHERE OrgID = @pOrgID AND InstrumentID = @pInstrumentID
	END
	
	SET @ret = 0
    RETURN @ret
    END

GO


