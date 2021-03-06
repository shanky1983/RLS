--****** Object:  Table [dbo].[TempStockReceivedDetails]    Script Date: 08/14/2015 14:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TempStockReceivedDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TempStockReceivedDetails](
	[PurchaseOrderID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](20) NULL,
	[TotalCost] [decimal](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](20) NULL,
	[OrgAddressID] [int] NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 2) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[LocationID] [int] NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[Status] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[Nominal] [decimal](18, 2) NULL,
	[SupplierID] [int] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
END
GO

/****** Object:  Table [dbo].[InventoryUOMOrgMapping]    Script Date: 2/12/2016 8:12:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InventoryUOMOrgMapping](
	[InventoryUOMOrgMappingId] [bigint] IDENTITY(1,1) NOT NULL,
	[InventoryUOMId] [bigint] NOT NULL,
	[OrgId] [bigint] NOT NULL,
	[CategoryId] [bigint] NULL,
	[TypeId] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[DraftIDMaster]    Script Date: 2/12/2016 8:12:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DraftIDMaster](
	[DraftIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[DraftID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[FeeShareGroupValueDetails]    Script Date: 08/14/2015 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeeShareGroupValueDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FeeShareGroupValueDetails](
	[ValueID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[GroupDefinationID] [bigint] NULL,
	[FeeTypeAttributesID] [bigint] NULL,
	[Value] [decimal](18, 2) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[FeeTypeGroupOrgMapping]    Script Date: 08/14/2015 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeeTypeGroupOrgMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FeeTypeGroupOrgMapping](
	[FeeTypeGroupOrgID] [bigint] IDENTITY(1,1) NOT NULL,
	[FeeTypeGroupID] [bigint] NULL,
	[FeeTypeSubGroupID] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[LanguageCode] [nvarchar](10) NULL,
	[FeeType] [nvarchar](255) NULL,
	[FeeID] [bigint] NULL,
	[IsActive] [nchar](1) NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[XSLBillFormat]    Script Date: 08/14/2015 14:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[XSLBillFormat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[XSLBillFormat](
	[XSLBFID] [int] IDENTITY(1,1) NOT NULL,
	[Header] [nvarchar](4000) NULL,
	[Body] [nvarchar](4000) NULL,
	[Footer] [nvarchar](4000) NULL,
	[BillType] [nvarchar](10) NULL,
	[OrgID] [int] NULL
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackGroundPrintAttributes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BackGroundPrintAttributes](
	[BackGroundPrintAttributesID] [bigint] IDENTITY(1,1) NOT NULL,
	[BackGroundPrintContentID] [bigint] NOT NULL,
	[FontName] [nvarchar](20) NULL,
	[FontStyle] [nvarchar](20) NULL,
	[FontColor] [nvarchar](20) NULL,
	[FontSize] [tinyint] NULL,
	[XAxis] [decimal](7, 2) NULL,
	[YAxis] [decimal](7, 2) NULL,
	[Width] [decimal](7, 2) NULL,
	[Hight] [decimal](7, 2) NULL,
	[Status] [bit] NULL
) ON [PRIMARY]
END
GO

--IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Theme]') AND type in (N'U'))
--BEGIN
--CREATE TABLE [dbo].[Theme](
--	[ThemeID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
--	[ThemeName] [nvarchar](255) NULL,
--	[ThemeURL] [nvarchar](255) NULL,
--	[createdat] [datetime] NULL,
--	[CreatedBy] [bigint] NULL,
--	[ModifiedAt] [datetime] NULL,
--	[ModifiedBy] [bigint] NULL
--) ON [PRIMARY]

--END
--GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleVideoMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoleVideoMapping](
	[VidoID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NULL,
	[OrgID] [int] NULL,
	[VideoOrderID] [int] NULL,
	[VideoDescription] [varchar](150) NULL,
	[VideoFilePath] [varchar](200) NULL,
	[CreateBy] [int] NULL,
	[CreateAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[VidoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

END
GO




IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductTypeOrgMapping]') AND type in (N'U'))
BEGIN
Create table ProductTypeOrgMapping
(
ProductTypeOrgMappingId BIGINT NOT NULL IDENTITY(1,1),
ProductTypeId INT NULL,
OrgID BIGINT NOT NULL,
Status BIGINT NULL,
CreatedAt DATETIME NULL,
CreatedBy BIGINT NULL,
ModifiedAt DATETIME NULL,
ModifiedBy BIGINT NULL
)
END
GO

/****** Object:  Table [dbo].[ProductCategoriesTypeMapping]    Script Date: 09/02/2015 11:27:25 ******/
CREATE TABLE ProductCategoriesTypeMapping(
ProductCategoriesTypeMappingId BIGINT NOT NULL IDENTITY(1,1),

CategoryID INT NULL,TypeID INT NULL,

OrgID INT NULL,

IsMandatory BIGINT NULL DEFAULT((1)),

Status BIGINT NULL DEFAULT((1)),

CreatedAt DATETIME NULL,

CreatedBy BIGINT NULL,

ModifiedAt DATETIME NULL,ModifiedBy BIGINT NULL

)

/****** Object:  Table [dbo].[StockReceivedBarcodeMapping]    Script Date: 09/02/2015 11:27:25 ******/
CREATE TABLE [dbo].[StockReceivedBarcodeMapping](
	[BarcodeMappingId] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NULL,
	[ProductKey] [nvarchar](510) NULL,
	[Barcode] [nvarchar](50) NULL,
	[UnitSize] [int] NULL,
	[Unit] [nvarchar](50) NULL,
	[StockReceivedDetailsId] [bigint] NULL,
	[StockOutFlowId] [bigint] NULL
) ON [PRIMARY]

/****** Object:  Table [dbo].[Inv_Config]    Script Date: 09/02/2015 11:27:25 ******/
CREATE TABLE [dbo].[Inv_Config](
	RowID int identity(1,1),
	[ConfigKey] [nvarchar](50) NOT NULL,
	[DisplayText] [nvarchar](max) NULL,
	[IsInternal] [nchar](1) NOT NULL,
	[ControlType] [nvarchar](20) NULL,
	[ValueType] [nvarchar](20) NULL,
	[ConfigType] [nvarchar](50) NULL,
	[IsAddressBased] [nchar](5) NULL,
	[ConfigValue] [nvarchar](max) NULL
) ON [PRIMARY]






