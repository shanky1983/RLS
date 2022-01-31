
/****** Object:  Table [dbo].[PatientInvSampleResults]    Script Date: 06/15/2009 11:25:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientInvSampleResults](
	[VisitID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[SampleCode] [int] NOT NULL,
	[AttributesID] [int] NOT NULL,
	[SampleValues] [varchar](50) NOT NULL,
	[SampleDesc] [varchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


