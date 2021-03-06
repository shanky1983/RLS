
GO
/****** Object:  Table [dbo].[LocationType]    Script Date: 05/11/2015 15:07:15 ******/
truncate table LocationType

INSERT [dbo].[LocationType] ([LocationTypeID], [LocationTypeName], [LocationTypeCode], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (1, N'Central Store', N'CS', NULL, NULL, NULL, NULL)
INSERT [dbo].[LocationType] ([LocationTypeID], [LocationTypeName], [LocationTypeCode], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (2, N'Selling Point', N'POS', NULL, NULL, NULL, NULL)
INSERT [dbo].[LocationType] ([LocationTypeID], [LocationTypeName], [LocationTypeCode], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (3, N'Point of Distribution Only', N'POD', NULL, NULL, NULL, NULL)
INSERT [dbo].[LocationType] ([LocationTypeID], [LocationTypeName], [LocationTypeCode], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (4, N'Central Store And Selling Point', N'CS-POS', NULL, NULL, NULL, NULL)
INSERT [dbo].[LocationType] ([LocationTypeID], [LocationTypeName], [LocationTypeCode], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (5, N'Optical', N'OPTICAL', NULL, NULL, NULL, NULL)
go
truncate table ControlTypeMaster
SET IDENTITY_INSERT [dbo].[ControlTypeMaster] ON
INSERT [dbo].[ControlTypeMaster] ([ControlTypeID], [ControlName], [ControlCode], [IsEnable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, N'TextBox', N'TXT', 'Y', NULL, NULL, NULL, NULL)
INSERT [dbo].[ControlTypeMaster] ([ControlTypeID], [ControlName], [ControlCode], [IsEnable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (2, N'CheckBox', N'CHK', 'Y', NULL, NULL, NULL, NULL)
INSERT [dbo].[ControlTypeMaster] ([ControlTypeID], [ControlName], [ControlCode], [IsEnable], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (3, N'dropdownlist', N'DDl', 'Y', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ControlTypeMaster] OFF

go
delete MetaData where domain='DataType'
insert MetaData (Domain,Code,DisplayText,LangCode) SELECT 'DataType','String','String','en-GB'
insert MetaData (Domain,Code,DisplayText,LangCode) SELECT 'DataType','Decimal','Decimal','en-GB'
insert MetaData (Domain,Code,DisplayText,LangCode) SELECT 'DataType','DateTime','DateTime','en-GB'
insert MetaData (Domain,Code,DisplayText,LangCode) SELECT 'DataType','Boolean','Boolean','en-GB'



go
truncate table ProductType

INSERT [dbo].[ProductType] ([TypeID], [TypeName], [OrgID], [IsActive], [ModifiedAt], [ModifiedBy], [CreatedAt], [CreatedBy]) VALUES (1, N'Drugs', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductType] ([TypeID], [TypeName], [OrgID], [IsActive], [ModifiedAt], [ModifiedBy], [CreatedAt], [CreatedBy]) VALUES (2, N'Medical Indents', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductType] ([TypeID], [TypeName], [OrgID], [IsActive], [ModifiedAt], [ModifiedBy], [CreatedAt], [CreatedBy]) VALUES (3, N'Food', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductType] ([TypeID], [TypeName], [OrgID], [IsActive], [ModifiedAt], [ModifiedBy], [CreatedAt], [CreatedBy]) VALUES (4, N'General Stocks', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductType] ([TypeID], [TypeName], [OrgID], [IsActive], [ModifiedAt], [ModifiedBy], [CreatedAt], [CreatedBy]) VALUES (5, N'Asset', NULL, NULL, NULL, NULL, NULL, NULL)

go

truncate table InventoryUOM
go
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (1, N'Kg', N'Kilogram', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (2, N'Ltr', N'Liter', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (3, N'Gm', N'Gram', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (4, N'Ml', N'Milliliter', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (5, N'Bottle', N'Bottle', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (6, N'Tin', N'Tin', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (7, N'Roll', N'Roll', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (8, N'Pcs', N'Pieces', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (9, N'Pkt', N'Packet', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (10, N'Nos', N'Numbers', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (11, N'Mtr', N'Metre', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (12, N'Box', N'Box', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (13, N'Can', N'Can', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (14, N'Barrel', N'Barrel', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (15, N'Strip', N'Strip', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (16, N'Carton', N'Carton', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (17, N'Dz', N'Dozen', NULL, NULL, NULL, NULL)
INSERT [dbo].[InventoryUOM] ([UOMID], [UOMCode], [UOMDescription], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (18, N'Bag', N'Bag', NULL, CAST(0x0000A1A600B008BF AS DateTime), NULL, NULL)


go



GO
/****** Object:  Table [dbo].[StockTypeMapping]    Script Date: 05/12/2015 09:39:38 ******/
/****** Object:  Table [dbo].[StockType]    Script Date: 05/12/2015 09:39:38 ******/
truncate table StockType
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, N'Purchase Order', 14, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (2, N'Stock Received', 15, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (3, N'Stock Return', 18, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (4, N'Stock Damage', 16, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (6, N'Stock Usage', 24, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (7, N'Intend', 21, NULL, N'Y', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (8, N'CentralPurchaseOrder', 48, NULL, N'Y', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockType] ([StockTypeID], [StockTypeName], [SearchTypeID], [OrgID], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (9, N'CentralStockReceive', 49, NULL, N'Y', NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[StockStatusMapping]    Script Date: 05/12/2015 09:39:38 ******/
truncate table StockStatusMapping
SET IDENTITY_INSERT [dbo].[StockStatusMapping] ON
INSERT [dbo].[StockStatusMapping] ([ID], [StockStatusID], [OrgID], [LanguageCode], [DisplayText], [StockTypeID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, 31, 1, N'en-GB', N'Cancelled', 2, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[StockStatusMapping] OFF
/****** Object:  Table [dbo].[StockStatus]    Script Date: 05/12/2015 09:39:38 ******/
truncate table StockStatus
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, N'Approved', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (2, N'Cancelled', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (3, N'Received', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (4, N'Inprogress', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (5, N'Pending', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (6, N'Approved', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (7, N'Received', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (8, N'Inprogress', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (9, N'Pending', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (10, N'Approved', 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (11, N'Pending', 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (12, N'Approved', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (13, N'Pending', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (14, N'Approved', 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (15, N'Pending', 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (16, N'Approved', 6, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (17, N'Pending', 6, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (18, N'Partial', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (28, N'Pending', 7, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (29, N'Approved', 7, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (30, N'Cancelled', 7, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, N'Approved', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (2, N'Cancelled', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (3, N'Received', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (4, N'Inprogress', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (5, N'Pending', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (18, N'Partial', 8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (6, N'Approved', 9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (7, N'Received', 9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (8, N'Inprogress', 9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (9, N'Pending', 9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockStatus] ([StockStatusID], [StockStatusName], [StockTypeID], [OrgID], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (31, N'Cancelled', 2, NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[StockReceivedType]    Script Date: 05/12/2015 09:39:38 ******/
truncate table StockReceivedType
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, N'FromSupplier', N'Y', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (2, N'FreeProduct', N'Y', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (3, N'AdhocDetails', N'N', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (4, N'FromStore', N'N', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (5, N'BulkLoad', N'N', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (6, N'QuickStockRecd', N'N', NULL, NULL, NULL, NULL)
INSERT [dbo].[StockReceivedType] ([StrockReceivedTypeID], [SrockReceivedTypeName], [IsDisplay], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (7, N'StockReturn', N'N', NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[StockOutFlowTypes]    Script Date: 05/12/2015 09:39:38 ******/
truncate table StockOutFlowTypes
SET IDENTITY_INSERT [dbo].[StockOutFlowTypes] ON
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (1, N'Stock Issued', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (2, N'Stock Damage', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (3, N'Stock Return', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (4, N'Expiry Date', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (5, N'Stock Usage', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (6, N'Adhoc', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[StockOutFlowTypes] ([StockOutFlowTypeId], [StockOutFlowType], [Description], [createdat], [CreatedBy], [ModifiedAt], [ModifiedBy]) VALUES (7, N'Disposal', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[StockOutFlowTypes] OFF


