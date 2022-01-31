
/****** Object:  StoredProcedure [dbo].[pGetReferingPhysician]    Script Date: 04/10/2009 11:51:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pGetReferingPhysician]
(
@pOrgID int,
@pPhysicianName varchar(100),
@pStatus varchar(20)
)
AS
DECLARE @ret bigint
	BEGIN      
    SET @ret = -1
    
    IF(@pStatus='')
    BEGIN
    IF(@pPhysicianName='')
    BEGIN
    SELECT 
    ReferingPhysicianID,(PhysicianName+' / '+IsNULL(Qualification,'')) AS PhysicianName 
    FROM ReferingPhysician 
    WHERE Status IS NULL AND OrgID=@pOrgID 
    ORDER BY PhysicianName
	END
	
	IF(@pPhysicianName!='')
	BEGIN
	SELECT 
	ReferingPhysicianID,PhysicianName,Qualification,OrganizationName 
	FROM ReferingPhysician
	WHERE Status IS NULL AND OrgID = @pOrgID AND PhysicianName LIKE '%' + @pPhysicianName + '%'
	ORDER BY PhysicianName
	END
	END
	
	IF(@pStatus!='')
    BEGIN
    IF(@pPhysicianName='')
    BEGIN
    SELECT 
    ReferingPhysicianID,(PhysicianName+' / '+IsNULL(Qualification,'')) AS PhysicianName 
    FROM ReferingPhysician 
    WHERE OrgID=@pOrgID 
    ORDER BY PhysicianName
	END
	
	IF(@pPhysicianName!='')
	BEGIN
	SELECT 
	ReferingPhysicianID,PhysicianName,Qualification,OrganizationName 
	FROM ReferingPhysician
	WHERE OrgID = @pOrgID AND PhysicianName LIKE '%' + @pPhysicianName + '%'
	ORDER BY PhysicianName
	END
	END
	
	SET @ret = 0   
	RETURN @ret
	END	

GO
