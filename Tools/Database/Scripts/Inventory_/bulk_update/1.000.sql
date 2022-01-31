;WITH SalesCTE(ProductID,BatchNo,locid,RowNo )
AS
(
SELECT
	ProductID,BatchNo,LocationID,
Ranking = DENSE_RANK() OVER(PARTITION BY ProductID,BatchNo, locationid ORDER BY NEWID() ASC)
FROM StockInHand  --where BatchNo=''
)
--select * FROM SalesCTE
DELETE FROM SalesCTE
WHERE RowNo > 1