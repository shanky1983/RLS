

/****** Object:  UserDefinedTableType [dbo].[PatientInvestigationFiles]    Script Date: 11/18/2009 16:16:13 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigationFiles' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvestigationFiles]
GO



/****** Object:  UserDefinedTableType [dbo].[PatientInvestigationFiles]    Script Date: 11/18/2009 16:16:13 ******/
CREATE TYPE [dbo].[PatientInvestigationFiles] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[InvestigationID] [bigint] NULL,
	[FilePath] [varchar](100) NULL,
	[ImageSource] [varbinary](max) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL
)
GO


