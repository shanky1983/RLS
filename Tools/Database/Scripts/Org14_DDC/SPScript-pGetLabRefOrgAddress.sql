
/****** Object:  StoredProcedure [dbo].[pGetLabRefOrgAddress]    Script Date: 05/12/2009 16:04:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetLabRefOrgAddress]
(
 @pLabRefOrgID bigint
)
AS
DECLARE @ret bigint
	BEGIN 
	SET @ret = -1
	
	SELECT 
	AddressID,
	Add1,
	Add2,
	Add3,
	City,
	CountryID,
	StateID,
	LandLineNumber,
	MobileNumber,
	PostalCode
	FROM LabRefOrgAddress
	WHERE LabRefOrgID=@pLabRefOrgID
	
	SET @ret = 0   
	RETURN @ret
	END	
GO
