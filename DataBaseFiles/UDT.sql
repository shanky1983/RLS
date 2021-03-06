
/****** Object:  UserDefinedTableType [dbo].[WorkListInvestigations]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'WorkListInvestigations' AND ss.name = N'dbo')
DROP TYPE [dbo].[WorkListInvestigations]
GO
/****** Object:  UserDefinedTableType [dbo].[visittemplate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'visittemplate' AND ss.name = N'dbo')
DROP TYPE [dbo].[visittemplate]
GO
/****** Object:  UserDefinedTableType [dbo].[VisitKnowledgeMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'VisitKnowledgeMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[VisitKnowledgeMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[VisitClientMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'VisitClientMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[VisitClientMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UTTStatus]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UTTStatus' AND ss.name = N'dbo')
DROP TYPE [dbo].[UTTStatus]
GO
/****** Object:  UserDefinedTableType [dbo].[UTD_TRFFilecollection]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UTD_TRFFilecollection' AND ss.name = N'dbo')
DROP TYPE [dbo].[UTD_TRFFilecollection]
GO
/****** Object:  UserDefinedTableType [dbo].[UPDTPatientPrescription]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UPDTPatientPrescription' AND ss.name = N'dbo')
DROP TYPE [dbo].[UPDTPatientPrescription]
GO
/****** Object:  UserDefinedTableType [dbo].[UpdateAndInsertDueTable]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UpdateAndInsertDueTable' AND ss.name = N'dbo')
DROP TYPE [dbo].[UpdateAndInsertDueTable]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTVitekDeviceIntegrationResult]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTVitekDeviceIntegrationResult' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTVitekDeviceIntegrationResult]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTVisitPurpose]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTVisitPurpose' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTVisitPurpose]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTVisitGenerateListUpdate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTVisitGenerateListUpdate' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTVisitGenerateListUpdate]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTRFfilemanager]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTRFfilemanager' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTRFfilemanager]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTrainingProgram]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTrainingProgram' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTrainingProgram]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTPAPayment]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTPAPayment' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTPAPayment]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTatschedulemapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTatschedulemapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTatschedulemapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTATRANDOMBATCHSCHEDULE]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTATRANDOMBATCHSCHEDULE' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTATRANDOMBATCHSCHEDULE]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTatlogisticdetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTatlogisticdetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTatlogisticdetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTasks]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTasks' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTasks]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTaskDefaultSearch]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTaskDefaultSearch' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTTaskDefaultSearch]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSurgeryPackageMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSurgeryPackageMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSurgeryPackageMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSurgeryPackageFeeTypeRateMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSurgeryPackageFeeTypeRateMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSurgeryPackageFeeTypeRateMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSurgeryPackageDeleting]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSurgeryPackageDeleting' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSurgeryPackageDeleting]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSURGERY]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSURGERY' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSURGERY]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStockReturnAmount]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTStockReturnAmount' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTStockReturnAmount]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStockReceivedBarcode]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTStockReceivedBarcode' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTStockReceivedBarcode]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStockReceivedAttributesDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTStockReceivedAttributesDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTStockReceivedAttributesDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTServiceQuotation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTServiceQuotation' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTServiceQuotation]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTServiceCode]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTServiceCode' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTServiceCode]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTScheduledMOM]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTScheduledMOM' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTScheduledMOM]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSaveFoodOrderDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSaveFoodOrderDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSaveFoodOrderDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSampleTracker]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSampleTracker' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSampleTracker]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSampleArchival]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSampleArchival' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTSampleArchival]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRoundMasterAttributes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRoundMasterAttributes' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTRoundMasterAttributes]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRoleUser]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRoleUser' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTRoleUser]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRoleMenuInfo]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRoleMenuInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTRoleMenuInfo]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRole]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRole' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTRole]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTResourceConsumption]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTResourceConsumption' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTResourceConsumption]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTReportSnapshot]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTReportSnapshot' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTReportSnapshot]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTReferralPolicy]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTReferralPolicy' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTReferralPolicy]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTReAssignedTask]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTReAssignedTask' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTReAssignedTask]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRate' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTRate]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTQCValuesdetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTQCValuesdetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTQCValuesdetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPreQuotationList]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPreQuotationList' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPreQuotationList]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPreQuotationInvestigations]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPreQuotationInvestigations' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPreQuotationInvestigations]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPharmacyDueReference]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPharmacyDueReference' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPharmacyDueReference]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPharmacyDueChart]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPharmacyDueChart' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPharmacyDueChart]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPharmacyBillingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPharmacyBillingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPharmacyBillingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPCCustomPriceMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPCCustomPriceMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPCCustomPriceMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPCClientMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPCClientMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPCClientMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientVascularDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientVascularDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientVascularDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientReflexes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientReflexes' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientReflexes]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTpatientQualification]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTpatientQualification' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTpatientQualification]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientOpenWound]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientOpenWound' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientOpenWound]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientoneInvSampleTransfer]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientoneInvSampleTransfer' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientoneInvSampleTransfer]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientNeurologicalDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientNeurologicalDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientNeurologicalDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientMuscleWasting]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientMuscleWasting' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientMuscleWasting]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientMuscleDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientMuscleDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientMuscleDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientHistoStatusDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientHistoStatusDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientHistoStatusDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDueDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDueDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientDueDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDueChartForIP]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDueChartForIP' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientDueChartForIP]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDueChart]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDueChart' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientDueChart]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDiscount]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDiscount' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientDiscount]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDischargedWith]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDischargedWith' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientDischargedWith]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDepositHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDepositHistory' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientDepositHistory]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientComplaintIP]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientComplaintIP' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientComplaintIP]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientComplaint]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientComplaint' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientComplaint]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientBodyPartDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientBodyPartDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPatientBodyPartDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPasswordPolicy]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPasswordPolicy' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTPasswordPolicy]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOutSourcingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOutSourcingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTOutSourcingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrthoPatientDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrthoPatientDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTOrthoPatientDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrganization]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganization' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTOrganization]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTnutritionFoodDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTnutritionFoodDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTnutritionFoodDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTNotificationStatusBulkUpdate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTNotificationStatusBulkUpdate' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTNotificationStatusBulkUpdate]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTMRDDischargeAnalysis]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTMRDDischargeAnalysis' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTMRDDischargeAnalysis]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTMetaData]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTMetaData' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTMetaData]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTKitStudyDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTKitStudyDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTKitStudyDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIPTreatmentPlanMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTIPTreatmentPlanMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTIPTreatmentPlanMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvValueRangeMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvValueRangeMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvValueRangeMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTinvSampleResults]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTinvSampleResults' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTinvSampleResults]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvReportTemplateMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvReportTemplateMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvReportTemplateMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvReportMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvReportMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvReportMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvReasonMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvReasonMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvReasonMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvRateMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvRateMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvRateMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvQualitativeResultMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvQualitativeResultMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvQualitativeResultMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvPackageMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvPackageMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvPackageMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvPackageDeleting]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvPackageDeleting' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvPackageDeleting]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvOrgNotifications]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvOrgNotifications' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvOrgNotifications]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceSnapshot]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceSnapshot' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvoiceSnapshot]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceReceipts]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceReceipts' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvoiceReceipts]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvoiceMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceid]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceid' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvoiceid]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoice]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoice' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvoice]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationQueue]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationQueue' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvestigationQueue]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvestigationMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationLocationMappingList]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationLocationMappingList' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvestigationLocationMappingList]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationLocationMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationLocationMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvestigationLocationMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationdetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationdetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvestigationdetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationConsumptionDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationConsumptionDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvestigationConsumptionDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInventoryLocations]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInventoryLocations' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInventoryLocations]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvBulkRate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvBulkRate' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvBulkRate]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvBulkDataValue]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvBulkDataValue' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvBulkDataValue]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInterpretationNotes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInterpretationNotes' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInterpretationNotes]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInternalExternalQuality]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInternalExternalQuality' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInternalExternalQuality]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIntegrationDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTIntegrationDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTIntegrationDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIdsforReport]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTIdsforReport' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTIdsforReport]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTICDCode]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTICDCode' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTICDCode]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHolidayMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHolidayMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHolidayMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessages]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessages' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHLMessages]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessagePatientIDDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessagePatientIDDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHLMessagePatientIDDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageORCDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageORCDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHLMessageORCDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageOBRDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageOBRDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHLMessageOBRDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageHeaderDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageHeaderDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHLMessageHeaderDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageErrorDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageErrorDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHLMessageErrorDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHl7OutBoundMessageDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHl7OutBoundMessageDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHl7OutBoundMessageDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHl7InBoundMessageDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHl7InBoundMessageDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHl7InBoundMessageDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHealthCoupons]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHealthCoupons' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTHealthCoupons]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTFoodOrderID]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTFoodOrderID' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTFoodOrderID]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTExternalQualityAssuranceMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTExternalQualityAssuranceMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTExternalQualityAssuranceMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEpisodeVisitDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEpisodeVisitDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTEpisodeVisitDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEpisodeFileManager]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEpisodeFileManager' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTEpisodeFileManager]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEpisode]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEpisode' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTEpisode]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEMR]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEMR' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTEMR]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEmployeeRegMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEmployeeRegMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTEmployeeRegMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDynamicColumnMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDynamicColumnMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDynamicColumnMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDisPatchMode]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDisPatchMode' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDisPatchMode]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDisPatchDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDisPatchDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDisPatchDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDischargeSummary]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDischargeSummary' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDischargeSummary]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDeviceStockUsage]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDeviceStockUsage' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDeviceStockUsage]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDeviceImportData]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDeviceImportData' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDeviceImportData]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDepartment]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDepartment' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDepartment]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCustomAttributesMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCustomAttributesMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCustomAttributesMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCurrencyOrgMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCurrencyOrgMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCurrencyOrgMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCouponValueMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCouponValueMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCouponValueMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCouponMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCouponMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCouponMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCouponDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCouponDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCouponDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTConfig]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTConfig' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTConfig]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCommunicationDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCommunicationDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCommunicationDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCodingSchemeOrgMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCodingSchemeOrgMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCodingSchemeOrgMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCodingSchemeMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCodingSchemeMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCodingSchemeMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTcodeschemelblmaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTcodeschemelblmaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTcodeschemelblmaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientTaxMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientTaxMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientTaxMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientServiceExclusivity]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientServiceExclusivity' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientServiceExclusivity]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientRefundHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientRefundHistory' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientRefundHistory]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientRefundDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientRefundDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientRefundDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientDiscountPolicyMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientDiscountPolicyMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientDiscountPolicyMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientDespatchmode]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientDespatchmode' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientDespatchmode]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientDepositHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientDepositHistory' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientDepositHistory]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientCreditDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientCreditDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientCreditDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientCommunication]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientCommunication' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientCommunication]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientBasicDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientBasicDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientBasicDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientAttributes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientAttributes' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientAttributes]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientAttributeFieldDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientAttributeFieldDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTClientAttributeFieldDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCategoriesAndPatterns]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCategoriesAndPatterns' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCategoriesAndPatterns]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCashClosureDenomination]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCashClosureDenomination' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCashClosureDenomination]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCapturePatientHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCapturePatientHistory' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTCapturePatientHistory]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBulkReferenceRange]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulkReferenceRange' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBulkReferenceRange]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBulkDeviceMap]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulkDeviceMap' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBulkDeviceMap]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBulckRateUpdates]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulckRateUpdates' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBulckRateUpdates]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodSeparation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodSeparation' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBloodSeparation]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodRequest]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodRequest' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBloodRequest]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodCollect]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodCollect' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBloodCollect]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodCapture]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodCapture' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBloodCapture]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBillsearchdetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBillsearchdetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBillsearchdetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBillOfMaterials]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBillOfMaterials' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBillOfMaterials]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBillOfMaterialDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBillOfMaterialDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBillOfMaterialDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBarcodePrintJob]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBarcodePrintJob' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBarcodePrintJob]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBarcodeCategoriesAndPatterns]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBarcodeCategoriesAndPatterns' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBarcodeCategoriesAndPatterns]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBanks]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBanks' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBanks]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTaxBillDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTaxBillDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTaxBillDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAmtRefundDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAmtRefundDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAmtRefundDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAmtRecDetailsUpdate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAmtRecDetailsUpdate' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAmtRecDetailsUpdate]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAmountReceivedDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAmountReceivedDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAmountReceivedDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAdvancePaidDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAdvancePaidDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAdvancePaidDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAddressDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAddressDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAddressDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAdditionalTubeMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAdditionalTubeMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAdditionalTubeMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAdditionalConsumption]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAdditionalConsumption' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTAdditionalConsumption]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_WidgetLoginDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_WidgetLoginDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_WidgetLoginDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_TRFfilemanager_QMS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_TRFfilemanager_QMS' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_TRFfilemanager_QMS]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_05_PACKAGE_TESTS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_05_PACKAGE_TESTS' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Stage2_MHL_T_05_PACKAGE_TESTS]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_04_GROUP_TESTS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_04_GROUP_TESTS' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Stage2_MHL_T_04_GROUP_TESTS]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_03_Package_Master]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_03_Package_Master' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Stage2_MHL_T_03_Package_Master]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_02_GROUP_MASTER]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_02_GROUP_MASTER' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Stage2_MHL_T_02_GROUP_MASTER]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_01_TESTMASTER]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_01_TESTMASTER' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Stage2_MHL_T_01_TESTMASTER]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_SampleSchedule]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_SampleSchedule' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_SampleSchedule]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ProductUOM]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ProductUOM' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ProductUOM]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ProductSupplierDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ProductSupplierDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ProductSupplierDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_PlanAndSchedule_QMS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_PlanAndSchedule_QMS' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_PlanAndSchedule_QMS]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_PatientHistoryExt]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_PatientHistoryExt' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_PatientHistoryExt]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_LedgerInvoiceDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_LedgerInvoiceDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_LedgerInvoiceDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_InputDept]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_InputDept' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_InputDept]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Finalbillid]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Finalbillid' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Finalbillid]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_DocPayout]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_DocPayout' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_DocPayout]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_DeviceErrorFlag]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_DeviceErrorFlag' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_DeviceErrorFlag]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Context]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Context' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Context]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClinicalHistoryMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClinicalHistoryMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClinicalHistoryMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClinicalHistoryMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClinicalHistoryMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClinicalHistoryMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientReceiptDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientReceiptDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClientReceiptDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientReceipt]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientReceipt' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClientReceipt]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientDebit]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientDebit' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClientDebit]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientCreditDebit]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientCreditDebit' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClientCreditDebit]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientCredit]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientCredit' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_ClientCredit]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Batchtimings]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Batchtimings' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_Batchtimings]
GO
/****** Object:  UserDefinedTableType [dbo].[UDPatientAllergies]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDPatientAllergies' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDPatientAllergies]
GO
/****** Object:  UserDefinedTableType [dbo].[UDDPatientoneInvSampleTransfer]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientoneInvSampleTransfer' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDPatientoneInvSampleTransfer]
GO
/****** Object:  UserDefinedTableType [dbo].[UDDPatientInvSampleTransfer]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientInvSampleTransfer' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDPatientInvSampleTransfer]
GO
/****** Object:  UserDefinedTableType [dbo].[UDDPatientInvSample]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientInvSample' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDPatientInvSample]
GO
/****** Object:  UserDefinedTableType [dbo].[UDDInvDeptSamples]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDInvDeptSamples' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDInvDeptSamples]
GO
/****** Object:  UserDefinedTableType [dbo].[UDDinsertSampleTrack]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDinsertSampleTrack' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDinsertSampleTrack]
GO
/****** Object:  UserDefinedTableType [dbo].[uddInsertGeneralAdvice]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'uddInsertGeneralAdvice' AND ss.name = N'dbo')
DROP TYPE [dbo].[uddInsertGeneralAdvice]
GO
/****** Object:  UserDefinedTableType [dbo].[UATTaxCategoriesMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UATTaxCategoriesMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UATTaxCategoriesMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UATProductsAttributesDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UATProductsAttributesDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UATProductsAttributesDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UATAccountsImpactDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UATAccountsImpactDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UATAccountsImpactDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[TT_UDTCampDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TT_UDTCampDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[TT_UDTCampDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[TrustedOrgActions]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TrustedOrgActions' AND ss.name = N'dbo')
DROP TYPE [dbo].[TrustedOrgActions]
GO
/****** Object:  UserDefinedTableType [dbo].[TRFfilemanager]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TRFfilemanager' AND ss.name = N'dbo')
DROP TYPE [dbo].[TRFfilemanager]
GO
/****** Object:  UserDefinedTableType [dbo].[TransBillingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TransBillingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[TransBillingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[TestMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TestMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[TestMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[TestCodes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TestCodes' AND ss.name = N'dbo')
DROP TYPE [dbo].[TestCodes]
GO
/****** Object:  UserDefinedTableType [dbo].[TaskDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TaskDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[TaskDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[TaskActionOrgMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TaskActionOrgMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[TaskActionOrgMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[SurgicalDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SurgicalDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[SurgicalDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[SurgeryBillingMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SurgeryBillingMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[SurgeryBillingMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[SurgeryBillingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SurgeryBillingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[SurgeryBillingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[StockReceivedBarcodeDetailsUDT]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'StockReceivedBarcodeDetailsUDT' AND ss.name = N'dbo')
DROP TYPE [dbo].[StockReceivedBarcodeDetailsUDT]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_05_PACKAGE_TESTS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_05_PACKAGE_TESTS' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage2_MHL_T_05_PACKAGE_TESTS]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_04_GROUP_TESTS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_04_GROUP_TESTS' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage2_MHL_T_04_GROUP_TESTS]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_03_Package_Master]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_03_Package_Master' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage2_MHL_T_03_Package_Master]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_02_GROUP_MASTER]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_02_GROUP_MASTER' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage2_MHL_T_02_GROUP_MASTER]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_01_TESTMASTER]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_01_TESTMASTER' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage2_MHL_T_01_TESTMASTER]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage_User_Template]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage_User_Template' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage_User_Template]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage_Physician]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage_Physician' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage_Physician]
GO
/****** Object:  UserDefinedTableType [dbo].[Stage_LocationMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage_LocationMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[Stage_LocationMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[SPLRateCard]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SPLRateCard' AND ss.name = N'dbo')
DROP TYPE [dbo].[SPLRateCard]
GO
/****** Object:  UserDefinedTableType [dbo].[SpecialRateMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SpecialRateMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[SpecialRateMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[SiteEpisodeVisitMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SiteEpisodeVisitMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[SiteEpisodeVisitMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[SchedulesDescription]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SchedulesDescription' AND ss.name = N'dbo')
DROP TYPE [dbo].[SchedulesDescription]
GO
/****** Object:  UserDefinedTableType [dbo].[SampleBatchTrackerDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SampleBatchTrackerDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[SampleBatchTrackerDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[SampleBatchConflictDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SampleBatchConflictDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[SampleBatchConflictDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[SalesItemsMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SalesItemsMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[SalesItemsMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[RoomFeeType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RoomFeeType' AND ss.name = N'dbo')
DROP TYPE [dbo].[RoomFeeType]
GO
/****** Object:  UserDefinedTableType [dbo].[RoomDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RoomDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[RoomDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[ReportPrintHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ReportPrintHistory' AND ss.name = N'dbo')
DROP TYPE [dbo].[ReportPrintHistory]
GO
/****** Object:  UserDefinedTableType [dbo].[Referrals]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Referrals' AND ss.name = N'dbo')
DROP TYPE [dbo].[Referrals]
GO
/****** Object:  UserDefinedTableType [dbo].[ReferingPhysicianDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ReferingPhysicianDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[ReferingPhysicianDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[RateSubTypeMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RateSubTypeMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[RateSubTypeMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[RateCardDiscount]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RateCardDiscount' AND ss.name = N'dbo')
DROP TYPE [dbo].[RateCardDiscount]
GO
/****** Object:  UserDefinedTableType [dbo].[RaiseSUPO]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RaiseSUPO' AND ss.name = N'dbo')
DROP TYPE [dbo].[RaiseSUPO]
GO
/****** Object:  UserDefinedTableType [dbo].[RaisePO]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RaisePO' AND ss.name = N'dbo')
DROP TYPE [dbo].[RaisePO]
GO
/****** Object:  UserDefinedTableType [dbo].[QuotationMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'QuotationMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[QuotationMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[ProductLocationMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ProductLocationMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[ProductLocationMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[ProductEpisodeVisitMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ProductEpisodeVisitMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[ProductEpisodeVisitMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[ProductCategories]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ProductCategories' AND ss.name = N'dbo')
DROP TYPE [dbo].[ProductCategories]
GO
/****** Object:  UserDefinedTableType [dbo].[PrintPolicy]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrintPolicy' AND ss.name = N'dbo')
DROP TYPE [dbo].[PrintPolicy]
GO
/****** Object:  UserDefinedTableType [dbo].[PrimaryConsultant]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrimaryConsultant' AND ss.name = N'dbo')
DROP TYPE [dbo].[PrimaryConsultant]
GO
/****** Object:  UserDefinedTableType [dbo].[PrescriptionType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrescriptionType' AND ss.name = N'dbo')
DROP TYPE [dbo].[PrescriptionType]
GO
/****** Object:  UserDefinedTableType [dbo].[PrescriptionDrugType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrescriptionDrugType' AND ss.name = N'dbo')
DROP TYPE [dbo].[PrescriptionDrugType]
GO
/****** Object:  UserDefinedTableType [dbo].[POMappingLocation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'POMappingLocation' AND ss.name = N'dbo')
DROP TYPE [dbo].[POMappingLocation]
GO
/****** Object:  UserDefinedTableType [dbo].[PhysioCompliant]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PhysioCompliant' AND ss.name = N'dbo')
DROP TYPE [dbo].[PhysioCompliant]
GO
/****** Object:  UserDefinedTableType [dbo].[PhysicianOrgMappingUDT]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PhysicianOrgMappingUDT' AND ss.name = N'dbo')
DROP TYPE [dbo].[PhysicianOrgMappingUDT]
GO
/****** Object:  UserDefinedTableType [dbo].[PendingICD]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PendingICD' AND ss.name = N'dbo')
DROP TYPE [dbo].[PendingICD]
GO
/****** Object:  UserDefinedTableType [dbo].[PatternMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatternMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatternMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[PatInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientVitalsType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientVitalsType' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientVitalsType]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientVitals]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientVitals' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientVitals]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientReferring]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientReferring' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientReferring]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientRedemDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientRedemDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientRedemDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientRecommendationDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientRecommendationDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientRecommendationDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[patientPRO]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'patientPRO' AND ss.name = N'dbo')
DROP TYPE [dbo].[patientPRO]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientPreferences]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientPreferences' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientPreferences]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientPhysioDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientPhysioDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientPhysioDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[patientOrganDonation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'patientOrganDonation' AND ss.name = N'dbo')
DROP TYPE [dbo].[patientOrganDonation]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientOldNotesFileMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientOldNotesFileMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientOldNotesFileMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvSampleMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvSampleMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvSampleCollected]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleCollected' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvSampleCollected]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvSample]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSample' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvSample]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvFileUpload]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvFileUpload' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvFileUpload]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvestigationFiles]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigationFiles' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvestigationFiles]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientDiscount]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientDiscount' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientDiscount]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientComplication]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientComplication' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientComplication]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientComplaintHealth]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientComplaintHealth' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientComplaintHealth]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientComplaintAttribute]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientComplaintAttribute' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientComplaintAttribute]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientBillingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientBillingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientBillingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientAmbulancedetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientAmbulancedetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientAmbulancedetails]
GO
/****** Object:  UserDefinedTableType [dbo].[PatientAddress]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientAddress' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientAddress]
GO
/****** Object:  UserDefinedTableType [dbo].[OrderedPhysiotherapy]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OrderedPhysiotherapy' AND ss.name = N'dbo')
DROP TYPE [dbo].[OrderedPhysiotherapy]
GO
/****** Object:  UserDefinedTableType [dbo].[OrderedInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OrderedInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[OrderedInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[OperationStaff]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationStaff' AND ss.name = N'dbo')
DROP TYPE [dbo].[OperationStaff]
GO
/****** Object:  UserDefinedTableType [dbo].[OperationNotes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationNotes' AND ss.name = N'dbo')
DROP TYPE [dbo].[OperationNotes]
GO
/****** Object:  UserDefinedTableType [dbo].[OperationFinding]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationFinding' AND ss.name = N'dbo')
DROP TYPE [dbo].[OperationFinding]
GO
/****** Object:  UserDefinedTableType [dbo].[OperationComplication]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationComplication' AND ss.name = N'dbo')
DROP TYPE [dbo].[OperationComplication]
GO
/****** Object:  UserDefinedTableType [dbo].[NotificationAudits]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'NotificationAudits' AND ss.name = N'dbo')
DROP TYPE [dbo].[NotificationAudits]
GO
/****** Object:  UserDefinedTableType [dbo].[NonReimbursableItems]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'NonReimbursableItems' AND ss.name = N'dbo')
DROP TYPE [dbo].[NonReimbursableItems]
GO
/****** Object:  UserDefinedTableType [dbo].[NewBornDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'NewBornDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[NewBornDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[MultiplePageContextkey]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'MultiplePageContextkey' AND ss.name = N'dbo')
DROP TYPE [dbo].[MultiplePageContextkey]
GO
/****** Object:  UserDefinedTableType [dbo].[ModuleCategory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ModuleCategory' AND ss.name = N'dbo')
DROP TYPE [dbo].[ModuleCategory]
GO
/****** Object:  UserDefinedTableType [dbo].[MasterBulkdata]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'MasterBulkdata' AND ss.name = N'dbo')
DROP TYPE [dbo].[MasterBulkdata]
GO
/****** Object:  UserDefinedTableType [dbo].[ManufacturerUDT]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ManufacturerUDT' AND ss.name = N'dbo')
DROP TYPE [dbo].[ManufacturerUDT]
GO
/****** Object:  UserDefinedTableType [dbo].[LstInvestigationDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LstInvestigationDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[LstInvestigationDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[LotVendorMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LotVendorMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[LotVendorMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[LotMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LotMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[LotMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[LoginDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LoginDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[LoginDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[LabourAndDeliveryNotes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LabourAndDeliveryNotes' AND ss.name = N'dbo')
DROP TYPE [dbo].[LabourAndDeliveryNotes]
GO
/****** Object:  UserDefinedTableType [dbo].[IPTreatmentPlanDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPTreatmentPlanDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[IPTreatmentPlanDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[IPTreatmentPlan]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPTreatmentPlan' AND ss.name = N'dbo')
DROP TYPE [dbo].[IPTreatmentPlan]
GO
/****** Object:  UserDefinedTableType [dbo].[IPPatInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPPatInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[IPPatInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[IPInvSamples]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPInvSamples' AND ss.name = N'dbo')
DROP TYPE [dbo].[IPInvSamples]
GO
/****** Object:  UserDefinedTableType [dbo].[InvSummaryTrend]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvSummaryTrend' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvSummaryTrend]
GO
/****** Object:  UserDefinedTableType [dbo].[InvSummaryReport]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvSummaryReport' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvSummaryReport]
GO
/****** Object:  UserDefinedTableType [dbo].[InvReportTemplateFooter]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvReportTemplateFooter' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvReportTemplateFooter]
GO
/****** Object:  UserDefinedTableType [dbo].[InvRemarks]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvRemarks' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvRemarks]
GO
/****** Object:  UserDefinedTableType [dbo].[InvProductMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvProductMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvProductMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[InvOrgReferenceMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvOrgReferenceMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvOrgReferenceMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[InvInstrumentMaster_QMS]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvInstrumentMaster_QMS' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvInstrumentMaster_QMS]
GO
/****** Object:  UserDefinedTableType [dbo].[InvInstrumentMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvInstrumentMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvInstrumentMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[InvHistoryAttributes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvHistoryAttributes' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvHistoryAttributes]
GO
/****** Object:  UserDefinedTableType [dbo].[InvGroupMapMasterPackage]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvGroupMapMasterPackage' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvGroupMapMasterPackage]
GO
/****** Object:  UserDefinedTableType [dbo].[InvGroupMapMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvGroupMapMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvGroupMapMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[Investigations]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Investigations' AND ss.name = N'dbo')
DROP TYPE [dbo].[Investigations]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationResults]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationResults' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationResults]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationOrgMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationOrgMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationOrgMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDetailsubPKG]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDetailsubPKG' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationDetailsubPKG]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDetailsub]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDetailsub' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationDetailsub]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDeleteOrgMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDeleteOrgMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationDeleteOrgMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationAdminRate]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationAdminRate' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationAdminRate]
GO
/****** Object:  UserDefinedTableType [dbo].[InventoryItemsMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryItemsMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[InventoryItemsMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[InventoryCategorieMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryCategorieMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[InventoryCategorieMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[InventoryAttributeValues]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryAttributeValues' AND ss.name = N'dbo')
DROP TYPE [dbo].[InventoryAttributeValues]
GO
/****** Object:  UserDefinedTableType [dbo].[InvDeptMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvDeptMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvDeptMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[InvCoAuthorization]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvCoAuthorization' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvCoAuthorization]
GO
/****** Object:  UserDefinedTableType [dbo].[InvClientMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvClientMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvClientMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[IntegerTableType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IntegerTableType' AND ss.name = N'dbo')
DROP TYPE [dbo].[IntegerTableType]
GO
/****** Object:  UserDefinedTableType [dbo].[Immunization]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Immunization' AND ss.name = N'dbo')
DROP TYPE [dbo].[Immunization]
GO
/****** Object:  UserDefinedTableType [dbo].[HistoSpecimenDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HistoSpecimenDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[HistoSpecimenDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[HistoryPKGType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HistoryPKGType' AND ss.name = N'dbo')
DROP TYPE [dbo].[HistoryPKGType]
GO
/****** Object:  UserDefinedTableType [dbo].[HistoryPKGAttribute]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HistoryPKGAttribute' AND ss.name = N'dbo')
DROP TYPE [dbo].[HistoryPKGAttribute]
GO
/****** Object:  UserDefinedTableType [dbo].[HIDECType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HIDECType' AND ss.name = N'dbo')
DROP TYPE [dbo].[HIDECType]
GO
/****** Object:  UserDefinedTableType [dbo].[HCUDTServiceQuotation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCUDTServiceQuotation' AND ss.name = N'dbo')
DROP TYPE [dbo].[HCUDTServiceQuotation]
GO
/****** Object:  UserDefinedTableType [dbo].[HCOrderedInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCOrderedInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[HCOrderedInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[HCOrdereddetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCOrdereddetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[HCOrdereddetails]
GO
/****** Object:  UserDefinedTableType [dbo].[HCInvestigationResults]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCInvestigationResults' AND ss.name = N'dbo')
DROP TYPE [dbo].[HCInvestigationResults]
GO
/****** Object:  UserDefinedTableType [dbo].[GroupOrgMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GroupOrgMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[GroupOrgMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[GetUserIDs]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GetUserIDs' AND ss.name = N'dbo')
DROP TYPE [dbo].[GetUserIDs]
GO
/****** Object:  UserDefinedTableType [dbo].[GetOrgIDs]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GetOrgIDs' AND ss.name = N'dbo')
DROP TYPE [dbo].[GetOrgIDs]
GO
/****** Object:  UserDefinedTableType [dbo].[GenerateWorklist]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GenerateWorklist' AND ss.name = N'dbo')
DROP TYPE [dbo].[GenerateWorklist]
GO
/****** Object:  UserDefinedTableType [dbo].[FileUploadDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FileUploadDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[FileUploadDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[FeeSplitSeriveDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FeeSplitSeriveDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[FeeSplitSeriveDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[FeeShareGroupValueDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FeeShareGroupValueDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[FeeShareGroupValueDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[FeedBackDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FeedBackDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[FeedBackDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[Familytree]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Familytree' AND ss.name = N'dbo')
DROP TYPE [dbo].[Familytree]
GO
/****** Object:  UserDefinedTableType [dbo].[ExcelProductDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ExcelProductDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[ExcelProductDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[ExaminationPKGType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ExaminationPKGType' AND ss.name = N'dbo')
DROP TYPE [dbo].[ExaminationPKGType]
GO
/****** Object:  UserDefinedTableType [dbo].[ExaminationPKGAttribute]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ExaminationPKGAttribute' AND ss.name = N'dbo')
DROP TYPE [dbo].[ExaminationPKGAttribute]
GO
/****** Object:  UserDefinedTableType [dbo].[DrugGenericUDT]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DrugGenericUDT' AND ss.name = N'dbo')
DROP TYPE [dbo].[DrugGenericUDT]
GO
/****** Object:  UserDefinedTableType [dbo].[DiscountPolicyUDT]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DiscountPolicyUDT' AND ss.name = N'dbo')
DROP TYPE [dbo].[DiscountPolicyUDT]
GO
/****** Object:  UserDefinedTableType [dbo].[DischargeSummary]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DischargeSummary' AND ss.name = N'dbo')
DROP TYPE [dbo].[DischargeSummary]
GO
/****** Object:  UserDefinedTableType [dbo].[DischargeInvNotes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DischargeInvNotes' AND ss.name = N'dbo')
DROP TYPE [dbo].[DischargeInvNotes]
GO
/****** Object:  UserDefinedTableType [dbo].[Diet_FoodIngredientsMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Diet_FoodIngredientsMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[Diet_FoodIngredientsMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[DiagnosticsPKGType]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DiagnosticsPKGType' AND ss.name = N'dbo')
DROP TYPE [dbo].[DiagnosticsPKGType]
GO
/****** Object:  UserDefinedTableType [dbo].[DiagnosticsPKGAttribute]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DiagnosticsPKGAttribute' AND ss.name = N'dbo')
DROP TYPE [dbo].[DiagnosticsPKGAttribute]
GO
/****** Object:  UserDefinedTableType [dbo].[DeviceSampleStatus]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DeviceSampleStatus' AND ss.name = N'dbo')
DROP TYPE [dbo].[DeviceSampleStatus]
GO
/****** Object:  UserDefinedTableType [dbo].[DeviceManufacturer]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DeviceManufacturer' AND ss.name = N'dbo')
DROP TYPE [dbo].[DeviceManufacturer]
GO
/****** Object:  UserDefinedTableType [dbo].[DeptID]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DeptID' AND ss.name = N'dbo')
DROP TYPE [dbo].[DeptID]
GO
/****** Object:  UserDefinedTableType [dbo].[Customers]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Customers' AND ss.name = N'dbo')
DROP TYPE [dbo].[Customers]
GO
/****** Object:  UserDefinedTableType [dbo].[CustomerLocations]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CustomerLocations' AND ss.name = N'dbo')
DROP TYPE [dbo].[CustomerLocations]
GO
/****** Object:  UserDefinedTableType [dbo].[CreditDebitSummary]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CreditDebitSummary' AND ss.name = N'dbo')
DROP TYPE [dbo].[CreditDebitSummary]
GO
/****** Object:  UserDefinedTableType [dbo].[ControlMappingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ControlMappingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[ControlMappingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[ConfigValue]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ConfigValue' AND ss.name = N'dbo')
DROP TYPE [dbo].[ConfigValue]
GO
/****** Object:  UserDefinedTableType [dbo].[CommunicableDiseaseMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CommunicableDiseaseMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[CommunicableDiseaseMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[ClosureAmount]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ClosureAmount' AND ss.name = N'dbo')
DROP TYPE [dbo].[ClosureAmount]
GO
/****** Object:  UserDefinedTableType [dbo].[ClientDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ClientDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[ClientDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[CauseOfDeath]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CauseOfDeath' AND ss.name = N'dbo')
DROP TYPE [dbo].[CauseOfDeath]
GO
/****** Object:  UserDefinedTableType [dbo].[CashFlowDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CashFlowDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[CashFlowDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[BulkCollectSample]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BulkCollectSample' AND ss.name = N'dbo')
DROP TYPE [dbo].[BulkCollectSample]
GO
/****** Object:  UserDefinedTableType [dbo].[BirthInstructions]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BirthInstructions' AND ss.name = N'dbo')
DROP TYPE [dbo].[BirthInstructions]
GO
/****** Object:  UserDefinedTableType [dbo].[BillItemsMapping]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillItemsMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[BillItemsMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[BillingDetailTablesWFT]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillingDetailTablesWFT' AND ss.name = N'dbo')
DROP TYPE [dbo].[BillingDetailTablesWFT]
GO
/****** Object:  UserDefinedTableType [dbo].[BillingDetailTables]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillingDetailTables' AND ss.name = N'dbo')
DROP TYPE [dbo].[BillingDetailTables]
GO
/****** Object:  UserDefinedTableType [dbo].[BidirectionalBarCodes]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BidirectionalBarCodes' AND ss.name = N'dbo')
DROP TYPE [dbo].[BidirectionalBarCodes]
GO
/****** Object:  UserDefinedTableType [dbo].[BelongDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BelongDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[BelongDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[BedMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BedMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[BedMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[BatchwisePatientInvestigation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BatchwisePatientInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[BatchwisePatientInvestigation]
GO
/****** Object:  UserDefinedTableType [dbo].[BarcodeMappingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BarcodeMappingDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[BarcodeMappingDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[BannerMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BannerMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[BannerMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[BackgroundProblem]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BackgroundProblem' AND ss.name = N'dbo')
DROP TYPE [dbo].[BackgroundProblem]
GO
/****** Object:  UserDefinedTableType [dbo].[AuditTransactionDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AuditTransactionDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[AuditTransactionDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCVaccincation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCVaccincation' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCVaccincation]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientHistory' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCPatientHistory]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientFetalFindings]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientFetalFindings' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCPatientFetalFindings]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientExamination]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientExamination' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCPatientExamination]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientComplication]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientComplication' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCPatientComplication]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCGPALDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCGPALDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCGPALDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[ANCComplaints]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCComplaints' AND ss.name = N'dbo')
DROP TYPE [dbo].[ANCComplaints]
GO
/****** Object:  UserDefinedTableType [dbo].[AnalyzerMappingDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AnalyzerMappingDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[AnalyzerMappingDetail]
GO
/****** Object:  UserDefinedTableType [dbo].[AnalyteMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AnalyteMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[AnalyteMaster]
GO
/****** Object:  UserDefinedTableType [dbo].[ActionDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ActionDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[ActionDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[ActionDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
/****** Object:  UserDefinedTableType [dbo].[UDTOrganismBulkUploadDrug]    Script Date: 4/15/2021 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganismBulkUploadDrug' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTOrganismBulkUploadDrug]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrganismBulkUploadFamily]    Script Date: 4/15/2021 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganismBulkUploadFamily' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTOrganismBulkUploadFamily]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrganismBulkUploadOraganism]    Script Date: 4/15/2021 4:04:33 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganismBulkUploadOraganism' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTOrganismBulkUploadOraganism]
GO



IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ActionDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ActionDetails] AS TABLE(
	[ActionType] [nvarchar](50) NULL,
	[Value] [nvarchar](1000) NULL,
	[AdditionalContext] [nvarchar](2000) NULL,
	[Category] [nvarchar](20) NULL,
	[version] [nvarchar](10) NULL,
	[Status] [nvarchar](20) NULL,
	[OrgID] [nvarchar](10) NULL,
	[OrgAddressID] [nvarchar](20) NULL,
	[CreatedAt] [nvarchar](100) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[Template] [nvarchar](max) NULL,
	[ContextType] [nvarchar](10) NULL,
	[IsAttachment] [nvarchar](5) NULL,
	[Subject] [nvarchar](500) NULL,
	[AttachmentName] [nvarchar](500) NULL,
	[IsClientBlinding] [nvarchar](10) NULL,
	[CCTo] [nvarchar](max) NULL,
	[BccTo] [nvarchar](max) NULL,
	[ReportType] [nvarchar](50) NULL,
	[IsManualReport] [bit] NULL,
[IsReprinting] bit NULL DEFAULT (0),
	ReportLanguage NVARCHAR(100),
	NoofCopies INT
)
GO
/****** Object:  UserDefinedTableType [dbo].[AnalyteMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AnalyteMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[AnalyteMaster] AS TABLE(
	[Investigationid] [bigint] NULL,
	[DepartmentID] [bigint] NULL,
	[ContatinerID] [bigint] NULL,
	[ResultValueType] [nvarchar](100) NULL,
	[SampleID] [bigint] NULL,
	[DecimalPlaces] [nvarchar](20) NULL,
	[MethodID] [bigint] NULL,
	[PrinclipleID] [bigint] NULL,
	[Classification] [nvarchar](500) NULL,
	[IsNABL] [char](2) NULL,
	[IsActive] [char](2) NULL,
	[OrgId] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[CutOffTimeValue] [int] NULL,
	[CutOffTimeType] [nvarchar](100) NULL,
	[ID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AnalyzerMappingDetail]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AnalyzerMappingDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[AnalyzerMappingDetail] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[TestCode] [nvarchar](100) NULL,
	[DeviceID] [nvarchar](100) NULL,
	[InstrumentID] [bigint] NULL,
	[FrequencyDay] [nvarchar](100) NULL,
	[FrequencyTime] [nvarchar](100) NULL,
	[QCRequired] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCComplaints]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCComplaints' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCComplaints] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[Description] [nvarchar](200) NULL,
	[Name] [nvarchar](255) NULL,
	[Status] [nchar](1) NULL,
	[Priority] [smallint] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCGPALDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCGPALDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCGPALDetails] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[SexOfChild] [nchar](1) NULL,
	[Age] [nvarchar](3) NULL,
	[ModeOfDeliveryID] [int] NULL,
	[BirthMaturityID] [int] NULL,
	[BirthWeight] [numeric](5, 2) NULL,
	[IsGrowthNormal] [nchar](1) NULL,
	[GrowthRate] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientComplication]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientComplication' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCPatientComplication] AS TABLE(
	[ComplicationID] [bigint] NULL,
	[ComplicationName] [nvarchar](30) NULL,
	[PatientVisitID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ANCStatus] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientExamination]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientExamination' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCPatientExamination] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[ExaminationID] [int] NULL,
	[ExaminationName] [nvarchar](100) NULL,
	[ComplaintId] [int] NULL,
	[Description] [nvarchar](200) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientFetalFindings]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientFetalFindings' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCPatientFetalFindings] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[FetalNumber] [int] NULL,
	[FetalPresentationDesc] [nvarchar](100) NULL,
	[FetalPositionDesc] [nvarchar](100) NULL,
	[FetalMovementsDesc] [nvarchar](100) NULL,
	[FetalFHSDesc] [nvarchar](100) NULL,
	[FetalOthers] [nvarchar](100) NULL,
	[isNormalFinding] [nchar](1) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCPatientHistory]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCPatientHistory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCPatientHistory] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[HistoryID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Description] [nvarchar](200) NULL,
	[HistoryName] [nvarchar](100) NULL,
	[ComplaintId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ANCVaccincation]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ANCVaccincation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ANCVaccincation] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[VaccinationID] [int] NULL,
	[VaccinationName] [nvarchar](100) NULL,
	[MonthOfVaccination] [int] NULL,
	[YearOfVaccination] [int] NULL,
	[VaccinationDose] [nvarchar](50) NULL,
	[IsBooster] [nchar](1) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AuditTransactionDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AuditTransactionDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[AuditTransactionDetails] AS TABLE(
	[AttributeID] [bigint] NULL,
	[AttributeName] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BackgroundProblem]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BackgroundProblem' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BackgroundProblem] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[PreparedAt] [nvarchar](10) NULL,
	[ICDCodeStatus] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BannerMaster]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BannerMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BannerMaster] AS TABLE(
	[LoginID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[BannerID] [bigint] NULL,
	[BannerStartDate] [datetime] NULL,
	[BannerEndDate] [datetime] NULL,
	[BannerText] [nvarchar](max) NULL,
	[OrgID] [int] NULL,
	[BannerType] [nvarchar](255) NULL,
	[CategoryCode] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
	[EmpDeptID] [bigint] NULL,
	[DocFileUrl] [nvarchar](max) NULL,
	[Status] [bit] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BarcodeMappingDetails]    Script Date: 6/25/2018 4:04:33 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BarcodeMappingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BarcodeMappingDetails] AS TABLE(
	[ProductID] [bigint] NULL,
	[ProductKey] [nvarchar](510) NULL,
	[Barcode] [nvarchar](50) NULL,
	[UnitSize] [int] NULL,
	[Unit] [nvarchar](50) NULL,
	[StockReceivedDetailsId] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BatchwisePatientInvestigation]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BatchwisePatientInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BatchwisePatientInvestigation] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[PatientVisitID] [bigint] NOT NULL,
	[GUID] [nvarchar](max) NULL,
	[AccessionNumber] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BedMaster]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BedMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BedMaster] AS TABLE(
	[BedID] [int] NULL,
	[BedName] [nvarchar](50) NULL,
	[RoomID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BelongDetails]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BelongDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BelongDetails] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[BelongingDescription] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BidirectionalBarCodes]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BidirectionalBarCodes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BidirectionalBarCodes] AS TABLE(
	[PatientName] [nvarchar](255) NULL,
	[PatientAge] [nvarchar](20) NULL,
	[PatientSex] [nchar](1) NULL,
	[TestCode] [nvarchar](50) NULL,
	[Barcode] [nvarchar](255) NULL,
	[PatientVisitId] [bigint] NULL,
	[rowid] [bigint] NULL,
	[PatientInvId] [bigint] NULL,
	[OrgID] [int] NULL,
	[DeviceID] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BillingDetailTables]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillingDetailTables' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BillingDetailTables] AS TABLE(
	[ID] [bigint] NOT NULL,
	[Amount] [decimal](18, 0) NULL,
	[Description] [nvarchar](50) NULL,
	[IsGroup] [nvarchar](1) NULL,
	[Status] [nvarchar](9) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BillingDetailTablesWFT]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillingDetailTablesWFT' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BillingDetailTablesWFT] AS TABLE(
	[ID] [bigint] NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[Description] [nvarchar](50) NULL,
	[IsGroup] [nvarchar](1) NULL,
	[Status] [nvarchar](9) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[FeeType] [nvarchar](10) NULL,
	[IsReimbursable] [nchar](1) NULL,
	[IsTaxable] [nchar](1) NULL,
	[ServiceCode] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BillItemsMapping]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillItemsMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BillItemsMapping] AS TABLE(
	[ItemName] [nvarchar](255) NULL,
	[ItemID] [bigint] NULL,
	[Type] [nvarchar](20) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BirthInstructions]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BirthInstructions' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BirthInstructions] AS TABLE(
	[InstructionID] [bigint] NULL,
	[Instructions] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[BulkCollectSample]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BulkCollectSample' AND ss.name = N'dbo')
CREATE TYPE [dbo].[BulkCollectSample] AS TABLE(
	[AccessionNumber] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[UID] [nvarchar](100) NULL,
	[InvSampleStatusID] [bigint] NULL,
	[TaskID] [nvarchar](100) NULL,
	[CollectedDateTime] [nvarchar](100) NULL,
	[PatientName] [nvarchar](100) NULL,
	[SampleName] [nvarchar](100) NULL,
	[BarcodeNumber] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[CashFlowDetails]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CashFlowDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[CashFlowDetails] AS TABLE(
	[CashFlowTransactionID] [bigint] NULL,
	[CashFlowID] [bigint] NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nchar](10) NULL,
	[InvoiceNo] [nvarchar](150) NULL,
	[AmountPaid] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[CauseOfDeath]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CauseOfDeath' AND ss.name = N'dbo')
CREATE TYPE [dbo].[CauseOfDeath] AS TABLE(
	[CauseOfDeathID] [bigint] NULL,
	[CauseOfDeathTypeID] [bigint] NULL,
	[CauseOfDeathType] [nvarchar](255) NULL,
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ICDCodeStatus] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ClientDetails]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ClientDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ClientDetails] AS TABLE(
	[ClientCode] [nvarchar](200) NULL,
	[ClientName] [nvarchar](200) NULL,
	[OrgID] [int] NULL,
	[ClientType] [int] NULL,
	[CustomerType] [bigint] NULL,
	[CountryCode] [nvarchar](30) NULL,
	[StateCode] [nvarchar](30) NULL,
	[EmailID] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](30) NULL,
	[MobileNo] [nvarchar](30) NULL,
	[AddressDetails] [nvarchar](500) NULL,
	[City] [nvarchar](30) NULL,
	[ISCash] [nvarchar](30) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ClosureAmount]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ClosureAmount' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ClosureAmount] AS TABLE(
	[AmountToBeClosed] [decimal](18, 2) NULL,
	[AmountClosed] [decimal](18, 2) NULL,
	[AmountRefunded] [decimal](18, 2) NOT NULL,
	[Status] [nvarchar](10) NULL,
	[ClosedBy] [int] NULL,
	[ClosedFor] [int] NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[CommunicableDiseaseMaster]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CommunicableDiseaseMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[CommunicableDiseaseMaster] AS TABLE(
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[ICDCode] [nvarchar](20) NULL,
	[ICDName] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ConfigValue]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ConfigValue' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ConfigValue] AS TABLE(
	[ConfigID] [bigint] NULL,
	[ConfigKeyID] [bigint] NULL,
	[ConfigValue] [nvarchar](max) NULL,
	[ConfigType] [nvarchar](max) NULL,
	[OrgAddressId] [bigint] NULL,
	[ConfigKey] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ControlMappingDetails]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ControlMappingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ControlMappingDetails] AS TABLE(
	[ControlTypeID] [int] NULL,
	[ControlName] [nvarchar](50) NULL,
	[ControlCode] [nvarchar](10) NULL,
	[ControlMappingID] [bigint] NULL,
	[DisplayText] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](10) NULL,
	[SequenceNo] [int] NULL,
	[ControlValueID] [bigint] NULL,
	[ControlValue] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[ID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[CreditDebitSummary]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CreditDebitSummary' AND ss.name = N'dbo')
CREATE TYPE [dbo].[CreditDebitSummary] AS TABLE(
	[ReceiptNo] [bigint] NOT NULL,
	[ID] [int] NOT NULL,
	[Date] [datetime] NULL,
	[CrDrType] [nvarchar](20) NULL,
	[ClientId] [bigint] NOT NULL,
	[ClientType] [nvarchar](50) NULL,
	[ItemType] [nvarchar](50) NULL,
	[Authorizedby] [bigint] NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[ReferenceID] [bigint] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Reason] [bigint] NULL,
	[Remarks] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[CustomerLocations]    Script Date: 6/25/2018 4:04:34 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CustomerLocations' AND ss.name = N'dbo')
CREATE TYPE [dbo].[CustomerLocations] AS TABLE(
	[LocationID] [int] NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[LocationName] [nvarchar](250) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[Phone] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Customers]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Customers' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Customers] AS TABLE(
	[CustomerID] [int] NULL,
	[CustomerName] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[EmailID] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[PANNumber] [nvarchar](20) NULL,
	[TINNo] [nvarchar](50) NULL,
	[CSTNo] [nvarchar](50) NULL,
	[DrugLicenceNo] [nvarchar](50) NULL,
	[ServiceTaxNo] [nvarchar](50) NULL,
	[CustomerTypeID] [int] NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsDeleted] [nchar](1) NULL,
	[TermsConditions] [nvarchar](max) NULL,
	[OrgAddressID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DeptID]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DeptID' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DeptID] AS TABLE(
	[SNO] [int] NULL,
	[DeptID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DeviceManufacturer]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DeviceManufacturer' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DeviceManufacturer] AS TABLE(
	[ManufacturerName] [nvarchar](50) NULL,
	[ManufacturerCode] [nvarchar](50) NULL,
	[EmailID] [nvarchar](100) NULL,
	[MobileNo] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DeviceSampleStatus]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DeviceSampleStatus' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DeviceSampleStatus] AS TABLE(
	[ExternalVisitID] [nvarchar](255) NULL,
	[VisitID] [bigint] NULL,
	[BarCode] [bigint] NULL,
	[TestCode] [nvarchar](50) NULL,
	[DeviceID] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DiagnosticsPKGAttribute]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DiagnosticsPKGAttribute' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DiagnosticsPKGAttribute] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[DID] [bigint] NULL,
	[AttributeID] [bigint] NULL,
	[AttributevalueID] [bigint] NULL,
	[AttributeValueName] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DiagnosticsPKGType]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DiagnosticsPKGType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DiagnosticsPKGType] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[DID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[DiagnosticsName] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Diet_FoodIngredientsMapping]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Diet_FoodIngredientsMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Diet_FoodIngredientsMapping] AS TABLE(
	[FoodIngredientMappingID] [bigint] NULL,
	[FoodID] [bigint] NOT NULL,
	[FoodIngredientID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[UOM] [nvarchar](50) NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DischargeInvNotes]    Script Date: 6/25/2018 4:04:35 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DischargeInvNotes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DischargeInvNotes] AS TABLE(
	[DischargeInvNotesID] [bigint] NULL,
	[InvestigationDetails] [nvarchar](max) NULL,
	[Type] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DischargeSummary]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DischargeSummary' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DischargeSummary] AS TABLE(
	[DischargeSummaryID] [bigint] NULL,
	[PatientVistID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[DateOfDischarge] [datetime] NULL,
	[TypeOfDischarge] [int] NULL,
	[ConditionOnDischarge] [nvarchar](255) NULL,
	[HospitalCourse] [nvarchar](max) NULL,
	[NextReviewAfter] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DiscountPolicyUDT]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DiscountPolicyUDT' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DiscountPolicyUDT] AS TABLE(
	[TODID] [bigint] NOT NULL,
	[Code] [nvarchar](10) NULL,
	[BasedOn] [nvarchar](10) NULL,
	[RangeFrom] [bigint] NULL,
	[RangeTo] [bigint] NULL,
	[Value] [decimal](18, 2) NULL,
	[FeeID] [bigint] NULL,
	[FeeType] [nvarchar](10) NULL,
	[Name] [nvarchar](255) NULL,
	[IsActive] [nvarchar](1) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[DrugGenericUDT]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'DrugGenericUDT' AND ss.name = N'dbo')
CREATE TYPE [dbo].[DrugGenericUDT] AS TABLE(
	[GenericName] [nvarchar](255) NULL,
	[GenericID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ExaminationPKGAttribute]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ExaminationPKGAttribute' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ExaminationPKGAttribute] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[EID] [bigint] NULL,
	[AttributeID] [bigint] NULL,
	[AttributevalueID] [bigint] NULL,
	[AttributeValueName] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ExaminationPKGType]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ExaminationPKGType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ExaminationPKGType] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[EID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[ExaminationName] [nvarchar](255) NULL,
	[ComplaintId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ExcelProductDetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ExcelProductDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ExcelProductDetails] AS TABLE(
	[ProductName] [nvarchar](500) NULL DEFAULT (''),
	[Category] [nvarchar](255) NULL DEFAULT (''),
	[BatchNo] [nvarchar](50) NULL DEFAULT (''),
	[LSU] [nvarchar](50) NULL DEFAULT (''),
	[QTY] [decimal](16, 2) NULL,
	[CompQTY] [decimal](16, 2) NULL,
	[cost price] [decimal](16, 6) NULL,
	[Selling Price] [decimal](16, 6) NULL,
	[Tax] [decimal](16, 2) NULL,
	[Discount] [decimal](16, 2) NULL,
	[MFT] [datetime] NULL,
	[Exp] [datetime] NULL,
	[VENDOR NAME] [nvarchar](max) NULL DEFAULT (''),
	[INVOICE. NO] [nvarchar](max) NULL DEFAULT (''),
	[Invoice DATE] [datetime] NULL,
	[Stock Receive Date] [datetime] NULL,
	[DC.no] [nvarchar](255) NULL,
	[ProductKeyflag] [bit] NULL DEFAULT ((0)),
	[ProductReceivedDetailsID] [bigint] NULL,
	[ReceivedUniqueNumber] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Familytree]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Familytree' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Familytree] AS TABLE(
	[ExternalName] [nvarchar](100) NULL,
	[ExternalPatientID] [bigint] NULL,
	[ExternalNoumber] [nvarchar](100) NULL,
	[DependentsName] [nvarchar](100) NULL,
	[DependentsPatientID] [bigint] NULL,
	[DependentsNoumber] [nvarchar](100) NULL,
	[DependentsType] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[FeedBackDetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FeedBackDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[FeedBackDetails] AS TABLE(
	[FeedBackQuestionID] [int] NULL,
	[UserFeedBackAnswer] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[FeeShareGroupValueDetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FeeShareGroupValueDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[FeeShareGroupValueDetails] AS TABLE(
	[GroupDefinationID] [bigint] NULL,
	[FeeTypeAttributesID] [bigint] NULL,
	[Value] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[FeeSplitSeriveDetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FeeSplitSeriveDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[FeeSplitSeriveDetails] AS TABLE(
	[SpecID] [bigint] NULL,
	[ID] [bigint] NULL,
	[RateId] [bigint] NULL,
	[FeeID] [bigint] NULL,
	[SplitOrgID] [int] NULL,
	[Type] [nvarchar](10) NULL,
	[FeeTypeAttributesID] [int] NULL,
	[SplitAmount] [decimal](18, 0) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[FileUploadDetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'FileUploadDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[FileUploadDetails] AS TABLE(
	[DocFileIDs] [bigint] NULL,
	[DocFileName] [nvarchar](500) NULL,
	[DocFileUrl] [nvarchar](max) NULL,
	[IdentifyingType] [nvarchar](50) NULL,
	[IdentifyingId] [bigint] NULL,
	[DocType] [nvarchar](50) NULL,
	[DocDate] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[GenerateWorklist]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GenerateWorklist' AND ss.name = N'dbo')
CREATE TYPE [dbo].[GenerateWorklist] AS TABLE(
	[ExternalVisitID] [nvarchar](20) NOT NULL,
	[PatientVisitID] [bigint] NOT NULL,
	[AccessionNumber] [int] NOT NULL,
	[SeqNo] [int] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[GetOrgIDs]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GetOrgIDs' AND ss.name = N'dbo')
CREATE TYPE [dbo].[GetOrgIDs] AS TABLE(
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[GetUserIDs]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GetUserIDs' AND ss.name = N'dbo')
CREATE TYPE [dbo].[GetUserIDs] AS TABLE(
	[LoginID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[GroupOrgMapping]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'GroupOrgMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[GroupOrgMapping] AS TABLE(
	[GroupID] [bigint] NOT NULL,
	[GroupName] [nvarchar](255) NULL,
	[OrgID] [int] NOT NULL,
	[Display] [nvarchar](5) NULL,
	[DisplayText] [nvarchar](255) NULL,
	[SequenceNo] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HCInvestigationResults]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCInvestigationResults' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HCInvestigationResults] AS TABLE(
	[Name] [nvarchar](500) NULL,
	[Value] [nvarchar](max) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[PatientVisitID] [bigint] NULL,
	[UOMID] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[UOMCode] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[GroupName] [nvarchar](255) NULL,
	[Status] [nvarchar](50) NULL,
	[ModifiedBy] [bigint] NULL,
	[PackageID] [int] NULL,
	[PackageName] [nvarchar](255) NULL,
	[SequenceNo] [int] NULL,
	[Dilution] [nvarchar](max) NULL,
	[RefferalID] [bigint] NULL,
	[DeviceID] [nvarchar](50) NULL,
	[DeviceValue] [nvarchar](max) NULL,
	[Precision] [nvarchar](max) NULL,
	[GUID] [nvarchar](255) NULL,
	[DeviceActualValue] [nvarchar](max) NULL,
	[ConvValue] [nvarchar](max) NULL,
	[ConvUOMCode] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HCOrdereddetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCOrdereddetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HCOrdereddetails] AS TABLE(
	[Orgid] [int] NULL,
	[Visitid] [bigint] NULL,
	[ID] [bigint] NULL,
	[Type] [nvarchar](20) NULL,
	[Name] [nvarchar](255) NULL,
	[SampleContainerID] [int] NULL,
	[SampleType] [nvarchar](250) NULL,
	[SampleCode] [int] NULL,
	[Barcode] [nvarchar](100) NULL,
	[SampleStatusid] [int] NULL,
	[SampleStatus] [nvarchar](50) NULL,
	[ReasonID] [int] NULL,
	[SampleReasonName] [nvarchar](100) NULL,
	[RecollectTime] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HCOrderedInvestigation]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCOrderedInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HCOrderedInvestigation] AS TABLE(
	[Name] [nvarchar](255) NULL,
	[ID] [bigint] NULL,
	[VisitID] [bigint] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[StudyInstanceUId] [nvarchar](150) NULL,
	[ComplaintId] [int] NULL,
	[ReferedToOrgID] [int] NULL,
	[ReferedToLocation] [int] NULL,
	[InvestigationsType] [nvarchar](5) NULL,
	[ReferralID] [bigint] NULL,
	[UID] [nvarchar](255) NULL,
	[ReferenceType] [nchar](1) NULL,
	[RefPhyName] [nvarchar](255) NULL,
	[RefPhysicianID] [bigint] NULL,
	[SequenceNo] [int] NULL,
	[ReportDateTime] [datetime] NULL,
	[TatDateTime] [datetime] NULL,
	[IsStat] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HCUDTServiceQuotation]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCUDTServiceQuotation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HCUDTServiceQuotation] AS TABLE(
	[TokenNumber] [int] NOT NULL,
	[TITLECode] [tinyint] NULL,
	[PatientName] [nvarchar](150) NULL,
	[SEX] [nchar](1) NULL,
	[DOB] [datetime] NULL,
	[Age] [nvarchar](20) NULL,
	[LandLineNumber] [nvarchar](30) NULL,
	[CreatedAt] [datetime] NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[EMail] [nvarchar](100) NULL,
	[ClientID] [int] NULL,
	[FeeType] [nvarchar](50) NULL,
	[SourceType] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgAddressID] [bigint] NULL,
	[OtherOrgID] [int] NULL,
	[CollectionAddress] [nvarchar](250) NULL,
	[RoleID] [bigint] NULL,
	[UserID] [bigint] NULL,
	[CollectionTime] [datetime] NULL,
	[BookingOrgID] [int] NULL,
	[BookingStatus] [nchar](1) NULL,
	[CollectionAddress2] [nvarchar](250) NULL,
	[City] [nvarchar](25) NULL,
	[PatientNumber] [nvarchar](30) NULL,
	[BookingID] [bigint] NULL,
	[BillDescription] [nvarchar](max) NULL,
	[Priority] [nvarchar](25) NULL,
	[Comments] [nvarchar](250) NULL,
	[State] [nvarchar](50) NULL,
	[Pincode] [nvarchar](10) NULL,
	[StateID] [smallint] NULL,
	[CityID] [bigint] NULL,
	[URNTypeID] [bigint] NULL,
	[URNO] [nvarchar](50) NULL,
	[DispatchValue] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HIDECType]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HIDECType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HIDECType] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[HIDECID] [int] NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ComplaintID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HistoryPKGAttribute]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HistoryPKGAttribute' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HistoryPKGAttribute] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[HID] [bigint] NULL,
	[AttributeID] [bigint] NULL,
	[AttributevalueID] [bigint] NULL,
	[AttributeName] [nvarchar](100) NULL,
	[AttributeValueName] [nvarchar](100) NULL,
	[InvestigationID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HistoryPKGType]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HistoryPKGType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HistoryPKGType] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[HID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[HistoryName] [nvarchar](255) NULL,
	[ComplaintId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HistoSpecimenDetails]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HistoSpecimenDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[HistoSpecimenDetails] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[ID] [bigint] NULL,
	[Type] [varchar](5) NULL,
	[SampleID] [int] NULL,
	[SampleName] [nvarchar](500) NULL,
	[SampleCount] [int] NULL,
	[ClinicalNotes] [varchar](max) NULL,
	[ClinicalDiagnosis] [varchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Immunization]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Immunization' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Immunization] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[PatientID] [bigint] NOT NULL,
	[VaccinationID] [int] NOT NULL,
	[VaccinationName] [nvarchar](100) NULL,
	[ImmunizedPeriod] [nvarchar](20) NOT NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Paymentstatus] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[IntegerTableType]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IntegerTableType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[IntegerTableType] AS TABLE(
	[ID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvClientMaster]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvClientMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvClientMaster] AS TABLE(
	[ClientID] [bigint] NOT NULL,
	[OrgID] [bigint] NULL,
	[ClientName] [nvarchar](100) NULL,
	[ClientTypeID] [int] NULL,
	[Type] [nvarchar](10) NULL,
	[ActiveYN] [nchar](1) NULL,
	[Status] [nvarchar](20) NULL,
	[RateTypeId] [int] NULL,
	[RateId] [int] NULL,
	[ClientAttributes] [nvarchar](max) NULL,
	[IsAllMedical] [nchar](1) NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[Interval] [int] NULL,
	[ClientMappingDetailsID] [bigint] NULL,
	[ValidFromTime] [time](7) NULL,
	[ValidToTime] [time](7) NULL,
	[TransferRate] [nchar](2) NULL,
	[BaseRate] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvCoAuthorization]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvCoAuthorization' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvCoAuthorization] AS TABLE(
	[ID] [bigint] NOT NULL,
	[InvestigationID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
	[RoleID] [int] NULL,
	[DeptID] [int] NULL,
	[PhysicianID] [int] NULL,
	[IsPrimary] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvDeptMaster]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvDeptMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvDeptMaster] AS TABLE(
	[DeptID] [int] NULL,
	[DeptName] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[Display] [nvarchar](255) NULL,
	[SequenceNo] [int] NULL,
	[Code] [nchar](5) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InventoryAttributeValues]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryAttributeValues' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InventoryAttributeValues] AS TABLE(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExistXml] [nvarchar](max) NULL,
	[NewXml] [nvarchar](max) NULL,
	PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  UserDefinedTableType [dbo].[InventoryCategorieMapping]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryCategorieMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InventoryCategorieMapping] AS TABLE(
	[CategorieMappingID] [bigint] NULL,
	[CategoryID] [int] NULL,
	[AttributeID] [int] NULL,
	[IsMandatory] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InventoryItemsMapping]    Script Date: 6/25/2018 4:04:36 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryItemsMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InventoryItemsMapping] AS TABLE(
	[CategoryID] [int] NULL,
	[ProductID] [bigint] NULL,
	[CategoryName] [nvarchar](500) NULL,
	[ProductName] [nvarchar](500) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 6) NULL,
	[UOMID] [int] NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LSUnit] [nvarchar](20) NULL,
	[Description] [nvarchar](500) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[Providedby] [bigint] NULL,
	[Type] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NULL,
	[ID] [bigint] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](50) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](50) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 6) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[HasExpiryDate] [nchar](1) NULL,
	[HasBatchNo] [nchar](1) NULL,
	[HasUsage] [nchar](1) NULL,
	[UsageCount] [int] NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[InHandQuantity] [decimal](18, 2) NULL,
	[ExciseTax] [decimal](18, 2) NULL,
	[DiscOrEnhancePercent] [decimal](18, 2) NULL,
	[DiscOrEnhanceType] [nvarchar](10) NULL,
	[Remarks] [nvarchar](255) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[ReceivedOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[ReceivedOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](255) NULL,
	[PrescriptionNO] [nvarchar](30) NULL,
	[ActualPrice] [decimal](18, 6) NULL,
	[EligibleAmount] [decimal](18, 6) NULL,
	[ClientFeeTypeRateCustID] [bigint] NULL,
	[InvoiceDate] [datetime] NULL,
	[StockStatus] [int] NULL,
	[DefectiveQty] [decimal](18, 2) NULL,
	[Comments] [nvarchar](30) NULL,
	[Shortage] [decimal](18, 2) NULL,
	[Damage] [decimal](18, 2) NULL,
	[Rejected] [decimal](18, 2) NULL,
	[PrepareCharges] [decimal](18, 2) NULL,
	[ProductCode] [nvarchar](100) NULL,
	[CopayValue] [decimal](18, 2) NULL,
	[CopayType] [nvarchar](10) NULL,
	[GenericName] [nvarchar](max) NULL,
	[ProductReceivedDetailsID] [bigint] NULL,
	[PurchaseTax] [decimal](18, 2) NULL,
	[HandlingCharges] [decimal](18, 6) NULL,
	[ReceivedUniqueNumber] [bigint] NULL,
	[ReceivedBatchNo] [nvarchar](255) NULL,
	[StockReceivedBarcodeDetailsID] [bigint] NULL,
	[StockReceivedBarcodeID] [bigint] NULL,
	[BarcodeNo] [nvarchar](100) NULL,
	[IsUniqueBarcode] [nvarchar](100) NULL,
	[TaxAmount] [decimal](18, 2) NULL,
	[IsSmsNeeded] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationAdminRate]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationAdminRate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationAdminRate] AS TABLE(
	[ID] [bigint] NULL,
	[Amount] [decimal](18, 2) NULL,
	[Refrange] [nvarchar](500) NULL,
	[DisplayTxt] [nvarchar](255) NULL,
	[IPAmount] [decimal](18, 2) NULL,
	[OPPercent] [decimal](18, 2) NULL,
	[IPPercent] [decimal](18, 2) NULL,
	[SourceID] [bigint] NULL,
	[UOMCode] [nvarchar](50) NULL,
	[UOMID] [int] NULL,
	[TYPE] [nvarchar](10) NULL,
	[MinAdvanceAmt] [decimal](10, 2) NULL,
	[LabAmount] [decimal](18, 2) NULL,
	[FranchiseeAmount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDeleteOrgMapping]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDeleteOrgMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationDeleteOrgMapping] AS TABLE(
	[InvestigationID] [bigint] NOT NULL,
	[InvestigationName] [nvarchar](255) NULL,
	[OrgID] [int] NOT NULL,
	[DeptID] [int] NULL,
	[HeaderID] [bigint] NULL,
	[Display] [nvarchar](5) NULL,
	[DisplayText] [nvarchar](255) NULL,
	[ReferenceRange] [nvarchar](max) NULL,
	[SequenceNo] [int] NULL,
	[SampleCode] [int] NULL,
	[MethodID] [bigint] NULL,
	[PrincipleID] [bigint] NULL,
	[KitID] [bigint] NULL,
	[InstrumentID] [bigint] NULL,
	[QCData] [nchar](1) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[SampleContainerID] [int] NULL,
	[UOMID] [int] NULL,
	[UOMCode] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDetail]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationDetail] AS TABLE(
	[ID] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[Type] [nvarchar](50) NULL,
	[HistoryDetails] [nvarchar](max) NULL,
	[VisitID] [bigint] NULL,
	[TestSequenceOrder] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDetailsub]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDetailsub' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationDetailsub] AS TABLE(
	[ID] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[Type] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationDetailsubPKG]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationDetailsubPKG' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationDetailsubPKG] AS TABLE(
	[ID] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[Type] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationOrgMapping]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationOrgMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationOrgMapping] AS TABLE(
	[InvestigationID] [bigint] NOT NULL,
	[InvestigationName] [nvarchar](255) NULL,
	[OrgID] [int] NOT NULL,
	[DeptID] [int] NULL,
	[HeaderID] [bigint] NULL,
	[Display] [nvarchar](5) NULL,
	[DisplayText] [nvarchar](255) NULL,
	[ReferenceRange] [nvarchar](max) NULL,
	[SequenceNo] [int] NULL,
	[SampleCode] [int] NULL,
	[MethodID] [bigint] NULL,
	[PrincipleID] [bigint] NULL,
	[KitID] [bigint] NULL,
	[InstrumentID] [bigint] NULL,
	[QCData] [nchar](1) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[SampleContainerID] [int] NULL,
	[UOMID] [int] NULL,
	[UOMCode] [nvarchar](50) NULL,
	[LoginID] [bigint] NULL,
	[PanicRange] [nvarchar](max) NULL,
	[AutoApproveLoginID] [bigint] NULL,
	[ReferenceRangeString] [nvarchar](max) NULL,
	[PrintSeparately] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvestigationResults]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationResults' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvestigationResults] AS TABLE(
	[Name] [nvarchar](500) NULL,
	[Value] [nvarchar](max) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[PatientVisitID] [bigint] NULL,
	[UOMID] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[UOMCode] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[GroupName] [nvarchar](255) NULL,
	[Status] [nvarchar](50) NULL,
	[ModifiedBy] [bigint] NULL,
	[PackageID] [int] NULL,
	[PackageName] [nvarchar](255) NULL,
	[SequenceNo] [int] NULL,
	[Dilution] [nvarchar](max) NULL,
	[RefferalID] [bigint] NULL,
	[DeviceID] [nvarchar](50) NULL,
	[DeviceValue] [nvarchar](max) NULL,
	[Precision] [nvarchar](max) NULL,
	[GUID] [nvarchar](255) NULL,
	[DeviceActualValue] [nvarchar](max) NULL,
	[ConvValue] [nvarchar](max) NULL,
	[ConvUOMCode] [nvarchar](50) NULL,
	[DeviceErrorCode] [nvarchar](10) NULL,
	[IsAbnormal] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Investigations]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Investigations' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Investigations] AS TABLE(
	[SNO] [int] NULL,
	[InvestigationID] [bigint] NULL,
	[DisplayText] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvGroupMapMaster]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvGroupMapMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvGroupMapMaster] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [nchar](250) NULL,
	[SequenceNo] [int] NULL,
	[Type] [nvarchar](20) NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvGroupMapMasterPackage]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvGroupMapMasterPackage' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvGroupMapMasterPackage] AS TABLE(
	[PType] [nvarchar](250) NULL,
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [nvarchar](250) NULL,
	[SequenceNo] [int] NULL,
	[Type] [nvarchar](20) NULL,
	[PackageId] [int] NULL,
	[IsReflex] [nvarchar](10) NULL,
	[IsRePortable] [nvarchar](10) NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvHistoryAttributes]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvHistoryAttributes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvHistoryAttributes] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[HistoryID] [bigint] NULL,
	[HistoryName] [nvarchar](255) NULL,
	[AttributeID] [bigint] NULL,
	[AttributeName] [nvarchar](255) NULL,
	[AttributevalueID] [bigint] NULL,
	[AttributeValueName] [nvarchar](255) NULL,
	[Type] [nvarchar](50) NULL,
	[HasAttribute] [nvarchar](5) NULL,
	[Description] [nvarchar](500) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvInstrumentMaster]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvInstrumentMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvInstrumentMaster] AS TABLE(
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [nvarchar](255) NULL,
	[InstrumentType] [int] NULL,
	[ProductCode] [nvarchar](255) NULL,
	[Model] [nvarchar](255) NULL,
	[Manufacturer] [nvarchar](255) NULL,
	[Method] [nvarchar](255) NULL,
	[Principle] [nvarchar](255) NULL,
	[ProcessingMode] [nvarchar](50) NULL,
	[SampleVolume] [nvarchar](50) NULL,
	[DataStorage] [nvarchar](50) NULL,
	[ThroughPut] [nvarchar](50) NULL,
	[Direction] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[Status] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[QCData] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Department] [nvarchar](100) NULL,
	[DeptID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvInstrumentMaster_QMS]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvInstrumentMaster_QMS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvInstrumentMaster_QMS] AS TABLE(
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [nvarchar](255) NULL,
	[InstrumentType] [int] NULL,
	[ProductCode] [nvarchar](255) NULL,
	[Model] [nvarchar](255) NULL,
	[Manufacturer] [nvarchar](255) NULL,
	[Method] [nvarchar](255) NULL,
	[Principle] [nvarchar](255) NULL,
	[ProcessingMode] [nvarchar](50) NULL,
	[SampleVolume] [nvarchar](50) NULL,
	[DataStorage] [nvarchar](50) NULL,
	[ThroughPut] [nvarchar](50) NULL,
	[Direction] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[Status] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[QCData] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Department] [nvarchar](100) NULL,
	[DeptID] [int] NULL,
	[MethodID] [bigint] NULL,
	[PrincipleID] [bigint] NULL,
	[InstallationDate] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvOrgReferenceMapping]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvOrgReferenceMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvOrgReferenceMapping] AS TABLE(
	[ID] [bigint] NOT NULL,
	[InvestigationID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[InstrumentID] [bigint] NULL,
	[KitID] [bigint] NULL,
	[UOMID] [int] NULL,
	[UOMCode] [nvarchar](50) NULL,
	[ReferenceRange] [nvarchar](max) NULL,
	[IsPrimary] [nchar](1) NULL,
	[IsActive] [nchar](1) NULL,
	[ClientID] [int] NULL,
	[TestCode] [nvarchar](50) NULL,
	[InstrumentCode] [nvarchar](50) NULL,
	[ReasonCode] [nvarchar](10) NULL,
	[DeviceMappingID] [bigint] NULL,
	[CONV_UOMID] [int] NULL,
	[CONV_UOMCode] [nvarchar](50) NULL,
	[CONV_Factor] [decimal](18, 9) NULL,
	[ConvFac_DecimalPoint] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvProductMapping]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvProductMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvProductMapping] AS TABLE(
	[InvestigationId] [bigint] NULL,
	[ProductId] [bigint] NULL,
	[EstimateQty] [decimal](18, 2) NULL,
	[Eunits] [nvarchar](50) NULL,
	[BufferQty] [decimal](18, 2) NULL,
	[Bunits] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvRemarks]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvRemarks' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvRemarks] AS TABLE(
	[RemarksID] [bigint] NULL,
	[RoleID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvReportTemplateFooter]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvReportTemplateFooter' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvReportTemplateFooter] AS TABLE(
	[Source] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[Name] [nvarchar](255) NULL,
	[Designation] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[InvestigationID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvSummaryReport]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvSummaryReport' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvSummaryReport] AS TABLE(
	[ResultSummary] [nvarchar](max) NULL,
	[ClinicalInterpretation] [nvarchar](max) NULL,
	[Suggestions] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[ShowTRF] [bit] NOT NULL,
	[OrgID] [int] NULL,
	[VisitID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[InvSummaryTrend]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvSummaryTrend' AND ss.name = N'dbo')
CREATE TYPE [dbo].[InvSummaryTrend] AS TABLE(
	[TrendInvId] [nvarchar](250) NULL,
	[Content] [varbinary](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[IPInvSamples]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPInvSamples' AND ss.name = N'dbo')
CREATE TYPE [dbo].[IPInvSamples] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[BarcodeNumber] [nvarchar](250) NULL,
	[SampleCode] [int] NULL,
	[SampleDesc] [nvarchar](250) NULL,
	[IPInvSampleCollectionMasterID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[IPPatInvestigation]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPPatInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[IPPatInvestigation] AS TABLE(
	[InvestigationName] [nvarchar](255) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[GroupName] [nvarchar](255) NULL,
	[PatientVisitID] [bigint] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CollectedDateTime] [datetime] NULL,
	[Status] [nvarchar](100) NULL,
	[ComplaintID] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[IPInvSampleCollectionMasterID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[IPTreatmentPlan]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPTreatmentPlan' AND ss.name = N'dbo')
CREATE TYPE [dbo].[IPTreatmentPlan] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[IPTreatmentPlanID] [int] NULL,
	[IPTreatmentPlanName] [nvarchar](100) NULL,
	[Prosthesis] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[OperationID] [bigint] NULL,
	[ParentID] [int] NULL,
	[ParentName] [nvarchar](100) NULL,
	[TreatmentPlanDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[StagePlanned] [nvarchar](5) NULL,
	[TreatmentPlanID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[IPTreatmentPlanDetails]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'IPTreatmentPlanDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[IPTreatmentPlanDetails] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[IPTreatmentPlanID] [int] NULL,
	[ScrubTeam] [nvarchar](100) NULL,
	[SurgeonID] [bigint] NULL,
	[AnesthesiastID] [bigint] NULL,
	[IsProvisional] [nvarchar](1) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[IPTreatmentPlanName] [nvarchar](100) NULL,
	[Prosthesis] [nvarchar](100) NULL,
	[ParentID] [int] NULL,
	[ParentName] [nvarchar](100) NULL,
	[TreatmentPlanDate] [datetime] NULL,
	[StagePlanned] [nvarchar](20) NULL,
	[SurgeonName] [nvarchar](100) NULL,
	[AnesthesiastName] [nvarchar](100) NULL,
	[SiteOfOperation] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[LabourAndDeliveryNotes]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LabourAndDeliveryNotes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[LabourAndDeliveryNotes] AS TABLE(
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[HusbandName] [nvarchar](100) NULL,
	[TypeOfLabour] [int] NULL,
	[ModeOfDelivery] [int] NULL,
	[DeliveryAssistance] [int] NULL,
	[ProcedureTypeID] [int] NULL,
	[GenerationType] [int] NULL,
	[LabourTmax] [nvarchar](20) NULL,
	[ROMLength] [nvarchar](20) NULL,
	[DeliveryTerm] [nvarchar](50) NULL,
	[DeliveringObstreticianID] [bigint] NULL,
	[NeonatologistID] [bigint] NULL,
	[DeliveryNotes] [nvarchar](max) NULL,
	[BirthRegID] [bigint] NULL,
	[AnesthesiaTypeID] [int] NULL,
	[TypeiD] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[LoginDetail]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LoginDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[LoginDetail] AS TABLE(
	[LoginID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[Orgid] [int] NULL,
	[DummyString] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[LotMaster]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LotMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[LotMaster] AS TABLE(
	[LotID] [bigint] NULL,
	[LotName] [nvarchar](50) NULL,
	[LotCode] [nvarchar](50) NULL,
	[MacID] [bigint] NULL,
	[VendorID] [bigint] NULL,
	[MetaValueID] [int] NULL,
	[DisplayText] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[InvestigationID] [bigint] NULL,
	[IsExpired] [char](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[LotVendorMaster]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LotVendorMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[LotVendorMaster] AS TABLE(
	[VendorName] [nvarchar](100) NULL,
	[Vendorcode] [nvarchar](25) NULL,
	[PanNo] [nvarchar](15) NULL,
	[SPOCName] [nvarchar](50) NULL,
	[EmailID] [nvarchar](100) NULL,
	[Mobileno] [nvarchar](50) NULL,
	[Landlineno] [nvarchar](50) NULL,
	[FaxNo] [nvarchar](50) NULL,
	[CountryID] [int] NULL,
	[StateID] [int] NULL,
	[CityID] [int] NULL,
	[PostalCode] [nvarchar](50) NULL,
	[TempAddress] [nvarchar](500) NULL,
	[PermenentAddress] [nvarchar](500) NULL,
	[Termsandconditions] [nvarchar](800) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[LstInvestigationDetails]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'LstInvestigationDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[LstInvestigationDetails] AS TABLE(
	[InvestigationID] [bigint] NULL DEFAULT (''),
	[InvestigationName] [nvarchar](255) NULL DEFAULT (''),
	[GroupID] [int] NULL DEFAULT (''),
	[PatientVisitID] [bigint] NULL DEFAULT (''),
	[OrgID] [bigint] NULL DEFAULT (''),
	[Status] [nvarchar](20) NULL DEFAULT (''),
	[Value] [nvarchar](max) NULL DEFAULT (''),
	[ReferenceRange] [nvarchar](max) NULL DEFAULT (''),
	[MedicalRemarks] [nvarchar](255) NULL DEFAULT (''),
	[TechnicalRemarks] [nvarchar](255) NULL DEFAULT ('')
)
GO
/****** Object:  UserDefinedTableType [dbo].[ManufacturerUDT]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ManufacturerUDT' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ManufacturerUDT] AS TABLE(
	[MfgID] [bigint] NULL,
	[MfgName] [nvarchar](255) NULL,
	[MfgCode] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[Phone] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[MasterBulkdata]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'MasterBulkdata' AND ss.name = N'dbo')
CREATE TYPE [dbo].[MasterBulkdata] AS TABLE(
	[TestName] [nvarchar](100) NULL,
	[CasualtyRate] [decimal](18, 2) NULL,
	[ProcedureDesc] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NULL,
	[IPAmount] [decimal](18, 2) NULL,
	[ItemName] [nvarchar](50) NULL,
	[Rate] [numeric](18, 2) NULL,
	[PhysicianName] [nvarchar](100) NULL,
	[Qualification] [nvarchar](100) NULL,
	[OrganizationName] [nvarchar](100) NULL,
	[IPTreatmentPlanName] [nvarchar](100) NULL,
	[IPTreatmentPlanParentID] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ModuleCategory]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ModuleCategory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ModuleCategory] AS TABLE(
	[ModuleID] [int] NULL,
	[ModuleName] [nvarchar](50) NULL,
	[ModuleCode] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[MultiplePageContextkey]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'MultiplePageContextkey' AND ss.name = N'dbo')
CREATE TYPE [dbo].[MultiplePageContextkey] AS TABLE(
	[PageID] [bigint] NULL,
	[ButtonName] [nvarchar](124) NULL,
	[RoleID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[RedirectURL] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[ActionType] [nvarchar](250) NULL,
	[ID] [bigint] NULL,
	[ContextType] [nvarchar](250) NULL,
	[ButtonValue] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[NewBornDetails]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'NewBornDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[NewBornDetails] AS TABLE(
	[BirthRegID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[ParentVisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[Name] [nvarchar](255) NULL,
	[Sex] [nvarchar](10) NULL,
	[IdentiFicationMarks1] [nvarchar](255) NULL,
	[IdentiFicationMarks2] [nvarchar](255) NULL,
	[DOB] [datetime] NULL,
	[BirthWeight] [nvarchar](10) NULL,
	[PresentationID] [int] NULL,
	[HeadCIRC] [nvarchar](10) NULL,
	[CHL] [nvarchar](10) NULL,
	[Status] [nvarchar](50) NULL,
	[APGARScore] [nvarchar](100) NULL,
	[NewBornDetailID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[NonReimbursableItems]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'NonReimbursableItems' AND ss.name = N'dbo')
CREATE TYPE [dbo].[NonReimbursableItems] AS TABLE(
	[FeeType] [nvarchar](100) NULL,
	[FeeID] [bigint] NULL,
	[FeeDesc] [nvarchar](max) NULL,
	[FeeTypeDesc] [nvarchar](max) NULL,
	[TPAID] [bigint] NULL,
	[TPAType] [nvarchar](255) NULL,
	[IsActive] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[NotificationAudits]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'NotificationAudits' AND ss.name = N'dbo')
CREATE TYPE [dbo].[NotificationAudits] AS TABLE(
	[ReceiverType] [nvarchar](20) NULL,
	[Id] [bigint] NULL,
	[NotificationTypes] [nvarchar](50) NULL,
	[ContactInfo] [nvarchar](50) NULL,
	[Message] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[OperationComplication]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationComplication' AND ss.name = N'dbo')
CREATE TYPE [dbo].[OperationComplication] AS TABLE(
	[OperationComplicationID] [bigint] NULL,
	[OperationID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[ComplicationName] [nvarchar](200) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ComplaintID] [int] NULL,
	[ICDCodeStatus] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[OperationFinding]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationFinding' AND ss.name = N'dbo')
CREATE TYPE [dbo].[OperationFinding] AS TABLE(
	[OperationFindingID] [bigint] NULL,
	[OperationID] [bigint] NULL,
	[OperationFindings] [nvarchar](max) NULL,
	[Type] [nvarchar](50) NULL,
	[PatientVistID] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[OperationNotes]    Script Date: 6/25/2018 4:04:37 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationNotes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[OperationNotes] AS TABLE(
	[OperationID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[PatientVistID] [bigint] NULL,
	[FromTime] [datetime] NULL,
	[ToTime] [datetime] NULL,
	[SurgeryTypeID] [int] NULL,
	[AnesthesiaTypeID] [int] NULL,
	[OperationTypeID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[OperationStaff]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OperationStaff' AND ss.name = N'dbo')
CREATE TYPE [dbo].[OperationStaff] AS TABLE(
	[OperationStaffID] [bigint] NULL,
	[OperationID] [bigint] NULL,
	[StaffType] [nvarchar](20) NULL,
	[StaffID] [bigint] NULL,
	[OrgID] [int] NULL,
	[PatientVistID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[OrderedInvestigation]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OrderedInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[OrderedInvestigation] AS TABLE(
	[Name] [nvarchar](255) NULL,
	[ID] [bigint] NULL,
	[VisitID] [bigint] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[StudyInstanceUId] [nvarchar](150) NULL,
	[ComplaintId] [int] NULL,
	[ReferedToOrgID] [int] NULL,
	[ReferedToLocation] [int] NULL,
	[InvestigationsType] [nvarchar](max) NULL,
	[ReferralID] [bigint] NULL,
	[UID] [nvarchar](255) NULL,
	[ReferenceType] [nchar](1) NULL,
	[RefPhyName] [nvarchar](255) NULL,
	[RefPhysicianID] [bigint] NULL,
	[SequenceNo] [int] NULL,
	[ReportDateTime] [datetime] NULL,
	[TatDateTime] [datetime] NULL,
	[IsStat] [nchar](1) NULL,
	[SampleID] [nvarchar](50) NULL,
	[TestSequenceOrder] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[OrderedPhysiotherapy]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OrderedPhysiotherapy' AND ss.name = N'dbo')
CREATE TYPE [dbo].[OrderedPhysiotherapy] AS TABLE(
	[ProcedureID] [bigint] NULL,
	[ProcedureName] [nvarchar](500) NULL,
	[OdreredQty] [decimal](18, 2) NULL,
	[Status] [nvarchar](50) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PhysicianComments] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientAddress]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientAddress' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientAddress] AS TABLE(
	[PatientID] [bigint] NULL,
	[AddressType] [nvarchar](250) NULL,
	[Add1] [nvarchar](250) NULL,
	[Add2] [nvarchar](250) NULL,
	[Add3] [nvarchar](250) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[CountryID] [int] NULL,
	[City] [nvarchar](25) NULL,
	[StateID] [int] NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[LandLineNumber] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OtherCountryName] [nvarchar](60) NULL,
	[OtherStateName] [nvarchar](60) NULL,
	[CityCode] [int] NULL,
	[AddLevel1] [int] NULL,
	[AddLevel2] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientAmbulancedetails]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientAmbulancedetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientAmbulancedetails] AS TABLE(
	[AmbulancedetailsID] [bigint] NULL,
	[AmbulanceID] [bigint] NULL,
	[FinalBillID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[DriverID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[Createdby] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[Modifiedby] [bigint] NULL,
	[Modifiedat] [datetime] NULL,
	[AmbulancearrivalFromdate] [datetime] NULL,
	[AmbulancearrivalTodate] [datetime] NULL,
	[Distancekgm] [bigint] NULL,
	[Duration] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientBillingDetails]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientBillingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientBillingDetails] AS TABLE(
	[VisitID] [bigint] NOT NULL,
	[PatientID] [bigint] NOT NULL,
	[PhysicianID] [bigint] NULL,
	[ConsultationDate] [datetime] NULL,
	[Status] [nvarchar](10) NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime] NOT NULL,
	[Description] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientComplaintAttribute]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientComplaintAttribute' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientComplaintAttribute] AS TABLE(
	[PatientComplaintAttributeID] [bigint] NULL,
	[ComplaintID] [bigint] NULL,
	[PatientVisitId] [bigint] NULL,
	[SeqID] [bigint] NULL,
	[AttributeID] [bigint] NULL,
	[AttributevalueID] [bigint] NULL,
	[AttributeValueName] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientComplaintHealth]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientComplaintHealth' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientComplaintHealth] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientComplication]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientComplication' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientComplication] AS TABLE(
	[ComplicationID] [int] NULL,
	[ComplicationName] [nvarchar](30) NULL,
	[ComplicationType] [nvarchar](10) NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ComplaintID] [int] NULL,
	[ICDCodeStatus] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientDiscount]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientDiscount' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientDiscount] AS TABLE(
	[FinalBillID] [bigint] NULL,
	[DiscountID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvestigation]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientInvestigation] AS TABLE(
	[InvestigationName] [nvarchar](255) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[GroupName] [nvarchar](255) NULL,
	[GroupComment] [nvarchar](255) NULL,
	[PatientVisitID] [bigint] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CollectedDateTime] [datetime] NULL,
	[Status] [nvarchar](100) NULL,
	[ComplaintID] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[InvestigationMethodID] [bigint] NULL,
	[MethodName] [nvarchar](255) NULL,
	[KitID] [bigint] NULL,
	[KitName] [nvarchar](255) NULL,
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [nvarchar](255) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[PrincipleID] [bigint] NULL,
	[PrincipleName] [nvarchar](255) NULL,
	[QCData] [nvarchar](max) NULL,
	[InvestigationSampleContainerID] [int] NULL,
	[PackageID] [int] NULL,
	[PackageName] [nvarchar](255) NULL,
	[Reason] [nvarchar](max) NULL,
	[ReportStatus] [nvarchar](max) NULL,
	[ReferenceRange] [nvarchar](max) NULL,
	[PerformingPhysicainName] [nvarchar](255) NULL,
	[ApprovedBy] [bigint] NULL,
	[GUID] [nvarchar](max) NULL,
	[IsAbnormal] [nvarchar](25) NULL,
	[AccessionNumber] [bigint] NULL,
	[AutoApproveLoginID] [bigint] NULL,
	[ValidatedBy] [bigint] NULL,
	[RemarksID] [bigint] NULL,
	[MedicalRemarks] [nvarchar](max) NULL,
	[GroupMedicalRemarks] [nvarchar](max) NULL,
	[InvSampleStatusID] [int] NULL,
	[AuthorizedBy] [bigint] NULL,
	[ConvReferenceRange] [nvarchar](max) NULL,
	[ManualAbnormal] [nvarchar](1) NULL,
	[IsAutoAuthorize] [nvarchar](1) NULL,
	[PrintableRange] [nvarchar](max) NULL,
	[IsAutoValidate] [nvarchar](1) NULL,
	[InvStatusReasonID] [bigint] NULL,
	[IsSensitive] [nvarchar](1) NULL,
	/* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
	[IsReportable] [bit] NULL
	/* END | NA | Sabari | 20181202 | Created | HOLD */
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvestigationFiles]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigationFiles' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientInvestigationFiles] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[FilePath] [nvarchar](100) NULL,
	[ImageSource] [varbinary](max) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[ImageID] [bigint] NULL,
	[Description] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvFileUpload]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvFileUpload' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientInvFileUpload] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[FilePath] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvSample]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSample' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientInvSample] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[SampleID] [int] NULL,
	[BarcodeNumber] [nvarchar](250) NULL,
	[SampleCode] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvSampleCollected]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleCollected' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientInvSampleCollected] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[SampleID] [int] NULL,
	[BarcodeNumber] [nvarchar](250) NULL,
	[SampleCode] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[InvSampleStatusID] [int] NULL,
	[DeptID] [int] NULL,
	[Reason] [nvarchar](500) NULL,
	[SampleContainerID] [int] NULL,
	[UID] [nvarchar](255) NULL,
	[CollectedLocID] [int] NULL,
	[RecSampleLocID] [int] NULL,
	[SampleRelationshipID] [int] NULL,
	[CollectedDateTime] [datetime] NULL,
	[VmValue] [int] NULL,
	[VmUnitID] [int] NULL,
	[SampleConditionID] [int] NULL,
	[ConsignmentNo] [nvarchar](50) NULL,

	[ExternalBarcode] [nvarchar](250) NULL,
	[BarcodeCount] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientInvSampleMapping]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientInvSampleMapping] AS TABLE(
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleID] [int] NULL,
	[ID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[Barcode] [nvarchar](250) NULL,
	[UniqueID] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientOldNotesFileMapping]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientOldNotesFileMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientOldNotesFileMapping] AS TABLE(
	[FileID] [bigint] NULL,
	[PatienOldNotesID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[patientOrganDonation]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'patientOrganDonation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[patientOrganDonation] AS TABLE(
	[PatientID] [bigint] NULL,
	[OrganID] [smallint] NULL,
	[OrganRegWith] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientPhysioDetails]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientPhysioDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientPhysioDetails] AS TABLE(
	[RowID] [bigint] NULL,
	[ProcedureID] [bigint] NULL,
	[ProcedureName] [nvarchar](500) NULL,
	[AdvisedNoOfSitting] [int] NULL,
	[CurrentNoOfSitting] [int] NULL,
	[DurationValue] [decimal](18, 2) NULL,
	[DurationUnits] [nvarchar](20) NULL,
	[ScoreCardValue] [decimal](18, 2) NULL,
	[ScoreCardUnit] [nvarchar](20) NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [nvarchar](20) NULL,
	[HasPending] [nvarchar](10) NULL,
	[NextReview] [nvarchar](100) NULL,
	[PatientPhysioDtlID] [bigint] NULL,
	[PhysicianComments] [nvarchar](max) NULL,
	[Symptoms] [nvarchar](max) NULL,
	[VisitType] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientPreferences]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientPreferences' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientPreferences] AS TABLE(
	[PatientID] [bigint] NOT NULL,
	[PatientVisitID] [bigint] NULL,
	[PatientPreference] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[patientPRO]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'patientPRO' AND ss.name = N'dbo')
