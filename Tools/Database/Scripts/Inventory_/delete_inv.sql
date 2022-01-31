--update StockOutFlowDetails set Quantity-=60 where StockOutFlowDetailsID=14370
--update StockOutFlowDetails set Quantity-=10 where StockOutFlowDetailsID=15061
--update StockOutFlowDetails set Quantity-=10 where StockOutFlowDetailsID=44139 
--update StockOutFlowDetails set Quantity-=10 where StockOutFlowDetailsID=14599 
--update StockOutFlowDetails set Quantity-=1 where StockOutFlowDetailsID=14035
--update StockOutFlowDetails set Quantity-=1 where StockOutFlowDetailsID=14147
--update StockOutFlowDetails set Quantity-=1 where StockOutFlowDetailsID=99044
--update StockOutFlowDetails set Quantity-=1 where StockOutFlowDetailsID=15109
--update StockOutFlowDetails set Quantity-=1 where StockOutFlowDetailsID=14670
--delete StockOutFlowDetails  where StockOutFlowDetailsID=117632
--INSERT INTO StockOutFlowDetails(StockOutFlowID, AttributeDetail,LocationID,OrgAddressID,OrgID,ProductID,Quantity,StockOutFlowDate,Unit)
--SELECt StockOutFlowID,AttributeDetail,LocationID,OrgAddressID,OrgID,1835,1,StockOutFlowDate,Unit from StockOutFlowDetails WHERE StockOutFlowDetailsID=1835
--update StockOutFlowDetails set Quantity=6 where StockOutFlowDetailsID=115090
--update StockOutFlowDetails set Quantity+=1 where StockOutFlowDetailsID=118425
--update StockOutFlowDetails set Quantity+=1 where StockOutFlowDetailsID=118425

----------------SELECt * from StockOutFlowDetails WHERE ProductID=4784 AND LocationID=7  AND StockOutFlowID=40957

----------------SELECt SUM((TotalStockIssued+TotalStockReturn+TotalStockDamage+TotalLocationIssued)) from StockInHand WHERE ProductID=4784 AND LocationID=7 
----------------SELECt SUM(Quantity) from StockOutFlowDetails WHERE ProductID=4784 AND LocationID=7 
