
/****** Object:  Table [dbo].[LabReferenceOrg]    Script Date: 05/12/2009 15:44:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[LabReferenceOrg](
	[LabRefOrgID] [bigint] IDENTITY(1,1) NOT NULL,
	[RefOrgName] [varchar](100) NULL,
	[ClientTypeID] [int] NULL,
	[OrgID] [int] NULL,
	[Status] [varchar] (20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


