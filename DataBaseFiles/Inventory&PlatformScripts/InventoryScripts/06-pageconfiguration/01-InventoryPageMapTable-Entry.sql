DELETE FROM Inventory_Pages WHERE PageURL LIKE '%/INVENTORY/%'

delete RoleMenu where MenuID not in(
SELECT MenuID FROM MenuMaster )

--truncate table InventoryPageMap

--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventory_Pages]') AND type in (N'U'))
--DROP TABLE [dbo].[Inventory_Pages]


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventory_Pages]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Inventory_Pages](
RowID int identity(1,1),
	[PageName] [varchar](50) NULL,
	[PageURL] [varchar](255) NULL,
	[Parentid] [int] NULL,
	[DisplayText] [varchar](255) NOT NULL,
	PageID int	
) ON [PRIMARY]
END
 





;with CTE(PAGENAME,PAGEURL,PARENTID,DISPLAYTEXT)
AS
(
 SELECT N'Bulkload ', N'/Inventory/INVBulkLoad.aspx', 3, N'Bulk Load'
UNION SELECT N'Central Purchase Order', N'/CentralPurchasing/CentralPurchaseOrder.aspx', 3, N'Central Purchase Order'
UNION SELECT N'Central Stock Receive', N'/CentralReceiving/StockReceive.aspx', 3, N'Central Stock Receive'
UNION SELECT N'Custom Attributes Master', N'/InventoryMaster/CustomAttributesMaster.aspx', 3, N'Attributes Master'
UNION SELECT N'home', N'/InventoryCommon/home.aspx',0,N'home'
UNION SELECT N'Intend', N'/StockIntend/Intend.aspx', 3, N'Indent Search'
UNION SELECT N'Inventory Location', N'/InventoryMaster/InventoryLocation.aspx', 2, N'Inventory Location'
UNION SELECT N'Inventory Mgmt', N'/StockManagement/INVBulkUpdate.aspx', 3, N'Inventory Mgmt'
UNION SELECT N'Inventory Search', N'/InventoryCommon/InventorySearch.aspx', 3, N'Inventory Search'
UNION SELECT N'Investigation Product Mapping',N'/InventoryMaster/InvestigationProductMapping.aspx',3,N'Investigation Product Mapping'
UNION SELECT N'Investigation Stock Usage','/InventoryReports/InvestigationStockUsage.aspx',3, N'Investigation Stock Usage'
UNION SELECT N'PO Request Search',N'/PORequest/PORequestSearch.aspx',3, N'PO Request Search'
UNION SELECT N'PO Request',N'/PORequest/PurchaseOrderRequest.aspx',3, N'PO Request'
UNION SELECT N'Product Categories', N'/InventoryMaster/ProductCategories.aspx', 3, N'Categories'
UNION SELECT N'Product Update', N'/StockManagement/ProductUpdate.aspx', 3, N'Update Products'
UNION SELECT N'Product Upload', N'/StockManagement/ExcelToProductsUpload.aspx', 2, N'Product Upload'
UNION SELECT N'Products', N'/InventoryMaster/Products.aspx', 3, N'Products'
UNION SELECT N'Purchase Order', N'/PurchaseOrder/PurchaseOrder.aspx', 3, N'Purchase Order'
UNION SELECT N'Quick Stock Received', N'/QuickStockReceived/QuickStockReceived.aspx', 3, N'Quick StockReceived'
UNION SELECT N'Quotation Master', N'/Quotation/ProductSupplierRateMapping.aspx', 3, N'Quotation Master'
UNION SELECT N'Raise Intend', N'/StockIntend/RaiseIntend.aspx', 3, N'Raise Indent'
UNION SELECT  N'Reorder level',N'/StockManagement/Reorderlevel.aspx',3, N'Reorder level'
UNION SELECT N'Stock Damage', N'/StockOutFlow/StockDamage.aspx', 3, N'Stock Damage'
UNION SELECT N'Stock Details', N'/StockManagement/StockDetails.aspx', 3, N'Stock Details'
UNION SELECT N'Stock In Hand', N'/StockManagement/ReorderlevelPO.aspx', 3, N'Reorder level'
UNION SELECT N'Stock Issued', N'/StockIntend/StockIssued.aspx', 3, N'Stock Issued'
UNION SELECT N'Stock Receive', N'/StockReceived/ReceiveStock.aspx', 3, N'Stock Receive'
UNION SELECT N'Stock Return', N'/StockReturn/StockReturn.aspx', 3, N'Stock Return'
UNION SELECT N'StockSummary', N'/InventoryReports/StockSummary.aspx', 3, N'Stock Summary'
UNION SELECT N'StockUsage', N'/StockOutFlow/StockUsage.aspx', 3, N'Stock Usage'
UNION SELECT N'Store StockReturn', N'/StockIntend/SubStoreStockReturn.aspx', 3, N'SubStore Stock Return'
UNION SELECT N'Suppliers', N'/InventoryMaster/Suppliers.aspx', 3, N'Suppliers'
UNION SELECT N'UpdateStock', N'/StockManagement/UpdateStockInHand.aspx', 3, N'Stock Adjustment'
UNION  SELECT  N'Stock Report','/InventoryReports/StockReport.aspx',0, N'Stock Report'
UNION SELECT N'Purchase Report','/InventoryReports/PurchaseOrderReport.aspx',0,N'Purchase Report'
UNION SELECT N'Stock Issued Report','/InventoryReports/StockIssuedReport.aspx',0,N'Stock Issued Report'
UNION SELECT N'Stock Report','/InventoryReports/StockReport.aspx',0,N'Stock Report'
UNION SELECT N'Stock Usage Report','/InventoryReports/StockUsageReport.aspx',0,N'Stock Usage Report'





)



INSERT [dbo].[Inventory_Pages] ([PageName], [PageURL], [Parentid], [DisplayText]) 

SELECT CT.[PageName],  CT.[PageURL],  CT.[Parentid],  CT.[DisplayText] FROM CTE CT
LEFT JOIN [Inventory_Pages] IP ON IP.PageName=CT.PAGENAME AND IP.PageURL=CT.PAGEURL AND IP.Parentid=CT.PARENTID AND IP.[DisplayText]=CT.[DisplayText]
WHERE IP.PageURL IS NULL



