
/****** Object:  StoredProcedure [dbo].[pGetLabRefOrg]    Script Date: 05/12/2009 16:04:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetLabRefOrg]
(@pOrgID int,
 @pClientTypeID int,
 @pStatus varchar(20)
)
AS
DECLARE @ret bigint
	BEGIN 
	SET @ret = -1
	
	IF (@pStatus='')
	BEGIN
	IF @pClientTypeID=0
	
	BEGIN
	SELECT LabRefOrgID,RefOrgName,ClientTypeID	
	FROM LabReferenceOrg where  OrgID=@pOrgID
	ORDER BY RefOrgName
	END
	
	ELSE
	
	BEGIN
	SELECT LabRefOrgID,RefOrgName	
	FROM LabReferenceOrg where ClientTypeID=@pClientTypeID and OrgID=@pOrgID
	ORDER BY RefOrgName
	END
	END
	
	IF (@pStatus!='')
	BEGIN
	IF @pClientTypeID=0
	
	BEGIN
	SELECT LabRefOrgID,RefOrgName,ClientTypeID	
	FROM LabReferenceOrg where  OrgID=@pOrgID AND Status IS NULL
	ORDER BY RefOrgName
	END
	
	ELSE
	
	BEGIN
	SELECT LabRefOrgID,RefOrgName	
	FROM LabReferenceOrg where ClientTypeID=@pClientTypeID AND OrgID=@pOrgID AND Status IS NULL
	ORDER BY RefOrgName
	END
	END
	
	SET @ret = 0   
	RETURN @ret
	END	