/****** Object:  Table [dbo].[Taxmaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
 
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaxCategoriesMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxCategoriesMapping](
	[TaxCategoriesMappingID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriesID] [int] NULL,
	[TaxTypeID] [int] NULL,
	[StateID] [int] NULL,
	[Tax] [decimal](18, 2) NULL,
	[OrgID] [int] NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[OrgAddressID] [int] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[OutputTaxTypeID] [int] NULL,
	[OutputTax] [decimal](18, 2) NULL,
 CONSTRAINT [Def_TaxCategoriesMapping_TaxCategoriesMappingID] PRIMARY KEY CLUSTERED 
(
	[TaxCategoriesMappingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers_HIST](
	[Supplier_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SupplierID] [int] NULL,
	[SupplierName] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[EmailID] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[TinNo] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[ParentSupplierID] [bigint] NULL,
	[IsDeleted] [nchar](3) NULL,
	[Termsconditions] [nvarchar](max) NULL,
	[CstNo] [nvarchar](50) NULL,
	[DrugLicenceNo] [nvarchar](50) NULL,
	[ServiceTaxNo] [nvarchar](50) NULL,
	[PanNo] [nvarchar](50) NULL,
	[DrugLicenceNo1] [nvarchar](50) NULL,
	[DrugLicenceNo2] [nvarchar](50) NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SupplierName] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[EmailID] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[TinNo] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[ParentSupplierID] [bigint] NULL,
	[IsDeleted] [nchar](3) NULL,
	[Termsconditions] [nvarchar](max) NULL,
	[CstNo] [nvarchar](50) NULL,
	[DrugLicenceNo] [nvarchar](50) NULL,
	[ServiceTaxNo] [nvarchar](50) NULL,
	[PanNo] [nvarchar](50) NULL,
	[DrugLicenceNo1] [nvarchar](50) NULL,
	[DrugLicenceNo2] [nvarchar](50) NULL,
	[SupplierCode] [nvarchar](100) NULL,
	[PIN] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SupplierCreditorDebitReference]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierCreditorDebitReference](
	[SupplierID] [bigint] NOT NULL,
	[UsedStockReceivedID] [bigint] NOT NULL,
	[UsedAmount] [decimal](18, 2) NULL,
	[CreditAmount] [decimal](18, 2) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierCreditorDebitNote]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierCreditorDebitNote](
	[SupplierID] [bigint] NOT NULL,
	[CreditAmount] [decimal](18, 2) NULL,
	[UsedAmount] [decimal](18, 2) NULL,
	[DebitAmount] [decimal](18, 0) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierAddress]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SupplierAddress](
	[AddressID] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplierID] [bigint] NOT NULL,
	[AddressType] [nchar](1) NULL,
	[Add1] [nvarchar](250) NULL,
	[Add2] [nvarchar](250) NULL,
	[Add3] [nvarchar](250) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[CountryID] [smallint] NULL,
	[City] [nvarchar](25) NULL,
	[StateID] [smallint] NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[LandLineNumber] [nvarchar](20) NULL,
	[StartDTTM] [datetime] NULL,
	[EndDTTM] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OtherCountryName] [nvarchar](60) NULL,
	[OtherStateName] [nvarchar](60) NULL,
	[CountryCode] [int] NULL,
	[StateCode] [int] NULL,
	[CityCode] [int] NULL,
	[AddLevel1] [int] NULL,
	[AddLevel2] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockUsageIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockUsageIDMaster](
	[StockUsageIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[StockUsageID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockUsageIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockUsageDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockUsageDetails](
	[StockUsageDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockUsageID] [bigint] NOT NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [bigint] NULL,
	[LocationID] [int] NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[BatchNo] [nvarchar](50) NULL,
	[UsedDate] [datetime] NULL,
	[UsageStatus] [nvarchar](50) NULL,
	[StockOutFlowID] [bigint] NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[IsReimbursable] [nchar](1) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[ParentProductID] [bigint] NULL,
	[kitID] [bigint] NULL,
	[TaxPercent] [decimal](18, 6) NULL,
	[Discount] [decimal](18, 6) NULL,
	[FeeDescription] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ReceiptNO] [nvarchar](20) NULL,
	[ProductKey] [nvarchar](1020) NULL,
	[Description] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockUsage]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockUsage](
	[StockUsageID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[UsedBy] [bigint] NULL,
	[OrgID] [int] NULL,
	[PatientID] [int] NULL,
	[OrgAddressID] [bigint] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[Comments] [nvarchar](255) NULL,
	[VisitID] [bigint] NULL,
	[StockUsageType] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockTypeMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockTypeMapping](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockTypeID] [int] NULL,
	[OrgID] [int] NULL,
	[LanguageCode] [nvarchar](10) NULL,
	[DisplayText] [nvarchar](50) NULL,
	[SearchTypeID] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockType]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockType](
	[StockTypeID] [int] NOT NULL,
	[StockTypeName] [nvarchar](20) NOT NULL,
	[SearchTypeID] [int] NULL,
	[OrgID] [int] NULL,
	[IsDisplay] [nchar](1) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockStatusMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockStatusMapping](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockStatusID] [int] NOT NULL,
	[OrgID] [int] NULL,
	[LanguageCode] [nvarchar](10) NULL,
	[DisplayText] [nvarchar](50) NULL,
	[StockTypeID] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockStatus]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockStatus](
	[StockStatusID] [int] NOT NULL,
	[StockStatusName] [nvarchar](20) NOT NULL,
	[StockTypeID] [int] NULL,
	[OrgID] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockReturnIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockReturnIDMaster](
	[StockReturnIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[StockReturnID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockReturnIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockReturnDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReturnDetails](
	[StockReturnDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockReturnID] [bigint] NULL,
	[StockReceivedID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[BatchNo] [nvarchar](255) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[CostPrice] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[StockOuFlowID] [bigint] NULL,
	[Unit] [nvarchar](50) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[POReturnQty] [decimal](10, 2) NULL,
	[POReturnCompQTY] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReturn]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReturn](
	[StockReturnID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SupplierID] [bigint] NULL,
	[ActualAmount] [decimal](18, 2) NULL,
	[ApprovedAmount] [decimal](18, 2) NULL,
	[Status] [nvarchar](255) NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[StockReferenceId] [bigint] NULL,
	[ReasonForStockReturn] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReceivedType]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockReceivedType](
	[StrockReceivedTypeID] [int] NOT NULL,
	[SrockReceivedTypeName] [nvarchar](255) NOT NULL,
	[IsDisplay] [nchar](1) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_StockReceivedType] PRIMARY KEY CLUSTERED 
(
	[StrockReceivedTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockReceivedIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockReceivedIDMaster](
	[StockReceivedIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[StockReceivedID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockReceivedIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockReceivedDetails_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReceivedDetails_HIST](
	[StockReceivedDetails_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockReceivedDetailsId] [bigint] NULL,
	[StockReceivedId] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[CategoryId] [int] NULL,
	[ProductId] [bigint] NOT NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](20) NULL,
	[TotalCost] [decimal](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](20) NULL,
	[OrgAddressID] [int] NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 2) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[StockReceivedDate] [datetime] NULL,
	[LocationID] [int] NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[Status] [nvarchar](50) NULL,
	[ExciseTax] [decimal](18, 2) NULL,
	[KitID] [bigint] NULL,
	[ProductKey] [nvarchar](255) NULL,
	[ReferenceID] [nvarchar](30) NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReceivedDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReceivedDetails](
	[StockReceivedDetailsId] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockReceivedId] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](20) NULL,
	[TotalCost] [decimal](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](20) NULL,
	[OrgAddressID] [int] NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 2) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[StockReceivedDate] [datetime] NULL,
	[LocationID] [int] NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[Status] [nvarchar](50) NULL,
	[ExciseTax] [decimal](18, 2) NULL,
	[KitID] [bigint] NULL,
	[ProductKey] [nvarchar](255) NULL,
	[ReferenceID] [nvarchar](30) NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Nominal] [decimal](18, 2) NULL,
	[CostMarginValue] [decimal](18, 6) NULL,
	[SellingMarginValue] [decimal](18, 6) NULL,
	[StockStatus] [int] NULL,
	[Shortage] [decimal](18, 2) NULL,
	[Damage] [decimal](18, 2) NULL,
	[Rejected] [decimal](18, 2) NULL,
	[Comments] [nvarchar](250) NULL,
	[OldProductKey] [nvarchar](510) NULL,
	[NewProductKey] [nvarchar](510) NULL,
	[CP] [decimal](18, 6) NULL,
	[SP] [decimal](18, 6) NULL,
 CONSTRAINT [Pk_StockReceivedDetails_StockReceivedDetailsId] PRIMARY KEY CLUSTERED 
(
	[StockReceivedDetailsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReceivedAttributesDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReceivedAttributesDetails](
	[Details] [bigint] IDENTITY(1,1) NOT NULL,
	[StockReceivedDetailsId] [bigint] NOT NULL,
	[CategorieMappingID] [bigint] NULL,
	[AttributesKey] [nvarchar](100) NULL,
	[AttributesValue] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_StockReceivedAttributesDetails_Details] PRIMARY KEY CLUSTERED 
(
	[Details] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReceived_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReceived_HIST](
	[StockReceived_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockReceivedID] [bigint] NULL,
	[StockReceivedNo] [nvarchar](50) NULL,
	[StockReceivedDate] [datetime] NULL,
	[PurchaseOrderNo] [nvarchar](50) NULL,
	[SupplierID] [int] NULL,
	[OrgID] [int] NULL,
	[FromLocationID] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[Comments] [nvarchar](255) NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[IssuedTO] [bigint] NULL,
	[ToLocationID] [int] NULL,
	[DCNumber] [nvarchar](50) NULL,
	[IndentID] [bigint] NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[StockReceivedTypeID] [int] NULL,
	[CessOnExciseTax] [decimal](18, 2) NULL,
	[HighterEdCessTax] [decimal](18, 2) NULL,
	[CSTax] [decimal](18, 2) NULL,
	[CessOnExciseTaxAmount] [decimal](18, 2) NULL,
	[HighterEdCessTaxAmount] [decimal](18, 2) NULL,
	[CSTAmount] [decimal](18, 2) NULL,
	[ExciseTaxAmount] [decimal](18, 2) NULL,
	[OutFlowID] [bigint] NULL,
	[RoundOfValue] [decimal](18, 2) NULL,
	[RoundOfType] [nvarchar](10) NULL,
	[BillID] [bigint] NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockReceived]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockReceived](
	[StockReceivedID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockReceivedNo] [nvarchar](50) NULL,
	[StockReceivedDate] [datetime] NULL,
	[PurchaseOrderNo] [nvarchar](50) NULL,
	[SupplierID] [int] NULL,
	[OrgID] [int] NULL,
	[FromLocationID] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[Comments] [nvarchar](255) NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[IssuedTO] [bigint] NULL,
	[ToLocationID] [int] NULL,
	[DCNumber] [nvarchar](50) NULL,
	[IndentID] [bigint] NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[StockReceivedTypeID] [int] NULL,
	[CessOnExciseTax] [decimal](18, 2) NULL,
	[HighterEdCessTax] [decimal](18, 2) NULL,
	[CSTax] [decimal](18, 2) NULL,
	[CessOnExciseTaxAmount] [decimal](18, 2) NULL,
	[HighterEdCessTaxAmount] [decimal](18, 2) NULL,
	[CSTAmount] [decimal](18, 2) NULL,
	[ExciseTaxAmount] [decimal](18, 2) NULL,
	[RoundOfValue] [decimal](18, 2) NULL,
	[RoundOfType] [nvarchar](10) NULL,
	[BillID] [bigint] NULL,
	[OutFlowID] [bigint] NULL,
	[NominalDiscount] [decimal](18, 2) NULL,
	[InvoiceDate] [datetime] NULL,
	[NetCalcTax] [nchar](3) NULL,
	[PurchaseOrderID] [bigint] NULL,
	[StatusID] [int] NULL,
	[SupServiceTax] [decimal](18, 2) NULL,
	[PODiscountPer] [decimal](18, 2) NULL,
	[PODiscountAmount] [decimal](18, 2) NULL,
	[SupServiceTaxAmount] [decimal](18, 2) NULL,
	[IndentReceivedID] [bigint] NULL,
	[Remarks] [nvarchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockOutFlowTypes]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockOutFlowTypes](
	[StockOutFlowTypeId] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockOutFlowType] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockOutFlowDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[StockOutFlowDetails](
	[StockOutFlowDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockOutFlowID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [bigint] NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[StockOutFlowDate] [datetime] NULL,
	[LocationID] [int] NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[BatchNo] [nvarchar](50) NULL,
	[DetailID] [bigint] NULL,
	[Type] [nvarchar](20) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[ExpiryDate] [datetime] NULL,
	[ProductKey] [nvarchar](255) NULL,
	[RaiseOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[RaiseOrgAddID] [int] NULL,
	[kitID] [bigint] NULL,
	[MRP] [decimal](18, 2) NULL,
	[TotalCost] [decimal](18, 2) NULL,
	[TotalMRP] [decimal](18, 2) NULL,
	[Taxvalues] [decimal](18, 2) NULL,
	[ExciesDuty] [decimal](18, 2) NULL,
	[CSTax] [decimal](18, 2) NULL,
	[CSTAmount] [decimal](18, 2) NULL,
	[Manufacture] [datetime] NULL,
	[CLocationID] [int] NULL,
	[Discount] [decimal](18, 2) NULL,
	[Discountvalue] [decimal](18, 2) NULL,
	[Returnqty] [decimal](18, 6) NULL,
	[NewProductKey] [nvarchar](510) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StockOutFlow]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[StockOutFlow](
	[StockOutFlowID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockOutFlowNo] [nvarchar](50) NULL,
	[StockOutFlowTypeID] [int] NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [bigint] NULL,
	[BranchID] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[Description] [nvarchar](max) NULL,
	[SupplierID] [int] NULL,
	[ConsumedBy] [nvarchar](100) NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[BillID] [bigint] NULL,
	[LocationID] [int] NULL,
	[ReferenceID] [nvarchar](30) NULL,
	[ReferenceType] [nchar](3) NULL,
	[StockReceivedID] [bigint] NULL,
	[RaiseOrgID] [int] NULL,
	[RaiseOrgAddID] [int] NULL,
	[PrescriptionNo] [nvarchar](30) NULL,
	[StockOutFlowReason] [nvarchar](255) NULL,
	[DCNo] [nvarchar](100) NULL,
	[CustomerID] [bigint] NULL,
	[SalesOrderID] [bigint] NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[CSTax] [decimal](18, 2) NULL,
	[CSTAmount] [decimal](18, 2) NULL,
	[ExciseTaxAmount] [decimal](18, 2) NULL,
	[VAT] [decimal](18, 2) NULL,
	[Surcharge] [decimal](18, 2) NULL,
	[RoundOfValue] [decimal](18, 2) NULL,
	[RoundOfType] [nvarchar](10) NULL,
	[CLocationID] [int] NULL,
	[TotalSales] [decimal](18, 2) NULL,
	[Remarks] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockIssuedIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIssuedIDMaster](
	[StockIssuedIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[StockIssuedID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockIssuedIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockInHand_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockInHand_HIST](
	[StockInHand_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductID] [bigint] NULL,
	[OrgID] [int] NULL,
	[StockInHandID] [bigint] NULL,
	[TotalStockReceived] [decimal](18, 2) NULL,
	[TotalStockIssued] [decimal](18, 2) NULL,
	[TotalStockReturn] [decimal](18, 2) NULL,
	[TotalStockDamage] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[Tax] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[LocationID] [int] NULL,
	[TotalLocationIssued] [decimal](18, 2) NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[TotalUsageLimit] [int] NULL,
	[TotalUsedSoFor] [int] NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[CostPrice] [decimal](18, 6) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[CreatedRole] [bigint] NULL,
 CONSTRAINT [Pk_StockInHand_HIST_StockInHand_HISTID] PRIMARY KEY CLUSTERED 
(
	[StockInHand_HISTID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockInHand]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockInHand](
	[ProductID] [bigint] NULL,
	[OrgID] [int] NULL,
	[TotalStockReceived] [decimal](18, 2) NULL,
	[TotalStockIssued] [decimal](18, 2) NULL,
	[TotalStockReturn] [decimal](18, 2) NULL,
	[TotalStockDamage] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[Tax] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[LocationID] [int] NULL,
	[TotalLocationIssued] [decimal](18, 2) NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[TotalUsageLimit] [int] NULL,
	[TotalUsedSoFor] [int] NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[CostPrice] [decimal](18, 6) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[StockInHandid] [bigint] IDENTITY(1,1) NOT NULL,
	[OldProductkey] [nvarchar](510) NULL,
	[NewProductkey] [nvarchar](510) NULL,
	[Active] [nvarchar](20) NULL,
	[Remarks] [nvarchar](50) NULL,
	[keyval] [nvarchar](50) NULL,
	[Discount] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SellingPriceRuleMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SellingPriceRuleMaster](
	[SellingPriceRuleID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Description] [nvarchar](100) NULL,
	[MinimumPrice] [decimal](18, 2) NOT NULL,
	[MaximumPrice] [decimal](18, 2) NOT NULL,
	[Percentage] [decimal](18, 2) NOT NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SellingPriceRuleLocationMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SellingPriceRuleLocationMapping](
	[MappingID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SellingPriceRuleID] [int] NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL,
	[LocationID] [int] NOT NULL,
	[OrgID] [int] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsDiscountAllow] [nchar](1) NULL,
 CONSTRAINT [Pk_SellingPriceRuleLocationMapping_MappingID] PRIMARY KEY CLUSTERED 
(
	[MappingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReturnDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReturnDetails](
	[SaleReturnDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SaleReturnID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[BatchNo] [nvarchar](255) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[CostPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[ExpiryDate] [datetime] NULL,
	[Unit] [nvarchar](50) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[ParentProductID] [bigint] NULL,
	[LocationID] [int] NULL,
	[CustomerLocationID] [int] NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[StockReceivedID] [bigint] NULL,
	[SalesOutflowDetailsID] [bigint] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[DcNo] [nvarchar](50) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReturn]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReturn](
	[SaleReturnID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[CustomerID] [bigint] NULL,
	[SaleReturnNo] [nvarchar](50) NULL,
	[ActualAmount] [decimal](18, 2) NULL,
	[ApprovedAmount] [decimal](18, 2) NULL,
	[Status] [nvarchar](255) NULL,
	[Type] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[ApprovedBy] [bigint] NULL,
	[ReasonForStockReturn] [nvarchar](250) NULL,
	[CustomerLocationID] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesOrders]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesOrders](
	[SalesOrderID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SalesOrderDate] [datetime] NULL,
	[SalesOrderNo] [nvarchar](50) NULL,
	[OrgID] [int] NOT NULL,
	[CustomerID] [bigint] NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Status] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[Comments] [nvarchar](255) NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[DeliveryDate] [datetime] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[Termsconditions] [nvarchar](max) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[ApprovalStatus] [nvarchar](50) NULL,
	[CLocationID] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesOrderOutFlowDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[SalesOrderOutFlowDetails](
	[SalesOrderOutFlowDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SalesOrderID] [bigint] NOT NULL,
	[StockOutFlowID] [bigint] NOT NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[DCNo] [nvarchar](100) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [bigint] NULL,
	[StockOutFlowDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[LocationID] [int] NULL,
	[RaiseOrgID] [int] NULL,
	[RaiseOrgAddID] [int] NULL,
	[Status] [nvarchar](30) NULL,
	[InvoiceDate] [datetime] NULL,
	[CLocationID] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesOrderDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesOrderDetails](
	[SalesOrderDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SalesOrderId] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[Make] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[OrgAddressID] [int] NULL,
	[SalseStatus] [nvarchar](50) NULL,
	[ParentProductID] [bigint] NULL,
	[IssueQty] [decimal](18, 2) NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[LocationID] [int] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RuleMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RuleMaster](
	[RuleID] [int] IDENTITY(1,1) NOT NULL,
	[TypeID] [int] NULL,
	[MinAmount] [nvarchar](150) NULL,
	[MaxAmount] [nvarchar](150) NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RuleApprovelMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RuleApprovelMaster](
	[RuleApprovelID] [int] IDENTITY(1,1) NOT NULL,
	[RuleID] [int] NULL,
	[SeqNo] [int] NULL,
	[StatusID] [int] NULL,
	[IsActive] [bit] NULL,
	[NextActionID] [int] NULL,
	[OrgID] [int] NULL,
	[NextStatusID] [int] NULL,
	[RoleID] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuotationMaster_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuotationMaster_HIST](
	[Quotation_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[QuotationID] [bigint] NOT NULL,
	[QuotationNo] [nvarchar](50) NULL,
	[ValidFrom] [datetime] NOT NULL,
	[ValidTo] [datetime] NOT NULL,
	[Comments] [nvarchar](250) NULL,
	[Status] [nvarchar](25) NULL,
	[SupplierID] [bigint] NOT NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [nchar](1) NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuotationMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuotationMaster](
	[QuotationID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[QuotationNo] [nvarchar](50) NULL,
	[ValidFrom] [datetime] NOT NULL,
	[ValidTo] [datetime] NOT NULL,
	[Comments] [nvarchar](250) NULL,
	[Status] [nvarchar](25) NULL,
	[SupplierID] [bigint] NOT NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [nchar](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseRequestDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseRequestDetails](
	[RequestDetailID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[PurchaseRequestID] [bigint] NULL,
	[RequestDate] [datetime] NULL,
	[PRStatus] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[SupplierID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[Unit] [nvarchar](50) NULL,
	[Quantity] [bigint] NULL,
	[RaiseOrgID] [int] NULL,
	[RaiseOrgAddID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[Description] [nvarchar](100) NULL,
	[POID] [bigint] NULL,
	[PoDetailsID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseRequest]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseRequest](
	[PurchaseRequestID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[RequestDate] [datetime] NULL,
	[PurchaseRequestNo] [nvarchar](50) NULL,
	[SupplierID] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Comments] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[RaiseOrgID] [int] NULL,
	[RaiseOrgAddID] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseOrders](
	[PurchaseOrderID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[PurchaseOrderDate] [datetime] NULL,
	[PurchaseOrderNo] [nvarchar](50) NULL,
	[OrgID] [int] NOT NULL,
	[SupplierID] [int] NULL,
	[BranchID] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[Comments] [nvarchar](max) NULL,
	[OrgAddressID] [int] NULL,
	[locationID] [int] NULL,
	[ReceivableLocation] [nchar](1) NULL,
	[Charges] [decimal](18, 2) NULL,
	[PoDiscount] [decimal](18, 2) NULL,
	[GrossAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[FreightCharges] [decimal](18, 2) NULL,
	[QuotationID] [bigint] NULL,
	[ProductDiscount] [decimal](18, 2) NOT NULL,
	[ProductTax] [decimal](18, 2) NOT NULL,
	[CFormType] [bit] NULL,
	[StatusID] [int] NULL,
	[IsRate] [bit] NULL,
 CONSTRAINT [Pk_PurchaseOrders_PurchaseOrderID] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseOrderMappingLocation]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[PurchaseOrderMappingLocation](
	[POMappingID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[POID] [bigint] NULL,
	[PODetailsID] [bigint] NULL,
	[DeliveryDate] [datetime] NULL,
	[LocationId] [int] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [datetime] NULL,
	[OrgId] [int] NULL,
	[OrgAddressId] [bigint] NULL,
	[Units] [nvarchar](50) NULL,
	[ProductID] [bigint] NULL,
	[SupplierId] [bigint] NULL,
	[ToLocationID] [int] NULL,
	[TrustedOrgID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[CompQty] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Vat] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseOrderIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderIDMaster](
	[PurchaseOrderIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseOrderDetails_HIST](
	[PurchaseOrderDetails_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[PurchaseOrderDetailsID] [bigint] NOT NULL,
	[PurchaseOrderId] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[OrgAddressID] [int] NULL,
	[POStatus] [nvarchar](50) NULL,
	[locationID] [int] NULL,
	[Totalqty] [bigint] NULL,
	[ParentProductID] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedRole] [bigint] NULL,
 CONSTRAINT [Pk_PurchaseOrderDetails_HIST_PurchaseOrderDetails_HISTID] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderDetails_HISTID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseOrderDetails](
	[PurchaseOrderDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[PurchaseOrderId] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[OrgAddressID] [int] NULL,
	[POStatus] [nvarchar](50) NULL,
	[locationID] [int] NULL,
	[Totalqty] [bigint] NULL,
	[ParentProductID] [bigint] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[InverseQty] [decimal](18, 2) NULL,
 CONSTRAINT [Pk_PurchaseOrderDetails_PurchaseOrderDetailsID] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectionList]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectionList](
	[ProductID] [bigint] NULL,
	[LocationID] [int] NULL,
	[OrgID] [int] NULL,
	[OrgAddressID] [int] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductType](
	[TypeID] [int] NULL,
	[TypeName] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[IsActive] [nvarchar](1) NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductSupplierRateMapping_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductSupplierRateMapping_HIST](
	[ProductMapping_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductMappingID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[SupplierID] [bigint] NOT NULL,
	[Unit] [nvarchar](50) NULL,
	[InverseQty] [bigint] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Orgid] [int] NULL,
	[IsDefault] [nvarchar](50) NULL,
	[Rate] [decimal](18, 2) NULL,
	[TYPE] [nvarchar](15) NULL,
	[ConUnit] [nvarchar](20) NULL,
	[QuotationID] [bigint] NULL,
	[Status] [nvarchar](25) NULL,
	[MRP] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductSupplierRateMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[ProductSupplierRateMapping](
	[ProductMappingID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[SupplierID] [bigint] NOT NULL,
	[Unit] [nvarchar](50) NULL,
	[InverseQty] [bigint] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Orgid] [int] NULL,
	[IsDefault] [nvarchar](50) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Type] [nvarchar](15) NULL,
	[ConUnit] [nvarchar](20) NULL,
	[QuotationID] [bigint] NULL,
	[Status] [nvarchar](25) NULL,
	[MRP] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsAttributesMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsAttributesMaster](
	[AttributeID] [int] IDENTITY(1,1) NOT NULL,
	[AttributeName] [nvarchar](255) NULL,
	[ControlTypeID] [int] NULL,
	[DataType] [nvarchar](50) NULL,
	[ControlLength] [int] NULL,
	[OrgID] [int] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_ProductsAttributesMaster_AttributeID] PRIMARY KEY CLUSTERED 
(
	[AttributeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsAttributesDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsAttributesDetails](
	[DetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NULL,
	[AttributeID] [int] NOT NULL,
	[AttributesKey] [nvarchar](100) NULL,
	[AttributesValue] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_ProductsAttributesDetails_AttributeID] PRIMARY KEY CLUSTERED 
(
	[DetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsAttributes]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[ProductsAttributes](
	[ProductAttributeID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[DrugFrequencyID] [bigint] NOT NULL,
	[DrugInstructionID] [int] NOT NULL,
	[Duration] [nvarchar](100) NULL,
	[Quantity] [decimal](18, 0) NULL,
	[OrgID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifyAt] [datetime] NULL,
	[ModifyBy] [bigint] NULL,
	[DurationType] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products_HIST](
	[Products_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[CategoryID] [int] NOT NULL,
	[OrgID] [int] NOT NULL,
	[Specification1] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ReOrderLevel] [bigint] NULL,
	[IsScheduleHDrug] [nchar](1) NULL,
	[OrgAddressID] [int] NULL,
	[LSU] [nvarchar](50) NULL,
	[HasExpiryDate] [nchar](1) NULL,
	[TypeID] [int] NULL,
	[HasBatchNo] [nchar](1) NULL,
	[HasUsage] [nchar](1) NULL,
	[HasAttributes] [nchar](1) NULL,
	[UsageCount] [int] NULL,
	[Attributes] [nvarchar](max) NULL,
	[MfgName] [nvarchar](50) NULL,
	[MfgCode] [nvarchar](30) NULL,
	[IsDeleted] [nchar](1) NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[ParentProductID] [bigint] NULL,
	[IsNorcotic] [nchar](1) NULL,
	[TransactionBlock] [nchar](1) NULL,
	[ProductCode] [nvarchar](100) NULL,
	[Make] [nvarchar](100) NULL,
	[CreatedRole] [bigint] NULL,
	[OrderedUnit] [nvarchar](255) NULL,
	[OrderedConvertUnit] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductName] [nvarchar](255) NULL,
	[CategoryID] [int] NOT NULL,
	[OrgID] [int] NOT NULL,
	[Specification1] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ReOrderLevel] [bigint] NULL,
	[IsScheduleHDrug] [nchar](1) NULL,
	[OrgAddressID] [int] NULL,
	[LSU] [nvarchar](50) NULL,
	[HasExpiryDate] [nchar](1) NULL,
	[TypeID] [int] NULL,
	[HasBatchNo] [nchar](1) NULL,
	[HasUsage] [nchar](1) NULL,
	[HasAttributes] [nchar](1) NULL,
	[UsageCount] [int] NULL,
	[Attributes] [nvarchar](max) NULL,
	[MfgName] [nvarchar](50) NULL,
	[MfgCode] [nvarchar](30) NULL,
	[IsDeleted] [nchar](1) NULL,
	[ParentProductID] [bigint] NOT NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[IsNorcotic] [nchar](1) NULL,
	[TransactionBlock] [nchar](1) NULL,
	[ProductCode] [nvarchar](100) NULL,
	[Make] [nvarchar](100) NULL,
	[Model] [nvarchar](100) NULL,
	[PSerialNo] [nvarchar](100) NULL,
	[PLocation] [nvarchar](100) NULL,
	[ReminderTemplateID] [bigint] NULL,
	[PreMaintenanceDate] [datetime] NULL,
	[NextMaintenanceDate] [datetime] NULL,
	[ServicerDetails] [nvarchar](600) NULL,
	[HasSerialNo] [nchar](1) NULL,
	[IsLabAnalyzer] [nchar](1) NULL,
	[LTofProduct] [smallint] NULL,
	[ReferenceID] [int] NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[IsDiscountable] [nchar](1) NULL,
	[ProductColour] [nvarchar](10) NULL,
	[CName] [nvarchar](150) NULL,
	[CatName] [nvarchar](200) NULL,
	[OldCategoryID] [bigint] NULL,
	[OrderedUnit] [nvarchar](255) NULL,
	[OrderedConvertUnit] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductMaintenanceRecord]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductMaintenanceRecord](
	[ProductMaintenanceID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductID] [bigint] NULL,
	[CategoryID] [int] NULL,
	[TypeID] [int] NULL,
	[DateOfMaintenance] [datetime] NULL,
	[ProbDetails] [nvarchar](300) NULL,
	[CorrectiveAction] [nvarchar](300) NULL,
	[MaintenanceCost] [decimal](18, 2) NULL,
	[MaintenanceType] [nvarchar](20) NULL,
	[Status] [nvarchar](10) NULL,
	[ActualDateOfMaintenance] [datetime] NULL,
	[ServicerDetails] [nvarchar](400) NULL,
	[ReminderTemplateID] [bigint] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductLocationMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductLocationMapping](
	[ProductLocationMappingID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[LocationID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[ReorderQuantity] [bigint] NULL,
	[Status] [bit] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[MaximumQuantity] [bigint] NULL,
 CONSTRAINT [Pk_ProductLocationMapping_ProductLocationMappingID] PRIMARY KEY CLUSTERED 
(
	[ProductLocationMappingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductEpisodeVisitMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductEpisodeVisitMapping](
	[ProductVisitMapID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[EpisodeVisitId] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[ProductType] [nvarchar](20) NULL,
	[Value] [int] NULL,
	[Guid] [nvarchar](255) NULL,
	[IsDelete] [nvarchar](10) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductCodeMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCodeMaster](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductCode] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
	[OrgID] [int] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[IsDeleted] [nchar](1) NULL,
	[ParentCategorieID] [bigint] NULL,
	[Tax] [decimal](18, 0) NULL,
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[tempcategoryID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PharmacyInventoryIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PharmacyInventoryIDMaster](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PharmacyInventoryID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[LocationID] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PharmacyBillIdMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PharmacyBillIdMaster](
	[OrgID] [int] NULL,
	[BillNumber] [bigint] NULL,
	[rowid] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchingStockReceiveddetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatchingStockReceiveddetails](
	[ViewStockReceivedDetailsId] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ViewStockReceivedId] [bigint] NOT NULL,
	[StockReceivedId] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[Manufacture] [datetime] NULL,
	[POQuantity] [decimal](18, 2) NULL,
	[ComplimentQTY] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[POUnit] [nvarchar](20) NULL,
	[TotalCost] [decimal](18, 2) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[RECQuantity] [decimal](18, 2) NULL,
	[RECUnit] [nvarchar](20) NULL,
	[OrgAddressID] [int] NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[InvoiceQty] [decimal](18, 2) NULL,
	[RcvdLSUQty] [decimal](18, 2) NULL,
	[StockReceivedDate] [datetime] NULL,
	[LocationID] [int] NULL,
	[AttributeDetail] [nvarchar](max) NULL,
	[UnitSellingPrice] [decimal](18, 6) NULL,
	[UnitCostPrice] [decimal](18, 6) NULL,
	[RakNo] [nvarchar](20) NULL,
	[MRP] [decimal](18, 2) NULL,
	[Status] [nvarchar](50) NULL,
	[ExciseTax] [decimal](18, 2) NULL,
	[ProductKey] [nvarchar](510) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MatchingStockReceived]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatchingStockReceived](
	[ViewStockReceivedID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StockReceivedID] [bigint] NULL,
	[StockReceivedNo] [nvarchar](50) NULL,
	[StockReceivedDate] [datetime] NULL,
	[PurchaseOrderNo] [nvarchar](50) NULL,
	[SupplierID] [int] NULL,
	[OrgID] [int] NULL,
	[FromLocationID] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[Comments] [nvarchar](255) NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[PaymentStatus] [nvarchar](50) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[IssuedTO] [bigint] NULL,
	[ToLocationID] [int] NULL,
	[DCNumber] [nvarchar](50) NULL,
	[IndentID] [bigint] NULL,
	[Tax] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[StockReceivedTypeID] [int] NULL,
	[CessOnExciseTax] [decimal](18, 2) NULL,
	[HighterEdCessTax] [decimal](18, 2) NULL,
	[CSTax] [decimal](18, 2) NULL,
	[CessOnExciseTaxAmount] [decimal](18, 2) NULL,
	[HighterEdCessTaxAmount] [decimal](18, 2) NULL,
	[CSTAmount] [decimal](18, 2) NULL,
	[ExciseTaxAmount] [decimal](18, 2) NULL,
	[RoundOfValue] [decimal](18, 2) NULL,
	[RoundOfType] [nvarchar](10) NULL,
	[MatchingInvoice] [nvarchar](50) NULL,
	[StatusID] [int] NULL,
	[PurchaseOrderID] [bigint] NULL,
	[SupServiceTax] [decimal](18, 2) NULL,
	[PODiscountPer] [decimal](18, 2) NULL,
	[PODiscountAmount] [decimal](18, 2) NULL,
	[SupServiceTaxAmount] [decimal](18, 2) NULL,
	[InvoiceDate] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaritalStatus]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaritalStatus](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Code] [nvarchar](25) NULL,
	[DisplayText] [nvarchar](25) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Manufacturer](
	[MfgID] [int] IDENTITY(1,1) NOT NULL,
	[MfgName] [nvarchar](255) NULL,
	[MfgCode] [nvarchar](255) NULL,
	[EMail] [nvarchar](255) NULL,
	[Phone] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationUserMap]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LocationUserMap](
	[LocationUserMapID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[LoginID] [bigint] NOT NULL,
	[LocationID] [int] NOT NULL,
	[OrgAddressID] [int] NOT NULL,
	[OrgID] [int] NOT NULL,
	[IsActive] [nchar](1) NULL,
	[IsDefault] [nchar](1) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
 CONSTRAINT [Pk_LocationUserMap_LocationUserMapID] PRIMARY KEY CLUSTERED 
(
	[LocationUserMapID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationType]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[LocationType](
	[LocationTypeID] [int] NOT NULL,
	[LocationTypeName] [nvarchar](255) NULL,
	[LocationTypeCode] [nvarchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Locations](
	[LocationID] [int] NOT NULL,
	[LocationName] [nvarchar](255) NULL,
	[LocationTypeID] [int] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgAddressID] [int] NULL,
	[IsActive] [nvarchar](1) NULL,
	[ParentLocationID] [int] NULL,
	[ParentLocationTypeID] [int] NULL,
	[TINNO] [nvarchar](50) NULL,
	[DLNO] [nvarchar](50) NULL,
	[LocationCode] [nvarchar](50) NULL,
	[RootLocationID] [int] NULL,
	[IsDefaults] [bit] NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

ALTER TABLE [dbo].[Locations] ADD  CONSTRAINT [Pk_Locations_locationid] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationProductMaping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationProductMaping](
	[LocationID] [bigint] NULL,
	[ProductTypeID] [int] NULL,
	[LocationProductMapID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [Pk_LocationProductMaping_LocationProductMapID] PRIMARY KEY CLUSTERED 
(
	[LocationProductMapID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocationClientMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
 
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localities]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Localities](
	[Locality_ID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Locality_Value] [nvarchar](150) NULL,
	[Type] [nvarchar](50) NULL,
	[NationalityID] [smallint] NULL,
	[ISDCode] [int] NULL,
	[ParentID] [int] NULL,
	[PhoneNo_Length] [int] NULL,
	[Locality_Code] [nvarchar](100) NULL,
	[OrgID] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	 [Code] [nvarchar] (25) NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

ALTER TABLE [dbo].[Localities] ADD  CONSTRAINT [Pk_Localities_Locality_ID] PRIMARY KEY CLUSTERED 
(
	[Locality_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KitStudyDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KitStudyDetails](
	[KitstudyID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[KitID] [nvarchar](100) NULL,
	[KitBacthNo] [nvarchar](100) NULL,
	[StudyID] [bigint] NULL,
	[SiteID] [bigint] NULL,
	[EpisodeVisitId] [bigint] NULL,
	[IndentID] [bigint] NULL,
	[ActualRaiseQty] [int] NULL,
	[RaisedQty] [int] NULL,
	[OrgID] [int] NULL,
	[OrgAddID] [int] NULL,
	[LocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[Status] [nvarchar](100) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KitPrepMasterDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[KitPrepMasterDetails](
	[MasterDetailsID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[KitID] [bigint] NOT NULL,
	[MasterKitID] [bigint] NOT NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[BatchNo] [nvarchar](50) NULL,
	[ExpiryDate] [datetime] NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[ToLocationID] [bigint] NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[IsReimbursable] [nchar](1) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[kitPrepBy] [bigint] NULL,
	[kitPrepAt] [datetime] NULL,
	[ActualQty] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KitPrepMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[KitPrepMaster](
	[KitID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[MasterKitID] [bigint] NOT NULL,
	[ExpiryDate] [datetime] NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[KitBatchNo] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[ToLocationID] [bigint] NULL,
	[comments] [nvarchar](255) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[TaxPercent] [decimal](18, 2) NULL,
	[VisitID] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[ProductKey] [nvarchar](255) NULL,
	[StockOutFlowStatus] [nvarchar](50) NULL,
	[IsBarCodePrinted] [nchar](1) NULL,
	[Quantity] [decimal](18, 2) NULL
) ON [PRIMARY]
SET ANSI_PADDING ON

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KitPatientUsage]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KitPatientUsage](
	[KitPatientUsageID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[VisitID] [bigint] NULL,
	[ReferenceID] [nvarchar](30) NULL,
	[ReferenceType] [nchar](3) NULL,
	[SoldPrice] [decimal](18, 2) NULL,
	[KitID] [bigint] NULL,
	[MasterKitID] [bigint] NULL,
	[KitBatchNo] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[LocationID] [int] NULL,
	[OrgID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[StockOutFlowDetailID] [bigint] NULL,
	[IsReimbursable] [nchar](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KitMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KitMaster](
	[MasterID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[MasterKitID] [bigint] NULL,
	[ProductID] [bigint] NOT NULL,
	[OrgID] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Iscommon] [nchar](1) NULL,
	[IsDelete] [nchar](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryWantedList]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryWantedList](
	[OrgID] [int] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Quantity] [decimal](18, 2) NULL,
	[Unit] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[OrgAddressID] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryUOM]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryUOM](
	[UOMID] [int] NOT NULL,
	[UOMCode] [nvarchar](50) NULL,
	[UOMDescription] [nvarchar](100) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryTaxDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryTaxDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ReferenceType] [nvarchar](100) NULL,
	[ReferenceID] [bigint] NULL,
	[PackingSale] [decimal](18, 2) NULL,
	[ExciseDuty] [decimal](18, 2) NULL,
	[EduCess] [decimal](18, 2) NULL,
	[SecCess] [decimal](18, 2) NULL,
	[CST] [decimal](18, 2) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[Total] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryProductMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryProductMapping](
	[InvestigationId] [bigint] NULL,
	[ProductId] [bigint] NULL,
	[EstimateQty] [decimal](18, 2) NULL,
	[Eunits] [nvarchar](50) NULL,
	[BufferQty] [decimal](18, 2) NULL,
	[Bunits] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryPageMap]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryPageMap](
	[PageMapID] [bigint] NOT NULL,
	[LocationTypeID] [int] NULL,
	[PageID] [bigint] NULL,
	[IsDispay] [nchar](1) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[PageMapID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryLocationsClientMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[InventoryLocationsClientMapping](
	[MappingID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ClientId] [bigint] NULL,
	[LocationID] [bigint] NULL,
	[OrgID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[IsActive] [nchar](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryIDMaster](
	[OrgID] [int] NOT NULL,
	[PurchaseOrderID] [bigint] NULL,
	[StockReceivedID] [bigint] NULL,
	[StockDamageID] [bigint] NULL,
	[StockReturnID] [bigint] NULL,
	[StockIssuedID] [bigint] NULL,
	[StockUsageID] [bigint] NULL,
	[AdhocID] [bigint] NULL,
	[IntendID] [bigint] NULL,
	[MivID] [bigint] NULL,
	[SubStockReturnID] [bigint] NULL,
	[PORID] [bigint] NULL,
	[StockExpiryID] [bigint] NULL,
	[DisposalID] [bigint] NULL,
	[SalesOrderID] [bigint] NULL,
	[InvoiceNo] [bigint] NULL,
	[DCNo] [bigint] NULL,
	[SalesOutFlowID] [bigint] NULL,
	[SalesReturnID] [bigint] NULL,
	[LaundryRefID] [bigint] NULL,
	[CssdRefID] [bigint] NULL,
	[StockTransferID] [bigint] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryConfig]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryConfig](
	[ConfigID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ConfigKey] [nvarchar](max) NOT NULL,
	[ConfigValue] [nvarchar](max) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressId] [bigint] NULL,
	[ConfigKeyID] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryAttributesOrgMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryAttributesOrgMapping](
	[MappingID] [int] IDENTITY(1,1) NOT NULL,
	[AttributeID] [int] NOT NULL,
	[ControlTypeID] [int] NULL,
	[DataType] [nvarchar](50) NULL,
	[ControlLength] [int] NULL,
	[OrgID] [int] NULL,
	[DisplayText] [nvarchar](255) NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[pagetype] [nvarchar](100) NULL,
	[IsMandatory] [bit] NULL,
	[ControlValue] [nvarchar](50) NULL,
	[LangCode] [nvarchar](20) NULL,
	[SeqNo] [int] NULL,
	[ReportID] [int] NULL
 CONSTRAINT [PK_InventoryAttributesOrgMapping_MappingID] PRIMARY KEY CLUSTERED 
(
	[MappingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InventoryAttributesMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InventoryAttributesMaster](
	[AttributeID] [int] IDENTITY(1,1) NOT NULL,
	[AttributeName] [nvarchar](255) NULL,
	[Status] [bit] NULL,
	[IsPreDefined] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ShowColumn] [nvarchar](2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IntendReceivedDetail_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IntendReceivedDetail_HIST](
	[IntendReceivedDetail_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendReceivedDetailID] [bigint] NULL,
	[IntendReceivedID] [bigint] NULL,
	[IntendReceivedDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[FromLocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[BatchNo] [nvarchar](200) NULL,
	[CategoryId] [int] NULL,
	[ExpiryDate] [datetime] NULL,
	[Tax] [decimal](18, 2) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[InvoiceQty] [int] NULL,
	[IssueQty] [decimal](18, 2) NULL,
	[RecdQty] [decimal](18, 2) NULL,
	[IntendIssuedDate] [datetime] NULL,
	[ProductKey] [nvarchar](255) NULL,
	[RaiseOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[RaiseOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](510) NULL,
	[CreatedRole] [bigint] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IntendReceivedDetail]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IntendReceivedDetail](
	[IntendReceivedDetailID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendReceivedID] [bigint] NULL,
	[IntendReceivedDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[FromLocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[BatchNo] [nvarchar](200) NULL,
	[CategoryId] [int] NULL,
	[ExpiryDate] [datetime] NULL,
	[Tax] [decimal](18, 2) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[InvoiceQty] [int] NULL,
	[IssueQty] [decimal](18, 2) NULL,
	[RecdQty] [decimal](18, 2) NULL,
	[IntendIssuedDate] [datetime] NULL,
	[ProductKey] [nvarchar](255) NULL,
	[RaiseOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[RaiseOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](510) NULL,
	[LaundryStatus] [nvarchar](50) NULL,
	[MRP] [decimal](18, 2) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [Pk_IntendReceivedDetail_IntendReceivedDetailID] PRIMARY KEY CLUSTERED 
(
	[IntendReceivedDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IntendReceived_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IntendReceived_HIST](
	[IntendReceived_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendReceivedID] [bigint] NULL,
	[IntendID] [bigint] NULL,
	[IntendIssuedDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[FromLocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[StockOutFlowID] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Comments] [nvarchar](255) NULL,
	[RaiseOrgAddID] [int] NULL,
	[RaiseOrgID] [int] NULL,
	[StockType] [nvarchar](255) NULL,
	[StockReturnReasonType] [int] NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IntendReceived]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IntendReceived](
	[IntendReceivedID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendID] [bigint] NULL,
	[IntendIssuedDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[FromLocationID] [int] NULL,
	[ToLocationID] [int] NULL,
	[StockOutFlowID] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[Comments] [nvarchar](255) NULL,
	[RaiseOrgAddID] [int] NULL,
	[RaiseOrgID] [int] NULL,
	[StockReturnReasonType] [int] NULL,
	[StockType] [nvarchar](255) NULL,
	[IndentReceivedNo] [nvarchar](50) NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](50) NULL,
 CONSTRAINT [Pk_IntendReceived_IntendReceivedID] PRIMARY KEY CLUSTERED 
(
	[IntendReceivedID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IntendDetail_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IntendDetail_HIST](
	[IntendDetail_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendDetailID] [bigint] NULL,
	[IntendID] [bigint] NULL,
	[IntendDetailDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[BatchNo] [nvarchar](200) NULL,
	[CategoryId] [int] NULL,
	[ExpiryDate] [datetime] NULL,
	[Tax] [decimal](18, 2) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[InvoiceQty] [int] NULL,
	[ProductKey] [nvarchar](510) NULL,
	[RaiseOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[RaiseOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](510) NULL,
	[CreatedRole] [bigint] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IntendDetail]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IntendDetail](
	[IntendDetailID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendID] [bigint] NULL,
	[IntendDetailDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[BatchNo] [nvarchar](200) NULL,
	[CategoryId] [int] NULL,
	[ExpiryDate] [datetime] NULL,
	[Tax] [decimal](18, 2) NULL,
	[SellingUnit] [nvarchar](50) NULL,
	[UnitPrice] [decimal](18, 6) NULL,
	[SellingPrice] [decimal](18, 6) NULL,
	[InvoiceQty] [int] NULL,
	[ProductKey] [nvarchar](510) NULL,
	[RaiseOrgID] [int] NULL,
	[ParentProductID] [bigint] NULL,
	[RaiseOrgAddID] [int] NULL,
	[ParentProductKey] [nvarchar](510) NULL,
	[Receivedquantity] [decimal](18, 2) NULL,
	[LaundryStatus] [nvarchar](50) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ToLocationId] [int] NULL,
 CONSTRAINT [Pk_IntendDetail_IntendDetailID] PRIMARY KEY CLUSTERED 
(
	[IntendDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Intend_HIST]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Intend_HIST](
	[Intend_HISTID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendID] [bigint] NULL,
	[IntendDate] [datetime] NULL,
	[IntendNo] [nvarchar](50) NULL,
	[Status] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[Comments] [nvarchar](255) NULL,
	[ToLocationID] [int] NULL,
	[StockOutFlowID] [bigint] NULL,
	[RaiseOrgID] [int] NULL,
	[RaiseOrgAddID] [int] NULL,
	[StockReturnReasonType] [int] NULL,
	[StockType] [nvarchar](255) NULL,
	[CreatedRole] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Intend]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Intend](
	[IntendID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[IntendDate] [datetime] NULL,
	[IntendNo] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](20) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[OrgID] [int] NOT NULL,
	[OrgAddressID] [int] NULL,
	[LocationID] [int] NULL,
	[Comments] [nvarchar](255) NULL,
	[ToLocationID] [int] NULL,
	[StockOutFlowID] [bigint] NULL,
	[RaiseOrgID] [int] NULL,
	[RaiseOrgAddID] [int] NULL,
	[StockReturnReasonType] [int] NULL,
	[StockType] [nvarchar](255) NULL,
	[Minimumshelflife] [int] NULL,
	[DespatchDate] [datetime] NULL,
	[ReferenceNo] [nvarchar](50) NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](50) NULL,
	[IndentType] [nvarchar](255) NULL
 CONSTRAINT [Pk_Intend_IntendID] PRIMARY KEY CLUSTERED 
(
	[IntendID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IndendIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndendIDMaster](
	[IndendIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[IndendID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[IndendIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentMaintenanceMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EquipmentMaintenanceMaster](
	[ReminderTemplateID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Notes] [nvarchar](1000) NULL,
	[Frequency] [nvarchar](10) NULL,
	[Orgid] [int] NULL,
	[PreMaintenanceDate] [datetime] NULL,
	[NextMaintenanceDate] [datetime] NULL,
	[AmcProvider] [nvarchar](1000) NULL,
	[StockReceivedDetailsId] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[Status] [nvarchar](20) NULL,
	[SerialNo] [nvarchar](200) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EpisodeVisitDetails]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EpisodeVisitDetails](
	[EpisodeVisitId] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[EpisodeID] [bigint] NOT NULL,
	[EpisodeVisitName] [nvarchar](100) NULL,
	[FeeID] [bigint] NULL,
	[FeeType] [nvarchar](10) NULL,
	[TimedType] [nvarchar](10) NULL,
	[TimedNo] [int] NULL,
	[EpisodeVisitNumber] [int] NULL,
	[IsMandatory] [nvarchar](3) NULL,
	[PackageDetails] [nvarchar](max) NULL,
	[OrgID] [int] NULL,
	[VisitType] [int] NULL,
	[IsDelete] [nvarchar](10) NULL,
	[Guid] [nvarchar](255) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DrugGeneric]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[DrugGeneric](
	[GenericID] [bigint] NOT NULL,
	[StdDose] [nvarchar](10) NULL,
	[MinDose] [nvarchar](10) NULL,
	[OptDose] [nvarchar](10) NULL,
	[DoseperKg] [nvarchar](10) NULL,
	[GenericName] [nvarchar](50) NULL,
	[Pregnency] [nchar](1) NULL,
	[Lactation] [nchar](1) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
 CONSTRAINT [UQ_DrugGeneric_GenericID_GenericName] UNIQUE NONCLUSTERED 
(
	[GenericName] ASC,
	[GenericID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_DrugGeneric_GenericName] UNIQUE NONCLUSTERED 
(
	[GenericName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DrugFormulation]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[DrugFormulation](
	[FMID] [int] NULL,
	[FMName] [nvarchar](50) NULL,
	[DisplayText] [nvarchar](50) NULL,
	[DisplayPlace] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [UQ_DrugFormulation_FMID_FMName] UNIQUE NONCLUSTERED 
(
	[FMID] ASC,
	[FMName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_DrugFormulation_FMName] UNIQUE NONCLUSTERED 
(
	[FMName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DrugBrand]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DrugBrand](
	[DrugID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[GenericID] [bigint] NULL,
	[BrandName] [nvarchar](500) NULL,
	[Strength] [nvarchar](100) NULL,
	[AvailableDose] [nvarchar](100) NULL,
	[FMID] [int] NULL,
	[IsApproved] [nchar](1) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [int] NULL
) ON [PRIMARY]
SET ANSI_PADDING OFF

ALTER TABLE [dbo].[DrugBrand] ADD  CONSTRAINT [Pk_DrugBrand_DrugID] PRIMARY KEY CLUSTERED 
(
	[DrugID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
ALTER TABLE [dbo].[DrugBrand] ADD  CONSTRAINT [UQ_DrugBrand_BrandName_FMID] UNIQUE NONCLUSTERED 
(
	[BrandName] ASC,
	[FMID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Drafts]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Drafts](
	[DraftID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrgID] [bigint] NULL,
	[LocationId] [bigint] NULL,
	[PageID] [int] NULL,
	[LoginID] [bigint] NULL,
	[DraftType] [nvarchar](255) NULL,
	[DraftValue] [nvarchar](255) NULL,
	[Data] [nvarchar](max) NULL
PRIMARY KEY CLUSTERED 
(
	[DraftID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlValueMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlValueMaster](
	[ControlValueID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ControlMappingID] [bigint] NULL,
	[ControlValue] [nvarchar](50) NULL,
	[IsTableReference] [nchar](3) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlTypeMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlTypeMaster](
	[ControlTypeID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ControlName] [nvarchar](30) NULL,
	[ControlCode] [nvarchar](10) NULL,
	[IsEnable] [nchar](1) NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlOrgMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlOrgMapping](
	[ControlMappingID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ControlTypeID] [int] NULL,
	[DisplayText] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[ReferenceID] [bigint] NULL,
	[ReferenceType] [nvarchar](10) NULL,
	[SequenceNo] [int] NULL,
	[createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CategorieAttributesMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategorieAttributesMapping](
	[CategorieMappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[AttributeID] [int] NULL,
	[OrgID] [int] NULL,
	[IsMandatory] [bit] NULL,
	[Status] [bit] NULL,
	[Createdat] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[SeqNo] [int] NULL,
 CONSTRAINT [PK_CategorieAttributesMapping_MappingID] PRIMARY KEY CLUSTERED 
(
	[CategorieMappingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Audit_ProductSupplierRateMapping]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Audit_ProductSupplierRateMapping](
	[AuditProductMappingID] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[SupplierID] [bigint] NOT NULL,
	[Unit] [nvarchar](50) NULL,
	[InverseQty] [bigint] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Orgid] [int] NULL,
	[IsDefault] [nvarchar](50) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Type] [nvarchar](15) NULL,
	[ConUnit] [nvarchar](20) NULL,
	[ProductMappingID] [bigint] NOT NULL,
	[Audit_Createdby] [bigint] NULL,
	[Audit_CreatedAt] [datetime] NULL,
	[Status] [nvarchar](25) NULL,
	[QuotationID] [bigint] NULL,
	[MRP] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ApprovalMechanismStatus]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApprovalMechanismStatus](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ReferenceID] [bigint] NULL,
	[RuleID] [int] NULL,
	[TypeID] [int] NULL,
	[RoleID] [bigint] NULL,
	[StatusID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ApprovedBy] [bigint] NULL,
	[ApprovedAt] [datetime] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[SeqNo] [int] NULL,
	[TaskId] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdhocIDMaster]    Script Date: 09/01/2015 19:39:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdhocIDMaster](
	[AdhocIDMasterID] [int] IDENTITY(1,1) NOT NULL,
	[AdhocID] [bigint] NULL,
	[OrgID] [int] NULL,
	[LocationID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[AdhocIDMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MedicalExpenses]    Script Date: 08/14/2015 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalExpenses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MedicalExpenses](
	[MedicalExpenseID] [bigint] IDENTITY(1,1) NOT NULL,
	[FamilyDetailsID] [bigint] NULL,
	[MemberDetailID] [bigint] NULL,
	[ExpenseType] [nvarchar](10) NULL,
	[Expense] [decimal](18, 2) NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL
) ON [PRIMARY]
END
GO

/****** Object:  Table [dbo].[CertificateInfo]    Script Date: 08/14/2015 14:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CertificateInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CertificateInfo](
	[CertificateInfoID] [bigint] IDENTITY(1,1) NOT NULL,
	[MemberDetailsID] [bigint] NULL,
	[CertificateTypeID] [int] NULL,
	[Value] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CertificateDate] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Default [DF_Audit_ProductSupplierRateMapping_Rate]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] ADD  CONSTRAINT [DF_Audit_ProductSupplierRateMapping_Rate]  DEFAULT ((0.00)) FOR [Rate]
GO
/****** Object:  Default [DF_Audit_ProductSupplierRateMapping_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] ADD  CONSTRAINT [DF_Audit_ProductSupplierRateMapping_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_Audit_ProductSupplierRateMapping_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] ADD  CONSTRAINT [DF_Audit_ProductSupplierRateMapping_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_Audit_ProductSupplierRateMapping_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] ADD  CONSTRAINT [DF_Audit_ProductSupplierRateMapping_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_Audit_ProductSupplierRateMapping_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Audit_ProductSupplierRateMapping] ADD  CONSTRAINT [DF_Audit_ProductSupplierRateMapping_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [Def_CategorieAttributesMapping_IsMandatory]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[CategorieAttributesMapping] ADD  CONSTRAINT [Def_CategorieAttributesMapping_IsMandatory]  DEFAULT ((1)) FOR [IsMandatory]
GO
/****** Object:  Default [Def_CategorieAttributesMapping_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[CategorieAttributesMapping] ADD  CONSTRAINT [Def_CategorieAttributesMapping_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF__ControlTy__IsEna__0F975522]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ControlTypeMaster] ADD  CONSTRAINT [DF__ControlTy__IsEna__2FFDFBC6]  DEFAULT ('Y') FOR [IsEnable]
GO
/****** Object:  Default [DF__EpisodeVi__IsDel__1ED998B2]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[EpisodeVisitDetails] ADD  CONSTRAINT [DF__EpisodeVi__IsDel__162F4418]  DEFAULT ('N') FOR [IsDelete]
GO
/****** Object:  Default [DF_IntendDetail_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail] ADD  CONSTRAINT [DF_IntendDetail_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_IntendDetail_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail] ADD  CONSTRAINT [DF_IntendDetail_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_IntendDetail_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail] ADD  CONSTRAINT [DF_IntendDetail_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_IntendDetail_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail] ADD  CONSTRAINT [DF_IntendDetail_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_IntendDetail_Receivedquantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail] ADD  CONSTRAINT [DF_IntendDetail_Receivedquantity]  DEFAULT ((0.00)) FOR [Receivedquantity]
GO
/****** Object:  Default [DF_IntendDetail_HIST_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail_HIST] ADD  CONSTRAINT [DF_IntendDetail_HIST_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_IntendDetail_HIST_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail_HIST] ADD  CONSTRAINT [DF_IntendDetail_HIST_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_IntendDetail_HIST_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail_HIST] ADD  CONSTRAINT [DF_IntendDetail_HIST_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_IntendDetail_HIST_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendDetail_HIST] ADD  CONSTRAINT [DF_IntendDetail_HIST_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_IntendReceivedDetail_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF_IntendReceivedDetail_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_IntendReceivedDetail_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF_IntendReceivedDetail_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_IntendReceivedDetail_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF_IntendReceivedDetail_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_IntendReceivedDetail_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF_IntendReceivedDetail_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_IntendReceivedDetail_IssueQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF_IntendReceivedDetail_IssueQty]  DEFAULT ((0.00)) FOR [IssueQty]
GO
/****** Object:  Default [DF_IntendReceivedDetail_RecdQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF_IntendReceivedDetail_RecdQty]  DEFAULT ((0.00)) FOR [RecdQty]
GO
/****** Object:  Default [DF__IntendRec__Produ__3B75D760]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail] ADD  CONSTRAINT [DF__IntendRec__Produ__1229A90A]  DEFAULT ('') FOR [ProductKey]
GO
/****** Object:  Default [DF_IntendReceivedDetail_HIST_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] ADD  CONSTRAINT [DF_IntendReceivedDetail_HIST_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_IntendReceivedDetail_HIST_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] ADD  CONSTRAINT [DF_IntendReceivedDetail_HIST_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_IntendReceivedDetail_HIST_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] ADD  CONSTRAINT [DF_IntendReceivedDetail_HIST_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_IntendReceivedDetail_HIST_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] ADD  CONSTRAINT [DF_IntendReceivedDetail_HIST_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_IntendReceivedDetail_HIST_IssueQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] ADD  CONSTRAINT [DF_IntendReceivedDetail_HIST_IssueQty]  DEFAULT ((0.00)) FOR [IssueQty]
GO
/****** Object:  Default [DF_IntendReceivedDetail_HIST_RecdQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[IntendReceivedDetail_HIST] ADD  CONSTRAINT [DF_IntendReceivedDetail_HIST_RecdQty]  DEFAULT ((0.00)) FOR [RecdQty]
GO
/****** Object:  Default [Def_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryAttributesMaster] ADD  CONSTRAINT [Def_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [Def_InventoryAttributesMaster_IsPreDefined]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryAttributesMaster] ADD  CONSTRAINT [Def_InventoryAttributesMaster_IsPreDefined]  DEFAULT ((1)) FOR [IsPreDefined]
GO
/****** Object:  Default [Def_InventoryAttributesOrgMapping_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryAttributesOrgMapping] ADD  CONSTRAINT [Def_InventoryAttributesOrgMapping_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [Def_InventoryAttributesOrgMapping_IsMandatory]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryAttributesOrgMapping] ADD  CONSTRAINT [Def_InventoryAttributesOrgMapping_IsMandatory]  DEFAULT ((1)) FOR [IsMandatory]
GO
/****** Object:  Default [DF_InventoryProductMapping_EstimateQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryProductMapping] ADD  CONSTRAINT [DF_InventoryProductMapping_EstimateQty]  DEFAULT ((0.00)) FOR [EstimateQty]
GO
/****** Object:  Default [DF_InventoryProductMapping_BufferQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryProductMapping] ADD  CONSTRAINT [DF_InventoryProductMapping_BufferQty]  DEFAULT ((0.00)) FOR [BufferQty]
GO
/****** Object:  Default [DF_InventoryWantedList_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[InventoryWantedList] ADD  CONSTRAINT [DF_InventoryWantedList_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_KitMaster_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitMaster] ADD  CONSTRAINT [DF_KitMaster_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_KitPatientUsage_SoldPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPatientUsage] ADD  CONSTRAINT [DF_KitPatientUsage_SoldPrice]  DEFAULT ((0.00)) FOR [SoldPrice]
GO
/****** Object:  Default [DF_KitPrepMaster_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMaster] ADD  CONSTRAINT [DF_KitPrepMaster_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_KitPrepMaster_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMaster] ADD  CONSTRAINT [DF_KitPrepMaster_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_KitPrepMaster_TaxPercent]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMaster] ADD  CONSTRAINT [DF_KitPrepMaster_TaxPercent]  DEFAULT ((0.00)) FOR [TaxPercent]
GO
/****** Object:  Default [DF__KitPrepMa__Produ__4668671F]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[KitPrepMaster] ADD  CONSTRAINT [DF__KitPrepMa__Produ__4668671F]  DEFAULT ('') FOR [ProductKey]
GO
/****** Object:  Default [DF__KitPrepMa__Quant__475C8B58]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[KitPrepMaster] ADD  CONSTRAINT [DF__KitPrepMa__Quant__475C8B58]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_KitPrepMasterDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMasterDetails] ADD  CONSTRAINT [DF_KitPrepMasterDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_KitPrepMasterDetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMasterDetails] ADD  CONSTRAINT [DF_KitPrepMasterDetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_KitPrepMasterDetails_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMasterDetails] ADD  CONSTRAINT [DF_KitPrepMasterDetails_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_KitPrepMasterDetails_TaxPercent]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMasterDetails] ADD  CONSTRAINT [DF_KitPrepMasterDetails_TaxPercent]  DEFAULT ((0.00)) FOR [TaxPercent]
GO
/****** Object:  Default [DF__KitPrepMa__Produ__4944D3CA]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[KitPrepMasterDetails] ADD  CONSTRAINT [DF__KitPrepMa__Produ__4944D3CA]  DEFAULT ('') FOR [ProductKey]
GO
/****** Object:  Default [DF_KitPrepMasterDetails_ActualQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[KitPrepMasterDetails] ADD  CONSTRAINT [DF_KitPrepMasterDetails_ActualQty]  DEFAULT ((0.00)) FOR [ActualQty]
GO
/****** Object:  Default [LCM_IsDefaultLocClient]    Script Date: 09/01/2015 19:39:30 ******/
 GO
