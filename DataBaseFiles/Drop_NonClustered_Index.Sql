IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ActionRoleMapping_RoleID_SearchTypeID')
DROP INDEX ActionRoleMapping.[NC_ActionRoleMapping_RoleID_SearchTypeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AdvancePaidDetails_VisitID')
DROP INDEX AdvancePaidDetails.[NC_AdvancePaidDetails_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_FinalBillID')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_FinalBillID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_OrgID_AmtReceived')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_OrgID_AmtReceived]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_OrgID_CreatedBy')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_CreatedBy')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ReceivedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_CreatedBy_AmtReceived')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ClosureStatus_CreatedBy_AmtReceived]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_OrgID_ReceiptNO')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_OrgID_ReceiptNO]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID_TypeID')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID_TypeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy_PaidCurrencyID')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy_PaidCurrencyID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ReceivedBy_ClosureStatus]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_TypeID')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_TypeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_CreatedBy_TypeID')
DROP INDEX AmountReceivedDetails.[NC_AmountReceivedDetails_ClosureStatus_CreatedBy_TypeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_RefundBy')
DROP INDEX AmountRefundDetails.[NC_AmountRefundDetails_RefundBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_RefundBy_OrgID_BillStatus')
DROP INDEX AmountRefundDetails.[NC_AmountRefundDetails_RefundBy_OrgID_BillStatus]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_OrgID_RefundNo')
DROP INDEX AmountRefundDetails.[NC_AmountRefundDetails_OrgID_RefundNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_RefundType,CreatedAt')
DROP INDEX AmountRefundDetails.[NC_AmountRefundDetails_RefundType,CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_OrgID_RefundType_CreatedAt')
DROP INDEX AmountRefundDetails.[NC_AmountRefundDetails_OrgID_RefundType_CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'AmountRefundDetails_OrgID_Status')
DROP INDEX AmountRefundDetails.[AmountRefundDetails_OrgID_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BannerRole_02')
DROP INDEX BannerRoleMapping.[NC_BannerRole_02]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Banners_01')
DROP INDEX Banners.[NC_Banners_01]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BedBooking_BookingID')
DROP INDEX BedBooking.[NC_BedBooking_BookingID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BedMaster_01')
DROP INDEX BedMaster.[NC_BedMaster_01]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_FeeType')
DROP INDEX BillingDetails.[NC_BillingDetails_FeeType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_FinalBillID')
DROP INDEX BillingDetails.[NC_BillingDetails_FinalBillID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_CreatedBy_FeeId')
DROP INDEX BillingDetails.[NC_BillingDetails_CreatedBy_FeeId]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_FeedId')
DROP INDEX BillingDetails.[NC_BillingDetails_FeedId]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_SourceType_FeeId')
DROP INDEX BillingDetails.[NC_BillingDetails_SourceType_FeeId]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_OrgID')
DROP INDEX BillingDetails.[NC_BillingDetails_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_OrgID_CreatedAt')
DROP INDEX BillingDetails.[NC_BillingDetails_OrgID_CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'BillingDetails_OrgID_FeeID')
DROP INDEX BillingDetails.[BillingDetails_OrgID_FeeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Bookings_BookingStatus')
DROP INDEX Bookings.[NC_Bookings_BookingStatus]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Bookings_ScheduleID')
DROP INDEX Bookings.[NC_Bookings_ScheduleID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_OrgID')
DROP INDEX CashOutFlow.[NC_CashOutFlow_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_ReceiverID_ClosureStatus_OrgID_CreatedBy')
DROP INDEX CashOutFlow.[NC_CashOutFlow_ReceiverID_ClosureStatus_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy_ReceiverID')
DROP INDEX CashOutFlow.[NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy_ReceiverID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy')
DROP INDEX CashOutFlow.[NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_OrgID_CreatedBy')
DROP INDEX CashOutFlow.[NC_CashOutFlow_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlowDetails_OrgID_CreatedBy')
DROP INDEX CashOutFlowDetails.[NC_CashOutFlowDetails_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ConfigKeyMaster_ConfigKeyID_ConfigKey')
DROP INDEX ConfigKeyMaster.[NC_ConfigKeyMaster_ConfigKeyID_ConfigKey]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ConfigOrgMaster_OrgID')
DROP INDEX ConfigOrgMaster.[NC_ConfigOrgMaster_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ConfigOrgMaster_OrgID_ConfigKeyID')
DROP INDEX ConfigOrgMaster.[NC_ConfigOrgMaster_OrgID_ConfigKeyID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'pk_ConfigValueMaster')
DROP INDEX ConfigValueMaster.[pk_ConfigValueMaster]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_DischargeSummary_PatientVistID')
DROP INDEX DischargeSummary.[NC_DischargeSummary_PatientVistID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_DrugBrand_OrgID_BrandName')
DROP INDEX DrugBrand.[NC_DrugBrand_OrgID_BrandName]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_DrugBrand_OrgID_Strength')
DROP INDEX DrugBrand.[NC_DrugBrand_OrgID_Strength]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_VisitID')
DROP INDEX FinalBill.[NC_FinalBill_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_PatientID_FinalBillID')
DROP INDEX FinalBill.[NC_FinalBill_PatientID_FinalBillID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_CreatedBy')
DROP INDEX FinalBill.[NC_FinalBill_OrgID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_PatientID_VisitID_CreatedBy')
DROP INDEX FinalBill.[NC_FinalBill_OrgID_PatientID_VisitID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_VisitID_CreatedAt')
DROP INDEX FinalBill.[NC_FinalBill_OrgID_VisitID_CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID')
DROP INDEX FinalBill.[NC_FinalBill_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_VisitID')
DROP INDEX FinalBill.[NC_FinalBill_OrgID_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FloorMaster_01')
DROP INDEX FloorMaster.[NC_FloorMaster_01]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ICDCodes_01')
DROP INDEX ICDCodes.[NC_ICDCodes_01]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InPatientAdmissionDetails_VisitID')
DROP INDEX InPatientAdmissionDetails.[NC_InPatientAdmissionDetails_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InPatientNumber_PatientID')
DROP INDEX InPatientNumber.[NC_InPatientNumber_PatientID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Intend_IntendID_OrgID')
DROP INDEX Intend.[NC_Intend_IntendID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Intend_OrgID')
DROP INDEX Intend.[NC_Intend_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Intend_IntendID')
DROP INDEX Intend.[NC_Intend_IntendID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceived_OrgID')
DROP INDEX IntendReceived.[NC_IntendReceived_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceived_IntendID')
DROP INDEX IntendReceived.[NC_IntendReceived_IntendID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_OrgID_BatchNo')
DROP INDEX IntendReceivedDetail.[NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_OrgID_BatchNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_OrgID')
DROP INDEX IntendReceivedDetail.[NC_IntendReceivedDetail_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedID')
DROP INDEX IntendReceivedDetail.[NC_IntendReceivedDetail_IntendReceivedID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID')
DROP INDEX IntendReceivedDetail.[NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_ProductKey')
DROP INDEX IntendReceivedDetail.[NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_ProductKey]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvDeptSamples_PatientVisitID_OrgID')
DROP INDEX InvDeptSamples.[NC_InvDeptSamples_PatientVisitID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationOrgMapping_OrgID')
DROP INDEX InvestigationOrgMapping.[NC_InvestigationOrgMapping_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationOrgMapping_OrgID_InvID_DeptID')
DROP INDEX InvestigationOrgMapping.[NC_InvestigationOrgMapping_OrgID_InvID_DeptID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_InvestigationID')
DROP INDEX InvestigationValues.[NC_InvestigationValues_InvestigationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_InvestigationID_GroupID_PatientVisitID_Orgid')
DROP INDEX InvestigationValues.[NC_InvestigationValues_InvestigationID_GroupID_PatientVisitID_Orgid]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_PatientVisitID_Orgid_PackageID_UID')
DROP INDEX InvestigationValues.[NC_InvestigationValues_PatientVisitID_Orgid_PackageID_UID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_PatientVisitID_Orgid_PackageID')
DROP INDEX InvestigationValues.[NC_InvestigationValues_PatientVisitID_Orgid_PackageID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvOrgGroup')
DROP INDEX InvOrgGroup.[NC_InvOrgGroup]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvRateMaster_Type_RateID')
DROP INDEX InvRateMaster.[NC_InvRateMaster_Type_RateID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvRateMaster_Type_ID_RateID')
DROP INDEX InvRateMaster.[NC_InvRateMaster_Type_ID_RateID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvRateMaster_Type')
DROP INDEX InvRateMaster.[NC_InvRateMaster_Type]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_VisitID')
DROP INDEX IPIntermediatePayments.[NC_IPIntermediatePayments_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_IsSettlementPage_AmountReceived')
DROP INDEX IPIntermediatePayments.[NC_IPIntermediatePayments_IsSettlementPage_AmountReceived]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_CreatedBy')
DROP INDEX IPIntermediatePayments.[NC_IPIntermediatePayments_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_ReceiptNO')
DROP INDEX IPIntermediatePayments.[NC_IPIntermediatePayments_ReceiptNO]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPTreatmentPlan_OperationID')
DROP INDEX IPTreatmentPlan.[NC_IPTreatmentPlan_OperationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPTreatmentPlan_PatientVisitID')
DROP INDEX IPTreatmentPlan.[NC_IPTreatmentPlan_PatientVisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPTreatmentPlan_PatientVisitID_Status_StagePlanned')
DROP INDEX IPTreatmentPlan.[NC_IPTreatmentPlan_PatientVisitID_Status_StagePlanned]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitMaster_OrgID_MasterKitID')
DROP INDEX KitMaster.[NC_KitMaster_OrgID_MasterKitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMaster_OrgID_MasterKitID')
DROP INDEX KitPrepMaster.[NC_KitPrepMaster_OrgID_MasterKitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMaster_LocationID')
DROP INDEX KitPrepMaster.[NC_KitPrepMaster_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_KitID_LocationID')
DROP INDEX KitPrepMasterDetails.[NC_KitPrepMasterDetails_KitID_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_KitID_LocationID_IsReimbursable')
DROP INDEX KitPrepMasterDetails.[NC_KitPrepMasterDetails_KitID_LocationID_IsReimbursable]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_LocationID_IsReimbursable')
DROP INDEX KitPrepMasterDetails.[NC_KitPrepMasterDetails_LocationID_IsReimbursable]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_LocationID')
DROP INDEX KitPrepMasterDetails.[NC_KitPrepMasterDetails_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_OrgID')
DROP INDEX KitPrepMasterDetails.[NC_KitPrepMasterDetails_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_MasterKitID_OrgID')
DROP INDEX KitPrepMasterDetails.[NC_KitPrepMasterDetails_MasterKitID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_LoggedInUsers_LoginID_SessionID')
DROP INDEX LoggedInUsers.[NC_LoggedInUsers_LoginID_SessionID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Login_LoginName_Password_IsLocked_Status')
DROP INDEX Login.[NC_Login_LoginName_Password_IsLocked_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_NRI_01')
DROP INDEX NonReimbursableItems.[NC_NRI_01]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_VisitID_OrgID_LabNo')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_VisitID_OrgID_LabNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_CreatedAt')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_Type_CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_ID_Type_OrgID')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_ID_Type_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_OrgID')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_Type_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Status')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_OrgID_Status')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_Type_OrgID_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_ID_Type_Status')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_ID_Type_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_AccessionNumber')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_AccessionNumber]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_Status')
DROP INDEX OrderedInvestigations.[NC_OrderedInvestigations_Type_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrganizationSpeciality_OrganizationID')
DROP INDEX OrganizationSpeciality.[NC_OrganizationSpeciality_OrganizationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrgUOMVitalsMapping_OrgID')
DROP INDEX OrgUOMVitalsMapping.[NC_OrgUOMVitalsMapping_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Patient_OrganizationID_PatientNumber')
DROP INDEX Patient.[NC_Patient_OrganizationID_PatientNumber]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Patient_PatID_OrganizationID')
DROP INDEX Patient.[NC_Patient_PatID_OrganizationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Patient_OrgID')
DROP INDEX Patient.[NC_Patient_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientAddress_PatientID_AddressType')
DROP INDEX PatientAddress.[NC_PatientAddress_PatientID_AddressType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientAddress_AddressType_MobileNumber')
DROP INDEX PatientAddress.[NC_PatientAddress_AddressType_MobileNumber]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientComplaint_PatientVisitID_ComplaintType')
DROP INDEX PatientComplaint.[NC_PatientComplaint_PatientVisitID_ComplaintType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_FeeType_IsReimbursable_Status')
DROP INDEX PatientDueChart.[NC_PatientDueChart_VisitID_FeeType_IsReimbursable_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_FeeType')
DROP INDEX PatientDueChart.[NC_PatientDueChart_FeeType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_FeeType_FeeID')
DROP INDEX PatientDueChart.[NC_PatientDueChart_FeeType_FeeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_Status_unit')
DROP INDEX PatientDueChart.[NC_PatientDueChart_VisitID_Status_unit]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_FeeType_Status_unit')
DROP INDEX PatientDueChart.[NC_PatientDueChart_VisitID_FeeType_Status_unit]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_PatientID')
DROP INDEX PatientDueChart.[NC_PatientDueChart_VisitID_PatientID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_Status')
DROP INDEX PatientDueChart.[NC_PatientDueChart_VisitID_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_FeeType')
DROP INDEX PatientDueChart.[NC_PatientDueChart_VisitID_FeeType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_FeeType_Status_CreatedAt')
DROP INDEX PatientDueChart.[NC_PatientDueChart_FeeType_Status_CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_Status_InterimBillNo')
DROP INDEX PatientDueChart.[NC_PatientDueChart_Status_InterimBillNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = '<Name of Missing Index, sysname,>')
DROP INDEX PatientDueChart.[<Name of Missing Index, sysname,>]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueDetails_FinalBillID_Status')
DROP INDEX PatientDueDetails.[NC_PatientDueDetails_FinalBillID_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueDetails_Status_FinalBillID')
DROP INDEX PatientDueDetails.[NC_PatientDueDetails_Status_FinalBillID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueDetails_Status')
DROP INDEX PatientDueDetails.[NC_PatientDueDetails_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueRefundDetails_DetailsID_Status')
DROP INDEX PatientDueRefundDetails.[NC_PatientDueRefundDetails_DetailsID_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueRefundDetails_RefundNo_OrgID_DetailsID')
DROP INDEX PatientDueRefundDetails.[NC_PatientDueRefundDetails_RefundNo_OrgID_DetailsID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientExamination_PatientVisitID')
DROP INDEX PatientExamination.[NC_PatientExamination_PatientVisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientExamination_PatientVisitID_ExaminationID')
DROP INDEX PatientExamination.[NC_PatientExamination_PatientVisitID_ExaminationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_PatientVisitID_OrgID_PackageID')
DROP INDEX PatientInvestigation.[NC_PatientInvestigation_PatientVisitID_OrgID_PackageID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_PatientVisitID_OrgID_GroupID')
DROP INDEX PatientInvestigation.[NC_PatientInvestigation_PatientVisitID_OrgID_GroupID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_PatientVisitID_OrgID')
DROP INDEX PatientInvestigation.[NC_PatientInvestigation_PatientVisitID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_OrgID_Status')
DROP INDEX PatientInvestigation.[NC_PatientInvestigation_OrgID_Status]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSample_PatientVisitID_OrgID')
DROP INDEX PatientInvSample.[NC_PatientInvSample_PatientVisitID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSample_SampleID')
DROP INDEX PatientInvSample.[NC_PatientInvSample_SampleID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSample_PatientVisitID_SampleID_OrgID')
DROP INDEX PatientInvSample.[NC_PatientInvSample_PatientVisitID_SampleID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSampleMapping_VisitID_OrgID')
DROP INDEX PatientInvSampleMapping.[NC_PatientInvSampleMapping_VisitID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSampleMapping_VisitID_OrgID_SampleID')
DROP INDEX PatientInvSampleMapping.[NC_PatientInvSampleMapping_VisitID_OrgID_SampleID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientPrescription_PatientVisitID_DrugStatus_PrescriptionType')
DROP INDEX PatientPrescription.[NC_PatientPrescription_PatientVisitID_DrugStatus_PrescriptionType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientPrescription_PatientVisitID_PrescriptionType')
DROP INDEX PatientPrescription.[NC_PatientPrescription_PatientVisitID_PrescriptionType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientTPADetails_PatientVisitID')
DROP INDEX PatientTPADetails.[NC_PatientTPADetails_PatientVisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientTPADetails_PatientID_PatientVisitID_TPAID')
DROP INDEX PatientTPADetails.[NC_PatientTPADetails_PatientID_PatientVisitID_TPAID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_PatientID')
DROP INDEX PatientVisit.[NC_PatientVisit_PatientID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_SpecialityID')
DROP INDEX PatientVisit.[NC_PatientVisit_SpecialityID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_PatientID_SpecialityID')
DROP INDEX PatientVisit.[NC_PatientVisit_PatientID_SpecialityID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_PhysicianID_VisitType')
DROP INDEX PatientVisit.[NC_PatientVisit_OrganizationID_PhysicianID_VisitType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitType')
DROP INDEX PatientVisit.[NC_PatientVisit_OrganizationID_VisitType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_VisitType')
DROP INDEX PatientVisit.[NC_PatientVisit_VisitType]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_VisitType_VisitState_VisitDate')
DROP INDEX PatientVisit.[NC_PatientVisit_VisitType_VisitState_VisitDate]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitState_DischargedDT')
DROP INDEX PatientVisit.[NC_PatientVisit_OrganizationID_VisitState_DischargedDT]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_VisitType_VisitDate')
DROP INDEX PatientVisit.[NC_PatientVisit_VisitType_VisitDate]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitType_VisitState')
DROP INDEX PatientVisit.[NC_PatientVisit_OrganizationID_VisitType_VisitState]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitPurpose_CreatedAt')
DROP INDEX PatientVisit.[NC_PatientVisit_OrganizationID_VisitPurpose_CreatedAt]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_PatientID_PatientVisitID')
DROP INDEX PatientVisit.[NC_PatientVisit_OrganizationID_PatientID_PatientVisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVitals_PatientVisitID_VitalsSetID')
DROP INDEX PatientVitals.[NC_PatientVitals_PatientVisitID_VitalsSetID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVitals_PatientVisitID')
DROP INDEX PatientVitals.[NC_PatientVitals_PatientVisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PhysicianFee_RateID')
DROP INDEX PhysicianFee.[NC_PhysicianFee_RateID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PrimaryConsultant_VisitID')
DROP INDEX PrimaryConsultant.[NC_PrimaryConsultant_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID_TypeID')
DROP INDEX Products.[NC_Products_OrgID_TypeID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID')
DROP INDEX Products.[NC_Products_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID_AddrID_ProductName')
DROP INDEX Products.[NC_Products_OrgID_AddrID_ProductName]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID_AddrID_TypeID_ProductName')
DROP INDEX Products.[NC_Products_OrgID_AddrID_TypeID_ProductName]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_ProductID_Spec')
DROP INDEX Products.[NC_Products_ProductID_Spec]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrderDetails_PurchaseOrderId')
DROP INDEX PurchaseOrderDetails.[NC_PurchaseOrderDetails_PurchaseOrderId]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrders_PurchaseOrderID_OrgID_SupplierID')
DROP INDEX PurchaseOrders.[NC_PurchaseOrders_PurchaseOrderID_OrgID_SupplierID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrders_PurchaseOrderID_OrgID')
DROP INDEX PurchaseOrders.[NC_PurchaseOrders_PurchaseOrderID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrders_PurchaseOrderNo_OrgID')
DROP INDEX PurchaseOrders.[NC_PurchaseOrders_PurchaseOrderNo_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_RoleMenu_RoleID_IsMapped')
DROP INDEX RoleMenu.[NC_RoleMenu_RoleID_IsMapped]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SampleTracker_PatientVisitID_OrgID')
DROP INDEX SampleTracker.[NC_SampleTracker_PatientVisitID_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Schedules_ResourceTemplateID')
DROP INDEX Schedules.[NC_Schedules_ResourceTemplateID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_State_CountryID')
DROP INDEX State.[NC_State_CountryID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockInHand_OrgID_AddrID_LocID')
DROP INDEX StockInHand.[NC_StockInHand_OrgID_AddrID_LocID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockInHand_ProdID_BatchNo')
DROP INDEX StockInHand.[NC_StockInHand_ProdID_BatchNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlow_OrgID_OrgAddressID_BillID_LocationID')
DROP INDEX StockOutFlow.[NC_StockOutFlow_OrgID_OrgAddressID_BillID_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlow_OrgID_OrgAddressID_LocationID')
DROP INDEX StockOutFlow.[NC_StockOutFlow_OrgID_OrgAddressID_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'StockOutFlow_ReferenceID')
DROP INDEX StockOutFlow.[StockOutFlow_ReferenceID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_OrgID_LocationID')
DROP INDEX StockOutFlowDetails.[NC_StockOutFlowDetails_OrgID_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_OrgID_ProductID_LocationID_ProductKey')
DROP INDEX StockOutFlowDetails.[NC_StockOutFlowDetails_OrgID_ProductID_LocationID_ProductKey]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_StockOutFlowID_OrgID_LocationID')
DROP INDEX StockOutFlowDetails.[NC_StockOutFlowDetails_StockOutFlowID_OrgID_LocationID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_OrgID_ProductID_BatchNo_ProductKey')
DROP INDEX StockOutFlowDetails.[NC_StockOutFlowDetails_OrgID_ProductID_BatchNo_ProductKey]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_SupplierID')
DROP INDEX StockReceived.[NC_StockReceived_OrgID_OrgAddressID_SupplierID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_DCNumber')
DROP INDEX StockReceived.[NC_StockReceived_OrgID_OrgAddressID_DCNumber]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_SupplierID_OrgID_OrgAddressID_CreatedAt_PaymentStatus')
DROP INDEX StockReceived.[NC_StockReceived_SupplierID_OrgID_OrgAddressID_CreatedAt_PaymentStatus]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_FromLocationID_Comments')
DROP INDEX StockReceived.[NC_StockReceived_OrgID_FromLocationID_Comments]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_StockReceivedNo')
DROP INDEX StockReceived.[NC_StockReceived_OrgID_OrgAddressID_StockReceivedNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_InvoiceNo')
DROP INDEX StockReceived.[NC_StockReceived_OrgID_OrgAddressID_InvoiceNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_PurchaseOrderNo')
DROP INDEX StockReceived.[NC_StockReceived_OrgID_OrgAddressID_PurchaseOrderNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_StockReceivedId')
DROP INDEX StockReceivedDetails.[NC_StockReceivedDetails_StockReceivedId]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_OrgID')
DROP INDEX StockReceivedDetails.[NC_StockReceivedDetails_OrgID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_OrgID_ProdID_BatchNo')
DROP INDEX StockReceivedDetails.[NC_StockReceivedDetails_OrgID_ProdID_BatchNo]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_StockReceivedDetailsId_OrgID_ProdID_StockReceivedId')
DROP INDEX StockReceivedDetails.[NC_StockReceivedDetails_StockReceivedDetailsId_OrgID_ProdID_StockReceivedId]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SurgeryBillingDetails_SurgeryBillingID')
DROP INDEX SurgeryBillingDetails.[NC_SurgeryBillingDetails_SurgeryBillingID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SurgeryBillingMaster_OrgID_ChiefSurgeonID')
DROP INDEX SurgeryBillingMaster.[NC_SurgeryBillingMaster_OrgID_ChiefSurgeonID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SurgeryPackageMaster_01')
DROP INDEX SurgeryPackageMaster.[NC_SurgeryPackageMaster_01]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_TaskActionMapping_OrgID_VisitPurposeID_OtherID')
DROP INDEX TaskActionMapping.[NC_TaskActionMapping_OrgID_VisitPurposeID_OtherID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_TaskEscalation_TaskActionID_OrgID_AllowedElaspsedTime')
DROP INDEX TaskEscalation.[NC_TaskEscalation_TaskActionID_OrgID_AllowedElaspsedTime]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Tasks_RoleID_OrgID_TaskDate')
DROP INDEX Tasks.[NC_Tasks_RoleID_OrgID_TaskDate]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Tasks_TaskActionID_AssignedTo_RoleID_PatientVisitID_TaskStatusID_CreatedBy')
DROP INDEX Tasks.[NC_Tasks_TaskActionID_AssignedTo_RoleID_PatientVisitID_TaskStatusID_CreatedBy]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_TaxBillDetails_BillID')
DROP INDEX TaxBillDetails.[NC_TaxBillDetails_BillID]

-- Added on 06 Aug 2012 for KMH Perf tuning. The below 2 indexes have been redefined and created with different column set
IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_VisitID')
DROP INDEX FinalBill.[NC_FinalBill_OrgID_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_OrgID_VisitID')
DROP INDEX PatientDueChart.[NC_PatientDueChart_OrgID_VisitID]

IF EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_OrgID_BilledDate')
DROP INDEX BillingDetails.[NC_BillingDetails_OrgID_BilledDate]