/****** Object:  Table [dbo].[SampleTracker]    Script Date: 06/12/2009 16:44:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SampleTracker](
	[SampleTrackerID] [int] IDENTITY(1,1) NOT NULL,
	[PatientVisitID] [bigint] NULL,
	[SampleID] [bigint] NULL,
	[InvSampleStatusID] [int] NULL,
	[DeptID] [int] NULL,
	[Reason] [varchar](500) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [int] NULL,
	[CurrentOrgID] [int] NULL,
	[IPInvSampleCollectionMasterID] [BIGINT]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