/****** Object:  Default [DF_MatchingStockReceived_PaidAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_PaidAmount]  DEFAULT ((0.00)) FOR [PaidAmount]
GO
/****** Object:  Default [DF_MatchingStockReceived_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_MatchingStockReceived_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_MatchingStockReceived_GrandTotal]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
/****** Object:  Default [DF_MatchingStockReceived_CessOnExciseTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_CessOnExciseTax]  DEFAULT ((0.00)) FOR [CessOnExciseTax]
GO
/****** Object:  Default [DF_MatchingStockReceived_HighterEdCessTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_HighterEdCessTax]  DEFAULT ((0.00)) FOR [HighterEdCessTax]
GO
/****** Object:  Default [DF_MatchingStockReceived_CSTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_CSTax]  DEFAULT ((0.00)) FOR [CSTax]
GO
/****** Object:  Default [DF_MatchingStockReceived_CessOnExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_CessOnExciseTaxAmount]  DEFAULT ((0.00)) FOR [CessOnExciseTaxAmount]
GO
/****** Object:  Default [DF_MatchingStockReceived_HighterEdCessTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_HighterEdCessTaxAmount]  DEFAULT ((0.00)) FOR [HighterEdCessTaxAmount]
GO
/****** Object:  Default [DF_MatchingStockReceived_CSTAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_CSTAmount]  DEFAULT ((0.00)) FOR [CSTAmount]
GO
/****** Object:  Default [DF_MatchingStockReceived_ExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_ExciseTaxAmount]  DEFAULT ((0.00)) FOR [ExciseTaxAmount]
GO
/****** Object:  Default [DF_MatchingStockReceived_RoundOfValue]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceived] ADD  CONSTRAINT [DF_MatchingStockReceived_RoundOfValue]  DEFAULT ((0.00)) FOR [RoundOfValue]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_POQuantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_POQuantity]  DEFAULT ((0.00)) FOR [POQuantity]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_ComplimentQTY]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_ComplimentQTY]  DEFAULT ((0.00)) FOR [ComplimentQTY]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_TotalCost]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_TotalCost]  DEFAULT ((0.00)) FOR [TotalCost]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_RECQuantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_RECQuantity]  DEFAULT ((0.00)) FOR [RECQuantity]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_InvoiceQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_InvoiceQty]  DEFAULT ((0.00)) FOR [InvoiceQty]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_RcvdLSUQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_RcvdLSUQty]  DEFAULT ((0.00)) FOR [RcvdLSUQty]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_UnitSellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_UnitSellingPrice]  DEFAULT ((0.00)) FOR [UnitSellingPrice]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_UnitCostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_UnitCostPrice]  DEFAULT ((0.00)) FOR [UnitCostPrice]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_MatchingStockReceiveddetails_ExciseTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[MatchingStockReceiveddetails] ADD  CONSTRAINT [DF_MatchingStockReceiveddetails_ExciseTax]  DEFAULT ((0.00)) FOR [ExciseTax]
GO
/****** Object:  Default [DF__ProductEp__IsDel__4999D985]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[ProductEpisodeVisitMapping] ADD  CONSTRAINT [DF__ProductEp__IsDel__4999D985]  DEFAULT ('N') FOR [IsDelete]
GO
/****** Object:  Default [Def_ProductLocationMapping_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductLocationMapping] ADD  CONSTRAINT [Def_ProductLocationMapping_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ProductMaintenanceRecord_MaintenanceCost]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductMaintenanceRecord] ADD  CONSTRAINT [DF_ProductMaintenanceRecord_MaintenanceCost]  DEFAULT ((0.00)) FOR [MaintenanceCost]
GO
/****** Object:  Default [DF_Products_TaxPercent]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_TaxPercent]  DEFAULT ((0.00)) FOR [TaxPercent]
GO
/****** Object:  Default [DF__Products__IsDisc__300650C0]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF__Products__IsDisc__300650C0]  DEFAULT ('N') FOR [IsDiscountable]
GO
/****** Object:  Default [DF_Products_HIST_TaxPercent]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[Products_HIST] ADD  CONSTRAINT [DF_Products_HIST_TaxPercent]  DEFAULT ((0.00)) FOR [TaxPercent]
GO
/****** Object:  Default [Def_ProductsAttributesDetails_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductsAttributesDetails] ADD  CONSTRAINT [Def_ProductsAttributesDetails_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [Def_ProductsAttributesMaster_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductsAttributesMaster] ADD  CONSTRAINT [Def_ProductsAttributesMaster_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_Rate]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_Rate]  DEFAULT ((0.00)) FOR [Rate]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_HIST_Rate]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_HIST_Rate]  DEFAULT ((0.00)) FOR [Rate]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_HIST_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_HIST_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_HIST_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_HIST_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_HIST_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_HIST_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_ProductSupplierRateMapping_HIST_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProductSupplierRateMapping_HIST] ADD  CONSTRAINT [DF_ProductSupplierRateMapping_HIST_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_ProjectionList_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[ProjectionList] ADD  CONSTRAINT [DF_ProjectionList_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_PurchaseOrderDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderDetails] ADD  CONSTRAINT [DF_PurchaseOrderDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_PurchaseOrderDetails_HIST_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderDetails_HIST] ADD  CONSTRAINT [DF_PurchaseOrderDetails_HIST_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_PurchaseOrderMappingLocation_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF_PurchaseOrderMappingLocation_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_PurchaseOrderMappingLocation_CompQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF_PurchaseOrderMappingLocation_CompQty]  DEFAULT ((0.00)) FOR [CompQty]
GO
/****** Object:  Default [DF_PurchaseOrderMappingLocation_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF_PurchaseOrderMappingLocation_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_PurchaseOrderMappingLocation_Vat]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF_PurchaseOrderMappingLocation_Vat]  DEFAULT ((0.00)) FOR [Vat]
GO
/****** Object:  Default [DF_PurchaseOrderMappingLocation_Amount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF_PurchaseOrderMappingLocation_Amount]  DEFAULT ((0.00)) FOR [Amount]
GO
/****** Object:  Default [DF_PurchaseOrderMappingLocation_Rate]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF_PurchaseOrderMappingLocation_Rate]  DEFAULT ((0.00)) FOR [Rate]
GO
/****** Object:  Default [DF__PurchaseO__Selli__2D218F1B]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[PurchaseOrderMappingLocation] ADD  CONSTRAINT [DF__PurchaseO__Selli__2D218F1B]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_PurchaseOrders_Charges]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF_PurchaseOrders_Charges]  DEFAULT ((0.00)) FOR [Charges]
GO
/****** Object:  Default [DF_PurchaseOrders_PoDiscount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF_PurchaseOrders_PoDiscount]  DEFAULT ((0.00)) FOR [PoDiscount]
GO
/****** Object:  Default [DF_PurchaseOrders_GrossAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF_PurchaseOrders_GrossAmount]  DEFAULT ((0.00)) FOR [GrossAmount]
GO
/****** Object:  Default [DF_PurchaseOrders_NetAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF_PurchaseOrders_NetAmount]  DEFAULT ((0.00)) FOR [NetAmount]
GO
/****** Object:  Default [DF_PurchaseOrders_FreightCharges]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF_PurchaseOrders_FreightCharges]  DEFAULT ((0.00)) FOR [FreightCharges]
GO
/****** Object:  Default [DF__PurchaseO__Produ__2E15B354]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF__PurchaseO__Produ__2E15B354]  DEFAULT ((0.00)) FOR [ProductDiscount]
GO
/****** Object:  Default [DF__PurchaseO__Produ__2F09D78D]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF__PurchaseO__Produ__2F09D78D]  DEFAULT ((0.00)) FOR [ProductTax]
GO
/****** Object:  Default [DF_SalesOrderDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesOrderDetails] ADD  CONSTRAINT [DF_SalesOrderDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_SalesOrderDetails_IssueQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesOrderDetails] ADD  CONSTRAINT [DF_SalesOrderDetails_IssueQty]  DEFAULT ((0.00)) FOR [IssueQty]
GO
/****** Object:  Default [DF_SalesOrderDetails_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesOrderDetails] ADD  CONSTRAINT [DF_SalesOrderDetails_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_SalesOrderDetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesOrderDetails] ADD  CONSTRAINT [DF_SalesOrderDetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_SalesOrderDetails_TotalAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesOrderDetails] ADD  CONSTRAINT [DF_SalesOrderDetails_TotalAmount]  DEFAULT ((0.00)) FOR [TotalAmount]
GO
/****** Object:  Default [DF_SalesOrders_GrandTotal]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesOrders] ADD  CONSTRAINT [DF_SalesOrders_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
/****** Object:  Default [DF_SalesReturn_ActualAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesReturn] ADD  CONSTRAINT [DF_SalesReturn_ActualAmount]  DEFAULT ((0.00)) FOR [ActualAmount]
GO
/****** Object:  Default [DF_SalesReturn_ApprovedAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesReturn] ADD  CONSTRAINT [DF_SalesReturn_ApprovedAmount]  DEFAULT ((0.00)) FOR [ApprovedAmount]
GO
/****** Object:  Default [DF_SalesReturnDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesReturnDetails] ADD  CONSTRAINT [DF_SalesReturnDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_SalesReturnDetails_CostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesReturnDetails] ADD  CONSTRAINT [DF_SalesReturnDetails_CostPrice]  DEFAULT ((0.00)) FOR [CostPrice]
GO
/****** Object:  Default [DF_SalesReturnDetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SalesReturnDetails] ADD  CONSTRAINT [DF_SalesReturnDetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_StockInHand_TotalStockReceived]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_TotalStockReceived]  DEFAULT ((0)) FOR [TotalStockReceived]
GO
/****** Object:  Default [DF_StockInHand_TotalStockIssued]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_TotalStockIssued]  DEFAULT ((0)) FOR [TotalStockIssued]
GO
/****** Object:  Default [DF_StockInHand_TotalStockReturn]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_TotalStockReturn]  DEFAULT ((0)) FOR [TotalStockReturn]
GO
/****** Object:  Default [DF_StockInHand_TotalStockDamage]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_TotalStockDamage]  DEFAULT ((0)) FOR [TotalStockDamage]
GO
/****** Object:  Default [DF_StockInHand_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockInHand_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_StockInHand_TotalLocationIssued]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_TotalLocationIssued]  DEFAULT ((0)) FOR [TotalLocationIssued]
GO
/****** Object:  Default [DF_StockInHand_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_StockInHand_CostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand] ADD  CONSTRAINT [DF_StockInHand_CostPrice]  DEFAULT ((0.00)) FOR [CostPrice]
GO
/****** Object:  Default [DF_StockInHand_HIST_TotalStockReceived]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_TotalStockReceived]  DEFAULT ((0.00)) FOR [TotalStockReceived]
GO
/****** Object:  Default [DF_StockInHand_HIST_TotalStockIssued]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_TotalStockIssued]  DEFAULT ((0.00)) FOR [TotalStockIssued]
GO
/****** Object:  Default [DF_StockInHand_HIST_TotalStockReturn]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_TotalStockReturn]  DEFAULT ((0.00)) FOR [TotalStockReturn]
GO
/****** Object:  Default [DF_StockInHand_HIST_TotalStockDamage]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_TotalStockDamage]  DEFAULT ((0.00)) FOR [TotalStockDamage]
GO
/****** Object:  Default [DF_StockInHand_HIST_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockInHand_HIST_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_StockInHand_HIST_TotalLocationIssued]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_TotalLocationIssued]  DEFAULT ((0.00)) FOR [TotalLocationIssued]
GO
/****** Object:  Default [DF_StockInHand_HIST_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_StockInHand_HIST_CostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockInHand_HIST] ADD  CONSTRAINT [DF_StockInHand_HIST_CostPrice]  DEFAULT ((0.00)) FOR [CostPrice]
GO
/****** Object:  Default [DF__StockOutF__Presc__1A55A60E]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF__StockOutF__Presc__1A55A60E]  DEFAULT ('0') FOR [PrescriptionNo]
GO
/****** Object:  Default [DF_StockOutFlow_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockOutFlow_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_StockOutFlow_GrandTotal]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
/****** Object:  Default [DF_StockOutFlow_CSTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_CSTax]  DEFAULT ((0.00)) FOR [CSTax]
GO
/****** Object:  Default [DF_StockOutFlow_CSTAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_CSTAmount]  DEFAULT ((0.00)) FOR [CSTAmount]
GO
/****** Object:  Default [DF_StockOutFlow_ExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_ExciseTaxAmount]  DEFAULT ((0.00)) FOR [ExciseTaxAmount]
GO
/****** Object:  Default [DF_StockOutFlow_VAT]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_VAT]  DEFAULT ((0.00)) FOR [VAT]
GO
/****** Object:  Default [DF_StockOutFlow_Surcharge]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_Surcharge]  DEFAULT ((0.00)) FOR [Surcharge]
GO
/****** Object:  Default [DF_StockOutFlow_RoundOfValue]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_RoundOfValue]  DEFAULT ((0.00)) FOR [RoundOfValue]
GO
/****** Object:  Default [DF_StockOutFlow_TotalSales]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlow] ADD  CONSTRAINT [DF_StockOutFlow_TotalSales]  DEFAULT ((0.00)) FOR [TotalSales]
GO
/****** Object:  Default [DF_StockOutFlowDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_StockOutFlowDetails_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_StockOutFlowDetails_TaxPercent]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_TaxPercent]  DEFAULT ((0.00)) FOR [TaxPercent]
GO
/****** Object:  Default [DF_StockOutFlowDetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF__StockOutF__Produ__1C3DEE80]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF__StockOutF__Produ__1C3DEE80]  DEFAULT ('') FOR [ProductKey]
GO
/****** Object:  Default [DF_StockOutFlowDetails_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_StockOutFlowDetails_TotalCost]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_TotalCost]  DEFAULT ((0.00)) FOR [TotalCost]
GO
/****** Object:  Default [DF_StockOutFlowDetails_TotalMRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_TotalMRP]  DEFAULT ((0.00)) FOR [TotalMRP]
GO
/****** Object:  Default [DF_StockOutFlowDetails_Taxvalues]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_Taxvalues]  DEFAULT ((0.00)) FOR [Taxvalues]
GO
/****** Object:  Default [DF_StockOutFlowDetails_ExciesDuty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_ExciesDuty]  DEFAULT ((0.00)) FOR [ExciesDuty]
GO
/****** Object:  Default [DF_StockOutFlowDetails_CSTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_CSTax]  DEFAULT ((0.00)) FOR [CSTax]
GO
/****** Object:  Default [DF_StockOutFlowDetails_CSTAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_CSTAmount]  DEFAULT ((0.00)) FOR [CSTAmount]
GO
/****** Object:  Default [DF_StockOutFlowDetails_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_StockOutFlowDetails_Discountvalue]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_Discountvalue]  DEFAULT ((0.00)) FOR [Discountvalue]
GO
/****** Object:  Default [DF_StockOutFlowDetails_Returnqty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockOutFlowDetails] ADD  CONSTRAINT [DF_StockOutFlowDetails_Returnqty]  DEFAULT ((0.00)) FOR [Returnqty]
GO
/****** Object:  Default [DF_StockReceived_PaidAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_PaidAmount]  DEFAULT ((0)) FOR [PaidAmount]
GO
/****** Object:  Default [DF_StockReceived_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockReceived_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_StockReceived_GrandTotal]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
/****** Object:  Default [DF_StockReceived_CessOnExciseTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_CessOnExciseTax]  DEFAULT ((0.00)) FOR [CessOnExciseTax]
GO
/****** Object:  Default [DF_StockReceived_HighterEdCessTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_HighterEdCessTax]  DEFAULT ((0.00)) FOR [HighterEdCessTax]
GO
/****** Object:  Default [DF_StockReceived_CSTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_CSTax]  DEFAULT ((0.00)) FOR [CSTax]
GO
/****** Object:  Default [DF_StockReceived_CessOnExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_CessOnExciseTaxAmount]  DEFAULT ((0.00)) FOR [CessOnExciseTaxAmount]
GO
/****** Object:  Default [DF_StockReceived_HighterEdCessTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_HighterEdCessTaxAmount]  DEFAULT ((0.00)) FOR [HighterEdCessTaxAmount]
GO
/****** Object:  Default [DF_StockReceived_CSTAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_CSTAmount]  DEFAULT ((0.00)) FOR [CSTAmount]
GO
/****** Object:  Default [DF_StockReceived_ExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_ExciseTaxAmount]  DEFAULT ((0.00)) FOR [ExciseTaxAmount]
GO
/****** Object:  Default [DF_StockReceived_RoundOfValue]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived] ADD  CONSTRAINT [DF_StockReceived_RoundOfValue]  DEFAULT ((0.00)) FOR [RoundOfValue]
GO
/****** Object:  Default [DF_StockReceived_HIST_PaidAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_PaidAmount]  DEFAULT ((0.00)) FOR [PaidAmount]
GO
/****** Object:  Default [DF_StockReceived_HIST_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockReceived_HIST_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_StockReceived_HIST_GrandTotal]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
/****** Object:  Default [DF_StockReceived_HIST_CessOnExciseTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_CessOnExciseTax]  DEFAULT ((0.00)) FOR [CessOnExciseTax]
GO
/****** Object:  Default [DF_StockReceived_HIST_HighterEdCessTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_HighterEdCessTax]  DEFAULT ((0.00)) FOR [HighterEdCessTax]
GO
/****** Object:  Default [DF_StockReceived_HIST_CSTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_CSTax]  DEFAULT ((0.00)) FOR [CSTax]
GO
/****** Object:  Default [DF_StockReceived_HIST_CessOnExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_CessOnExciseTaxAmount]  DEFAULT ((0.00)) FOR [CessOnExciseTaxAmount]
GO
/****** Object:  Default [DF_StockReceived_HIST_HighterEdCessTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_HighterEdCessTaxAmount]  DEFAULT ((0.00)) FOR [HighterEdCessTaxAmount]
GO
/****** Object:  Default [DF_StockReceived_HIST_CSTAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_CSTAmount]  DEFAULT ((0.00)) FOR [CSTAmount]
GO
/****** Object:  Default [DF_StockReceived_HIST_ExciseTaxAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_ExciseTaxAmount]  DEFAULT ((0.00)) FOR [ExciseTaxAmount]
GO
/****** Object:  Default [DF_StockReceived_HIST_RoundOfValue]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceived_HIST] ADD  CONSTRAINT [DF_StockReceived_HIST_RoundOfValue]  DEFAULT ((0.00)) FOR [RoundOfValue]
GO
/****** Object:  Default [Def_StockReceivedAttributesDetail_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedAttributesDetails] ADD  CONSTRAINT [Def_StockReceivedAttributesDetail_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_StockReceivedDetails_POQuantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_POQuantity]  DEFAULT ((0.00)) FOR [POQuantity]
GO
/****** Object:  Default [DF_StockReceivedDetails_ComplimentQTY]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_ComplimentQTY]  DEFAULT ((0.00)) FOR [ComplimentQTY]
GO
/****** Object:  Default [DF_StockReceivedDetails_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockReceivedDetails_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_StockReceivedDetails_TotalCost]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_TotalCost]  DEFAULT ((0.00)) FOR [TotalCost]
GO
/****** Object:  Default [DF_StockReceivedDetails_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_RECQuantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_RECQuantity]  DEFAULT ((0.00)) FOR [RECQuantity]
GO
/****** Object:  Default [DF_StockReceivedDetails_InvoiceQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_InvoiceQty]  DEFAULT ((0.00)) FOR [InvoiceQty]
GO
/****** Object:  Default [DF_StockReceivedDetails_RcvdLSUQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_RcvdLSUQty]  DEFAULT ((0.00)) FOR [RcvdLSUQty]
GO
/****** Object:  Default [DF_StockReceivedDetails_UnitSellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_UnitSellingPrice]  DEFAULT ((0.00)) FOR [UnitSellingPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_UnitCostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_UnitCostPrice]  DEFAULT ((0.00)) FOR [UnitCostPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_StockReceivedDetails_ExciseTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF_StockReceivedDetails_ExciseTax]  DEFAULT ((0.00)) FOR [ExciseTax]
GO
/****** Object:  Default [DF__StockRece__Produ__0D1ADB2A]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[StockReceivedDetails] ADD  CONSTRAINT [DF__StockRece__Produ__0D1ADB2A]  DEFAULT ('') FOR [ProductKey]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_POQuantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_POQuantity]  DEFAULT ((0.00)) FOR [POQuantity]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_ComplimentQTY]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_ComplimentQTY]  DEFAULT ((0.00)) FOR [ComplimentQTY]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_Tax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_Tax]  DEFAULT ((0.00)) FOR [Tax]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_TotalCost]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_TotalCost]  DEFAULT ((0.00)) FOR [TotalCost]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_RECQuantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_RECQuantity]  DEFAULT ((0.00)) FOR [RECQuantity]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_InvoiceQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_InvoiceQty]  DEFAULT ((0.00)) FOR [InvoiceQty]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_RcvdLSUQty]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_RcvdLSUQty]  DEFAULT ((0.00)) FOR [RcvdLSUQty]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_UnitSellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_UnitSellingPrice]  DEFAULT ((0.00)) FOR [UnitSellingPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_UnitCostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_UnitCostPrice]  DEFAULT ((0.00)) FOR [UnitCostPrice]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_MRP]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_MRP]  DEFAULT ((0.00)) FOR [MRP]
GO
/****** Object:  Default [DF_StockReceivedDetails_HIST_ExciseTax]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReceivedDetails_HIST] ADD  CONSTRAINT [DF_StockReceivedDetails_HIST_ExciseTax]  DEFAULT ((0.00)) FOR [ExciseTax]
GO
/****** Object:  Default [DF_StockReturn_ActualAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReturn] ADD  CONSTRAINT [DF_StockReturn_ActualAmount]  DEFAULT ((0.00)) FOR [ActualAmount]
GO
/****** Object:  Default [DF_StockReturn_ApprovedAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReturn] ADD  CONSTRAINT [DF_StockReturn_ApprovedAmount]  DEFAULT ((0.00)) FOR [ApprovedAmount]
GO
/****** Object:  Default [DF_StockReturnDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReturnDetails] ADD  CONSTRAINT [DF_StockReturnDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_StockReturnDetails_CostPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReturnDetails] ADD  CONSTRAINT [DF_StockReturnDetails_CostPrice]  DEFAULT ((0.00)) FOR [CostPrice]
GO
/****** Object:  Default [DF_StockReturnDetails_Amount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockReturnDetails] ADD  CONSTRAINT [DF_StockReturnDetails_Amount]  DEFAULT ((0.00)) FOR [Amount]
GO
/****** Object:  Default [DF__StockRetu__Produ__15B0212B]    Script Date: 09/14/2015 17:43:59 ******/
ALTER TABLE [dbo].[StockReturnDetails] ADD  CONSTRAINT [DF__StockRetu__Produ__15B0212B]  DEFAULT ('') FOR [ProductKey]
GO
/****** Object:  Default [DF_StockUsageDetails_Quantity]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockUsageDetails] ADD  CONSTRAINT [DF_StockUsageDetails_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
/****** Object:  Default [DF_StockUsageDetails_UnitPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockUsageDetails] ADD  CONSTRAINT [DF_StockUsageDetails_UnitPrice]  DEFAULT ((0.00)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_StockUsageDetails_SellingPrice]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockUsageDetails] ADD  CONSTRAINT [DF_StockUsageDetails_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
/****** Object:  Default [DF_StockUsageDetails_TaxPercent]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockUsageDetails] ADD  CONSTRAINT [DF_StockUsageDetails_TaxPercent]  DEFAULT ((0.00)) FOR [TaxPercent]
GO
/****** Object:  Default [DF_StockUsageDetails_Discount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[StockUsageDetails] ADD  CONSTRAINT [DF_StockUsageDetails_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
/****** Object:  Default [DF_SupplierCreditorDebitNote_CreditAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SupplierCreditorDebitNote] ADD  CONSTRAINT [DF_SupplierCreditorDebitNote_CreditAmount]  DEFAULT ((0.00)) FOR [CreditAmount]
GO
/****** Object:  Default [DF_SupplierCreditorDebitNote_UsedAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SupplierCreditorDebitNote] ADD  CONSTRAINT [DF_SupplierCreditorDebitNote_UsedAmount]  DEFAULT ((0.00)) FOR [UsedAmount]
GO
/****** Object:  Default [DF_SupplierCreditorDebitNote_DebitAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SupplierCreditorDebitNote] ADD  CONSTRAINT [DF_SupplierCreditorDebitNote_DebitAmount]  DEFAULT ((0.00)) FOR [DebitAmount]
GO
/****** Object:  Default [DF_SupplierCreditorDebitReference_UsedAmount]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[SupplierCreditorDebitReference] ADD  CONSTRAINT [DF_SupplierCreditorDebitReference_UsedAmount]  DEFAULT ((0.00)) FOR [UsedAmount]
GO
/****** Object:  Default [Def_TaxCategoriesMapping_Status]    Script Date: 09/01/2015 19:39:30 ******/
ALTER TABLE [dbo].[TaxCategoriesMapping] ADD  CONSTRAINT [Def_TaxCategoriesMapping_Status]  DEFAULT ((1)) FOR [Status]
GO
IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='Stockinhand' AND SC.NAME = 'SubstoreReturnqty') 
BEGIN
 ALTER TABLE Stockinhand add  SubstoreReturnqty  DECIMAL(18,2)
