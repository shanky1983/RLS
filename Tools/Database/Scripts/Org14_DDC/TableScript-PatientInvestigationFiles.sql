
/****** Object:  Table [dbo].[PatientInvestigationFiles]    Script Date: 11/16/2009 15:50:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientInvestigationFiles](
	[ImageID] [bigint] IDENTITY(1,1) NOT NULL,
	[PatientVisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[FilePath] [varchar](100) NULL,
	[ImageSource] [varbinary](max) NULL,
	[Type] [varchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


