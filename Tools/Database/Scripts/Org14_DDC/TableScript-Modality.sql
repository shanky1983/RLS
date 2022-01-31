
/****** Object:  Table [dbo].[Modality]    Script Date: 10/06/2009 15:10:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Modality](
	[ModalityID] [int] NOT NULL,
	[ModalityName] [varchar](250) NOT NULL,
	[ModalityMake] [varchar](250) NULL,
	[AETitle] [varchar](250) NULL,
	[ModalityDescription] [varchar](500) NULL,
	[DepartmentID] [int] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


