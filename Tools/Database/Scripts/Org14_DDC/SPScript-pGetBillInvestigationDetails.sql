

/****** Object:  StoredProcedure [dbo].[pGetBillInvestigationDetails]    Script Date: 04/16/2009 11:21:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pGetBillInvestigationDetails]
(
@pVisitID bigint,
@pClientID int
)
	AS
	DECLARE @ret bigint
	BEGIN  
    
	SET @ret = -1  
	SELECT  PI.GroupID,GM.GroupName,dbo.GetRate(PI.GroupID,@pClientID,'GRP') as Rate,'GRP' as Type
	FROM PatientInvestigation PI
	INNER JOIN InvGroupMaster GM
	ON GM.GroupID = PI.GroupID
	WHERE PI.PatientVisitID = @pVisitID
	GROUP BY PI.GROUPID,GM.GROUPNAME 
  
	SELECT  PI.InvestigationID,PI.InvestigationName,dbo.GetRate(PI.InvestigationID,@pClientID,'INV') as Rate,'INV' as Type
	FROM PatientInvestigation PI
	WHERE PI.PatientVisitID = @pVisitID
	AND PI.GroupID = 0
  
	SET @ret = 0   
	RETURN @ret
	END	
  