CREATE TYPE [dbo].[patientPRO] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[ProcedureID] [bigint] NOT NULL,
	[ProcedureFID] [bigint] NOT NULL,
	[ProcedureDesc] [nvarchar](max) NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientRecommendationDetails]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientRecommendationDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientRecommendationDetails] AS TABLE(
	[PRecoDtlsID] [bigint] NULL,
	[RecoID] [bigint] NULL,
	[ResultID] [int] NULL,
	[ResultValues] [nvarchar](max) NULL,
	[SequenceNo] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientRedemDetails]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientRedemDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientRedemDetails] AS TABLE(
	[MembershipCardMappingID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[RedemPoints] [decimal](18, 2) NULL,
	[RedemValue] [decimal](18, 2) NULL,
	[Finalbillid] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientReferring]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientReferring' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientReferring] AS TABLE(
	[RefPhysicianID] [bigint] NULL,
	[RefPhyName] [nvarchar](255) NULL,
	[ReferenceType] [nchar](1) NULL,
	[FeeType] [nvarchar](30) NULL,
	[FeeID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[Status] [nvarchar](50) NULL,
	[Comments] [nvarchar](150) NULL,
	[PerphyID] [bigint] NULL,
	[Perphyname] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientVitals]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientVitals' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientVitals] AS TABLE(
	[PatientVitalsID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[VitalsID] [int] NULL,
	[VitalsValue] [numeric](7, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[UOMID] [int] NULL,
	[ConditionID] [int] NULL,
	[NurseNotes] [nvarchar](255) NULL,
	[VitalsName] [nvarchar](20) NULL,
	[VitalsDescription] [nvarchar](50) NULL,
	[UOMCode] [nvarchar](50) NULL,
	[UOMDescription] [nvarchar](50) NULL,
	[VitalsSetID] [int] NULL,
	[VitalsType] [nvarchar](100) NULL,
	[VitalsTypeID] [bigint] NULL,
	[EntryDate] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientVitalsType]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientVitalsType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatientVitalsType] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[VitalsID] [int] NULL,
	[VitalsValue] [nvarchar](10) NULL,
	[SessionType] [tinyint] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatInvestigation]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatInvestigation] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[InvestigationID] [bigint] NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatternMapping]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatternMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PatternMapping] AS TABLE(
	[PatternID] [bigint] NULL,
	[InvestigationID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PendingICD]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PendingICD' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PendingICD] AS TABLE(
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[ComplaintType] [nvarchar](5) NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ICDCodeStatus] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PhysicianOrgMappingUDT]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PhysicianOrgMappingUDT' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PhysicianOrgMappingUDT] AS TABLE(
	[MappingID] [bigint] NULL,
	[PhysicianID] [bigint] NULL,
	[HospitalID] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PhysioCompliant]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PhysioCompliant' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PhysioCompliant] AS TABLE(
	[PatientPhysioDtlID] [bigint] NULL,
	[ComplaintID] [bigint] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ICDCodeStatus] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[POMappingLocation]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'POMappingLocation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[POMappingLocation] AS TABLE(
	[supplierid] [bigint] NULL,
	[POID] [bigint] NULL,
	[PODetailsID] [bigint] NULL,
	[Productid] [bigint] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Units] [nvarchar](255) NULL,
	[LocationID] [bigint] NULL,
	[DeliveryDate] [datetime] NULL,
	[ToLocationID] [int] NULL,
	[TrustedOrgID] [int] NULL,
	[CompQty] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Vat] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[POMappingID] [bigint] NULL,
	[Rate] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NULL,
		[ProductDescription] [NVarchar](500) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PrescriptionDrugType]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrescriptionDrugType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PrescriptionDrugType] AS TABLE(
	[PrescriptionID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[DrugName] [nvarchar](100) NULL,
	[DrugFormulation] [nvarchar](100) NULL,
	[DrugFrequency] [nvarchar](100) NULL,
	[ROA] [nvarchar](100) NULL,
	[Dose] [nvarchar](100) NULL,
	[Duration] [nvarchar](100) NULL,
	[Instruction] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[AdministeredAtFrom] [datetime] NULL,
	[AdministeredAtTo] [datetime] NULL,
	[DrugStatus] [nvarchar](25) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PrescriptionType]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrescriptionType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PrescriptionType] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[DrugName] [nvarchar](100) NULL,
	[DrugFormulation] [nvarchar](100) NULL,
	[DrugFrequency] [nvarchar](100) NULL,
	[ROA] [nvarchar](100) NULL,
	[Dose] [nvarchar](100) NULL,
	[Duration] [nvarchar](100) NULL,
	[Instruction] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[DrugStatus] [nvarchar](25) NULL,
	[PrescriptionType] [nvarchar](5) NULL,
	[DrugSource] [nvarchar](5) NULL,
	[DrugID] [bigint] NULL,
	[PrescriptionNumber] [nvarchar](30) NULL,
	[PhysicianID] [bigint] NULL,
	[PrescribeDrugExpiryDate] [datetime] NULL,
	[TaskID] [bigint] NULL,
	[PrescriptionID] [bigint] NULL,
	[Direction] [nvarchar](500) NULL,
	[Qty] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PrimaryConsultant]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrimaryConsultant' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PrimaryConsultant] AS TABLE(
	[PrimaryConsultantID] [bigint] NULL,
	[PhysicianName] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PrintPolicy]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PrintPolicy' AND ss.name = N'dbo')
