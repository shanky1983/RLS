IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ActionRoleMapping_RoleID_SearchTypeID')
CREATE NONCLUSTERED INDEX NC_ActionRoleMapping_RoleID_SearchTypeID ON ActionRoleMapping(RoleID, SearchTypeID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AdvancePaidDetails_VisitID')
CREATE NONCLUSTERED INDEX NC_AdvancePaidDetails_VisitID ON AdvancePaidDetails(VisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_FinalBillID')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_FinalBillID ON AmountReceivedDetails(FinalBillID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_OrgID_AmtReceived')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_OrgID_AmtReceived ON AmountReceivedDetails(AmtReceived, OrgID) INCLUDE (FinalBillID, ReceivedBy, CreatedBy, CreatedAt, PaidCurrencyID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_OrgID_CreatedBy ON AmountReceivedDetails(OrgID, CreatedBy) INCLUDE (AmtReceived, CreatedAt, PaidCurrencyID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_CreatedBy')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_CreatedBy ON AmountReceivedDetails(CreatedBy) INCLUDE (FinalBillID, AmtReceived, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ReceivedBy ON AmountReceivedDetails(ReceivedBy) INCLUDE (AmtReceivedID, FinalBillID, AmtReceived, CreatedAt, TypeID, ReceiptNO, PaidCurrencyID, OtherCurrencyAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_CreatedBy_AmtReceived')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ClosureStatus_CreatedBy_AmtReceived ON AmountReceivedDetails(AmtReceived, ClosureStatus, CreatedBy) INCLUDE (CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_OrgID_ReceiptNO')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_OrgID_ReceiptNO ON AmountReceivedDetails(OrgID, ReceiptNO)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID ON AmountReceivedDetails(ReceivedBy, ClosureStatus, OrgID) INCLUDE (CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID_TypeID')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_OrgID_TypeID ON AmountReceivedDetails(ReceivedBy, ClosureStatus, OrgID, TypeID) INCLUDE (AmtReceived)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy ON AmountReceivedDetails(ClosureStatus, OrgID, CreatedBy) INCLUDE (AmtReceived, TypeID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy_PaidCurrencyID')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ClosureStatus_OrgID_CreatedBy_PaidCurrencyID ON AmountReceivedDetails(ClosureStatus, OrgID, CreatedBy, PaidCurrencyID) INCLUDE (TypeID, OtherCurrencyAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ReceivedBy_ClosureStatus ON AmountReceivedDetails(ReceivedBy, ClosureStatus) INCLUDE (AmtReceivedID, FinalBillID, AmtReceived, CreatedAt, TypeID, ReceiptNO, PaidCurrencyID, OtherCurrencyAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_TypeID')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ReceivedBy_ClosureStatus_TypeID ON AmountReceivedDetails(ReceivedBy, ClosureStatus, TypeID) INCLUDE (AmtReceivedID, FinalBillID, AmtReceived, CreatedAt, ReceiptNO, PaidCurrencyID, OtherCurrencyAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountReceivedDetails_ClosureStatus_CreatedBy_TypeID')
CREATE NONCLUSTERED INDEX NC_AmountReceivedDetails_ClosureStatus_CreatedBy_TypeID ON AmountReceivedDetails(ClosureStatus, CreatedBy, TypeID) INCLUDE (FinalBillID, AmtReceived)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_RefundBy')
CREATE NONCLUSTERED INDEX NC_AmountRefundDetails_RefundBy ON AmountRefundDetails(RefundBy) INCLUDE (AmtRefundID, FinalBillID, AmtRefund, CreatedAt, BillStatus, RefundNo, TranCurrencyID, PaymentTypeID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_RefundBy_OrgID_BillStatus')
CREATE NONCLUSTERED INDEX NC_AmountRefundDetails_RefundBy_OrgID_BillStatus ON AmountRefundDetails(RefundBy, OrgID, BillStatus) INCLUDE (AmtRefund, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_OrgID_RefundNo')
CREATE NONCLUSTERED INDEX NC_AmountRefundDetails_OrgID_RefundNo ON AmountRefundDetails(OrgID, RefundNo) INCLUDE (BillingDetailsID, AmtRefund)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_RefundType,CreatedAt')
CREATE NONCLUSTERED INDEX NC_AmountRefundDetails_RefundType,CreatedAt ON AmountRefundDetails(CreatedAt, RefundType) INCLUDE (FinalBillID, BillingDetailsID, Quantity)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_AmountRefundDetails_OrgID_RefundType_CreatedAt')
CREATE NONCLUSTERED INDEX NC_AmountRefundDetails_OrgID_RefundType_CreatedAt ON AmountRefundDetails(OrgID, CreatedAt, RefundType) INCLUDE (FinalBillID, AmtRefund)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'AmountRefundDetails_OrgID_Status')
CREATE NONCLUSTERED INDEX AmountRefundDetails_OrgID_Status ON AmountRefundDetails(RefundStatus, OrgID, BillStatus) INCLUDE (AmtRefund)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BannerRole_02')
CREATE NONCLUSTERED INDEX NC_BannerRole_02 ON BannerRoleMapping(BannerID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Banners_01')
CREATE NONCLUSTERED INDEX NC_Banners_01 ON Banners(OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BedBooking_BookingID')
CREATE NONCLUSTERED INDEX NC_BedBooking_BookingID ON BedBooking(BookingID) INCLUDE (BedID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BedMaster_01')
CREATE NONCLUSTERED INDEX NC_BedMaster_01 ON BedMaster(BedName)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_FeeType')
CREATE NONCLUSTERED INDEX NC_BillingDetails_FeeType ON BillingDetails(FeeType) INCLUDE (FinalBillID, FeeId)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_FinalBillID')
CREATE NONCLUSTERED INDEX NC_BillingDetails_FinalBillID ON BillingDetails(FinalBillID) INCLUDE (DiscountAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_CreatedBy_FeeId')
CREATE NONCLUSTERED INDEX NC_BillingDetails_CreatedBy_FeeId ON BillingDetails(FeeId, CreatedBy) INCLUDE (FinalBillID, Amount, CreatedAt, Quantity)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_FeedId')
CREATE NONCLUSTERED INDEX NC_BillingDetails_FeedId ON BillingDetails(FeeId) INCLUDE (FinalBillID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_SourceType_FeeId')
CREATE NONCLUSTERED INDEX NC_BillingDetails_SourceType_FeeId ON BillingDetails(FeeId, SourceType) INCLUDE (FinalBillID, Amount, CreatedBy, CreatedAt, Quantity)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_OrgID_CreatedAt')
--CREATE NONCLUSTERED INDEX NC_BillingDetails_OrgID ON BillingDetails(OrgID) INCLUDE (BillingDetailsID, FinalBillID, FeeId, FeeType, Amount, Quantity)
Create Nonclustered Index NC_BillingDetails_OrgID_CreatedAt on BillingDetails(OrgID, CreatedAt) Include (BillingDetailsID, FinalBillID, FeeId, FeeType, FeeDescription, Amount, CreatedBy, 
ModifiedBy, ModifiedAt, ItemType, Quantity, Rate, Status, IsCreditBill, BatchNo, ExpiryDate,       
FromDate, ToDate, AttributeDetail, ReceiptNO, DiscountAmount, IsReimbursable, RefPhysicianID, RefPhyName,       
IsTaxable, ServiceCode, ReferenceType, Perphyname, PerphyID, ReturnQuantity, SourceType, SourceTypeID,       
BilledDate, DiscountPercent, DiscOrEnhanceType, Remarks, RoomTypeID, kitid, LabNo, TaxPercent, ProductKey)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'BillingDetails_OrgID_FeeID')
CREATE NONCLUSTERED INDEX BillingDetails_OrgID_FeeID ON BillingDetails(FeeId, OrgID) INCLUDE (FinalBillID, Amount, CreatedBy, CreatedAt, Quantity)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Bookings_BookingStatus')
CREATE NONCLUSTERED INDEX NC_Bookings_BookingStatus ON Bookings(BookingStatus) INCLUDE (BookingID, ScheduleID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Bookings_ScheduleID')
CREATE NONCLUSTERED INDEX NC_Bookings_ScheduleID ON Bookings(ScheduleID) INCLUDE (BookingID, BookingStatus)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_OrgID')
CREATE NONCLUSTERED INDEX NC_CashOutFlow_OrgID ON CashOutFlow(OrgID) INCLUDE (AmountReceived, CreatedBy, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_ReceiverID_ClosureStatus_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_CashOutFlow_ReceiverID_ClosureStatus_OrgID_CreatedBy ON CashOutFlow(ReceiverID, ClosureStatus, OrgID, CreatedBy) INCLUDE (AmountReceived)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy_ReceiverID')
CREATE NONCLUSTERED INDEX NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy_ReceiverID ON CashOutFlow(ReceiverID, ClosureStatus, OrgID, CreatedBy) INCLUDE (AmountReceived)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_CashOutFlow_ClosureStatus_OrgID_CreatedBy ON CashOutFlow(ClosureStatus, OrgID, CreatedBy) INCLUDE (OutFlowID, ReceiverID, ReceiverName, ReceiverType, AmountReceived, Remarks)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlow_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_CashOutFlow_OrgID_CreatedBy ON CashOutFlow(OrgID, CreatedBy) INCLUDE (OutFlowID, ReceiverID, ReceiverName, AmountReceived, Remarks, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_CashOutFlowDetails_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_CashOutFlowDetails_OrgID_CreatedBy ON CashOutFlowDetails(OrgID, CreatedBy) INCLUDE (AmtPaid, CreatedAt, TypeID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ConfigKeyMaster_ConfigKeyID_ConfigKey')
CREATE NONCLUSTERED INDEX NC_ConfigKeyMaster_ConfigKeyID_ConfigKey ON ConfigKeyMaster(ConfigKeyID) INCLUDE (ConfigKey)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ConfigOrgMaster_OrgID')
CREATE NONCLUSTERED INDEX NC_ConfigOrgMaster_OrgID ON ConfigOrgMaster(OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ConfigOrgMaster_OrgID_ConfigKeyID')
CREATE NONCLUSTERED INDEX NC_ConfigOrgMaster_OrgID_ConfigKeyID ON ConfigOrgMaster(ConfigKeyID, OrgID) INCLUDE (ConfigValue)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'pk_ConfigValueMaster')
CREATE NONCLUSTERED INDEX pk_ConfigValueMaster ON ConfigValueMaster(ConfigValueID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_DischargeSummary_PatientVistID')
CREATE NONCLUSTERED INDEX NC_DischargeSummary_PatientVistID ON DischargeSummary(PatientVistID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_DrugBrand_OrgID_BrandName')
CREATE NONCLUSTERED INDEX NC_DrugBrand_OrgID_BrandName ON DrugBrand(BrandName, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_DrugBrand_OrgID_Strength')
CREATE NONCLUSTERED INDEX NC_DrugBrand_OrgID_Strength ON DrugBrand(Strength, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_VisitID')
CREATE NONCLUSTERED INDEX NC_FinalBill_VisitID ON FinalBill(VisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_PatientID_FinalBillID')
CREATE NONCLUSTERED INDEX NC_FinalBill_PatientID_FinalBillID ON FinalBill(FinalBillID, PatientID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_FinalBill_OrgID_CreatedBy ON FinalBill(OrgID, CreatedBy) INCLUDE (VisitID, DiscountAmount, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_PatientID_VisitID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_FinalBill_OrgID_PatientID_VisitID_CreatedBy ON FinalBill(OrgID, PatientID, VisitID, CreatedBy)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_VisitID_CreatedAt')
CREATE NONCLUSTERED INDEX NC_FinalBill_OrgID_VisitID_CreatedAt ON FinalBill(OrgID, VisitID, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID')
CREATE NONCLUSTERED INDEX NC_FinalBill_OrgID ON FinalBill(OrgID) INCLUDE (FinalBillID, VisitID, IsCreditBill)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_VisitID')
CREATE NONCLUSTERED INDEX NC_FinalBill_OrgID_VisitID ON FinalBill(OrgID, VisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FloorMaster_01')
CREATE NONCLUSTERED INDEX NC_FloorMaster_01 ON FloorMaster(FloorName)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_ICDCodes_01')
CREATE NONCLUSTERED INDEX NC_ICDCodes_01 ON ICDCodes(ICDCodeID) INCLUDE (ICDDescription)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InPatientAdmissionDetails_VisitID')
CREATE NONCLUSTERED INDEX NC_InPatientAdmissionDetails_VisitID ON InPatientAdmissionDetails(VisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InPatientNumber_PatientID')
CREATE NONCLUSTERED INDEX NC_InPatientNumber_PatientID ON InPatientNumber(PatientID) INCLUDE (IPNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Intend_IntendID_OrgID')
CREATE NONCLUSTERED INDEX NC_Intend_IntendID_OrgID ON Intend(IntendID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Intend_OrgID')
CREATE NONCLUSTERED INDEX NC_Intend_OrgID ON Intend(OrgID) INCLUDE (IntendID, IntendDate, IntendNo, Status, LocationID, ToLocationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Intend_IntendID')
CREATE NONCLUSTERED INDEX NC_Intend_IntendID ON Intend(IntendID) INCLUDE (IntendDate, IntendNo, LocationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceived_OrgID')
CREATE NONCLUSTERED INDEX NC_IntendReceived_OrgID ON IntendReceived(OrgID) INCLUDE (IntendReceivedID, IntendID, IntendIssuedDate, Status, FromLocationID, ToLocationID, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceived_IntendID')
CREATE NONCLUSTERED INDEX NC_IntendReceived_IntendID ON IntendReceived(IntendID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_OrgID_BatchNo')
CREATE NONCLUSTERED INDEX NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_OrgID_BatchNo ON IntendReceivedDetail(IntendReceivedDetailID, ProductID, OrgID, BatchNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_OrgID')
CREATE NONCLUSTERED INDEX NC_IntendReceivedDetail_OrgID ON IntendReceivedDetail(OrgID) INCLUDE (IntendReceivedDetailID, ProductID, BatchNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedID')
CREATE NONCLUSTERED INDEX NC_IntendReceivedDetail_IntendReceivedID ON IntendReceivedDetail(IntendReceivedID) INCLUDE (IntendReceivedDetailID, ProductID, Quantity, BatchNo, IssueQty, RecdQty)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID')
CREATE NONCLUSTERED INDEX NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID ON IntendReceivedDetail(IntendReceivedDetailID, ProductID) INCLUDE (IssueQty, ProductKey)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_ProductKey')
CREATE NONCLUSTERED INDEX NC_IntendReceivedDetail_IntendReceivedDetailID_ProductID_ProductKey ON IntendReceivedDetail(IntendReceivedDetailID, ProductID, ProductKey) INCLUDE (IssueQty)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvDeptSamples_PatientVisitID_OrgID')
CREATE NONCLUSTERED INDEX NC_InvDeptSamples_PatientVisitID_OrgID ON InvDeptSamples(PatientVisitID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationOrgMapping_OrgID')
CREATE NONCLUSTERED INDEX NC_InvestigationOrgMapping_OrgID ON InvestigationOrgMapping(OrgID) INCLUDE (InvestigationID, DisplayText)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationOrgMapping_OrgID_InvID_DeptID')
CREATE NONCLUSTERED INDEX NC_InvestigationOrgMapping_OrgID_InvID_DeptID ON InvestigationOrgMapping(OrgID) INCLUDE (InvestigationID, DeptID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_InvestigationID')
CREATE NONCLUSTERED INDEX NC_InvestigationValues_InvestigationID ON InvestigationValues(InvestigationID) INCLUDE (Value)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_InvestigationID_GroupID_PatientVisitID_Orgid')
CREATE NONCLUSTERED INDEX NC_InvestigationValues_InvestigationID_GroupID_PatientVisitID_Orgid ON InvestigationValues(InvestigationID, GroupID, PatientVisitID, Orgid) INCLUDE (InvestigationValueID, Name, Value, UOMCode, GroupName, SequenceNo, UID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_PatientVisitID_Orgid_PackageID_UID')
CREATE NONCLUSTERED INDEX NC_InvestigationValues_PatientVisitID_Orgid_PackageID_UID ON InvestigationValues(PatientVisitID, Orgid, PackageID, UID) INCLUDE (InvestigationValueID, Name, Value, InvestigationID, GroupID, UOMCode, GroupName, SequenceNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvestigationValues_PatientVisitID_Orgid_PackageID')
CREATE NONCLUSTERED INDEX NC_InvestigationValues_PatientVisitID_Orgid_PackageID ON InvestigationValues(PatientVisitID, Orgid, PackageID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvOrgGroup')
CREATE NONCLUSTERED INDEX NC_InvOrgGroup ON InvOrgGroup(OrgGroupID, OrgID) INCLUDE (AttGroupID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvRateMaster_Type_RateID')
CREATE NONCLUSTERED INDEX NC_InvRateMaster_Type_RateID ON InvRateMaster(Type, RateID) INCLUDE (ID, Rate)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvRateMaster_Type_ID_RateID')
CREATE NONCLUSTERED INDEX NC_InvRateMaster_Type_ID_RateID ON InvRateMaster(Type, ID, RateID) INCLUDE (IPAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_InvRateMaster_Type')
CREATE NONCLUSTERED INDEX NC_InvRateMaster_Type ON InvRateMaster(Type) INCLUDE (ID, RateID, Rate)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_VisitID')
CREATE NONCLUSTERED INDEX NC_IPIntermediatePayments_VisitID ON IPIntermediatePayments(VisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_IsSettlementPage_AmountReceived')
CREATE NONCLUSTERED INDEX NC_IPIntermediatePayments_IsSettlementPage_AmountReceived ON IPIntermediatePayments(AmountReceived, IsSettlementPage) INCLUDE (PaymentDetailsID, VisitID, CreatedBy, CreatedAt, ReceiptNO)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_CreatedBy')
CREATE NONCLUSTERED INDEX NC_IPIntermediatePayments_CreatedBy ON IPIntermediatePayments(CreatedBy) INCLUDE (VisitID, AmountReceived, CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPIntermediatePayments_ReceiptNO')
CREATE NONCLUSTERED INDEX NC_IPIntermediatePayments_ReceiptNO ON IPIntermediatePayments(ReceiptNO) INCLUDE (VisitID, StartBillingDetailID, EndBillingDetaillID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPTreatmentPlan_OperationID')
CREATE NONCLUSTERED INDEX NC_IPTreatmentPlan_OperationID ON IPTreatmentPlan(OperationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPTreatmentPlan_PatientVisitID')
CREATE NONCLUSTERED INDEX NC_IPTreatmentPlan_PatientVisitID ON IPTreatmentPlan(PatientVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_IPTreatmentPlan_PatientVisitID_Status_StagePlanned')
CREATE NONCLUSTERED INDEX NC_IPTreatmentPlan_PatientVisitID_Status_StagePlanned ON IPTreatmentPlan(PatientVisitID, Status, StagePlanned)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitMaster_OrgID_MasterKitID')
CREATE NONCLUSTERED INDEX NC_KitMaster_OrgID_MasterKitID ON KitMaster(MasterKitID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMaster_OrgID_MasterKitID')
CREATE NONCLUSTERED INDEX NC_KitPrepMaster_OrgID_MasterKitID ON KitPrepMaster(MasterKitID, OrgID) INCLUDE (KitID, ExpiryDate, KitBatchNo, CreatedAt, Status)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMaster_LocationID')
CREATE NONCLUSTERED INDEX NC_KitPrepMaster_LocationID ON KitPrepMaster(LocationID) INCLUDE (KitID, MasterKitID, KitBatchNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_KitID_LocationID')
CREATE NONCLUSTERED INDEX NC_KitPrepMasterDetails_KitID_LocationID ON KitPrepMasterDetails(KitID, LocationID) INCLUDE (Quantity, SellingPrice)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_KitID_LocationID_IsReimbursable')
CREATE NONCLUSTERED INDEX NC_KitPrepMasterDetails_KitID_LocationID_IsReimbursable ON KitPrepMasterDetails(KitID, LocationID, IsReimbursable) INCLUDE (Quantity, SellingPrice)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_LocationID_IsReimbursable')
CREATE NONCLUSTERED INDEX NC_KitPrepMasterDetails_LocationID_IsReimbursable ON KitPrepMasterDetails(LocationID, IsReimbursable) INCLUDE (KitID, Quantity, SellingPrice)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_LocationID')
CREATE NONCLUSTERED INDEX NC_KitPrepMasterDetails_LocationID ON KitPrepMasterDetails(LocationID) INCLUDE (KitID, Quantity, SellingPrice)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_OrgID')
CREATE NONCLUSTERED INDEX NC_KitPrepMasterDetails_OrgID ON KitPrepMasterDetails(OrgID) INCLUDE (MasterKitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_KitPrepMasterDetails_MasterKitID_OrgID')
CREATE NONCLUSTERED INDEX NC_KitPrepMasterDetails_MasterKitID_OrgID ON KitPrepMasterDetails(MasterKitID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_LoggedInUsers_LoginID_SessionID')
CREATE NONCLUSTERED INDEX NC_LoggedInUsers_LoginID_SessionID ON LoggedInUsers(LoginID, SessionID) INCLUDE (CreatedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Login_LoginName_Password_IsLocked_Status')
CREATE NONCLUSTERED INDEX NC_Login_LoginName_Password_IsLocked_Status ON Login(LoginName, Password, IsLocked, Status)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_NRI_01')
CREATE NONCLUSTERED INDEX NC_NRI_01 ON NonReimbursableItems(OrgID, IsActive)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_VisitID_OrgID_LabNo')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_VisitID_OrgID_LabNo ON OrderedInvestigations(VisitID, OrgID, LabNo) INCLUDE (Status, AccessionNumber, CreatedAt, ResCaptureLoc)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_CreatedAt')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_Type_CreatedAt ON OrderedInvestigations(Type, CreatedAt) INCLUDE (VisitID, ID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_ID_Type_OrgID')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_ID_Type_OrgID ON OrderedInvestigations(ID, Type, OrgID) INCLUDE (AccessionNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_OrgID')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_Type_OrgID ON OrderedInvestigations(Type, OrgID) INCLUDE (ID, AccessionNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Status')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_Status ON OrderedInvestigations(Status) INCLUDE (AccessionNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_OrgID_Status')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_Type_OrgID_Status ON OrderedInvestigations(Type, Status, OrgID) INCLUDE (VisitID, ID, CreatedAt, UID, ResCaptureLoc, LabNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_ID_Type_Status')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_ID_Type_Status ON OrderedInvestigations(ID, Type, Status) INCLUDE (VisitID, CreatedAt, UID, ResCaptureLoc, LabNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_AccessionNumber')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_AccessionNumber ON OrderedInvestigations(AccessionNumber) INCLUDE (Status)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrderedInvestigations_Type_Status')
CREATE NONCLUSTERED INDEX NC_OrderedInvestigations_Type_Status ON OrderedInvestigations(Type, Status) INCLUDE (VisitID, ID, CreatedAt, UID, ResCaptureLoc, LabNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrganizationSpeciality_OrganizationID')
CREATE NONCLUSTERED INDEX NC_OrganizationSpeciality_OrganizationID ON OrganizationSpeciality(OrganizationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_OrgUOMVitalsMapping_OrgID')
CREATE NONCLUSTERED INDEX NC_OrgUOMVitalsMapping_OrgID ON OrgUOMVitalsMapping(OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Patient_OrganizationID_PatientNumber')
CREATE NONCLUSTERED INDEX NC_Patient_OrganizationID_PatientNumber ON Patient(OrganizationID, PatientNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Patient_PatID_OrganizationID')
CREATE NONCLUSTERED INDEX NC_Patient_PatID_OrganizationID ON Patient(PatientID, OrganizationID, RegistrationDTTM) INCLUDE (Name, TITLECode, SEX, Age, PatientNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Patient_OrgID')
CREATE NONCLUSTERED INDEX NC_Patient_OrgID ON Patient(OrganizationID) INCLUDE (PatientID, Name, DOB, Age, PatientNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientAddress_PatientID_AddressType')
CREATE NONCLUSTERED INDEX NC_PatientAddress_PatientID_AddressType ON PatientAddress(PatientID, AddressType) INCLUDE (Add1, Add2, Add3, CountryID, City, StateID, MobileNumber, LandLineNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientAddress_AddressType_MobileNumber')
CREATE NONCLUSTERED INDEX NC_PatientAddress_AddressType_MobileNumber ON PatientAddress(AddressType, MobileNumber)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientComplaint_PatientVisitID_ComplaintType')
CREATE NONCLUSTERED INDEX NC_PatientComplaint_PatientVisitID_ComplaintType ON PatientComplaint(PatientVisitID, ComplaintType)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_FeeType_IsReimbursable_Status')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_VisitID_FeeType_IsReimbursable_Status ON PatientDueChart(VisitID, FeeType, Status, IsReimbursable) INCLUDE (unit, Amount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_FeeType')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_FeeType ON PatientDueChart(FeeType) INCLUDE (FeeID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_FeeType_FeeID')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_FeeType_FeeID ON PatientDueChart(FeeType, FeeID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_Status_unit')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_VisitID_Status_unit ON PatientDueChart(VisitID, Status, unit) INCLUDE (DetailsID, PatientID, FeeType, FeeID, Description, Comments, FromDate, ToDate, CreatedAt, Amount, BatchNo, ExpiryDate, IsReimbursable, IsTaxable, ServiceCode, InterimBillNo, DiscountAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_FeeType_Status_unit')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_VisitID_FeeType_Status_unit ON PatientDueChart(VisitID, FeeType, Status, unit) INCLUDE (DetailsID, FeeID, Description, Comments, FromDate, ToDate, CreatedAt, Amount, IsReimbursable, DiscountAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_PatientID')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_VisitID_PatientID ON PatientDueChart(VisitID, PatientID) INCLUDE (CreatedAt, ModifiedAt)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_Status')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_VisitID_Status ON PatientDueChart(VisitID, Status) INCLUDE (DiscountAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_VisitID_FeeType')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_VisitID_FeeType ON PatientDueChart(VisitID, FeeType) INCLUDE (FeeID, Amount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_FeeType_Status_CreatedAt')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_FeeType_Status_CreatedAt ON PatientDueChart(FeeType, Status, CreatedAt) INCLUDE (DetailsID, VisitID, FeeID, unit, Amount, InterimBillNo, TaxPercent)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_Status_InterimBillNo')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_Status_InterimBillNo ON PatientDueChart(Status, InterimBillNo) INCLUDE (VisitID, Description, unit, Amount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_Status_CreatedAt')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_Status_CreatedAt ON PatientDueChart(Status, CreatedAt) INCLUDE (DetailsID, VisitID, FeeType, FeeID, Description, unit, Amount, BatchNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueDetails_FinalBillID_Status')
CREATE NONCLUSTERED INDEX NC_PatientDueDetails_FinalBillID_Status ON PatientDueDetails(FinalBillID, Status) INCLUDE (DueAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueDetails_Status_FinalBillID')
CREATE NONCLUSTERED INDEX NC_PatientDueDetails_Status_FinalBillID ON PatientDueDetails(FinalBillID, Status) INCLUDE (DueAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueDetails_Status')
CREATE NONCLUSTERED INDEX NC_PatientDueDetails_Status ON PatientDueDetails(Status) INCLUDE (PatientID, DueAmount, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueRefundDetails_DetailsID_Status')
CREATE NONCLUSTERED INDEX NC_PatientDueRefundDetails_DetailsID_Status ON PatientDueRefundDetails(DetailsID, Status) INCLUDE (RefundNO, Quantity, Rate)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueRefundDetails_RefundNo_OrgID_DetailsID')
CREATE NONCLUSTERED INDEX NC_PatientDueRefundDetails_RefundNo_OrgID_DetailsID ON PatientDueRefundDetails(DetailsID, RefundNO, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientExamination_PatientVisitID')
CREATE NONCLUSTERED INDEX NC_PatientExamination_PatientVisitID ON PatientExamination(PatientVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientExamination_PatientVisitID_ExaminationID')
CREATE NONCLUSTERED INDEX NC_PatientExamination_PatientVisitID_ExaminationID ON PatientExamination(PatientVisitID, ExaminationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_PatientVisitID_OrgID_PackageID')
CREATE NONCLUSTERED INDEX NC_PatientInvestigation_PatientVisitID_OrgID_PackageID ON PatientInvestigation(PatientVisitID, OrgID, PackageID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_PatientVisitID_OrgID_GroupID')
CREATE NONCLUSTERED INDEX NC_PatientInvestigation_PatientVisitID_OrgID_GroupID ON PatientInvestigation(PatientVisitID, GroupID, OrgID) INCLUDE (InvestigationID, InvestigationName, GroupName)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_PatientVisitID_OrgID')
CREATE NONCLUSTERED INDEX NC_PatientInvestigation_PatientVisitID_OrgID ON PatientInvestigation(PatientVisitID, OrgID) INCLUDE (InvestigationID, InvestigationName, GroupName)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvestigation_OrgID_Status')
CREATE NONCLUSTERED INDEX NC_PatientInvestigation_OrgID_Status ON PatientInvestigation(Status, OrgID) INCLUDE (PatientVisitID, InvestigationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSample_PatientVisitID_OrgID')
CREATE NONCLUSTERED INDEX NC_PatientInvSample_PatientVisitID_OrgID ON PatientInvSample(PatientVisitID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSample_SampleID')
CREATE NONCLUSTERED INDEX NC_PatientInvSample_SampleID ON PatientInvSample(SampleID) INCLUDE (SampleCode)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSample_PatientVisitID_SampleID_OrgID')
CREATE NONCLUSTERED INDEX NC_PatientInvSample_PatientVisitID_SampleID_OrgID ON PatientInvSample(PatientVisitID, SampleID, OrgID) INCLUDE (BarcodeNumber, SampleCode, SampleContainerID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSampleMapping_VisitID_OrgID')
CREATE NONCLUSTERED INDEX NC_PatientInvSampleMapping_VisitID_OrgID ON PatientInvSampleMapping(VisitID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientInvSampleMapping_VisitID_OrgID_SampleID')
CREATE NONCLUSTERED INDEX NC_PatientInvSampleMapping_VisitID_OrgID_SampleID ON PatientInvSampleMapping(VisitID, OrgID, SampleID) INCLUDE (DeptID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientPrescription_PatientVisitID_DrugStatus_PrescriptionType')
CREATE NONCLUSTERED INDEX NC_PatientPrescription_PatientVisitID_DrugStatus_PrescriptionType ON PatientPrescription(PatientVisitID, DrugStatus, PrescriptionType)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientPrescription_PatientVisitID_PrescriptionType')
CREATE NONCLUSTERED INDEX NC_PatientPrescription_PatientVisitID_PrescriptionType ON PatientPrescription(PatientVisitID, PrescriptionType)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientTPADetails_PatientVisitID')
CREATE NONCLUSTERED INDEX NC_PatientTPADetails_PatientVisitID ON PatientTPADetails(PatientVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientTPADetails_PatientID_PatientVisitID_TPAID')
CREATE NONCLUSTERED INDEX NC_PatientTPADetails_PatientID_PatientVisitID_TPAID ON PatientTPADetails(PatientID, PatientVisitID, TPAID) INCLUDE (TPAAttributes)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_PatientID')
CREATE NONCLUSTERED INDEX NC_PatientVisit_PatientID ON PatientVisit(PatientID) INCLUDE (PatientVisitId, VisitState)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_SpecialityID')
CREATE NONCLUSTERED INDEX NC_PatientVisit_SpecialityID ON PatientVisit(SpecialityID) INCLUDE (PatientID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_PatientID_SpecialityID')
CREATE NONCLUSTERED INDEX NC_PatientVisit_PatientID_SpecialityID ON PatientVisit(PatientID, SpecialityID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_PhysicianID_VisitType')
CREATE NONCLUSTERED INDEX NC_PatientVisit_OrganizationID_PhysicianID_VisitType ON PatientVisit(OrganizationID, PhysicianID, VisitType) INCLUDE (PatientVisitId, PatientID, VisitDate, VisitPurposeID, AdmissionSuggested, ReferingPhysicianName, ExternalVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitType')
CREATE NONCLUSTERED INDEX NC_PatientVisit_OrganizationID_VisitType ON PatientVisit(OrganizationID, VisitType) INCLUDE (PatientVisitId, PatientID, VisitDate, PhysicianID, VisitPurposeID, AdmissionSuggested, ReferingPhysicianName, ExternalVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_VisitType')
CREATE NONCLUSTERED INDEX NC_PatientVisit_VisitType ON PatientVisit(VisitType) INCLUDE (PatientVisitId, DischargedDT)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_VisitType_VisitState_VisitDate')
CREATE NONCLUSTERED INDEX NC_PatientVisit_VisitType_VisitState_VisitDate ON PatientVisit(VisitDate, VisitType, VisitState) INCLUDE (PatientVisitId, PatientID, IsDayCare)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitState_DischargedDT')
CREATE NONCLUSTERED INDEX NC_PatientVisit_OrganizationID_VisitState_DischargedDT ON PatientVisit(OrganizationID, VisitState, DischargedDT) INCLUDE (PatientVisitId, PatientID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_VisitType_VisitDate')
CREATE NONCLUSTERED INDEX NC_PatientVisit_VisitType_VisitDate ON PatientVisit(VisitDate, VisitType) INCLUDE (PatientID, PhysicianID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitType_VisitState')
CREATE NONCLUSTERED INDEX NC_PatientVisit_OrganizationID_VisitType_VisitState ON PatientVisit(OrganizationID, VisitType, VisitState) INCLUDE (PatientVisitId, PatientID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_VisitPurpose_CreatedAt')
CREATE NONCLUSTERED INDEX NC_PatientVisit_OrganizationID_VisitPurpose_CreatedAt ON PatientVisit(OrganizationID, VisitPurposeID, CreatedAt) INCLUDE (PatientVisitId, PatientID, VisitDate, OrgAddressID, VisitType, ExternalVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVisit_OrganizationID_PatientID_PatientVisitID')
CREATE NONCLUSTERED INDEX NC_PatientVisit_OrganizationID_PatientID_PatientVisitID ON PatientVisit(PatientVisitId, PatientID, OrganizationID) INCLUDE (OrgAddressID, VisitType, ExternalVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVitals_PatientVisitID_VitalsSetID')
CREATE NONCLUSTERED INDEX NC_PatientVitals_PatientVisitID_VitalsSetID ON PatientVitals(PatientVisitID, VitalsSetID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientVitals_PatientVisitID')
CREATE NONCLUSTERED INDEX NC_PatientVitals_PatientVisitID ON PatientVitals(PatientVisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PhysicianFee_RateID')
CREATE NONCLUSTERED INDEX NC_PhysicianFee_RateID ON PhysicianFee(RateID) INCLUDE (PhysicianFeeID, PhysicianID, Amount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PrimaryConsultant_VisitID')
CREATE NONCLUSTERED INDEX NC_PrimaryConsultant_VisitID ON PrimaryConsultant(VisitID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID_TypeID')
CREATE NONCLUSTERED INDEX NC_Products_OrgID_TypeID ON Products(OrgID, TypeID) INCLUDE (ProductID, ProductName, CategoryID, HasExpiryDate, HasBatchNo, IsDeleted, TaxPercent)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID')
CREATE NONCLUSTERED INDEX NC_Products_OrgID ON Products(OrgID) INCLUDE (ProductID, ProductName, CategoryID, HasExpiryDate, TypeID, HasBatchNo, IsDeleted, TaxPercent)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID_AddrID_ProductName')
CREATE NONCLUSTERED INDEX NC_Products_OrgID_AddrID_ProductName ON Products(ProductName, OrgID, OrgAddressID) INCLUDE (ProductID, CategoryID, LSU, HasExpiryDate, TypeID, IsDeleted)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_OrgID_AddrID_TypeID_ProductName')
CREATE NONCLUSTERED INDEX NC_Products_OrgID_AddrID_TypeID_ProductName ON Products(ProductName, OrgID, OrgAddressID, TypeID) INCLUDE (ProductID, CategoryID, LSU, HasExpiryDate, IsDeleted)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Products_ProductID_Spec')
CREATE NONCLUSTERED INDEX NC_Products_ProductID_Spec ON Products(OrgID, Specification1) INCLUDE (ProductName)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrderDetails_PurchaseOrderId')
CREATE NONCLUSTERED INDEX NC_PurchaseOrderDetails_PurchaseOrderId ON PurchaseOrderDetails(PurchaseOrderId) INCLUDE (ProductID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrders_PurchaseOrderID_OrgID_SupplierID')
CREATE NONCLUSTERED INDEX NC_PurchaseOrders_PurchaseOrderID_OrgID_SupplierID ON PurchaseOrders(PurchaseOrderID, OrgID, SupplierID) INCLUDE (PurchaseOrderNo)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrders_PurchaseOrderID_OrgID')
CREATE NONCLUSTERED INDEX NC_PurchaseOrders_PurchaseOrderID_OrgID ON PurchaseOrders(PurchaseOrderID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PurchaseOrders_PurchaseOrderNo_OrgID')
CREATE NONCLUSTERED INDEX NC_PurchaseOrders_PurchaseOrderNo_OrgID ON PurchaseOrders(PurchaseOrderNo, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_RoleMenu_RoleID_IsMapped')
CREATE NONCLUSTERED INDEX NC_RoleMenu_RoleID_IsMapped ON RoleMenu(RoleID, IsMapped)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SampleTracker_PatientVisitID_OrgID')
CREATE NONCLUSTERED INDEX NC_SampleTracker_PatientVisitID_OrgID ON SampleTracker(PatientVisitID, OrgID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Schedules_ResourceTemplateID')
CREATE NONCLUSTERED INDEX NC_Schedules_ResourceTemplateID ON Schedules(ResourceTemplateID) INCLUDE (NextOccurance)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_State_CountryID')
CREATE NONCLUSTERED INDEX NC_State_CountryID ON State(CountryID) INCLUDE (StateID, StateName, IsDefault)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockInHand_OrgID_AddrID_LocID')
CREATE NONCLUSTERED INDEX NC_StockInHand_OrgID_AddrID_LocID ON StockInHand(OrgID, OrgAddressID, LocationID) INCLUDE (ProductID, TotalStockReceived, TotalStockIssued, TotalStockReturn, TotalStockDamage, BatchNo, ExpiryDate, SellingPrice, SellingUnit)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockInHand_ProdID_BatchNo')
CREATE NONCLUSTERED INDEX NC_StockInHand_ProdID_BatchNo ON StockInHand(ProductID, BatchNo) INCLUDE (TotalStockReceived, TotalStockIssued, TotalStockReturn, TotalStockDamage, TotalLocationIssued)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlow_OrgID_OrgAddressID_BillID_LocationID')
CREATE NONCLUSTERED INDEX NC_StockOutFlow_OrgID_OrgAddressID_BillID_LocationID ON StockOutFlow(OrgID, OrgAddressID, BillID, LocationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlow_OrgID_OrgAddressID_LocationID')
CREATE NONCLUSTERED INDEX NC_StockOutFlow_OrgID_OrgAddressID_LocationID ON StockOutFlow(OrgID, OrgAddressID, LocationID) INCLUDE (BillID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'StockOutFlow_ReferenceID')
CREATE NONCLUSTERED INDEX StockOutFlow_ReferenceID ON StockOutFlow(ReferenceID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_OrgID_LocationID')
CREATE NONCLUSTERED INDEX NC_StockOutFlowDetails_OrgID_LocationID ON StockOutFlowDetails(OrgID, LocationID) INCLUDE (StockOutFlowDetailsID, StockOutFlowID, ProductID, ProductKey)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_OrgID_ProductID_LocationID_ProductKey')
CREATE NONCLUSTERED INDEX NC_StockOutFlowDetails_OrgID_ProductID_LocationID_ProductKey ON StockOutFlowDetails(OrgID, ProductID, LocationID, ProductKey) INCLUDE (StockOutFlowDetailsID, StockOutFlowID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_StockOutFlowID_OrgID_LocationID')
CREATE NONCLUSTERED INDEX NC_StockOutFlowDetails_StockOutFlowID_OrgID_LocationID ON StockOutFlowDetails(StockOutFlowID, OrgID, LocationID) INCLUDE (StockOutFlowDetailsID, ProductID, Quantity, ProductKey)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockOutFlowDetails_OrgID_ProductID_BatchNo_ProductKey')
CREATE NONCLUSTERED INDEX NC_StockOutFlowDetails_OrgID_ProductID_BatchNo_ProductKey ON StockOutFlowDetails(OrgID, ProductID, BatchNo, ProductKey) INCLUDE (StockOutFlowDetailsID, StockOutFlowID, Quantity)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_SupplierID')
CREATE NONCLUSTERED INDEX NC_StockReceived_OrgID_OrgAddressID_SupplierID ON StockReceived(SupplierID, OrgID, OrgAddressID) INCLUDE (StockReceivedID, StockReceivedNo, StockReceivedDate, Status, ToLocationID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_DCNumber')
CREATE NONCLUSTERED INDEX NC_StockReceived_OrgID_OrgAddressID_DCNumber ON StockReceived(OrgID, OrgAddressID, DCNumber) INCLUDE (StockReceivedID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_SupplierID_OrgID_OrgAddressID_CreatedAt_PaymentStatus')
CREATE NONCLUSTERED INDEX NC_StockReceived_SupplierID_OrgID_OrgAddressID_CreatedAt_PaymentStatus ON StockReceived(SupplierID, OrgID, CreatedAt, OrgAddressID, PaymentStatus) INCLUDE (StockReceivedID, StockReceivedNo, StockReceivedDate, PurchaseOrderNo, InvoiceNo, PaidAmount)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_FromLocationID_Comments')
CREATE NONCLUSTERED INDEX NC_StockReceived_OrgID_FromLocationID_Comments ON StockReceived(OrgID, FromLocationID, Comments)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_StockReceivedNo')
CREATE NONCLUSTERED INDEX NC_StockReceived_OrgID_OrgAddressID_StockReceivedNo ON StockReceived(StockReceivedNo, OrgID, OrgAddressID) INCLUDE (StockReceivedID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_InvoiceNo')
CREATE NONCLUSTERED INDEX NC_StockReceived_OrgID_OrgAddressID_InvoiceNo ON StockReceived(OrgID, OrgAddressID, InvoiceNo) INCLUDE (StockReceivedID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceived_OrgID_OrgAddressID_PurchaseOrderNo')
CREATE NONCLUSTERED INDEX NC_StockReceived_OrgID_OrgAddressID_PurchaseOrderNo ON StockReceived(PurchaseOrderNo, OrgID, OrgAddressID) INCLUDE (StockReceivedID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_StockReceivedId')
CREATE NONCLUSTERED INDEX NC_StockReceivedDetails_StockReceivedId ON StockReceivedDetails(StockReceivedId) INCLUDE (ProductId)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_OrgID')
CREATE NONCLUSTERED INDEX NC_StockReceivedDetails_OrgID ON StockReceivedDetails(OrgID) INCLUDE (ProductId, BatchNo, UnitPrice)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_OrgID_ProdID_BatchNo')
CREATE NONCLUSTERED INDEX NC_StockReceivedDetails_OrgID_ProdID_BatchNo ON StockReceivedDetails(OrgID, ProductId, BatchNo) INCLUDE (UnitPrice)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_StockReceivedDetails_StockReceivedDetailsId_OrgID_ProdID_StockReceivedId')
CREATE NONCLUSTERED INDEX NC_StockReceivedDetails_StockReceivedDetailsId_OrgID_ProdID_StockReceivedId ON StockReceivedDetails(StockReceivedDetailsId, StockReceivedId, OrgID, ProductId) INCLUDE (BatchNo, ExpiryDate, Manufacture, ComplimentQTY, Tax, Discount, RECUnit, SellingUnit, InvoiceQty, RcvdLSUQty, UnitSellingPrice, UnitCostPrice, RakNo, MRP, ExciseTax)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SurgeryBillingDetails_SurgeryBillingID')
CREATE NONCLUSTERED INDEX NC_SurgeryBillingDetails_SurgeryBillingID ON SurgeryBillingDetails(SurgeryBillingID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SurgeryBillingMaster_OrgID_ChiefSurgeonID')
CREATE NONCLUSTERED INDEX NC_SurgeryBillingMaster_OrgID_ChiefSurgeonID ON SurgeryBillingMaster(OrgID, ChiefSurgeonID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_SurgeryPackageMaster_01')
CREATE NONCLUSTERED INDEX NC_SurgeryPackageMaster_01 ON SurgeryPackageMaster(OrgID, ActiveYN, RateID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_TaskActionMapping_OrgID_VisitPurposeID_OtherID')
CREATE NONCLUSTERED INDEX NC_TaskActionMapping_OrgID_VisitPurposeID_OtherID ON TaskActionMapping(OrgID, VisitPurposeID, OtherID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_TaskEscalation_TaskActionID_OrgID_AllowedElaspsedTime')
CREATE NONCLUSTERED INDEX NC_TaskEscalation_TaskActionID_OrgID_AllowedElaspsedTime ON TaskEscalation(TaskActionID, OrgID, AllowedElaspsedTime)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Tasks_RoleID_OrgID_TaskDate')
CREATE NONCLUSTERED INDEX NC_Tasks_RoleID_OrgID_TaskDate ON Tasks(TaskDate, RoleID, OrgID) INCLUDE (TaskID, TaskActionID, TaskDescription, RedirectURL, PatientID, AssignedTo, PatientVisitID, TaskStatusID, ModifiedBy, SpecialityID, RefernceID)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_Tasks_TaskActionID_AssignedTo_RoleID_PatientVisitID_TaskStatusID_CreatedBy')
CREATE NONCLUSTERED INDEX NC_Tasks_TaskActionID_AssignedTo_RoleID_PatientVisitID_TaskStatusID_CreatedBy ON Tasks(TaskActionID, AssignedTo, RoleID, PatientVisitID, TaskStatusID, CreatedBy)
GO
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_TaxBillDetails_BillID')
CREATE NONCLUSTERED INDEX NC_TaxBillDetails_BillID ON TaxBillDetails(BillID)

-- Added on 06 Aug 2012 for KMH Perf tuning begins

/*---------------- The below covering index is for general select on BillingDetails table -----------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_OrgID_FinalBillID_BillingDetailsID')
CREATE NONCLUSTERED INDEX NC_BillingDetails_OrgID_FinalBillID_BillingDetailsID ON BillingDetails (OrgID, FinalBillID, BillingDetailsID)
Include(FeeDescription, Amount, CreatedBy, ModifiedBy, ModifiedAt, ItemType, Quantity, Rate, Status, IsCreditBill, BatchNo, ExpiryDate, FromDate, 
ToDate, AttributeDetail, ReceiptNO, DiscountAmount, IsReimbursable, RefPhysicianID, RefPhyName, IsTaxable, ServiceCode, ReferenceType, Perphyname, PerphyID, ReturnQuantity, SourceType, SourceTypeID, BilledDate, DiscOrEnhanceType, Remarks, RoomTypeID, DiscountPercent, kitid, LabNo, TaxPercent, ProductKey)
/*-----------------------------------------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_FinalBill_OrgID_VisitID')
CREATE NONCLUSTERED INDEX NC_FinalBill_OrgID_VisitID ON FinalBill (OrgID, VisitID) Include (FinalBillID, PatientID, IsCreditBill)

/*---------------- The below covering index is for general select on PatientDueChart table -----------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_PatientDueChart_OrgID_VisitID')
CREATE NONCLUSTERED INDEX NC_PatientDueChart_OrgID_VisitID ON PatientDueChart (VisitID, OrgID)
Include (DetailsID,PatientID,FeeType,FeeID,[Description],Comments,FromDate,ToDate,[Status],unit,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,
Amount,PackageID,BatchNo,ExpiryDate,AttributeDetail,IsReimbursable,RefPhysicianID,RefPhyName,IsTaxable,ServiceCode,ReferenceType,InterimBillNo,PerphyName,
PerPhysicianID,DiscountAmount,ReturnQuantity,DiscOrEnhanceType,Remarks,RoomTypeID,DiscountPercent,kitid,LabNo,TaxPercent,ProductKey,VersionNo,
ReimbursableAmount,NonReimbursableAmount,RoleID,DeptID,LocationID,ActualAmount)

-- Added on 06 Aug 2012 for KMH Perf tuning ends
IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'NC_BillingDetails_OrgID_BilledDate')
CREATE NONCLUSTERED INDEX [NC_BillingDetails_OrgID_BilledDate]
ON [dbo].[BillingDetails] ([OrgID],[BilledDate])
INCLUDE ([BillingDetailsID],[FinalBillID],[PharmacyBillNo])

IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'IDX_WorkListMaster_Worklistid')
Create Nonclustered index IDX_WorkListMaster_Worklistid on WorkListmaster (Worklistid)
GO

IF NOT EXISTS (SELECT 1 FROM sys.sysindexes WHERE name = 'IDX_WorklistDetail_WMID')
Create Nonclustered INDEX IDX_WorklistDetail_WMID on WorklistDetail (WMID) include (Patientinvid)
GO