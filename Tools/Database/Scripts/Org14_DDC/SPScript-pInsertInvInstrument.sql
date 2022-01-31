

/****** Object:  StoredProcedure [dbo].[pInsertInvInstrument]    Script Date: 10/13/2009 16:34:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pInsertInvInstrument]
(
  @pOrgID int,
  @pInstrumentName varchar(255),
  @pCreatedBy bigint,
  @pInstrumentID bigint output
)
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	SET @pInstrumentID = (SELECT ISNULL(MAX(InstrumentID),0)+1 FROM InvInstrumentMaster)
	
	INSERT INTO InvInstrumentMaster(InstrumentID,InstrumentName,OrgID,CreatedBy,CreatedAt)
	VALUES (@pInstrumentID,@pInstrumentName,@pOrgID,@pCreatedBy,GETDATE())
		
	SET @ret = 0
    RETURN @ret
    END

GO


