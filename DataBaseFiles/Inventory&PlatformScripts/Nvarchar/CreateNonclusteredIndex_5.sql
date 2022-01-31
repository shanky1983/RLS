CREATE NONCLUSTERED INDEX [NC_ActionRoleMapping_RoleID_SearchTypeID] ON [dbo].[ActionRoleMapping](RoleID ASC, SearchTypeID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_AdditionalVisitDetails_visitid] ON [dbo].[AdditionalVisitDetails](PatientVisitID ASC) INCLUDE (PhlebetomyID, LogisticsID, RoundNo, Exautoauthorization, ZoneID, ApprovalNo);
 
CREATE NONCLUSTERED INDEX [NC_AddressDetails_ReferenceID] ON [dbo].[AddressDetails](ReferenceID ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_AmountRefundDetails_BillingDetailsID_OrgID_BillStatus] ON [dbo].[AmountRefundDetails](BillingDetailsID ASC, OrgID ASC, BillStatus ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_BarcodePrintJob_MachineID_status] ON [dbo].[BarcodePrintJob](MachineID ASC, Status ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_BarcodePrintJob_status_org_add_machine_ID] ON [dbo].[BarcodePrintJob](OrgID ASC, OrgAddressID ASC, MachineID ASC, ID ASC) INCLUDE (VisitID, SampleID, BarcodeNumber, HeaderLine1, HeaderLine2, FooterLine1, FooterLine2);
 
CREATE NONCLUSTERED INDEX [IDX_BidirectionalBarCodeDetails_DeviceID] ON [dbo].[BidirectionalBarCodeDetails](DeviceID ASC) INCLUDE (PatientInvID);
 
CREATE NONCLUSTERED INDEX [IDX_Billingdetails_Feeid_Billedate] ON [dbo].[BillingDetails](FeeId ASC, BilledDate ASC) INCLUDE (FinalBillID, Amount, Quantity, OrgID);
 
CREATE NONCLUSTERED INDEX [IDX_BillingDetails_Feeid_Feetype_Labno] ON [dbo].[BillingDetails](FeeId ASC, FeeType ASC, LabNo ASC) INCLUDE (FinalBillID, IsSTAT, TatDateTime);
 
CREATE NONCLUSTERED INDEX [IDX_Billingdetails_Locationid_Feetype] ON [dbo].[BillingDetails](LocationID ASC, FeeType ASC) INCLUDE (FinalBillID, FeeId);
 
CREATE NONCLUSTERED INDEX [IDX_Billingdetails_Orgid] ON [dbo].[BillingDetails](OrgID ASC) INCLUDE (FinalBillID, FeeId, FeeType, ActualAmount);
 
CREATE NONCLUSTERED INDEX [IDX_Billingdetails_Orgid_Billeddate] ON [dbo].[BillingDetails](OrgID ASC, BilledDate ASC) INCLUDE (FinalBillID, FeeId, Amount, Quantity);
 
CREATE NONCLUSTERED INDEX [IDX_Billingdetails_Orgid_Feetype_finalbillid_Feeid] ON [dbo].[BillingDetails](OrgID ASC, FeeType ASC, FinalBillID ASC, FeeId ASC) INCLUDE (ActualAmount, Amount, Quantity);
 
CREATE NONCLUSTERED INDEX [IDX_Billlingdetails_Finalbillid_Orgid_Billeddate] ON [dbo].[BillingDetails](FinalBillID ASC, OrgID ASC, BilledDate ASC) INCLUDE (FeeId, Amount, Quantity);
 
CREATE NONCLUSTERED INDEX [PK_ClientAttributesDetails_ClientID_OrgID] ON [dbo].[ClientAttributesDetails](ClientID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_ClientMaster_ClientCode_Orgid] ON [dbo].[ClientMaster](ClientCode ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_ClientMaster_Orgid] ON [dbo].[ClientMaster](OrgID ASC) INCLUDE (ClientID, ClientName, OrgAddressID, ClientTypeID);
 
CREATE NONCLUSTERED INDEX [PK_ClientMaster_ClientID_OrgID] ON [dbo].[ClientMaster](ClientID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Codemapperr_Identifyingtype_Identifyingid] ON [dbo].[CodeMapper](IdentifyingType ASC, IdentifyingID ASC) INCLUDE (CodeMasterID);
 
CREATE NONCLUSTERED INDEX [IDX_CodeMaster_CodeSchemeID_CodeType] ON [dbo].[CodeMaster](CodeSchemeID ASC, CodeType ASC) INCLUDE (CodeMasterID, CodeName);
 
CREATE NONCLUSTERED INDEX [NIDX_CodeMaSTER_CodeMasterID_CodeType] ON [dbo].[CodeMaster](CodeMasterID ASC, CodeType ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_ConfigKeyMaster_ConfigKeyID_ConfigKey] ON [dbo].[ConfigKeyMaster](ConfigKeyID ASC) INCLUDE (ConfigKey);
 
CREATE NONCLUSTERED INDEX [NC_ConfigOrgMaster_OrgID] ON [dbo].[ConfigOrgMaster](OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_ConfigOrgMaster_OrgID_ConfigKeyID] ON [dbo].[ConfigOrgMaster](ConfigKeyID ASC, OrgID ASC) INCLUDE (ConfigValue);
 
CREATE CLUSTERED INDEX [C_CurrencyMaster] ON [dbo].[CurrencyMaster](CurrencyID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_DeviceIntegrationOrgMapping_Instrumentid] ON [dbo].[DeviceIntegrationOrgMapping](InstrumentID ASC) INCLUDE (DeviceID, InvestigationID, OrgID);
 
CREATE NONCLUSTERED INDEX [IDX_DeviceIntegrationOrgMapping_Orgid] ON [dbo].[DeviceIntegrationOrgMapping](OrgID ASC) INCLUDE (DeviceID, InvestigationID, InstrumentID);
 
