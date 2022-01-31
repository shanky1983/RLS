 delete AM 
 FROM ActionMaster AM  
 WHERE   AM.QueryString like  '%/inventory/%' 
 DELETE ActionMaster WHERE ActionCode LIKE '%INTEND%'
 DELETE ActionMaster WHERE ActionCode LIKE '%STOCK%'
  
--DELETE ActionRoleMapping WHERE SearchTypeID IN(15,14,16,17,18,21)
declare @maxActionMaster int
select @maxActionMaster=isnull(max(ActionID),0)+1 from ActionMaster


 ;WITH CTETEMPACTION([ActionName],  [CreatedAt], [QueryString], [ActionCode],  [IsShareable])
 AS(
 SELECT N'View & Print Order',   GETDATE(),  N'../PurchaseOrder/ViewPurchaseOrder.aspx?ID={IdentityValue}&GVPI={GridViewValue}', N'View_Print_Order_ViewPurchaseOrder',  NULL
UNION SELECT N'Copy PO',   GETDATE(), N'../PurchaseOrder/PurchaseOrderQuantity.aspx?copo={IdentityValue}&GVPI={GridViewValue}', N'Copy_PO_PurchaseOrderQuantity',  NULL
UNION SELECT N'Cancel Order',   GETDATE(), N'../PurchaseOrder/ViewPurchaseOrder.aspx?can=1&ID={IdentityValue}&GVPI={GridViewValue}', N'Cancel_Order_ViewPurchaseOrder',  NULL
UNION SELECT N'Approve Order',  GETDATE(), N'../StockReceived/ViewStockReceived.aspx?Approve=1&ID={IdentityValue}&GVPI={GridViewValue}&SupplierID={SupplierValue}&QuotationID={QuotationValue}', N'Approve_Order_ViewStockReceived',  NULL
UNION SELECT N'Approve Order',   GETDATE(), N'../PurchaseOrder/PurchaseOrderQuantity.aspx?Approve=1&ID={IdentityValue}&GVPI={GridViewValue}&SupplierID={SupplierValue}&QuotationID={QuotationValue}', N'Approve_Order_PurchaseOrderQuantity',  NULL
UNION SELECT N'Approve Order',   GETDATE(), N'../StockReceived/UpdateStockReceived.aspx?Approve=1&ID={IdentityValue}&GVPI={GridViewValue}&SupplierID={SupplierValue}&QuotationID={QuotationValue}', N'Approve_Order_UpdateStockReceived',  NULL
UNION SELECT N'View & Print Order',   GETDATE(), N'../StockReceived/ViewStockReceived.aspx?ID={IdentityValue}&GVPI={GridViewValue}', N'View_Print_Order_ViewStockReceived',  NULL
UNION SELECT N'View & Print Order',   GETDATE(), N'../StockReturn/ViewStockReturn.aspx?ID={IdentityValue}&GVPI={GridViewValue}', N'View_Print_Order_ViewStockReturn',  NULL
UNION SELECT N'View & Print Order',   GETDATE(), N'../StockOutFlow/ViewStockDamage.aspx?ID={IdentityValue}&GVPI={GridViewValue}', N'View_Print_Order_ViewStockDamage',  NULL
UNION SELECT N'View & Print Order',   GETDATE(), N'../Inventory/ViewStockIssued.aspx?ID={IdentityValue}&GVPI={GridViewValue}', N'View_Print_Order_ViewStockIssued',  NULL
UNION SELECT N'Issued Stock',   GETDATE(), N'../StockIntend/IssueStock.aspx?intID={IntendID}&LocationID={LocID}&ReceivedOrgID={RecvOrgID}', N'Issued Intend',  N'N'
UNION SELECT N'Received Indent',   GETDATE(), NULL, N'Received Indent',  N'N'
UNION SELECT N'View Intend',   GETDATE(), NULL, N'View Intend',  N'N'
)



INSERT INTO ActionMaster([ActionID],[ActionName],  [CreatedAt], [QueryString], [ActionCode],  [IsShareable])

SELECT @maxActionMaster+ROW_NUMBER()  over(order by  TEMP.[ActionName],TEMP.[QueryString], TEMP.[ActionCode]),   TEMP.[ActionName],  TEMP.[CreatedAt], TEMP.[QueryString], TEMP.[ActionCode],  TEMP.[IsShareable] FROM CTETEMPACTION TEMP
LEFT JOIN ActionMaster AC ON AC.ActionName=TEMP.ActionName AND AC.ActionCode=TEMP.ActionCode
WHERE AC.ActionName IS NULL

