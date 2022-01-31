SET
ANSI_NULLS ON 
GO
SET
QUOTED_IDENTIFIER ON 
GO
CREATE FUNCTION [dbo].[fnGetGroupName] 
(
	@pInvestigationID bigint, 
	@pPatientVisitID bigint 
)
RETURNS
varchar(255) 
BEGIN
DECLARE @GroupName varchar(255) 
SELECT @GroupName = GroupName FROM PatientInvestigation WHERE InvestigationID = @pInvestigationID AND PatientVisitID = @pPatientVisitID 
return @GroupName 
END