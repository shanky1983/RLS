
/****** Object:  StoredProcedure [dbo].[pGetDispatchDetails]    Script Date: 11/10/2009 13:48:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[pGetDispatchDetails]
(
@pVisitID bigint,
@pOrgID int
)
AS
DECLARE @ret bigint

	BEGIN     
	SET @ret = -1
	
	SELECT 
	S.TitleName,P.Name,CONVERT(VARCHAR,P.Age)+ '' +P.AgeUnit AS AgeUnit,
	LVD.HospitalName,LVD.ReferingPhysicianName,LVD.VisitDate,LVD.CollectionCentreName,LVD.ClientName,
	PM.PriorityName
	FROM PatientVisit LVD
	INNER JOIN Patient P ON P.PatientID = LVD.PatientID AND P.OrgID = LVD.OrgID
	INNER JOIN Salutation S ON S.TitleID  = P.TITLECode
	INNER JOIN PriorityMaster PM ON PM.PriorityID = LVD.PriorityID
	WHERE LVD.OrgID = @pOrgID AND LVD.PatientVisitId = @pVisitID

	SELECT 
	PA.Add1,PA.Add2,PA.Add3,PA.City,PA.LandLineNumber,PA.MobileNumber,PA.PostalCode,PA.AddressType,
	ST.StateName,C.CountryName
	FROM PatientVisit LVD
	INNER JOIN Patient P ON P.PatientID = LVD.PatientID AND P.OrgID = LVD.OrgID
	LEFT JOIN PatientAddress PA ON PA.PatientID = P.PatientID
	LEFT JOIN State ST ON ST.StateID = PA.StateID
	LEFT JOIN Country C ON C.CountryID = PA.CountryID
	WHERE LVD.OrgID = @pOrgID AND LVD.PatientVisitId = @pVisitID

	SELECT 
	RP.ReceiverContactNo,RP.ReceiverName,RP.Value,RP.Status,PM.ModeName
	FROM PatientVisit LVD
	INNER JOIN ResultPublishing RP ON RP.PatientVisitID = LVD.PatientVisitId AND RP.OrgID = LVD.OrgID
	LEFT JOIN PublishingMode PM ON PM.ModeID = RP.ModeID
	WHERE LVD.OrgID = @pOrgID AND LVD.PatientVisitId = @pVisitID

	SELECT 
	SA.Add1,SA.Add2,SA.Add3,SA.City,SA.LandLineNumber,SA.MobileNumber,SA.PostalCode,
	ST.StateName,C.CountryName
	FROM PatientVisit LVD
	INNER JOIN ResultPublishing RP ON RP.PatientVisitID = LVD.PatientVisitId AND RP.OrgID = LVD.OrgID
	LEFT JOIN ShippingAddress SA ON SA.ShippingAddressID = RP.ShippingAddressID
	LEFT JOIN State ST ON ST.StateID = SA.StateID
	LEFT JOIN Country C ON C.CountryID = SA.CountryID
	WHERE LVD.OrgID = @pOrgID AND LVD.PatientVisitId = @pVisitID
	
	SELECT	Name AS InvestigationName
			,Type,ID as InvestigationID
			,VisitID as PatientVisitID,OrgID,Status
	FROM OrderedInvestigations
	WHERE Status = 'Paid' AND VisitID = @pVisitID	AND	OrgID=@pOrgID

	--SELECT 
	--PInv.InvestigationID,PInv.InvestigationName,PInv.GroupID,PInv.GroupName,PInv.IsCompleted,
	--PInv.Status,IDM.DeptName
	--FROM PatientInvestigation PInv
	--INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID
	--LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID
	--WHERE PInv.OrgID = @pOrgID AND PInv.PatientVisitID = @pVisitID
	
	SELECT 
	PInv.Status,IDM.DeptName
	FROM PatientInvestigation PInv
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID
	WHERE PInv.OrgID = @pOrgID AND PInv.PatientVisitID = @pVisitID AND PInv.Status!='Completed'
	GROUP BY IDM.DeptName,PInv.Status
	
	UNION ALL
	
	SELECT 
	PInv.Status,IDM.DeptName
	FROM PatientInvestigation PInv
	INNER JOIN InvestigationOrgMapping IOM ON IOM.InvestigationID = PInv.InvestigationID AND IOM.OrgID = PInv.OrgID
	LEFT JOIN InvDeptMaster IDM ON IDM.DeptID = IOM.DeptID
	WHERE PInv.OrgID = @pOrgID AND PInv.PatientVisitID = @pVisitID AND PInv.Status='Completed'
	GROUP BY IDM.DeptName,PInv.Status
	
	SELECT		DISTINCT	invsMaster.SampleDesc,isMaster.InvSampleStatusDesc,dptMaster.DeptName,sTracker.CreatedAt,
	CASE PIS.BarcodeNumber 
	WHEN '0' THEN '--'
	ELSE PIS.BarcodeNumber 
	END AS BarcodeNumber
	FROM			SampleTracker sTracker 
	INNER JOIN		PatientInvSample PIS
	ON				PIS.SampleID = sTracker.SampleID AND PIS.PatientVisitID = sTracker.PatientVisitID AND PIS.OrgID = sTracker.OrgID
	INNER JOIN		InvSampleStatusmaster isMaster 
	ON				isMaster.InvSampleStatusID = sTracker.InvSampleStatusID
	INNER JOIN		InvDeptMaster dptMaster 
	ON				dptMaster.DeptID=sTracker.DeptID
	INNER JOIN		InvSampleMaster invsMaster 
	ON				invsMaster.SampleCode = PIS.SampleCode
	WHERE			sTracker.PatientVisitID=@pVisitID
	AND				sTracker.OrgID=@pOrgID
  
	SET @ret = 0   
	RETURN @ret
	END	

GO


