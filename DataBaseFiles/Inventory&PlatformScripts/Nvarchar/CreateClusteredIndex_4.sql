ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF_PatientDueChart_Amount] DEFAULT ((0)) FOR [Amount]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__TranC__009FF5AC] DEFAULT ((0)) FOR [TranCurrencyID]

ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__IsRei__015F0FBB] DEFAULT ('Y') FOR [IsReimbursable]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__BaseC__019419E5] DEFAULT ((0)) FOR [BaseCurrencyID]

ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__Produ__025333F4] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__TranC__02883E1E] DEFAULT ((0)) FOR [TranCurrencyAmount]

ALTER TABLE [ActionMaster]WITH NOCHECK ADD CONSTRAINT [DF__ActionMas__IsSha__02BD4848] DEFAULT ('N') FOR [IsShareable]

ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__IsDis__0347582D] DEFAULT ('Y') FOR [IsDiscountable]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Payme__037C6257] DEFAULT ((0)) FOR [PaymentTypeID]

ALTER TABLE [Ambulance]WITH NOCHECK ADD CONSTRAINT [DF_ambulance_status] DEFAULT ('A') FOR [Status]

ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__IsSTA__043B7C66] DEFAULT ('N') FOR [IsSTAT]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Payme__04708690] DEFAULT ('') FOR [PaymentDetail]

ALTER TABLE [AmountApprovalDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountApp__Appro__04A590BA] DEFAULT (N'Pending') FOR [ApprovalStatus]

ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__IsOut__052FA09F] DEFAULT ('N') FOR [IsOutSource]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Recei__0564AAC9] DEFAULT ('') FOR [ReceiptNo]

ALTER TABLE [AmountClosureDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountClo__Pendi__0599B4F3] DEFAULT ((0)) FOR [PendingSettlementAmt]

ALTER TABLE [PatientDueChart]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__IsNAB__0623C4D8] DEFAULT ('N') FOR [IsNABL]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Chequ__0658CF02] DEFAULT ((0)) FOR [ChequeNo]

ALTER TABLE [AmountClosureDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountClo__Amoun__068DD92C] DEFAULT ('Pending') FOR [AmountClosureStatus]

ALTER TABLE [PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__PatientDu__Write__0717E911] DEFAULT ((0)) FOR [WriteOffAmt]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__BankN__074CF33B] DEFAULT ('') FOR [BankName]

ALTER TABLE [AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountRec__Refer__0781FD65] DEFAULT ((0)) FOR [ReferenceID]

ALTER TABLE [PatientIndents]WITH NOCHECK ADD CONSTRAINT [DF_PatientIndents_ConsultationDate] DEFAULT (getdate()) FOR [IndentDate]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Remar__08411774] DEFAULT ('') FOR [Remarks]

ALTER TABLE [AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountRec__Refer__0876219E] DEFAULT ('') FOR [ReferenceType]

ALTER TABLE [PatientIndents]WITH NOCHECK ADD CONSTRAINT [DF_PatientIndents_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__TaskM__09353BAD] DEFAULT ((0)) FOR [TaskModifiedBy]

ALTER TABLE [AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountRec__Units__096A45D7] DEFAULT ((0)) FOR [Units]

ALTER TABLE [PatientProcedure]WITH NOCHECK ADD CONSTRAINT [DF_PatientProcedure_ConsultationDate] DEFAULT (getdate()) FOR [ProcedureDate]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__TaskR__0A295FE6] DEFAULT ('') FOR [TaskRejectReason]

ALTER TABLE [AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountRec__CashG__0A5E6A10] DEFAULT ((0)) FOR [CashGiven]

ALTER TABLE [PatientProcedure]WITH NOCHECK ADD CONSTRAINT [DF_PatientProcedure_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Versi__0B1D841F] DEFAULT ('') FOR [VersionNo]

ALTER TABLE [AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountRec__Balan__0B528E49] DEFAULT ((0)) FOR [BalanceGiven]

ALTER TABLE [PatientVisit]WITH NOCHECK ADD CONSTRAINT [DF__PatientVi__Credi__0BDC9E2E] DEFAULT ((-1)) FOR [CreditLimit]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Autho__0C11A858] DEFAULT ((0)) FOR [AuthorisedBy]

ALTER TABLE [AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__AmountRec__Round__0C46B282] DEFAULT ((0)) FOR [RoundOffAmount]

ALTER TABLE [PatientVisit]WITH NOCHECK ADD CONSTRAINT [DF__PatientVi__patie__0CD0C267] DEFAULT ((0)) FOR [patientHistoryID]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Servi__0D05CC91] DEFAULT ('') FOR [ServiceType]

ALTER TABLE [aspnet_Applications]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Ap__Appli__0D3AD6BB] DEFAULT (newid()) FOR [ApplicationId]

ALTER TABLE [PatientVisit]WITH NOCHECK ADD CONSTRAINT [DF__PatientVi__Visit__0DC4E6A0] DEFAULT ('') FOR [VisitNumber]

ALTER TABLE [Edt_BillMaster]WITH NOCHECK ADD CONSTRAINT [DF__Edt_BillM__RoleI__0DF9F0CA] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [aspnet_Membership]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Me__Passw__0E2EFAF4] DEFAULT ((0)) FOR [PasswordFormat]

