/****** Object:  StoredProcedure [dbo].[pGetPurchaseOrderReport]    Script Date: 05/17/2010 13:04:58 ******/      
       
--CREATE PROCEDURE [dbo].[pGetPurchaseOrderReport]                                                        
--(                                        
-- @pFrom DATETIME,                          
-- @pTo DATETIME,                            
-- @pLocationID INT,                            
-- @pOrgID INT,                                     
-- @pOrgAddressID INT                                  
--)                                   
--AS                                                        
--DECLARE @Return AS BIGINT                                                        
BEGIN                                    
--SET @Return = -1                                   
         
 --IF (@pLocationID=0)        
 -- SET @pLocationID=Null                       
      
       
 DECLARE @StocRecdDetails TABLE(SrdDetailID BIGINT IDENTITY(1,1) , SrdID BIGINT,       
         
  Tax varchar(20),        
  Qty decimal(18,2),        
  Rate decimal(18,2),        
  Amt decimal(18,2))  
  
  DECLARE @StocRecdDetails1 TABLE(SrdDetailID BIGINT IDENTITY(1,1) , SrdID BIGINT,       
         
  Tax varchar(20),        
  Qty decimal(18,2),        
  Rate decimal(18,2),        
  Amt decimal(18,2))      
       
          
DECLARE @TaxAmountDetails AS TABLE(        
 SrdID BIGINT,        
 TaxAmount4 decimal(18,2),        
 TaxAmount12 decimal(18,2),        
 TaxAmount0 decimal(18,2), Others decimal(18,2)  ,     
 TaxableAmount4 decimal(18,2),        
 TaxableAmount12 decimal(18,2),        
 TaxableAmount0 decimal(18,2)        
  
)
DECLARE @Tb table(Date Datetime,InvoiceNo varchar(500),SupplierName
 varchar(500),TinNo varchar(500),TaxPaid decimal(18,2),TaxAmountble decimal(18,2),NetAmount decimal(18,2),Tax decimal(18,2))
 
 




             
         
         
 BEGIN            
 --SELECT COUNT(*) FROM (   
      
 INSERT INTO @StocRecdDetails(SrdID,Tax,Rate,Qty,Amt) 
 SELECT   S.StockReceivedId,     
    CASE        
    WHEN CONVERT(Varchar,SRD.Tax) IN ('4.00','5.00','12.50','13.50','14.50','0.00') THEN CONVERT(Varchar,SRD.Tax) else '1000' end,      
    UnitPrice,      
    RcvdLSUQty,      
    (UnitPrice*RcvdLSUQty)       
 FROM   StockReceivedDetails SRD INNER JOIN StockReceived S ON S.StockReceivedID=srd.StockReceivedId                      
 WHERE   S.StockReceivedDate BETWEEN '01/09/2011 00:00:00:000' AND '30/09/2011 23:59:59:997' 
    AND SRD.LocationID = 17  AND ISNULL(S.SupplierID,0) >0  
    order by SRD.tax
    
    
   insert into @StocRecdDetails1(SrdID,Tax,Amt) 
    SELECT t.SrdID,t.Tax,sum(t.Amt)  FROM @StocRecdDetails  t
    group by t.SrdID,t.Tax
    
 --   DECLARE @Tb table(Date Datetime,InvoiceNo varchar(500),SupplierName
 --varchar(500),TinNo varchar(500),TaxPaid decimal(18,2),TaxAmountble decimal(18,2),
 --NetAmount decimal(18,2),Tax decimal(18,2))
 

    
    SELECT Convert(varchar,r.StockReceivedDate,103) Date , InvoiceNo,SupplierName, TinNo,
    (s.Amt*s.Tax/100) [Tax Paid],
    amt -(s.Amt*s.Tax/100) [Tax Amountble],
    amt [Net Amount] ,S.Tax
     FROM @StocRecdDetails1 S inner join StockReceived R on R.StockReceivedID=S.SrdID 
    inner join Suppliers P on P.SupplierID=r.SupplierID where s.Tax<>'1000'
    order by S.Tax,StockReceivedDate
    
    
         
      
--pGetPurchaseOrderReport '01/10/2010','31/10/2010',1,11,21      
        
      
    --SELECT * FROM @StocRecdDetails order by SrdID  
        
 --INSERT INTO @TaxAmountDetails (SrdID,TaxAmount4,TaxAmount12,TaxAmount0,Others)         
 --SELECT SrdID,         
 --  isNull([4.00%],'0')  as '4.00%',        
 --  isNull([12.50%],'0') as '12.50%',        
 --  isNull([0.00%],'0')  as '0.00%',        
 --  isNull([Others],'0') as 'Others'  
 --FROM                           
 -- (SELECT SrdDetailID,SrdID,Qty,Tax,Rate,Amt                  
 --  FROM @StocRecdDetails) ss                          
 --   PIVOT                          
 --   (          
 --    SUM(amt)        
 -- FOR Tax IN                          
 -- ([4.00%],[12.50%],[0.00%],[Others] )        
 --) AS pvt        
         
    
   
            
       
--SELECT FB.StockReceivedDate Date, 
--		FB.InvoiceNo,     
--		DCNumber,
--		SupplierName,
--		S.TinNo,
--		d.SrdID,	
--		SUM(d.TaxAmount4) TaxAmount4,      
--		SUM(d.TaxAmount12) TaxAmount12,      
--		SUM(d.TaxAmount0) TaxAmount0
--FROM @StocRecdDetails d inner join StockReceived FB on D.SrdID=FB.StockReceivedID
--INNER JOIN  Suppliers S on S.SupplierID=FB.SupplierID 
--    GROUP BY FB.StockReceivedDate , d.SrdID,
--		FB.InvoiceNo,     
--		DCNumber,
--		SupplierName,
--		S.TinNo 
      
       
 --SELECT       
 -- FB.StockReceivedDate PurchaseOrderDate,       
 -- FB.StockReceivedNo PurchaseOrderNo,       
 -- FB.GrandTotal-FB.Discount NetValue ,      
 -- (FB.GrandTotal-FB.Discount)-(SUM(d.TaxAmount4)+SUM(d.TaxAmount12)+SUM(d.TaxAmount0)+SUM(d.Others)) GrandTotal,           
 -- SUM(d.TaxAmount4) TaxAmount4,      
 -- SUM(d.TaxAmount12) TaxAmount12,      
 -- SUM(d.TaxAmount0) TaxAmount0,      
 -- SUM(d.Others) Others,    
 -- SUM(d.TaxableAmount4)-SUM(d.TaxAmount4) TaxableAmount4,      
 -- SUM(d.TaxableAmount12)-SUM(d.TaxAmount12) TaxableAmount12,      
 -- SUM(d.TaxableAmount0)-SUM(d.TaxAmount0) TaxableAmount0,    
 -- SupplierName,          
 -- CASE ISNULL(FB.InvoiceNo,'') WHEN '' then      
 -- DCNumber      
 -- ELSE      
 -- FB.InvoiceNo      
 -- END  InvoiceNo,      
 -- S.TinNo      
        
 --FROM StockReceived FB INNER JOIN @TaxAmountDetails d  ON d.SrdID=FB.StockReceivedID       
 --INNER JOIN  Suppliers S on S.SupplierID=FB.SupplierID      
       
 --GROUP BY d.SrdID,FB.CreatedAt,FB.Discount, FB.StockReceivedNo, FB.GrandTotal,StockReceivedDate ,         
 -- SupplierName,          
 -- FB.InvoiceNo,DCNumber,          
 -- S.TinNo      
 --SET @Return=0                          
 --END            
          
--RETURN @Return                                                        
          
END 
end 

  