/****** Object:  Table [dbo].[LabVisitDetails]    Script Date: 04/28/2009 12:29:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[LabVisitDetails](
	[PatientID] [bigint] NULL,
	[OrgID] [int] NULL,
	[VisitID] [bigint] NULL,
	[VisitDate] [datetime] NULL,
	[PriorityID] [int] NULL,
	[ReferingPhysicianID] [int] NULL,
	[ReferingPhysicianName] [varchar](100) NULL,
	[HospitalID] [int] NULL,
	[HospitalName] [varchar](100) NULL,
	[ClientID] [int] NULL,
	[ClientName] [varchar](100) NULL,
	[CollectionCentreID] [int] NULL,
	[CollectionCentreName] [varchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO