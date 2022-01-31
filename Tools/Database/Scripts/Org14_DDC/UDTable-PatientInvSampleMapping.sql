
/****** Object:  UserDefinedTableType [dbo].[PatientInvSampleMapping]    Script Date: 09/23/2009 13:33:25 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvSampleMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvSampleMapping]
GO

/****** Object:  UserDefinedTableType [dbo].[PatientInvSampleMapping]    Script Date: 09/23/2009 13:33:25 ******/
CREATE TYPE [dbo].[PatientInvSampleMapping] AS TABLE(
	[VisitID] [bigint] NULL,
	[OrgID] [int] NULL,
	[SampleID] [int] NULL,
	[ID] [bigint] NULL,
	[Type] [varchar](10) NULL
)
GO