END
 IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='Taxmaster' AND SC.NAME = 'TaxType') 
BEGIN
 ALTER TABLE Taxmaster add  [TaxType] [nvarchar](20) NULL
END
 IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='ReportExcelSp' AND SC.NAME = 'OrgID') 
BEGIN
 ALTER TABLE ReportExcelSp add  [OrgID] [int] NULL
END
 IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='ReportExcelSp' AND SC.NAME = 'ReportGroupID') 
BEGIN
 ALTER TABLE ReportExcelSp add  [ReportGroupID] [int] NULL
END
 IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='ReportExcelSp' AND SC.NAME = 'DataSetname') 
BEGIN
 ALTER TABLE ReportExcelSp add  [DataSetname] [nvarchar](max) NULL
END
 IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='DiscountMaster' AND SC.NAME = 'DataSetname') 
BEGIN
 ALTER TABLE DiscountMaster add  [DataSetname] [nvarchar](max) NULL
END
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DiscountMaster'
			AND SC.NAME = 'Createdat'
		)
BEGIN
	ALTER TABLE DiscountMaster ADD Createdat DATETIME
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DiscountMaster'
			AND SC.NAME = 'CreatedBy'
		)
BEGIN
	ALTER TABLE DiscountMaster ADD CreatedBy BIGINT
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DiscountMaster'
			AND SC.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE DiscountMaster ADD ModifiedBy BIGINT
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DiscountMaster'
			AND SC.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE DiscountMaster ADD ModifiedAt DATETIME
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DiscountMaster'
			AND SC.NAME = 'IsRequiresReason'
		)