CREATE NONCLUSTERED INDEX [IDX_DeviceIntegrationOrgMapping_OrgID_Investigationid_Instrumentid] ON [dbo].[DeviceIntegrationOrgMapping](OrgID ASC, InvestigationID ASC, InstrumentID ASC) ;
 
CREATE CLUSTERED INDEX [pk_DuePaidDetail] ON [dbo].[DuePaidDetail](DueBillNo ASC, PaidAmount ASC, PaidDate ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_FinalBill_OrgID_FinalBillID] ON [dbo].[FinalBill](OrgID ASC, FinalBillID ASC) INCLUDE (VisitID, PatientID, DiscountAmount, Due, IsCreditBill, OrgAddressID, TaxAmount, BillNumber, ServiceCharge, RoundOff, EDCess, SHEDCess);
 
CREATE NONCLUSTERED INDEX [IDX_Finalbill_Orgid_RefFinalBillID_Createdat] ON [dbo].[FinalBill](OrgID ASC, RefFinalBillID ASC, CreatedAt ASC) INCLUDE (FinalBillID, VisitID);
 
CREATE NONCLUSTERED INDEX [IDX_Finalbill_Reffinalbillid_Createdat] ON [dbo].[FinalBill](RefFinalBillID ASC, CreatedAt ASC) INCLUDE (FinalBillID, VisitID);
 
CREATE NONCLUSTERED INDEX [IDX_FinalBill_Visitid] ON [dbo].[FinalBill](VisitID ASC) INCLUDE (BillNumber);
 
CREATE NONCLUSTERED INDEX [IDX_FinalBill_VisitID_OrgID] ON [dbo].[FinalBill](VisitID ASC, OrgID ASC) INCLUDE (FinalBillID);
 
CREATE NONCLUSTERED INDEX [PK_FinalBill_PatientID_VisitID_OrgID] ON [dbo].[FinalBill](PatientID ASC, VisitID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_IDPatternMaster_Categoryid_Orgid_orgaddressid] ON [dbo].[IDPatternMaster](CategoryID ASC, OrgID ASC, OrgAddressID ASC) INCLUDE (LastGeneratedNumber);
 
CREATE NONCLUSTERED INDEX [IDX_InvClientMaster_Clientid_Orgid] ON [dbo].[InvClientMaster](ClientID ASC, OrgID ASC) INCLUDE (RateId);
 
CREATE NONCLUSTERED INDEX [IDX_invclientmaster_orgid_ActiveYN] ON [dbo].[InvClientMaster](OrgID ASC, ActiveYN ASC) INCLUDE (ClientID, ClientTypeID, RateId, ValidFrom, ValidTo, Priority, ClientMappingDetailsID);
 
CREATE NONCLUSTERED INDEX [IDX_InvDeptMaster_OrgID_DeptID] ON [dbo].[InvDeptMaster](OrgID ASC, DeptID ASC) INCLUDE (Invdeptid, DeptName);
 
CREATE NONCLUSTERED INDEX [NC_InvDeptSamples_PatientVisitID_OrgID] ON [dbo].[InvDeptSamples](PatientVisitID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationAttributesDetails_PatientInvId] ON [dbo].[InvestigationAttributesDetails](PatientInvId ASC) ;
 
CREATE NONCLUSTERED INDEX [NCIDX_InvestigationOrgAttributes_InvID_Orgid_HasHistory] ON [dbo].[InvestigationOrgAttributes](InvestigationID ASC, OrgID ASC, HasHistory ASC) INCLUDE (Classification);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationOrgMapping_deptid] ON [dbo].[InvestigationOrgMapping](DeptID ASC) INCLUDE (InvestigationID, OrgID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationOrgMapping_InvestigationID_OrgID] ON [dbo].[InvestigationOrgMapping](InvestigationID ASC, OrgID ASC) INCLUDE (DeptID, UOMID, UOMCode, InvValidationText, AutoApproveLoginID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationOrgMapping_OrgID] ON [dbo].[InvestigationOrgMapping](OrgID ASC) INCLUDE (InvestigationID, DisplayText, DeptID, HeaderID, ProtocalGroupID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationOrgMapping_Orgid_Investigationid] ON [dbo].[InvestigationOrgMapping](OrgID ASC, InvestigationID ASC) INCLUDE (DisplayText);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationPattern_Orgid_patternid] ON [dbo].[InvestigationPattern](OrgID ASC, PatternID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationQueue_accessno_visitid] ON [dbo].[InvestigationQueue](AccessionNumber ASC, VisitID ASC) INCLUDE (OrderedUID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationQueue_invid_accessno] ON [dbo].[InvestigationQueue](InvestigationID ASC, AccessionNumber ASC) INCLUDE (OrderedUID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationQueue_Orgid_Type_Status_Createdat] ON [dbo].[InvestigationQueue](OrgID ASC, Type ASC, Status ASC, CreatedAt ASC) INCLUDE (VisitID, InvestigationID, OrderedUID, AccessionNumber);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationQueue_Type] ON [dbo].[InvestigationQueue](Type ASC) INCLUDE (InvestigationID, AccessionNumber, OrderedUID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationQueue_Visitid_Type_InvestigationId] ON [dbo].[InvestigationQueue](VisitID ASC, Type ASC, InvestigationID ASC) INCLUDE (AccessionNumber, OrderedUID);
 
CREATE NONCLUSTERED INDEX [PK_InvestigationValueHistory_PatientVisitID_Orgid] ON [dbo].[InvestigationValueHistory](PatientVisitID ASC, Orgid ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_InvestigationValueHistory_PatientVisitID_Orgid_InvID] ON [dbo].[InvestigationValueHistory](PatientVisitID ASC, Orgid ASC, InvestigationID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationValues_InvestigationID_GroupID_packageid_PatientVisitID_Orgid] ON [dbo].[InvestigationValues](InvestigationID ASC, GroupID ASC, PackageID ASC, PatientVisitID ASC, Orgid ASC) INCLUDE (InvestigationValueID, Name, Value, UOMCode, GroupName, SequenceNo, UID);
 
