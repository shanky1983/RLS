
/****** Object:  Table [dbo].[ResultPublishing]    Script Date: 04/10/2009 10:15:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ResultPublishing](
	[OrgID] [int] NULL,
	[PatientVisitID] [bigint] NULL,
	[ModeID] [int] NULL,
	[ShippingAddressID] [bigint] NULL,
	[Value] [varchar](50) NULL,
	[Status] [varchar](30) NULL,
	[ReceiverName] [varchar](30) NULL,
	[ReceiverContactNo] [varchar](20) NULL,
	[StartDTTM] [datetime] NULL,
	[EndDTTM] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

