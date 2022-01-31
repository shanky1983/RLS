/****** Object:  Table [dbo].[InvKitMaster]    Script Date: 10/13/2009 13:14:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvKitMaster](
	[KitID] [bigint] NULL,
	[KitName] [varchar](255) NULL,
	[OrgID] [int] NULL,
	[Status] [varchar] (10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


