
/****** Object:  StoredProcedure [dbo].[pInsertSamplePublishingDetails]    Script Date: 04/10/2009 16:42:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pInsertSamplePublishingDetails]
(
  @pOrgID int,
  @pVisitID bigint,
  @pModeID int,
  @pValue varchar(30),
  @pAddr1 varchar(60),
  @pAddr2 varchar(60),
  @pAddr3 varchar(60),
  @pPostalCode varchar(10),
  @pCountryID smallint,
  @pCity varchar(25),
  @pStateID smallint,
  @pMobileNumber varchar(20),
  @pLandLineNumber varchar(20),
  @pCreatedBy bigint
)
AS
DECLARE @pCreatedAt datetime
DECLARE @pShippingAddressID bigint 
DECLARE @ret bigint

	BEGIN 
	SET @pCreatedAt=GETDATE()
	SET @pShippingAddressID = NULL
	SET @ret = -1
	
	if (@pModeID!=0)
	
	BEGIN
    INSERT INTO ShippingAddress(Add1,Add2,Add3,City,StateID,CountryID,PostalCode,LandLineNumber,MobileNumber,CreatedBy,CreatedAt)
    VALUES(@pAddr1,@pAddr2,@pAddr3,@pCity,@pStateID,@pCountryID,@pPostalCode,@pLandLineNumber,@pMobileNumber,@pCreatedBy,@pCreatedAt)
    SET @pShippingAddressID = SCOPE_IDENTITY()
	END
	
    INSERT INTO ResultPublishing(OrgID,PatientVisitID,ModeID,ShippingAddressID,Value,Status,CreatedBy,CreatedAt)
    VALUES(@pOrgID,@pVisitID,@pModeID,@pShippingAddressID,@pValue,'Not Published',@pCreatedBy,@pCreatedAt)
   
	SET @ret = 0   
	RETURN @ret
	END

GO

