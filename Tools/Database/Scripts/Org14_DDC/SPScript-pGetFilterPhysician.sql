
/****** Object:  StoredProcedure [dbo].[pGetFilterPhysician]    Script Date: 07/10/2009 17:07:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pGetFilterPhysician]
(
	@FilterText varchar(50),
	@pOrgID int
	
)
AS
DECLARE @ret bigint
	BEGIN      
    SET @ret = -1
    
    --SELECT ReferingPhysicianID,PhysicianName,Qualification,OrganizationName FROM ReferingPhysician where OrgID=@pOrgID
    SELECT ReferingPhysicianID,(PhysicianName+' / '+IsNULL(Qualification,'')) as PhysicianName 
    FROM ReferingPhysician where OrgID=@pOrgID 
    AND PhysicianName like @FilterText+'%' AND  Status IS NULL  ORDER BY PhysicianName
	
	SET @ret = 0   
	RETURN @ret
	END	

