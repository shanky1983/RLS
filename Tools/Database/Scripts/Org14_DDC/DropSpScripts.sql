

/****** Object:  StoredProcedure [dbo].[pGetLabPublishingMode]    Script Date: 04/10/2009 11:51:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabPublishingMode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabPublishingMode]
GO


/****** Object:  StoredProcedure [dbo].[pGetBillInvestigationDetails]    Script Date: 04/16/2009 16:37:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetBillInvestigationDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetBillInvestigationDetails]
GO



/****** Object:  StoredProcedure [dbo].[pGetLabPatientDetailandAddress]    Script Date: 04/22/2009 11:48:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabPatientDetailandAddress]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabPatientDetailandAddress]
GO



/****** Object:  StoredProcedure [dbo].[pGetReferingPhysician]    Script Date: 04/10/2009 11:51:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetReferingPhysician]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetReferingPhysician]
GO



/****** Object:  StoredProcedure [dbo].[pGetInvClientType]    Script Date: 04/10/2009 11:51:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvClientType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvClientType]
GO

/****** Object:  StoredProcedure [dbo].[pGetSearchActionsByPage]    Script Date: 02/02/2009 19:02:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetSearchActionsByPage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetSearchActionsByPage]
GO

/****** Object:  StoredProcedure [dbo].[pSearchBillSummary]    Script Date: 04/22/2009 16:58:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pSearchBillSummary]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pSearchBillSummary]
GO

/****** Object:  StoredProcedure [dbo].[pInsertReferingPhysician]    Script Date: 05/07/2009 11:33:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertReferingPhysician]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertReferingPhysician]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabDiscount]    Script Date: 05/12/2009 16:04:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabDiscount]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabDiscount]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabRefOrg]    Script Date: 05/12/2009 16:04:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabRefOrg]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabRefOrg]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabRefOrgAddress]    Script Date: 05/12/2009 16:04:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabRefOrgAddress]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabRefOrgAddress]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabDetailandAddress]    Script Date: 05/14/2009 10:11:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabDetailandAddress]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabDetailandAddress]
GO

/****** Object:  StoredProcedure [dbo].[pUpdateLabRefOrgDetails]    Script Date: 05/14/2009 10:11:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateLabRefOrgDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateLabRefOrgDetails]
GO


/****** Object:  StoredProcedure [dbo].[pUpdateLabRefOrgAddress]    Script Date: 05/14/2009 10:11:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateLabRefOrgAddress]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateLabRefOrgAddress]
GO


/****** Object:  StoredProcedure [dbo].[pInsertLabRefOrgDetails]    Script Date: 05/14/2009 10:11:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertLabRefOrgDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertLabRefOrgDetails]
GO


/****** Object:  StoredProcedure [dbo].[pInsertLabRefOrgAddress]    Script Date: 05/14/2009 10:11:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertLabRefOrgAddress]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertLabRefOrgAddress]
GO


/****** Object:  StoredProcedure [dbo].[pGetLabBranch]    Script Date: 05/28/2009 13:32:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabBranch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabBranch]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabHospital]    Script Date: 05/28/2009 13:33:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabHospital]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabHospital]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabConsumablesByOrg]    Script Date: 05/30/2009 12:51:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabConsumablesByOrg]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabConsumablesByOrg]
GO





/****** Object:  StoredProcedure [dbo].[pGetInvSampleMaster]    Script Date: 06/02/2009 15:33:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvSampleMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvSampleMaster]
GO

/****** Object:  StoredProcedure [dbo].[pGetAppearanceMaster]    Script Date: 06/03/2009 12:07:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetAppearanceMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetAppearanceMaster]
GO

/****** Object:  StoredProcedure [dbo].[pGetColorMaster]    Script Date: 06/03/2009 12:09:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetColorMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetColorMaster]
GO

/****** Object:  StoredProcedure [dbo].[pGetPriorityMaster]    Script Date: 06/05/2009 10:06:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetPriorityMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetPriorityMaster]
GO

/****** Object:  StoredProcedure [dbo].[pGetLabVisitDetails]    Script Date: 06/05/2009 12:37:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabVisitDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabVisitDetails]
GO

/****** Object:  StoredProcedure [dbo].[pGetCollectionCentre]    Script Date: 06/08/2009 15:09:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetCollectionCentre]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetCollectionCentre]
GO

/****** Object:  StoredProcedure [dbo].[pInsertInvestigationImage]    Script Date: 06/08/2009 18:57:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvestigationImage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvestigationImage]
GO



/****** Object:  StoredProcedure [dbo].[pGetInvestigationCapture] ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvestigationCapture]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvestigationCapture]
GO



/****** Object:  StoredProcedure [dbo].[pGetLabSummaryReportParameter]    Script Date: 06/18/2009 10:19:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabSummaryReportParameter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabSummaryReportParameter]
GO


/****** Object:  StoredProcedure [dbo].[pGetPendingInvestigations]    Script Date: 07/01/2009 14:37:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetPendingInvestigations]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetPendingInvestigations]
GO

/****** Object:  StoredProcedure [dbo].[pInvestigationResults]    Script Date: 07/01/2009 18:01:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInvestigationResults]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInvestigationResults]
GO




/****** Object:  StoredProcedure [dbo].[pUpdatePatientInvestigationComplete]    Script Date: 07/11/2009 11:17:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdatePatientInvestigationComplete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdatePatientInvestigationComplete]
GO

/****** Object:  StoredProcedure [dbo].[pGetFilterPhysician]    Script Date: 07/13/2009 11:48:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetFilterPhysician]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetFilterPhysician]
GO





/****** Object:  StoredProcedure [dbo].[pInsertOrderedInvestigation]    Script Date: 07/13/2009 12:05:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertOrderedInvestigation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertOrderedInvestigation]
GO



/****** Object:  StoredProcedure [dbo].[pUpdatePatientInvStatus]    Script Date: 07/13/2009 12:12:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdatePatientInvStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdatePatientInvStatus]
GO

/****** Object:  StoredProcedure [dbo].[pUpdatePriority]    Script Date: 07/13/2009 16:46:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdatePriority]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdatePriority]
GO





/****** Object:  StoredProcedure [dbo].[pGetInvestigationForVisit]    Script Date: 08/04/2009 13:55:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvestigationForVisit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvestigationForVisit]
GO


/****** Object:  StoredProcedure [dbo].[pUpdateLabVisitDetails]    Script Date: 09/24/2009 10:27:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateLabVisitDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateLabVisitDetails]
GO

/****** Object:  StoredProcedure [dbo].[pGetInvBulkData]    Script Date: 09/24/2009 10:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvBulkData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvBulkData]
GO

/****** Object:  StoredProcedure [dbo].[pGetInvestigationDrugs]    Script Date: 09/24/2009 10:28:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvestigationDrugs]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvestigationDrugs]
GO



/****** Object:  StoredProcedure [dbo].[pGetTextResultValues]    Script Date: 10/01/2009 15:01:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetTextResultValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetTextResultValues]
GO




/****** Object:  StoredProcedure [dbo].[pGetResultValues]    Script Date: 10/01/2009 18:54:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetResultValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetResultValues]
GO



/****** Object:  StoredProcedure [dbo].[pGetMethodKitForResultValues]    Script Date: 10/22/2009 10:12:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetMethodKitForResultValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetMethodKitForResultValues]
GO

/****** Object:  StoredProcedure [dbo].[pGetDeptToTrackSamples]    Script Date: 11/09/2009 14:03:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetDeptToTrackSamples]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetDeptToTrackSamples]
GO

/****** Object:  StoredProcedure [dbo].[pGetDispatchDetails]    Script Date: 11/10/2009 13:48:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetDispatchDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetDispatchDetails]
GO

/****** Object:  StoredProcedure [dbo].[pUpdateDispatchDetails]    Script Date: 11/10/2009 14:33:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateDispatchDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateDispatchDetails]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInsertInvGroups]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInsertInvGroups]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateReferenceRange]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateReferenceRange]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertPhysician]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertPhysician]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvestigationStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvestigationStatus]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertOrderedInvestigationHos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertOrderedInvestigationHos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateOrderedInvStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateOrderedInvStatus]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvDeptMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvDeptMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvestigationImage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvestigationImage]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetLabSummaryreportDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetLabSummaryreportDetails]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetModalityWorklist]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetModalityWorklist]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetSimilarGroupname]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetSimilarGroupname]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvInstrument]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvInstrument]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvKit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvKit]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvMethod]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvMethod]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvInstrument]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvInstrument]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvKit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvKit]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvMethod]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvMethod]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateReferingPhysician]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateReferingPhysician]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertSamplePublishingDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertSamplePublishingDetails]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetDayWiseCollection]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetDayWiseCollection]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PGetInvestigationDatas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PGetInvestigationDatas]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetPublishingMode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetPublishingMode]
GO