CREATE TYPE [dbo].[PrintPolicy] AS TABLE(
	[ID] [int] NOT NULL,
	[OrgAddressID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[Type] [nvarchar](100) NOT NULL,
	[Value] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ProductCategories]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ProductCategories' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ProductCategories] AS TABLE(
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](100) NULL,
	[OrgID] [int] NULL,
	[Description] [nvarchar](255) NULL,
	[OrgAddressID] [int] NULL,
	[ParentCategorieID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ProductEpisodeVisitMapping]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ProductEpisodeVisitMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ProductEpisodeVisitMapping] AS TABLE(
	[ProductVisitMapID] [bigint] NULL,
	[EpisodeVisitId] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[ProductType] [nvarchar](20) NULL,
	[Value] [int] NULL,
	[Guid] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ProductLocationMapping]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ProductLocationMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ProductLocationMapping] AS TABLE(
	[ProductLocationMappingID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[ReorderQuantity] [bigint] NULL,
	[OrgID] [int] NULL,
	[MaximumQuantity] [bigint] NULL,
	[IsIndentLocation] [int] NULL,
	[StockFrequency] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[QuotationMaster]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'QuotationMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[QuotationMaster] AS TABLE(
	[QuotationID] [bigint] NULL,
	[QuotationNo] [nvarchar](50) NULL,
	[ValidFrom] [datetime] NOT NULL,
	[ValidTo] [datetime] NOT NULL,
	[Comments] [nvarchar](250) NULL,
	[Status] [nvarchar](25) NULL,
	[SupplierID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[RaisePO]    Script Date: 6/25/2018 4:04:38 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RaisePO' AND ss.name = N'dbo')
CREATE TYPE [dbo].[RaisePO] AS TABLE(
	[ProductID] [bigint] NULL,
	[SupplierID] [int] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[UOMID] [int] NULL,
	[Unit] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[RaiseSUPO]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RaiseSUPO' AND ss.name = N'dbo')
CREATE TYPE [dbo].[RaiseSUPO] AS TABLE(
	[ProductID] [bigint] NULL,
	[SupplierID] [int] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[PDate] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[RateCardDiscount]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RateCardDiscount' AND ss.name = N'dbo')
CREATE TYPE [dbo].[RateCardDiscount] AS TABLE(
	[PolicyID] [bigint] NOT NULL,
	[FeeType] [nvarchar](50) NOT NULL,
	[CategoryCode] [nvarchar](50) NULL,
	[DiscountPercentage] [decimal](18, 2) NOT NULL,
	[DiscountType] [nvarchar](50) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[RateSubTypeMapping]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RateSubTypeMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[RateSubTypeMapping] AS TABLE(
	[Description] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[RateID] [int] NULL,
	[RateSubTypeID] [int] NULL,
	[TypeOfSubType] [nvarchar](50) NULL,
	[VisitSubTypeID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ReferingPhysicianDetails]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ReferingPhysicianDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ReferingPhysicianDetails] AS TABLE(
	[ReferingPhysicianID] [int] NULL DEFAULT (''),
	[PhysicianName] [nvarchar](100) NULL DEFAULT (''),
	[Qualification] [nvarchar](100) NULL DEFAULT (''),
	[OrganizationName] [nvarchar](100) NULL DEFAULT (''),
	[OrgID] [int] NULL DEFAULT (''),
	[Status] [nvarchar](20) NULL DEFAULT (''),
	[Salutation] [int] NULL DEFAULT (''),
	[LoginID] [bigint] NULL DEFAULT (''),
	[PhysicianCode] [nvarchar](20) NULL DEFAULT (''),
	[IsClient] [nchar](1) NULL DEFAULT (''),
	[IsActive] [nchar](1) NULL DEFAULT (''),
	[CreatedBy] [bigint] NULL DEFAULT (''),
	[CreatedAt] [datetime] NULL DEFAULT (''),
	[ModifiedBy] [bigint] NULL DEFAULT (''),
	[ModifiedAt] [datetime] NULL DEFAULT (''),
	[Gender] [nchar](1) NULL DEFAULT (''),
	[DOB] [nvarchar](10) NULL DEFAULT (''),
	[Age] [nvarchar](3) NULL DEFAULT (''),
	[RegistrationType] [nchar](1) NULL DEFAULT (''),
	[ParentReferingPhysicianID] [int] NULL DEFAULT (''),
	[IsMerged] [nchar](1) NULL DEFAULT (''),
	[DiscountLimit] [decimal](18, 2) NULL DEFAULT (''),
	[DiscountPeriod] [nvarchar](20) NULL DEFAULT (''),
	[DiscountValidFrom] [datetime] NULL DEFAULT (''),
	[DiscountValidTo] [datetime] NULL DEFAULT (''),
	[RefFeeCategoryid] [bigint] NULL DEFAULT (''),
	[HasReportingEmail] [bit] NULL DEFAULT (''),
	[HasReportingSms] [bit] NULL DEFAULT (''),
	[DesignationID] [bigint] NULL DEFAULT (''),
	[LoginName] [nvarchar](40) NULL DEFAULT (''),
	[Password] [nvarchar](40) NULL DEFAULT (''),
	[AddressTypeID] [int] NULL DEFAULT (''),
	[Address1] [nvarchar](100) NULL DEFAULT (''),
	[City] [nvarchar](40) NULL DEFAULT (''),
	[CountryID] [int] NULL DEFAULT (''),
	[StateID] [int] NULL DEFAULT (''),
	[EmailID] [nvarchar](40) NULL DEFAULT (''),
	[Phone] [nvarchar](20) NULL DEFAULT (''),
	[Mobile] [nvarchar](20) NULL DEFAULT (''),
	[IsCommunication] [nvarchar](1) NULL DEFAULT (''),
	[FaxNumber] [nvarchar](20) NULL DEFAULT (''),
	[ISDCode] [int] NULL DEFAULT ('')
)
GO
/****** Object:  UserDefinedTableType [dbo].[Referrals]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Referrals' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Referrals] AS TABLE(
	[ReferralID] [bigint] NOT NULL,
	[ReferralDetailsID] [bigint] NOT NULL,
	[ReferedByOrgID] [int] NOT NULL,
	[ReferedByVisitID] [bigint] NOT NULL,
	[ReferedToOrgID] [int] NULL,
	[ReferralVisitPurposeID] [int] NULL,
	[ReferralSpecialityID] [int] NULL,
	[ReferedToPhysicianID] [int] NULL,
	[ReferralStatus] [nvarchar](100) NULL,
	[ReferralNotes] [nvarchar](max) NULL,
	[ReferedToLocation] [bigint] NULL,
	[ReferedByLocation] [bigint] NULL,
	[AllowCaseSheet] [nchar](1) NULL,
	[ReferedToPhysicianName] [nvarchar](255) NULL,
	[ReferralSpecialityName] [nvarchar](255) NULL,
	[ResultID] [int] NULL,
	[ResultName] [nvarchar](255) NULL,
	[ResultTemplateType] [nvarchar](25) NULL,
	[ReferedToOrgName] [nvarchar](255) NULL,
	[ReferedByPhysicianID] [int] NULL,
	[ReferedByPhysicianName] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ReportPrintHistory]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'ReportPrintHistory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[ReportPrintHistory] AS TABLE(
	[AccessionNumber] [bigint] NOT NULL,
	[InvestigationID] [bigint] NOT NULL,
	[Status] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[RoomDetails]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RoomDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[RoomDetails] AS TABLE(
	[RoomID] [int] NULL,
	[RoomName] [nvarchar](200) NULL,
	[FloorID] [int] NULL,
	[FloorName] [nvarchar](150) NULL,
	[WardID] [int] NULL,
	[WardName] [nvarchar](150) NULL,
	[RoomTypeID] [int] NULL,
	[RoomTypeName] [nvarchar](150) NULL,
	[NoBeds] [int] NULL,
	[BedName] [nvarchar](50) NULL,
	[BuildingID] [int] NULL,
	[BuildingName] [nvarchar](150) NULL,
	[ID] [int] NULL,
	[Name] [nvarchar](150) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ISVariable] [nvarchar](50) NULL,
	[ISOptional] [nvarchar](50) NULL,
	[FeeID] [int] NULL,
	[RateID] [int] NULL,
	[FeelogicID] [nvarchar](10) NULL,
	[AllowSlotBooking] [nvarchar](5) NULL,
	[IsAnOT] [nvarchar](5) NULL,
	[NoRows] [int] NULL,
	[NoColumns] [int] NULL,
	[SampleGroupID] [bigint] NULL,
	[SampleCode] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[RoomFeeType]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'RoomFeeType' AND ss.name = N'dbo')
CREATE TYPE [dbo].[RoomFeeType] AS TABLE(
	[RFTValue] [bigint] NULL,
	[RFAmount] [decimal](18, 0) NULL,
	[ISVariable] [nchar](1) NULL,
	[ISOptional] [nchar](1) NULL,
	[RoomTypeFeeMappingID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SalesItemsMapping]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SalesItemsMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SalesItemsMapping] AS TABLE(
	[CategoryID] [int] NULL,
	[ProductID] [bigint] NULL,
	[CategoryName] [nvarchar](500) NULL,
	[ProductName] [nvarchar](500) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 6) NULL,
	[UOMID] [int] NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LSUnit] [nvarchar](20) NULL,
	[Description] [nvarchar](500) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[Providedby] [bigint] NULL,
	[Type] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NULL,
	[ID] [bigint] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](50) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](50) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 2) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[HasExpiryDate] [nchar](1) NULL,
	[HasBatchNo] [nchar](1) NULL,
	[HasUsage] [nchar](1) NULL,
	[UsageCount] [int] NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[InHandQuantity] [decimal](18, 2) NULL,
	[ExciseTax] [decimal](18, 2) NULL,
	[DiscOrEnhancePercent] [decimal](18, 2) NULL,
	[DiscOrEnhanceType] [nvarchar](10) NULL,
	[Remarks] [nvarchar](255) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[ReceivedOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[ReceivedOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](255) NULL,
	[PrescriptionNO] [nvarchar](30) NULL,
	[SalesOrderID] [bigint] NULL,
	[CustomerID] [int] NULL,
	[StockOutFlowID] [bigint] NULL,
	[StockReceivedID] [bigint] NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[DCNo] [nvarchar](100) NULL,
	[StockInHandID] [bigint] NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[CstTax] [decimal](18, 2) NULL,
	[CsTaxAmount] [decimal](18, 2) NULL,
	[CustomerLocationID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SampleBatchConflictDetails]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SampleBatchConflictDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SampleBatchConflictDetails] AS TABLE(
	[BatchID] [int] NOT NULL,
	[BatchNo] [nvarchar](50) NOT NULL,
	[SampleID] [int] NOT NULL,
	[BarcodeNumber] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SampleBatchTrackerDetails]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SampleBatchTrackerDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SampleBatchTrackerDetails] AS TABLE(
	[BatchID] [int] NOT NULL,
	[BatchNo] [nvarchar](50) NOT NULL,
	[SampleID] [int] NOT NULL,
	[PatientVisitID] [bigint] NULL,
	[BarcodeNumber] [nvarchar](250) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[BatchStatus] [nvarchar](50) NOT NULL,
	[SampleContainerID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SchedulesDescription]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SchedulesDescription' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SchedulesDescription] AS TABLE(
	[pResourceTemplateID] [bigint] NULL,
	[pScheduleID] [bigint] NULL,
	[pStart] [datetime] NULL,
	[pEnd] [datetime] NULL,
	[pTokenNumber] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SiteEpisodeVisitMapping]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SiteEpisodeVisitMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SiteEpisodeVisitMapping] AS TABLE(
	[SiteVisitMapID] [bigint] NULL,
	[EpisodeVisitId] [bigint] NULL,
	[SiteID] [bigint] NULL,
	[NoOfSubjects] [int] NULL,
	[Guid] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SpecialRateMaster]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SpecialRateMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SpecialRateMaster] AS TABLE(
	[InvID] [bigint] NULL,
	[InvType] [nvarchar](10) NULL,
	[OpAmount] [decimal](18, 2) NULL,
	[IpAmount] [decimal](18, 2) NULL,
	[ClientID] [bigint] NULL,
	[ReferenceType] [nvarchar](20) NULL,
	[ServiceID] [bigint] NULL,
	[SCode] [nvarchar](11) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SPLRateCard]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SPLRateCard' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SPLRateCard] AS TABLE(
	[RateCard] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage_LocationMaster]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage_LocationMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage_LocationMaster] AS TABLE(
	[OrgName] [nvarchar](100) NULL,
	[LocationName] [nvarchar](100) NULL,
	[LocationCode] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[Country] [nvarchar](30) NULL,
	[PostalCode] [nvarchar](30) NULL,
	[TransitTime] [int] NULL,
	[Mobile] [nvarchar](100) NULL,
	[LandLine] [nvarchar](100) NULL,
	[LocationType] [nvarchar](100) NULL,
	[Status] [nvarchar](100) NULL,
	[IsMappedClients] [nvarchar](3) NULL,
	[ClientCode] [nvarchar](30) NULL,
	[ClientName] [nvarchar](100) NULL,
	[IsDefault] [nvarchar](3) NULL,
	[Flag] [nvarchar](4) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage_Physician]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage_Physician' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage_Physician] AS TABLE(
	[SNO] [bigint] NULL,
	[PhysicianName] [nvarchar](100) NULL,
	[PhysicianCode] [nvarchar](100) NULL,
	[DOB] [datetime] NULL,
	[AGE] [nvarchar](100) NULL,
	[Sex] [nvarchar](100) NULL,
	[Qualification] [nvarchar](30) NULL,
	[Designation] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[Country] [nvarchar](100) NULL,
	[MobileNumber] [nvarchar](100) NULL,
	[Emailid] [nvarchar](100) NULL,
	[LandLineNo] [nvarchar](100) NULL,
	[FaxNo] [nvarchar](100) NULL,
	[ISCLIENT] [nchar](1) NULL,
	[DiscountLimit] [decimal](18, 2) NULL,
	[DiscountValidFrom] [datetime] NULL,
	[DiscountValidTo] [datetime] NULL,
	[HasReportingSms] [nchar](1) NULL,
	[HasReportingEmail] [nchar](1) NULL,
	[ReferalHospitalName] [nvarchar](100) NULL,
	[ReferalHospitalCode] [nvarchar](100) NULL,
	[Flag] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage_User_Template]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage_User_Template' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage_User_Template] AS TABLE(
	[LoginName] [nvarchar](100) NULL,
	[UserName] [nvarchar](100) NULL,
	[SurName] [nvarchar](100) NULL,
	[DOB] [datetime] NULL,
	[Sex] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Salutation] [nvarchar](100) NULL,
	[Status] [nvarchar](30) NULL,
	[MaritalStatus] [nvarchar](30) NULL,
	[Qualification] [nvarchar](30) NULL,
	[Role] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_01_TESTMASTER]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_01_TESTMASTER' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage2_MHL_T_01_TESTMASTER] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[TCODE] [nvarchar](255) NULL,
	[EDOSCode] [nvarchar](255) NULL,
	[TestName] [nvarchar](max) NULL,
	[TEST_ABBREVATION] [nvarchar](max) NULL,
	[DISPLAY_NAME] [nvarchar](max) NULL,
	[DeptName] [nvarchar](max) NULL,
	[SECTION_NAME] [nvarchar](max) NULL,
	[TEST_GROUP] [nvarchar](255) NULL,
	[TEST_PARENT] [nvarchar](255) NULL,
	[Values_Type] [nvarchar](255) NULL,
	[Orderable] [nvarchar](255) NULL,
	[SEQUENCE_No] [nvarchar](255) NULL,
	[INPUT_FORMAT] [nvarchar](255) NULL,
	[Sample_Type] [nvarchar](max) NULL,
	[Method] [nvarchar](max) NULL,
	[Container] [nvarchar](max) NULL,
	[Units] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[PROCESSING_LOCATION] [nvarchar](255) NULL,
	[Decimal_Places] [nvarchar](255) NULL,
	[Classification] [nvarchar](255) NULL,
	[IS_MACHINE_INTERFACED] [nvarchar](255) NULL,
	[REPEATABLE] [nvarchar](255) NULL,
	[TEST_GENDER] [nvarchar](255) NULL,
	[IS_NABL] [nvarchar](255) NULL,
	[IS_CAP] [nvarchar](255) NULL,
	[IS_STAT] [nvarchar](255) NULL,
	[IS_SMS] [nvarchar](255) NULL,
	[IS_STATISTICAL] [nvarchar](255) NULL,
	[AUTORIZATION] [nvarchar](255) NULL,
	[CO_AUTHORIZATION] [nvarchar](255) NULL,
	[TAT_POLICY] [nvarchar](255) NULL,
	[REFERENCE_RANGE] [nvarchar](max) NULL,
	[CRITICAL_RANGE] [nvarchar](255) NULL,
	[IS_CRITICAL_ALERT] [nvarchar](255) NULL,
	[PANIC_RANGE] [nvarchar](max) NULL,
	[AUTO_AUTHORIZATION_RANGE] [nvarchar](255) NULL,
	[ACCEPTABLE_RANGE] [nvarchar](255) NULL,
	[TEST_EMERGENCY_STAGE] [nvarchar](255) NULL,
	[IS_TEST_HISTORY] [nvarchar](255) NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[DISCOUNT_CATEGORY] [nvarchar](255) NULL,
	[TFORMAT] [nvarchar](255) NULL,
	[SPLFORMAT] [nvarchar](255) NULL,
	[TESTTYPE] [nvarchar](255) NULL,
	[CHILDOF] [nvarchar](255) NULL,
	[LOD] [nvarchar](255) NULL,
	[NOOFSAMPLES] [nvarchar](255) NULL,
	[OUTPUT_FORMAT] [nvarchar](255) NULL,
	[PCTS] [nvarchar](255) NULL,
	[AttType] [nvarchar](255) NULL,
	[CutOffTimeValue] [nvarchar](255) NULL,
	[CutOffTimeType] [nvarchar](255) NULL,
	[IsActive] [nvarchar](255) NULL,
	[IsNonReportable] [nvarchar](255) NULL,
	[PrintSeparately] [nvarchar](255) NULL,
	[IsParameter] [nvarchar](255) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[DeptID] [nvarchar](255) NULL,
	[SampleCode] [nvarchar](255) NULL,
	[MethodID] [nvarchar](255) NULL,
	[SampleContainerID] [nvarchar](255) NULL,
	[HeaderId] [nvarchar](255) NULL,
	[AutoAuthorizationId] [nvarchar](255) NULL,
	[UOMID] [nvarchar](255) NULL,
	[Processing_AddressID] [nvarchar](255) NULL,
	[ProtocolGroup] [nvarchar](100) NULL,
	[ProtocolGroupID] [int] NULL,
	[I_Tcode] [nvarchar](100) NULL,
	[Billing_Name] [nvarchar](100) NULL,
	[flag] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_02_GROUP_MASTER]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_02_GROUP_MASTER' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage2_MHL_T_02_GROUP_MASTER] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[GROUPNAME] [nvarchar](255) NULL,
	[METRO_COMBINE_CODE] [nvarchar](255) NULL,
	[EDOSCODE] [nvarchar](255) NULL,
	[DISPLAY_NAME] [nvarchar](255) NULL,
	[ABBREVATION] [nvarchar](255) NULL,
	[IS_ORDERABLE] [nvarchar](255) NULL,
	[CLASSIFICATION] [nvarchar](255) NULL,
	[IS_NABL] [nvarchar](255) NULL,
	[IS_CAP] [nvarchar](255) NULL,
	[IS_STAT] [nvarchar](255) NULL,
	[TAT_POLICY] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[ValidationText] [nvarchar](max) NULL,
	[ValidationRule] [nvarchar](max) NULL,
	[IsDiscountable] [nvarchar](255) NULL,
	[IsServicetaxable] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[CutOffTimeValue] [nvarchar](255) NULL,
	[CutOffTimeType] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[HasHistory] [nvarchar](255) NULL,
	[Remarks] [nvarchar](255) NULL,
	[PrintSeparately] [nvarchar](255) NULL,
	[Gender] [nvarchar](255) NULL,
	[groupinterpretation] [nvarchar](max) NULL,
	[Issummaryworklist] [nvarchar](255) NULL,
	[IsSpecialFormat] [nvarchar](255) NULL,
	[Groupid] [nvarchar](255) NULL,
	[ProtocolGroup] [nvarchar](100) NULL,
	[ProtocolGroupID] [int] NULL,
	[I_Tcode] [nvarchar](100) NULL,
	[Billing_Name] [nvarchar](100) NULL,
	[flag] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_03_Package_Master]    Script Date: 6/25/2018 4:04:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_03_Package_Master' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage2_MHL_T_03_Package_Master] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[PACKAGE_NAME] [nvarchar](max) NULL,
	[METROLAB_PROFILECODE] [nvarchar](255) NULL,
	[DOSCODE] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[TestName] [nvarchar](255) NULL,
	[TEST_SEQUENCE_NO] [nvarchar](255) NULL,
	[Test_Name] [nvarchar](255) NULL,
	[DISPLAY_NAME] [nvarchar](max) NULL,
	[TAT_POLICY] [nvarchar](255) NULL,
	[IS_ORDERABLE] [nvarchar](255) NULL,
	[CLASSIFICATION] [nvarchar](255) NULL,
	[IS_NABL] [nvarchar](255) NULL,
	[IS_CAP] [nvarchar](255) NULL,
	[IS_STAT] [nvarchar](255) NULL,
	[ValidationText] [nvarchar](max) NULL,
	[ValidationRule] [nvarchar](max) NULL,
	[IsDiscountable] [nvarchar](255) NULL,
	[IsServicetaxable] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[CutOffTimeValue] [nvarchar](255) NULL,
	[CutOffTimeType] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[HasHistory] [nvarchar](255) NULL,
	[Remarks] [nvarchar](255) NULL,
	[PrintSeparately] [nvarchar](255) NULL,
	[Gender] [nvarchar](255) NULL,
	[groupinterpretation] [nvarchar](max) NULL,
	[Issummaryworklist] [nvarchar](255) NULL,
	[IsSpecialFormat] [nvarchar](255) NULL,
	[ABBREVATION] [nvarchar](255) NULL,
	[Groupid] [nvarchar](255) NULL,
	[ProtocolGroup] [nvarchar](100) NULL,
	[ProtocolGroupID] [int] NULL,
	[I_Tcode] [nvarchar](30) NULL,
	[Billing_Name] [nvarchar](100) NULL,
	[Flag] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_04_GROUP_TESTS]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_04_GROUP_TESTS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage2_MHL_T_04_GROUP_TESTS] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[GROUP_CODE] [nvarchar](255) NULL,
	[TEST_CODE] [nvarchar](255) NULL,
	[TEST_NAME] [nvarchar](255) NULL,
	[TEST_SEQUENCE_NO] [float] NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[ID] [int] NULL,
	[flag] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Stage2_MHL_T_05_PACKAGE_TESTS]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Stage2_MHL_T_05_PACKAGE_TESTS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[Stage2_MHL_T_05_PACKAGE_TESTS] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[PACKAGE_CODE] [nvarchar](255) NULL,
	[TEST_CODE] [nvarchar](255) NULL,
	[TEST_NAME] [nvarchar](255) NULL,
	[TEST_SEQUENCE_NO] [float] NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[ID] [nvarchar](255) NULL,
	[Flag] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[StockReceivedBarcodeDetailsUDT]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'StockReceivedBarcodeDetailsUDT' AND ss.name = N'dbo')
CREATE TYPE [dbo].[StockReceivedBarcodeDetailsUDT] AS TABLE(
	[StockReceivedBarcodeDetailsID] [bigint] NULL,
	[StockReceivedBarcodeID] [bigint] NULL,
	[ReceivedUniqueNumber] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[ParentBarCode] [nvarchar](100) NULL,
	[BarcodeNo] [nvarchar](100) NULL,
	[Status] [nvarchar](50) NULL,
	[RecUnit] [nvarchar](50) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[IsUniqueBarcode] [nvarchar](10) NULL,
	[ActionType] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SurgeryBillingDetails]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SurgeryBillingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SurgeryBillingDetails] AS TABLE(
	[SurgeryBillingDetailsID] [bigint] NULL,
	[SurgeryBillingID] [bigint] NULL,
	[PhysicianID] [bigint] NULL,
	[Description] [nvarchar](50) NULL,
	[Type] [nvarchar](5) NULL,
	[Value] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SurgeryBillingMaster]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SurgeryBillingMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SurgeryBillingMaster] AS TABLE(
	[SurgeryBillingID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SurgeryID] [bigint] NULL,
	[TreatmentName] [nvarchar](100) NULL,
	[SurgicalFee] [decimal](18, 2) NULL,
	[ChiefSurgeonID] [bigint] NULL,
	[ChiefSurgeonName] [nvarchar](255) NULL,
	[ChiefSurgeonFee] [decimal](18, 2) NULL,
	[OTCharges] [decimal](18, 2) NULL,
	[RoomCharges] [decimal](18, 2) NULL,
	[Consumables] [decimal](18, 2) NULL,
	[ProsthesisFee] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SurgicalDetail]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'SurgicalDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[SurgicalDetail] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[SurgeryID] [int] NULL,
	[SurgeryName] [nvarchar](100) NULL,
	[ParentID] [int] NULL,
	[ParentName] [nvarchar](100) NULL,
	[TreatmentPlanDate] [datetime] NULL,
	[HospitalName] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TaskActionOrgMapping]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TaskActionOrgMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TaskActionOrgMapping] AS TABLE(
	[TaskActionID] [int] NULL,
	[RoleID] [bigint] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TaskDetails]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TaskDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TaskDetails] AS TABLE(
	[TaskID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[TaskActionID] [int] NULL,
	[AssignedTo] [bigint] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TestCodes]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TestCodes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TestCodes] AS TABLE(
	[Tcode] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TestMaster]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TestMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TestMaster] AS TABLE(
	[OrgID] [int] NULL,
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [nvarchar](255) NULL,
	[DisplayText] [nvarchar](255) NULL,
	[BillingName] [nvarchar](255) NULL,
	[DeptID] [int] NULL,
	[SampleCode] [int] NULL,
	[MethodID] [bigint] NULL,
	[PrincipleID] [bigint] NULL,
	[Interpretation] [nvarchar](max) NULL,
	[SampleContainerID] [int] NULL,
	[ProcessingAddressID] [int] NULL,
	[AutoApproveLoginID] [bigint] NULL,
	[ResultValueType] [nvarchar](100) NULL,
	[CPT] [decimal](10, 2) NULL,
	[CPRT] [decimal](10, 2) NULL,
	[DecimalPlaces] [nvarchar](10) NULL,
	[CutOffTimeValue] [int] NULL,
	[CutOffTimeType] [nvarchar](10) NULL,
	[Classification] [nvarchar](250) NULL,
	[SubCategory] [nvarchar](150) NULL,
	[IsOrderable] [nchar](1) NULL,
	[QCData] [nchar](1) NULL,
	[IsInterfaced] [nchar](1) NULL,
	[IsSMS] [nchar](1) NULL,
	[IsServiceTax] [nchar](1) NULL,
	[IsNABL] [nchar](1) NULL,
	[IsCAP] [nchar](1) NULL,
	[IsDiscountable] [nchar](1) NULL,
	[IsRepeatable] [nchar](1) NULL,
	[IsSTAT] [nchar](1) NULL,
	[IsActive] [nchar](1) NULL,
	[Category] [nvarchar](100) NULL,
	[Gender] [nvarchar](50) NULL,
	[IsNonReportable] [nchar](1) NULL,
	[PrintSeparately] [nchar](1) NULL,
	[HeaderID] [bigint] NULL,
	[GetWorkList] [nvarchar](50) NULL,
	[IsTATrandom] [smallint] NULL,
	[ProtocalGroupID] [int] NULL,
	[ReferenceRangeString] [nvarchar](1000) NULL,
	[IsSynoptic] [nvarchar](10) NULL,
	[IsFieldTest] [nchar](1) NULL,
	[PreAnalyticalConditionId] [int] NULL,
	[PostAnalyticalConditionId] [int] NULL,
	[IsSensitiveTest] [nchar](1) NULL,
	[OutputGroupingCode][nvarchar](50) NULL,
	[IsAutoCertification] [nvarchar](100) NULL,
	[ShowGroupInstruction] [bit]
)
GO
/****** Object:  UserDefinedTableType [dbo].[TransBillingDetails]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TransBillingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TransBillingDetails] AS TABLE(
	[FeeId] [int] NULL,
	[FeeType] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Unit] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Status] [nvarchar](30) NULL,
	[DiscPercent] [decimal](18, 2) NULL,
	[IsReimburse] [nvarchar](5) NULL,
	[RefPhysId] [bigint] NULL,
	[RefPhysName] [nvarchar](100) NULL,
	[IsTaxable] [nchar](5) NULL,
	[PerPhyName] [nvarchar](30) NULL,
	[PerPhyID] [bigint] NULL,
	[DiscEnhanceType] [nvarchar](20) NULL,
	[Remarks] [nvarchar](255) NULL,
	[DiscAmount] [decimal](18, 2) NULL,
	[RateId] [bigint] NULL,
	[IsDiscountable] [char](1) NULL,
	[PatientId] [bigint] NULL,
	[DiscEnhanceRemarks] [nvarchar](255) NULL,
	[DiscEnhancePercent] [decimal](18, 2) NULL,
	[IsStat] [char](1) NULL,
	[ReferenceType] [nvarchar](255) NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[VisitId] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[SpecialityID] [bigint] NULL,
	[ReceiptNo] [nvarchar](30) NULL,
	[DiscountReason] [nvarchar](255) NULL,
	[StockReceivedID] [bigint] NULL,
	[ProductReceivedDetailsID] [bigint] NULL,
	[ReceivedUniqueNumber] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TRFfilemanager]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TRFfilemanager' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TRFfilemanager] AS TABLE(
	[FileID] [bigint] NULL,
	[FileUrl] [nvarchar](500) NULL,
	[FileName] [nvarchar](500) NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[IdentifyingID] [bigint] NULL,
	[IdentifyingType] [nvarchar](20) NULL,
	[FilePath] [nvarchar](300) NULL,
	[Createdby] [bigint] NULL,
	[Createdat ] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TrustedOrgActions]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TrustedOrgActions' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TrustedOrgActions] AS TABLE(
	[LoggedOrgID] [int] NULL,
	[SharingOrgID] [int] NULL,
	[IdentifyingType] [nvarchar](30) NULL,
	[IdentifyingActionID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[DummyString] [nvarchar](300) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TT_UDTCampDetail]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TT_UDTCampDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TT_UDTCampDetail] AS TABLE(
	[ID] [int] NULL,
	[OrgName] [nvarchar](60) NULL,
	[SlNo] [int] NULL,
	[PDate] [datetime] NULL,
	[SDate] [datetime] NULL,
	[SCollectedBy] [nvarchar](500) NULL,
	[PatID] [nvarchar](200) NULL,
	[Title] [nvarchar](200) NULL,
	[Name] [nvarchar](1000) NULL,
	[Age] [nvarchar](5) NULL,
	[AgeType] [nvarchar](20) NULL,
	[Sex] [nvarchar](20) NULL,
	[Location] [nvarchar](1000) NULL,
	[Doctor] [nvarchar](1000) NULL,
	[RefHospital] [nvarchar](1000) NULL,
	[Priority] [nvarchar](200) NULL,
	[DispatchMode] [nvarchar](200) NULL,
	[TESTSREQUESTED] [nvarchar](max) NULL,
	[CHARGED] [decimal](19, 2) NULL,
	[AmountPaid] [decimal](19, 2) NULL,
	[AmountDisocunt] [decimal](19, 2) NULL,
	[DisocuntReason] [nvarchar](max) NULL,
	[DiscountAuthorisedBy] [nvarchar](500) NULL,
	[History] [varchar](max) NULL,
	[Remarks] [varchar](max) NULL,
	[MobileNo] [nvarchar](40) NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[ClientCode] [nvarchar](200) NULL,
	[EmailID] [nvarchar](200) NULL,
	[ErrorStatus] [bit] NOT NULL,
	[ErrorDesc] [nvarchar](4000) NULL,
	[ValidateData] [nvarchar](400) NULL,
	[ClientID] [bigint] NULL,
	[LOCATIONID] [bigint] NULL,
	[TitleID] [bigint] NULL,
	[DoctorID] [bigint] NULL,
	[RefHospitalID] [bigint] NULL,
	[TESTCODE] [nvarchar](max) NULL,
	[SCollectedByID] [bigint] NULL,
	[PriorityID] [int] NULL,
	[IsClientPatient] [varchar](6) NULL,
	[CreatedbyId] [bigint] NULL,
	[RateId] [bigint] NULL,
	[TestType] [varchar](30) NULL,
	[FeeId] [varchar](15) NULL,
	[IsDiscountable] [varchar](3) NULL,
	[DueAmount] [decimal](18, 2) NULL,
	[OrgId] [int] NULL,
	[DiscountAuthorisedByID] [bigint] NULL,
	[HasHealthCoupon] [varchar](3) NULL,
	[MyCardActiveDays] [nvarchar](30) NULL,
	[IsCreditBill] [varchar](15) NULL,
	[CampId] [int] NULL,
	[PatientNumber] [nvarchar](60) NULL,
	[DOB] [datetime] NULL,
	[HealthHubID] [varchar](100) NULL,
	[EmployeeID] [varchar](100) NULL,
	[SourceType] [varchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UATAccountsImpactDetails]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UATAccountsImpactDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UATAccountsImpactDetails] AS TABLE(
	[EdtMasterBillID] [bigint] NULL,
	[OrgID] [int] NULL,
	[GrossBillValue] [decimal](18, 2) NULL DEFAULT ((0)),
	[Discount] [decimal](18, 2) NULL DEFAULT ((0)),
	[DiscountPercentage] [decimal](18, 2) NULL DEFAULT ((0)),
	[DiscountReason] [nvarchar](255) NULL DEFAULT (''),
	[Tax] [decimal](18, 2) NULL DEFAULT ((0)),
	[ServiceCharge] [decimal](18, 2) NULL DEFAULT ((0)),
	[RoundOffAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[NetValue] [decimal](18, 2) NULL DEFAULT ((0)),
	[PreviousReceivedAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[ReceivedAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[PreviousRefundAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[RefundAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[Due] [decimal](18, 2) NULL DEFAULT ((0)),
	[MedicalAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[NonMedicalAmount] [decimal](18, 2) NULL DEFAULT ((0)),
	[EdtDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[RoleID] [int] NULL DEFAULT ((0)),
	[DeptID] [int] NULL DEFAULT ((0))
)
GO
/****** Object:  UserDefinedTableType [dbo].[UATProductsAttributesDetails]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UATProductsAttributesDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UATProductsAttributesDetails] AS TABLE(
	[DetailsID] [bigint] NULL,
	[AttributeID] [int] NULL,
	[AttributesKey] [nvarchar](100) NULL,
	[AttributesValue] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UATTaxCategoriesMapping]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UATTaxCategoriesMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UATTaxCategoriesMapping] AS TABLE(
	[TaxCategoriesMappingID] [int] NULL,
	[CategoriesID] [int] NULL,
	[TaxTypeID] [int] NULL,
	[StateID] [bigint] NULL,
	[Tax] [decimal](18, 2) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[Status] [bit] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[OutputTaxTypeID] [int] NULL,
	[OutputTax] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[uddInsertGeneralAdvice]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'uddInsertGeneralAdvice' AND ss.name = N'dbo')
CREATE TYPE [dbo].[uddInsertGeneralAdvice] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[Description] [nvarchar](250) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDDinsertSampleTrack]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDinsertSampleTrack' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDDinsertSampleTrack] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[InvSampleStatusID] [int] NULL,
	[CurrentOrgID] [int] NULL,
	[DeptID] [int] NULL,
	[Reason] [nvarchar](500) NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
	[OrgID] [int] NULL,
	[CollectedIn] [int] NULL,
	[Remarks] [nvarchar](500) NULL,
	[SampleVolume] [int] NULL,
	[SampleUnit] [nvarchar](500) NULL,
	[ReasonID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDDInvDeptSamples]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDInvDeptSamples' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDDInvDeptSamples] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[DeptID] [int] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDDPatientInvSample]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientInvSample' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDDPatientInvSample] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[BarcodeNumber] [nvarchar](500) NULL,
	[SampleCode] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleContainerID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDDPatientInvSampleTransfer]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientInvSampleTransfer' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDDPatientInvSampleTransfer] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[OrgID] [int] NULL,
	[ModifiedBy] [bigint] NULL,
	[RecSampleLocID] [int] NULL,
	[UID] [nvarchar](250) NULL,
	[InvestigationID] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[Type] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDDPatientoneInvSampleTransfer]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientoneInvSampleTransfer' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDDPatientoneInvSampleTransfer] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[OrgID] [int] NULL,
	[ModifiedBy] [bigint] NULL,
	[RecSampleLocID] [int] NULL,
	[UID] [nvarchar](250) NULL,
	[InvestigationID] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[Type] [nvarchar](50) NULL,
	[IsIntegrationTest] [tinyint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDPatientAllergies]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDPatientAllergies' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDPatientAllergies] AS TABLE(
	[PatientID] [bigint] NULL,
	[AllergyID] [int] NULL,
	[AllergyName] [nvarchar](40) NULL,
	[AllergyType] [nvarchar](40) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Batchtimings]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Batchtimings' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Batchtimings] AS TABLE(
	[Batchstarttime] [time](7) NULL,
	[Cutofftime] [time](7) NULL,
	[Cutoffintervalvalue] [smallint] NULL,
	[Cutoffintervaltype] [char](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientCredit]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientCredit' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClientCredit] AS TABLE(
	[CreditID] [bigint] NULL,
	[CreditDate] [datetime] NULL,
	[OrgID] [int] NULL,
	[Category] [nvarchar](10) NULL,
	[SourceCode] [nvarchar](50) NULL,
	[SubSourceCode] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[BarCode] [nvarchar](20) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Remarks] [nvarchar](255) NULL,
	[Status] [nvarchar](15) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientCreditDebit]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientCreditDebit' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClientCreditDebit] AS TABLE(
	[Id] [bigint] NULL,
	[Date] [datetime] NULL,
	[OrgID] [int] NULL,
	[Category] [nvarchar](10) NULL,
	[SourceCode] [nvarchar](50) NULL,
	[SubSourceCode] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[BarCode] [nvarchar](20) NULL,
	[Remarks] [nvarchar](255) NULL,
	[Status] [nvarchar](15) NULL,
	[ClientName] [nvarchar](100) NULL,
	[ClientCode] [nvarchar](50) NULL,
	[InCharge] [nvarchar](50) NULL,
	[Address1] [nvarchar](50) NULL,
	[Address2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Pincode] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[Country] [nvarchar](20) NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
	[Count] [int] NULL,
	[Type] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientDebit]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientDebit' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClientDebit] AS TABLE(
	[DebitID] [bigint] NULL,
	[DebitDate] [datetime] NULL,
	[OrgID] [int] NULL,
	[Category] [nvarchar](10) NULL,
	[SourceCode] [nvarchar](50) NULL,
	[SubSourceCode] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[BarCode] [nvarchar](20) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Remarks] [nvarchar](255) NULL,
	[Status] [nvarchar](15) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientReceipt]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientReceipt' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClientReceipt] AS TABLE(
	[ReceiptID] [bigint] NULL,
	[ReceiptDate] [datetime] NULL,
	[OrgID] [int] NULL,
	[SourceCode] [varchar](50) NULL,
	[SubSourceCode] [varchar](50) NULL,
	[Amount] [decimal](18, 3) NOT NULL,
	[Mode] [varchar](15) NULL,
	[ChequeNo] [varchar](50) NULL,
	[ChequeDate] [datetime] NULL,
	[BankCode] [varchar](100) NULL,
	[BankName] [varchar](100) NULL,
	[AccCode] [varchar](50) NULL,
	[Remarks] [varchar](255) NULL,
	[DepositedBy] [varchar](50) NULL,
	[ResponseCode] [varchar](5) NULL,
	[ResponseMsg] [varchar](50) NULL,
	[PaymentReceiptNo] [varchar](30) NULL,
	[TransactionID] [varchar](30) NULL,
	[AuthIDCode] [varchar](30) NULL,
	[Status] [varchar](15) NULL,
	[PaymentType] [varchar](20) NULL,
	[ManualRemarks] [varchar](200) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[UploadedImages] [varchar](200) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClientReceiptDetail]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClientReceiptDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClientReceiptDetail] AS TABLE(
	[Id] [bigint] NULL,
	[Date] [datetime] NULL,
	[OrgID] [int] NULL,
	[SourceCode] [nvarchar](50) NULL,
	[SubSourceCode] [nvarchar](50) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Mode] [nvarchar](15) NULL,
	[ChequeNo] [nvarchar](50) NULL,
	[ChequeDate] [datetime] NULL,
	[BankCode] [nvarchar](100) NULL,
	[BankName] [nvarchar](100) NULL,
	[AccCode] [nvarchar](50) NULL,
	[Remarks] [nvarchar](255) NULL,
	[DepositedBy] [nvarchar](50) NULL,
	[ResponseCode] [nvarchar](5) NULL,
	[ResponseMsg] [nvarchar](50) NULL,
	[PaymentReceiptNo] [nvarchar](30) NULL,
	[TransactionID] [nvarchar](30) NULL,
	[AuthIDCode] [nvarchar](30) NULL,
	[Status] [nvarchar](15) NULL,
	[ClientName] [nvarchar](100) NULL,
	[ClientCode] [nvarchar](50) NULL,
	[InCharge] [nvarchar](50) NULL,
	[Address1] [nvarchar](50) NULL,
	[Address2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Pincode] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[Country] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Category] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClinicalHistoryMapping]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClinicalHistoryMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClinicalHistoryMapping] AS TABLE(
	[InvMedMappingID] [bigint] NULL,
	[InvID] [bigint] NULL,
	[MedicalDetailID] [int] NULL,
	[MedicalDetailType] [nvarchar](50) NULL,
	[MeanTime] [decimal](18, 0) NULL,
	[IsInternal] [nvarchar](50) NULL,
	[IsMandatory] [char](1) NULL,
	[InvType] [nvarchar](50) NULL,
	[IsActive] [char](1) NULL,
	[HistorySequence] [int] NULL,
	[OperationType] [nvarchar](50) NULL,
	[OrgId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ClinicalHistoryMaster]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ClinicalHistoryMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ClinicalHistoryMaster] AS TABLE(
	[HistoryID] [int] NULL,
	[HistoryName] [nvarchar](500) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
	[HistoryCode] [nvarchar](500) NULL,
	[ControlType] [nvarchar](50) NULL,
	[IsActive] [char](1) NULL,
	[OperationType] [nvarchar](50) NULL,
	[OrgId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Context]    Script Date: 6/25/2018 4:04:40 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Context' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Context] AS TABLE(
	[OrgID] [bigint] NULL,
	[OrgName] [nvarchar](200) NULL,
	[LogoPath] [nvarchar](50) NULL,
	[OrgAddressID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[RoleName] [nvarchar](50) NULL,
	[UserID] [bigint] NULL,
	[LoginID] [bigint] NULL,
	[LoginName] [nvarchar](50) NULL,
	[Age] [nvarchar](20) NULL,
	[LocationID] [bigint] NULL,
	[PharmacyLocationID] [bigint] NULL,
	[IsTrustedOrg] [nchar](1) NULL,
	[BaseCurrency] [nvarchar](10) NULL,
	[CurrencyFormat] [nvarchar](30) NULL,
	[ThemeID] [bigint] NULL,
	[CountryID] [smallint] NULL,
	[StateID] [smallint] NULL,
	[LanguageCode] [nvarchar](5) NULL,
	[PageID] [bigint] NULL,
	[SessionID] [nvarchar](200) NULL,
	[DepartmentName] [nvarchar](255) NULL,
	[AdditionalInfo] [nvarchar](max) NULL,
	[DepartmentCode] [nvarchar](30) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_DeviceErrorFlag]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_DeviceErrorFlag' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_DeviceErrorFlag] AS TABLE(
	[InstrumentId] [bigint] NULL,
	[ProductCode] [nvarchar](50) NULL,
	[InstrumentName] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[ErrorFlagCode] [nvarchar](50) NULL,
	[ErrorDesc] [nvarchar](250) NULL,
	[ErrorFlagResult] [nvarchar](50) NULL,
	[OperationType] [nvarchar](50) NULL,
	[IsActive] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_DocPayout]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_DocPayout' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_DocPayout] AS TABLE(
	[RefPhyid] [int] NULL,
	[Outstanding] [decimal](18, 2) NULL,
	[BillAmount] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Netamount] [decimal](18, 2) NULL,
	[Payableamount] [decimal](18, 2) NULL,
	[Payamount] [decimal](18, 2) NULL,
	[Paystatus] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Finalbillid]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Finalbillid' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Finalbillid] AS TABLE(
	[Finalbillid] [bigint] NULL,
	[RefPhyid] [int] NULL,
	[remarks] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_InputDept]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_InputDept' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_InputDept] AS TABLE(
	[DeptID] [bigint] NULL,
	[DeptCode] [nvarchar](50) NULL,
	[VisitType] [int] NULL,
	[OrgAddressID] [bigint] NULL,
	[RefID] [bigint] NULL,
	[RefType] [nvarchar](256) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_LedgerInvoiceDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_LedgerInvoiceDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_LedgerInvoiceDetails] AS TABLE(
	[ClientCode] [varchar](50) NULL,
	[ClientName] [varchar](50) NULL,
	[OrgID] [bigint] NULL,
	[InvoiceNumber] [varchar](50) NULL,
	[InvoiceId] [bigint] NULL,
	[ClientId] [bigint] NULL,
	[BillNumber] [varchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[InvoiceDate] [datetime] NULL,
	[FromDate] [varchar](50) NULL,
	[ToDate] [varchar](50) NULL,
	[ReceivedAmt] [decimal](18, 3) NULL,
	[Status] [varchar](50) NULL,
	[NetValue] [decimal](18, 3) NULL,
	[ContactPerson] [varchar](100) NULL,
	[CreditLimit] [decimal](18, 3) NULL,
	[CreditID] [bigint] NULL,
	[CreditDate] [datetime] NULL,
	[Narration] [varchar](100) NULL,
	[Remarks] [varchar](100) NULL,
	[DebitID] [bigint] NULL,
	[DebitDate] [datetime] NULL,
	[Address] [varchar](50) NULL,
	[Total] [int] NULL,
	[BillDate] [datetime] NULL,
	[Amount] [decimal](18, 3) NULL,
	[BillId] [bigint] NULL,
	[Name] [varchar](100) NULL,
	[Age] [varchar](50) NULL,
	[Test] [varchar](70) NULL,
	[Barcode] [varchar](30) NULL,
	[InvoiceDetailsID] [bigint] NULL,
	[PaymentMode] [varchar](50) NULL,
	[CurrencyCode] [varchar](50) NULL,
	[AdvanceDetailID] [decimal](18, 3) NULL,
	[City] [varchar](50) NULL,
	[PaymentType] [varchar](50) NULL,
	[M1Pending] [decimal](18, 3) NULL,
	[M2Pending] [decimal](18, 3) NULL,
	[M3Pending] [decimal](18, 3) NULL,
	[M4Pending] [decimal](18, 3) NULL,
	[TotalPending] [decimal](18, 3) NULL,
	[TotalAmount] [varchar](50) NULL,
	[CR] [varchar](100) NULL,
	[DR] [varchar](100) NULL,
	[DiscountPercentage] [decimal](18, 3) NULL,
	[DiscountAmount] [decimal](18, 3) NULL,
	[ActualAmount] [decimal](18, 3) NULL,
	[Description] [varchar](250) NULL,
	[TotalAmt] [decimal](18, 3) NULL,
	[TotalAdvanceAmount] [decimal](18, 3) NULL,
	[UsedAdvanceAmount] [decimal](18, 3) NULL,
	[RemainingAdvanceAmount] [decimal](18, 3) NULL,
	[IsAdvanceUsed] [varchar](50) NULL,
	[IsSucceedTransaction] [varchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_PatientHistoryExt]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_PatientHistoryExt' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_PatientHistoryExt] AS TABLE(
	[HistoryExtID] [bigint] NULL,
	[DetailHistory] [nvarchar](max) NULL,
	[PatientVisitId] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Remarks] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_PlanAndSchedule_QMS]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_PlanAndSchedule_QMS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_PlanAndSchedule_QMS] AS TABLE(
	[PlanScheduleID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[EventType] [int] NULL,
	[EventTypeCode] [nvarchar](10) NULL,
	[EventName] [nvarchar](50) NULL,
	[FromDate] [datetime] NULL,
	[Todate] [datetime] NULL,
	[AuditScope] [nvarchar](256) NULL,
	[AuditCriteria] [varchar](256) NULL,
	[Venue] [nvarchar](100) NULL,
	[Topic] [nvarchar](255) NULL,
	[Agenda] [nvarchar](255) NULL,
	[ProgramType] [nvarchar](100) NULL,
	[DeptID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[createdAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Location] [int] NULL,
	[Status] [nvarchar](30) NULL,
	[ParicipantID] [bigint] NULL,
	[UserID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[Files] [varchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ProductSupplierDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ProductSupplierDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ProductSupplierDetails] AS TABLE(
	[ProductID] [bigint] NULL,
	[SupplierID] [bigint] NULL,
	[OrgId] [int] NULL,
	[OrgAddressId] [int] NULL,
	[CategoryID] [int] NULL,
	[CategoryName] [varchar](500) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 6) NULL,
	[Unit] [varchar](20) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingUnit] [varchar](50) NULL,
	[PurchaseTax] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ProductUOM]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_ProductUOM' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_ProductUOM] AS TABLE(
	[ProductUOMID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[UOMID] [int] NULL,
	[UOMCode] [nvarchar](100) NULL,
	[ConvesionQty] [decimal](18, 2) NULL,
	[IsBaseunit] [bit] NULL,
	[Action] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_SampleSchedule]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_SampleSchedule' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_SampleSchedule] AS TABLE(
	[RowID] [bigint] NULL,
	[SampleID] [nvarchar](50) NULL,
	[ScheduleTime] [datetime] NULL,
	[TestingAddress] [nvarchar](100) NULL,
	[CollectionPerson] [bigint] NULL,
	[QuotationNO] [nvarchar](50) NULL,
	[SampleStatus] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_01_TESTMASTER]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_01_TESTMASTER' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Stage2_MHL_T_01_TESTMASTER] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[TCODE] [nvarchar](255) NULL,
	[EDOSCode] [nvarchar](255) NULL,
	[TestName] [nvarchar](max) NULL,
	[TEST_ABBREVATION] [nvarchar](max) NULL,
	[DISPLAY_NAME] [nvarchar](max) NULL,
	[DeptName] [nvarchar](max) NULL,
	[SECTION_NAME] [nvarchar](max) NULL,
	[TEST_GROUP] [nvarchar](255) NULL,
	[TEST_PARENT] [nvarchar](255) NULL,
	[Values_Type] [nvarchar](255) NULL,
	[Orderable] [nvarchar](255) NULL,
	[SEQUENCE_No] [nvarchar](255) NULL,
	[INPUT_FORMAT] [nvarchar](255) NULL,
	[Sample_Type] [nvarchar](max) NULL,
	[Method] [nvarchar](max) NULL,
	[Container] [nvarchar](max) NULL,
	[Units] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[PROCESSING_LOCATION] [nvarchar](255) NULL,
	[Decimal_Places] [nvarchar](255) NULL,
	[Classification] [nvarchar](255) NULL,
	[IS_MACHINE_INTERFACED] [nvarchar](255) NULL,
	[REPEATABLE] [nvarchar](255) NULL,
	[TEST_GENDER] [nvarchar](255) NULL,
	[IS_NABL] [nvarchar](255) NULL,
	[IS_CAP] [nvarchar](255) NULL,
	[IS_STAT] [nvarchar](255) NULL,
	[IS_SMS] [nvarchar](255) NULL,
	[IS_STATISTICAL] [nvarchar](255) NULL,
	[AUTORIZATION] [nvarchar](255) NULL,
	[CO_AUTHORIZATION] [nvarchar](255) NULL,
	[TAT_POLICY] [nvarchar](255) NULL,
	[REFERENCE_RANGE] [nvarchar](max) NULL,
	[CRITICAL_RANGE] [nvarchar](255) NULL,
	[IS_CRITICAL_ALERT] [nvarchar](255) NULL,
	[PANIC_RANGE] [nvarchar](max) NULL,
	[AUTO_AUTHORIZATION_RANGE] [nvarchar](255) NULL,
	[ACCEPTABLE_RANGE] [nvarchar](255) NULL,
	[TEST_EMERGENCY_STAGE] [nvarchar](255) NULL,
	[IS_TEST_HISTORY] [nvarchar](255) NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[DISCOUNT_CATEGORY] [nvarchar](255) NULL,
	[TFORMAT] [nvarchar](255) NULL,
	[SPLFORMAT] [nvarchar](255) NULL,
	[TESTTYPE] [nvarchar](255) NULL,
	[CHILDOF] [nvarchar](255) NULL,
	[LOD] [nvarchar](255) NULL,
	[NOOFSAMPLES] [nvarchar](255) NULL,
	[OUTPUT_FORMAT] [nvarchar](255) NULL,
	[PCTS] [nvarchar](255) NULL,
	[AttType] [nvarchar](255) NULL,
	[CutOffTimeValue] [nvarchar](255) NULL,
	[CutOffTimeType] [nvarchar](255) NULL,
	[IsActive] [nvarchar](255) NULL,
	[IsNonReportable] [nvarchar](255) NULL,
	[PrintSeparately] [nvarchar](255) NULL,
	[IsParameter] [nvarchar](255) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[DeptID] [nvarchar](255) NULL,
	[SampleCode] [nvarchar](255) NULL,
	[MethodID] [nvarchar](255) NULL,
	[SampleContainerID] [nvarchar](255) NULL,
	[HeaderId] [nvarchar](255) NULL,
	[AutoAuthorizationId] [nvarchar](255) NULL,
	[UOMID] [nvarchar](255) NULL,
	[Processing_AddressID] [nvarchar](255) NULL,
	[ProtocolGroup] [nvarchar](100) NULL,
	[ProtocolGroupID] [int] NULL,
	[I_Tcode] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_02_GROUP_MASTER]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_02_GROUP_MASTER' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Stage2_MHL_T_02_GROUP_MASTER] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[GROUPNAME] [nvarchar](255) NULL,
	[METRO_COMBINE_CODE] [nvarchar](255) NULL,
	[EDOSCODE] [nvarchar](255) NULL,
	[DISPLAY_NAME] [nvarchar](255) NULL,
	[ABBREVATION] [nvarchar](255) NULL,
	[IS_ORDERABLE] [nvarchar](255) NULL,
	[CLASSIFICATION] [nvarchar](255) NULL,
	[IS_NABL] [nvarchar](255) NULL,
	[IS_CAP] [nvarchar](255) NULL,
	[IS_STAT] [nvarchar](255) NULL,
	[TAT_POLICY] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[ValidationText] [nvarchar](max) NULL,
	[ValidationRule] [nvarchar](max) NULL,
	[IsDiscountable] [nvarchar](255) NULL,
	[IsServicetaxable] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[CutOffTimeValue] [nvarchar](255) NULL,
	[CutOffTimeType] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[HasHistory] [nvarchar](255) NULL,
	[Remarks] [nvarchar](255) NULL,
	[PrintSeparately] [nvarchar](255) NULL,
	[Gender] [nvarchar](255) NULL,
	[groupinterpretation] [nvarchar](max) NULL,
	[Issummaryworklist] [nvarchar](255) NULL,
	[IsSpecialFormat] [nvarchar](255) NULL,
	[Groupid] [nvarchar](255) NULL,
	[ProtocolGroup] [nvarchar](100) NULL,
	[ProtocolGroupID] [int] NULL,
	[I_Tcode] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_03_Package_Master]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_03_Package_Master' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Stage2_MHL_T_03_Package_Master] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[PACKAGE_NAME] [nvarchar](max) NULL,
	[METROLAB_PROFILECODE] [nvarchar](255) NULL,
	[DOSCODE] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[Test Name] [nvarchar](255) NULL,
	[TEST_SEQUENCE_NO] [nvarchar](255) NULL,
	[Test_Name] [nvarchar](255) NULL,
	[DISPLAY_NAME] [nvarchar](max) NULL,
	[TAT_POLICY] [nvarchar](255) NULL,
	[IS_ORDERABLE] [nvarchar](255) NULL,
	[CLASSIFICATION] [nvarchar](255) NULL,
	[IS_NABL] [nvarchar](255) NULL,
	[IS_CAP] [nvarchar](255) NULL,
	[IS_STAT] [nvarchar](255) NULL,
	[ValidationText] [nvarchar](max) NULL,
	[ValidationRule] [nvarchar](max) NULL,
	[IsDiscountable] [nvarchar](255) NULL,
	[IsServicetaxable] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[CutOffTimeValue] [nvarchar](255) NULL,
	[CutOffTimeType] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[HasHistory] [nvarchar](255) NULL,
	[Remarks] [nvarchar](255) NULL,
	[PrintSeparately] [nvarchar](255) NULL,
	[Gender] [nvarchar](255) NULL,
	[groupinterpretation] [nvarchar](max) NULL,
	[Issummaryworklist] [nvarchar](255) NULL,
	[IsSpecialFormat] [nvarchar](255) NULL,
	[ABBREVATION] [nvarchar](255) NULL,
	[Groupid] [nvarchar](255) NULL,
	[ProtocolGroup] [nvarchar](100) NULL,
	[ProtocolGroupID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_04_GROUP_TESTS]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_04_GROUP_TESTS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Stage2_MHL_T_04_GROUP_TESTS] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[GROUP_CODE] [nvarchar](255) NULL,
	[TEST_CODE] [nvarchar](255) NULL,
	[TEST_NAME] [nvarchar](255) NULL,
	[TEST_SEQUENCE_NO] [float] NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[ID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Stage2_MHL_T_05_PACKAGE_TESTS]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_Stage2_MHL_T_05_PACKAGE_TESTS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_Stage2_MHL_T_05_PACKAGE_TESTS] AS TABLE(
	[LAB] [nvarchar](255) NULL,
	[PACKAGE_CODE] [nvarchar](255) NULL,
	[TEST_CODE] [nvarchar](255) NULL,
	[TEST_NAME] [nvarchar](255) NULL,
	[TEST_SEQUENCE_NO] [float] NULL,
	[InvestigationID] [nvarchar](255) NULL,
	[OrgGroupID] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[ID] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_TRFfilemanager_QMS]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_TRFfilemanager_QMS' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_TRFfilemanager_QMS] AS TABLE(
	[FileID] [bigint] NULL,
	[FileName] [varchar](500) NULL,
	[OrgID] [int] NULL,
	[IdentifyingID] [varchar](20) NULL,
	[IdentifyingType] [varchar](20) NULL,
	[FilePath] [varchar](300) NULL,
	[FileType] [varchar](20) NULL,
	[PageID] [bigint] NULL,
	[Createdby] [bigint] NULL,
	[Createdat ] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt ] [datetime] NULL,
	[IsDelete] [varchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_WidgetLoginDetail]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_WidgetLoginDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDT_WidgetLoginDetail] AS TABLE(
	[RoleID] [bigint] NULL,
	[LoginID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[WID] [bigint] NULL,
	[DetailedID] [bigint] NULL,
	[WCode] [nvarchar](200) NULL,
	[WGCode] [nvarchar](200) NULL,
	[Active] [char](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAdditionalConsumption]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAdditionalConsumption' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAdditionalConsumption] AS TABLE(
	[AdditionalConsumptionID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[DeviceID] [nvarchar](100) NULL,
	[ConsumptionType] [varchar](300) NULL,
	[ConsumptionCount] [int] NULL,
	[TestDate] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAdditionalTubeMapping]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAdditionalTubeMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAdditionalTubeMapping] AS TABLE(
	[ID] [int] NULL,
	[Type] [nvarchar](20) NULL,
	[SampleCode] [bigint] NULL,
	[IsActive] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAddressDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAddressDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAddressDetails] AS TABLE(
	[AddressID] [bigint] NULL,
	[AddressTypeID] [int] NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[Address1] [nvarchar](2000) NULL,
	[City] [nvarchar](50) NULL,
	[CountryID] [int] NULL,
	[StateID] [int] NULL,
	[EmailID] [nvarchar](250) NULL,
	[Phone] [nvarchar](250) NULL,
	[Mobile] [nvarchar](500) NULL,
	[FaxNumber] [nvarchar](100) NULL,
	[IsCommunication] [nvarchar](50) NULL,
	[ISDCode] [int] NULL,
	[Name] [nvarchar](500) NULL,
	[ContactType] [nvarchar](200) NULL,
	[EmpID] [bigint] NULL,
	[SubUrban] [nvarchar](100) NULL,
	[Address2] [nvarchar](2000) NULL,
	[ZipCode] [nvarchar](30) NULL,
	[InvoiceEmail] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAdvancePaidDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAdvancePaidDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAdvancePaidDetails] AS TABLE(
	[AdvanceAmount] [decimal](18, 2) NULL,
	[TypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[AdvanceTypeID] [bigint] NULL,
	[AdvanceType] [nvarchar](10) NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[OtherCurrencyAmount] [decimal](18, 2) NULL,
	[PaymentCollectedFrom] [nvarchar](100) NULL,
	[BankBranch] [nvarchar](100) NULL,
	[TransactionID] [nvarchar](100) NULL,
	[ChequeDate] [datetime] NULL,
	[CardHoldername] [nvarchar](100) NULL,
	[Isoutstation] [nvarchar](10) NULL,
	[AmtReceivedID] [bigint] NULL,
	[AuthorisationCode] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAmountReceivedDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAmountReceivedDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAmountReceivedDetails] AS TABLE(
	[AmtReceived] [decimal](18, 2) NOT NULL,
	[TypeID] [int] NOT NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[ChequeValidDate] [datetime] NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[OtherCurrencyAmount] [decimal](18, 2) NULL,
	[EMIOpted] [nvarchar](1) NULL,
	[EMIROI] [decimal](18, 2) NULL,
	[EMITenor] [int] NULL,
	[EMIValue] [decimal](10, 2) NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](255) NULL,
	[Units] [int] NULL,
	[CardHolderName] [nvarchar](255) NULL,
	[CashGiven] [decimal](18, 2) NULL,
	[BalanceGiven] [decimal](18, 2) NULL,
	[TransactionID] [nvarchar](255) NULL,
	[BranchName] [nvarchar](255) NULL,
	[PaymentCollectedFrom] [nvarchar](100) NULL,
	[IsOutStation] [nvarchar](1) NULL,
	[AmtReceivedID] [bigint] NULL,
	[AuthorisationCode] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAmtRecDetailsUpdate]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAmtRecDetailsUpdate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAmtRecDetailsUpdate] AS TABLE(
	[AmtReceivedID] [bigint] NOT NULL,
	[AmtReceived] [decimal](18, 2) NOT NULL,
	[TypeID] [int] NOT NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[ChequeValidDate] [datetime] NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[OtherCurrencyAmount] [decimal](18, 2) NULL,
	[EMIOpted] [nvarchar](1) NULL,
	[EMIROI] [decimal](18, 2) NULL,
	[EMITenor] [int] NULL,
	[EMIValue] [decimal](10, 2) NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](255) NULL,
	[Units] [int] NULL,
	[CardHolderName] [nvarchar](255) NULL,
	[CashGiven] [decimal](18, 2) NULL,
	[BalanceGiven] [decimal](18, 2) NULL,
	[ModifiedBy] [bigint] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTAmtRefundDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTAmtRefundDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTAmtRefundDetails] AS TABLE(
	[FinalBillID] [bigint] NOT NULL,
	[BillingDetailsID] [bigint] NOT NULL,
	[AmtRefund] [decimal](18, 2) NOT NULL,
	[RefundBy] [bigint] NOT NULL,
	[RefundStatus] [nvarchar](10) NOT NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ReasonforRefund] [nvarchar](255) NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[RefundType] [nvarchar](50) NULL,
	[ApprovedBy] [bigint] NULL,
	[TranCurrencyID] [int] NULL,
	[BaseCurrencyID] [int] NULL,
	[TranCurrencyAmount] [decimal](18, 4) NULL,
	[PaymentTypeID] [int] NULL,
	[PaymentDetail] [nvarchar](255) NULL,
	[ChequeNo] [bigint] NULL,
	[BankName] [nvarchar](100) NULL,
	[Remarks] [nvarchar](255) NULL,
	[AuthorisedBy] [int] NULL,
	[ServiceType] [nvarchar](20) NULL,
	[Comments] [nvarchar](255) NULL,
	[CancelAmount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTaxBillDetails]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTaxBillDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTaxBillDetails] AS TABLE(
	[TaxID] [int] NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[TaxAmount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBanks]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBanks' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBanks] AS TABLE(
	[BankName] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBarcodeCategoriesAndPatterns]    Script Date: 6/25/2018 4:04:41 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBarcodeCategoriesAndPatterns' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBarcodeCategoriesAndPatterns] AS TABLE(
	[BarcodeCategoryId] [bigint] NULL,
	[BarcodeMainAttributeId] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[Value] [nvarchar](250) NULL,
	[Id] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBarcodePrintJob]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBarcodePrintJob' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBarcodePrintJob] AS TABLE(
	[ID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[BarcodeNumber] [nvarchar](250) NULL,
	[MachineID] [nvarchar](100) NULL,
	[HeaderLine1] [nvarchar](max) NULL,
	[HeaderLine2] [nvarchar](max) NULL,
	[FooterLine1] [nvarchar](max) NULL,
	[FooterLine2] [nvarchar](max) NULL,
	[RightHeaderLine1] [nvarchar](max) NULL,
	[RightHeaderLine2] [nvarchar](max) NULL,
	[RightHeaderLine3] [nvarchar](max) NULL,
	[RightHeaderLine4] [nvarchar](max) NULL,
	[RightHeaderLine5] [nvarchar](max) NULL,
	[RightHeaderLine6] [nvarchar](max) NULL,
	[RightHeaderLine7] [nvarchar](max) NULL,
	[PrinterName] [nvarchar](max) NULL,
	[Status] [nvarchar](200) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBillOfMaterialDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBillOfMaterialDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBillOfMaterialDetails] AS TABLE(
	[BillofMaterialID] [int] NULL,
	[ProductID] [bigint] NOT NULL,
	[EstimatedQty] [decimal](10, 2) NULL,
	[EstimatedUnit] [nvarchar](50) NULL,
	[BufferQty] [decimal](10, 2) NULL,
	[BufferUnit] [nvarchar](50) NULL,
	[EstimatedDuration] [nvarchar](50) NULL,
	[CeilingLimit] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[ParentProductID] [bigint] NOT NULL,
	[InvestigationID] [bigint] NOT NULL,
	[LocationID] [int] NULL,
	[Description] [nvarchar](200) NULL,
	[RecurrentUsage] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBillOfMaterials]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBillOfMaterials' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBillOfMaterials] AS TABLE(
	[ResourceServiceTypeID] [int] NULL,
	[ServiceName] [nvarchar](100) NOT NULL,
	[FeeType] [nvarchar](50) NULL,
	[FeeTypeID] [int] NULL,
	[ResourceType] [nvarchar](50) NULL,
	[ResourceName] [nvarchar](200) NULL,
	[OrgID] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[SeviceID] [bigint] NOT NULL,
	[ServiceType] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBillsearchdetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBillsearchdetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBillsearchdetails] AS TABLE(
	[OrgID] [bigint] NULL,
	[VisitNumber] [nvarchar](20) NULL,
	[ClientName] [nvarchar](200) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[VisitDate] [datetime] NULL,
	[Name] [nvarchar](200) NULL,
	[FeeDescription] [nvarchar](200) NULL,
	[FeeType] [nvarchar](20) NULL,
	[Amount] [decimal](18, 2) NULL,
	[MAmount] [decimal](18, 2) NULL,
	[RateCard] [nvarchar](20) NULL,
	[MRateCard] [nvarchar](20) NULL,
	[BaseAmount] [decimal](18, 2) NULL,
	[MBaseAmount] [decimal](18, 2) NULL,
	[BaseRateCard] [nvarchar](20) NULL,
	[MBaseRateCard] [nvarchar](20) NULL,
	[DiscounCategory] [nvarchar](20) NULL,
	[MDiscounCategory] [nvarchar](20) NULL,
	[DiscountedPolicy] [nvarchar](20) NULL,
	[MDiscountedPolicy] [nvarchar](20) NULL,
	[FinalBillID] [bigint] NULL,
	[RateID] [bigint] NULL,
	[MRateID] [bigint] NULL,
	[BaseRateID] [bigint] NULL,
	[MBaseRateID] [bigint] NULL,
	[DiscountPolicyID] [bigint] NULL,
	[MDiscountPolicyID] [bigint] NULL,
	[DiscountPercentage] [bigint] NULL,
	[BillingDetailsID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodCapture]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodCapture' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBloodCapture] AS TABLE(
	[CapturedTime] [datetime] NULL,
	[HeartRate] [nvarchar](20) NULL,
	[BloodPressure] [nvarchar](50) NULL,
	[Saturation] [bigint] NULL,
	[Volume] [bigint] NULL,
	[Condition] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodCollect]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodCollect' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBloodCollect] AS TABLE(
	[BagNumber] [nvarchar](20) NULL,
	[BagType] [nvarchar](20) NULL,
	[BloodCapacity] [nvarchar](50) NULL,
	[TubeID] [nvarchar](20) NULL,
	[AntiCoagulants] [nvarchar](250) NULL,
	[BloodComponent] [nvarchar](250) NULL,
	[BloodGroup] [nvarchar](50) NULL,
	[CollectedDate] [datetime] NULL,
	[SeperatedDate] [datetime] NULL,
	[ReconstitutedDate] [datetime] NULL,
	[ExpiryDate] [datetime] NULL,
	[StorageSlot] [nvarchar](30) NULL,
	[BatchNo] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodRequest]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodRequest' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBloodRequest] AS TABLE(
	[BloodComponent] [bigint] NULL,
	[NoOfUnits] [bigint] NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](100) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBloodSeparation]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBloodSeparation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBloodSeparation] AS TABLE(
	[ParentbagNumber] [nvarchar](50) NULL,
	[BagNumber] [nvarchar](50) NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](100) NULL,
	[Volume] [nvarchar](10) NULL,
	[BloodGroupName] [nvarchar](20) NULL,
	[ExpiryDate] [datetime] NULL,
	[OrgID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBulckRateUpdates]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulckRateUpdates' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBulckRateUpdates] AS TABLE(
	[FinalbillID] [bigint] NULL,
	[ClientID] [bigint] NULL,
	[OldRateID] [bigint] NULL,
	[OldAmount] [decimal](18, 0) NULL,
	[NewRateID] [bigint] NULL,
	[NewAmount] [decimal](18, 0) NULL,
	[BillFromDate] [datetime] NULL,
	[BillToDate] [datetime] NULL,
	[InvoiceID] [bigint] NULL,
	[PreTotBilledAmount] [decimal](18, 0) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBulkDeviceMap]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulkDeviceMap' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBulkDeviceMap] AS TABLE(
	[SNo] [int] NULL,
	[DeviceID] [nvarchar](50) NOT NULL,
	[TestCode] [nvarchar](50) NULL,
	[InvestigationName] [nvarchar](max) NULL,
	[InvestigationID] [bigint] NULL,
	[Formula] [nvarchar](max) NULL,
	[Abnormal] [nchar](1) NULL,
	[IsActive] [nchar](1) NULL,
	[IsUpload] [nchar](1) NULL,
	[IsDownload] [nchar](1) NULL,
	[LocationID] [int] NULL,
	[OrgId] [bigint] NOT NULL,
	[Flag] [nvarchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTBulkReferenceRange]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulkReferenceRange' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTBulkReferenceRange] AS TABLE(
	[TestCode] [nvarchar](30) NULL,
	[RangeType] [nvarchar](100) NULL,
	[GenderValue] [nvarchar](100) NULL,
	[SubCategoryType] [nvarchar](100) NULL,
	[ResultType] [nvarchar](100) NULL,
	[TypeMode] [nvarchar](100) NULL,
	[AgeRangeType] [nvarchar](100) NULL,
	[AgeRange] [nvarchar](100) NULL,
	[ReferenceName] [nvarchar](100) NULL,
	[ValueTypeMode] [nvarchar](100) NULL,
	[Value] [nvarchar](100) NULL,
	[IsNormal] [nvarchar](50) NULL,
	[IsSourceText] [nvarchar](5) NULL,
	[ReferenceRange] [nvarchar](max) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[Device] [nvarchar](100) NULL,
	[Status] [bit] NULL DEFAULT ((0)),
	[OrgID] [int] NULL,
	[InvestigationID] [bigint] NULL DEFAULT ((0)),
	[InvestigationName] [nvarchar](500) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCapturePatientHistory]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCapturePatientHistory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCapturePatientHistory] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[HistoryID] [bigint] NULL,
	[HistoryName] [nvarchar](300) NULL,
	[AttributeID] [bigint] NULL,
	[AttributeName] [nvarchar](300) NULL,
	[AttributevalueID] [bigint] NULL,
	[AttributeValueName] [nvarchar](300) NULL,
	[HasAttribute] [nvarchar](300) NULL,
	[Description] [nvarchar](300) NULL,
	[Type] [nvarchar](300) NULL,
	[PatientHistoryAttributeID] [bigint] NULL,
	[SeqID] [bigint] NULL,
	[ActionType] [nvarchar](300) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCashClosureDenomination]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCashClosureDenomination' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCashClosureDenomination] AS TABLE(
	[DenominationID] [bigint] NULL,
	[Unit] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[LoginID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCategoriesAndPatterns]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCategoriesAndPatterns' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCategoriesAndPatterns] AS TABLE(
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](50) NULL,
	[PatternValue] [nvarchar](150) NULL,
	[IsReset] [nchar](1) NULL,
	[CreatedDate] [datetime] NULL,
	[ResetNumber] [bigint] NULL,
	[ResetOption] [nvarchar](20) NULL,
	[ResetBy] [nvarchar](30) NULL,
	[Pattern] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientAttributeFieldDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientAttributeFieldDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientAttributeFieldDetails] AS TABLE(
	[KeyName] [nvarchar](400) NOT NULL,
	[Valuedata] [nvarchar](400) NOT NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](400) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientAttributes]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientAttributes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientAttributes] AS TABLE(
	[AttributesID] [bigint] NULL,
	[value] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[ClientID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientBasicDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientBasicDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientBasicDetails] AS TABLE(
	[ClientCode] [nvarchar](30) NULL,
	[ClientType] [int] NULL,
	[RegistrationType] [nvarchar](100) NULL,
	[HasParent] [bit] NULL,
	[txtHasparent] [bigint] NULL,
	[CCLabReport] [nvarchar](10) NULL,
	[SplPrivileges] [int] NULL,
	[OrderableLocation] [nvarchar](100) NULL,
	[PrintLocation] [bigint] NULL,
	[NoofPrintCopies] [int] NULL,
	[Location] [bigint] NULL,
	[Hub] [bigint] NULL,
	[Zone] [bigint] NULL,
	[Route] [bigint] NULL,
	[TransitTime] [int] NULL,
	[ddlTransitTime] [nvarchar](50) NULL,
	[ExAutoAuthorization] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientCommunication]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientCommunication' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientCommunication] AS TABLE(
	[ClientId] [int] NULL,
	[ComMode] [nvarchar](20) NULL,
	[NotifyType] [nvarchar](20) NULL,
	[ComDetails] [nvarchar](100) NULL,
	[BlockNotify] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientCreditDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientCreditDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientCreditDetails] AS TABLE(
	[BusinessType] [bigint] NULL,
	[CSTNo] [nvarchar](50) NULL,
	[ServiceTaxNo] [nvarchar](50) NULL,
	[PANNo] [nvarchar](50) NULL,
	[SAPCode] [nvarchar](50) NULL,
	[CurrencyType] [int] NULL,
	[PaymentCategory] [nvarchar](20) NULL,
	[AllowServiceMapping] [nvarchar](5) NULL,
	[InvoiceCycle] [nvarchar](15) NULL,
	[CouponSystem] [nvarchar](5) NULL,
	[InvoiceApprovalRequired] [nvarchar](5) NULL,
	[AllowBillingDiscount] [nvarchar](5) NULL,
	[ClientStatus] [nvarchar](5) NULL,
	[Reason] [nvarchar](30) NULL,
	[Action] [nvarchar](50) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[CreditLimit] [decimal](18, 2) NULL,
	[CreditDays] [bigint] NULL,
	[GraceLimit] [decimal](18, 2) NULL,
	[GraceDays] [bigint] NULL,
	[AdvanceThreshold] [nvarchar](50) NULL,
	[Value] [decimal](18, 2) NULL,
	[MinimumDeposite] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientDepositHistory]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientDepositHistory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientDepositHistory] AS TABLE(
	[DepositID] [bigint] NULL,
	[ClientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[ReceiptNo] [bigint] NULL,
	[AmountDeposited] [decimal](18, 2) NULL,
	[PaymentTypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[ConversionRate] [decimal](18, 4) NULL,
	[PaidCurrencyAmount] [decimal](18, 4) NULL,
	[CreatedBy] [bigint] NULL,
	[CardHolderName] [nvarchar](255) NULL,
	[CashGiven] [decimal](18, 2) NULL,
	[BalanceGiven] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientDespatchmode]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientDespatchmode' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientDespatchmode] AS TABLE(
	[ActionTypeID] [bigint] NULL,
	[Despatch] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[ClientID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientDiscountPolicyMapping]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientDiscountPolicyMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientDiscountPolicyMapping] AS TABLE(
	[ClientId] [int] NULL,
	[PolicyType] [nvarchar](30) NULL,
	[PolicyID] [bigint] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[IsActive] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientRefundDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientRefundDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientRefundDetails] AS TABLE(
	[DepositID] [bigint] NULL,
	[ClientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedAT] [datetime] NULL,
	[RefundAmount] [decimal](18, 2) NULL,
	[PaymentTypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientRefundHistory]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientRefundHistory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientRefundHistory] AS TABLE(
	[DepositID] [bigint] NULL,
	[ClientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[RefundAmount] [decimal](18, 2) NULL,
	[PaymentTypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientServiceExclusivity]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientServiceExclusivity' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientServiceExclusivity] AS TABLE(
	[ClientId] [bigint] NULL,
	[FeeID] [bigint] NOT NULL,
	[FeeType] [nvarchar](20) NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[SCode] [nvarchar](50) NULL,
	[IsExclusive] [bit] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTClientTaxMaster]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientTaxMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTClientTaxMaster] AS TABLE(
	[ClientID] [bigint] NULL,
	[TaxID] [int] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [nvarchar](1) NULL,
	[SequenceNo] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTcodeschemelblmaster]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTcodeschemelblmaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTcodeschemelblmaster] AS TABLE(
	[CodeLabel] [int] NULL,
	[CodeTextbox] [nvarchar](100) NULL,
	[CodeMasterID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCodingSchemeMaster]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCodingSchemeMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCodingSchemeMaster] AS TABLE(
	[CodeTypeID] [int] NULL,
	[CodingSchemaName] [nvarchar](50) NOT NULL,
	[VersionNo] [nvarchar](25) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCodingSchemeOrgMapping]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCodingSchemeOrgMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCodingSchemeOrgMapping] AS TABLE(
	[CodingSchemeOrgID] [int] NULL,
	[CodeTypeID] [int] NOT NULL,
	[RootOrgID] [bigint] NOT NULL,
	[ParentOrgID] [bigint] NOT NULL,
	[OrgID] [bigint] NOT NULL,
	[IsPrimary] [nvarchar](1) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCommunicationDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCommunicationDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCommunicationDetails] AS TABLE(
	[DetailID] [bigint] NULL,
	[CommID] [bigint] NULL,
	[CommCode] [nvarchar](50) NULL,
	[CommType] [int] NULL,
	[OrgID] [int] NULL,
	[LoginID] [bigint] NULL,
	[RoleID] [int] NULL,
	[ACKRequired] [nchar](5) NULL,
	[ACKStatus] [int] NULL,
	[PriorityLevel] [nvarchar](15) NULL,
	[Remarks] [nvarchar](max) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTConfig]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTConfig' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTConfig] AS TABLE(
	[ConfigID] [bigint] NULL,
	[ConfigKey] [nvarchar](max) NULL,
	[ConfigValue] [nvarchar](max) NULL,
	[ParentID] [bigint] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCouponDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCouponDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCouponDetails] AS TABLE(
	[CouponDetailID] [bigint] NULL,
	[CouponID] [bigint] NULL,
	[StartSerialNo] [nvarchar](30) NULL,
	[EndSerialNo] [nvarchar](30) NULL,
	[BatchNo] [nvarchar](30) NULL,
	[OrderedUnits] [bigint] NULL,
	[CouponValue] [numeric](12, 2) NULL,
	[ExpiryDate] [nvarchar](50) NULL,
	[ConsumedUnits] [bigint] NULL,
	[Code] [nvarchar](15) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCouponMaster]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCouponMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCouponMaster] AS TABLE(
	[CouponID] [bigint] NULL,
	[Code] [nvarchar](15) NULL,
	[Name] [nvarchar](50) NULL,
	[Status] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCouponValueMaster]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCouponValueMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCouponValueMaster] AS TABLE(
	[CouponId] [int] NOT NULL,
	[CouponName] [nvarchar](255) NULL,
	[CouponBarcode] [nvarchar](50) NULL,
	[CouponValue] [decimal](18, 2) NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[PhysicianId] [bigint] NULL,
	[OrgID] [int] NULL,
	[AddressId] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[Status] [nchar](1) NULL,
	[InvestigationID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[IsDelete] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCurrencyOrgMapping]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCurrencyOrgMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCurrencyOrgMapping] AS TABLE(
	[CurrencyID] [int] NOT NULL,
	[OrgID] [int] NOT NULL,
	[ConversionRate] [decimal](18, 4) NULL,
	[IsBaseCurrency] [nchar](1) NULL,
	[CurrencyCode] [nvarchar](10) NULL,
	[CurrencyName] [nvarchar](100) NULL,
	[RemoveCurrency] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCustomAttributesMapping]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCustomAttributesMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTCustomAttributesMapping] AS TABLE(
	[ID] [bigint] NULL,
	[MappingID] [bigint] NULL,
	[AttributeID] [bigint] NULL,
	[AttributeName] [nvarchar](255) NULL,
	[AttributeStatus] [bit] NULL,
	[IsPreDefined] [bit] NULL,
	[DataType] [nvarchar](50) NULL,
	[ControlLength] [int] NULL,
	[IsMandatory] [bit] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[Status] [bit] NULL,
	[Description] [nvarchar](500) NULL,
	[ControlTypeID] [int] NULL,
	[ControlName] [nvarchar](50) NULL,
	[ControlCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[Type] [nvarchar](50) NULL,
	[ControlValue] [nvarchar](max) NULL,
	[IsTableReference] [bit] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDepartment]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDepartment' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDepartment] AS TABLE(
	[DeptID] [bigint] NULL,
	[DeptName] [nvarchar](200) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDeviceImportData]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDeviceImportData' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDeviceImportData] AS TABLE(
	[BarCode] [nvarchar](50) NOT NULL,
	[TestCode] [nvarchar](15) NOT NULL,
	[DeviceSampleDesc] [nvarchar](15) NOT NULL,
	[PatientName] [nvarchar](150) NULL,
	[PatientNumber] [nvarchar](50) NOT NULL,
	[ExternalVisitID] [nvarchar](50) NULL,
	[PatientAge] [nvarchar](15) NULL,
	[PatientSex] [nvarchar](10) NULL,
	[OrgID] [int] null
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDeviceStockUsage]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDeviceStockUsage' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDeviceStockUsage] AS TABLE(
	[DeviceStockUsageID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[DeviceID] [nvarchar](100) NULL,
	[ProductName] [nvarchar](300) NULL,
	[ItemBarcodeNo] [nvarchar](300) NULL,
	[Status] [nvarchar](300) NULL,
	[Consumption] [decimal](18, 0) NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDischargeSummary]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDischargeSummary' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDischargeSummary] AS TABLE(
	[DischargeSummarSeqID] [int] NULL,
	[PlaceHolderID] [nvarchar](50) NULL,
	[ControlName] [nvarchar](150) NULL,
	[HeaderName] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[IsActive] [nvarchar](1) NULL,
	[SequenceNo] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDisPatchDetails]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDisPatchDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDisPatchDetails] AS TABLE(
	[VisitID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[DispatchType] [nvarchar](20) NULL,
	[DispatchValue] [nvarchar](20) NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDisPatchMode]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDisPatchMode' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDisPatchMode] AS TABLE(
	[DispatchType] [nvarchar](20) NULL,
	[DispatchValue] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDynamicColumnMapping]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDynamicColumnMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTDynamicColumnMapping] AS TABLE(
	[DynamicColumnMappingID] [int] NULL,
	[SearchTypeID] [int] NULL,
	[SearchColumnID] [int] NULL,
	[OrgID] [int] NULL,
	[OrgAddID] [int] NULL,
	[Deleted] [nchar](1) NULL,
	[Visible] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEmployeeRegMaster]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEmployeeRegMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTEmployeeRegMaster] AS TABLE(
	[EmployeeNumber] [nvarchar](510) NULL,
	[Name] [nvarchar](510) NULL,
	[DOJ] [datetime] NULL,
	[EmployerID] [bigint] NULL,
	[DeptID] [bigint] NULL,
	[DesignationID] [bigint] NULL,
	[EmployementTypeID] [bigint] NULL,
	[Qualification] [nvarchar](255) NULL,
	[EmployerLocationID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[ZoneID] [bigint] NULL,
	[MobileNo] [nvarchar](255) NULL,
	[LandlineNo] [nvarchar](255) NULL,
	[EMail] [nvarchar](max) NULL,
	[DiscountLimit] [decimal](18, 2) NULL,
	[DiscountPeriod] [nvarchar](20) NULL,
	[DiscountValidFrom] [datetime] NULL,
	[DiscountValidTo] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEMR]    Script Date: 6/25/2018 4:04:42 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEMR' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTEMR] AS TABLE(
	[Id] [bigint] NULL,
	[Attributeid] [bigint] NULL,
	[Attributevalueid] [bigint] NULL,
	[Attributevaluename] [nvarchar](150) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEpisode]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEpisode' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTEpisode] AS TABLE(
	[EpisodeID] [bigint] NULL,
	[EpisodeName] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[NoofSitting] [int] NULL,
	[ClientID] [bigint] NULL,
	[StudyTypeID] [int] NULL,
	[EpisodeNumber] [nvarchar](100) NULL,
	[StartDate] [nvarchar](200) NULL,
	[EndDate] [nvarchar](200) NULL,
	[Attributes] [nvarchar](max) NULL,
	[NoOfPatient] [int] NULL,
	[ISAdhoc] [nvarchar](3) NULL,
	[OrgLocationID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ClientSiteAttribute] [nvarchar](max) NULL,
	[SiteWiseSubjectAllocation] [int] NULL,
	[VisitWiseSubjectAllocation] [int] NULL,
	[StudyPhaseID] [int] NULL,
	[StudySource] [nvarchar](155) NULL,
	[StudyDesign] [nvarchar](max) NULL,
	[ReferenceLab] [nvarchar](255) NULL,
	[ScreeningSubjects] [int] NULL,
	[NoOfSites] [int] NULL,
	[IsUndefinedScreening] [nvarchar](3) NULL,
	[TherapeuticVlaue] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEpisodeFileManager]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEpisodeFileManager' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTEpisodeFileManager] AS TABLE(
	[FileID] [bigint] NULL,
	[FileUrl] [nvarchar](300) NULL,
	[EpisodeID] [bigint] NULL,
	[FileType] [nvarchar](200) NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTEpisodeVisitDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTEpisodeVisitDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTEpisodeVisitDetails] AS TABLE(
	[EpisodeVisitDetailID] [bigint] NULL,
	[EpisodeID] [bigint] NULL,
	[EpisodeVisitName] [nvarchar](100) NULL,
	[FeeID] [bigint] NULL,
	[FeeType] [nvarchar](10) NULL,
	[TimedType] [nvarchar](10) NULL,
	[TimedNo] [int] NULL,
	[EpisodeVisitNumber] [int] NULL,
	[IsMandatory] [nvarchar](3) NULL,
	[PackageDetails] [nvarchar](max) NULL,
	[SiteDetails] [nvarchar](max) NULL,
	[VisitType] [int] NULL,
	[Guid] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTExternalQualityAssuranceMaster]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTExternalQualityAssuranceMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTExternalQualityAssuranceMaster] AS TABLE(
	[VendorID] [bigint] NULL,
	[CycleIdentification] [nvarchar](500) NULL,
	[DateOfProcessing] [nvarchar](100) NULL,
	[Interpretation] [nvarchar](500) NULL,
	[HasFile] [char](2) NULL,
	[FileType] [nvarchar](15) NULL,
	[FilePath] [nvarchar](500) NULL,
	[ResultType] [nvarchar](500) NULL,
	[Extras] [nvarchar](500) NULL,
	[DeptID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTFoodOrderID]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTFoodOrderID' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTFoodOrderID] AS TABLE(
	[FoodOrderID] [bigint] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHealthCoupons]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHealthCoupons' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHealthCoupons] AS TABLE(
	[HealthCouponNo] [nvarchar](255) NULL,
	[Value] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHl7InBoundMessageDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHl7InBoundMessageDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHl7InBoundMessageDetails] AS TABLE(
	[Id] [int] NULL,
	[MsgControlId] [varchar](100) NULL,
	[ErrorList] [varchar](max) NULL,
	[StatusOfInbound] [varchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHl7OutBoundMessageDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHl7OutBoundMessageDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHl7OutBoundMessageDetails] AS TABLE(
	[HL7ID] [bigint] NULL,
	[ID] [bigint] NULL,
	[Name] [nvarchar](1000) NULL,
	[Type] [nvarchar](50) NULL,
	[Status] [nvarchar](100) NULL,
	[AccessionNumber] [bigint] NULL,
	[GeneratedXML] [nvarchar](max) NULL,
	[TestStatus] [nvarchar](100) NULL,
	[PatientVisitID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageErrorDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageErrorDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHLMessageErrorDetails] AS TABLE(
	[HLMessageError] [nvarchar](max) NULL,
	[HLMessageID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[HLMessageColumns] [nvarchar](300) NULL,
	[HLMessageTable] [nvarchar](300) NULL,
	[FileNames] [nvarchar](150) NULL,
	[Locations] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageHeaderDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageHeaderDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHLMessageHeaderDetails] AS TABLE(
	[MHEvent_Type] [nvarchar](100) NULL,
	[Encoding_Characters] [nvarchar](100) NULL,
	[Sending_Application] [nvarchar](100) NULL,
	[Sending_Facility] [nvarchar](100) NULL,
	[SFNamespace_ID] [nvarchar](100) NULL,
	[SFUniversal_ID] [nvarchar](100) NULL,
	[Message_Date_Time] [datetime] NULL,
	[MessageSecurity] [nvarchar](100) NULL,
	[Receiving_Application] [nvarchar](100) NULL,
	[Receiving_Facility] [nvarchar](100) NULL,
	[Sequence_number] [nvarchar](100) NULL,
	[Message_control_id] [nvarchar](100) NULL,
	[Message_Type] [nvarchar](100) NULL,
	[Message_Code] [nvarchar](100) NULL,
	[Trigger_Event] [nvarchar](100) NULL,
	[Message_Structure] [nvarchar](100) NULL,
	[Continuation_pointer] [nvarchar](100) NULL,
	[Processing_ID] [nvarchar](100) NULL,
	[Version_ID] [nvarchar](100) NULL,
	[Application_Acknowledgment_type] [nvarchar](100) NULL,
	[MHCountry_Code] [nvarchar](100) NULL,
	[Character_Set] [nvarchar](100) NULL,
	[Principal_Language_Of_Message] [nvarchar](100) NULL,
	[MHIdentifier] [nvarchar](100) NULL,
	[Alternate_Character_Set_Handling_Scheme] [nvarchar](100) NULL,
	[Message_Profile_Identifier] [nvarchar](100) NULL,
	[Entity_Identifier] [nvarchar](100) NULL,
	[Sending_Responsible_Organization] [nvarchar](100) NULL,
	[SROrganization_Name] [nvarchar](100) NULL,
	[Receiving_Responsible_Organization] [nvarchar](100) NULL,
	[RROrganization_Name] [nvarchar](100) NULL,
	[Sending_Network_Address] [nvarchar](100) NULL,
	[SNNamespace_ID] [nvarchar](100) NULL,
	[Receiving_Network_Address] [nvarchar](100) NULL,
	[RNNamespace_ID] [nvarchar](100) NULL,
	[HLMessageID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[ParentID] [bigint] NULL,
	[HLMessageHeaderContent] [nvarchar](max) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageOBRDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageOBRDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHLMessageOBRDetails] AS TABLE(
	[OBREvent_Type] [nvarchar](100) NULL,
	[Set_ID_OBR] [nvarchar](100) NULL,
	[Placer_Order_Number] [nvarchar](100) NULL,
	[OBRFiller_Order_Number] [nvarchar](100) NULL,
	[Universal_Service_Identifier] [nvarchar](100) NULL,
	[OBRIdentifier] [nvarchar](100) NULL,
	[OBRText] [nvarchar](100) NULL,
	[Name_Of_Coding_System] [nvarchar](100) NULL,
	[OBRPriority] [nvarchar](100) NULL,
	[Requested_Date_Time] [datetime] NULL,
	[Observation_Date_Time] [datetime] NULL,
	[Observation_End_Date_Time] [datetime] NULL,
	[Collection_Volume] [nvarchar](100) NULL,
	[Collector_Identifier] [nvarchar](100) NULL,
	[Spicemen_Action_Code] [nvarchar](100) NULL,
	[Danger_Code] [nvarchar](100) NULL,
	[Relevant_Clinical_Information] [nvarchar](100) NULL,
	[Specimen_Received_Date_Time] [datetime] NULL,
	[Specimen_Source] [nvarchar](100) NULL,
	[OBROrdering_Provider] [nvarchar](100) NULL,
	[Person_Identifier] [nvarchar](100) NULL,
	[OBRFamily_Name] [nvarchar](100) NULL,
	[Given_Name] [nvarchar](100) NULL,
	[Second_and_Further_Given_Names_or_Initials_There_of] [nvarchar](100) NULL,
	[OBRSuffix] [nvarchar](100) NULL,
	[OBRPrefix] [nvarchar](100) NULL,
	[OBRDegree] [nvarchar](100) NULL,
	[Order_Callback_Phone_Number] [nvarchar](100) NULL,
	[Placer_Field1] [nvarchar](100) NULL,
	[Placer_Field2] [nvarchar](100) NULL,
	[Filler_Field1] [nvarchar](100) NULL,
	[Filler_Field2] [nvarchar](100) NULL,
	[Results_Rpt_Status_Chng_DateTime] [datetime] NULL,
	[Change_to_Practice] [nvarchar](100) NULL,
	[Diagnostic_Serv_Sect_ID] [nvarchar](100) NULL,
	[Result_Status] [nvarchar](100) NULL,
	[Parent_Status] [nvarchar](100) NULL,
	[OBRQuantity_Timing] [nvarchar](100) NULL,
	[Result_Copies_To] [nvarchar](100) NULL,
	[Parent_Result_Observation_Identifier] [nvarchar](100) NULL,
	[Transporation_Mode] [nvarchar](100) NULL,
	[Reason_For_Study] [nvarchar](100) NULL,
	[Principal_Result_Interpreter] [nvarchar](100) NULL,
	[Assistant_Result_Interpreter] [nvarchar](100) NULL,
	[Technician] [nvarchar](100) NULL,
	[Transcriptionist] [nvarchar](100) NULL,
	[Scheduled_Date_Time] [datetime] NULL,
	[Number_Of_Sample_Containers] [nvarchar](100) NULL,
	[Transport_Logistics_Of_Collected_Samlpe] [nvarchar](100) NULL,
	[Collectors_Comment] [nvarchar](100) NULL,
	[Transport_Arrangement_Responsibility] [nvarchar](100) NULL,
	[Transport_Arranged] [nvarchar](100) NULL,
	[Escort_Required] [nvarchar](100) NULL,
	[Planned_Patient_Transport_Comment] [nvarchar](100) NULL,
	[Procedure_Code] [nvarchar](100) NULL,
	[Procedure_Code_Modifier] [nvarchar](100) NULL,
	[Placer_Supplemental_Service_Information] [nvarchar](100) NULL,
	[Filler_Supplemental_Service_Information] [nvarchar](100) NULL,
	[Medically_Necessary_Duplicate_Procedure_Reason] [nvarchar](100) NULL,
	[Result_Handling] [nvarchar](100) NULL,
	[Parent_Universal_Service_Identifier] [nvarchar](100) NULL,
	[HLMessageID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[Tasks_Line_Discount] [decimal](18, 2) NULL,
	[Tasks_Line_Amount] [decimal](18, 2) NULL,
	[Tasks_Sales_Price] [decimal](18, 2) NULL,
	[Tasks_Sales_ID] [nvarchar](20) NULL,
	[Login_Create_DateTime] [datetime] NULL,
	[Login_Priority] [nvarchar](20) NULL,
	[HLMessageOBRContent] [nvarchar](max) NOT NULL,
	[LocationSource] [nvarchar](20) NULL,
	[OBRQuantity_TimingQuantity] [int] NULL,
	[OBRQuantity_TimingInterval] [int] NULL,
	[OBRQuantity_TimingDuration] [int] NULL,
	[OBRQuantity_TimingStartDate] [datetime] NULL,
	[OBRQuantity_TimingEndDate] [datetime] NULL,
	[OBRQuantity_TimingPriority] [nvarchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessageORCDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessageORCDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHLMessageORCDetails] AS TABLE(
	[ORCEvent_Type] [nvarchar](100) NULL,
	[Order_Control] [nvarchar](100) NULL,
	[Place_Order_Number] [nvarchar](100) NULL,
	[ORCPlEntity_Identifier] [nvarchar](100) NULL,
	[ORCFiller_Order_Number] [nvarchar](100) NULL,
	[ORCFEntity_Identifier] [nvarchar](100) NULL,
	[Placer_Group_Number] [nvarchar](100) NULL,
	[ORCPrEntity_Identifier] [nvarchar](100) NULL,
	[Order_Status] [nvarchar](100) NULL,
	[Response_Flag] [nvarchar](100) NULL,
	[ORCQuantity_Timing] [nvarchar](100) NULL,
	[Quantity] [nvarchar](100) NULL,
	[Interval] [nvarchar](100) NULL,
	[Duration] [nvarchar](100) NULL,
	[Start_Date_Time] [datetime] NULL,
	[End_Date_Time] [datetime] NULL,
	[ORCPriority] [nvarchar](100) NULL,
	[Parent_Order] [nvarchar](100) NULL,
	[Placer_Assigned_Identifier] [nvarchar](100) NULL,
	[Date_Time_Of_Transaction] [datetime] NULL,
	[Entered_By] [nvarchar](100) NULL,
	[EnterPerson_Identifier] [nvarchar](100) NULL,
	[EnterFamily_Name] [nvarchar](100) NULL,
	[EnterGiven_Name] [nvarchar](100) NULL,
	[EnterSecond_and_Further_Given_Names_or_Initials_Thereof] [nvarchar](100) NULL,
	[Verified_By] [nvarchar](100) NULL,
	[ORCOrdering_Provider] [nvarchar](100) NULL,
	[OrderingPerson_Identifier] [nvarchar](100) NULL,
	[OrderingFamily_Name] [nvarchar](100) NULL,
	[OrderingGiven_Name] [nvarchar](100) NULL,
	[OrderingSecond_and_Further_Given_Names_or_Initials_Thereof] [nvarchar](100) NULL,
	[ORCSuffix] [nvarchar](100) NULL,
	[ORCPrefix] [nvarchar](100) NULL,
	[ORCDegree] [nvarchar](100) NULL,
	[Enterer_Location] [nvarchar](100) NULL,
	[Point_of_Care] [nvarchar](100) NULL,
	[Room] [nvarchar](100) NULL,
	[Bed] [nvarchar](100) NULL,
	[Facility] [nvarchar](100) NULL,
	[Call_Back_Phone_Number] [nvarchar](100) NULL,
	[ORCTelephone_number] [nvarchar](100) NULL,
	[Order_Effective_Date_Time] [datetime] NULL,
	[Order_Control_Code_Reason] [nvarchar](100) NULL,
	[Entering_Organization] [nvarchar](100) NULL,
	[Entering_Device] [nvarchar](100) NULL,
	[Action_By] [nvarchar](100) NULL,
	[Advanced_Beneficiary_Notice_Code] [nvarchar](100) NULL,
	[Ordering_Facility_Name] [nvarchar](100) NULL,
	[Ordering_Facility_Address] [nvarchar](100) NULL,
	[Ordering_Facility_Phone_Number] [nvarchar](100) NULL,
	[Ordering_Provider_Address] [nvarchar](100) NULL,
	[Order_Status_Modifier] [nvarchar](100) NULL,
	[Advanced_Beneficiary_Notice_Override_Reason] [nvarchar](100) NULL,
	[Filler_Expected_Availability_Date_time] [datetime] NULL,
	[Confidentially_Code] [nvarchar](100) NULL,
	[Order_Type] [nvarchar](100) NULL,
	[Enterer_Authorization_Mode] [nvarchar](100) NULL,
	[ORCParent_Universal_Service_Identifier] [nvarchar](100) NULL,
	[HLMessageID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[HLMessageORCContent] [nvarchar](max) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessagePatientIDDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessagePatientIDDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHLMessagePatientIDDetails] AS TABLE(
	[PIDEvent_Type] [nvarchar](100) NULL,
	[Set_ID_PID] [nvarchar](100) NULL,
	[Patient_ID] [nvarchar](100) NULL,
	[Patient_Identifier_List] [nvarchar](100) NULL,
	[ID_Number] [nvarchar](100) NULL,
	[Identifier_Check_Digit] [nvarchar](100) NULL,
	[Check_Digit_Scheme] [nvarchar](100) NULL,
	[Alteration_Patient_ID_PID] [nvarchar](100) NULL,
	[Patient_Name] [nvarchar](100) NULL,
	[PIDFamily_Name] [nvarchar](100) NULL,
	[Given_Name] [nvarchar](100) NULL,
	[Second_and_further_given_Names_or_Initials_Thereof] [nvarchar](100) NULL,
	[PIDSuffix] [nvarchar](100) NULL,
	[PIDPrefix] [nvarchar](100) NULL,
	[PIDDegree] [nvarchar](100) NULL,
	[Mother_Maiden_Name] [nvarchar](100) NULL,
	[Date_time_Of_Birth] [datetime] NULL,
	[Date_Administrative_Sex] [nvarchar](100) NULL,
	[Patient_Alies] [nvarchar](100) NULL,
	[Race] [nvarchar](100) NULL,
	[Patient_Address] [nvarchar](max) NULL,
	[Street_Mailing_Address] [nvarchar](max) NULL,
	[Other_Designation] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[State_Of_Province] [nvarchar](100) NULL,
	[Zip_Or_Postal_Code] [nvarchar](100) NULL,
	[Country] [nvarchar](100) NULL,
	[PIDCountry_Code] [nvarchar](100) NULL,
	[Phone_Number_home] [nvarchar](100) NULL,
	[HTelephone_Number] [nvarchar](100) NULL,
	[HPhone_Number_Business] [nvarchar](100) NULL,
	[HBTelephone_Number] [nvarchar](100) NULL,
	[PIDAssigning_Authority] [nvarchar](max) NULL,
	[PIDIdentifier_Type_Code] [nvarchar](max) NULL,
	[Telecommunication_use_code] [nvarchar](100) NULL,
	[Telecommunication_Equipment_Type] [nvarchar](100) NULL,
	[Communication_Address] [nvarchar](max) NULL,
	[Phone_Number_Business] [nvarchar](100) NULL,
	[PIDTelephone_Number] [nvarchar](100) NULL,
	[Primary_Language] [nvarchar](100) NULL,
	[Marital_Status] [nvarchar](100) NULL,
	[Religion] [nvarchar](100) NULL,
	[Patient_Account_Number] [nvarchar](100) NULL,
	[ACID_Number] [nvarchar](100) NULL,
	[SSN_Number_Patient] [nvarchar](100) NULL,
	[Driver_License_Number_Patient] [nvarchar](100) NULL,
	[Mother_Identifier] [nvarchar](100) NULL,
	[MID_Number] [nvarchar](100) NULL,
	[Ethnic_Group] [nvarchar](100) NULL,
	[EGIdentifier] [nvarchar](100) NULL,
	[Birth_Place] [nvarchar](100) NULL,
	[Multiple_Birth_Indicator] [nvarchar](100) NULL,
	[Birth_Order] [nvarchar](100) NULL,
	[Citizenship] [nvarchar](100) NULL,
	[Veterans_Military_Status] [nvarchar](100) NULL,
	[Nationality] [nvarchar](100) NULL,
	[Patient_Death_Date_and_Time] [datetime] NULL,
	[Patient_Death_Indicator] [nvarchar](100) NULL,
	[Identity_Unknown_Indicator] [nvarchar](100) NULL,
	[Identity_reliability_Code] [nvarchar](100) NULL,
	[Last_Updated_DateTime] [datetime] NULL,
	[Last_Update_Facility] [nvarchar](100) NULL,
	[NamespaceID] [nvarchar](100) NULL,
	[Species_Code] [nvarchar](100) NULL,
	[Breed_Code] [nvarchar](100) NULL,
	[Strain] [nvarchar](100) NULL,
	[Production_Class_Code] [nvarchar](100) NULL,
	[Tribal_Citizenship] [nvarchar](100) NULL,
	[PIDIdentifier] [nvarchar](100) NULL,
	[Ward_Code] [nvarchar](100) NULL,
	[HLMessageID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[HLMessagePatientIDContent] [nvarchar](max) NOT NULL,
	[HTelecommunication_use_code] [nvarchar](100) NULL,
	[HTelecommunication_Equipment_Type] [nvarchar](100) NULL,
	[HCommunication_Address] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHLMessages]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHLMessages' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHLMessages] AS TABLE(
	[HLMessagesID] [int] NULL,
	[MsgControlId] [nvarchar](50) NOT NULL,
	[ParentControlId] [nvarchar](50) NULL,
	[OrgId] [int] NULL,
	[MsgType] [nvarchar](50) NULL,
	[Sending_App] [nvarchar](100) NULL,
	[Sending_Facility] [nvarchar](100) NULL,
	[Rec_App] [nvarchar](100) NULL,
	[Rec_Facility] [nvarchar](100) NULL,
	[TransferDatetime] [datetime] NULL,
	[msg_Content] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NOT NULL,
	[ErrorList] [nvarchar](max) NULL,
	[PatientVisitID] [bigint] NULL,
	[HL7Message] [varchar](max) NULL,
	[PatientIdentifier] [varchar](20) NULL,
	[StatusOfInbound] [varchar](50) NULL,
	[XMLERROR] [varchar](max) NULL,
	[OrderedId] [varchar](25) NULL,
	[ControlType] [varchar](15) NULL,
	[TaskDate] [datetime] NULL,
	[PickedAt] [datetime] NULL,
	[CompletedAt] [datetime] NULL,
	[MessageStatus] [nvarchar](100) NULL,
	[ErrorDescription] [varchar](max) NULL,
	[Futuredate] [datetime] NULL,
	[ParentHLMessagesID] [bigint] NULL,
	[FileNames] [nvarchar](200) NULL,
	[FileCreatedAt] [datetime] NULL,
	[FileModifiedAt] [datetime] NULL,
	[LocationID] [bigint] NULL,
	[Locations] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHolidayMaster]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHolidayMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTHolidayMaster] AS TABLE(
	[Scheduleid] [int] NULL,
	[Holidayid] [int] NULL,
	[Holidayname] [varchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTICDCode]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTICDCode' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTICDCode] AS TABLE(
	[ICDCode] [nvarchar](10) NULL,
	[ICDCategory] [int] NOT NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[IsUserDefined] [nvarchar](5) NULL,
	[OrgID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBY] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ComplaintName] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIdsforReport]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTIdsforReport' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTIdsforReport] AS TABLE(
	[IDs] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIntegrationDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTIntegrationDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTIntegrationDetails] AS TABLE(
	[Value] [nvarchar](max) NULL,
	[OrgID] [int] NULL,
	[ExternalID] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[XMLType] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInternalExternalQuality]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInternalExternalQuality' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInternalExternalQuality] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[AnalyteName] [nvarchar](256) NULL,
	[ResultValue] [nvarchar](50) NULL,
	[InternalResultValue] [nvarchar](50) NULL,
	[ExternalResultValue] [nvarchar](50) NULL,
	[Score] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[RootCause] [nvarchar](256) NULL,
	[Correction] [decimal](18, 3) NULL,
	[CorrectiveActions] [nvarchar](50) NULL,
	[PreventiveActions] [nvarchar](50) NULL,
	[Deviation] [decimal](18, 3) NULL,
	[EQMID] [bigint] NULL,
	[ID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInterpretationNotes]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInterpretationNotes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInterpretationNotes] AS TABLE(
	[ID] [bigint] NULL,
	[GENDER] [nchar](1) NULL,
	[AGEFROM] [int] NULL,
	[AGETO] [int] NULL,
	[AGEOPERATOR] [nvarchar](1) NULL,
	[CLIENTID] [int] NULL,
	[INTERPRETATION] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvBulkDataValue]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvBulkDataValue' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvBulkDataValue] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[Name] [nvarchar](50) NULL,
	[Value] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvBulkRate]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvBulkRate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvBulkRate] AS TABLE(
	[SNO] [int] NULL,
	[RateTypeID] [bigint] NULL,
	[OrgID] [int] NULL,
	[TestCode] [nvarchar](50) NULL,
	[TestType] [nvarchar](50) NULL,
	[TestName] [nvarchar](255) NULL,
	[RateName] [nvarchar](50) NULL,
	[Rate] [decimal](18, 2) NULL,
	[LabShareAmount] [decimal](18, 2) NULL,
	[FranchiseeShareAmount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInventoryLocations]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInventoryLocations' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInventoryLocations] AS TABLE(
	[LocationID] [int] NULL,
	[LocationName] [nvarchar](200) NULL,
	[LocationTypeID] [int] NULL,
	[OrgID] [int] NULL,
	[LID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[ProductTypeID] [nvarchar](200) NULL,
	[IsActive] [nvarchar](1) NULL,
	[ParentLocationID] [int] NULL,
	[DLNO] [nvarchar](50) NULL,
	[TINNO] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationConsumptionDetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationConsumptionDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvestigationConsumptionDetails] AS TABLE(
	[InvestigationProductMapDetailID] [bigint] NULL,
	[InvestigationProductMapID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[IsManualProcess] [int] NULL,
	[MethodID] [int] NULL,
	[DeviceID] [nvarchar](100) NULL,
	[ProductID] [bigint] NULL,
	[ConsumptionQty] [decimal](18, 9) NULL,
	[ConsumptionUOMID] [int] NULL,
	[CalibrationQty] [decimal](18, 9) NULL,
	[CalibrationUOMID] [int] NULL,
	[OrgID] [int] NULL,
	[ActionFlag] [varchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationdetails]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationdetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvestigationdetails] AS TABLE(
	[ResultID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[Name] [nvarchar](100) NULL,
	[Value] [nvarchar](max) NULL,
	[InvestigationMethodID] [bigint] NULL,
	[AbnormalFlag] [nvarchar](10) NULL,
	[ID] [int] NULL,
	[InvestigationName] [nvarchar](255) NULL,
	[TestType] [nvarchar](255) NULL,
	[SampleCode] [int] NULL,
	[SampleContainerID] [int] NULL,
	[SampleContainerColor] [nvarchar](255) NULL,
	[SampleType] [nvarchar](255) NULL,
	[Barcode] [nvarchar](255) NULL,
	[Rate] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationLocationMapping]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationLocationMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvestigationLocationMapping] AS TABLE(
	[InvestigationID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[LocationID] [int] NULL,
	[ProcessingOrgID] [bigint] NULL,
	[ProcessingAddressID] [int] NULL,
	[Type] [nvarchar](150) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationLocationMappingList]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationLocationMappingList' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvestigationLocationMappingList] AS TABLE(
	[Id] [bigint] NULL,
	[InvestigationID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[LocationID] [int] NULL,
	[ProcessingOrgID] [bigint] NULL,
	[ProcessingAddressID] [int] NULL,
	[Type] [nvarchar](150) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationMaster]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvestigationMaster] AS TABLE(
	[InvestigationID] [bigint] NOT NULL,
	[InvestigationName] [nvarchar](255) NULL,
	[UOMID] [int] NULL,
	[Display] [nchar](1) NULL,
	[TestCode] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvestigationQueue]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvestigationQueue' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvestigationQueue] AS TABLE(
	[VisitID] [bigint] NULL,
	[UID] [nvarchar](max) NOT NULL,
	[OrgID] [int] NOT NULL,
	[InvestigationID] [bigint] NOT NULL,
	[Type] [nvarchar](20) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[AccessionNumber] [bigint] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[IsReportable] [nchar](1) NULL,
	[IsBillable] [nchar](1) NULL,
	[ParentName] [nvarchar](max) NULL,
	[ParentInvId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoice]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoice' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvoice] AS TABLE(
	[FinalBillID] [bigint] NULL,
	[ClientID] [bigint] NULL,
	[InvoiceID] [bigint] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[RefID] [bigint] NULL,
	[RefType] [nvarchar](50) NULL,
	[Status] [nvarchar](10) NULL,
	[Reason] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceid]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceid' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvoiceid] AS TABLE(
	[Invoiceid] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceMaster]    Script Date: 6/25/2018 4:04:43 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvoiceMaster] AS TABLE(
	[ClientID] [int] NOT NULL,
	[ClientCode] [nvarchar](10) NULL,
	[ClientName] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[AddressType] [nvarchar](50) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[CountryID] [int] NULL,
	[StateID] [int] NULL,
	[EmailID] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[Termsconditions] [nvarchar](max) NULL,
	[CstNo] [nvarchar](50) NULL,
	[DespatchMode] [nvarchar](50) NULL,
	[ServiceTaxNo] [nvarchar](50) NULL,
	[PanNo] [nvarchar](50) NULL,
	[IsApproval] [nchar](3) NULL,
	[IsDeleted] [nchar](3) NULL,
	[Status] [nvarchar](50) NULL,
	[ClientTypeID] [int] NULL,
	[AddressID] [int] NULL,
	[Attributes] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceReceipts]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceReceipts' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvoiceReceipts] AS TABLE(
	[InvoiceID] [bigint] NULL,
	[InvoiceAmount] [decimal](18, 2) NULL,
	[ReceivedAmount] [decimal](18, 2) NULL,
	[PaymentTypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[OrgAddID] [int] NULL,
	[WriteOffAmt] [decimal](18, 2) NULL,
	[RoundOffAmt] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[WriteOffReason] [nvarchar](max) NULL,
	[CreditAmount] [decimal](18, 2) NULL,
	[ChequeDate] [datetime] NULL,
	[ChequeImage] [nvarchar](100) NULL,
	[DiscountAmount] [decimal] (18, 2) Null,
    [TDSAmount] [decimal] (18, 2) Null

)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvoiceSnapshot]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvoiceSnapshot' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvoiceSnapshot] AS TABLE(
	[Content] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](25) NULL,
	[NOTIFICATIONID] [bigint] NOT NULL,
	[ClientID] [bigint] NOT NULL,
	[InvoiceID] [bigint] NOT NULL,
	[Seq_Num] [int] NOT NULL,
	[Category] [nvarchar](25) NULL,
	[FromDate] [datetime] NULL,
	[TODate] [datetime] NULL,
	[ReportPath] [nvarchar](400) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvOrgNotifications]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvOrgNotifications' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvOrgNotifications] AS TABLE(
	[InvestigationID] [int] NULL,
	[OrgID] [int] NULL,
	[Type] [nvarchar](20) NULL,
	[ActionType] [nvarchar](20) NULL,
	[ActionTemplateID] [int] NULL,
	[NotifiedTo] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvPackageDeleting]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvPackageDeleting' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvPackageDeleting] AS TABLE(
	[PackageID] [int] NULL,
	[ID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[Active] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvPackageMapping]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvPackageMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvPackageMapping] AS TABLE(
	[PackageID] [int] NULL,
	[ID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[Active] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvQualitativeResultMaster]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvQualitativeResultMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvQualitativeResultMaster] AS TABLE(
	[ResultID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[Name] [nvarchar](50) NULL,
	[Value] [nvarchar](max) NULL,
	[InvestigationMethodID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvRateMaster]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvRateMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvRateMaster] AS TABLE(
	[Description_Name] [nvarchar](max) NULL,
	[Amount_For_OP] [decimal](18, 2) NULL,
	[Processed_Type] [nvarchar](max) NULL,
	[Discount_Category] [nvarchar](100) NULL,
	[CPT_Rate] [decimal](18, 2) NULL,
	[CPRT_Rate] [decimal](18, 2) NULL,
	[RateTypeID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvReasonMaster]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvReasonMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvReasonMaster] AS TABLE(
	[StatusID] [bigint] NULL,
	[ReasonID] [bigint] NULL,
	[ReasonDesc] [nvarchar](100) NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvReportMapping]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvReportMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvReportMapping] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[TemplateID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvReportTemplateMaster]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvReportTemplateMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvReportTemplateMaster] AS TABLE(
	[TemplateID] [int] NULL,
	[ReportTemplateName] [nvarchar](255) NULL,
	[IsDefault] [nchar](1) NULL,
	[OrgID] [int] NULL,
	[IsActive] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTinvSampleResults]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTinvSampleResults' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTinvSampleResults] AS TABLE(
	[VisitID] [bigint] NOT NULL,
	[SampleCode] [int] NOT NULL,
	[AttributesID] [int] NOT NULL,
	[SampleValues] [nvarchar](50) NOT NULL,
	[SampleDesc] [nvarchar](255) NULL,
	[CreatedBy] [int] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTInvValueRangeMaster]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvValueRangeMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTInvValueRangeMaster] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[ValueRange] [nvarchar](max) NULL,
	[OrgID] [int] NULL,
	[ReflexInvestigationID] [bigint] NULL,
	[IsReportable] [nchar](1) NULL,
	[IsChargeable] [nchar](1) NULL,
	[ReflexSampleType] [nvarchar](250) NULL,
	[Type] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIPTreatmentPlanMaster]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTIPTreatmentPlanMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTIPTreatmentPlanMaster] AS TABLE(
	[IPTreatmentPlanID] [int] NULL,
	[IPTreatmentPlanName] [nvarchar](100) NULL,
	[IPTreatmentPlanParentID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTKitStudyDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTKitStudyDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTKitStudyDetails] AS TABLE(
	[KitID] [nvarchar](100) NULL,
	[KitBacthNo] [nvarchar](100) NULL,
	[StudyID] [bigint] NULL,
	[SiteID] [bigint] NULL,
	[EpisodeVisitId] [bigint] NULL,
	[IndentID] [bigint] NULL,
	[ActualRaiseQty] [int] NULL,
	[RaisedQty] [int] NULL,
	[OrgID] [int] NULL,
	[OrgAddID] [int] NULL,
	[LocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[Status] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTMetaData]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTMetaData' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTMetaData] AS TABLE(
	[MetaDataID] [int] NULL,
	[Domain] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[DisplayText] [nvarchar](100) NULL,
	[LangCode] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTMRDDischargeAnalysis]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTMRDDischargeAnalysis' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTMRDDischargeAnalysis] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[CaseSheetRcvdStatus] [nvarchar](15) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTNotificationStatusBulkUpdate]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTNotificationStatusBulkUpdate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTNotificationStatusBulkUpdate] AS TABLE(
	[NotificationID] [int] NULL,
	[Status] [nvarchar](40) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTnutritionFoodDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTnutritionFoodDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTnutritionFoodDetails] AS TABLE(
	[VisitID] [bigint] NULL,
	[FoodMenuID] [bigint] NULL,
	[StartDate] [datetime] NULL,
	[Enddate] [datetime] NULL,
	[FoodSessionID] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[PlanedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[FoodID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[refType] [nvarchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrganization]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganization' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTOrganization] AS TABLE(
	[OrgID] [int] NULL,
	[OrgAddID] [bigint] NULL,
	[Name] [nvarchar](200) NULL,
	[OrganizationTypeID] [int] NULL,
	[LogoPath] [nvarchar](max) NULL,
	[Add1] [nvarchar](250) NULL,
	[Add2] [nvarchar](250) NULL,
	[Add3] [nvarchar](250) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[CountryID] [smallint] NULL,
	[City] [nvarchar](25) NULL,
	[StateID] [smallint] NULL,
	[LandLineNumber] [nvarchar](50) NULL,
	[Location] [nvarchar](50) NULL,
	[StartDTTM] [datetime] NULL,
	[EndDTTM] [datetime] NULL,
	[OtherCountryName] [nvarchar](60) NULL,
	[OtherStateName] [nvarchar](60) NULL,
	[MobileNumber] [nvarchar](15) NULL,
	[Isdefaultorg] [nvarchar](5) NULL,
	[DefaultOrgID] [bigint] NULL,
	ReportLanguage NVARCHAR(100)
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrthoPatientDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrthoPatientDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTOrthoPatientDetails] AS TABLE(
	[SpecialityPartsName] [nvarchar](255) NULL,
	[Status] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOutSourcingDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOutSourcingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTOutSourcingDetails] AS TABLE(
	[SampleTrackerID] [bigint] NULL,
	[SampleID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[OrgId] [int] NULL,
	[UID] [nvarchar](255) NULL,
	[OutsourcedDate] [datetime] NULL,
	[ReceivedDate] [datetime] NULL,
	[CourierDetails] [nvarchar](max) NULL,
	[Acknowledgement] [nvarchar](max) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[Absolute] [bit] NULL,
	[ReachedDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[AccessionNumber] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[OutSourcingLocationID] [bigint] NULL,
	[RefID] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPasswordPolicy]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPasswordPolicy' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPasswordPolicy] AS TABLE(
	[Type] [nchar](1) NULL,
	[PasswordLength] [int] NULL,
	[Splcharlen] [int] NULL,
	[Numcharlen] [int] NULL,
	[ValidityPeriodType] [nvarchar](50) NULL,
	[ValidityPeriod] [int] NULL,
	[PreviousPwdcount] [int] NULL,
	[OrgID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Id] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientBodyPartDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientBodyPartDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientBodyPartDetails] AS TABLE(
	[BodyPartsID] [bigint] NULL,
	[Position] [nvarchar](50) NULL,
	[ChildItemID] [bigint] NULL,
	[ChildItemDescription] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientComplaint]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientComplaint' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientComplaint] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Query] [nchar](1) NULL,
	[ComplaintType] [nvarchar](5) NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ICDCodeStatus] [nvarchar](20) NULL,
	[OnBehalf] [bigint] NULL,
	[PhysicianComments] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientComplaintIP]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientComplaintIP' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientComplaintIP] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[ComplaintName] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Query] [nchar](1) NULL,
	[ComplaintType] [nvarchar](5) NULL,
	[ICDCode] [nvarchar](10) NULL,
	[ICDDescription] [nvarchar](255) NULL,
	[ICDCodeStatus] [nvarchar](20) NULL,
	[OnBehalf] [bigint] NULL,
	[IsPrimarydiagnosed] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDepositHistory]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDepositHistory' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientDepositHistory] AS TABLE(
	[DepositID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[ReceiptNo] [bigint] NULL,
	[AmountDeposited] [decimal](18, 2) NULL,
	[PaymentTypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[Remarks] [nvarchar](150) NULL,
	[ServiceCharge] [decimal](18, 2) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[ConversionRate] [decimal](18, 4) NULL,
	[PaidCurrencyAmount] [decimal](18, 4) NULL,
	[CreatedBy] [bigint] NULL,
	[CardHolderName] [nvarchar](255) NULL,
	[CashGiven] [decimal](18, 2) NULL,
	[BalanceGiven] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDischargedWith]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDischargedWith' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientDischargedWith] AS TABLE(
	[DischargeID] [int] NOT NULL,
	[DischargedWithName] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](200) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDiscount]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDiscount' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientDiscount] AS TABLE(
	[DiscountID] [bigint] NULL,
	[DiscountCode] [nvarchar](50) NULL,
	[DiscountName] [nvarchar](50) NULL,
	[DiscountType] [nvarchar](50) NULL,
	[DiscountCeilingValue] [decimal](18, 2) NULL,
	[UserDiscountValue] [decimal](18, 2) NULL,
	[SlabCeilingValue] [decimal](18, 2) NULL,
	[SlabPercentage] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDueChart]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDueChart' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientDueChart] AS TABLE(
	[FeeType] [nvarchar](10) NULL,
	[FeeID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[Comments] [nvarchar](150) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Status] [nvarchar](15) NULL,
	[unit] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[DetailsID] [bigint] NULL,
	[PackageID] [bigint] NULL,
	[SpecialityID] [int] NULL,
	[UserID] [bigint] NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[IsReimbursable] [nchar](1) NULL,
	[IsTaxable] [nchar](1) NULL,
	[ServiceCode] [nvarchar](255) NULL,
	[DiscountPercent] [decimal](18, 2) NULL,
	[DiscOrEnhanceType] [nvarchar](10) NULL,
	[Remarks] [nvarchar](255) NULL,
	[ReimbursableAmount] [decimal](18, 2) NULL,
	[NonReimbursableAmount] [decimal](18, 2) NULL,
	[ActualAmount] [decimal](18, 2) NULL,
	[RateID] [bigint] NULL,
	[IsDiscountable] [nchar](1) NULL,
	[IsSTAT] [nchar](1) NULL,
	[IsOutSource] [nchar](1) NULL,
	[IsNABL] [nchar](1) NULL,
	[TatDate] [datetime] NULL,
	[BaseRateID] [bigint] NULL,
	[DiscountPolicyID] [bigint] NULL,
	[DiscountCategoryCode] [nvarchar](25) NULL,
	[ReportDeliveryDate] [datetime] NULL,
	[MaxTestDisPercentage] [decimal](18, 2) NULL,
	[MaxTestDisAmount] [decimal](18, 2) NULL,
	[BaseTestcalculationAmount] [decimal](18, 2) NULL,
	[IsRedeem] [nvarchar](1) NULL,
	[RedeemAmount] [decimal](18, 2) NULL,
	[RedeemPoints] [decimal](18, 2) NULL,
	[ClientFeeTypeRateCustID] [bigint] NULL,
	[DiscOrEnhanceRemarks] [nvarchar](255) NULL,
	[DiscOrEnhancePercent] [decimal](18, 2) NULL,
	[ReferralID] [int] NULL,
	[ReferralType] [nvarchar](55) NULL,
	[ItemCurrencyID] [bigint] NULL,
	[Tatreferencedatetime] [datetime] NULL,
	[Tatreferencedatebase] [tinyint] NULL,
	[Tatsamplereceiptdatetime] [datetime] NULL,
	[Tatprocessstartdatetime] [datetime] NULL,
	[Logistictimeinmins] [smallint] NULL,
	[Processingtimeinmins] [int] NULL,
	[Labendtime] [varchar](50) NULL,
	[Earlyreporttime] [varchar](50) NULL,
	[EligibleAmount] [decimal](18, 2) NULL,
	[CoSharing] [decimal](18, 2) NULL,
	[Performertype] [nvarchar](255) NULL
	,
	[CoPayValue] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDueChartForIP]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDueChartForIP' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientDueChartForIP] AS TABLE(
	[FeeType] [nvarchar](10) NULL,
	[FeeID] [bigint] NULL,
	[Description] [nvarchar](max) NULL,
	[Comments] [nvarchar](150) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Status] [nvarchar](15) NULL,
	[unit] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[DetailsID] [bigint] NULL,
	[PackageID] [bigint] NULL,
	[FromTable] [nvarchar](3) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[IsReimbursable] [nchar](1) NULL,
	[IsTaxable] [nchar](1) NULL,
	[ServiceCode] [nvarchar](255) NULL,
	[DiscountPercent] [decimal](18, 2) NULL,
	[DiscOrEnhanceType] [nvarchar](10) NULL,
	[Remarks] [nvarchar](255) NULL,
	[ReimbursableAmount] [decimal](18, 2) NULL,
	[NonReimbursableAmount] [decimal](18, 2) NULL,
	[ActualAmount] [decimal](18, 2) NULL,
	[RateID] [bigint] NULL,
	[IsDiscountable] [nchar](1) NULL,
	[IsSTAT] [nchar](1) NULL,
	[IsOutSource] [nchar](1) NULL,
	[IsNABL] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientDueDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientDueDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientDueDetails] AS TABLE(
	[PatientDueID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[FinalBillID] [bigint] NULL,
	[PatientNumber] [nvarchar](30) NULL,
	[PatientName] [nvarchar](255) NULL,
	[DueAmount] [decimal](18, 2) NULL,
	[DuePaidAmt] [decimal](18, 2) NULL,
	[ExistingDueAmt] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[OrgID] [int] NULL,
	[ReceiptNo] [nvarchar](30) NULL,
	[IsCreditBill] [nchar](1) NULL,
	[Status] [nvarchar](25) NULL,
	[WriteOffAmt] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientHistoStatusDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientHistoStatusDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientHistoStatusDetails] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[BarcodeNumber] [nvarchar](500) NOT NULL,
	[CompletionTime] [datetime] NULL,
	[Status] [nvarchar](200) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientInvestigation]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientInvestigation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientInvestigation] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [nvarchar](250) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[InvestigationMethodID] [bigint] NULL,
	[InvestigationSampleContainerID] [int] NULL,
	[SampleID] [int] NULL,
	[InvestigationSiteID] [int] NULL,
	[IsCompleted] [nchar](1) NULL,
	[CollectedDateTime] [datetime] NULL,
	[Status] [nvarchar](100) NULL,
	[ComplaintId] [int] NULL,
	[GroupID] [int] NULL,
	[GroupName] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
	[ReportStatus] [nvarchar](255) NULL,
	[ReferenceRange] [nvarchar](max) NULL,
	[MethodName] [nvarchar](255) NULL,
	[IPInvSampleCollectionMasterID] [bigint] NULL,
	[OrgID] [int] NULL,
	[WorklistDeletedStatus] [nvarchar](50) NULL,
	[PerformingPhysicainName] [nvarchar](500) NULL,
	[KitID] [bigint] NULL,
	[KitName] [nvarchar](255) NULL,
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [nvarchar](255) NULL,
	[Interpretation] [nvarchar](max) NULL,
	[PrincipleID] [bigint] NULL,
	[WorkListID] [bigint] NULL,
	[DeviceID] [nvarchar](255) NULL,
	[PatientInvID] [bigint] NULL,
	[IsSensitive] [nvarchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientMuscleDetail]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientMuscleDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientMuscleDetail] AS TABLE(
	[MuscleID] [bigint] NULL,
	[MusclePower] [nvarchar](255) NULL,
	[MuscleTone] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientMuscleWasting]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientMuscleWasting' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientMuscleWasting] AS TABLE(
	[Status] [nvarchar](100) NULL,
	[ItemID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientNeurologicalDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientNeurologicalDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientNeurologicalDetails] AS TABLE(
	[NeurologicalType] [nvarchar](255) NULL,
	[ItemID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientoneInvSampleTransfer]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientoneInvSampleTransfer' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientoneInvSampleTransfer] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleID] [bigint] NULL,
	[RecSampleLocID] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[UID] [nvarchar](205) NULL,
	[IsIntegrationTest] [tinyint] NULL,
	[Type] [nvarchar](10) NULL,
	[CreatedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientOpenWound]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientOpenWound' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientOpenWound] AS TABLE(
	[Size] [nvarchar](255) NULL,
	[Units] [nvarchar](50) NULL,
	[Location] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTpatientQualification]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTpatientQualification' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTpatientQualification] AS TABLE(
	[PatientID] [bigint] NULL,
	[MetaTypeID] [nvarchar](25) NULL,
	[MetaValueID] [nvarchar](25) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientReflexes]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientReflexes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientReflexes] AS TABLE(
	[ReflexesTypeID] [bigint] NULL,
	[Position] [nvarchar](100) NULL,
	[Status] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPatientVascularDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientVascularDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPatientVascularDetails] AS TABLE(
	[VascularDeficitID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPCClientMapping]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPCClientMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPCClientMapping] AS TABLE(
	[RefPhyID] [int] NULL,
	[RefOrgID] [bigint] NULL,
	[PayerID] [int] NULL,
	[RateID] [int] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPCCustomPriceMapping]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPCCustomPriceMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPCCustomPriceMapping] AS TABLE(
	[ID] [bigint] NULL,
	[Name] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[Type] [nvarchar](10) NULL,
	[RefOrgID] [bigint] NULL,
	[RefPhyID] [int] NULL,
	[Rate] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPharmacyBillingDetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPharmacyBillingDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPharmacyBillingDetails] AS TABLE(
	[BillingDetailsID] [bigint] NULL,
	[FromTable] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPharmacyDueChart]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPharmacyDueChart' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPharmacyDueChart] AS TABLE(
	[DetailsID] [bigint] NULL,
	[FromTable] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPharmacyDueReference]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPharmacyDueReference' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPharmacyDueReference] AS TABLE(
	[FeeType] [nvarchar](50) NULL,
	[FeeID] [bigint] NULL,
	[ItemName] [nvarchar](255) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPreQuotationInvestigations]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPreQuotationInvestigations' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPreQuotationInvestigations] AS TABLE(
	[ID] [bigint] NULL,
	[Name] [nvarchar](200) NULL,
	[Type] [nvarchar](200) NULL,
	[SampleType] [nvarchar](200) NULL,
	[SampleCount] [int] NULL,
	[DiscountType] [nvarchar](100) NULL,
	[DiscountValue] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Status] [nvarchar](200) NULL,
	[PkgID] [bigint] NULL,
	[PkgName] [nvarchar](255) NULL,
	[AccessionNumber] [bigint] NULL,
	[PkgAmt] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTPreQuotationList]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPreQuotationList' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTPreQuotationList] AS TABLE(
	[ID] [bigint] NULL,
	[Name] [nvarchar](200) NULL,
	[Type] [nvarchar](200) NULL,
	[SampleType] [nvarchar](200) NULL,
	[SampleCount] [int] NULL,
	[DiscountType] [nvarchar](100) NULL,
	[DiscountValue] [decimal](18, 0) NULL,
	[Amount] [decimal](18, 0) NULL,
	[Status] [nvarchar](200) NULL,
	[PkgID] [bigint] NULL,
	[PkgName] [nvarchar](255) NULL,
	[AccessionNumber] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTQCValuesdetails]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTQCValuesdetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTQCValuesdetails] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[TestCode] [nvarchar](100) NULL,
	[InvestigationName] [nvarchar](510) NULL,
	[InstrumentID] [bigint] NULL,
	[QCValueID] [bigint] NULL,
	[QCLevel] [varchar](30) NULL,
	[OrgAddressID] [bigint] NULL,
	[value1] [nvarchar](20) NULL,
	[value2] [nvarchar](20) NULL,
	[value3] [nvarchar](20) NULL,
	[value4] [nvarchar](20) NULL,
	[ProcessedAt] [datetime] NULL,
	[IsUpdate] [char](1) NULL,
	[LotID] [bigint] NULL,
	[LotName] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRate]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTRate] AS TABLE(
	[Rateid] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTReAssignedTask]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTReAssignedTask' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTReAssignedTask] AS TABLE(
	[TaskID] [bigint] NULL,
	[AssignedTo] [bigint] NULL,
	[PatientVisitID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTReferralPolicy]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTReferralPolicy' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTReferralPolicy] AS TABLE(
	[Categoryid] [bigint] NOT NULL,
	[CategoryName] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[Modifiedby] [bigint] NULL,
	[Fromrange] [bigint] NULL,
	[Torange] [bigint] NULL,
	[Payout] [bigint] NULL,
	[Payon] [nvarchar](10) NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTReportSnapshot]    Script Date: 6/25/2018 4:04:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTReportSnapshot' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTReportSnapshot] AS TABLE(
	[Content] [nvarchar](max) NOT NULL,
	[TemplateID] [nvarchar](25) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[ReportPath] [nvarchar](400) NULL,
	[AccessionNumber] [nvarchar](1000) NULL,
	[NotificationID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[Seq_Num] [int] NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTResourceConsumption]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTResourceConsumption' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTResourceConsumption] AS TABLE(
	[PatientID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[ServiceName] [nvarchar](100) NULL,
	[ServiceID] [bigint] NULL,
	[ResourceName] [nvarchar](100) NULL,
	[ResourceID] [bigint] NULL,
	[ConsumptionValue] [nvarchar](100) NULL,
	[ConsumptionDate] [datetime] NULL,
	[Comments] [nvarchar](200) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ServiceType] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRole]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRole' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTRole] AS TABLE(
	[RoleID] [bigint] NULL,
	[RoleName] [nvarchar](200) NULL,
	[Description] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [bigint] NULL,
	[DeptID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRoleMenuInfo]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRoleMenuInfo' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTRoleMenuInfo] AS TABLE(
	[UserMenuID] [bigint] NULL,
	[MenuID] [int] NULL,
	[RoleID] [bigint] NULL,
	[RoleName] [nvarchar](255) NULL,
	[ParentID] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[MenuHeader] [nvarchar](255) NULL,
	[IsMapped] [nchar](1) NULL,
	[HasAction] [nchar](1) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Description] [nvarchar](max) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRoleUser]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRoleUser' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTRoleUser] AS TABLE(
	[ID] [int] NULL,
	[RoleName] [nvarchar](200) NULL,
	[UserName] [nvarchar](200) NULL,
	[RoleID] [bigint] NULL,
	[UserID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTRoundMasterAttributes]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTRoundMasterAttributes' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTRoundMasterAttributes] AS TABLE(
	[ID] [int] NULL,
	[RoundID] [bigint] NOT NULL,
	[ClinicID] [int] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[SequenceNo] [int] NOT NULL,
	[EstimatedTime] [nvarchar](50) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSampleArchival]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSampleArchival' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSampleArchival] AS TABLE(
	[ID] [int] NULL,
	[StorageRackID] [int] NULL,
	[RowNo] [smallint] NULL,
	[ColumnNo] [smallint] NULL,
	[BarcodeNo] [nvarchar](50) NULL,
	[DeptID] [int] NULL,
	[InstrumentID] [int] NULL,
	[Active] [bit] NULL,
	[Status] [nvarchar](40) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSampleTracker]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSampleTracker' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSampleTracker] AS TABLE(
	[SampleTrackerID] [int] NULL,
	[PatientVisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[InvSampleStatusID] [int] NULL,
	[CurrentOrgID] [int] NULL,
	[DeptID] [int] NULL,
	[Reason] [nvarchar](500) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IPInvSampleCollectionMasterID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleDesc] [nvarchar](250) NULL,
	[InvSampleStatusDesc] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSaveFoodOrderDetails]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSaveFoodOrderDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSaveFoodOrderDetails] AS TABLE(
	[FoodID] [bigint] NULL,
	[FoodOrderDate] [datetime] NULL,
	[OrderBy] [bigint] NULL,
	[WardBy] [bigint] NULL,
	[Status] [nvarchar](100) NULL,
	[UOM] [nvarchar](100) NULL,
	[Quantity] [decimal](18, 0) NULL,
	[PatientDietPlanID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTScheduledMOM]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTScheduledMOM' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTScheduledMOM] AS TABLE(
	[scheduledMOMID] [bigint] NULL,
	[PlanScheduleID] [bigint] NULL,
	[PointsDiscussed] [nvarchar](max) NULL,
	[ActionProposed] [nvarchar](max) NULL,
	[ProposedCompDate] [datetime] NULL,
	[ResponsiblePerson] [bigint] NULL,
	[status] [varchar](30) NULL,
	[DeptID] [int] NULL,
	[OrgID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTServiceCode]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTServiceCode' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTServiceCode] AS TABLE(
	[FinalBillID] [bigint] NOT NULL,
	[BillingDetailsID] [bigint] NOT NULL,
	[ServiceCode] [nvarchar](255) NULL,
	[DisplayText] [nvarchar](255) NULL,
	[ClientID] [bigint] NULL,
	[DummyString] [nvarchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTServiceQuotation]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTServiceQuotation' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTServiceQuotation] AS TABLE(
	[TokenNumber] [int] NOT NULL,
	[TITLECode] [tinyint] NULL,
	[PatientName] [nvarchar](150) NULL,
	[SEX] [char](1) NULL,
	[DOB] [datetime] NULL,
	[Age] [nvarchar](20) NULL,
	[LandLineNumber] [nvarchar](30) NULL,
	[CreatedAt] [datetime] NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[EMail] [nvarchar](100) NULL,
	[ClientID] [int] NULL,
	[FeeType] [nvarchar](50) NULL,
	[SourceType] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgAddressID] [bigint] NULL,
	[OtherOrgID] [int] NULL,
	[CollectionAddress] [nvarchar](250) NULL,
	[RoleID] [bigint] NULL,
	[UserID] [bigint] NULL,
	[CollectionTime] [datetime] NULL,
	[BookingOrgID] [int] NULL,
	[BookingStatus] [nchar](1) NULL,
	[CollectionAddress2] [nvarchar](250) NULL,
	[City] [nvarchar](25) NULL,
	[PatientNumber] [nvarchar](30) NULL,
	[BookingID] [bigint] NULL,
	[BillDescription] [nvarchar](max) NULL,
	[Priority] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[Pincode] [nvarchar](max) NULL,
	[StateID] [bigint] NULL,
	[CityID] [bigint] NULL,
	[URNTypeID] [bigint] NULL,
	[URNO] [nvarchar](max) NULL,
	[DispatchValue] [nvarchar](max) NULL,
	[ReferalID] [bigint] NULL,
	[TokenID] [nvarchar](20) NULL,
	[RefPhysicianName] [nvarchar](100) NULL,
	[NRICNumber] [nvarchar](100) NULL,
	[NRICType] [nvarchar](100) NULL,
	[ExterNalPatNo] [nvarchar](100) NULL,
	Location NVARCHAR(1000) NULL,
	ERPPatientNumber NVARCHAR(300) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStockReceivedAttributesDetails]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTStockReceivedAttributesDetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTStockReceivedAttributesDetails] AS TABLE(
	[Details] [bigint] NULL,
	[StockReceivedDetailsId] [bigint] NULL,
	[CategorieMappingID] [int] NULL,
	[AttributesKey] [nvarchar](100) NULL,
	[AttributesValue] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStockReceivedBarcode]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTStockReceivedBarcode' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTStockReceivedBarcode] AS TABLE(
	[StockReceivedItemID] [bigint] NULL,
	[StockReceivedItemDetailID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[ProductName] [nvarchar](300) NULL,
	[ParentBarCode] [nvarchar](300) NULL,
	[ChildBarCode] [nvarchar](300) NULL,
	[RECUnit] [nvarchar](100) NULL,
	[Status] [nvarchar](300) NULL,
	[Commands] [nvarchar](300) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStockReturnAmount]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTStockReturnAmount' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTStockReturnAmount] AS TABLE(
	[StockReturnId] [bigint] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[ReferenceNo] [nvarchar](250) NULL,
	[Type] [nvarchar](250) NULL,
	[Amount] [decimal](18, 2) NULL,
	[BatchNo] [nvarchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSURGERY]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSURGERY' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSURGERY] AS TABLE(
	[Id] [bigint] NULL,
	[Name] [nvarchar](150) NULL,
	[ChiefSurgeonID] [bigint] NULL,
	[Type] [nvarchar](150) NULL,
	[TreatmentName] [nvarchar](150) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSurgeryPackageDeleting]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSurgeryPackageDeleting' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSurgeryPackageDeleting] AS TABLE(
	[PackageID] [int] NULL,
	[FeeID] [bigint] NULL,
	[FeeType] [nvarchar](10) NULL,
	[DrugGenericID] [bigint] NULL,
	[SpecialtyID] [int] NULL,
	[PkgQuantity] [decimal](18, 2) NULL,
	[ItemName] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSurgeryPackageFeeTypeRateMaster]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSurgeryPackageFeeTypeRateMaster' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSurgeryPackageFeeTypeRateMaster] AS TABLE(
	[FeeTypeRateMasterID] [bigint] NULL,
	[PackageID] [bigint] NULL,
	[Feetype] [nvarchar](50) NULL,
	[RateID] [bigint] NULL,
	[SpecialtyID] [int] NULL,
	[MaxAmountAllowed] [decimal](18, 2) NULL,
	[Createdby] [nvarchar](20) NULL,
	[CreatedAt] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTSurgeryPackageMapping]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTSurgeryPackageMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTSurgeryPackageMapping] AS TABLE(
	[PackageID] [int] NULL,
	[FeeID] [bigint] NULL,
	[FeeType] [nvarchar](10) NULL,
	[DrugGenericID] [bigint] NULL,
	[SpecialtyID] [int] NULL,
	[PkgQuantity] [decimal](18, 2) NULL,
	[ItemName] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTaskDefaultSearch]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTaskDefaultSearch' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTaskDefaultSearch] AS TABLE(
	[LoginID] [bigint] NULL,
	[RoleID] [bigint] NULL,
	[OrgID] [bigint] NULL,
	[OrgAddressID] [bigint] NULL,
	[LocationID] [int] NULL,
	[Type] [nvarchar](10) NULL,
	[TypeID] [int] NULL,
	[Value] [nvarchar](510) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTasks]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTasks' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTasks] AS TABLE(
	[TaskActionID] [int] NULL,
	[TaskDescription] [nvarchar](max) NULL,
	[RedirectURL] [nvarchar](max) NULL,
	[PatientID] [bigint] NULL,
	[AssignedTo] [bigint] NULL,
	[OrgID] [int] NULL,
	[ParentID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[HighlightColor] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[SpecialityID] [int] NULL,
	[AllowDuplicate] [nchar](1) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTatlogisticdetails]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTatlogisticdetails' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTatlogisticdetails] AS TABLE(
	[Logisticdetailsid] [int] NULL,
	[Fromorgid] [int] NULL,
	[Fromorgaddressid] [bigint] NULL,
	[Toorgid] [int] NULL,
	[Toorgaddressid] [bigint] NULL,
	[Transittimevalue] [smallint] NULL,
	[Transittimetype] [char](1) NULL,
	[TransittimeName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[Createdby] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[Modifiedby] [bigint] NULL,
	[Modifiedat] [datetime] NULL,
	[Fromorgname] [nvarchar](50) NULL,
	[Fromlocationname] [nvarchar](50) NULL,
	[Toorgname] [nvarchar](50) NULL,
	[Tolocationname] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTATRANDOMBATCHSCHEDULE]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTATRANDOMBATCHSCHEDULE' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTATRANDOMBATCHSCHEDULE] AS TABLE(
	[Scheduleid] [int] NULL,
	[Schedulecode] [varchar](50) NULL,
	[Schedulename] [varchar](50) NULL,
	[Reportedon] [varchar](50) NULL,
	[Processinghours] [smallint] NULL,
	[Processingmins] [smallint] NULL,
	[Earlyreporttime] [nvarchar](25) NULL,
	[Tatprocesstype] [tinyint] NULL,
	[Scheduleday] [nvarchar](255) NULL,
	[Tatmode] [tinyint] NULL,
	[Tatcalculationbase] [tinyint] NULL,
	[Randombatchid] [int] NULL,
	[Batchstarttime] [nvarchar](25) NULL,
	[Cutofftime] [nvarchar](25) NULL,
	[Orgid] [int] NULL,
	[Flag] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTatschedulemapping]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTatschedulemapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTatschedulemapping] AS TABLE(
	[Schedulemappingid] [int] NULL,
	[Scheduleid] [int] NULL,
	[Testid] [bigint] NULL,
	[Testtype] [varchar](10) NULL,
	[Clientid] [bigint] NULL,
	[Orgid] [int] NULL,
	[Createdby] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[IsActive] [bit] NULL,
	[Modifiedby] [bigint] NULL,
	[Modifiedat] [datetime] NULL,
	[CategoryType] [nvarchar](50) NULL,
	[CategoryID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTPAPayment]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTPAPayment' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTPAPayment] AS TABLE(
	[VisitID] [bigint] NULL,
	[TypeID] [int] NULL,
	[Description] [nvarchar](50) NULL,
	[Comments] [nvarchar](150) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Status] [nvarchar](15) NULL,
	[unit] [numeric](18, 0) NULL,
	[Amount] [decimal](18, 2) NULL,
	[DetailsID] [bigint] NULL,
	[RightOff] [decimal](18, 2) NULL,
	[TDS] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[BankNameorCardType] [nvarchar](50) NULL,
	[ChequeorCardNumber] [nvarchar](100) NULL,
	[TPADiscountAmt] [decimal](18, 2) NULL,
	[TPASettledAmt] [decimal](18, 2) NULL,
	[TPADisallowedAmt] [decimal](18, 2) NULL,
	[TPARemarks] [nvarchar](255) NULL,
	[TPAApproverID] [bigint] NULL,
	[TPAApproverName] [nvarchar](150) NULL,
	[TPAApprovedDate] [datetime] NULL,
	[TPAWriteOffApprover] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTrainingProgram]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTrainingProgram' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTrainingProgram] AS TABLE(
	[OrgID] [bigint] NULL,
	[PlanScheduleID] [bigint] NULL,
	[ExamType] [nvarchar](20) NULL,
	[Participant] [nvarchar](20) NULL,
	[TotalMarks] [int] NULL,
	[MarksObtained] [int] NULL,
	[Remarks] [nvarchar](100) NULL,
	[TrainingProgramID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTRFfilemanager]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTTRFfilemanager' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTTRFfilemanager] AS TABLE(
	[FileID] [bigint] NULL,
	[FileUrl] [nvarchar](300) NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[IdentifyingID] [bigint] NULL,
	[IdentifyingType] [nvarchar](20) NULL,
	[FileName] [nvarchar](300) NULL,
	[FilePath] [nvarchar](300) NULL,
	[Createdby] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[Isactive] [nvarchar](5) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTVisitGenerateListUpdate]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTVisitGenerateListUpdate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTVisitGenerateListUpdate] AS TABLE(
	[SampleID] [nvarchar](150) NULL,
	[Temperature] [nvarchar](40) NULL,
	[location] [nvarchar](100) NULL,
	[SampleDescrip] [nvarchar](500) NULL,
	[Vendor] [nvarchar](100) NULL,
	[Quality] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTVisitPurpose]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTVisitPurpose' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTVisitPurpose] AS TABLE(
	[VisitPurposeID] [int] NULL,
	[VisitPurposeName] [nvarchar](25) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [bigint] NULL,
	[VisitType] [nvarchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTVitekDeviceIntegrationResult]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTVitekDeviceIntegrationResult' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTVitekDeviceIntegrationResult] AS TABLE(
	[VisitID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[GroupID] [int] NULL,
	[InvestigationID] [bigint] NULL,
	[DeviceCode] [nvarchar](50) NULL,
	[Barcode] [nvarchar](250) NULL,
	[OrganismCode] [nvarchar](200) NULL,
	[OrganismName] [nvarchar](200) NULL,
	[DrugCode] [nvarchar](200) NULL,
	[DrugName] [nvarchar](200) NULL,
	[Sensitivity] [nvarchar](200) NULL,
	[MicValue] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UpdateAndInsertDueTable]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UpdateAndInsertDueTable' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UpdateAndInsertDueTable] AS TABLE(
	[DueBillNo] [bigint] NULL,
	[BillAmount] [decimal](18, 2) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[PaidBillNo] [bigint] NULL,
	[PaidDate] [datetime] NULL,
	[CollectedBy] [bigint] NULL,
	[DisCountAmt] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UPDTPatientPrescription]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UPDTPatientPrescription' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UPDTPatientPrescription] AS TABLE(
	[PrescriptionID] [bigint] NULL,
	[PatientVisitID] [bigint] NULL,
	[DrugName] [nvarchar](100) NULL,
	[DrugFormulation] [nvarchar](100) NULL,
	[DrugFrequency] [nvarchar](100) NULL,
	[ROA] [nvarchar](255) NULL,
	[Dose] [nvarchar](255) NULL,
	[Duration] [nvarchar](100) NULL,
	[Instruction] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ComplaintID] [int] NULL,
	[DrugStatus] [nvarchar](25) NULL,
	[Direction] [nvarchar](500) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UTD_TRFFilecollection]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UTD_TRFFilecollection' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UTD_TRFFilecollection] AS TABLE(
	[FileID] [bigint] NULL,
	[FileUrl] [nvarchar](300) NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[IdentifyingID] [bigint] NULL,
	[IdentifyingType] [nvarchar](20) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UTTStatus]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UTTStatus' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UTTStatus] AS TABLE(
	[status] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[VisitClientMapping]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'VisitClientMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[VisitClientMapping] AS TABLE(
	[VisitClientMappingID] [bigint] NULL,
	[VisitID] [bigint] NOT NULL,
	[ClientID] [bigint] NOT NULL,
	[FinalBillID] [bigint] NOT NULL,
	[RateID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[PreAuthAmount] [decimal](18, 2) NULL,
	[PreAuthApprovalNumber] [nvarchar](100) NULL,
	[ClaimAmount] [decimal](18, 2) NULL,
	[ClaimLogic] [int] NULL,
	[CoPayment] [decimal](18, 2) NULL,
	[CopaymentPercent] [decimal](18, 2) NULL,
	[CoPaymentLogic] [int] NULL,
	[NonMedicalAmount] [decimal](18, 2) NULL,
	[ClientAttributes] [nvarchar](max) NULL,
	[IsAllMedical] [nchar](1) NULL,
	[PaymentStatus] [nvarchar](255) NULL,
	[ClientName] [nvarchar](128) NULL,
	[RateName] [nvarchar](128) NULL,
	[AsCreditBill] [nvarchar](1) NULL,
	[PolicyNo] [nvarchar](50) NULL,
	[PolicyStartDate] [datetime] NULL,
	[PolicyEndDate] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[VisitKnowledgeMapping]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'VisitKnowledgeMapping' AND ss.name = N'dbo')
CREATE TYPE [dbo].[VisitKnowledgeMapping] AS TABLE(
	[VisitKnowledgeMappingID] [bigint] NULL,
	[KnowledgeOfServiceID] [smallint] NULL,
	[Description] [nvarchar](50) NULL,
	[AttributeID] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[visittemplate]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'visittemplate' AND ss.name = N'dbo')
CREATE TYPE [dbo].[visittemplate] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[FeeID] [bigint] NULL,
	[FeeType] [nvarchar](50) NULL,
	[TemplateID] [bigint] NULL,
	[TemplateData] [nvarchar](max) NULL,
	[FinalBillID] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[WorkListInvestigations]    Script Date: 6/25/2018 4:04:45 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'WorkListInvestigations' AND ss.name = N'dbo')
CREATE TYPE [dbo].[WorkListInvestigations] AS TABLE(
	[InvestigationName] [nvarchar](255) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[GroupName] [nvarchar](255) NULL,
	[GroupComment] [nvarchar](255) NULL,
	[PatientVisitID] [bigint] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CollectedDateTime] [datetime] NULL,
	[Status] [nvarchar](100) NULL,
	[ComplaintID] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[InvestigationMethodID] [bigint] NULL,
	[MethodName] [nvarchar](255) NULL,
	[KitID] [bigint] NULL,
	[KitName] [nvarchar](255) NULL,
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [nvarchar](255) NULL,
	[Interpretation] [nvarchar](255) NULL,
	[PrincipleID] [bigint] NULL,
	[PrincipleName] [nvarchar](255) NULL,
	[QCData] [nvarchar](max) NULL,
	[InvestigationSampleContainerID] [int] NULL,
	[PackageID] [int] NULL,
	[PackageName] [nvarchar](255) NULL,
	[UID] [nvarchar](255) NULL
)
GO

IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'OrganismMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[OrganismMapping]
GO
CREATE TYPE [dbo].[OrganismMapping] AS TABLE(
	[MappingID] [bigint] NULL,
	[InvestigationId] [bigint] NULL,
	[OrganismId] [int] NULL,
	[DrugID] [int] NULL,
	[SequenceNo] [int] NULL
)
GO

IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvSampleMapping]
GO
CREATE TYPE [dbo].[PatientInvSampleMapping] AS TABLE(
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleID] [int] NULL,
	[ID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[Barcode] [nvarchar](250) NULL,
	[UniqueID] [nvarchar](255) NULL,
	[ExternalBarcode] [nvarchar](250) NULL
)
GO

IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleCollected' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvSampleCollected]
GO
CREATE TYPE [dbo].[PatientInvSampleCollected] AS TABLE(
	[PatientVisitID] [bigint] NOT NULL,
	[SampleID] [int] NULL,
	[BarcodeNumber] [nvarchar](250) NULL,
	[SampleCode] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[InvSampleStatusID] [int] NULL,
	[DeptID] [int] NULL,
	[Reason] [nvarchar](500) NULL,
	[SampleContainerID] [int] NULL,
	[UID] [nvarchar](255) NULL,
	[CollectedLocID] [int] NULL,
	[RecSampleLocID] [int] NULL,
	[SampleRelationshipID] [int] NULL,
	[CollectedDateTime] [datetime] NULL,
	[VmValue] [int] NULL,
	[VmUnitID] [int] NULL,
	[SampleConditionID] [int] NULL,
	[ConsignmentNo] [nvarchar](50) NULL,
	[ExternalBarcode] [nvarchar](250) NULL,
        [BarcodeCount] [int] NULL
)
GO
/* BEGIN | sabari | 20181129 | Dev | Culture Report */
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDrugLevelMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDrugLevelMapping]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTDrugLevelMapping]    Script Date: 12/5/2018 5:29:58 PM ******/
CREATE TYPE [dbo].[UDTDrugLevelMapping] AS TABLE(
	[LevelID] [bigint] NULL,
	[LevelName] [nvarchar](200) NULL,
	[DrugID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [bit] NULL,
	[OrgID] [int] NULL
)
GO
/* END | sabari | 20181129 | Dev | Culture Report */

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_OrderStatus' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_OrderStatus]
GO

/****** Object:  UserDefinedTableType [dbo].[UDT_OrderStatus]    Script Date: 2/21/2019 6:43:39 PM ******/
CREATE TYPE [dbo].[UDT_OrderStatus] AS TABLE(
	[MessageID] [bigint] NULL,
	[OrgCode] [nvarchar](5) NULL,
	[OrderID] [bigint] NULL,
	[ExternalPatientID] [nvarchar](25) NULL,
	[ExternalVisitID] [nvarchar](25) NULL,
	[LISPatientID] [bigint] NULL,
	[LISVisitID] [bigint] NULL,
	[OrderedTestCode] [nvarchar](10) NULL,
	[OrderedTestName] [nvarchar](250) NULL,
	[ContentTestCode] [nvarchar](10) NULL,
	[ContentTestName] [nvarchar](250) NULL,
	[OrderedTestStatus] [nvarchar](100) NULL,
	[ContentTestStatus] [nvarchar](100) NULL,
	[OrderedStatusDateTime] [datetime] NULL,
	[ContentStatusDateTime] [datetime] NULL,
	[ProcessStatus] [nchar](1) NULL,
	[ProcessComments] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedAtDateTime] [datetime] NULL,
	[ProcessedBy] [nvarchar](50) NULL,
	[ProcessedDateTime] [datetime] NULL
)
GO
------------------------ Added by Jayaramana L -------------
 
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTInvOrganismDrugMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTInvOrganismDrugMapping]
GO
--DROP TYPE [dbo].[UDTInvOrganismDrugMapping]
--GO
 
CREATE TYPE [dbo].[UDTInvOrganismDrugMapping] AS TABLE(
	[DrugName] [nvarchar](100) NULL,
	[DrugID] [bigint] NULL,
	[DrugCode] [nvarchar](100) NULL,
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [nvarchar](100) NULL,
	[OrganismID] [bigint] NULL,
	[OrganismName] [nvarchar](100) NULL,
	[OrganismCode] [nvarchar](100) NULL,
	[Intermediate] [nvarchar](100) NULL,
	[Resistant] [nvarchar](100) NULL,
	[Susceptibility] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[SequenceNo] [int] NULL,
	[IsActive]  [bit] DEFAULT 1,
	[OrgID] [bigint] NULL 
)
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvDeltaCheck' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvDeltaCheck]
GO
---------------------------

/****** Object:  UserDefinedTableType [dbo].[InvDeltaCheck]    Script Date: 12/3/2019 11:02:58 AM ******/
CREATE TYPE [dbo].[InvDeltaCheck] AS TABLE(
	[InvDeltaCheckId] [bigint] NULL,
	[InvestigationId] [bigint] NOT NULL,
	[DeltaCalculationType] [varchar](10) NOT NULL,
	[DeltaUnit] [decimal](18, 2) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[TimeUnit] [varchar](50) NOT NULL,
	[Orgid] [bigint] NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTDeviceIntegrationQCResults' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTDeviceIntegrationQCResults]
GO

/****** Object:  UserDefinedTableType [dbo].[UDTDeviceIntegrationQCResults]    Script Date: 5/14/2020 1:45:16 PM ******/
CREATE TYPE [dbo].[UDTDeviceIntegrationQCResults] AS TABLE(
	[TestCode] [varchar](25) NULL,
	[ResultValue] [varchar](10) NULL,
	[ResultUOM] [varchar](10) NULL,
	[DeviceID] [varchar](20) NULL,
	[OrganismName] [varchar](50) NULL,
	[OrganismCode] [varchar](10) NULL,
	[DrugCode] [varchar](10) NULL,
	[DrugName] [varchar](50) NULL,
	[Sensitivity] [varchar](50) NULL,
	[MicValue] [varchar](10) NULL,
	[DeviceErrorCode] [varchar](250) NULL,
	[QCLevel] [varchar](10) NULL,
	[LotName] [varchar](50) NULL,
	[AddInfo] [varchar](50) NULL,
	[AddInfoValue] [varchar](50) NULL,
	[QCStatus] [varchar](50) NULL,
	[QCRange] [varchar](50) NULL,
	[QCFailedRule] [varchar](50) NULL,
	[ProcessedAt] [varchar](50) NULL
)
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTQCEvaluvationsDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTQCEvaluvationsDetails]
GO

/****** Object:  UserDefinedTableType [dbo].[UDTQCEvaluvationsDetails]    Script Date: 5/14/2020 1:45:16 PM ******/
CREATE TYPE [dbo].[UDTQCEvaluvationsDetails] AS TABLE(
	[InvestigationID] [bigint] NULL,
	[InstrumentID] [bigint] NULL,
	[LotID] [bigint] NULL,
	[OrgID] [int] NULL,
	[Mean] [decimal](18, 2) NULL,
	[StandardDeviation] [decimal](18, 2) NULL,
	[CoVariation] [decimal](18, 2) NULL,
	[QCLevel] [nvarchar](5) NULL
)
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientLanguage' AND ss.name = N'dbo')
DROP TYPE [dbo].UDTClientLanguage
GO

CREATE TYPE UDTClientLanguage AS TABLE 
(
    ClientID BIGINT,
    ReportLanguage NVARCHAR(100),
	NoofCopies INT,
	isActive NCHAR(1),
	CreatedAt DATETIME,
	CreatedBy BIGINT,
	ModifiedAt DATETIME,
	ModifiedBy BIGINT
)
GO



IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTPatientVisitLanguage' AND ss.name = N'dbo')
DROP TYPE [dbo].UDTPatientVisitLanguage
GO
CREATE TYPE UDTPatientVisitLanguage AS TABLE 
( 
	PatientVisitID BIGINT,
	ReportLanguage NVARCHAR(100) DEFAULT 'en-GB', 
	IsActive NCHAR(1),
	CreatedAt DATETIME,
	CreatedBy BIGINT,
	ModifiedAt DATETIME,
	ModifiedBy BIGINT
)
GO 



IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientAttributeFieldDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].UDTClientAttributeFieldDetails
GO

/****** Object:  UserDefinedTableType [dbo].[UDTClientAttributeFieldDetails]    Script Date: 08-05-2020 3:50:19 PM ******/
CREATE TYPE [dbo].[UDTClientAttributeFieldDetails] AS TABLE(
	[KeyName] [nvarchar](400) NOT NULL,
	[Valuedata] [nvarchar](400) NOT NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](400) NOT NULL,
	[TestType] [Nvarchar] (400) Not NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BidirectionalBarcodesDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].BidirectionalBarcodesDetails
GO

CREATE TYPE [dbo].[BidirectionalBarcodesDetails] AS TABLE(
	[PatientName] [nvarchar](255) NULL,
	[PatientAge] [nvarchar](20) NULL,
	[PatientSex] [nchar](1) NULL,
	[TestCode] [nvarchar](50) NULL,
	[Barcode] [nvarchar](255) NULL,
	[PatientInvId] [bigint] NULL,
	[OrgID] [int] NULL,
	[DeviceID] [nvarchar](50) NULL,
	[DeviceDate] [datetime] NULL,
	[DOB] [datetime] NULL,
	[SampleName] [nvarchar](255) NULL,
	[PhysicianName] [nvarchar](255) NULL,
	[ClientName] [nvarchar](255) NULL,
	[VisitNumber] [nvarchar](255) NULL,
	[Remarks] [nvarchar](255) NULL,
	[rowid] [bigint] NULL,
	[PatientVisitId] [bigint] NULL,
	[AccessionNumber] [bigint] NULL,
	[AttFlag] [char](1) NULL,
	[IsProcessed] [char](1) NULL,
	[CreatedAt] [datetime] NULL,
	[String1] [nvarchar](255) NULL,
	[String2] [nvarchar](255) NULL,
	[Int1] [int] NULL,
	[Int2] [int] NULL,
	[Long1] [bigint] NULL
)
GO

------------------------- HomeCollection Start -----------------------

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PreOrdered' AND ss.name = N'dbo')
DROP TYPE [dbo].PreOrdered
GO
/****** Object:  UserDefinedTableType [dbo].[PreOrdered] Script Date: 6/26/2020 12:54:22 PM ******/
CREATE TYPE [dbo].[PreOrdered] AS TABLE(
	[Name] [nvarchar](255) NULL,
	[ID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[Rate] [decimal](18, 2) NULL,
	[ActualAmount] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[SalesAmount] [decimal](18, 2) NULL,
	[PkgName] [nvarchar](30) NULL,
	[PkgID] [bigint] NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTHCBookingSchedule' AND ss.name = N'dbo')
DROP TYPE [dbo].UDTHCBookingSchedule
GO
/****** Object:  UserDefinedTableType [dbo].[UDTHCBookingSchedule]    Script Date: 9/28/2020 3:45:03 PM ******/
CREATE TYPE [dbo].[UDTHCBookingSchedule] AS TABLE(
	[TokenNumber] [int] NOT NULL,
	[TITLECode] [tinyint] NULL,
	[PatientName] [nvarchar](150) NULL,
	[SEX] [char](1) NULL,
	[DOB] [datetime] NULL,
	[Age] [nvarchar](20) NULL,
	[LandLineNumber] [nvarchar](30) NULL,
	[CreatedAt] [datetime] NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[EMail] [nvarchar](100) NULL,
	[ClientID] [int] NULL,
	[FeeType] [nvarchar](50) NULL,
	[SourceType] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgAddressID] [bigint] NULL,
	[OtherOrgID] [int] NULL,
	[CollectionAddress] [nvarchar](250) NULL,
	[RoleID] [bigint] NULL,
	[UserID] [bigint] NULL,
	[CollectionTime] [datetime] NULL,
	[BookingOrgID] [int] NULL,
	[BookingStatus] [nvarchar](50) NULL,
	[CollectionAddress2] [nvarchar](250) NULL,
	[City] [nvarchar](25) NULL,
	[PatientNumber] [nvarchar](30) NULL,
	[BookingID] [bigint] NULL,
	[BillDescription] [nvarchar](max) NULL,
	[Priority] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[Pincode] [nvarchar](max) NULL,
	[StateID] [bigint] NULL,
	[CityID] [bigint] NULL,
	[URNTypeID] [bigint] NULL,
	[URNO] [nvarchar](max) NULL,
	[DispatchValue] [nvarchar](max) NULL,
	[ReferalID] [bigint] NULL,
	[TokenID] [nvarchar](20) NULL,
	[RefPhysicianName] [nvarchar](100) NULL,
	[NRICNumber] [nvarchar](100) NULL,
	[NRICType] [nvarchar](100) NULL,
	[ExterNalPatNo] [nvarchar](100) NULL
)
GO


------------------------- HomeCollection End -------------------------

------------------------- LIMSAPI Related start ----------------------

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientRegistrationInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].PatientRegistrationInfo
GO
/****** Object:  UserDefinedTableType [dbo].[PatientRegistrationInfo]    Script Date: 8/10/2020 1:45:30 PM ******/
CREATE TYPE [dbo].[PatientRegistrationInfo] AS TABLE(
	[PatientID] [bigint] NOT NULL,
	[Age] [nvarchar](50) NULL,
	[FirstName] [nvarchar](250) NULL,
	[MiddleName] [nvarchar](250) NULL,
	[LastName] [nvarchar](250) NULL,
	[Gender] [nchar](5) NULL,
	[DateofBirth] [datetime] NULL,
	[Email] [nvarchar](100) NULL,
	[Salutation] [nvarchar](15) NULL,
	[Address] [nvarchar](500) NULL,
	[City] [nvarchar](300) NULL,
	[State] [nvarchar](300) NULL,
	[Country] [nvarchar](300) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[MobileNumber] [nvarchar](10) NULL,
	[URNType] [nvarchar](250) NULL,
	[URNNo] [nvarchar](100) NULL,
	[DateOfRegistration] [datetime] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[Source] [nvarchar](250) NULL,
	[Status] [nvarchar](250) NULL,
	[ClientID] [nvarchar](250) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ISProcessed] [nchar](2) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[PatientName] [nvarchar](250) NULL,
	[Type] [nvarchar](150) NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BookingInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].BookingInfo
