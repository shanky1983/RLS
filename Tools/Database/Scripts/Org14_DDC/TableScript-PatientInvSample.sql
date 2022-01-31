/****** Object:  Table [dbo].[PatientInvSample]    Script Date: 06/12/2009 16:43:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientInvSample](
	   [PatientVisitID] [bigint] NULL,
       [SampleID] [bigint] IDENTITY(1,1) NOT NULL,
       [BarcodeNumber] [varchar](250) NULL,
       [SampleCode] [int] NULL,
       [OrgID] [int] NULL,
       [CreatedBy] [bigint] NULL,
       [CreatedAt] [datetime] NULL,
       [ModifiedBy] [bigint] NULL,
       [ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


