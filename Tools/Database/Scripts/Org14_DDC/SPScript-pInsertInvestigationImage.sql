
/****** Object:  StoredProcedure [dbo].[pInsertInvestigationImage]    Script Date: 06/08/2009 18:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pInsertInvestigationImage]
(
  @pVisitID bigint,
  @pInvestigationID bigint,
  @pMIMEType varchar(10),
  @pImage varbinary(MAX),
  @pCreatedBy bigint
)
AS
DECLARE @pCreatedAt datetime
DECLARE @ret bigint

	BEGIN 
	SET @ret = -1
	SET @pCreatedAt=GETDATE()
      	
	INSERT INTO InvestigationImageMaster (VisitID,InvestigationID,MIMEType,Image,CreatedBy,CreatedAt)
	VALUES (@pVisitID,@pInvestigationID,@pMIMEType,@pImage,@pCreatedBy,@pCreatedAt)
    
    SET @ret = 0   
	RETURN @ret
	END

GO