ALTER TABLE [PhysicianFeeDetails]WITH NOCHECK ADD CONSTRAINT [DF_PhysicianFeeDetails_Status] DEFAULT ('A') FOR [Status]

ALTER TABLE [Edt_BillMaster]WITH NOCHECK ADD CONSTRAINT [DF__Edt_BillM__DeptI__0EEE1503] DEFAULT ((0)) FOR [DeptID]

ALTER TABLE [aspnet_Paths]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Pa__PathI__0F231F2D] DEFAULT (newid()) FOR [PathId]

ALTER TABLE [PreOrderedInvestigations]WITH NOCHECK ADD CONSTRAINT [DF_PreOrderedInvestigations_ReferralID] DEFAULT ((-1)) FOR [ReferralID]

ALTER TABLE [Edt_BillMasterDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_BillM__RoleI__0FE2393C] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [aspnet_PersonalizationPerUser]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Perso__Id__10174366] DEFAULT (newid()) FOR [Id]

ALTER TABLE [PrintPolicyMaster]WITH NOCHECK ADD CONSTRAINT [DF__PrintPoli__Creat__10A1534B] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_BillMasterDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_BillM__DeptI__10D65D75] DEFAULT ((0)) FOR [DeptID]

ALTER TABLE [aspnet_Roles]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Ro__RoleI__110B679F] DEFAULT (newid()) FOR [RoleId]

ALTER TABLE [PrintPolicyMaster]WITH NOCHECK ADD CONSTRAINT [DF__PrintPoli__IsAct__11957784] DEFAULT ((0)) FOR [IsActive]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__DueAm__11CA81AE] DEFAULT ((0)) FOR [DueAmount]

ALTER TABLE [aspnet_Users]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Us__UserI__11FF8BD8] DEFAULT (newid()) FOR [UserId]

ALTER TABLE [ProductEpisodeVisitMapping]WITH NOCHECK ADD CONSTRAINT [DF__ProductEp__IsDel__12899BBD] DEFAULT ('N') FOR [IsDelete]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__DuePa__12BEA5E7] DEFAULT ((0)) FOR [DuePaidAmt]

ALTER TABLE [aspnet_Users]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Us__Mobil__12F3B011] DEFAULT (NULL) FOR [MobileAlias]

ALTER TABLE [ReferingPhysician]WITH NOCHECK ADD CONSTRAINT [DF__ReferingP__Paren__137DBFF6] DEFAULT ((0)) FOR [ParentReferingPhysicianID]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__OrgID__13B2CA20] DEFAULT ((0)) FOR [OrgID]

ALTER TABLE [CouponValueMaster]WITH NOCHECK ADD CONSTRAINT [DF__CouponVal__Statu__13BF4DC6] DEFAULT ('N') FOR [Status]

ALTER TABLE [aspnet_Users]WITH NOCHECK ADD CONSTRAINT [DF__aspnet_Us__IsAno__13E7D44A] DEFAULT ((0)) FOR [IsAnonymous]

ALTER TABLE [ReportExcelMaster]WITH NOCHECK ADD CONSTRAINT [DF_ReportExcelMaster_IsActive] DEFAULT ((1)) FOR [IsActive]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__IsCre__14A6EE59] DEFAULT ('') FOR [IsCreditBill]

ALTER TABLE [CouponValueMaster]WITH NOCHECK ADD CONSTRAINT [DF__CouponVal__IsDel__14B371FF] DEFAULT ('N') FOR [IsDelete]

ALTER TABLE [Attune_Deadlock_Log]WITH NOCHECK ADD CONSTRAINT [DF__Attune_De__Creat__14DBF883] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [ReportExcelRoleMapping]WITH NOCHECK ADD CONSTRAINT [DF_ReportExcelRoleMapping_IsActive] DEFAULT ((1)) FOR [IsActive]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Statu__159B1292] DEFAULT ('') FOR [Status]

ALTER TABLE [CouponValueMaster]WITH NOCHECK ADD CONSTRAINT [DF__CouponVal__Total__15A79638] DEFAULT ((1)) FOR [TotalAllowedCount]

ALTER TABLE [BedBooking]WITH NOCHECK ADD CONSTRAINT [DF_BedBooking_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [ReportExcelRoleMapping]WITH NOCHECK ADD CONSTRAINT [DF_ReportExcelRoleMapping_Createdat] DEFAULT (getdate()) FOR [Createdat]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__PaidF__168F36CB] DEFAULT ((0)) FOR [PaidFinalbillID]

ALTER TABLE [CouponValueMaster]WITH NOCHECK ADD CONSTRAINT [DF__CouponVal__UsedC__169BBA71] DEFAULT ((0)) FOR [UsedCount]

ALTER TABLE [BedBooking]WITH NOCHECK ADD CONSTRAINT [DF__BedBookin__IsRei__16C440F5] DEFAULT ('Y') FOR [IsReimbursable]

