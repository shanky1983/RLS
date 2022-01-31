

/****** Object:  StoredProcedure [dbo].[pGetLabDetailandAddress]    Script Date: 04/22/2009 11:48:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetLabDetailandAddress]
	(
		@pLabRefOrgID bigint		
	)
AS
DECLARE @ret bigint
 BEGIN
  SET @ret = -1
  
  SELECT
  LabRefOrgID,
  RefOrgName,
  ClientTypeID
  FROM LabReferenceOrg
  WHERE LabRefOrgID=@pLabRefOrgID
  
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
