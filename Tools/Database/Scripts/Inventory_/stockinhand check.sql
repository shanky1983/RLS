DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT) --primary key(proID,batchNo,Locid))
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT) --primary key(proID,batchNo,Locid))

insert @tb1
SELECT ProductID,ProductKey,TotalLocationIssued+TotalStockDamage+TotalStockIssued+TotalStockReturn,LocationID FROM StockInHand (nolock)
 
insert @tb2(proID,batchNo,Qty,Locid)
SELECT ProductID,ProductKey,SUM(Quantity),LocationID FROM StockOutFlowDetails (nolock) where   BatchNo is not null --and Description='AD'
group by ProductID,ProductKey ,LocationID 

SELECT  t2.proID,t2.batchNo,t2.Qty [OUT] ,t1.Qty [IN] ,T1.Locid FROM @tb1 t1 inner join @tb2 t2
on T1.proID=T2.proID and T1.batchNo=T2.batchNo and T1.Locid=T2.Locid
where T1.Qty<>T2.Qty  


DELETE @tb1
DELETE @tb2

insert into  @tb1
select ProductID,ProductKey ,sum((RcvdLSUQty)+(ISNULL(ComplimentQTY,0))),LocationID
	from StockReceivedDetails(nolock) s 
	inner join StockReceived (nolock) d on d.StockReceivedID=s.StockReceivedId  and d.Status in ('Approved','Received')  
	group by ProductID,ProductKey,LocationID 
 
--insert @tb3
 select ProductID,s.ProductKey ,t.Qty,s.TotalStockReceived,Locid from StockInHand (nolock) s 
	inner join @tb1 t  on t.proID=S.ProductID and s.ProductKey=T.BatchNo and LocationID=Locid
	WHERE  s.TotalStockReceived<>t.Qty 
 


