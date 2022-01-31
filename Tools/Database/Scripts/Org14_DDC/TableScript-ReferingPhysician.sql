/****** Object:  Table [dbo].[ReferingPhysician]    Script Date: 04/25/2009 17:33:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ReferingPhysician](
	[ReferingPhysicianID] [int] IDENTITY(1,1) NOT NULL,
	[PhysicianName] [varchar](100) NULL,
	[Qualification] [varchar](100) NULL,
	[OrganizationName] [varchar](100) NULL,
	[OrgID] [int] NULL,
	[Status] [varchar] (20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