GO

/****** Object:  UserDefinedTableType [dbo].[BookingInfo]    Script Date: 9/30/2020 11:28:15 AM ******/
CREATE TYPE [dbo].[BookingInfo] AS TABLE(
	[BookingID] [bigint] NOT NULL,
	[FirstName] [nvarchar](150) NULL,
	[MiddleName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Salutation] [nvarchar](50) NULL,
	[Age] [nvarchar](20) NULL,
	[Gender] [nchar](3) NULL,
	[DateofBirth] [datetime] NULL,
	[Address] [nvarchar](250) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[Email] [nvarchar](50) NULL,
	[City] [nvarchar](150) NULL,
	[State] [nvarchar](150) NULL,
	[Country] [nvarchar](150) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[ClientCode] [nvarchar](50) NULL,
	[URNType] [nvarchar](125) NULL,
	[URNNo] [nvarchar](50) NULL,
	[TRFFile] [nvarchar](150) NULL,
	[DispatchType] [nvarchar](50) NULL,
	[BookingDTTM] [datetime] NULL,
	[SampleID] [nvarchar](50) NULL,
	[SampleName] [nvarchar](125) NULL,
	[ContainerID] [nvarchar](50) NULL,
	[ContainerName] [nvarchar](125) NULL,
	[SampleContainerColour] [nvarchar](125) NULL,
	[SampleCollectionTime] [datetime] NULL,
	[SampleStatus] [nvarchar](50) NULL,
	[Reason] [nvarchar](250) NULL,
	[FollowUpTest] [nvarchar](125) NULL,
	[FollowUpDTTM] [datetime] NULL,
	[TestCode] [nvarchar](100) NULL,
	[TestName] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[ReceivedAmount] [decimal](18, 2) NULL,
	[DueAmount] [decimal](18, 2) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PaymentMode] [nvarchar](25) NULL,
	[CardDetails] [nvarchar](150) NULL,
	[ReferenceNo] [nvarchar](25) NULL,
	[InventoryCount] [bigint] NULL,
	[InventoryDetails] [nvarchar](100) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[UserID] [nvarchar](50) NULL,
	[Status] [nvarchar](250) NULL,
	[ClientID] [nvarchar](250) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL,
	[Name] [nvarchar](300) NULL,
	[PatientID] [bigint] NULL,
	[ExternalPatientNumber] [nvarchar](100) NULL,
	[CollectionTime] [datetime] NULL,
	[OrderedFrom] [nvarchar](150) NULL,
	[CardNumber] [bigint] NULL,
	[CurrencyType] [nvarchar](20) NULL,
	[JsonValue] [nvarchar](max) NULL,
	[CityID] [bigint] NULL,
	[StateID] [bigint] NULL,
	[CountryID] [bigint] NULL,
	[LoginID] [bigint] NULL,
	[AddressType] [nchar](3) NULL,
	[Type] [nvarchar](10) NULL,
	[DiscountID] [bigint] NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[SourceType] [nvarchar](50) NULL,
	[ExternalPatientRefNo] [nvarchar](50) NULL,
	[BarcodeNo] [nvarchar](250) NULL,
	[OrgCode] [nvarchar](25) NULL,
	[LocationCode] [nvarchar](25) NULL,
	[EmployeeID] [nvarchar](100) NULL,
	[BookingRemarks] [nvarchar](3000) NULL,
	Location NVARCHAR(1000) NULL,
	ERPPatientNumber NVARCHAR(300) NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCLiveLocation' AND ss.name = N'dbo')
