/****** Object:  UserDefinedTableType [dbo].[InvestigationResults]    Script Date: 08/24/2009 12:26:58 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvestigationResults' AND ss.name = N'dbo')
DROP TYPE [dbo].[InvestigationResults]
GO



/****** Object:  UserDefinedTableType [dbo].[InvestigationResults]    Script Date: 08/24/2009 12:26:58 ******/
CREATE TYPE [dbo].[InvestigationResults] AS TABLE(
	[Name] [varchar](500) NULL,
	[Value] [varchar](max) NULL,
	[InvestigationID] [bigint] NULL,
	[GroupID] [int] NULL,
	[PatientVisitID] [bigint] NULL,
	[UOMID] [varchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[UOMCode] [varchar](50) NULL,
	[OrgID] [int] NULL,
	[GroupName] [varchar](255) NULL,
	[Status] [varchar](10) NULL,
	[ModifiedBy] [bigint] NULL
	
)
GO



