/****** Object:  StoredProcedure [dbo].[pUpdateLabRefOrgAddress]    Script Date: 02/02/2009 19:03:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdateLabRefOrgAddress]
(
  @pAddressID bigint,
  @pLabRefOrgID bigint,
  @pAddr1 varchar(60),
  @pAddr2 varchar(60),
  @pAddr3 varchar(60),
  @pCity varchar(25),
  @pCountryID smallint,
  @pLandLineNumber varchar(20),
  @pMobileNumber varchar(20),
  @pModifiedBy bigint,
  @pPostalCode varchar(10),
  @pStateID smallint
)
AS
DECLARE @ret bigint 
DECLARE @pModifiedAt datetime
   
	BEGIN
    SET @pModifiedAt=GETDATE()
	SET @ret = -1
	
	UPDATE LabRefOrgAddress SET 
	LabRefOrgID = @pLabRefOrgID,
	Add1 = @pAddr1,
	Add2 = @pAddr2,
	Add3 = @pAddr3,
	PostalCode = @pPostalCode,
	CountryID = @pCountryID,
	City = @pCity,
	StateID =@pStateID,
	MobileNumber = @pMobileNumber,
	LandLineNumber=@pLandLineNumber,
	ModifiedBy = @pModifiedBy,
	ModifiedAt = @pModifiedAt
	WHERE AddressID = @pAddressID
 
	SET @ret = 0   
	RETURN @ret
	END	
	
GO