DROP TYPE [dbo].HCLiveLocation
GO
/****** Object:  UserDefinedTableType [dbo].[HCLiveLocation]    Script Date: 8/10/2020 1:52:56 PM ******/
CREATE TYPE [dbo].[HCLiveLocation] AS TABLE(
	[LoginID] [bigint] NULL,
	[TransactionDate] [datetime] NULL,
	[Latitude] [float] NOT NULL,
	[Longitude] [float] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ISProcessed] [nvarchar](1) NULL,
	[Error] [nvarchar](1) NULL,
	[Remarks] [nvarchar](3000) NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'HCPaymentInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].HCPaymentInfo
GO
/****** Object:  UserDefinedTableType [dbo].[HCPaymentInfo]    Script Date: 8/10/2020 1:52:56 PM ******/
CREATE TYPE [dbo].[HCPaymentInfo] AS TABLE(
	[BookingID] [bigint] NULL,
	[FinalBillID] [bigint] NULL,
	[ReceivedAmount] [decimal](18, 2) NULL,
	[ClosureStatus] [nvarchar](250) NULL,
	[OrgID] [int] NULL,
	[TypeID] [int] NULL,
	[ChequeorCardNumber] [nvarchar](50) NULL,
	[BaseCurrencyID] [int] NULL,
	[PaidCurrencyID] [int] NULL,
	[OtherCurrencyAmount] [decimal](18, 2) NULL,
	[RoleID] [int] NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[Units] [int] NULL,
	[ExternalRefNo] [nvarchar](50) NULL,
	[PaymentMode] [nvarchar](30) NULL,
	[CurrencyType] [nvarchar](30) NULL,
	[TransactionID] [nvarchar](1020) NULL,
	[CardHolderName] [nvarchar](255) NULL,
	[CashGiven] [decimal](18, 2) NULL,
	[BalanceGiven] [decimal](18, 2) NULL,
	[RoundOffAmount] [decimal](18, 2) NULL,
	[ChequeValidDate] [datetime] NULL,
	[AuthorisationCode] [nvarchar](1020) NULL,
	[Remarks] [nvarchar](150) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TripStatusInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].TripStatusInfo
