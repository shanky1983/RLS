
/****** Object:  StoredProcedure [dbo].[pGetInvSampleMaster]    Script Date: 06/02/2009 15:33:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetInvSampleMaster]
AS
DECLARE @ret bigint
	BEGIN    
	SET @ret = -1  
    SELECT SampleCode,SampleDesc
    FROM InvSampleMaster
    SET @ret = 0   
	RETURN @ret
	END	
GO