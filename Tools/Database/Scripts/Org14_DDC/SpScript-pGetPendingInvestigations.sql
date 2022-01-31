
/****** Object:  StoredProcedure [dbo].[pGetPendingInvestigations]    Script Date: 07/01/2009 14:37:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[pGetPendingInvestigations]
(
	@PatientVisitID bigint,
	@OrgID int,
	@RoleID bigint
)

AS
DECLARE @ret as int
	
	BEGIN 
	SET @ret = -1
	
	SELECT		InvestigationID,InvestigationName FROM PatientInvestigation WHERE Status = 'Pending' OR Status = 'Completed'
	AND			PatientVisitID = @PatientVisitID
	AND			OrgID=@OrgID
	
	SET @ret = 0
    RETURN @ret

END		

GO