BEGIN
	 ALTER TABLE DiscountMaster add  [IsRequiresReason] [nchar](1) NULL
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DiscountMaster'
			AND SC.NAME = 'IsApprovalRequired'
		)
BEGIN
	 ALTER TABLE DiscountMaster add  [IsApprovalRequired] [nchar](1) NULL
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DueClearanceReference'
			AND SC.NAME = 'Createdat'
		)
BEGIN
	ALTER TABLE DueClearanceReference ADD Createdat DATETIME
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DueClearanceReference'
			AND SC.NAME = 'CreatedBy'
		)
BEGIN
	ALTER TABLE DueClearanceReference ADD CreatedBy BIGINT
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DueClearanceReference'
			AND SC.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE DueClearanceReference ADD ModifiedBy BIGINT
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DueClearanceReference'
			AND SC.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE DueClearanceReference ADD ModifiedAt DATETIME
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DueClearanceReference'
			AND SC.NAME = 'EligibleAmount'
		)
BEGIN
	 ALTER TABLE DueClearanceReference ADD [EligibleAmount] [decimal](18, 2) NULL
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'DueClearanceReference'
			AND SC.NAME = 'locationid'
		)
BEGIN
	 ALTER TABLE DueClearanceReference ADD [locationid] [bigint] NULL
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'CashOutFlow'
			AND SC.NAME = 'ClosureID'
		)