ALTER TABLE [ReportGroupMaster]WITH NOCHECK ADD CONSTRAINT [DF_ReportGroupMaster_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Creat__17835B04] DEFAULT ((0)) FOR [CreatedBy]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingDe__IsRei__17B8652E] DEFAULT ('Y') FOR [IsReimbursable]

ALTER TABLE [ReportMaster]WITH NOCHECK ADD CONSTRAINT [DF_ReportMaster_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Modif__18777F3D] DEFAULT ((0)) FOR [ModifiedBy]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF_BilledDate_op] DEFAULT (getdate()) FOR [BilledDate]

ALTER TABLE [ReportMaster]WITH NOCHECK ADD CONSTRAINT [DF__ReportMas__Deplo__1936994C] DEFAULT ((0)) FOR [DeploymentOrganizationTypeID]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Versi__196BA376] DEFAULT ('') FOR [VersionNo]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingDe__Produ__19A0ADA0] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [ReportPrintHistory]WITH NOCHECK ADD CONSTRAINT [DF__ReportPri__RoleI__1A2ABD85] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Disco__1A5FC7AF] DEFAULT ((0)) FOR [DiscountAmt]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingDe__IsDis__1A94D1D9] DEFAULT ('Y') FOR [IsDiscountable]

ALTER TABLE [ReportPrintHistory]WITH NOCHECK ADD CONSTRAINT [DF__ReportPri__OrgAd__1B1EE1BE] DEFAULT ((0)) FOR [OrgAddressID]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Curre__1B53EBE8] DEFAULT ((0)) FOR [CurrentDue]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingDe__IsSTA__1B88F612] DEFAULT ('N') FOR [IsSTAT]

ALTER TABLE [RoleDeptMap]WITH NOCHECK ADD CONSTRAINT [DF__RoleDeptM__IsAct__1C1305F7] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [Edt_PatientDueDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__Write__1C481021] DEFAULT ((0)) FOR [WriteOffAmt]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingDe__IsOut__1C7D1A4B] DEFAULT ('N') FOR [IsOutSource]

ALTER TABLE [RoomType]WITH NOCHECK ADD CONSTRAINT [DF__RoomType__AllowS__1D072A30] DEFAULT ('N') FOR [AllowSlotBooking]

ALTER TABLE [Edt_PatientVisit]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__RoleI__1D3C345A] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [BillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingDe__IsNAB__1D713E84] DEFAULT ('N') FOR [IsNABL]

ALTER TABLE [SampleBatchTracker]WITH NOCHECK ADD CONSTRAINT [DF__SampleBat__IsCon__1DFB4E69] DEFAULT ('N') FOR [IsConflict]

ALTER TABLE [Edt_PatientVisit]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Patie__DeptI__1E305893] DEFAULT ((0)) FOR [DeptID]

ALTER TABLE [BillingTestDetails]WITH NOCHECK ADD CONSTRAINT [DF__BillingTe__Bille__1E71E663] DEFAULT (getdate()) FOR [BilledDate]

ALTER TABLE [SiteEpisodeVisitMapping]WITH NOCHECK ADD CONSTRAINT [DF__SiteEpiso__IsDel__1EEF72A2] DEFAULT ('N') FOR [IsDelete]

ALTER TABLE [Edt_VisitClientMapping]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Visit__RoleI__1F247CCC] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [PatientInvestigationDevice]WITH NOCHECK ADD CONSTRAINT [DF__PatientIn__IsUpd__1F660A9C] DEFAULT ((0)) FOR [IsUpdated]

ALTER TABLE [StockInHand]WITH NOCHECK ADD CONSTRAINT [DF_StockInHand_TotalStockReceived] DEFAULT ((0)) FOR [TotalStockReceived]

ALTER TABLE [Edt_VisitClientMapping]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Visit__DeptI__2018A105] DEFAULT ((0)) FOR [DeptID]

ALTER TABLE [PatientInvestigationDeviceRuleBasedTest]WITH NOCHECK ADD CONSTRAINT [DF__PatientIn__IsUpd__205A2ED5] DEFAULT ((0)) FOR [IsUpdated]

ALTER TABLE [StockInHand]WITH NOCHECK ADD CONSTRAINT [DF_StockInHand_TotalStockIssued] DEFAULT ((0)) FOR [TotalStockIssued]

ALTER TABLE [EmployeeRegMaster]WITH NOCHECK ADD CONSTRAINT [DF_EmpRegMaster_IsActive] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [PatientMembershipCardMapping]WITH NOCHECK ADD CONSTRAINT [DF__PatientMe__Statu__214E530E] DEFAULT ('Pending') FOR [Status]

ALTER TABLE [StockInHand]WITH NOCHECK ADD CONSTRAINT [DF_StockInHand_TotalStockReturn] DEFAULT ((0)) FOR [TotalStockReturn]

ALTER TABLE [EmployeeRegMaster]WITH NOCHECK ADD CONSTRAINT [DF_EmpRegMaster_IsAlive] DEFAULT ('Y') FOR [IsAlive]

ALTER TABLE [PatientTRFVerification]WITH NOCHECK ADD CONSTRAINT [DF__PatientTR__IsDet__22427747] DEFAULT ((0)) FOR [IsDetailsEdited]

