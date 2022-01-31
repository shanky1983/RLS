/****** Object:  StoredProcedure [dbo].[pGetAppearanceMaster]    Script Date: 06/03/2009 12:07:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetAppearanceMaster]
	AS
	DECLARE @ret bigint
		BEGIN    
			SET @ret = -1  
			SELECT AppearanceID,AppearanceName
			FROM AppearanceMaster
			SET @ret = 0   
			RETURN @ret
		END
GO


