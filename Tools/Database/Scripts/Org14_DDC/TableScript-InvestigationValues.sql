/****** Object:  Table [dbo].[InvestigationValues]    Script Date: 07/06/2009 15:57:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvestigationValues](
	[InvestigationValueID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](500) NULL,
	[Value] [varchar](max) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[GroupName] [varchar](255) NULL,
	[PatientVisitID] [bigint] NULL,
	[UOMID] [int] NULL,
	[Status] [varchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[UOMCode] [varchar](50) NULL,
	[Orgid] [int] NULL,
	[IPInvSampleCollectionMasterID] [bigint]NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
