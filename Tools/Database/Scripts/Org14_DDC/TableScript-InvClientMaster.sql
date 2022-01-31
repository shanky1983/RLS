/****** Object:  Table [dbo].[InvClientMaster]    Script Date: 04/25/2009 10:36:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvClientMaster](
	[ClientID] [int] NOT NULL,
	[OrgID] [int] NULL,
	[ClientName] [varchar](100) NULL,
	[ClientTypeID] [int] NULL,
	[Status] [varchar] (20) NULL,
	[ActiveYN] [char](1) NULL
	
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

