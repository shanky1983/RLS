
/****** Object:  StoredProcedure [dbo].[pGetSearchActionsByPage]    Script Date: 02/02/2009 19:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetSearchActionsByPage]
(
@RoleID int,
@Type varchar(50)
)
AS
DECLARE @ret bigint
	BEGIN
	SET @ret = -1
	
	Select	
	SA.ActionName,
	SA.PageID,
	SA.ActionID,
	P.PageURL
	FROM SearchActions SA
	INNER JOIN Pages P
	ON P.PageID = SA.PageID
	WHERE SA.RoleID = @RoleID	AND SA.Type= @Type
	
	SET @ret = 0   
	RETURN @ret
	END	
	
GO
