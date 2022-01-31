
/****** Object:  StoredProcedure [dbo].[pGetInvClientType]    Script Date: 04/10/2009 11:51:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetInvClientType]
AS
DECLARE @ret bigint
	 BEGIN      
	 SET @ret = -1
     SELECT ClientTypeID,ClientTypeName FROM InvClientType
     SET @ret = 0   
	 RETURN @ret
	 END	
GO

