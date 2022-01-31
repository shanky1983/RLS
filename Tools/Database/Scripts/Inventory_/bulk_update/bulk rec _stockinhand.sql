
DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT   primary key (proID,batchNo,Locid))
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT   primary key (proID,batchNo,Locid))
DECLARE @tb3 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT   primary key (proID,batchNo,Locid))

 
 
	

DECLARE @tbLocation AS TABLE([RowNO] int identity(1,1),          
   LocationID int) 
DECLARE @RowNo INT  
DECLARE @LocationID INT

--SELECT distinct LocationID,OrgID,o.Name FROM StockReceivedDetails t inner join Organization o on t.OrgID=o.OrgID order by LocationID
   

INSERT @tbLocation(LocationID)
SELECT LocationID from Locations where   LocationID=138

--SELECT distinct orgid FROM Locations

 
 declare @orgid int ,@orgaddid int

-------------------STOCKINHAND-------------------------
 BEGIN     
SELECT @RowNo=COUNT(*) FROM @tbLocation 
	WHILE @RowNo>0 
	 BEGIN
 
	 SELECT @LocationID=LocationID FROM @tbLocation WHERE RowNO=@RowNo
	 SELECT  @OrgID=orgid, @orgaddid=OrgAddressID FROM Locations where LocationID=@LocationID
	 


insert into  @tb1
select ProductID,ProductKey,sum((RcvdLSUQty)+(ISNULL(ComplimentQTY,0))),LocationID
	from StockReceivedDetails (nolock) s 
	inner join StockReceived (nolock) d on d.StockReceivedID=s.StockReceivedId  and d.Status in ('Approved','Received')  where LocationID=@LocationID
	group by ProductID,ProductKey,LocationID 

insert into  @tb2
select ProductID,s.ProductKey ,s.TotalStockReceived,LocationID from StockInHand (nolock) s  where LocationID=@LocationID

	 
insert into  @tb3
	 SELECT distinct t.* FROM @tb1 T Left join @tb2 T1 on T.batchNo=T1.batchNo and t.proID=T1.proID and t.Locid=T1.Locid
	 where T.Locid=@LocationID and T1.batchNo is null and t.qty>0
	 
	 
	 
	   
      
       INSERT INTO StockInHand(OrgID,ProductID, TotalStockReceived,                                      
      CreatedBy,CreatedAt, OrgAddressID,  BatchNo,ExpiryDate,
      Tax,SellingPrice,SellingUnit,LocationID,AttributeDetail,
      TotalUsageLimit,RakNo ,MRP,CostPrice,ProductKey,TotalStockIssued )                                                               
   SELECT distinct @orgid,  S.proID,S.Qty,
      1,MAX(StockReceivedDate),@orgaddid,(t.batchNo),
       (T.ExpiryDate),max(t.Tax), T.SellingPrice,t.SellingUnit,
      @LocationID,'N',0,
     null,max(isnull(t.MRP,0)) ,isnull(t.UnitPrice,0),t.ProductKey,qty
   FROM @tb3 S inner join StockReceivedDetails (nolock) t on t.ProductKey=S.batchNo AND t.ProductId=S.proID
   WHERE T.LocationID =@LocationID    and Qty>0 
   group by (t.batchNo),
       (T.ExpiryDate),  T.SellingPrice,t.SellingUnit,t.UnitPrice,t.ProductKey,S.proID,S.Qty
   order by ProductKey   
  
     --SELECT distinct  * FROM @tb2 T Left join @tb1 T1 on T.batchNo=T1.batchNo and t.proID=T1.proID and t.Locid=T1.Locid
	 --where T.Locid=@LocationID and T1.batchNo is null
	 	 
	 	 DELETE @tb1
	 	 DELETE @tb2
	 
	SET @RowNo=@RowNo-1
	END
END

	 
	 
  