ALTER TABLE [StockInHand]WITH NOCHECK ADD CONSTRAINT [DF_StockInHand_TotalStockDamage] DEFAULT ((0)) FOR [TotalStockDamage]

ALTER TABLE [EmployeeRegMaster]WITH NOCHECK ADD CONSTRAINT [DF_EmpRegMaster_Status] DEFAULT ('Y') FOR [Status]

ALTER TABLE [SampleArchival]WITH NOCHECK ADD CONSTRAINT [df_SampleArchival_Active] DEFAULT ((1)) FOR [Active]

ALTER TABLE [StockInHand]WITH NOCHECK ADD CONSTRAINT [DF_StockInHand_TotalLocationIssued] DEFAULT ((0)) FOR [TotalLocationIssued]

ALTER TABLE [EpisodeVisitDetails]WITH NOCHECK ADD CONSTRAINT [DF__EpisodeVi__IsDel__23E931E9] DEFAULT ('N') FOR [IsDelete]

ALTER TABLE [StorageRackDayMaster]WITH NOCHECK ADD CONSTRAINT [df_StorageRackDaysMaster_Active] DEFAULT ((1)) FOR [Active]

ALTER TABLE [StockInHand]WITH NOCHECK ADD CONSTRAINT [DF__StockInHa__Produ__24A84BF8] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [FeeTypeMaster]WITH NOCHECK ADD CONSTRAINT [DF__FeeTypeMa__IsSer__24DD5622] DEFAULT ('N') FOR [IsServiceable]

ALTER TABLE [StorageRackMaster]WITH NOCHECK ADD CONSTRAINT [df_StorageRackMaster_Active] DEFAULT ((1)) FOR [Active]

ALTER TABLE [TRFfilemanager]WITH NOCHECK ADD CONSTRAINT [DF__TRFfilema__TRFGU__253CAF48] DEFAULT (newid()) FOR [TRFGUID]

ALTER TABLE [StockOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__StockOutF__Presc__259C7031] DEFAULT ('0') FOR [PrescriptionNo]

ALTER TABLE [FeeTypeOrgMapping]WITH NOCHECK ADD CONSTRAINT [FeeTypeOrgMapping_Def_LangCode] DEFAULT ('en-GB') FOR [LanguageCode]

ALTER TABLE [TRFfilemanager]WITH NOCHECK ADD CONSTRAINT [DF__TRFfilema__TRFIm__2630D381] DEFAULT (0x) FOR [TRFImageData]

ALTER TABLE [StockOutFlowDetails]WITH NOCHECK ADD CONSTRAINT [DF__StockOutF__Produ__2690946A] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [FinalBill]WITH NOCHECK ADD CONSTRAINT [DF__FinalBill__EDCes__26C59E94] DEFAULT ((0)) FOR [EDCess]

ALTER TABLE [StockReceived]WITH NOCHECK ADD CONSTRAINT [DF_StockReceived_PaidAmount] DEFAULT ((0)) FOR [PaidAmount]

ALTER TABLE [FinalBill]WITH NOCHECK ADD CONSTRAINT [DF__FinalBill__SHEDC__27B9C2CD] DEFAULT ((0)) FOR [SHEDCess]

ALTER TABLE [StockReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__StockRece__Produ__2878DCDC] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [StockReturnDetails]WITH NOCHECK ADD CONSTRAINT [DF__StockRetu__Produ__296D0115] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [TaskActions]WITH NOCHECK ADD CONSTRAINT [DF__TaskActio__IsSha__2A61254E] DEFAULT ('N') FOR [IsShareable]

ALTER TABLE [TransBillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__TransBill__IsDis__2B554987] DEFAULT ('N') FOR [IsDiscountable]

ALTER TABLE [TransBillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__TransBill__IsSTA__2C496DC0] DEFAULT ('N') FOR [IsSTAT]

ALTER TABLE [TransBillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__TransBill__IsOut__2D3D91F9] DEFAULT ('N') FOR [IsOutSource]

ALTER TABLE [GeneralBillingItems]WITH NOCHECK ADD CONSTRAINT [DF__GeneralBi__FeeSu__68F31A7C] DEFAULT ('GEN') FOR [FeeSubType]

ALTER TABLE [TransBillingDetails]WITH NOCHECK ADD CONSTRAINT [DF__TransBill__IsNAB__2E31B632] DEFAULT ('N') FOR [IsNABL]

ALTER TABLE [IDMaster]WITH NOCHECK ADD CONSTRAINT [DF_IDMaster_PatientNumber] DEFAULT ((0)) FOR [PatientNumber]

ALTER TABLE [VisitClientMapping]WITH NOCHECK ADD CONSTRAINT [DF__VisitClie__Final__2F25DA6B] DEFAULT ((0)) FOR [FinalBillID]

ALTER TABLE [IDMaster]WITH NOCHECK ADD CONSTRAINT [DF_IDMaster_BillNumber] DEFAULT ((0)) FOR [BillNumber]

ALTER TABLE [IDMaster]WITH NOCHECK ADD CONSTRAINT [DF_IDMaster_IPNumber] DEFAULT ((0)) FOR [IPNumber]

