/****** Object:  StoredProcedure [dbo].[pGetColorMaster]    Script Date: 06/03/2009 12:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetColorMaster]
AS
DECLARE @ret bigint

	BEGIN      
	SET @ret = -1

		SELECT ColorID,ColorName
		FROM ColorMaster

	SET @ret = 0   
	RETURN @ret
	END	
GO


