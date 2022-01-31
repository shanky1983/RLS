
/****** Object:  StoredProcedure [dbo].[pInsertReferingPhysician]    Script Date: 04/15/2009 17:42:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pInsertReferingPhysician]
(
  @pOrgID int,
  @pPhysicianName varchar(100),
  @pQualification varchar(50),
  @pOrganizationName varchar(100),
  @pRefPhyID int output
)
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	INSERT INTO ReferingPhysician(OrgID,PhysicianName,Qualification,OrganizationName)
	VALUES (@pOrgID,@pPhysicianName,@pQualification,@pOrganizationName)
	SET @pRefPhyID = SCOPE_IDENTITY()
	
	SET @ret = 0
    RETURN @ret
    END
GO

