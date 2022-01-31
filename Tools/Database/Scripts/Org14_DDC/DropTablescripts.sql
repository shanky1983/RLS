/****** Object:  Table [dbo].[ShippingAddress]    Script Date: 04/10/2009 10:14:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShippingAddress]') AND type in (N'U'))
DROP TABLE [dbo].[ShippingAddress]
GO

/****** Object:  Table [dbo].[ResultPublishing]    Script Date: 04/10/2009 10:15:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResultPublishing]') AND type in (N'U'))
DROP TABLE [dbo].[ResultPublishing]
GO

/****** Object:  Table [dbo].[PublishingMode]    Script Date: 04/10/2009 10:18:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PublishingMode]') AND type in (N'U'))
DROP TABLE [dbo].[PublishingMode]
GO

/****** Object:  Table [dbo].[BillMaster]    Script Date: 04/11/2009 10:51:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BillMaster]
GO

/****** Object:  Table [dbo].[BillLineItems]    Script Date: 04/11/2009 10:53:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillLineItems]') AND type in (N'U'))
DROP TABLE [dbo].[BillLineItems]
GO

/****** Object:  Table [dbo].[InvClientType]    Script Date: 04/25/2009 10:36:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvClientType]') AND type in (N'U'))
DROP TABLE [dbo].[InvClientType]
GO

/****** Object:  Table [dbo].[InvClientMaster]    Script Date: 04/25/2009 10:36:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvClientMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvClientMaster]
GO

/****** Object:  Table [dbo].[InvRateMaster]    Script Date: 04/25/2009 10:37:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvRateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvRateMaster]
GO

/****** Object:  Table [dbo].[ReferingPhysician]    Script Date: 04/25/2009 17:33:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferingPhysician]') AND type in (N'U'))
DROP TABLE [dbo].[ReferingPhysician]
GO

/****** Object:  Table [dbo].[LabVisitDetails]    Script Date: 04/28/2009 12:29:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabVisitDetails]') AND type in (N'U'))
DROP TABLE [dbo].[LabVisitDetails]
GO

/****** Object:  Table [dbo].[DiscountMaster]    Script Date: 05/12/2009 15:38:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountMaster]
GO

/****** Object:  Table [dbo].[LabReferenceOrg]    Script Date: 05/12/2009 15:44:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabReferenceOrg]') AND type in (N'U'))
DROP TABLE [dbo].[LabReferenceOrg]
GO

/****** Object:  Table [dbo].[LabRefOrgAddress]    Script Date: 05/13/2009 11:47:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabRefOrgAddress]') AND type in (N'U'))
DROP TABLE [dbo].[LabRefOrgAddress]
GO

/****** Object:  Table [dbo].[BillIDMaster]    Script Date: 05/28/2009 09:18:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IDMaster]
GO

/****** Object:  Table [dbo].[LabConsumables]    Script Date: 05/29/2009 19:39:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabConsumables]') AND type in (N'U'))
DROP TABLE [dbo].[LabConsumables]
GO

/****** Object:  Table [dbo].[AppearanceMaster]    Script Date: 06/03/2009 11:55:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppearanceMaster]') AND type in (N'U'))
DROP TABLE [dbo].[AppearanceMaster]
GO

/****** Object:  Table [dbo].[ColorMaster]    Script Date: 06/03/2009 11:57:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ColorMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ColorMaster]
GO

/****** Object:  Table [dbo].[PriorityMaster]    Script Date: 06/05/2009 09:58:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriorityMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PriorityMaster]
GO

/****** Object:  Table [dbo].[CollectionCentreMaster]    Script Date: 06/08/2009 14:41:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CollectionCentreMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CollectionCentreMaster]
GO

/****** Object:  Table [dbo].[InvestigationImageMaster]    Script Date: 06/08/2009 18:28:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationImageMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationImageMaster]
GO

/****** Object:  Table [dbo].[InvDeptSamples]    Script Date: 06/12/2009 16:45:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvDeptSamples]') AND type in (N'U'))
DROP TABLE [dbo].[InvDeptSamples]
GO

/****** Object:  Table [dbo].[PatientInvestigation]    Script Date: 06/12/2009 16:46:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvestigation]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvestigation]
GO


/****** Object:  Table [dbo].[PatientInvSample]    Script Date: 06/12/2009 16:43:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSample]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSample]
GO

/****** Object:  Table [dbo].[SampleTracker]    Script Date: 06/12/2009 16:44:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SampleTracker]') AND type in (N'U'))
DROP TABLE [dbo].[SampleTracker]
GO

/****** Object:  Table [dbo].[PatientInvSampleResults]    Script Date: 06/15/2009 11:25:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSampleResults]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSampleResults]
GO

/****** Object:  Table [dbo].[SampleAttributes]    Script Date: 06/15/2009 11:27:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SampleAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[SampleAttributes]
GO

/****** Object:  Table [dbo].[LabSummaryReportParameter]    Script Date: 06/18/2009 10:07:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabSummaryReportParameter]') AND type in (N'U'))
DROP TABLE [dbo].[LabSummaryReportParameter]
GO

/****** Object:  Table [dbo].[OrderedInvestigations]    Script Date: 06/22/2009 16:00:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderedInvestigations]') AND type in (N'U'))
DROP TABLE [dbo].[OrderedInvestigations]
GO

/****** Object:  Table [dbo].[InvDeptMaster]    Script Date: 04/28/2009 11:24:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvDeptMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvDeptMaster]
GO

/****** Object:  Table [dbo].[InvestigationValues]    Script Date: 07/01/2009 18:05:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationValues]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationValues]
GO

/****** Object:  Table [dbo].[InvReportMapping]    Script Date: 07/13/2009 12:18:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReportMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvReportMapping]
GO

/****** Object:  Table [dbo].[InvReportMaster]    Script Date: 07/13/2009 12:19:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReportMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvReportMaster]
GO

/****** Object:  Table [dbo].[PatientInvSampleMapping]    Script Date: 09/24/2009 10:22:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSampleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSampleMapping]
GO

/****** Object:  Table [dbo].[InvestigationMethod]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationMethod]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationMethod]
GO

/****** Object:  StoredProcedure [dbo].[pInsertInvInstrument]    Script Date: 10/13/2009 16:34:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvInstrument]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvInstrument]
GO

/****** Object:  StoredProcedure [dbo].[pGetInvInstrument]    Script Date: 10/13/2009 16:34:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvInstrument]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvInstrument]
GO

/****** Object:  StoredProcedure [dbo].[pUpdateInvInstrument]    Script Date: 10/13/2009 16:35:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvInstrument]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvInstrument]
GO

/****** Object:  StoredProcedure [dbo].[pInsertInvKit]    Script Date: 10/13/2009 16:34:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvKit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvKit]
GO
/****** Object:  StoredProcedure [dbo].[pGetInvKit]    Script Date: 10/13/2009 16:34:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvKit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvKit]
GO

/****** Object:  StoredProcedure [dbo].[pUpdateInvKit]    Script Date: 10/13/2009 16:35:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvKit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvKit]
GO

/****** Object:  StoredProcedure [dbo].[pInsertInvMethod]    Script Date: 10/13/2009 16:34:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertInvMethod]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pInsertInvMethod]
GO

/****** Object:  StoredProcedure [dbo].[pGetInvMethod]    Script Date: 10/13/2009 16:34:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetInvMethod]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetInvMethod]
GO

/****** Object:  StoredProcedure [dbo].[pUpdateInvMethod]    Script Date: 10/13/2009 16:35:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdateInvMethod]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pUpdateInvMethod]
GO

/****** Object:  Table [dbo].[InvInstrumentMaster]    Script Date: 10/13/2009 13:14:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvInstrumentMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvInstrumentMaster]
GO

/****** Object:  Table [dbo].[InvKitMaster]    Script Date: 10/13/2009 13:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvKitMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvKitMaster]
GO