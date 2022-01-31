
/****** Object:  Table [dbo].[DiscountMaster]    Script Date: 05/12/2009 15:38:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DiscountMaster](
	[DiscountID] [int] NULL,
	[DiscountName] [varchar](50) NULL,
	[OrgID] [int] NULL,
	[Discount] [decimal](18, 2) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