ALTER TABLE [IDMaster]WITH NOCHECK ADD CONSTRAINT [DF_IDMaster_VisitNumber] DEFAULT ((0)) FOR [VisitNumber]

ALTER TABLE [IDPatternMaster]WITH NOCHECK ADD CONSTRAINT [IsPatternAutoGenerated_IDPatternMaster] DEFAULT ('Y') FOR [IsPatternAutoGenerated]

ALTER TABLE [IncSourcePaidDetails]WITH NOCHECK ADD CONSTRAINT [DF__IncSource__CashG__332B7579] DEFAULT ((0)) FOR [CashGiven]

ALTER TABLE [IncSourcePaidDetails]WITH NOCHECK ADD CONSTRAINT [DF__IncSource__Balan__341F99B2] DEFAULT ((0)) FOR [BalanceGiven]

ALTER TABLE [InPatientConsultantTransferDetails]WITH NOCHECK ADD CONSTRAINT [DF_InPatientConsultantTransferDetails_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [InPatientDischargeDetails]WITH NOCHECK ADD CONSTRAINT [DF_InPatientDischargeDetails_AmbulanceRequired] DEFAULT ('N') FOR [AmbulanceRequired]

ALTER TABLE [InPatientDischargeDetails]WITH NOCHECK ADD CONSTRAINT [DF_InPatientDischargeDetails_AmbulanceConfirmed] DEFAULT ('N') FOR [AmbulanceConfirmed]

ALTER TABLE [BidirectionalBarCodeDetails]WITH NOCHECK ADD CONSTRAINT [Df_BidirectionalBarCodeDetails_iscompleted] DEFAULT ((0)) FOR [Iscompleted]

ALTER TABLE [InPatientDischargeDetails]WITH NOCHECK ADD CONSTRAINT [DF_InPatientDischargeDetails_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [CampDetail]WITH NOCHECK ADD CONSTRAINT [DF__CampDetai__IsCli__389D6368] DEFAULT ('N') FOR [IsClientPatient]

ALTER TABLE [InPatientLocationTransferDetails]WITH NOCHECK ADD CONSTRAINT [DF_PatientLocation_DateOfTransfer] DEFAULT (getdate()) FOR [DateOfTransfer]

ALTER TABLE [CampDetailError]WITH NOCHECK ADD CONSTRAINT [DF__CampDetai__IsCli__399187A1] DEFAULT ('N') FOR [IsClientPatient]

ALTER TABLE [InPatientLocationTransferDetails]WITH NOCHECK ADD CONSTRAINT [DF_PatientLocation_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [ClientMaster]WITH NOCHECK ADD CONSTRAINT [DF__ClientMas__IsCli__3A85ABDA] DEFAULT ((0)) FOR [IsClientAccess]

ALTER TABLE [IntendReceivedDetail]WITH NOCHECK ADD CONSTRAINT [DF__IntendRec__Produ__3ACC9741] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [DiscountMaster]WITH NOCHECK ADD CONSTRAINT [DF__DiscountM__Ceili__552FB23F] DEFAULT (NULL) FOR [CeilingValue]

ALTER TABLE [InvClientMaster]WITH NOCHECK ADD CONSTRAINT [DF__InvClient__Valid__3BC0BB7A] DEFAULT ('00:00:00.000') FOR [ValidFromTime]

ALTER TABLE [FinalBill]WITH NOCHECK ADD CONSTRAINT [DF__FinalBill__IsCoP__3C6DF44C] DEFAULT ('N') FOR [IsCoPayBill]

ALTER TABLE [InvClientMaster]WITH NOCHECK ADD CONSTRAINT [DF__InvClient__Valid__3CB4DFB3] DEFAULT ('23:59:59.999') FOR [ValidToTime]

ALTER TABLE [InvestigationOrgMapping]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsCon__3D621885] DEFAULT ('N') FOR [IsConfidentialTest]

ALTER TABLE [InvClientType]WITH NOCHECK ADD CONSTRAINT [DF__InvClient__Displ__3DA903EC] DEFAULT ('Y') FOR [Display]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__IsCoP__3E563CBE] DEFAULT ('N') FOR [IsCoPublish]

ALTER TABLE [InvestigationBulkDataMapping]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsAct__3E9D2825] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__IsAtt__3F4A60F7] DEFAULT ((0)) FOR [IsAttachmentMandatory]

ALTER TABLE [InvestigationMaster]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsPar__3F914C5E] DEFAULT ('N') FOR [IsParameter]

ALTER TABLE [BulkRegistrationDetail]WITH NOCHECK ADD CONSTRAINT [DF__BulkRegis__IsPro__3FC65688] DEFAULT ('N') FOR [IsProcessed]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__IsPkg__403E8530] DEFAULT ((1)) FOR [IsPkgTransfer]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsInt__40857097] DEFAULT ('N') FOR [IsInterfaced]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__Total__40BA7AC1] DEFAULT ((0.00)) FOR [TotalAmount]

ALTER TABLE [InvRateMaster]WITH NOCHECK ADD CONSTRAINT [DF__InvRateMa__IsAct__4132A969] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsSMS__417994D0] DEFAULT ('N') FOR [IsSMS]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__OrgPe__41AE9EFA] DEFAULT ((0.00)) FOR [OrgPercent]

