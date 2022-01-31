
/****** Object:  Table [dbo].[InvResultTemplate]    Script Date: 09/29/2009 15:56:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvResultTemplate](
	[ResultID] [int] NOT NULL,
	[ResultName] [varchar](255) NULL,
	[ResultValues] [varchar] (max) NULL,
	[ResultTemplateType] [varchar](25) NOT NULL,
	[OrgID] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


