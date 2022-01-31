
/****** Object:  Table [dbo].[InvRateMaster]    Script Date: 04/25/2009 10:37:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InvRateMaster](
	[RateID] [bigint]IDENTITY(1,1) NOT NULL,
	[Type] [varchar](20) NULL,
	[ID][bigint] NULL,
	[ClientID] [int] NULL,
	[Rate] [decimal](18, 2) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