ALTER TABLE [Notifications]WITH NOCHECK ADD CONSTRAINT [DF__Notificat__IsCli__4226CDA2] DEFAULT ('') FOR [IsClientBlinding]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsSer__426DB909] DEFAULT ('N') FOR [IsServiceTax]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__OrgAm__42A2C333] DEFAULT ((0.00)) FOR [OrgAmount]

ALTER TABLE [OrderedInvestigations]WITH NOCHECK ADD CONSTRAINT [DF__OrderedIn__IsCoP__431AF1DB] DEFAULT ('N') FOR [IsCoPublish]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsNAB__4361DD42] DEFAULT ('N') FOR [IsNABL]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__AmtBe__4396E76C] DEFAULT ((0.00)) FOR [AmtBeforeTDS]

ALTER TABLE [OrganizationAddress]WITH NOCHECK ADD CONSTRAINT [DF__Organizat__IsRem__440F1614] DEFAULT ('N') FOR [IsRemote]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsCAP__4456017B] DEFAULT ('N') FOR [IsCAP]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__TDSPe__448B0BA5] DEFAULT ((0.00)) FOR [TDSPercent]

ALTER TABLE [PatientInvestigation]WITH NOCHECK ADD CONSTRAINT [DF__PatientIn__IsCon__45033A4D] DEFAULT ('N') FOR [IsConfidentialTest]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsDis__454A25B4] DEFAULT ('N') FOR [IsDiscountable]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__TDSAm__457F2FDE] DEFAULT ((0.00)) FOR [TDSAmount]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsRep__463E49ED] DEFAULT ('N') FOR [IsRepeatable]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__TermP__46735417] DEFAULT ((0.00)) FOR [TermPayableAmount]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsSTA__47326E26] DEFAULT ('N') FOR [IsSTAT]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__Previ__47677850] DEFAULT ((0.00)) FOR [PreviousDue]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__HasHi__4826925F] DEFAULT ('N') FOR [HasHistory]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__Total__485B9C89] DEFAULT ((0.00)) FOR [TotalPayable]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF_Investigationorgattributes_IsTATrandom] DEFAULT ((0)) FOR [IsTATrandom]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__Total__494FC0C2] DEFAULT ((0.00)) FOR [TotalPaid]

ALTER TABLE [InvestigationOrgAttributes]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsNon__4A0EDAD1] DEFAULT ((0)) FOR [IsNonEditable]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__TermP__4A43E4FB] DEFAULT ((0.00)) FOR [TermPayment]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__DueSe__4B380934] DEFAULT ((0.00)) FOR [DueSettled]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__TermD__4C2C2D6D] DEFAULT ((0.00)) FOR [TermDue]

ALTER TABLE [CashOutFlow]WITH NOCHECK ADD CONSTRAINT [DF__CashOutFl__Total__4D2051A6] DEFAULT ((0.00)) FOR [TotalDue]

ALTER TABLE [ClientServiceCodeMapping]WITH NOCHECK ADD CONSTRAINT [DF__ClientSer__ShowA__4E1475DF] DEFAULT ('N') FOR [ShowActualDiscAmt]

ALTER TABLE [ClientTaxMaster]WITH NOCHECK ADD CONSTRAINT [DF__ClientTax__IsAct__4F089A18] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [CollectionsHistory]WITH NOCHECK ADD CONSTRAINT [DF__Collectio__CashG__4FFCBE51] DEFAULT ((0)) FOR [CashGiven]

ALTER TABLE [CollectionsHistory]WITH NOCHECK ADD CONSTRAINT [DF__Collectio__Balan__50F0E28A] DEFAULT ((0)) FOR [BalanceGiven]

ALTER TABLE [CommunicationConfig]WITH NOCHECK ADD CONSTRAINT [DF__Communica__IsAct__51E506C3] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [DialysisDetails]WITH NOCHECK ADD CONSTRAINT [DF_DialysisDetails_isFirstDialysis] DEFAULT ((0)) FOR [IsFirstDialysis]

ALTER TABLE [DrugUseInstruction]WITH NOCHECK ADD CONSTRAINT [DF_DrugUseInstruction_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Gross__54C1736E] DEFAULT ((0)) FOR [GrossBillValue]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsInt__55808D7D] DEFAULT ('N') FOR [IsInterfaced]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Disco__55B597A7] DEFAULT ((0)) FOR [Discount]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsSMS__5674B1B6] DEFAULT ('N') FOR [IsSMS]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Disco__56A9BBE0] DEFAULT ((0)) FOR [DiscountPercentage]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsSer__5768D5EF] DEFAULT ('N') FOR [IsServiceTax]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Disco__579DE019] DEFAULT ('') FOR [DiscountReason]

