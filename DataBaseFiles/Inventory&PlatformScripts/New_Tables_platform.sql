/****** Object:  Table [dbo].[MedicalIndentMaster_History]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalIndentMaster_History]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalIndentMaster_History]
GO


/****** Object:  Table [dbo].[MedicalIndentMaster_History]    Script Date: 01/20/2016 15:55:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MedicalIndentMaster_History](
	[ID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[MedicalIndentID] [bigint] NULL,
	[ItemName] [nvarchar](500) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsRefundable] [nchar](1) NULL,
	[IsTaxable] [nchar](1) NULL,
	[IsAmountEditable] [nchar](1) NULL,
	[IsDiscountable] [nchar](1) NULL,
	[ChartAccCode] [nchar](1) NULL,
	[ServiceCode] [nvarchar](255) NULL
) ON [PRIMARY]

GO



IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PHYORG_IsAmountEditable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PhysicianOrganization] DROP CONSTRAINT [DF_PHYORG_IsAmountEditable]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PHYORG_IsRefundable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PhysicianOrganization] DROP CONSTRAINT [DF_PHYORG_IsRefundable]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PHYORG_IsDiscountable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PhysicianOrganization] DROP CONSTRAINT [DF_PHYORG_IsDiscountable]
END

GO


/****** Object:  Table [dbo].[PhysicianOrganization]    Script Date: 01/20/2016 10:40:54 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianOrganization]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianOrganization]
GO



/****** Object:  Table [dbo].[PhysicianOrganization]    Script Date: 01/20/2016 10:40:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PhysicianOrganization](
	[PhysicianID] [int] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ChartAccCode] [nvarchar](10) NULL,
	[IsAmountEditable] [nchar](1) NULL,
	[IsRefundable] [nchar](1) NULL,
	[IsTaxable] [nchar](1) NULL,
	[IsDiscountable] [nchar](1) NULL,
	[Status] [nchar](1) NULL,
	[FeeTypeGroupOrgID] [bigint] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PhysicianOrganization] ADD  CONSTRAINT [DF_PHYORG_IsAmountEditable]  DEFAULT ('Y') FOR [IsAmountEditable]
GO

ALTER TABLE [dbo].[PhysicianOrganization] ADD  CONSTRAINT [DF_PHYORG_IsRefundable]  DEFAULT ('Y') FOR [IsRefundable]
GO

ALTER TABLE [dbo].[PhysicianOrganization] ADD  CONSTRAINT [DF_PHYORG_IsDiscountable]  DEFAULT ('Y') FOR [IsDiscountable]
GO



/****** Object:  Table [dbo].[PatientPrescription]    Script Date: 02/05/2016 12:15:50 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPrescription]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPrescription]
GO

/****** Object:  Table [dbo].[PatientPrescription]    Script Date: 02/05/2016 12:15:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientPrescription](
	[PatientVisitID] [bigint] NOT NULL,
	[DrugID] [bigint] NULL,
	[BrandName] [nvarchar](100) NULL,
	[Dose] [nvarchar](50) NULL,
	[Formulation] [nvarchar](50) NULL,
	[ROA] [nvarchar](50) NULL,
	[DrugFrequency] [nvarchar](50) NULL,
	[Duration] [nvarchar](100) NULL,
	[ComplaintId] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[AdministeredAtFrom] [datetime] NULL,
	[Instruction] [nvarchar](100) NULL,
	[PrescriptionID] [bigint] IDENTITY(1,1) NOT NULL,
	[DrugStatus] [nvarchar](25) NULL,
	[AdministeredAtTo] [datetime] NULL,
	[DrugSource] [nvarchar](5) NULL,
	[PrescriptionType] [nvarchar](5) NULL,
	[IssuedQty] [numeric](18, 2) NULL,
	[Status] [nvarchar](25) NULL,
	[TotalQty] [numeric](18, 2) NULL,
	[TaskID] [bigint] NULL,
	[PrescriptionNumber] [varchar](30) NULL,
	[PhysicianID] [bigint] NULL,
	[PrescriptionValidityDate] [datetime] NULL,
	[Direction] [varchar](255) NULL,
	[ReturnQuantity] [decimal](18, 2) NULL,
	[Migrated_Patient_Number] [nvarchar](12) NULL,
	[Migrated_Visit_Number] [nvarchar](10) NULL,
	[Migrated_Drug_Code] [nvarchar](8) NULL,
	[Migrated_Batch_Code] [nvarchar](30) NULL,
	[Migrated_Price_Code] [decimal](18, 6) NULL,
	[Comment] [nvarchar](255) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__PatientPr__Statu__5728DECD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PatientPrescriptionDetails] DROP CONSTRAINT [DF__PatientPr__Statu__5728DECD]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PatientPrescription_ReturnQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PatientPrescriptionDetails] DROP CONSTRAINT [DF_PatientPrescription_ReturnQuantity]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PatientPrescription_Migrated_Price_Code]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PatientPrescriptionDetails] DROP CONSTRAINT [DF_PatientPrescription_Migrated_Price_Code]
END

GO


/****** Object:  Table [dbo].[PatientPrescriptionDetails]    Script Date: 01/19/2016 17:52:25 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPrescriptionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPrescriptionDetails]
GO



/****** Object:  Table [dbo].[PatientPrescriptionDetails]    Script Date: 01/19/2016 17:52:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PatientPrescriptionDetails](
	[PatientVisitID] [bigint] NOT NULL,
	[DrugID] [bigint] NULL,
	[BrandName] [nvarchar](100) NULL,
	[Dose] [nvarchar](50) NULL,
	[Formulation] [nvarchar](50) NULL,
	[ROA] [nvarchar](50) NULL,
	[DrugFrequency] [nvarchar](50) NULL,
	[Duration] [nvarchar](100) NULL,
	[ComplaintId] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[AdministeredAtFrom] [datetime] NULL,
	[Instruction] [nvarchar](100) NULL,
	[PrescriptionID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[DrugStatus] [nvarchar](25) NULL,
	[AdministeredAtTo] [datetime] NULL,
	[DrugSource] [nvarchar](5) NULL,
	[PrescriptionType] [nvarchar](5) NULL,
	[IssuedQty] [numeric](18, 2) NULL,
	[Status] [nvarchar](25) NULL,
	[TotalQty] [numeric](18, 2) NULL,
	[TaskID] [bigint] NULL,
	[PrescriptionNumber] [nvarchar](30) NULL,
	[PhysicianID] [bigint] NULL,
	[PrescriptionValidityDate] [datetime] NULL,
	[Direction] [nvarchar](255) NULL,
	[ReturnQuantity] [decimal](18, 6) NULL,
	[Migrated_Patient_Number] [nvarchar](12) NULL,
	[Migrated_Visit_Number] [nvarchar](10) NULL,
	[Migrated_Drug_Code] [nvarchar](8) NULL,
	[Migrated_Batch_Code] [nvarchar](30) NULL,
	[Migrated_Price_Code] [decimal](18, 6) NULL,
	[IsGeneric] [nchar](1) NULL,
	[IssueDrugID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[OrderTaskID] [bigint] NULL,
	[PatientPrescriptionID] [bigint] NULL,
	[Comment] [nvarchar](40) NULL,
	[DrugFrequencyID] [int] NULL,
	[DrugInstructionID] [int] NULL,
	[PrescriptionDrugMappingID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Sticky] [bit] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PatientPrescriptionDetails] ADD  CONSTRAINT [DF__PatientPr__Statu__5728DECD]  DEFAULT ('Open') FOR [Status]
GO

ALTER TABLE [dbo].[PatientPrescriptionDetails] ADD  CONSTRAINT [DF_PatientPrescription_ReturnQuantity]  DEFAULT ((0.00)) FOR [ReturnQuantity]
GO

ALTER TABLE [dbo].[PatientPrescriptionDetails] ADD  CONSTRAINT [DF_PatientPrescription_Migrated_Price_Code]  DEFAULT ((0.00)) FOR [Migrated_Price_Code]
GO





/****** Object:  Table [dbo].[PatientProgressive]    Script Date: 01/20/2016 10:50:49 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientProgressive]') AND type in (N'U'))
DROP TABLE [dbo].[PatientProgressive]
GO



/****** Object:  Table [dbo].[PatientProgressive]    Script Date: 01/20/2016 10:50:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PatientProgressive](
	[PatientProgressiveID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[PatientVisitID] [bigint] NULL,
	[ProgressiveID] [int] NULL,
	[Subjective] [nvarchar](300) NULL,
	[Objective] [nvarchar](300) NULL,
	[Assesment] [nvarchar](300) NULL,
	[Planning] [nvarchar](300) NULL,
	[PatientID] [bigint] NULL,
	[PhysicianName] [nvarchar](255) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [datetime] NULL,
	[DateandTimeofCaseReview] [datetime] NULL,
	[OrderTaskID] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]

GO




IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__OrderedPh__Patie__5ACAF209]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[OrderedPhysiotherapy] DROP CONSTRAINT [DF__OrderedPh__Patie__5ACAF209]
END

GO



/****** Object:  Table [dbo].[OrderedPhysiotherapy]    Script Date: 01/20/2016 11:05:02 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderedPhysiotherapy]') AND type in (N'U'))
DROP TABLE [dbo].[OrderedPhysiotherapy]
GO



/****** Object:  Table [dbo].[OrderedPhysiotherapy]    Script Date: 01/20/2016 11:05:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderedPhysiotherapy](
	[ProcedureID] [bigint] NULL,
	[ProcedureName] [nvarchar](500) NULL,
	[OdreredQty] [decimal](18, 2) NULL,
	[Status] [nvarchar](50) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PatientID] [bigint] NULL,
	[VisitID] [bigint] NULL,
	[OrgAddID] [int] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[PerphyID] [bigint] NULL,
	[Perphyname] [nvarchar](255) NULL,
	[PerformerType] [nvarchar](55) NULL,
	[TaskID] [bigint] NULL,
	[PhysicianID] [bigint] NULL,
	[Type] [nvarchar](10) NULL,
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderedPhysioID] [int] NULL,
	[OrderTaskID] [bigint] NULL,
	[PatientVisitAttribID] [bigint] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[OrderedPhysiotherapy] ADD  CONSTRAINT [DF__OrderedPh__Patie__5ACAF209]  DEFAULT ((0)) FOR [PatientVisitAttribID]
GO




IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MI_IsRefundable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MedicalIndentMaster] DROP CONSTRAINT [DF_MI_IsRefundable]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MI_IsAmountEditable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MedicalIndentMaster] DROP CONSTRAINT [DF_MI_IsAmountEditable]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MI_IsDiscountable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MedicalIndentMaster] DROP CONSTRAINT [DF_MI_IsDiscountable]
END

GO

IF  EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MI_ChartAccCode]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MedicalIndentMaster] DROP CONSTRAINT [DF_MI_ChartAccCode]
END

GO



/****** Object:  Table [dbo].[MedicalIndentMaster]    Script Date: 01/21/2016 19:24:29 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalIndentMaster]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalIndentMaster]
GO



/****** Object:  Table [dbo].[MedicalIndentMaster]    Script Date: 01/21/2016 19:24:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MedicalIndentMaster](
	[MedicalIndentID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ItemName] [nvarchar](500) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsRefundable] [nchar](1) NULL,
	[IsTaxable] [nchar](1) NULL,
	[IsAmountEditable] [nchar](1) NULL,
	[IsDiscountable] [nchar](1) NULL,
	[ChartAccCode] [nchar](1) NULL,
	[ServiceCode] [nvarchar](255) NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MedicalIndentMaster] ADD  CONSTRAINT [DF_MI_IsRefundable]  DEFAULT ('Y') FOR [IsRefundable]
GO

ALTER TABLE [dbo].[MedicalIndentMaster] ADD  CONSTRAINT [DF_MI_IsAmountEditable]  DEFAULT ('Y') FOR [IsAmountEditable]
GO

ALTER TABLE [dbo].[MedicalIndentMaster] ADD  CONSTRAINT [DF_MI_IsDiscountable]  DEFAULT ('Y') FOR [IsDiscountable]
GO

ALTER TABLE [dbo].[MedicalIndentMaster] ADD  CONSTRAINT [DF_MI_ChartAccCode]  DEFAULT ('Y') FOR [ChartAccCode]
GO


----Langaguage mapping-------------------


/****** Object:  Table [dbo].[ClaimAmountLogicLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClaimAmountLogicLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ClaimAmountLogicLangMapping]
GO
/****** Object:  Table [dbo].[DrugFrequencyLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugFrequencyLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DrugFrequencyLangMapping]
GO
/****** Object:  Table [dbo].[KnowledgeOfServiceLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KnowledgeOfServiceLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[KnowledgeOfServiceLangMapping]
GO
/****** Object:  Table [dbo].[LocalitiesLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocalitiesLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[LocalitiesLangMapping]
GO
/****** Object:  Table [dbo].[NationalityLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NationalityLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[NationalityLangMapping]
GO
/****** Object:  Table [dbo].[PageLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PageLangMapping]
GO
/****** Object:  Table [dbo].[PurposeOfAdmissionLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurposeOfAdmissionLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PurposeOfAdmissionLangMapping]
GO
/****** Object:  Table [dbo].[RacemasterLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RacemasterLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[RacemasterLangMapping]
GO
/****** Object:  Table [dbo].[ReligionLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReligionLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ReligionLangMapping]
GO
/****** Object:  Table [dbo].[ReportResoureLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportResoureLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ReportResoureLangMapping]
GO
/****** Object:  Table [dbo].[RoleLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[RoleLangMapping]
GO
/****** Object:  Table [dbo].[URNTypesLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[URNTypesLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[URNTypesLangMapping]
GO
/****** Object:  Table [dbo].[URNTypesLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[URNTypesLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[URNTypesLangMapping](
	[URNTypesMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[URNTypesID] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[RoleLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoleLangMapping](
	[RoleLangID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleID] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ReportResoureLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportResoureLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ReportResoureLangMapping](
	[ResLangMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[ResourceID] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ReligionLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReligionLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ReligionLangMapping](
	[ReligionMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[ReligionID] [bigint] NOT NULL,
	[ReligionDesc] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[RacemasterLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RacemasterLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RacemasterLangMapping](
	[RaceMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[RaceID] [bigint] NOT NULL,
	[RaceDesc] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PurposeOfAdmissionLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurposeOfAdmissionLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PurposeOfAdmissionLangMapping](
	[PurposeOfAdmissionLangMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurposeOfAdmissionID] [bigint] NOT NULL,
	[PurposeOfAdmissionDesc] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PageLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PageLangMapping](
	[PageMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[PageID] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NationalityLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NationalityLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NationalityLangMapping](
	[NationalityLangMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[NationalityID] [bigint] NOT NULL,
	[NationalityDesc] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[LocalitiesLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocalitiesLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LocalitiesLangMapping](
	[LocalitiesMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[LocalitiesID] [bigint] NULL,
	[LocalitiesDesc] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[KnowledgeOfServiceLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KnowledgeOfServiceLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KnowledgeOfServiceLangMapping](
	[KnowledgeOfServiceLangMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[KnowledgeOfServiceID] [bigint] NOT NULL,
	[KnowledgeOfServiceDesc] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[DrugFrequencyLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugFrequencyLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DrugFrequencyLangMapping](
	[DrugFreqLangMapId] [int] IDENTITY(1,1) NOT NULL,
	[DrugFrequencyID] [bigint] NULL,
	[DisplayText] [nvarchar](max) NULL,
	[LangCode] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
 CONSTRAINT [DrugFrequencyLangMapping_DrugFreqLangMapId_PK] PRIMARY KEY CLUSTERED 
(
	[DrugFreqLangMapId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ClaimAmountLogicLangMapping]    Script Date: 02/29/2016 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClaimAmountLogicLangMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ClaimAmountLogicLangMapping](
	[ClaimAmountLogicMapID] [bigint] IDENTITY(1,1) NOT NULL,
	[ClaimID] [bigint] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[MedicalIndentMaster_History]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalExpenses]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalExpenses]
GO



IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalExpenses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MedicalExpenses](
	[MedicalExpenseID] [bigint] IDENTITY(1,1) NOT NULL,
	[FamilyDetailsID] [bigint] NULL,
	[MemberDetailID] [bigint] NULL,
	[ExpenseType] [nvarchar](10) NULL,
	[Expense] [decimal](18, 2) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL
) ON [PRIMARY]
END
GO

/****** Object:  Table [dbo].[MedicalIndentMaster_History]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CertificateInfo]') AND type in (N'U'))
DROP TABLE [dbo].[CertificateInfo]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CertificateInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CertificateInfo](
	[CertificateInfoID] [bigint] IDENTITY(1,1) NOT NULL,
	[MemberDetailsID] [bigint] NULL,
	[CertificateTypeID] [int] NULL,
	[Value] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CertificateDate] [datetime] NULL
) ON [PRIMARY]
END
GO

/****** Object:  Table [dbo].[LoggedInUsers_HIST]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoggedInUsers_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[LoggedInUsers_HIST]
GO

/****** Object:  Table [dbo].[LoggedInUsers_HIST]    Script Date: 08/14/2015 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoggedInUsers_HIST]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoggedInUsers_HIST](
	[HISTID] [bigint] IDENTITY(1,1) NOT NULL,
	[LoginID] [bigint] NOT NULL,
	[IsLogged] [nchar](1) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[SessionID] [nvarchar](100) NULL,
	[RoleID] [int] NULL,
	[DeptID] [int] NULL,
	[ID] [bigint] NULL,
	[InventoryLocationID] [int] NULL
) ON [PRIMARY]
END
GO

/****** Object:  Table [dbo].[SpecialityOrgMapping]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialityOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialityOrgMapping]
GO

/****** Object:  Table [dbo].[SpecialityOrgMapping]    Script Date: 29-01-2016  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialityOrgMapping]') AND type in (N'U'))
BEGIN

CREATE TABLE [dbo].[SpecialityOrgMapping](
	[SpecialityOrgMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[SpecialityID] [int] NULL,
	[SpecialityDesc] [nvarchar](1000) NULL,
	[OrgID] [BigInt] NULL,
	[CreatedBy] [nvarchar](30) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](30) NULL,
	[ModifiedAt] [datetime] NULL
 
) ON [PRIMARY]
END
GO

/****** Object:  Table [dbo].[SpecialityLangMapping]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialityLangMapping]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialityLangMapping]
GO

/****** Object:  Table [dbo].[SpecialityLangMapping]    Script Date: 29-01-2016  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialityLangMapping](
	[SpecialityLangMapping] [bigint] IDENTITY(1,1) NOT NULL,
	[SpecialityID] [int] NULL,
	[SpecialityDesc] [nvarchar](1000) NULL,
	[LangCode] [nvarchar](10) NULL,
	[CreatedBy] [nvarchar](30) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [nvarchar](30) NULL,
	[ModifiedAt] [datetime] NULL
	 
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[DepartmentRateCardMapping]    Script Date: 01/20/2016 15:55:04 ******/
IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DepartmentRateCardMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DepartmentRateCardMapping]
GO

/****** Object:  Table [dbo].[DepartmentRateCardMapping]    Script Date: 08/14/2015 14:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DepartmentRateCardMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DepartmentRateCardMapping](
	[DeptRateCardMapID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[DepartmentID] [bigint] NULL,
	[DepartmentCode] [nvarchar](50) NULL,
	[RateID] [int] NULL,
	[OrgID] [int] NULL,
	[SpecialityCode] [nvarchar](50) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
END
GO
