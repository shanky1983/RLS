
/****** Object:  Table [dbo].[BillMaster]    Script Date: 04/11/2009 10:51:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BillMaster](
	[BillID] [bigint] NULL,
	[BillDate] [datetime] NULL,
	[OrgID] [int] NULL,
	[VisitID] [bigint] NULL,
	[PatientID] [bigint] NULL,
	[ClientID] [int] NULL,
	[CollectionCentreID] [int] NULL,
	[Type] [varchar](10) NULL,
	[ReferenceBillID] [bigint] NULL,
	[GrossAmount] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[AmountReceived] [decimal](18,2)NULL,
	[AmountDue][decimal](18,2)NULL,
	[IsCredit] [char](1) NULL,
	[Status] [char] (5) NULL,
	[Comments] [varchar] (500) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