ALTER TABLE [ClientMaster_HIST]WITH NOCHECK ADD CONSTRAINT [DF__ClientMas__IsCop__5810179D] DEFAULT ((0)) FOR [IsCopay]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsNAB__585CFA28] DEFAULT ('N') FOR [IsNABL]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Account__Tax__58920452] DEFAULT ((0)) FOR [Tax]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsCAP__59511E61] DEFAULT ('N') FOR [IsCAP]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Servi__5986288B] DEFAULT ((0)) FOR [ServiceCharge]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsDis__5A45429A] DEFAULT ('N') FOR [IsDiscountable]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Round__5A7A4CC4] DEFAULT ((0)) FOR [RoundOffAmount]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsRep__5B3966D3] DEFAULT ('N') FOR [IsRepeatable]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__NetVa__5B6E70FD] DEFAULT ((0)) FOR [NetValue]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsSTA__5C2D8B0C] DEFAULT ('N') FOR [IsSTAT]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Previ__5C629536] DEFAULT ((0)) FOR [PreviousReceivedAmount]

ALTER TABLE [InvestigationOrgAttributesHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__Creat__5D21AF45] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Recei__5D56B96F] DEFAULT ((0)) FOR [ReceivedAmount]

ALTER TABLE [InvestigationOrgMapping]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsAct__5E15D37E] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Previ__5E4ADDA8] DEFAULT ((0)) FOR [PreviousRefundAmount]

ALTER TABLE [InvestigationOrgMapping]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__IsCol__5F09F7B7] DEFAULT ('') FOR [IsColorPrint]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Refun__5F3F01E1] DEFAULT ((0)) FOR [RefundAmount]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__Allow__5F56727F] DEFAULT ((1)) FOR [AllowAutoComplete]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Account__Due__6033261A] DEFAULT ((0)) FOR [Due]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__IsFor__604A96B8] DEFAULT ((1)) FOR [IsFormulaCalculateOnDevice]

ALTER TABLE [InvestigationOrgMappingHistory]WITH NOCHECK ADD CONSTRAINT [DF__Investiga__AutoA__60F24029] DEFAULT ((0)) FOR [AutoApproveLoginID]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__Medic__61274A53] DEFAULT ((0)) FOR [MedicalAmount]

ALTER TABLE [InvMedicalDetailsMapping]WITH NOCHECK ADD CONSTRAINT [DF__InvMedica__IsMan__61E66462] DEFAULT ('N') FOR [IsMandatory]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__NonMe__621B6E8C] DEFAULT ((0)) FOR [NonMedicalAmount]

ALTER TABLE [InvOrganismDrugMapping]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgani__IsAct__62DA889B] DEFAULT ((1)) FOR [IsActive]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__RoleI__630F92C5] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__HasHi__63CEACD4] DEFAULT ('N') FOR [HasHistory]

ALTER TABLE [Edt_AccountsImpactDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Accou__DeptI__6403B6FE] DEFAULT ((0)) FOR [DeptID]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__IsSpe__64C2D10D] DEFAULT ('N') FOR [IsSpecialFormat]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__AmtRe__64F7DB37] DEFAULT ((0)) FOR [AmtReceived]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF_Invorggroup_IsTATrandom] DEFAULT ((0)) FOR [IsTATrandom]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__TypeI__65EBFF70] DEFAULT ((0)) FOR [TypeID]

ALTER TABLE [InvOrgGroup]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgGro__IsCol__66AB197F] DEFAULT ('') FOR [IsColorPrint]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Chequ__66E023A9] DEFAULT ('') FOR [ChequeorCardNumber]

ALTER TABLE [InvOrgReferenceMapping]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgRef__IsPri__679F3DB8] DEFAULT ('N') FOR [IsPrimary]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__BankN__67D447E2] DEFAULT ('') FOR [BankNameorCardType]

ALTER TABLE [InvOrgReferenceMapping]WITH NOCHECK ADD CONSTRAINT [DF__InvOrgRef__IsAct__689361F1] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Remar__68C86C1B] DEFAULT ('') FOR [Remarks]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Servi__69BC9054] DEFAULT ((0)) FOR [ServiceCharge]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__BaseC__6AB0B48D] DEFAULT ((0)) FOR [BaseCurrencyID]

ALTER TABLE [InvReportMaster]WITH NOCHECK ADD CONSTRAINT [DF__InvReport__IsAct__6B6FCE9C] DEFAULT ('A') FOR [IsActive]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__PaidC__6BA4D8C6] DEFAULT ((0)) FOR [PaidCurrencyID]

ALTER TABLE [InvSummaryReport]WITH NOCHECK ADD CONSTRAINT [DF__InvSummar__ShowT__6C63F2D5] DEFAULT ((0)) FOR [ShowTRF]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Other__6C98FCFF] DEFAULT ((0)) FOR [OtherCurrencyAmount]

ALTER TABLE [InvValueRangeMaster]WITH NOCHECK ADD CONSTRAINT [DF__InvValueR__IsAct__6D58170E] DEFAULT ('Y') FOR [IsActive]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__RoleI__6D8D2138] DEFAULT ((0)) FOR [RoleID]

ALTER TABLE [KitPrepMaster]WITH NOCHECK ADD CONSTRAINT [DF__KitPrepMa__Produ__6E4C3B47] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__DeptI__6E814571] DEFAULT ((0)) FOR [DeptID]

