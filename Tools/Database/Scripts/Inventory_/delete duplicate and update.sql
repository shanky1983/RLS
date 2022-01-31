

select * into StockInHand_Dump from StockInHand
--begin tran
--select * into tempstockinhand from StockInHand


select ProductKey, Locationid, productid, sum(TotalStockReceived) TotalStockReceived, 
sum(TotalStockIssued) TotalStockIssued, sum(TotalStockReturn) TotalStockReturn, sum(TotalStockDamage) TotalStockDamage,
SUM(TotalLocationIssued) TotalLocationIssued
Into StockInHand_Manipulate 
from StockInHand with (Tablockx) group by ProductKey, Locationid, productid

Update temp 
Set temp.TotalStockReceived = manip.TotalStockReceived,
temp.TotalStockIssued = manip.TotalStockIssued,
temp.TotalStockReturn = manip.TotalStockReturn,
temp.TotalStockDamage = manip.TotalStockDamage,
temp.TotalLocationIssued = manip.TotalLocationIssued
From StockInHand temp, StockInHand_Manipulate manip
Where temp.ProductKey = manip.ProductKey
and temp.Locationid = manip.Locationid
and temp.productid = manip.productid

SELECT * FROM StockInHand with (tablockx) where StockInHandid not in (select MAX(StockInHandid) from StockInHand group by ProductKey, Locationid, productid)

Delete StockInHand with (tablockx) where StockInHandid not in (select MAX(StockInHandid) from StockInHand group by ProductKey, Locationid, productid)
commit