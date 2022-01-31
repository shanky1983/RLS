
/****** Object:  Table [dbo].[PatientInvSampleMapping]    Script Date: 09/24/2009 10:22:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientInvSampleMapping](
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleID] [int] NULL,
	[ID] [bigint] NULL,
	[Type] [varchar](10) NULL,
	[DeptID] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


