/****** Object:  Table [dbo].[InvestigationImageMaster]    Script Date: 06/08/2009 18:28:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvestigationImageMaster](
	[VisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[MIMEType] [varchar](10) NULL,
	[Image] [varbinary](max) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


