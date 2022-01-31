/****** Object:  StoredProcedure [dbo].[pUpdateReferingPhysician]    Script Date: 04/15/2009 17:42:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pUpdateReferingPhysician]
(
  @pReferingPhysicianID bigint,
  @pOrgID int,
  @pStatus varchar(10),
  @pPhysicianName varchar(100),
  @pQualification varchar(50),
  @pOrganizationName varchar(100)
)
AS

DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	IF(@pStatus='')
	BEGIN
	UPDATE ReferingPhysician 
	SET PhysicianName = @pPhysicianName, Qualification = @pQualification, OrganizationName = @pOrganizationName
	WHERE OrgID = @pOrgID AND ReferingPhysicianID = @pReferingPhysicianID
	END 
	
	IF(@pStatus!='')
	BEGIN
	UPDATE ReferingPhysician
	SET Status=@pStatus
	WHERE OrgID = @pOrgID AND ReferingPhysicianID = @pReferingPhysicianID
	END
	
	SET @ret = 0
    RETURN @ret
    END
GO