ALTER TABLE [KitPrepMaster]WITH NOCHECK ADD CONSTRAINT [DF__KitPrepMa__Quant__6F405F80] DEFAULT ((0.00)) FOR [Quantity]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Refer__6F7569AA] DEFAULT ((0)) FOR [ReferenceID]

ALTER TABLE [KitPrepMasterDetails]WITH NOCHECK ADD CONSTRAINT [DF__KitPrepMa__Produ__703483B9] DEFAULT ('') FOR [ProductKey]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Refer__70698DE3] DEFAULT ('') FOR [ReferenceType]

ALTER TABLE [LocationClientMapping]WITH NOCHECK ADD CONSTRAINT [LCM_IsDefaultLocClient] DEFAULT ('N') FOR [IsDefaultLocClient]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Units__715DB21C] DEFAULT ((0)) FOR [Units]

ALTER TABLE [LoginRole]WITH NOCHECK ADD CONSTRAINT [DF__LoginRole__IsDef__721CCC2B] DEFAULT ((0)) FOR [IsDefault]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__EMIOp__7251D655] DEFAULT ('') FOR [EMIOpted]

ALTER TABLE [LoginRole_HIST]WITH NOCHECK ADD CONSTRAINT [DF__LoginRole__IsDef__7310F064] DEFAULT ((0)) FOR [IsDefault]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__EMIRO__7345FA8E] DEFAULT ((0)) FOR [EMIROI]

ALTER TABLE [MenuMaster]WITH NOCHECK ADD CONSTRAINT [LanguageCode_Default] DEFAULT ('en-GB') FOR [LanguageCode]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__EMITe__743A1EC7] DEFAULT ((0)) FOR [EMITenor]

ALTER TABLE [MenuMasterHeader]WITH NOCHECK ADD CONSTRAINT [MenuMasterHeader_Def_LangCode] DEFAULT ('en-GB') FOR [LanguageCode]

ALTER TABLE [Edt_AmountReceivedDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__EMIVa__752E4300] DEFAULT ((0)) FOR [EMIValue]

ALTER TABLE [Notifications]WITH NOCHECK ADD CONSTRAINT [DF__Notificat__Prior__75ED5D0F] DEFAULT ((2)) FOR [Priority]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__AmtRe__76226739] DEFAULT ((0)) FOR [AmtRefund]

ALTER TABLE [OrderedInvestigations]WITH NOCHECK ADD CONSTRAINT [DF_OrderedInvestigations_ReferralID] DEFAULT ((-1)) FOR [ReferralID]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Refun__77168B72] DEFAULT ((0)) FOR [RefundBy]

ALTER TABLE [OrganismMaster]WITH NOCHECK ADD CONSTRAINT [DF__OrganismM__IsAct__77D5A581] DEFAULT ((1)) FOR [IsActive]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Refun__780AAFAB] DEFAULT ('') FOR [RefundStatus]

ALTER TABLE [Pages]WITH NOCHECK ADD CONSTRAINT [DF__Pages__IsShareab__78C9C9BA] DEFAULT ('N') FOR [IsShareable]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Creat__78FED3E4] DEFAULT ((0)) FOR [CreatedBy]

ALTER TABLE [Patient]WITH NOCHECK ADD CONSTRAINT [DF__Patient__IsNotif__79BDEDF3] DEFAULT ((0)) FOR [IsNotify]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Modif__79F2F81D] DEFAULT ((0)) FOR [ModifiedBy]

ALTER TABLE [Patient]WITH NOCHECK ADD CONSTRAINT [DF__Patient__Externa__7AB2122C] DEFAULT ('') FOR [ExternalPatientNumber]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Reaso__7AE71C56] DEFAULT ('') FOR [ReasonforRefund]

ALTER TABLE [Patient]WITH NOCHECK ADD CONSTRAINT [DF__Patient__ParentP__7BA63665] DEFAULT ((0)) FOR [ParentPatientID]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__BillS__7BDB408F] DEFAULT ('') FOR [BillStatus]

ALTER TABLE [PatientConsultation]WITH NOCHECK ADD CONSTRAINT [DF_PatientConsultation_ConsultationDate] DEFAULT (getdate()) FOR [ConsultationDate]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Quant__7CCF64C8] DEFAULT ((0)) FOR [Quantity]

ALTER TABLE [PatientConsultation]WITH NOCHECK ADD CONSTRAINT [DF_PatientConsultation_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Refun__7DC38901] DEFAULT ('') FOR [RefundNo]

ALTER TABLE [PatientDepositHistory]WITH NOCHECK ADD CONSTRAINT [DF__PatientDe__CashG__7E82A310] DEFAULT ((0)) FOR [CashGiven]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Refun__7EB7AD3A] DEFAULT ('') FOR [RefundType]

ALTER TABLE [PatientDepositHistory]WITH NOCHECK ADD CONSTRAINT [DF__PatientDe__Balan__7F76C749] DEFAULT ((0)) FOR [BalanceGiven]

ALTER TABLE [Edt_AmountRefundDetails]WITH NOCHECK ADD CONSTRAINT [DF__Edt_Amoun__Appro__7FABD173] DEFAULT ((0)) FOR [ApprovedBy]
