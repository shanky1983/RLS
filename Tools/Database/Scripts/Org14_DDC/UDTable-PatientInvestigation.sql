
/****** Object:  UserDefinedTableType [dbo].[PatientInvestigation]    Script Date: 11/30/2009 11:48:22 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PatientInvestigation' AND ss.name = N'dbo')
DROP TYPE [dbo].[PatientInvestigation]
GO



/****** Object:  UserDefinedTableType [dbo].[PatientInvestigation]    Script Date: 11/30/2009 11:48:22 ******/
CREATE TYPE [dbo].[PatientInvestigation] AS TABLE(
	[InvestigationName] [varchar](255) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[GroupName] [varchar](255) NULL,
	[PatientVisitID] [bigint] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CollectedDateTime] [datetime] NULL,
	[Status] [varchar](100) NULL,
	[ComplaintID] [int] NULL,
	[Type] [varchar](50) NULL,
	[OrgID] [int] NULL,
	[InvestigationMethodID] [bigint] NULL,
	[MethodName] [varchar](255) NULL,
	[KitID] [bigint] NULL,
	[KitName] [varchar](255) NULL,
	[InstrumentID] [bigint] NULL,
	[InstrumentName] [varchar](255) NULL,
	[Interpretation] [varchar](255) NULL
)
GO