GO
/****** Object:  UserDefinedTableType [dbo].[TripStatusInfo]    Script Date: 8/10/2020 2:37:28 PM ******/
CREATE TYPE [dbo].[TripStatusInfo] AS TABLE(
	[BookingID] [bigint] NOT NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[LoginID] [nvarchar](50) NULL,
	[TripStatus] [nvarchar](50) NULL,
	[TripReason] [nvarchar](250) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL
)
GO


IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TripStatusInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].TripStatusInfo
GO
/****** Object:  UserDefinedTableType [dbo].[TripStatusInfo]    Script Date: 8/10/2020 2:37:28 PM ******/
CREATE TYPE [dbo].[TripStatusInfo] AS TABLE(
	[BookingID] [bigint] NOT NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[LoginID] [nvarchar](50) NULL,
	[TripStatus] [nvarchar](50) NULL,
	[TripReason] [nvarchar](250) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL
)
GO


/****** Object:  UserDefinedTableType [dbo].[InventoryItemsMapping_LIMSAPI]    Script Date:  02-Jun-20 11:33:35 AM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InventoryItemsMapping_LIMSAPI' AND ss.name = N'dbo')
DROP TYPE [dbo].[InventoryItemsMapping_LIMSAPI]
GO


/****** Object:  UserDefinedTableType [dbo].[InventoryItemsMapping_LIMSAPI]    Script Date: 02-Jun-20 11:33:35 AM ******/
CREATE TYPE [dbo].[InventoryItemsMapping_LIMSAPI] AS TABLE(
	[CategoryID] [int] NULL,
	[ProductID] [bigint] NULL,
	[CategoryName] [nvarchar](500) NULL,
	[ProductName] [nvarchar](500) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 6) NULL,
	[UOMID] [int] NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[LSUnit] [nvarchar](20) NULL,
	[Description] [nvarchar](500) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[Providedby] [bigint] NULL,
	[Type] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NULL,
	[ID] [bigint] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](50) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](50) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 6) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[HasExpiryDate] [nchar](1) NULL,
	[HasBatchNo] [nchar](1) NULL,
	[HasUsage] [nchar](1) NULL,
	[UsageCount] [int] NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[InHandQuantity] [decimal](18, 2) NULL,
	[ExciseTax] [decimal](18, 2) NULL,
	[DiscOrEnhancePercent] [decimal](18, 2) NULL,
	[DiscOrEnhanceType] [nvarchar](10) NULL,
	[Remarks] [nvarchar](255) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[ReceivedOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[ReceivedOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](255) NULL,
	[PrescriptionNO] [nvarchar](30) NULL,
	[ActualPrice] [decimal](18, 6) NULL,
	[EligibleAmount] [decimal](18, 6) NULL,
	[ClientFeeTypeRateCustID] [bigint] NULL,
	[InvoiceDate] [datetime] NULL,
	[StockStatus] [int] NULL,
	[DefectiveQty] [decimal](18, 2) NULL,
	[Comments] [nvarchar](30) NULL,
	[Shortage] [decimal](18, 2) NULL,
	[Damage] [decimal](18, 2) NULL,
	[Rejected] [decimal](18, 2) NULL,
	[PrepareCharges] [decimal](18, 2) NULL,
	[ProductCode] [nvarchar](100) NULL,
	[CopayValue] [decimal](18, 2) NULL,
	[CopayType] [nvarchar](10) NULL,
	[GenericName] [nvarchar](max) NULL,
	[ProductReceivedDetailsID] [bigint] NULL,
	[PurchaseTax] [decimal](18, 2) NULL,
	[HandlingCharges] [decimal](18, 6) NULL,
	[ReceivedUniqueNumber] [bigint] NULL,
	[ReceivedBatchNo] [nvarchar](255) NULL,
	[StockReceivedBarcodeDetailsID] [bigint] NULL,
	[StockReceivedBarcodeID] [bigint] NULL,
	[BarcodeNo] [nvarchar](100) NULL,
	[IsUniqueBarcode] [nvarchar](100) NULL,
	[TaxAmount] [decimal](18, 2) NULL,
	[IsSmsNeeded] [nchar](1) NULL,
	[SchemeType] [nvarchar](50) NULL,
	[SchemeDisc] [decimal](18, 2) NULL,
	[DiscountType] [nvarchar](50) NULL,
	[TotalSchemeDisc] [decimal](18, 2) NULL,
	[TotalNormalDisc] [decimal](18, 2) NULL
)
GO