BEGIN
	ALTER TABLE CashOutFlow add   [ClosureID] [bigint] NULL
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'CashOutFlow'
			AND SC.NAME = 'DepositID'
		)
BEGIN
	ALTER TABLE CashOutFlow add   DepositID [bigint] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'CashOutFlow'
			AND SC.NAME = 'ReferenceNo'
		)
BEGIN
	ALTER TABLE CashOutFlow add  [ReferenceNo] [nvarchar](255) NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'ProductsAttributesMaster'
			AND SC.NAME = 'LangCode'
		)
BEGIN
	 ALTER TABLE ProductsAttributesMaster ADD LangCode NVARCHAR(10) DEFAULT 'en-GB'
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'ProductSupplierRateMapping'
			AND SC.NAME = 'PurchasePrice'
		)
BEGIN
	 ALTER TABLE ProductSupplierRateMapping add PurchasePrice Decimal(18,2)   
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PurchaseRequest'
			AND SC.NAME = 'IntendID'
		)
BEGIN
	 ALTER TABLE PurchaseRequest ADD IntendID BIGINT
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'StockReceivedType'
			AND SC.NAME = 'LanguageCode'
		)
BEGIN
	  ALTER TABLE StockReceivedType ADD LanguageCode NVARCHAR(10) DEFAULT 'en-GB'
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'ProductsAttributesMaster'
			AND SC.NAME = 'LangCode'
		)
