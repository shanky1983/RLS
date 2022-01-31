;WITH SalesCTE(ProductKey,ProductID,BatchNo,locid,RowNo )
AS
(
SELECT
	ProductKey,ProductID,BatchNo,LocationID,
Ranking = DENSE_RANK() OVER(PARTITION BY ProductID, ProductKey, locationid ORDER BY NEWID() ASC)
FROM StockInHand  --where BatchNo=''
)
select * FROM SalesCTE
--DELETE FROM SalesCTE
WHERE RowNo > 1 --and locid not in(14,25,4)

--SELECT * FROM StockInHand where ProductKey='35918@#$3493EM@#$Aug/2014@#$6.25@#$81.35@#$Nos' and LocationID=14

--SELECT * FROM StockInHand where ProductKey='37390@#$OC/ZT/003@#$Nov/2012@#$3.30@#$3.30@#$Nos' and LocationID=14
--SELECT * FROM StockReceivedDetails where ProductKey='37390@#$OC/ZT/003@#$Nov/2012@#$3.30@#$3.30@#$Nos' and LocationID=14
--update StockInHand set TotalStockReceived=TotalStockReceived+1050.00 where StockInHandID=115451