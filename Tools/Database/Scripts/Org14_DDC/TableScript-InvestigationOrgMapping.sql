

/****** Object:  Table [dbo].[InvestigationOrgMapping]    Script Date: 11/28/2009 19:12:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvestigationOrgMapping](
	[InvestigationID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[DeptID] [int] NULL,
	[HeaderID] [bigint] NULL,
	[Display] [varchar](5) NULL,
	[DisplayText] [varchar](255) NULL,
	[ReferenceRange] [varchar](500) NULL,
	[UOMID] [int] NULL,
	[UOMCode] [varchar](50) NULL,
	[SequenceNo] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