CREATE NONCLUSTERED INDEX [IDX_InvestigationValues_Orgid_CreatedAt] ON [dbo].[InvestigationValues](Orgid ASC, CreatedAt ASC) INCLUDE (PatientVisitID, UID, InvestigationID, GroupID, DeviceID);
 
CREATE NONCLUSTERED INDEX [NC_InvestigationValues_InvestigationID] ON [dbo].[InvestigationValues](InvestigationID ASC) INCLUDE (Value);
 
CREATE NONCLUSTERED INDEX [NC_InvestigationValues_InvestigationID_GroupID_PatientVisitID_Orgid] ON [dbo].[InvestigationValues](InvestigationID ASC, GroupID ASC, PatientVisitID ASC, Orgid ASC) INCLUDE (InvestigationValueID, Name, Value, UOMCode, GroupName, SequenceNo, UID);
 
CREATE NONCLUSTERED INDEX [NC_InvestigationValues_PatientVisitID_Orgid_PackageID] ON [dbo].[InvestigationValues](PatientVisitID ASC, Orgid ASC, PackageID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_InvestigationValues_PatientVisitID_Orgid_PackageID_UID] ON [dbo].[InvestigationValues](PatientVisitID ASC, Orgid ASC, PackageID ASC, UID ASC) INCLUDE (InvestigationValueID, Name, Value, InvestigationID, GroupID, UOMCode, GroupName, SequenceNo);
 
CREATE NONCLUSTERED INDEX [IDX_InvGroupMapMaster_Groupid_Parent] ON [dbo].[InvGroupMapMaster](GroupID ASC, Parent ASC) INCLUDE (InvestigationID);
 
CREATE NONCLUSTERED INDEX [NC_InvGroupMapMaster_InvestigationID] ON [dbo].[InvGroupMapMaster](InvestigationID ASC) INCLUDE (GroupID);
 
CREATE NONCLUSTERED INDEX [NC_InvGroupMapMaster_Parent] ON [dbo].[InvGroupMapMaster](Parent ASC) INCLUDE (GroupID, InvestigationID);
 
CREATE NONCLUSTERED INDEX [IDX_InvoiceDetails_Createdat] ON [dbo].[InvoiceDetails](CreatedAt ASC) INCLUDE (FinalBillID);
 
CREATE NONCLUSTERED INDEX [PK_InvoiceDetails_InvoiceID_Status] ON [dbo].[InvoiceDetails](InvoiceID ASC, Status ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_InvoiceSnapshot_Invoiceid_Seq_Num_Type] ON [dbo].[InvoiceSnapshot](InvoiceID ASC, Seq_Num ASC, Type ASC) INCLUDE (InvoicePath);
 
CREATE NONCLUSTERED INDEX [IDX_InvoiceSnapshot_Seq_Num] ON [dbo].[InvoiceSnapshot](Seq_Num ASC) INCLUDE (InvoiceID, InvoicePath);
 
CREATE NONCLUSTERED INDEX [PK_InvoiceSnapshot_NotID_type] ON [dbo].[InvoiceSnapshot](NotificationID ASC, Type ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_InvOrgGroup_OrgID] ON [dbo].[InvOrgGroup](OrgID ASC) INCLUDE (AttGroupID, OrgGroupID, DisplayText, IsNonOrderable, Status, Gender, ProtocalGroupID);
 
CREATE NONCLUSTERED INDEX [NC_InvOrgGroup_AttGroupID, OrgID] ON [dbo].[InvOrgGroup](AttGroupID ASC, OrgID ASC) INCLUDE (OrgGroupID);
 
CREATE NONCLUSTERED INDEX [NC_InvOrgGroup_OrgGroupID, OrgID] ON [dbo].[InvOrgGroup](OrgGroupID ASC, OrgID ASC) INCLUDE (AttGroupID);
 
CREATE NONCLUSTERED INDEX [IDX_InvOrgReferenceMapping_InvestigationID_ClientID] ON [dbo].[InvOrgReferenceMapping](InvestigationID ASC, ClientID ASC) INCLUDE (ReferenceRange);
 
CREATE NONCLUSTERED INDEX [iDX_invratemaster_Ratetypeid_id_Rateid] ON [dbo].[InvRateMaster](Type ASC, ID ASC, RateID ASC, RateRefID ASC) INCLUDE (Rate, IPAmount);
 
CREATE NONCLUSTERED INDEX [NC_InvRateMaster_Type] ON [dbo].[InvRateMaster](Type ASC) INCLUDE (ID, RateID, Rate);
 
CREATE NONCLUSTERED INDEX [NC_InvRateMaster_Type_ID_RateID] ON [dbo].[InvRateMaster](Type ASC, ID ASC, RateID ASC) INCLUDE (IPAmount);
 
CREATE NONCLUSTERED INDEX [NC_InvRateMaster_Type_RateID] ON [dbo].[InvRateMaster](Type ASC, RateID ASC) INCLUDE (ID, Rate);
 
CREATE NONCLUSTERED INDEX [NC_KitPrepMasterDetails_KitID_LocationID] ON [dbo].[KitPrepMasterDetails](KitID ASC, LocationID ASC) INCLUDE (Quantity, SellingPrice);
 
CREATE NONCLUSTERED INDEX [NC_KitPrepMasterDetails_KitID_LocationID_IsReimbursable] ON [dbo].[KitPrepMasterDetails](KitID ASC, LocationID ASC, IsReimbursable ASC) INCLUDE (Quantity, SellingPrice);
 
CREATE NONCLUSTERED INDEX [NC_KitPrepMasterDetails_LocationID] ON [dbo].[KitPrepMasterDetails](LocationID ASC) INCLUDE (KitID, Quantity, SellingPrice);
 
CREATE NONCLUSTERED INDEX [NC_KitPrepMasterDetails_LocationID_IsReimbursable] ON [dbo].[KitPrepMasterDetails](LocationID ASC, IsReimbursable ASC) INCLUDE (KitID, Quantity, SellingPrice);
 
