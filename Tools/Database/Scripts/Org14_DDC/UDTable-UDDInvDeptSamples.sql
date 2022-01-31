

/****** Object:  UserDefinedTableType [dbo].[UDDInvDeptSamples]    Script Date: 06/12/2009 17:19:45 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'UDDInvDeptSamples' AND ss.name = N'dbo')
DROP TYPE [dbo].[UDDInvDeptSamples]
GO



/****** Object:  UserDefinedTableType [dbo].[UDDInvDeptSamples]    Script Date: 06/12/2009 17:19:45 ******/
CREATE TYPE [dbo].[UDDInvDeptSamples] AS TABLE(
	[PatientVisitID] [bigint] NULL,
	[DeptID] [int] NULL,
	[OrgID] [int] NULL
)
GO


