 DROP INDEX [dbo].[ActionRoleMapping].[NC_ActionRoleMapping_RoleID_SearchTypeID]
 DROP INDEX [dbo].[AdditionalVisitDetails].[IDX_AdditionalVisitDetails_visitid]
 DROP INDEX [dbo].[InvestigationOrgAttributes].[NCIDX_InvestigationOrgAttributes_InvID_Orgid_HasHistory]
 DROP INDEX [dbo].[AddressDetails].[NC_AddressDetails_ReferenceID]
 DROP INDEX [dbo].[SampleTracker].[IDX_sampleTracker_Createdat]
 DROP INDEX [dbo].[SampleTracker].[IDX_SampleTracker_invsampleStatusid]
 DROP INDEX [dbo].[SampleTracker].[IDX_SampleTracker_InvSampleStatusID_OrgID]
 DROP INDEX [dbo].[SampleTracker].[IDX_SampleTracker_OrgID_InvSampleStatusID_CreatedAt_sampleid]
 DROP INDEX [dbo].[SampleTracker].[IDX_SampleTracker_Patientvisitid_Sampleid]
 DROP INDEX [dbo].[SampleTracker].[IDX_SampleTracker_Sampletransferstatus]
 DROP INDEX [dbo].[SampleTracker].[IDX_SampleTracker_status_PatientVisitID]
 DROP INDEX [dbo].[SampleTracker].[NC_SampleTracker_PatientVisitID_OrgID]
 DROP INDEX [dbo].[SampleTracker].[SampleTracker_PatientVisitID_InvSampleStatusID]
 DROP INDEX [dbo].[CurrencyMaster].[C_CurrencyMaster]
 DROP INDEX [dbo].[PhysicianOrganization].[Pk_PhysicianOrg]
 DROP INDEX [dbo].[TaskActionMapping].[NC_TaskActionMapping_OrgID_VisitPurposeID_OtherID]
 DROP INDEX [dbo].[ReferingPhysician].[IDX_ReferingPhysician_OrgID_IsActive_PhysicianName_ParentReferingPhysicianID]
 DROP INDEX [dbo].[ReferingPhysician].[IDX_ReferingPhysician_Orgid_ParentReferingPhysicianID_ReferingPhysicianID]
 DROP INDEX [dbo].[ReferingPhysician].[IDX_ReferingPhysician_OrgID_Salutation_IsActive_PhysicianName_ParentReferingPhysicianID]
 DROP INDEX [dbo].[InvestigationOrgMapping].[IDX_InvestigationOrgMapping_deptid]
 DROP INDEX [dbo].[InvestigationOrgMapping].[IDX_InvestigationOrgMapping_InvestigationID_OrgID]
 DROP INDEX [dbo].[InvestigationOrgMapping].[IDX_InvestigationOrgMapping_OrgID]
 DROP INDEX [dbo].[InvestigationOrgMapping].[IDX_InvestigationOrgMapping_Orgid_Investigationid]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_ActionType_Category_Status]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_ActionType_Status_Seq_Num]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_ActionType_Status_Seq_Num2]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_ActionType_Value_Status]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_Category_Orgid_AdditionalContext_status]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_IdentityID]
 DROP INDEX [dbo].[Notifications].[IDX_Notifications_seq_num]
 DROP INDEX [dbo].[Notifications].[PK_Notifications_IdID_Cat_AcType_Status_OrgID]
 DROP INDEX [dbo].[InvestigationPattern].[IDX_InvestigationPattern_Orgid_patternid]
 DROP INDEX [dbo].[PatientDisPatchDetails].[CI_patientDispatchdetails_visitid_orgid]
 DROP INDEX [dbo].[PatientDisPatchDetails].[IDX_PatientDisPatchDetails_DispatchType_Visitid]
 DROP INDEX [dbo].[PatientDisPatchDetails].[IDX_PatientDisPatchDetails_Patientid_Orgid]
 DROP INDEX [dbo].[Tasks].[IDX_Tasks_ParentID_Status]
 DROP INDEX [dbo].[Tasks].[IDX_Tasks_RoleID_OrgID_TaskDate]
 DROP INDEX [dbo].[Tasks].[IDX_Tasks_TaskActionid_Patientvisitid]
 DROP INDEX [dbo].[Tasks].[NC_Tasks_RoleID_OrgID]
 DROP INDEX [dbo].[Tasks].[NC_Tasks_RoleID_OrgID_TaskDate]
 DROP INDEX [dbo].[Tasks].[NC_Tasks_TaskActionID_AssignedTo_RoleID_PatientVisitID_TaskStatusID_CreatedBy]
 DROP INDEX [dbo].[ClientAttributesDetails].[PK_ClientAttributesDetails_ClientID_OrgID]
 DROP INDEX [dbo].[InvestigationQueue].[IDX_InvestigationQueue_accessno_visitid]
 DROP INDEX [dbo].[InvestigationQueue].[IDX_InvestigationQueue_invid_accessno]
 DROP INDEX [dbo].[InvestigationQueue].[IDX_InvestigationQueue_Orgid_Type_Status_Createdat]
 DROP INDEX [dbo].[InvestigationQueue].[IDX_InvestigationQueue_Type]
 DROP INDEX [dbo].[InvestigationQueue].[IDX_InvestigationQueue_Visitid_Type_InvestigationId]
 DROP INDEX [dbo].[PatientDueDetails].[CI_patientDuedetails_Patientid]
 DROP INDEX [dbo].[PatientDueDetails].[IDX_PatientDueDetails_ORgid_Visitid]
 DROP INDEX [dbo].[PatientDueDetails].[PK_PatientDueDetails_FinalBillID_VisitID]
 DROP INDEX [dbo].[BarcodePrintJob].[IDX_BarcodePrintJob_MachineID_status]
 DROP INDEX [dbo].[BarcodePrintJob].[IDX_BarcodePrintJob_status_org_add_machine_ID]
 DROP INDEX [dbo].[ClientMaster].[IDX_ClientMaster_ClientCode_Orgid]
 DROP INDEX [dbo].[ClientMaster].[IDX_ClientMaster_Orgid]
 DROP INDEX [dbo].[ClientMaster].[PK_ClientMaster_ClientID_OrgID]
 DROP INDEX [dbo].[InvestigationValueHistory].[PK_InvestigationValueHistory_PatientVisitID_Orgid]
 DROP INDEX [dbo].[InvestigationValueHistory].[PK_InvestigationValueHistory_PatientVisitID_Orgid_InvID]
 DROP INDEX [dbo].[KitPrepMasterDetails].[NC_KitPrepMasterDetails_KitID_LocationID]
 DROP INDEX [dbo].[KitPrepMasterDetails].[NC_KitPrepMasterDetails_KitID_LocationID_IsReimbursable]
 DROP INDEX [dbo].[KitPrepMasterDetails].[NC_KitPrepMasterDetails_LocationID]
 DROP INDEX [dbo].[KitPrepMasterDetails].[NC_KitPrepMasterDetails_LocationID_IsReimbursable]
 DROP INDEX [dbo].[PrintSnapshot].[PK_PRINTSnapshot_VisitID_NotID_OrgID]
 DROP INDEX [dbo].[PrintSnapshot].[PK_PRINTSnapshot_VisitID_NotID_OrgID_Seq_Num]
 DROP INDEX [dbo].[PrintSnapshot].[PK_PRINTSnapshot_VisitID_Seq_Num_Category_OrgID]
 DROP INDEX [dbo].[InvestigationValues].[IDX_InvestigationValues_InvestigationID_GroupID_packageid_PatientVisitID_Orgid]
 DROP INDEX [dbo].[InvestigationValues].[IDX_InvestigationValues_Orgid_CreatedAt]
 DROP INDEX [dbo].[InvestigationValues].[NC_InvestigationValues_InvestigationID]
 DROP INDEX [dbo].[InvestigationValues].[NC_InvestigationValues_InvestigationID_GroupID_PatientVisitID_Orgid]
 DROP INDEX [dbo].[InvestigationValues].[NC_InvestigationValues_PatientVisitID_Orgid_PackageID]
 DROP INDEX [dbo].[InvestigationValues].[NC_InvestigationValues_PatientVisitID_Orgid_PackageID_UID]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_orderedinvestigation_rescaploc]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_orderedInvestigations_Orgid_invid]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_OrderedInvestigations_Orgid_status_refaccess]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_OrderedInvestigations_ReferredAccessionNo]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_OrderedInvestigations_Status]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_Orderedinvestigations_Type_Orgid_status_ReferredType]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_OrderedInvestigations_Type_OrgID_Status_ReferredType2]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_OrderedInvestigations_VisitID_OrgID]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_Orderedinvestigations_Visitid_Referedtype_ReferredAccessionNo]
 DROP INDEX [dbo].[OrderedInvestigations].[IDX_OrderedInvestigations_Visitid_UID_Orgid]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_ID_Type_OrgID]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_ID_Type_Status]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_ResCaptureLoc_Status]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_Type_CreatedAt]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_Type_OrgID]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_Type_OrgID_Status]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_Type_Status]
 DROP INDEX [dbo].[OrderedInvestigations].[NC_OrderedInvestigations_VisitID_OrgID_LabNo]
 DROP INDEX [dbo].[OrderedInvestigations].[PK_OrderedInvestigations_VisitID_OrgID_AccNo_status]
 DROP INDEX [dbo].[IDPatternMaster].[IDX_IDPatternMaster_Categoryid_Orgid_orgaddressid]
 DROP INDEX [dbo].[InvGroupMapMaster].[IDX_InvGroupMapMaster_Groupid_Parent]
 DROP INDEX [dbo].[InvGroupMapMaster].[NC_InvGroupMapMaster_InvestigationID]
 DROP INDEX [dbo].[InvGroupMapMaster].[NC_InvGroupMapMaster_Parent]
 DROP INDEX [dbo].[CodeMapper].[IDX_Codemapperr_Identifyingtype_Identifyingid]
 DROP INDEX [dbo].[PatientHistoryExt].[IDX_PatientHistoryExt_Visitid_patientid_Orgid]
 DROP INDEX [dbo].[CodeMaster].[IDX_CodeMaster_CodeSchemeID_CodeType]
 DROP INDEX [dbo].[CodeMaster].[NIDX_CodeMaSTER_CodeMasterID_CodeType]
 DROP INDEX [dbo].[DeviceIntegrationOrgMapping].[IDX_DeviceIntegrationOrgMapping_Instrumentid]
 DROP INDEX [dbo].[DeviceIntegrationOrgMapping].[IDX_DeviceIntegrationOrgMapping_Orgid]
 DROP INDEX [dbo].[DeviceIntegrationOrgMapping].[IDX_DeviceIntegrationOrgMapping_OrgID_Investigationid_Instrumentid]
 DROP INDEX [dbo].[BidirectionalBarCodeDetails].[IDX_BidirectionalBarCodeDetails_DeviceID]
 DROP INDEX [dbo].[ReportBarcode].[IDX_ReportBarcode_VisitID_OrgID]
 DROP INDEX [dbo].[LabPrintHistory].[NIDX_LabPrintHistPageMode]
 DROP INDEX [dbo].[AmountRefundDetails].[PK_AmountRefundDetails_BillingDetailsID_OrgID_BillStatus]
 DROP INDEX [dbo].[PatientInvestigation].[IDX_patientinvestigation_Accessionno_orgid]
 DROP INDEX [dbo].[PatientInvestigation].[Idx_Patientinvestigation_Accessno_invid]
 DROP INDEX [dbo].[PatientInvestigation].[IDX_PatientInvestigation_InvestigationID_Status_OrgID]
 DROP INDEX [dbo].[PatientInvestigation].[IDX_Patientinvestigation_Orgid]
 DROP INDEX [dbo].[PatientInvestigation].[IDX_PatientInvestigation_Patientvisitid_status]
 DROP INDEX [dbo].[PatientInvestigation].[IDX_Patientinvestigation_Status_Orgid]
 DROP INDEX [dbo].[PatientInvestigation].[IDX_PatientInvestigation_Visitid]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_AccessionNumber]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_orgid_visit_status]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_PatientVisitID_GroupID_OrgID]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_PatientVisitID_GroupID_OrgID_Status]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_PatientVisitID_InvestigationID_OrgID]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_PatientVisitID_IsCompleted]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_PatientVisitID_OrgID_PackageID]
 DROP INDEX [dbo].[PatientInvestigation].[NC_PatientInvestigation_PatientVisitID_OrgID_PackageID_GroupID]
 DROP INDEX [dbo].[PatientInvestigation].[NCIDX_PatientInvestigation_Orgid_CreatedAt]
 DROP INDEX [dbo].[PatientInvestigation].[PK_PatientInvestigation_VisitID_OrgID_AccNo_status]
 DROP INDEX [dbo].[PatientInvestigation_Hist].[idx_Nonclustered_PatientInvestigation_Hist_OrgID_PatientVisitID_Status]
 DROP INDEX [dbo].[PatientInvestigation_Hist].[IDX_PatientInvestigation_Hist_Status_Orgid]
 DROP INDEX [dbo].[BillingDetails].[IDX_Billingdetails_Feeid_Billedate]
 DROP INDEX [dbo].[BillingDetails].[IDX_BillingDetails_Feeid_Feetype_Labno]
 DROP INDEX [dbo].[BillingDetails].[IDX_Billingdetails_Locationid_Feetype]
 DROP INDEX [dbo].[BillingDetails].[IDX_Billingdetails_Orgid]
 DROP INDEX [dbo].[BillingDetails].[IDX_Billingdetails_Orgid_Billeddate]
 DROP INDEX [dbo].[BillingDetails].[IDX_Billingdetails_Orgid_Feetype_finalbillid_Feeid]
 DROP INDEX [dbo].[BillingDetails].[IDX_Billlingdetails_Finalbillid_Orgid_Billeddate]
 DROP INDEX [dbo].[PatientInvestigationFiles].[NC_patientinvestigationfiles_ImgSrc_FilePath]
 DROP INDEX [dbo].[Localities].[PK_Localities_Locality_ID_Type_OrgID]
 DROP INDEX [dbo].[Products].[pIDX_Products]
 DROP INDEX [dbo].[PatientInvSample].[IDX_Patientinvsample_BarcodeNumber_Orgid]
 DROP INDEX [dbo].[PatientInvSample].[IDX_patientinvsample_pickedby]
 DROP INDEX [dbo].[PatientInvSample].[IDX_Patientinvsample_RecSampleLocID_CollectedLocID_recorgid]
 DROP INDEX [dbo].[PatientInvSample].[IDX_PatientInvSample_Visitid_Uid_Sampleid]
 DROP INDEX [dbo].[PatientInvSample].[NC_PatientInvSample_PatientVisitID_OrgID]
 DROP INDEX [dbo].[PatientInvSample].[NC_PatientInvSample_PatientVisitID_SampleID_OrgID]
 DROP INDEX [dbo].[PatientInvSample].[NC_PatientInvSample_RecSampleLocID_recorgid_CreatedAt]
 DROP INDEX [dbo].[InvoiceDetails].[IDX_InvoiceDetails_Createdat]
 DROP INDEX [dbo].[InvoiceDetails].[PK_InvoiceDetails_InvoiceID_Status]
 DROP INDEX [dbo].[PatientInvSampleMapping].[IDX_PatientInvSampleMapping_TYPE_Visitid]
 DROP INDEX [dbo].[PatientInvSampleMapping].[IDX_PatientInvSampleMapping_Type_Visitid_ID]
 DROP INDEX [dbo].[PatientInvSampleMapping].[IDX_PatientInvSampleMapping_Type_Visitid_INV]
 DROP INDEX [dbo].[PatientInvSampleMapping].[IDX_PatientInvSampleMapping_VisitID_UID_ID_Type]
 DROP INDEX [dbo].[PatientInvSampleMapping].[NC_PatientInvSampleMapping_VisitID_OrgID]
 DROP INDEX [dbo].[PatientInvSampleMapping].[NC_PatientInvSampleMapping_VisitID_OrgID_SampleID]
 DROP INDEX [dbo].[OrganizationSpeciality].[NC_OrganizationSpeciality_OrganizationID]
 DROP INDEX [dbo].[ReportPrintHistory].[IDX_ReportPrintHistory_AccessionNumber_VisitID_OrgID_Type]
 DROP INDEX [dbo].[ReportPrintHistory].[IDX_ReportPrintHistory_VisitID_OrgID_Type]
 DROP INDEX [dbo].[ReportPrintHistory].[nc_reportprinthistory_orgid_status_type]
 DROP INDEX [dbo].[FinalBill].[IDX_FinalBill_OrgID_FinalBillID]
 DROP INDEX [dbo].[FinalBill].[IDX_Finalbill_Orgid_RefFinalBillID_Createdat]
 DROP INDEX [dbo].[FinalBill].[IDX_Finalbill_Reffinalbillid_Createdat]
 DROP INDEX [dbo].[FinalBill].[IDX_FinalBill_Visitid]
 DROP INDEX [dbo].[FinalBill].[IDX_FinalBill_VisitID_OrgID]
 DROP INDEX [dbo].[FinalBill].[PK_FinalBill_PatientID_VisitID_OrgID]
 DROP INDEX [dbo].[PatientInvSampleResults].[NC_PatientInvSampleResults_OrgID_VisitID]
 DROP INDEX [dbo].[ReportPublishing].[IDX_ReportPublishing_OrgID]
 DROP INDEX [dbo].[ReportPublishing].[IDX_ReportPublishing_PatientVisitID_OrgID]
 DROP INDEX [dbo].[LoggedInProfile].[IDX_LoggedInProfile_orgid_crdate]
 DROP INDEX [dbo].[InvoiceSnapshot].[IDX_InvoiceSnapshot_Invoiceid_Seq_Num_Type]
 DROP INDEX [dbo].[InvoiceSnapshot].[IDX_InvoiceSnapshot_Seq_Num]
 DROP INDEX [dbo].[InvoiceSnapshot].[PK_InvoiceSnapshot_NotID_type]
 DROP INDEX [dbo].[ReportSnapshot].[IDX_ReportSnapshot_TYPE]
 DROP INDEX [dbo].[ReportSnapshot].[PK_ReportSnapshot_VisitID_NotID_OrgID]
 DROP INDEX [dbo].[LoggedInUsers].[IDX_Loggedinusers_Loginid]
 DROP INDEX [dbo].[LoggedInUsers].[IDX_LoggedInUsers_Sessionid]
 DROP INDEX [dbo].[Login].[NC_Login_LoginName_Password_IsLocked_Status]
 DROP INDEX [dbo].[Users].[IDX_Users_LoginID]
 DROP INDEX [dbo].[InvOrgGroup].[IDX_InvOrgGroup_OrgID]
 DROP INDEX [dbo].[InvOrgGroup].[NC_InvOrgGroup_AttGroupID, OrgID]
 DROP INDEX [dbo].[InvOrgGroup].[NC_InvOrgGroup_OrgGroupID, OrgID]
 DROP INDEX [dbo].[LoginDeptMap].[IDX_LoginDeptMap_RoleDetpID_loginID]
 DROP INDEX [dbo].[ConfigKeyMaster].[NC_ConfigKeyMaster_ConfigKeyID_ConfigKey]
 DROP INDEX [dbo].[OrgUOMVitalsMapping].[NC_OrgUOMVitalsMapping_OrgID]
 DROP INDEX [dbo].[ConfigOrgMaster].[NC_ConfigOrgMaster_OrgID]
 DROP INDEX [dbo].[ConfigOrgMaster].[NC_ConfigOrgMaster_OrgID_ConfigKeyID]
 DROP INDEX [dbo].[RoleMenu].[NC_RoleMenu_RoleID_IsMapped]
 DROP INDEX [dbo].[InvOrgReferenceMapping].[IDX_InvOrgReferenceMapping_InvestigationID_ClientID]
 DROP INDEX [dbo].[VisitClientMapping].[IDX_VisitClientMapping_Orgid_Finalbillid]
 DROP INDEX [dbo].[VisitClientMapping].[IDX_VisitClientMapping_OrgID_VisitID_FinalBillID]
 DROP INDEX [dbo].[VisitClientMapping].[IDX_VisitiClientMapping_Orgid]
 DROP INDEX [dbo].[VisitClientMapping].[NI_VisitClientMapping_Visitid]
 DROP INDEX [dbo].[InvClientMaster].[IDX_InvClientMaster_Clientid_Orgid]
 DROP INDEX [dbo].[InvClientMaster].[IDX_invclientmaster_orgid_ActiveYN]
 DROP INDEX [dbo].[InvDeptMaster].[IDX_InvDeptMaster_OrgID_DeptID]
 DROP INDEX [dbo].[InvDeptSamples].[NC_InvDeptSamples_PatientVisitID_OrgID]
 DROP INDEX [dbo].[PatientVisit].[UQ_Patientvisit_VisitNumber]
 DROP INDEX [dbo].[PatientVisit].[IDX_PatientVisit_OrganizationID_VisitDate]
 DROP INDEX [dbo].[PatientVisit].[IDX_PatientVisit_OrganizationID_VisitType]
 DROP INDEX [dbo].[PatientVisit].[IDX_PatientVisit_ReferVisitID]
 DROP INDEX [dbo].[PatientVisit].[IDX_PatientVisit_Visitdate_Orgid]
 DROP INDEX [dbo].[PatientVisit].[IDX_Patientvisit_VisitNumber]
 DROP INDEX [dbo].[PatientVisit].[IDX_PatientVisit_VisitType]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_OrganizationID_PhysicianID_VisitType]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_OrganizationID_VisitState_DischargedDT]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_OrganizationID_VisitType_VisitState]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_OrgID_ExternalVisitID]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_PatientID]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_PatientID_SpecialityID]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_SpecialityID]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_VisitType]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_VisitType_VisitDate]
 DROP INDEX [dbo].[PatientVisit].[NC_PatientVisit_VisitType_VisitState_VisitDate]
 DROP INDEX [dbo].[InvRateMaster].[iDX_invratemaster_Ratetypeid_id_Rateid]
 DROP INDEX [dbo].[InvRateMaster].[NC_InvRateMaster_Type]
 DROP INDEX [dbo].[InvRateMaster].[NC_InvRateMaster_Type_ID_RateID]
 DROP INDEX [dbo].[InvRateMaster].[NC_InvRateMaster_Type_RateID]
 DROP INDEX [dbo].[InvestigationAttributesDetails].[IDX_InvestigationAttributesDetails_PatientInvId]
 DROP INDEX [dbo].[Patient].[IDX_Patient_OrganizationID_PatientID]
 DROP INDEX [dbo].[PatternMapping].[IDX_PatternMapping_investigationid_patternid]
 DROP INDEX [dbo].[Patient_HIST].[IDX_Patient_HIST_Patientid_Orgid]
 DROP INDEX [dbo].[RateRefOrgMapping].[IDX_RateRefOrgMapping_Rate_orgid]
 DROP INDEX [dbo].[PatientAddress].[NC_PatientAddress_AddressType_MobileNumber]
 DROP INDEX [dbo].[PatientAddress].[NC_PatientAddress_PatientID_AddressType]
 DROP INDEX [dbo].[DuePaidDetail].[pk_DuePaidDetail]
 DROP INDEX [dbo].[PaymentType].[pk_PaymentTypeID]