CREATE NONCLUSTERED INDEX [NIDX_LabPrintHistPageMode] ON [dbo].[LabPrintHistory](PageMode ASC) INCLUDE (PatientVisitID, ID);
 
CREATE NONCLUSTERED INDEX [PK_Localities_Locality_ID_Type_OrgID] ON [dbo].[Localities](Locality_ID ASC, Type ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_LoggedInProfile_orgid_crdate] ON [dbo].[LoggedInProfile](OrgID ASC, CreatedAt ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Loggedinusers_Loginid] ON [dbo].[LoggedInUsers](LoginID ASC) INCLUDE (RoleID, DeptID);
 
CREATE NONCLUSTERED INDEX [IDX_LoggedInUsers_Sessionid] ON [dbo].[LoggedInUsers](SessionID ASC) INCLUDE (ID);
 
CREATE NONCLUSTERED INDEX [NC_Login_LoginName_Password_IsLocked_Status] ON [dbo].[Login](LoginName ASC, Password ASC, IsLocked ASC, Status ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_LoginDeptMap_RoleDetpID_loginID] ON [dbo].[LoginDeptMap](RoleDetpID ASC, loginID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_ActionType_Category_Status] ON [dbo].[Notifications](ActionType ASC, Category ASC, Status ASC) INCLUDE (IdentityID, CompletionTime, AttachmentName, Subject, AdditionalContext);
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_ActionType_Status_Seq_Num] ON [dbo].[Notifications](ActionType ASC, Status ASC, Seq_Num ASC) INCLUDE (AdditionalContext);
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_ActionType_Status_Seq_Num2] ON [dbo].[Notifications](OrgAddressID ASC, ActionType ASC, Status ASC, Seq_Num ASC) INCLUDE (AdditionalContext, Category, OrgID, Template, ContextType, IsAttachment, Subject, Priority, AttachmentName, IdentityID, Value);
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_ActionType_Value_Status] ON [dbo].[Notifications](ActionType ASC, Value ASC, Status ASC) INCLUDE (NotificationID, AdditionalContext, Category, OrgID, OrgAddressID, Template, ContextType, IsAttachment, Subject, Seq_Num, RetryCount, Priority);
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_Category_Orgid_AdditionalContext_status] ON [dbo].[Notifications](Category ASC, OrgID ASC, AdditionalContext ASC, Status ASC) INCLUDE (Subject, AttachmentName, IdentityID);
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_IdentityID] ON [dbo].[Notifications](IdentityID ASC) INCLUDE (CompletionTime);
 
CREATE NONCLUSTERED INDEX [IDX_Notifications_seq_num] ON [dbo].[Notifications](Seq_Num ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_Notifications_IdID_Cat_AcType_Status_OrgID] ON [dbo].[Notifications](IdentityID ASC, Category ASC, ActionType ASC, Status ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_orderedinvestigation_rescaploc] ON [dbo].[OrderedInvestigations](ResCaptureLoc ASC) INCLUDE (AccessionNumber, OrgID, UID);
 
CREATE NONCLUSTERED INDEX [IDX_orderedInvestigations_Orgid_invid] ON [dbo].[OrderedInvestigations](OrgID ASC, ID ASC) INCLUDE (VisitID, AccessionNumber, UID, CreatedAt, ResCaptureLoc, LabNo);
 
CREATE NONCLUSTERED INDEX [IDX_OrderedInvestigations_Orgid_status_refaccess] ON [dbo].[OrderedInvestigations](OrgID ASC, Status ASC, ReferredAccessionNo ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_OrderedInvestigations_ReferredAccessionNo] ON [dbo].[OrderedInvestigations](ReferredAccessionNo ASC) INCLUDE (AccessionNumber);
 
CREATE NONCLUSTERED INDEX [IDX_OrderedInvestigations_Status] ON [dbo].[OrderedInvestigations](Status ASC) INCLUDE (AccessionNumber, ID, Type, OrgID);
 
CREATE NONCLUSTERED INDEX [IDX_Orderedinvestigations_Type_Orgid_status_ReferredType] ON [dbo].[OrderedInvestigations](Type ASC, OrgID ASC, Status ASC, ReferredType ASC) INCLUDE (VisitID, ID, PkgID);
 
CREATE NONCLUSTERED INDEX [IDX_OrderedInvestigations_Type_OrgID_Status_ReferredType2] ON [dbo].[OrderedInvestigations](Type ASC, OrgID ASC, Status ASC, ReferredType ASC) INCLUDE (VisitID, ID, PkgID, AccessionNumber, CreatedAt, LabNo, ResCaptureLoc, ReferralID);
 
CREATE NONCLUSTERED INDEX [IDX_OrderedInvestigations_VisitID_OrgID] ON [dbo].[OrderedInvestigations](VisitID ASC, OrgID ASC) INCLUDE (ID, Name, Type, Status, CreatedBy, ModifiedBy, UID, ResCaptureLoc, IsStat, PkgID);
 
CREATE NONCLUSTERED INDEX [IDX_Orderedinvestigations_Visitid_Referedtype_ReferredAccessionNo] ON [dbo].[OrderedInvestigations](VisitID ASC, ReferredType ASC, ReferredAccessionNo ASC) INCLUDE (Status, ID, UID, Type);
 
CREATE NONCLUSTERED INDEX [IDX_OrderedInvestigations_Visitid_UID_Orgid] ON [dbo].[OrderedInvestigations](VisitID ASC, UID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_ID_Type_OrgID] ON [dbo].[OrderedInvestigations](ID ASC, Type ASC, OrgID ASC) INCLUDE (AccessionNumber);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_ID_Type_Status] ON [dbo].[OrderedInvestigations](ID ASC, Type ASC, Status ASC) INCLUDE (VisitID, CreatedAt, UID, ResCaptureLoc, LabNo);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_ResCaptureLoc_Status] ON [dbo].[OrderedInvestigations](ResCaptureLoc ASC, Status ASC) INCLUDE (VisitID);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_Type_CreatedAt] ON [dbo].[OrderedInvestigations](Type ASC, CreatedAt ASC) INCLUDE (VisitID, ID);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_Type_OrgID] ON [dbo].[OrderedInvestigations](Type ASC, OrgID ASC) INCLUDE (ID, AccessionNumber);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_Type_OrgID_Status] ON [dbo].[OrderedInvestigations](Type ASC, Status ASC, OrgID ASC) INCLUDE (VisitID, CreatedAt, UID, ResCaptureLoc, LabNo);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_Type_Status] ON [dbo].[OrderedInvestigations](Type ASC, Status ASC) INCLUDE (VisitID, ID, CreatedAt, UID, ResCaptureLoc, LabNo);
 
