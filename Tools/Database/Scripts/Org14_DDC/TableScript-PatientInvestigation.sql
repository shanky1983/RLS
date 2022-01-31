/****** Object:  Table [dbo].[PatientInvestigation]    Script Date: 07/20/2009 17:25:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientInvestigation](
	[PatientVisitID] [bigint] NOT NULL,
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [varchar](250) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[InvestigationMethodID] [bigint] NULL,
	[InvestigationSampleContainerID] [int] NULL,
	[SampleID] [int] NULL,
	[InvestigationSiteID] [int] NULL,
	[IsCompleted] [char](1) NULL,
	[Status] [varchar](100) NULL,
	[GroupID] [int] NULL,
	[GroupName] [varchar](250) NULL,
	[Reason] [varchar](250) NULL,
	[ReportStatus] [varchar](255) NULL,
	[ReferenceRange] [varchar](255) NULL,
	[MethodName] [varchar](255) NULL,
	[WorklistDeletedStatus] [varchar](50) NULL,
	[PerformingPhysicainName] [varchar](500) NULL,
	[ComplaintId] [int] NULL,
	[OrgID] [int] NULL,
	[KitID] [bigint] NULL,
	[KitName] [varchar] (255) NULL,
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [varchar] (255) NULL,
	[Interpretation] [varchar] (255) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
