
/****** Object:  Table [dbo].[PerformingPhysician]    Script Date: 10/24/2009 18:42:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PerformingPhysician](
	[PerformingPhysicianID] [bigint] IDENTITY(1,1) NOT NULL,
	[PhysicianName] [nvarchar](250) NULL,
	[Qualification] [nvarchar](250) NULL,
	[OrgID] [int] NULL
) ON [PRIMARY]

GO