CREATE NONCLUSTERED INDEX [NC_OrderedInvestigations_VisitID_OrgID_LabNo] ON [dbo].[OrderedInvestigations](VisitID ASC, OrgID ASC, LabNo ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_OrderedInvestigations_VisitID_OrgID_AccNo_status] ON [dbo].[OrderedInvestigations](VisitID ASC, OrgID ASC, AccessionNumber ASC, Status ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_OrganizationSpeciality_OrganizationID] ON [dbo].[OrganizationSpeciality](OrganizationID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_OrgUOMVitalsMapping_OrgID] ON [dbo].[OrgUOMVitalsMapping](OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Patient_OrganizationID_PatientID] ON [dbo].[Patient](OrganizationID ASC, PatientID ASC) INCLUDE (Name, Age, PatientNumber, AgeValues);
 
CREATE NONCLUSTERED INDEX [IDX_Patient_HIST_Patientid_Orgid] ON [dbo].[Patient_HIST](PatientID ASC, OrganizationID ASC) INCLUDE (Patient_HISTID);
 
CREATE NONCLUSTERED INDEX [NC_PatientAddress_AddressType_MobileNumber] ON [dbo].[PatientAddress](AddressType ASC, MobileNumber ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_PatientAddress_PatientID_AddressType] ON [dbo].[PatientAddress](PatientID ASC, AddressType ASC) INCLUDE (Add1, Add2, Add3, CountryID, City, StateID, MobileNumber, LandLineNumber);
 
CREATE NONCLUSTERED INDEX [CI_patientDispatchdetails_visitid_orgid] ON [dbo].[PatientDisPatchDetails](VisitID ASC, OrgID ASC) INCLUDE (PatientID, DispatchType, DispatchValue);
 
CREATE NONCLUSTERED INDEX [IDX_PatientDisPatchDetails_DispatchType_Visitid] ON [dbo].[PatientDisPatchDetails](VisitID ASC) INCLUDE (DispatchValue);
 
CREATE NONCLUSTERED INDEX [IDX_PatientDisPatchDetails_Patientid_Orgid] ON [dbo].[PatientDisPatchDetails](PatientID ASC, OrgID ASC) INCLUDE (PatientDispatchID);
 
CREATE NONCLUSTERED INDEX [CI_patientDuedetails_Patientid] ON [dbo].[PatientDueDetails](PatientID ASC) INCLUDE (VisitID, DueAmount, DuePaidAmt, DiscountAmt, WriteOffAmt);
 
CREATE NONCLUSTERED INDEX [IDX_PatientDueDetails_ORgid_Visitid] ON [dbo].[PatientDueDetails](OrgID ASC, VisitID ASC) INCLUDE (DueAmount, DuePaidAmt, DiscountAmt);
 
CREATE NONCLUSTERED INDEX [PK_PatientDueDetails_FinalBillID_VisitID] ON [dbo].[PatientDueDetails](FinalBillID ASC, VisitID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_PatientHistoryExt_Visitid_patientid_Orgid] ON [dbo].[PatientHistoryExt](PatientVisitId ASC, PatientID ASC, OrganizationID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_patientinvestigation_Accessionno_orgid] ON [dbo].[PatientInvestigation](AccessionNumber ASC, OrgID ASC) INCLUDE (PatientVisitID, InvestigationID);
 
CREATE NONCLUSTERED INDEX [Idx_Patientinvestigation_Accessno_invid] ON [dbo].[PatientInvestigation](AccessionNumber ASC, InvestigationID ASC, PatientVisitID ASC, OrgID ASC) INCLUDE (SampleID, CollectedDateTime, Status, ComplaintId, GroupID, Reason, ReferenceRange, IPInvSampleCollectionMasterID, KitID, InstrumentID, Interpretation, PrincipleID, QCData, UID, IsAbnormal, GroupMedicalRemarks, WorkListID);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvestigation_InvestigationID_Status_OrgID] ON [dbo].[PatientInvestigation](InvestigationID ASC, Status ASC, OrgID ASC) INCLUDE (PatientInvID, AccessionNumber, PatientVisitID);
 
CREATE NONCLUSTERED INDEX [IDX_Patientinvestigation_Orgid] ON [dbo].[PatientInvestigation](OrgID ASC) INCLUDE (PatientVisitID, InvestigationID, InvestigationName, Status, AccessionNumber, WorkListID, statustype);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvestigation_Patientvisitid_status] ON [dbo].[PatientInvestigation](PatientVisitID ASC, Status ASC) INCLUDE (OrgID, UID, InvestigationID, GroupID, PackageID);
 
