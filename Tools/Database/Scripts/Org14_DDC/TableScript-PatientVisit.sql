
/****** Object:  Table [dbo].[PatientVisit]    Script Date: 11/28/2009 17:05:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO
 
CREATE TABLE [dbo].[PatientVisit](
	[PatientVisitId] [bigint] NOT NULL,
	[PatientID] [bigint] NULL,
	[VisitDate] [datetime] NULL,
	[ReferOrgID] [bigint] NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [bigint] NULL,
	[PhysicianID] [int] NULL,
	[ConditionId] [int] NULL,
	[VisitType] [int] NULL,
	[OutVisitID] [bigint] NULL,
	[VisitPurposeID] [int] NULL,
	[SpecialityID] [int] NULL,
	[VisitNotes] [nvarchar](1000) NULL,
	[ClientID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[VisitState] [varchar](50) NULL,
	[NurseNotes] [varchar](255) NULL,
	[AccompaniedBy] [varchar](50) NULL,
	[ParentVisitId] [bigint] NULL,
	[NextReviewDate] [varchar](20) NULL,
	[SecuredCode] [varchar](150) NULL,
	[AdmissionSuggested] [char](1) NULL,
	[TokenNumber] [int] NULL,
	[PhysicianName] [varchar](50) NULL,
	[Age] [varchar](20) NULL,
	[PriorityID] [int] NULL,
	[ReferingPhysicianID] [int] NULL,
	[ReferingPhysicianName] [varchar](100) NULL,
	[HospitalID] [int] NULL,
	[HospitalName] [varchar](100) NULL,
	[ClientName] [varchar](100) NULL,
	[CollectionCentreID] [int] NULL,
	[CollectionCentreName] [varchar](100) NULL,
	[CorporateID] [int] NULL, 
 CONSTRAINT [PK_PatientVisit] PRIMARY KEY CLUSTERED 
(
	[PatientVisitId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


