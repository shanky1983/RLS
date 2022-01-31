/****** Object:  Table [dbo].[IDMaster]    Script Date: 05/28/2009 09:18:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[IDMaster](
	[OrgID] [int] NOT NULL,
	[BillID] [bigint] NOT NULL,
	[VisitID] [bigint] NOT NULL
 CONSTRAINT [PK_IDMaster] PRIMARY KEY CLUSTERED 
(
	[OrgID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