CREATE NONCLUSTERED INDEX [IDX_Patientinvestigation_Status_Orgid] ON [dbo].[PatientInvestigation](Status ASC, OrgID ASC) INCLUDE (PatientVisitID, InvestigationID, InvestigationName, AccessionNumber, WorkListID, statustype);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvestigation_Visitid] ON [dbo].[PatientInvestigation](PatientVisitID ASC) INCLUDE (UID, InvestigationID, SampleID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_AccessionNumber] ON [dbo].[PatientInvestigation](WorkListID ASC, AccessionNumber ASC, PatientVisitID ASC, InvestigationID ASC, OrgID ASC) INCLUDE (GroupID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_orgid_visit_status] ON [dbo].[PatientInvestigation](OrgID ASC, PatientVisitID ASC, Status ASC) INCLUDE (WorkListID, AccessionNumber, GroupID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_PatientVisitID_GroupID_OrgID] ON [dbo].[PatientInvestigation](PatientVisitID ASC, GroupID ASC, OrgID ASC) INCLUDE (InvestigationID, InvestigationName, GroupName, UID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_PatientVisitID_GroupID_OrgID_Status] ON [dbo].[PatientInvestigation](PatientVisitID ASC, Status ASC, GroupID ASC, OrgID ASC) INCLUDE (InvestigationID, InvestigationName);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_PatientVisitID_InvestigationID_OrgID] ON [dbo].[PatientInvestigation](PatientVisitID ASC, InvestigationID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_PatientVisitID_IsCompleted] ON [dbo].[PatientInvestigation](PatientVisitID ASC, IsCompleted ASC) INCLUDE (InvestigationID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_PatientVisitID_OrgID_PackageID] ON [dbo].[PatientInvestigation](PatientVisitID ASC, OrgID ASC, PackageID ASC) INCLUDE (InvestigationID, InvestigationName, GroupName);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvestigation_PatientVisitID_OrgID_PackageID_GroupID] ON [dbo].[PatientInvestigation](PatientVisitID ASC, GroupID ASC, OrgID ASC, PackageID ASC) ;
 
CREATE NONCLUSTERED INDEX [NCIDX_PatientInvestigation_Orgid_CreatedAt] ON [dbo].[PatientInvestigation](OrgID ASC, CreatedAt ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_PatientInvestigation_VisitID_OrgID_AccNo_status] ON [dbo].[PatientInvestigation](PatientVisitID ASC, OrgID ASC, AccessionNumber ASC, Status ASC) ;
 
CREATE NONCLUSTERED INDEX [idx_Nonclustered_PatientInvestigation_Hist_OrgID_PatientVisitID_Status] ON [dbo].[PatientInvestigation_Hist](OrgID ASC, PatientVisitID ASC, Status ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvestigation_Hist_Status_Orgid] ON [dbo].[PatientInvestigation_Hist](Status ASC, OrgID ASC) INCLUDE (PatientVisitID, ModifiedAt);
 
CREATE NONCLUSTERED INDEX [NC_patientinvestigationfiles_ImgSrc_FilePath] ON [dbo].[PatientInvestigationFiles](OrgID ASC, PatientVisitID ASC) INCLUDE (ImageSource, FilePath, ImageID, Description);
 
CREATE NONCLUSTERED INDEX [IDX_Patientinvsample_BarcodeNumber_Orgid] ON [dbo].[PatientInvSample](BarcodeNumber ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_patientinvsample_pickedby] ON [dbo].[PatientInvSample](Pickedby ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Patientinvsample_RecSampleLocID_CollectedLocID_recorgid] ON [dbo].[PatientInvSample](RecSampleLocID ASC, CollectedLocID ASC, recorgid ASC) INCLUDE (PatientVisitID, SampleID, UID, Pickedby);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvSample_Visitid_Uid_Sampleid] ON [dbo].[PatientInvSample](PatientVisitID ASC, UID ASC, SampleID ASC) INCLUDE (BarcodeNumber);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvSample_PatientVisitID_OrgID] ON [dbo].[PatientInvSample](PatientVisitID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_PatientInvSample_PatientVisitID_SampleID_OrgID] ON [dbo].[PatientInvSample](PatientVisitID ASC, SampleID ASC, OrgID ASC) INCLUDE (BarcodeNumber, SampleCode, SampleContainerID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvSample_RecSampleLocID_recorgid_CreatedAt] ON [dbo].[PatientInvSample](RecSampleLocID ASC, recorgid ASC, CreatedAt ASC) INCLUDE (PatientVisitID, CollectedLocID);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvSampleMapping_TYPE_Visitid] ON [dbo].[PatientInvSampleMapping](Type ASC, VisitID ASC) INCLUDE (UID, ID, SampleID);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvSampleMapping_Type_Visitid_ID] ON [dbo].[PatientInvSampleMapping](Type ASC, VisitID ASC, ID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvSampleMapping_Type_Visitid_INV] ON [dbo].[PatientInvSampleMapping](Type ASC, VisitID ASC) INCLUDE (UID, ID, SampleID);
 
CREATE NONCLUSTERED INDEX [IDX_PatientInvSampleMapping_VisitID_UID_ID_Type] ON [dbo].[PatientInvSampleMapping](VisitID ASC, UID ASC, ID ASC, Type ASC) INCLUDE (SID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvSampleMapping_VisitID_OrgID] ON [dbo].[PatientInvSampleMapping](VisitID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_PatientInvSampleMapping_VisitID_OrgID_SampleID] ON [dbo].[PatientInvSampleMapping](VisitID ASC, OrgID ASC, SampleID ASC) INCLUDE (DeptID);
 
CREATE NONCLUSTERED INDEX [NC_PatientInvSampleResults_OrgID_VisitID] ON [dbo].[PatientInvSampleResults](OrgID ASC, VisitID ASC) INCLUDE (SampleCode, AttributesID, SampleValues);
 
CREATE NONCLUSTERED INDEX [IDX_PatientVisit_OrganizationID_VisitDate] ON [dbo].[PatientVisit](OrganizationID ASC, VisitDate ASC) INCLUDE (PatientID, OrgAddressID, VisitType, CreatedAt, ExternalVisitID, VisitNumber, TodaysVisitNo, VisitPurposeID, ReferingPhysicianName, patientHistoryID);
 
CREATE NONCLUSTERED INDEX [IDX_PatientVisit_OrganizationID_VisitType] ON [dbo].[PatientVisit](OrganizationID ASC, VisitType ASC) INCLUDE (PatientVisitId, PatientID, VisitDate, PhysicianID, VisitPurposeID, AdmissionSuggested, ReferingPhysicianName, ExternalVisitID, OrgAddressID, WardNo, VisitNumber, IsSTAT);
 
CREATE NONCLUSTERED INDEX [IDX_PatientVisit_ReferVisitID] ON [dbo].[PatientVisit](ReferVisitID ASC) INCLUDE (PatientVisitId, OrganizationID);
 
