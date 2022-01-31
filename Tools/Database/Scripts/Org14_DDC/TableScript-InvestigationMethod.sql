/****** Object:  Table [dbo].[InvestigationMethod]    Script Date: 02/02/2009 19:30:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvestigationMethod](
	[MethodID] [bigint] NULL,
	[MethodName] [varchar](255) NULL,
	[Status] [varchar] (10) NULL,
	[FemaleLowerLimit] [bigint] NULL,
	[FemaleUpperLimit] [bigint] NULL,
	[MaleLowerLimit] [bigint] NULL,
	[MaleUpperLimit] [bigint] NULL,
	[Severity] [varchar](50) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

