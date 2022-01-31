

/****** Object:  UserDefinedTableType [dbo].[BillItemsMapping]    Script Date: 04/15/2009 16:42:16 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BillItemsMapping' AND ss.name = N'dbo')
DROP TYPE [dbo].[BillItemsMapping]
GO


/****** Object:  UserDefinedTableType [dbo].[BillItemsMapping]    Script Date: 04/15/2009 16:42:16 ******/
CREATE TYPE [dbo].[BillItemsMapping] AS TABLE(
	[ItemName] [varchar](500) NULL,
	[ItemID] [bigint] NULL,
	[Type][varchar](20) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL
)
GO