CREATE NONCLUSTERED INDEX [IDX_PatientVisit_Visitdate_Orgid] ON [dbo].[PatientVisit](VisitDate ASC, OrganizationID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Patientvisit_VisitNumber] ON [dbo].[PatientVisit](VisitNumber ASC) INCLUDE (PatientVisitId);
 
CREATE NONCLUSTERED INDEX [IDX_PatientVisit_VisitType] ON [dbo].[PatientVisit](VisitType ASC) INCLUDE (PatientVisitId, OrganizationID, ReferingPhysicianID, ReferingPhysicianName, HospitalID, HospitalName);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_OrganizationID_PhysicianID_VisitType] ON [dbo].[PatientVisit](OrganizationID ASC, PhysicianID ASC, VisitType ASC) INCLUDE (PatientVisitId, PatientID, VisitDate, VisitPurposeID, AdmissionSuggested, ReferingPhysicianName, ExternalVisitID);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_OrganizationID_VisitState_DischargedDT] ON [dbo].[PatientVisit](OrganizationID ASC, VisitState ASC, DischargedDT ASC) INCLUDE (PatientVisitId, PatientID);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_OrganizationID_VisitType_VisitState] ON [dbo].[PatientVisit](OrganizationID ASC, VisitType ASC, VisitState ASC) INCLUDE (PatientVisitId, PatientID);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_OrgID_ExternalVisitID] ON [dbo].[PatientVisit](OrganizationID ASC, ExternalVisitID ASC) INCLUDE (PatientVisitId, CreatedAt, ModifiedAt);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_PatientID] ON [dbo].[PatientVisit](PatientID ASC) INCLUDE (PatientVisitId, VisitState);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_PatientID_SpecialityID] ON [dbo].[PatientVisit](PatientID ASC, SpecialityID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_SpecialityID] ON [dbo].[PatientVisit](SpecialityID ASC) INCLUDE (PatientID);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_VisitType] ON [dbo].[PatientVisit](VisitType ASC) INCLUDE (PatientVisitId, DischargedDT);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_VisitType_VisitDate] ON [dbo].[PatientVisit](VisitDate ASC, VisitType ASC) INCLUDE (PatientID, PhysicianID);
 
CREATE NONCLUSTERED INDEX [NC_PatientVisit_VisitType_VisitState_VisitDate] ON [dbo].[PatientVisit](VisitDate ASC, VisitType ASC, VisitState ASC) INCLUDE (PatientVisitId, PatientID, IsDayCare);
 
CREATE NONCLUSTERED INDEX [UQ_Patientvisit_VisitNumber] ON [dbo].[PatientVisit](VisitNumber ASC, OrganizationID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_PatternMapping_investigationid_patternid] ON [dbo].[PatternMapping](InvestigationID ASC, PatternID ASC) ;
 
CREATE CLUSTERED INDEX [pk_PaymentTypeID] ON [dbo].[PaymentType](PaymentTypeID ASC) ;
 
CREATE CLUSTERED INDEX [Pk_PhysicianOrg] ON [dbo].[PhysicianOrganization](PhysicianID ASC, OrganizationID ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_PRINTSnapshot_VisitID_NotID_OrgID] ON [dbo].[PrintSnapshot](VisitID ASC, NotificationID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_PRINTSnapshot_VisitID_NotID_OrgID_Seq_Num] ON [dbo].[PrintSnapshot](VisitID ASC, NotificationID ASC, OrgID ASC, Seq_Num ASC) ;
 
CREATE NONCLUSTERED INDEX [PK_PRINTSnapshot_VisitID_Seq_Num_Category_OrgID] ON [dbo].[PrintSnapshot](VisitID ASC, Seq_Num ASC, Category ASC, OrgID ASC) ;
 
CREATE CLUSTERED INDEX [pIDX_Products] ON [dbo].[Products](ProductID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_RateRefOrgMapping_Rate_orgid] ON [dbo].[RateRefOrgMapping](RateID ASC, OrgID ASC) INCLUDE (RateRefID, DiscountPolicyID);
 
CREATE NONCLUSTERED INDEX [IDX_ReferingPhysician_OrgID_IsActive_PhysicianName_ParentReferingPhysicianID] ON [dbo].[ReferingPhysician](OrgID ASC, IsActive ASC, PhysicianName ASC, ParentReferingPhysicianID ASC) INCLUDE (ReferingPhysicianID, Salutation, PhysicianCode, RegistrationType);
 
CREATE NONCLUSTERED INDEX [IDX_ReferingPhysician_Orgid_ParentReferingPhysicianID_ReferingPhysicianID] ON [dbo].[ReferingPhysician](OrgID ASC, ParentReferingPhysicianID ASC, ReferingPhysicianID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_ReferingPhysician_OrgID_Salutation_IsActive_PhysicianName_ParentReferingPhysicianID] ON [dbo].[ReferingPhysician](OrgID ASC, Salutation ASC, IsActive ASC, PhysicianName ASC, ParentReferingPhysicianID ASC) INCLUDE (ReferingPhysicianID, PhysicianCode, RegistrationType);
 
CREATE NONCLUSTERED INDEX [IDX_ReportBarcode_VisitID_OrgID] ON [dbo].[ReportBarcode](VisitID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_ReportPrintHistory_AccessionNumber_VisitID_OrgID_Type] ON [dbo].[ReportPrintHistory](AccessionNumber ASC, VisitID ASC, OrgID ASC, Type ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_ReportPrintHistory_VisitID_OrgID_Type] ON [dbo].[ReportPrintHistory](VisitID ASC, OrgID ASC, Type ASC) ;
 
CREATE NONCLUSTERED INDEX [nc_reportprinthistory_orgid_status_type] ON [dbo].[ReportPrintHistory](OrgID ASC, Status ASC, Type ASC) INCLUDE (VisitID);
 
CREATE NONCLUSTERED INDEX [IDX_ReportPublishing_OrgID] ON [dbo].[ReportPublishing](OrgID ASC) INCLUDE (ResultPublishID, PatientVisitID);
 
