/****** Object:  StoredProcedure [dbo].[pGetCollectionCentre]    Script Date: 06/08/2009 15:09:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetCollectionCentre]
(@pOrgID int)
	AS
	DECLARE @ret bigint
	BEGIN  
	SET @ret = -1    
		SELECT 
		CollectionCentreID,CollectionCentreName
		FROM CollectionCentreMaster 
		WHERE OrgID=@pOrgID ORDER BY CollectionCentreName
	SET @ret = 0   
	RETURN @ret	
	END	
GO


