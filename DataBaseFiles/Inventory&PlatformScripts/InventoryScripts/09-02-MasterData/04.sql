 
DECLARE @OrgID INT =112
	DECLARE @RoleID Bigint
	DECLARE @SearchTypeID int 
	DECLARE @ActionID int,@PageID int

 
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/PurchaseOrder/PurchaseOrderQuantity.aspx')	
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'PurchaseOrderQuantity','/PurchaseOrder/PurchaseOrderQuantity.aspx' 
	

END
	ELSE 
		BEGIN 
		SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/PurchaseOrder/PurchaseOrderQuantity.aspx')		
		END
	SET @SearchTypeID=14
	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='Approve Order' AND ActionCode='Approve_Order_PurchaseOrderQuantity'
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	-----------------------------------------------------------------------------------------------	
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/PurchaseOrder/ViewPurchaseOrder.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'View Purchase Order','/PurchaseOrder/ViewPurchaseOrder.aspx' 
	

END
	ELSE 
		BEGIN 
		SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/PurchaseOrder/ViewPurchaseOrder.aspx')
		END 
		
		SET @SearchTypeID=14

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='View & Print Order' AND ActionCode='View_Print_Order_ViewPurchaseOrder'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
------------------------------------------------------------------------------------------------------------------
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockReceived/UpdateStockReceived.aspx')
BEGIN 
    SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'UpdateStockReceived','/StockReceived/UpdateStockReceived.aspx' 
	
END	
	ELSE 
		BEGIN 
		SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockReceived/UpdateStockReceived.aspx' )
		END 
		
		SET @SearchTypeID=15

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='Approve Order' AND ActionCode='Approve_Order_UpdateStockReceived'
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID
	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)	
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	
-------------------------------------------------------------

IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockReceived/ViewStockReceived.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'View Receive Stock','/StockReceived/ViewStockReceived.aspx' 
	


END
	ELSE 
		BEGIN 
		SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockReceived/ViewStockReceived.aspx')
		END 

 SET @SearchTypeID=15

--	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='View & Print Order' AND ActionCode='View_Print_Order_ViewPurchaseOrder'	

--SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID
--	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
--	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
--	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
--	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
--	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID
--	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
--	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
--	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
--	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
--------------------------------------------------------------------------------------------------
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockOutFlow/ViewStockDamage.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'View Stock Damage','/StockOutFlow/ViewStockDamage.aspx' 

END
ELSE	
	BEGIN 
		SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockOutFlow/ViewStockDamage.aspx')
	END 

	SET @SearchTypeID=16

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='View & Print Order' AND ActionCode='View_Print_Order_ViewPurchaseOrder'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)

-----------------------------------------------------------------------
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockOutFlow/ViewStockIssued.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'View Stock Issued','/Inventory/ViewStockIssued.aspx' 
	



END
ELSE 
	BEGIN 
	SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/Inventory/ViewStockIssued.aspx')
	END 
	SET @SearchTypeID=17

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='View & Print Order' AND ActionCode='View_Print_Order_ViewPurchaseOrder'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)


-----------------------------------------------------------------
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockReturn/ViewStockReturn.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'View Stock Issued','/StockReturn/ViewStockReturn.aspx' 	

END
ELSE
	BEGIN 
	SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockReturn/ViewStockReturn.aspx')
	END

SET @SearchTypeID=18

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='View & Print Order' AND ActionCode='View_Print_Order_ViewPurchaseOrder'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)

----------------------------------------------------------------------------------------------------------------------------------

IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockIntend/ReceivedIndent.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'Received Indent','/StockIntend/ReceivedIndent.aspx' 	
END
	ELSE 	
		BEGIN 
			SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockIntend/ReceivedIndent.aspx' )
		END 
		
		SET @SearchTypeID=21

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='Received Indent' AND ActionCode='Received Indent'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
-------------------------------------------------------------------------------------------------
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockIntend/ViewIntendDetail.aspx' )
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'View Intend','/StockIntend/ViewIntendDetail.aspx' 
	


END
ELSE	
	BEGIN 
	SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockIntend/ViewIntendDetail.aspx')
	END 
	SET @SearchTypeID=21

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='View Intend' AND ActionCode='View Intend'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID		
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
----------------------------------------------------------------
IF NoT EXISTS(SELECT 1 FROM Pages WHERE PAGEURL ='/StockIntend/IssueStock.aspx')
BEGIN 
	SELECT @PageID=(SELECT MAX(pageid) FROM Pages) 
	SELECT @PageID=isnull(@PageID,0)+1

	insert Pages(PageID,PageName,PageURL)
	SELECT @PageID ,'Issue Intend','/StockIntend/IssueStock.aspx' 

END
ELSE
	BEGIN 
	SELECT @PageID=(SELECT pageid FROM Pages WHERE PAGEURL ='/StockIntend/IssueStock.aspx')
	END 
	SET @SearchTypeID=21

	SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionName='Issued Stock' AND ActionCode='Issue Intend'
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID
	SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'InventoryAdmin' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	
	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Inventory' AND OrgID=@OrgID	
	INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,'Y' 
	WHERE Not EXISTS(SELECT 1 FROM ActionRoleMapping 
	WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
--COMMIT
--rOLLBACK