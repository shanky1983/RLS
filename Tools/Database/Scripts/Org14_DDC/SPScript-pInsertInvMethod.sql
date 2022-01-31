
/****** Object:  StoredProcedure [dbo].[pInsertInvMethod]    Script Date: 10/13/2009 16:34:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pInsertInvMethod]
(
  @pOrgID int,
  @pMethodName varchar(255),
  @pCreatedBy bigint,
  @pMethodID bigint output
)
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	SET @pMethodID = (SELECT ISNULL(MAX(MethodID),0)+1 FROM InvestigationMethod)
	
	INSERT INTO InvestigationMethod(MethodID,MethodName,OrgID,CreatedBy,CreatedAt)
	VALUES (@pMethodID,@pMethodName,@pOrgID,@pCreatedBy,GETDATE())
		
	SET @ret = 0
    RETURN @ret
    END

GO


