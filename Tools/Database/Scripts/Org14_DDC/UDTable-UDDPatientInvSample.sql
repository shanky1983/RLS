

/****** Object:  UserDefinedTableType [dbo].[UDDPatientInvSample]    Script Date: 07/13/2009 12:40:34 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDPatientInvSample' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDPatientInvSample]
GO



/****** Object:  UserDefinedTableType [dbo].[UDDPatientInvSample]    Script Date: 07/13/2009 12:40:34 ******/
CREATE TYPE [dbo].[UDDPatientInvSample] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[BarcodeNumber] [varchar](500) NULL,
	[SampleCode] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgID] [int] NULL
)
GO