BEGIN
	 ALTER TABLE ProductsAttributesMaster ADD LangCode NVARCHAR(10) DEFAULT 'en-GB'
END
GO
IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PurchaseRequestDetails'
			AND SC.NAME = 'IntendDetailID'
		)
BEGIN
	ALTER TABLE PurchaseRequestDetails ADD IntendDetailID BIGINT
END
GO





IF NOT EXISTS(SELECT 1 FROM syscolumns WHERE [name]='CategoryID' AND id= OBJECT_ID('ProductCodeMaster'))
BEGIN
ALTER TABLE ProductCodeMaster ADD CategoryID INT NULL
END
GO
IF NOT EXISTS(SELECT 1 FROM syscolumns WHERE [name]='ProductTypeId' AND id= OBJECT_ID('ProductCodeMaster'))
BEGIN
ALTER TABLE ProductCodeMaster ADD ProductTypeId INT NULL
END
GO


IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='RejectReason' AND object_id= OBJECT_ID('BillingDetails'))
BEGIN
Alter table BillingDetails Add RejectReason NVarchar(255)
END
GO

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='ResubmissionType' AND object_id= OBJECT_ID('BillingDetails'))
BEGIN
Alter table BillingDetails Add ResubmissionType NVarchar(50)
END
GO

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='Comments' AND object_id= OBJECT_ID('BillingDetails'))
BEGIN
Alter table BillingDetails Add Comments NVarchar(255) 
END
GO

IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='ClaimStatus' AND object_id= OBJECT_ID('BillingDetails'))
BEGIN
Alter table BillingDetails Add ClaimStatus NVarchar(50) 
END
GO

IF not  EXISTS(SELECT 1 FROM sys.columns sc inner join sys.sysobjects SO (nolock) on sc.object_id = so.id where so.name = 'BillingDetails' And sc.name = 'IsAdminChargeApplicable') 
BEGIN
ALTER TABLE BillingDetails add  IsAdminChargeApplicable  nchar(1)
END
GO


IF NOT EXISTS(SELECT 1 FROM syscolumns WHERE [name]='CategoryID' AND id= OBJECT_ID('ProductCodeMaster'))
BEGIN
ALTER TABLE ProductCodeMaster ADD CategoryID INT NULL
END
GO
IF NOT EXISTS(SELECT 1 FROM syscolumns WHERE [name]='ProductTypeId' AND id= OBJECT_ID('ProductCodeMaster'))
BEGIN
ALTER TABLE ProductCodeMaster ADD ProductTypeId INT NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'IsPading'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [IsPading] [nchar] (1) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'PadLength'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [PadLength] [int] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'ResetFinancialDate'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [ResetFinancialDate] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'ResetFinancialYear'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [ResetFinancialYear] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'CreatedBy'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [CreatedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'CreatedAt'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [CreatedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [ModifiedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [ModifiedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IDPatternMaster' AND SC.NAME = 'LocationID'
		)
BEGIN
	ALTER TABLE IDPatternMaster ADD [LocationID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'Localities' AND SC.NAME = 'Code'
		)
BEGIN
	ALTER TABLE Localities ADD Code VARCHAR(25)
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TaskActionOrgMapping' AND SC.NAME = 'CreatedBy'
		)
BEGIN
	ALTER TABLE TaskActionOrgMapping ADD [CreatedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TaskActionOrgMapping' AND SC.NAME = 'CreatedAt'
		)
BEGIN
	ALTER TABLE TaskActionOrgMapping ADD [CreatedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TaskActionOrgMapping' AND SC.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE TaskActionOrgMapping ADD [ModifiedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TaskActionOrgMapping' AND SC.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE TaskActionOrgMapping ADD [ModifiedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'StockReorder' AND SC.NAME = 'CreatedBy'
		)
BEGIN
	ALTER TABLE StockReorder ADD [CreatedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'StockReorder' AND SC.NAME = 'CreatedAt'
		)
BEGIN
	ALTER TABLE StockReorder ADD [CreatedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'StockReorder' AND SC.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE StockReorder ADD [ModifiedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'StockReorder' AND SC.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE StockReorder ADD [ModifiedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'RefPhysicianID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [RefPhysicianID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'RefPhyName'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [RefPhyName] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'DiscOrEnhanceRemarks'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [DiscOrEnhanceRemarks] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'LabNo'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [LabNo] [nvarchar] (30) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'TaxPercent'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [TaxPercent] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'EligibleAmount'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [EligibleAmount] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'CoSharing'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [CoSharing] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'Performertype'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [Performertype] [nvarchar] (55) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'RateRefID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [RateRefID] [int] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'SellingUnit'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [SellingUnit] [nvarchar] (50) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'DiscountReason'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [DiscountReason] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'ClientFeeTypeRateCustID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [ClientFeeTypeRateCustID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'AgreedAmount'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [AgreedAmount] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'Remarks'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [Remarks] [nvarchar] (50) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'DiscOrEnhancePercent'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [DiscOrEnhancePercent] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'ReferralID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [ReferralID] [int] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'ReferralType'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [ReferralType] [nvarchar] (55) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'CoPayValue'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [CoPayValue] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'CoPayType'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [CoPayType] [nvarchar] (10) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'PerPhySpecialtyID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [PerPhySpecialtyID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'PackageId'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [PackageId] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'PaymentCollectedFrom'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [PaymentCollectedFrom] [nvarchar] (100) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'ClosureID'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [ClosureID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'DepositedClosureStatus'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [DepositedClosureStatus] [nvarchar] (10) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'AmountDebtClosureDetailsID'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [AmountDebtClosureDetailsID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'TransactionID'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [TransactionID] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'BranchName'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [BranchName] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'IsOutStation'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [IsOutStation] [nvarchar] (1) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'AuthorisationCode'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [AuthorisationCode] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountReceivedDetails' AND SC.NAME = 'IsDueBill'
		)
BEGIN
	ALTER TABLE AmountReceivedDetails ADD [IsDueBill] [bit] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IPIntermediatePayments' AND SC.NAME = 'ReceiptType'
		)
BEGIN
	ALTER TABLE IPIntermediatePayments ADD [ReceiptType] [nvarchar] (5) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'IPIntermediatePayments' AND SC.NAME = 'RoundoffAmount'
		)
BEGIN
	ALTER TABLE IPIntermediatePayments ADD [RoundoffAmount] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDueDetails' AND SC.NAME = 'DueReason'
		)
BEGIN
	ALTER TABLE PatientDueDetails ADD [DueReason] [nvarchar] (max) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDueDetails' AND SC.NAME = 'CoPaymentDue'
		)
BEGIN
	ALTER TABLE PatientDueDetails ADD [CoPaymentDue] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountApprovalDetails' AND SC.NAME = 'FinalBillID'
		)
