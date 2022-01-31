
/****** Object:  StoredProcedure [dbo].[pGetPriorityMaster]    Script Date: 06/05/2009 10:06:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetPriorityMaster]
AS
DECLARE @ret bigint
	BEGIN      
    SET @ret = -1
    
    SELECT PriorityID,PriorityName
    FROM PriorityMaster
	
	SET @ret = 0   
	RETURN @ret
	END	
 
GO