------------------------- LIMSAPI Related End ----------------------
/****** Object:  UserDefinedTableType [dbo].[UDTBulkRegIntegrationNotifications]    Script Date: 9/16/2020 4:44:42 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTBulkRegIntegrationNotifications' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTBulkRegIntegrationNotifications]
GO

/****** Object:  UserDefinedTableType [dbo].[UDTBulkRegIntegrationNotifications]    Script Date: 9/16/2020 4:44:42 PM ******/
CREATE TYPE [dbo].[UDTBulkRegIntegrationNotifications] AS TABLE(
	[NotificationID] [bigint] NULL,
	[ErrorDescription] [varchar](2000) NULL,
	[Status] [varchar](10) NULL
)
GO

----------- Lab Code UDT --- 

IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTLabCodeForTest' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTLabCodeForTest] AS TABLE(
	[ID] [bigint] NOT NULL,
	[Type] [nvarchar](50),
	[AccessionNumber] bigint
	
    )
GO
----------- Lab Code UDT -----
/****** Object:  UserDefinedTableType [dbo].[InvDeltaCheck]    Script Date: 6/24/2020 11:23:39 AM ******/
DROP TYPE [dbo].UDTInvAutoCertifyValidation
GO

/****** Object:  UserDefinedTableType [dbo].[InvDeltaCheck]    Script Date: 6/24/2020 11:23:40 AM ******/
CREATE TYPE [dbo].[UDTInvAutoCertifyValidation] AS TABLE(
	InvestigationId bigint not null,
	Type varchar(50) not null,
	Orgid int not null,
	Isautocertify bit default 0,
	IsDeviceError  bit default 0,
	IsQCstatus  bit default 0,
	IsCriticalValue  bit default 0,
	IsDeltavalue  bit default 0,
	IsAutoauthorizationrange bit default 0,
	IsGroupDependencies bit default 0,
	IsCrossParameterCheck bit default 0,
	IsTechnicianVerificationNeeded bit default 0
)
GO

