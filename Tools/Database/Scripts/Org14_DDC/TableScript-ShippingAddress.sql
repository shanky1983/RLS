/****** Object:  Table [dbo].[ShippingAddress]    Script Date: 04/10/2009 10:14:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ShippingAddress](
	[ShippingAddressID] [bigint] IDENTITY(1,1) NOT NULL,
	[Add1] [varchar](60) NULL,
	[Add2] [varchar](60) NULL,
	[Add3] [varchar](60) NULL,
	[PostalCode] [varchar](10) NULL,
	[CountryID] [smallint] NULL,
	[City] [varchar](25) NULL,
	[StateID] [smallint] NULL,
	[MobileNumber] [varchar](20) NULL,
	[LandLineNumber] [varchar](20) NULL,
	[StartDTTM] [datetime] NULL,
	[EndDTTM] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
 CONSTRAINT [PK_ShippingAddress] PRIMARY KEY CLUSTERED 
(
	[ShippingAddressID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

