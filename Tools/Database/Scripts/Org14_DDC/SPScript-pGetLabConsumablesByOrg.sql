

/****** Object:  StoredProcedure [dbo].[pGetLabConsumablesByOrg]    Script Date: 05/30/2009 12:51:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pGetLabConsumablesByOrg]
(
	@orgID int,
	@type varchar(5)
)
AS
DECLARE @ret bigint
BEGIN
	SET @ret = -1
	SET NOCOUNT ON;
			BEGIN
				SELECT 
				LC.ConsumableID,LC.ConsumableName,
				LC.ConsumableName+' -Rs:'+CONVERT(varchar,ISNULL(RM.Rate,0)) AS ConsumableNameRate
				FROM LabConsumables LC
				INNER JOIN InvRateMaster RM 
				ON RM.ID = LC.ConsumableID
				WHERE LC.OrgID=@orgID AND RM.Type=@type ORDER BY LC.ConsumableName
				SET @ret = 0   
				RETURN @ret
			END
END
GO