CREATE NONCLUSTERED INDEX [IDX_ReportPublishing_PatientVisitID_OrgID] ON [dbo].[ReportPublishing](PatientVisitID ASC, OrgID ASC) INCLUDE (ResultPublishID);
 
CREATE NONCLUSTERED INDEX [IDX_ReportSnapshot_TYPE] ON [dbo].[ReportSnapshot](Type ASC) INCLUDE (VisitID, Seq_Num);
 
CREATE NONCLUSTERED INDEX [PK_ReportSnapshot_VisitID_NotID_OrgID] ON [dbo].[ReportSnapshot](VisitID ASC, NotificationID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_RoleMenu_RoleID_IsMapped] ON [dbo].[RoleMenu](RoleID ASC, IsMapped ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_sampleTracker_Createdat] ON [dbo].[SampleTracker](CreatedAt ASC) INCLUDE (PatientVisitID, SampleID, InvSampleStatusID, SampleTrackerID);
 
CREATE NONCLUSTERED INDEX [IDX_SampleTracker_invsampleStatusid] ON [dbo].[SampleTracker](InvSampleStatusID ASC) INCLUDE (SampleID);
 
CREATE NONCLUSTERED INDEX [IDX_SampleTracker_InvSampleStatusID_OrgID] ON [dbo].[SampleTracker](OrgID ASC) INCLUDE (PatientVisitID, SampleID, CreatedAt);
 
CREATE NONCLUSTERED INDEX [IDX_SampleTracker_OrgID_InvSampleStatusID_CreatedAt_sampleid] ON [dbo].[SampleTracker](OrgID ASC, InvSampleStatusID ASC, CreatedAt ASC, SampleID ASC) INCLUDE (SampleTrackerID, Reason);
 
CREATE NONCLUSTERED INDEX [IDX_SampleTracker_Patientvisitid_Sampleid] ON [dbo].[SampleTracker](PatientVisitID ASC, SampleID ASC) INCLUDE (SampleTrackerID, OrgID);
 
CREATE NONCLUSTERED INDEX [IDX_SampleTracker_Sampletransferstatus] ON [dbo].[SampleTracker](SampleID ASC) INCLUDE (InvSampleStatusID);
 
CREATE NONCLUSTERED INDEX [IDX_SampleTracker_status_PatientVisitID] ON [dbo].[SampleTracker](PatientVisitID ASC) INCLUDE (OrgID, SampleID);
 
CREATE NONCLUSTERED INDEX [NC_SampleTracker_PatientVisitID_OrgID] ON [dbo].[SampleTracker](PatientVisitID ASC, OrgID ASC) ;
 
CREATE NONCLUSTERED INDEX [SampleTracker_PatientVisitID_InvSampleStatusID] ON [dbo].[SampleTracker](PatientVisitID ASC, InvSampleStatusID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_TaskActionMapping_OrgID_VisitPurposeID_OtherID] ON [dbo].[TaskActionMapping](OrgID ASC, VisitPurposeID ASC, OtherID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Tasks_ParentID_Status] ON [dbo].[Tasks](ParentID ASC, TaskStatusID ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Tasks_RoleID_OrgID_TaskDate] ON [dbo].[Tasks](RoleID ASC, OrgID ASC, TaskDate ASC) INCLUDE (TaskID, TaskActionID, TaskDescription, RedirectURL, PatientID, AssignedTo, PatientVisitID, TaskStatusID, HighlightColor, ModifiedBy, SpecialityID, RefernceID, Type, ShowedTime);
 
CREATE NONCLUSTERED INDEX [IDX_Tasks_TaskActionid_Patientvisitid] ON [dbo].[Tasks](TaskActionID ASC, PatientVisitID ASC) ;
 
CREATE NONCLUSTERED INDEX [NC_Tasks_RoleID_OrgID] ON [dbo].[Tasks](RoleID ASC, OrgID ASC) INCLUDE (TaskID, TaskActionID, TaskDescription, RedirectURL, TaskDate, PatientID, AssignedTo, PatientVisitID, TaskStatusID, HighlightColor, SpecialityID);
 
CREATE NONCLUSTERED INDEX [NC_Tasks_RoleID_OrgID_TaskDate] ON [dbo].[Tasks](TaskDate ASC, RoleID ASC, OrgID ASC) INCLUDE (TaskID, TaskActionID, TaskDescription, RedirectURL, PatientID, AssignedTo, PatientVisitID, TaskStatusID, ModifiedBy, SpecialityID, RefernceID);
 
CREATE NONCLUSTERED INDEX [NC_Tasks_TaskActionID_AssignedTo_RoleID_PatientVisitID_TaskStatusID_CreatedBy] ON [dbo].[Tasks](TaskActionID ASC, AssignedTo ASC, RoleID ASC, PatientVisitID ASC, TaskStatusID ASC, CreatedBy ASC) ;
 
CREATE NONCLUSTERED INDEX [IDX_Users_LoginID] ON [dbo].[Users](LoginID ASC) INCLUDE (Name);
 
CREATE NONCLUSTERED INDEX [IDX_VisitClientMapping_Orgid_Finalbillid] ON [dbo].[VisitClientMapping](OrgID ASC, FinalBillID ASC) INCLUDE (VisitID, ClientID, RateID);
 
CREATE NONCLUSTERED INDEX [IDX_VisitClientMapping_OrgID_VisitID_FinalBillID] ON [dbo].[VisitClientMapping](OrgID ASC, VisitID ASC, FinalBillID ASC) INCLUDE (ClientID, RateID);
 
CREATE NONCLUSTERED INDEX [IDX_VisitiClientMapping_Orgid] ON [dbo].[VisitClientMapping](OrgID ASC) INCLUDE (ClientID, FinalBillID, IsActive);
 
CREATE NONCLUSTERED INDEX [NI_VisitClientMapping_Visitid] ON [dbo].[VisitClientMapping](VisitID ASC, ClientID ASC) ;
 
