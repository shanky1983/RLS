

/****** Object:  UserDefinedTableType [dbo].[UDDinsertSampleTrack]    Script Date: 06/12/2009 17:20:29 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDinsertSampleTrack' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDinsertSampleTrack]
GO



/****** Object:  UserDefinedTableType [dbo].[UDDinsertSampleTrack]    Script Date: 06/12/2009 17:20:29 ******/
CREATE TYPE [dbo].[UDDinsertSampleTrack] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[SampleID] [int] NULL,
	[InvSampleStatusID] [int] NULL,
	[DeptID] [int] NULL,
	[Reason] [varchar](500) NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
	[OrgID] [int] NULL,
	 [CurrentOrgID] [int] NULL
)
GO