/*********** Rule master Related ************************/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvRuleMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].InvRuleMaster
GO
CREATE TYPE [dbo].[InvRuleMaster] AS TABLE(
	[RuleMasterId] [int] NOT NULL,
	[RuleTypeID] [int] NULL,
	[InvestigationID] [bigint] NOT NULL,
	[InvestigationName] [varchar](100) NOT NULL,
	[PostTriggerFunctionId] [int] NULL,
	[PostTriggerFunction] [varchar](100) NULL,
	[InvRemarksValue] [nvarchar](max) NULL,
	[OrgId] [int] NULL,
	[InvType] [nvarchar](100) NOT NULL
)
GO

/****** Object:  UserDefinedTableType [dbo].[MachineErrorRule]    Script Date: 01-09-2020 4:21:25 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'MachineErrorRule' AND ss.name = N'dbo')
DROP TYPE [dbo].[MachineErrorRule]
GO

/****** Object:  UserDefinedTableType [dbo].[MachineErrorRule]    Script Date: 01-09-2020 4:21:26 PM ******/
CREATE TYPE [dbo].[MachineErrorRule] AS TABLE(
	[MachineErrorRuleId] [int] NOT NULL,
	[RuleMasterId] [int] NULL,
	[ComponentName] [varchar](100) NULL,
	[ErrorCode] [nvarchar](100) NULL,
	[LogicalOperator] [varchar](10) NULL
)
GO
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientAgeGenderRule' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientAgeGenderRule]
GO
CREATE TYPE [dbo].[PatientAgeGenderRule] AS TABLE(
	[PatientAgeGenderRuleId] [int] NOT NULL,
	[RuleMasterId] [int] NULL,
	[ComponentName] [varchar](100) NULL,
	[Gender] [varchar](10) NULL,
	[SubCategory] [varchar](20) NULL,
	[AgeType] [nvarchar](20) NULL,
	[AgeOptr] [nvarchar](10) NULL,
	[AgeValue1] [int] NULL,
	[Agevalue2] [int] NULL,
	[LogicalOperator] [varchar](10) NULL
)
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TestResultsRule' AND ss.name = N'dbo')
DROP TYPE [dbo].[TestResultsRule]
GO
CREATE TYPE [dbo].[TestResultsRule] AS TABLE(
	[TestResultsRuleId] [int] NOT NULL,
	[RuleMasterId] [int] NULL,
	[ComponentName] [varchar](100) NULL,
	[ResultInvestigationID] [bigint] NULL,
	[ResultInvestigation] [nvarchar](500) NULL,
	[ResultType] [varchar](100) NULL,
	[ResultOptr] [nvarchar](10) NULL,
	[ResultValue1] [varchar](500) NULL,
	[Resultvalue2] [varchar](500) NULL,
	[LogicalOperator] [varchar](10) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PatientAgeGenderRule]    Script Date: 18/9/2020 10:34:41 AM ******/
DROP TYPE [dbo].[PatientAgeGenderRule]
GO

/****** Object:  UserDefinedTableType [dbo].[PatientAgeGenderRule]    Script Date: 18/9/2020 10:34:41 AM ******/
CREATE TYPE [dbo].[PatientAgeGenderRule] AS TABLE(
	[PatientAgeGenderRuleId] [int] NOT NULL,
	[RuleMasterId] [int] NULL,
	[ComponentName] [varchar](100) NULL,
	[Gender] [varchar](10) NULL,
	[SubCategory] [varchar](20) NULL,
	[AgeType] [nvarchar](20) NULL,
	[AgeOptr] [nvarchar](10) NULL,
	[AgeValue1] [int] NULL,
	[Agevalue2] [int] NULL,
	[LogicalOperator] [varchar](10) NULL,
	[RemarksId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TestResultsRule]    Script Date: 18/9/2020 10:35:46 AM ******/
DROP TYPE [dbo].[TestResultsRule]
GO

/****** Object:  UserDefinedTableType [dbo].[TestResultsRule]    Script Date: 18/9/2020 10:35:46 AM ******/
CREATE TYPE [dbo].[TestResultsRule] AS TABLE(
	[TestResultsRuleId] [int] NOT NULL,
	[RuleMasterId] [int] NULL,
	[ComponentName] [varchar](100) NULL,
	[ResultInvestigationID] [bigint] NULL,
	[ResultInvestigation] [nvarchar](500) NULL,
	[ResultType] [varchar](100) NULL,
	[ResultOptr] [nvarchar](10) NULL,
	[ResultValue1] [varchar](500) NULL,
	[Resultvalue2] [varchar](500) NULL,
	[LogicalOperator] [varchar](10) NULL,
	[RemarksId] [int] NULL
)
GO

/****** Object:  Table [dbo].[MachineErrorRule]    Script Date: 18/9/2020 10:36:47 AM ******/
DROP TABLE [dbo].[MachineErrorRule]
GO

/****** Object:  Table [dbo].[MachineErrorRule]    Script Date: 18/9/2020 10:36:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MachineErrorRule](
	[MachineErrorRuleId] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[RuleMasterId] [int] NULL,
	[ComponentName] [varchar](100) NULL,
	[ErrorCode] [nvarchar](100) NULL,
	[LogicalOperator] [varchar](10) NULL,
	[IsActive] [bit] NULL DEFAULT ((1)),
	[RemarksId] [int] NULL DEFAULT ((0)),
	[ErrorCondition] [nvarchar](max) NULL,
 CONSTRAINT [Pk_MachineErrorRule_RuleId] PRIMARY KEY CLUSTERED 
(
	[MachineErrorRuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigationAttributes' AND ss.name = N'dbo')
DROP TYPE [dbo].PatientInvestigationAttributes
GO
CREATE TYPE [dbo].[PatientInvestigationAttributes] AS TABLE(
PatientVisitID [bigint] NULL,
[OrgID] [int] NULL,
PatientInvID [bigint] NULL,
AccessionNumber [bigint] NULL,
MedicalRemarksID [bigint] NULL,
[InvestigationID] [bigint] NULL
)
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTCovidReport' AND ss.name = N'dbo')
DROP TYPE [dbo].UDTCovidReport
GO
CREATE TYPE [dbo].[UDTCovidReport] AS TABLE(
VisitID [bigint] NULL,
PatientInvID [bigint] NULL,
AccessionNumber [bigint] NULL,
MedicalRemarksID [varchar](100)NULL,
InvestigationID [bigint] NULL,
InvestigationValueID [bigint] NULL,
Value [varchar](100)NULL,
[OrgID] [int] NULL
)
GO

/****** Object:  UserDefinedTableType [dbo].[TT_UDTCampDetail]    Script Date: 16-12-2020 22:26:37 ******/
DROP TYPE [dbo].[TT_UDTCampDetail]
GO

/****** Object:  UserDefinedTableType [dbo].[TT_UDTCampDetail]    Script Date: 16-12-2020 22:26:37 ******/
CREATE TYPE [dbo].[TT_UDTCampDetail] AS TABLE(
	[ID] [int] NULL,
	[OrgName] [nvarchar](60) NULL,
	[SlNo] [int] NULL,
	[PDate] [datetime] NULL,
	[SDate] [datetime] NULL,
	[SCollectedBy] [nvarchar](500) NULL,
	[PatID] [nvarchar](200) NULL,
	[Title] [nvarchar](200) NULL,
	[Name] [nvarchar](1000) NULL,
	[Age] [nvarchar](5) NULL,
	[AgeType] [nvarchar](20) NULL,
	[Sex] [nvarchar](20) NULL,
	[Location] [nvarchar](1000) NULL,
	[Doctor] [nvarchar](1000) NULL,
	[RefHospital] [nvarchar](1000) NULL,
	[Priority] [nvarchar](200) NULL,
	[DispatchMode] [nvarchar](200) NULL,
	[TESTSREQUESTED] [nvarchar](max) NULL,
	[CHARGED] [decimal](19, 2) NULL,
	[AmountPaid] [decimal](19, 2) NULL,
	[AmountDisocunt] [decimal](19, 2) NULL,
	[DisocuntReason] [nvarchar](max) NULL,
	[DiscountAuthorisedBy] [nvarchar](500) NULL,
	[History] [varchar](max) NULL,
	[Remarks] [varchar](max) NULL,
	[MobileNo] [nvarchar](40) NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[ClientCode] [nvarchar](200) NULL,
	[EmailID] [nvarchar](200) NULL,
	[ErrorStatus] [bit] NOT NULL,
	[ErrorDesc] [nvarchar](4000) NULL,
	[ValidateData] [nvarchar](400) NULL,
	[ClientID] [bigint] NULL,
	[LOCATIONID] [bigint] NULL,
	[TitleID] [bigint] NULL,
	[DoctorID] [bigint] NULL,
	[RefHospitalID] [bigint] NULL,
	[TESTCODE] [nvarchar](max) NULL,
	[SCollectedByID] [bigint] NULL,
	[PriorityID] [int] NULL,
	[IsClientPatient] [varchar](6) NULL,
	[CreatedbyId] [bigint] NULL,
	[RateId] [bigint] NULL,
	[TestType] [varchar](30) NULL,
	[FeeId] [varchar](15) NULL,
	[IsDiscountable] [varchar](3) NULL,
	[DueAmount] [decimal](18, 2) NULL,
	[OrgId] [int] NULL,
	[DiscountAuthorisedByID] [bigint] NULL,
	[HasHealthCoupon] [varchar](3) NULL,
	[MyCardActiveDays] [nvarchar](30) NULL,
	[IsCreditBill] [varchar](15) NULL,
	[CampId] [int] NULL,
	[PatientNumber] [nvarchar](60) NULL,
	[DOB] [datetime] NULL,
	[HealthHubID] [varchar](100) NULL,
	[EmployeeID] [varchar](100) NULL,
	[SourceType] [varchar](250) NULL,
	[BookingID] [varchar](100) NULL,
	[ExternalRefNo] [varchar](100) NULL,
	[SampleNumber] [varchar](250) NULL,
		SRFID NVARCHAR(250) NULL,
	TRFID NVARCHAR(250) NULL,
	PassportNo NVARCHAR(200) NULL
)
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTClientSupplyDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].UDTClientSupplyDetails
GO
CREATE TYPE [dbo].[UDTClientSupplyDetails] AS TABLE(
ClientCode Varchar(50),
OrgID int,
BillofSupplyNumber Varchar(30),
InvoiceAmount Decimal(18,2),
SONo Varchar(50),
DateofBill Varchar(30),
AttuneInvNo Varchar(30)
)
GO

/****** Object:  UserDefinedTableType [dbo].[UDTOrganismBulkUploadDrug]    Script Date: 4/15/2021 5:40:07 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganismBulkUploadDrug' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTOrganismBulkUploadDrug] AS TABLE(
	[SlNo] [varchar](100) NULL,
	[BrandName] [varchar](100) NULL,
	[BrandCode] [varchar](100) NULL,
	[FamilyName] [varchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrganismBulkUploadFamily]    Script Date: 4/12/2021 5:16:39 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganismBulkUploadFamily' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTOrganismBulkUploadFamily] AS TABLE(
	[SlNo] [varchar](100) NULL,
	[FamilyName] [varchar](100) NULL,
	[FamilyCode] [varchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrganismBulkUploadOraganism]    Script Date: 4/12/2021 5:41:54 PM ******/
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTOrganismBulkUploadOraganism' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UDTOrganismBulkUploadOraganism] AS TABLE(
	[SlNo] [varchar](100) NULL,
	[OrganismName] [varchar](100) NULL,
	[OrganismCode] [varchar](100) NULL
)
GO

IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UT_Leaveinfo' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UT_Leaveinfo] AS TABLE(
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Holidays] [datetime] NULL
)
GO

IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UT_WorkingTime' AND ss.name = N'dbo')
CREATE TYPE [dbo].[UT_WorkingTime] AS TABLE(
	[WorkingDays] [nvarchar](200) NULL,
	[StartTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[SlotDuration] [time](7) NULL
)
GO
IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'CreditNotesDetails' AND ss.name = N'dbo')
DROP TYPE [dbo].[CreditNotesDetails]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_CreditNotesDetails] ******/
CREATE TYPE [dbo].[CreditNotesDetails] AS TABLE(
	[FinalbillId]		[bigint] NULL,
	[BillingDetailsId]  [bigint] NULL,
	[OrgID]				[bigint] NULL,
	[PatientVisitId]	[bigint] NULL,
	[ServiceId]			[bigint] NULL,
	[ClientId]			[bigint] NULL,
	[ClientCode]		[nvarchar](100) NULL,
	[ClientName]		[nvarchar](300) NULL,
	[VisitNumber]		[nvarchar](300) NULL,
	[CancelledDate]		[datetime] NULL,
	[BillSupplyNumber]  [nvarchar](100) NULL,
	[AmountCharged]		[decimal](18, 2) NULL,
	[TestCode]			[nvarchar](100) NULL,
	[TestName]			[nvarchar](300) NULL,
	[CreditNote]		[nvarchar](300) NULL,
	[NetAmount]			[decimal](18, 2) NULL,
	[GrossAmount]		[decimal](18, 2) NULL,
	[InvoiceAmount]		[decimal](18, 2) NULL,
	[InvoioceDate]		[datetime] NULL,
	[InvoicegenBy]		[nvarchar](300) NULL,
	[ExtraNote]			[nvarchar](300) NULL,
	[Command]			[nvarchar](300) NULL
)
GO
IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TT_UDTSaveBookingDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[TT_UDTSaveBookingDetail]
GO
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TT_UDTSaveBookingDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TT_UDTSaveBookingDetail] AS TABLE(
	[Id] [int] NULL,
	[SlNo] [varchar](20) NULL,
	[OrgName] [varchar](60) NULL,
	[OrgLocation] [varchar](1000) NULL,
	[BookingDate] [varchar](20) NULL,
	[PatientNumber] [varchar](100) NULL,
	[Title] [varchar](50) NULL,
	[PatientName] [varchar](100) NULL,
	[DOB] [varchar](20) NULL,
	[Age] [varchar](20) NULL,
	[AgeType] [varchar](20) NULL,
	[Sex] [varchar](20) NULL,
	[Pincode] [varchar](20) NULL,
	[Location] [varchar](1000) NULL,
	[CollectionAddress] [varchar](1000) NULL,
	[CollectionDate] [varchar](20) NULL,
	[Technician] [varchar](100) NULL,
	[TestCodes] [nvarchar](max) NULL,
	[Discount] [varchar](20) NULL,
	[ClientCode] [varchar](100) NULL,
	[MobileNo] [varchar](100) NULL,
	[EmailID] [varchar](100) NULL,
	[DispatchMode] [varchar](100) NULL,
	[RefDocName] [varchar](100) NULL,
	[Remarks] [varchar](max) NULL,
	[Salutation] [varchar](50) NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedbyId] [varchar](20) NULL,
	[ClientID] [varchar](20) NULL,
	[LocationID] [varchar](20) NULL,
	[ErrorStatus] [varchar](20) NULL,
	[OrgID] [varchar](20) NULL,
	[SCollectedBy] [varchar](20) NULL,
	[ErrorDesc] [varchar](max) NULL,
	[TestCode] [varchar](1000) NULL,
	[TestType] [varchar](1000) NULL,
	[FeeId] [varchar](20) NULL,
	[OrgLocationID] [varchar](20) NULL
)
GO
IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TT_UDTBookingDetail' AND ss.name = N'dbo')
DROP TYPE [dbo].[TT_UDTBookingDetail]
GO
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'TT_UDTBookingDetail' AND ss.name = N'dbo')
CREATE TYPE [dbo].[TT_UDTBookingDetail] AS TABLE(
	[SlNo] [int] NULL,
	[OrgName] [varchar](60) NULL,
	[OrgLocation] [varchar](1000) NULL,
	[BookingDate] [datetime] NULL,
	[PatientNumber] [varchar](100) NULL,
	[Salutation] [varchar](50) NULL,
	[PatientName] [varchar](100) NULL,
	[DOB] [varchar](20) NULL,
	[Age] [varchar](20) NULL,
	[AgeType] [varchar](20) NULL,
	[Sex] [varchar](20) NULL,
	[Pincode] [varchar](20) NULL,
	[Location] [varchar](1000) NULL,
	[CollectionAddress] [varchar](1000) NULL,
	[CollectionDate] [varchar](20) NULL,
	[Technician] [varchar](100) NULL,
	[TestCodes] [nvarchar](max) NULL,
	[Discount] [varchar](20) NULL,
	[ClientCode] [varchar](100) NULL,
	[MobileNo] [varchar](100) NULL,
	[EmailID] [varchar](100) NULL,
	[DispatchMode] [varchar](100) NULL,
	[RefDr] [varchar](100) NULL,
	[Remarks] [varchar](max) NULL
)
GO
IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UsersInfo' AND ss.name = N'dbo')
DROP TYPE [dbo].[UsersInfo]
GO
CREATE TYPE [dbo].[UsersInfo] AS TABLE(
	[UserID] [bigint] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[LoginID] [nvarchar](50) NULL,
	[LoginName] [nvarchar](75) NULL,
	[Password] [nvarchar](250) NULL,
	[OrgID] [int] NULL,
	[ServerName] [nvarchar](500) NULL,
	[URL] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL
)
GO

 
/****** Object:  UserDefinedTableType [dbo].[UDT_DeviceInvestigationData]    Script Date: 7/15/2021 7:24:09 PM ******/
IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDT_DeviceInvestigationData' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDT_DeviceInvestigationData]
GO

/****** Object:  UserDefinedTableType [dbo].[UDT_DeviceInvestigationData]    Script Date: 7/15/2021 7:24:09 PM ******/
CREATE TYPE [dbo].[UDT_DeviceInvestigationData] AS TABLE(
	[UID] [int] NOT NULL,
	[DeviceID] [varchar](100) NOT NULL,
	[GroupID] [bigint] NULL,
	[MessageID] [varchar](100) NULL,
	[PatientID] [bigint] NULL,
	[SampleID] [varchar](100) NULL,
	[ContainerNo] [varchar](100) NULL,
	[OrderedDTTM] [datetime] NULL,
	[SpecimenCollectionDTTM] [datetime] NULL,
	[TestCode] [varchar](100) NOT NULL,
	[Value] [varchar](100) NULL,
	[ValueUOM] [varchar](100) NULL,
	[ReferenceRange] [varchar](100) NULL,
	[AbnormalFlag] [varchar](100) NULL,
	[ResultType] [varchar](100) NULL,
	[ResultCompletedDTTM] [datetime] NULL,
	[CreatedAt] [datetime] NOT NULL,
	[RawDataLogID] [int] NULL,
	[IsProcessed] [char](1) NOT NULL DEFAULT ('N'),
	[OrgName] [varchar](100) NULL,
	[ProcessedAt] [datetime] NULL,
	PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
GO



IF  EXISTS (SELECT 1 FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BulkRegValidateParam' AND ss.name = N'dbo')
DROP TYPE [dbo].[BulkRegValidateParam]
GO



/****** Object:  UserDefinedTableType [dbo].[BulkRegValidateParam]    Script Date: 20-09-2021 16:38:38 ******/
CREATE TYPE [dbo].[BulkRegValidateParam] AS TABLE(
	[PatientName] [nvarchar](50) NULL,
	[HealthHubId] [nvarchar](50) NULL,
	[MobileNo] [nvarchar](15) NULL,
	[Sex] [nvarchar](10) NULL,
	[DOB] [nvarchar](20) NULL,
	[EmployeeID] [nvarchar](50) NULL,
	[OrgId] [int] NULL,
	PassportNo [Nvarchar](100) NULL
)
GO


