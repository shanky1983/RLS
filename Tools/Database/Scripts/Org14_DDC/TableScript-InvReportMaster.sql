/****** Object:  Table [dbo].[InvReportMaster]    Script Date: 07/10/2009 16:49:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvReportMaster](
	[TemplateID] [int] NULL,
	[ReportTemplateName] [varchar](255) NULL,
	[IsDefault] [char](10) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO