


CREATE TABLE #TEMPATTRIBUTETALE([AttributeID] INT, [AttributeName] NVARCHAR(100), [Status] INT, [IsPreDefined] INT, [ShowColumn] INT NULL)


INSERT INTO #TEMPATTRIBUTETALE( [AttributeID], [AttributeName], [Status], [IsPreDefined], [ShowColumn])
SELECT 1, N'POQuantity', 1, 1,  NULL
UNION SELECT 2, N'POUnit', 1, 1,  NULL
UNION SELECT 3, N'RECQuantity', 1, 1,  NULL
UNION SELECT 4, N'BatchNo', 1, 0,  NULL
UNION SELECT 5, N'Manufacture', 0, 1,  NULL
UNION SELECT 6, N'ExpiryDate', 1, 0,  NULL
UNION SELECT 7, N'LSUnit', 1, 1,  NULL
UNION SELECT 8, N'RcvdLSUQty', 1, 1,  NULL
UNION SELECT 9, N'UnitPrice', 1, 0,  NULL
UNION SELECT 10, N'ComplimentQTY', 0, 1,  NULL
UNION SELECT 11, N'UnitCostPrice', 1, 1,  N'0'
UNION SELECT 12, N'Discount', 1, 0,  NULL
UNION SELECT 13, N'Tax', 1, 1,  NULL
UNION SELECT 14, N'UnitSellingPrice', 1, 1,  N'0'
UNION SELECT 15, N'MRP', 1, 0,  NULL
UNION SELECT 16, N'RakNo', 1, 0,  NULL
UNION SELECT 17, N'Type', 1, 1,  NULL
UNION SELECT 18, N'InvoiceQty', 1, 1,  NULL
UNION SELECT 19, N'SellingPrice', 1, 0,  NULL
UNION SELECT 20, N'ProductName', 1, 1,  NULL
UNION SELECT 21, N'ProductColor', 1, 0,  NULL
UNION SELECT 22, N'Freight Charge', 1, 0,  NULL


SET IDENTITY_INSERT [dbo].[InventoryAttributesMaster] ON 
INSERT [dbo].[InventoryAttributesMaster] ([AttributeID], [AttributeName], [Status], [IsPreDefined], [ShowColumn],Createdat)

SELECT T.[AttributeID], T.[AttributeName], T.[Status], T.[IsPreDefined], T.[ShowColumn],GETDATE() FROM #TEMPATTRIBUTETALE T
LEFT JOIN InventoryAttributesMaster  IA ON IA.AttributeID=T.AttributeID
WHERE IA.AttributeID IS NULL

SET IDENTITY_INSERT [dbo].[InventoryAttributesMaster] OFF



DROP TABLE #TEMPATTRIBUTETALE



DECLARE @OrgID INT=112 
 
 ;WITH CTEATTORGMAPPING(AttributeID,ControlTypeID,DataType,DisplayText,Status,pagetype,IsMandatory,SeqNo )
 as(

   SELECT 20,1,'String','ProductName',1,'CSD',1,1
UNION SELECT 1,1,'Decimal','PO Qty',1,'CSD',1,2
UNION SELECT 2,1,'Decimal','PO Unit',1,'CSD',1,3
UNION SELECT 3,1,'Decimal','Recd Qty',1,'CSD',1,4
UNION SELECT 4,1,'String','Batch No',1,'CSD',0,5
UNION SELECT 5,1,'DateTime','Mft Date',1,'CSD',0,6
UNION SELECT 6,1,'DateTime','Exp Date',1,'CSD',0,7
UNION SELECT 7,3,'Decimal','LSU',1,'CSD',1,8
UNION SELECT 8,1,'Decimal','Recd LSU Qty',1,'CSD',1,9
UNION SELECT 9,1,'Decimal','Cost Price',1,'CSD',0,10
UNION SELECT 10,1,'Decimal','Comp Qty',1,'CSD',0,11
UNION SELECT 11,1,'Decimal','UnitCostPrice',1,'CSD',1,12
UNION SELECT 12,1,'Decimal','Discount',1,'CSD',0,13
UNION SELECT 13,1,'Decimal','Tax',1,'CSD',0,14
UNION SELECT 14,1,'Decimal','UnitSellingPrice',1,'CSD',1,15
UNION SELECT 15,1,'Decimal','MRP',1,'CSD',0,16
UNION SELECT 16,1,'Decimal','Rack No',1,'CSD',0,17
UNION SELECT 17,1,'Decimal','Total Cost',1,'CSD',1,18
UNION SELECT 18,1,'Decimal','Inverse Qty',1,'CSD',1,19
UNION SELECT 19,1,'Decimal','Selling Price',1,'CSD',0,20

)

INSERT INTO [dbo].[InventoryAttributesOrgMapping]
( [AttributeID], [ControlTypeID], DataType,  [OrgID], [DisplayText], [Status],     [pagetype], [IsMandatory],SeqNo)

 SELECT DISTINCT A.AttributeID,A.ControlTypeID,A.DataType,@OrgID,A.DisplayText,A.Status,A.pagetype,A.IsMandatory,A.SeqNo FROM CTEATTORGMAPPING A
 left JOIN InventoryAttributesOrgMapping B ON B.AttributeID=A.AttributeID and b.OrgID=@OrgID
WHERE B.AttributeID IS NULL
 
