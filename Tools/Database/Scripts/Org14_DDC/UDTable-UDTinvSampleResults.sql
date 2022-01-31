/****** Object:  UserDefinedTableType [dbo].[UDTinvSampleResults]    Script Date: 06/15/2009 11:30:35 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDTinvSampleResults' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDTinvSampleResults]
GO

/****** Object:  UserDefinedTableType [dbo].[UDTinvSampleResults]    Script Date: 06/15/2009 11:30:35 ******/
CREATE TYPE [dbo].[UDTinvSampleResults] AS TABLE(
	[VisitID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[SampleCode] [int] NOT NULL,
	[AttributesID] [int] NOT NULL,
	[SampleValues] [varchar](50) NOT NULL,
	[SampleDesc] [varchar](255) NULL,
	[CreatedBy] [int] NULL
)
GO


