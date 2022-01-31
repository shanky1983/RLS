
/****** Object:  StoredProcedure [dbo].[pInsertLabRefOrgAddress]    Script Date: 02/02/2009 19:03:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pInsertLabRefOrgAddress]
(
  @pLabRefOrgID bigint,
  @pAddr1 varchar(60),
  @pAddr2 varchar(60),
  @pAddr3 varchar(60),
  @pCity varchar(25),
  @pCountryID smallint,
  @pCreatedBy bigint,
  @pLandLineNumber varchar(20),
  @pMobileNumber varchar(20),
  @pPostalCode varchar(10),
  @pStateID smallint
 )
AS
  DECLARE @pCreatedAt datetime
  DECLARE @pStartDTTM datetime
  DECLARE @pEndDTTM datetime
  DECLARE @ret bigint
  
	BEGIN
	SET @pCreatedAt=GETDATE()
	SET @pStartDTTM =GETDATE()
	SET @pEndDTTM =GETDATE()
	SET @ret = -1
  
	INSERT INTO LabRefOrgAddress(LabRefOrgID,Add1,Add2,Add3,City,CountryID,StateID,LandLineNumber,MobileNumber,PostalCode,StartDTTM,EndDTTM,CreatedBy,CreatedAt) 
	VALUES (@pLabRefOrgID,@pAddr1,@pAddr2,@pAddr3,@pCity,@pCountryID,@pStateID,@pLandLineNumber,@pMobileNumber,@pPostalCode,@pStartDTTM,@pEndDTTM,@pCreatedBy,@pCreatedAt)
 
	SET @ret = 0   
	RETURN @ret
	END	

GO