
/****** Object:  StoredProcedure [dbo].[pGetLabPublishingMode]    Script Date: 04/10/2009 11:51:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetLabPublishingMode]
AS
DECLARE @ret bigint
	BEGIN      
	SET @ret = -1
	
    SELECT ModeID,ModeName FROM PublishingMode 
    
    SET @ret = 0   
	RETURN @ret
	END	

GO
