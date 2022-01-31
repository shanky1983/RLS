/****** Object:  Table [dbo].[BillLineItems]    Script Date: 04/11/2009 10:53:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BillLineItems](
	[BillLineItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[BillID] [bigint] NULL,
	[OrgID] [int] NULL,
	[ItemName] [varchar](500) NULL,
	[ItemID] [bigint] NULL,
	[ItemType] [varchar](20) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL
) ON [PRIMARY]

GO

