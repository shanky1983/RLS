/****** Object:  StoredProcedure [dbo].[pUpdateLabRefOrgDetails]    Script Date: 04/09/2009 14:06:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdateLabRefOrgDetails]
(
  @pLabRefOrgID bigint,
  @pRefOrgName varchar(100),
  @pClientTypeID int,
  @pStatus varchar(20)
)
AS
DECLARE @ret bigint
	BEGIN 
	SET @ret = -1
	
	IF(@pStatus='')
	BEGIN
	UPDATE LabReferenceOrg 
	SET
	RefOrgName = @pRefOrgName,
	ClientTypeID = @pClientTypeID 	
	WHERE LabRefOrgID = @pLabRefOrgID
	END
	
	IF(@pStatus!='')
	BEGIN
	UPDATE LabReferenceOrg 
	SET
	Status = @pStatus
	WHERE LabRefOrgID = @pLabRefOrgID
	END
	
	SET @ret = 0   
	RETURN @ret
	END

GO
 
 