BEGIN
	ALTER TABLE AmountApprovalDetails ADD [FinalBillID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountApprovalDetails' AND SC.NAME = 'BilledAmount'
		)
BEGIN
	ALTER TABLE AmountApprovalDetails ADD [BilledAmount] [decimal] (
		18
		,2
		) NOT NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'AmountApprovalDetails' AND SC.NAME = 'BuildAmount'
		)
BEGIN
	ALTER TABLE AmountApprovalDetails ADD [BuildAmount] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'PaymentCollectedFrom'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [PaymentCollectedFrom] [nvarchar] (100) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'ClosureID'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [ClosureID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'DeptType'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [DeptType] [nvarchar] (50) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'DeliveryDate'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [DeliveryDate] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'ChequeValidDate'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [ChequeValidDate] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'DepositedClosureStatus'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [DepositedClosureStatus] [nvarchar] (10) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'AmountDebtClosureDetailsID'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [AmountDebtClosureDetailsID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'TransactionID'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [TransactionID] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'BranchName'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [BranchName] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'IsOutStation'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [IsOutStation] [nvarchar] (1) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'IsDepositused'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [IsDepositused] [nchar] (1) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'Discount'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [Discount] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'DepositTypeID'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [DepositTypeID] [nvarchar] (10) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'RefundNo'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [RefundNo] [nvarchar] (30) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [ModifiedAt] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [ModifiedBy] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'PatientDepositHistory' AND SC.NAME = 'LoyaltyExpiryDate'
		)
BEGIN
	ALTER TABLE PatientDepositHistory ADD [LoyaltyExpiryDate] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'DepositID'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [DepositID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'ReceiptNo'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [ReceiptNo] [nvarchar] (30) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'ReturnQuantity'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [ReturnQuantity] [decimal] (
		18
		,0
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'DiscOrEnhanceRemarks'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [DiscOrEnhanceRemarks] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'DiscOrEnhancePercent'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [DiscOrEnhancePercent] [decimal] (
		18
		,0
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'ReferralType'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [ReferralType] [nvarchar] (55) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'ClientFeeTypeRateCustID'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [ClientFeeTypeRateCustID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'ReferralID'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [ReferralID] [int] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'PerPhySpecialtyID'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [PerPhySpecialtyID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'TransBillingDetails' AND SC.NAME = 'OrderTaskID'
		)
BEGIN
	ALTER TABLE TransBillingDetails ADD [OrderTaskID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'DiscOrEnhanceRemarks'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [DiscOrEnhanceRemarks] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'LabNo'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [LabNo] [nvarchar] (30) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'TaxPercent'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [TaxPercent] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'Performertype'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [Performertype] [nvarchar] (55) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'SellingUnit'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [SellingUnit] [nvarchar] (50) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'TransferRateID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [TransferRateID] [int] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'TransferAmount'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [TransferAmount] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'TatDateTime'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [TatDateTime] [datetime] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'DiscountReason'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [DiscountReason] [nvarchar] (255) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'BaseRateID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [BaseRateID] [int] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'ClientFeeTypeRateCustID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [ClientFeeTypeRateCustID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'AgreedAmount'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [AgreedAmount] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'Remarks'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [Remarks] [nvarchar] (50) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'DiscOrEnhancePercent'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [DiscOrEnhancePercent] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'ReferralType'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [ReferralType] [nvarchar] (55) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'CoPayValue'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [CoPayValue] [decimal] (
		18
		,2
		) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'CoPayType'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [CoPayType] [nvarchar] (10) NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'PerPhySpecialtyID'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [PerPhySpecialtyID] [bigint] NULL
END
	GO

IF NOT EXISTS (
		SELECT 1
		FROM SYS.COLUMNS SC
		WHERE OBJECT_NAME(SC.OBJECT_ID) = 'BillingDetails' AND SC.NAME = 'PackageId'
		)
BEGIN
	ALTER TABLE BillingDetails ADD [PackageId] [bigint] NULL
END
	GO
	
	
/****** Object:  Table [dbo].[ReportExcelSp]    Script Date: 08/14/2015 14:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportExcelSp]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ReportExcelSp](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Name] [nvarchar](124) NULL,
	[Description] [nvarchar](255) NULL,
	[OrgID] [int] NULL,
	[ReportGroupID] [int] NULL,
	[DataSetname] [nvarchar](max) NULL,
	[ReportPath] [nvarchar](100) NULL
) ON [PRIMARY]
END
GO
	



If Not exists(select 1 from sys.columns sc inner join sys.sysobjects SO (nolock) on sc.object_id = so.id where so.name = 'PaymentType' And sc.name = 'LanguageCode') 
BEGIN 
ALTER TABLE PaymentType ADD LanguageCode NVARCHAR(10) DEFAULT 'en-GB'
END
GO

If Not exists(select 1 from sys.columns sc inner join sys.sysobjects SO (nolock) on sc.object_id = so.id where so.name = 'PaymentType' And sc.name = 'PaymentCode') 
BEGIN 
ALTER TABLE PaymentType ADD PaymentCode NVARCHAR(10) DEFAULT 'en-GB'
END
GO

If Not exists(select 1 from sys.columns sc inner join sys.sysobjects SO (nolock) on sc.object_id = so.id where so.name = 'Drafts' And sc.name = 'DraftMasterID') 
	BEGIN
	ALTER TABLE [Drafts] adD [DraftMasterID] [nvarchar](50) NULL
END
GO



IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'LangCode' AND id = OBJECT_ID('DiscountMaster'))
BEGIN
ALter table DiscountMaster ADD LangCode Nvarchar(100)
END
GO

IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'SpecialityID' AND id = OBJECT_ID('TransBillingDetails'))
BEGIN
Alter table TransBillingDetails ADD SpecialityID bigint
END
GO

IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'LangCode' AND id = OBJECT_ID('Theme'))
BEGIN
ALter table Theme ADD LangCode Nvarchar(100)
END
GO

IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'EligibleAmount' AND id = OBJECT_ID('SurgeryOrderedServices'))
BEGIN
ALter table SurgeryOrderedServices ADD [EligibleAmount] [decimal](18, 2) NULL
END
GO


IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'locationid' AND id = OBJECT_ID('SurgeryOrderedServices'))
BEGIN
ALter table SurgeryOrderedServices ADD [locationid] [bigint] NULL
END
GO


IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='DailySalary' AND object_id= OBJECT_ID('Users '))
BEGIN
    ALTER TABLE Users ADD [DailySalary] [decimal](18, 2) 
END
GO
IF NOT EXISTS(SELECT * FROM sys.columns WHERE name='MonthlySalary' AND object_id= OBJECT_ID('Users '))
BEGIN
    ALTER TABLE Users ADD [MonthlySalary] [decimal](18, 2) 
END
GO
IF OBJECT_ID('dbo.[DF_Users_DailySalary]', 'D') IS NULL 
BEGIN
	ALTER TABLE Users ADD CONSTRAINT DF_Users_DailySalary DEFAULT 0.00 FOR DailySalary
end
GO
IF OBJECT_ID('dbo.[DF_Users_MonthlySalary]', 'D') IS NULL
BEGIN
	ALTER TABLE Users ADD CONSTRAINT DF_Users_MonthlySalary DEFAULT 0.00 FOR MonthlySalary
END
GO


If not EXISTS(SELECT 1 FROM sys.columns sc inner join sys.sysobjects SO (nolock) on sc.object_id = so.id where so.name = 'MetaData' And sc.name = 'SeqNo') 
begin
Alter table MetaData Add SeqNo int
end


--WARNING! ERRORS ENCOUNTERED DURING SQL PARSING!
IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'createdat'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [createdat] [datetime] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'CreatedBy'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [CreatedBy] [bigint] NULL
END
Go
IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'ModifiedAt'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [ModifiedAt] [datetime] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'ModifiedBy'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [ModifiedBy] [bigint] NULL
	
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'CountryCode'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [CountryCode] [int] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'StateCode'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [StateCode] [int] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'CityCode'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [CityCode] [int] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'AddLevel1'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [AddLevel1] [int] NULL
END
GO

IF NOT EXISTS (
		SELECT 1
		FROM sys.columns sc
		INNER JOIN sys.sysobjects SO(NOLOCK) ON sc.object_id = so.id
		WHERE so.NAME = 'NewInstanceWaitingCustomers'
			AND sc.NAME = 'AddLevel2'
		)
BEGIN
	ALTER TABLE NewInstanceWaitingCustomers ADD [AddLevel2] [int] NULL
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'DynamicColumnMapping'
		AND sc.NAME = 'DisplayText'
)
BEGIN
	ALTER TABLE DynamicColumnMapping ADD  [DisplayText] [nvarchar] (200) NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'DynamicColumnMapping'
		AND sc.NAME = 'LangCode'
)
BEGIN
	ALTER TABLE DynamicColumnMapping ADD  [LangCode] [nvarchar] (50) NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'DynamicColumnMapping'
		AND sc.NAME = 'createdat'
)
BEGIN
	ALTER TABLE DynamicColumnMapping ADD  [createdat] [datetime] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'DynamicColumnMapping'
		AND sc.NAME = 'CreatedBy'
)
BEGIN
	ALTER TABLE DynamicColumnMapping ADD  [CreatedBy] [bigint] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'DynamicColumnMapping'
		AND sc.NAME = 'ModifiedAt'
)
BEGIN
	ALTER TABLE DynamicColumnMapping ADD  [ModifiedAt] [datetime] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'DynamicColumnMapping'
		AND sc.NAME = 'ModifiedBy'
)
BEGIN
	ALTER TABLE DynamicColumnMapping ADD  [ModifiedBy] [bigint] NULL
END
 GO

 
 IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'ClientFeeTypeRateCustomization'
		AND sc.NAME = 'ClientFeeTypeRateCustID'
)
BEGIN
	ALTER TABLE ClientFeeTypeRateCustomization ADD [ClientFeeTypeRateCustID] [bigint] IDENTITY (1,1) 	NOT NULL
	
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'ClientFeeTypeRateCustomization'
		AND sc.NAME = 'FeeID'
)
BEGIN
	ALTER TABLE ClientFeeTypeRateCustomization ADD [FeeID] [bigint] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'ClientFeeTypeRateCustomization'
		AND sc.NAME = 'createdat'
)
BEGIN
	ALTER TABLE ClientFeeTypeRateCustomization ADD [createdat] [datetime] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'ClientFeeTypeRateCustomization'
		AND sc.NAME = 'CreatedBy'
)
BEGIN
	ALTER TABLE ClientFeeTypeRateCustomization ADD [CreatedBy] [bigint] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'ClientFeeTypeRateCustomization'
		AND sc.NAME = 'ModifiedAt'
)
BEGIN
	ALTER TABLE ClientFeeTypeRateCustomization ADD [ModifiedAt] [datetime] NULL
END
 GO

IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'ClientFeeTypeRateCustomization'
		AND sc.NAME = 'ModifiedBy'
)
BEGIN
	ALTER TABLE ClientFeeTypeRateCustomization ADD [ModifiedBy] [bigint] NULL
END
 GO
 
 
IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'IDPatternMaster'
		AND sc.NAME = 'OrgID'
)
begin 

	ALTER table IDPatternMaster ALTER COLUMN [OrgID] [bigint] NULL
end 
IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'Patient'
		AND sc.NAME = 'Nationality'
)
begin 
	ALTER table Patient ALTER COLUMN [Nationality] [bigint] NULL
	end
	
	IF NOT EXISTS (
	SELECT 1
	FROM sys.columns sc
	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
	WHERE so.NAME = 'Country'
		AND sc.NAME = 'CountryID'
)
begin 
	ALTER TABLE [dbo].[Country] ALTER COLUMN CountryID int NOT NULL
end	
	
--alter TABLE PatientDueDetails alter COLUMN [DiscountAmt] [decimal](18, 6) NULL
--alter TABLE PatientDueDetails alter COLUMN  [CurrentDue] [decimal](18, 6) NULL




--ALTER TABLE  OrgUsers  ALTER COLUMN CountryID BIGINT
--ALTER TABLE  OrgUsers  ALTER COLUMN StateID BIGINT

--IF NOT EXISTS (
--	SELECT 1
--	FROM sys.columns sc
--	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
--	WHERE so.NAME = 'Theme'
--		AND sc.NAME = 'createdat'
--)
--BEGIN
--	ALTER TABLE Theme ADD [createdat] [datetime] NULL
--END
-- GO

--IF NOT EXISTS (
--	SELECT 1
--	FROM sys.columns sc
--	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
--	WHERE so.NAME = 'Theme'
--		AND sc.NAME = 'CreatedBy'
--)
--BEGIN
--	ALTER TABLE Theme ADD [CreatedBy] [bigint] NULL
--END
-- GO

--IF NOT EXISTS (
--	SELECT 1
--	FROM sys.columns sc
--	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
--	WHERE so.NAME = 'Theme'
--		AND sc.NAME = 'ModifiedAt'
--)
--BEGIN
--	ALTER TABLE Theme ADD [ModifiedAt] [datetime] NULL
--END
-- GO

--IF NOT EXISTS (
--	SELECT 1
--	FROM sys.columns sc
--	INNER JOIN sys.sysobjects SO (NOLOCK) ON sc.object_id = so.id
--	WHERE so.NAME = 'Theme'
--		AND sc.NAME = 'ModifiedBy'
--)
--BEGIN
--	ALTER TABLE Theme ADD [ModifiedBy] [bigint] NULL
--END
-- GO


IF not  EXISTS(SELECT 1 FROM sys.columns sc inner join sys.sysobjects SO (nolock) on sc.object_id = so.id where so.name = 'PatientDueChart' And sc.name = 'IsAdminChargeApplicable') 
BEGIN
ALTER TABLE PatientDueChart add  IsAdminChargeApplicable  nchar(1)
END
GO




IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'StampFee' AND id = OBJECT_ID('StockReceived'))                
BEGIN
	   ALTER TABLE StockReceived ADD StampFee decimal(18,2)
END 

GO

IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'DeliveryCharges' AND id = OBJECT_ID('StockReceived'))                
BEGIN
	   ALTER TABLE StockReceived ADD DeliveryCharges decimal(18,2)
END 


IF NOT EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='Localities' AND SC.NAME = 'IsDefault') 
begin
alter table localities add  IsDefault nchar(1)
end
GO


IF EXISTS(SELECT 1 FROM SYS.COLUMNS SC WHERE OBJECT_NAME(SC.OBJECT_ID)='Localities' AND SC.NAME = 'NationalityID') 
begin
	ALTER TABLE Localities alter column NationalityID bigint
end
GO
