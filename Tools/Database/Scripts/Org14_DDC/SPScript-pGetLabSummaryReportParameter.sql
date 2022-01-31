
/****** Object:  StoredProcedure [dbo].[pGetLabSummaryReportParameter]    Script Date: 06/18/2009 10:19:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pGetLabSummaryReportParameter]
(@pOrgID int
)
	AS
	DECLARE @ret bigint
		BEGIN      
		SET @ret = -1
		SELECT ParameterValue,ParameterName 
		FROM LabSummaryReportParameter
	    WHERE OrgID=@pOrgID
	    SET @ret = 0   
		RETURN @ret
		END	

GO


