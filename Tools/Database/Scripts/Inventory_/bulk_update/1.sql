DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)


--insert into  @tb1
--select ProductID,BatchNo,sum((RcvdLSUQty)+(ISNULL(ComplimentQTY,0))),LocationID
--	from StockReceivedDetails s 
--	inner join StockReceived d on d.StockReceivedID=s.StockReceivedId  and d.Status in ('Approved','Received')  
--	group by ProductID,BatchNo,LocationID 
	
--	--SELECT * FROM @tb1 where proID=6307
	
--	select s.TotalStockReceived,t.Qty,Locid from StockInHand s 
--	inner join @tb1 t  on t.proID=S.ProductID and s.batchNo=T.BatchNo and LocationID=Locid
--	WHERE  s.TotalStockReceived<t.Qty  
	 
	 --SELECT * FROM StockReceivedDetails where ProductId=9070

	 
--UPDATE s SET TotalStockReceived=t.Qty
--		from @tb1 t 
--	inner join StockInHand s on t.proID=S.ProductID and s.batchNo=T.BatchNo and LocationID=Locid
--	WHERE
--	 t.Qty<>s.TotalStockReceived 
---------------------------------------------	


delete @tb1
delete @tb2


  

insert @tb1
SELECT ProductID,ProductKey,TotalLocationIssued+TotalStockDamage+TotalStockIssued+TotalStockReturn,LocationID FROM StockInHand 
 
insert @tb2(proID,batchNo,Qty,Locid)
SELECT ProductID,ProductKey,SUM(Quantity),LocationID FROM StockOutFlowDetails where   BatchNo is not null --and Description='AD'
group by ProductID,ProductKey ,LocationID 

DECLARE @tb3 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)

insert @tb3
SELECT  t2.proID,t2.batchNo,t2.Qty-t1.Qty,T1.Locid FROM @tb1 t1 inner join @tb2 t2
on T1.proID=T2.proID and T1.batchNo=T2.batchNo and T1.Locid=T2.Locid
where T1.Qty<T2.Qty  


SELECT TotalStockIssued+t.qty,TotalStockReceived+Qty from StockInHand s 
	inner join @tb3 t  on t.proID=S.ProductID and s.ProductKey=T.batchNo and LocationID=Locid 

	 



--update s set TotalStockIssued=TotalStockIssued+t.qty,TotalStockReceived=TotalStockReceived+Qty from StockInHand s 
--	inner join @tb3 t  on t.proID=S.ProductID and s.ProductKey=T.batchNo and LocationID=Locid 

	 