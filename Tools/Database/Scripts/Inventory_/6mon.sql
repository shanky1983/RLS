
    
     
    
  --[pGetSalesTaxReport_kmh]'01/03/2011','31/03/2011' ,1,11,21  
DECLARE                                                           
@pFrom DATETIME,                                              
@pTo DATETIME

SELECT  @pFrom='01/06/2011' 
SELECT  @pTo='30/06/2011'                                               
                                              
                      
BEGIN      

SELECT @pFrom=CONVERT(datetime,@pFrom+'00:00:00')
SELECT @pTo=CONVERT(datetime,@pTo+'23:59:59:998')

DECLARE @Billdetails AS TABLE( RowNo int identity(1,1),                     
 FinalBillID BIGINT ,                      
 FeeID BIGINT,                      
 BatchNo varchar(100),                      
 Tax varchar(20),                      
 Qty decimal(18,2),                      
 Rate decimal(18,2),                      
 Amt decimal(18,2)              
)                     
  
                    
DECLARE @tblFinalBillingDetails TABLE (FinalBillID bigint, ReceiptNo bigint,BillingDetailsID bigint, isCreditBill Char(1), CreatedAt datetime)    
     
 INSERT INTO @tblFinalBillingDetails    
 EXEC pGetBillingDetailsByDateRange 78, @pFrom, @pTo    
     
 --SELECT * FROM @tblFinalBillingDetails Order By FinalBillID    
                 
 INSERT INTO @Billdetails(FinalBillID,FeeID,BatchNo,Qty,Rate)              
 SELECT FB.FinalBillID,                      
  FeeId,                      
  BatchNo,                      
  Quantity,                      
  Amount                    
 FROM FinalBill FB            
   INNER JOIN BillingDetails BD ON BD.FinalBillID=FB.FinalBillID --AND FeeType='PRM'               
   INNER JOIN @tblFinalBillingDetails T ON BD.BillingDetailsID = T.BillingDetailsID  AND FeeType='PRM'     
 WHERE FB.OrgID=78 and FB.PatientID not in(
14775,
13085,
14514,
13379,
12332,
15273,
15861,
16034,
16026,
14406,
16403,
15931,
15521,
16484,
16920,
12005,
14011,
17222
) 
         
  UNION      all     
  SELECT FB.FinalBillID,                      
  FeeId,                      
  BatchNo,                      
  unit,                      
  Amount                                     
 FROM FinalBill FB                          
   INNER JOIN PatientDueChart BD ON BD.VisitID=FB.VisitID AND FeeType='PRM'             
 WHERE CONVERT(varchar,BD.CreatedAt,103) BETWEEN @pFrom AND @pTo  and BD.Status in('Saved','Pending')   
 and FB.PatientID not in(
14775,
13085,
14514,
13379,
12332,
15273,
15861,
16034,
16026,
14406,
16403,
15931,
15521,
16484,
16920,
12005,
14011,
17222
)        

 
 
      
--INSERT INTO @Billdetails(FinalBillID,FeeID,BatchNo,Qty,Rate)                      
--SELECT FB.FinalBillID,                      
--  FeeId,                      
--  BatchNo,                      
--  Quantity,                      
--  Amount                      
--FROM FinalBill FB                
--  INNER JOIN BillingDetails BD ON BD.FinalBillID=FB.FinalBillID AND FeeType='PRM'                       
--WHERE BD.CreatedAt BETWEEN @pFrom AND @pTo 

--UNION ALL
--SELECT FB.FinalBillID,                      
--  FeeId,                      
--  BatchNo,                      
--  unit,                      
--  Amount                      
--FROM FinalBill FB                
--  INNER JOIN PatientDueChart BD ON BD.VisitID=FB.VisitID AND FeeType='PRM'   
--WHERE BD.CreatedAt BETWEEN @pFrom AND @pTo  and BD.Status in('saved','Pending')
--and bd.PatientID not in(
--10914,
--9945,
--10583,
--10535,
--3968,
--12059,
--12476,
--12796,
--2017,
--12796,
--2017,
--12799,
--12974,
--9945,
--13037,
--13053,
--13433,
--13360,
--13353,
--13284,
--13458,
--14310

--) 

SELECT SUM(Rate*Qty) FROM @Billdetails





  
               
 UPDATE T set T.Tax=                      
  CASE                      
  WHEN CONVERT(Varchar,S.Tax) IN ('4.00','12.50','0.00') THEN CONVERT(Varchar,S.Tax)                       
  ELSE 'Others'                      
  END, Amt=((Qty*Rate)*S.Tax)/100                      
 FROM @Billdetails T INNER JOIN StockInHand S ON S.ProductID=T.FeeID --AND S.BatchNo=T.BatchNo 
 
 SELECT tax ,
  Sum(amt) 
   [Taxble Amount],
 (SUM(Rate*Qty)) [Net Amount]
 FROM @Billdetails where Tax <>'Others'
 group by Tax
 order by Tax desc
 
                      
        
            
       
 --INSERT INTO @TaxAmountDetails (FinalBillID,TaxAmount4,TaxAmount12,TaxAmount0,Others,TaxPayable4,TaxPayable12,TaxPayable0,OthersTaxAmt)                       
 --SELECT FinalBillID,                       
 --  isNull([4.00%],'0')  as '4.00%',                
 --  isNull([12.50%],'0') as '12.50%',                
 --  isNull([0.00%],'0')  as '0.00%',                
 --  isNull([Others],'0') as 'Others',          
 --   Qty*Rate,      
 --   Qty*Rate,    
 --   Qty*Rate,  
 --   Qty*Rate  
                     
 --FROM                                         
 -- (SELECT RowNo, FinalBillID,FeeID,BatchNo,Qty,Tax,Rate,amt                                
 --  FROM @Billdetails) ss                                        
 --   PIVOT                               
 --   (                        
 --    SUM(amt)                      
 -- FOR Tax IN                                        
 -- ([4.00%],[12.50%],[0.00%],[Others] )                      
 --) AS pvt                      
             
 ----SELECT * FROM  @TaxAmountDetails
         
 --UPDATE TAD SET TAD.TaxPayable4=                    
 --    CASE                    
 --     WHEN TAD.TaxAmount4>0 THEN TAD.TaxPayable4                    
 --    ELSE 0.0                    
 --    END                     
 --    ,TAD.TaxPayable12=                    
 --    CASE                    
 --     WHEN TAD.TaxAmount12>0 THEN TAD.TaxPayable12                    
 --    ELSE 0.0                    
 --    END                    
 --    ,TAD.TaxPayable0=                    
 --    CASE                    
 --     WHEN (TAD.TaxAmount4=0.0 and TAD.TaxAmount12=0.0 and TAD.TaxAmount0=0.0 and TAD.Others=0) THEN TAD.TaxPayable0                    
 --    ELSE 0.0    
 --     END
 --     ,TAD.OthersTaxAmt= 
 --     CASE                    
 --    WHEN (TAD.Others>0 AND TAD.TaxAmount4=0.0 and TAD.TaxAmount12=0.0 and TAD.TaxAmount0=0.0 ) 
 --    THEN TAD.OthersTaxAmt                    
 --    ELSE 0.0    
 --     END                          
 --    FROM @TaxAmountDetails TAD  
                       
     
 --  --SELECT * FROM  @TaxAmountDetails
       
             
 -- SELECT                 
 --  sum(d.TaxAmount4) TaxAmount4,
 --  sum(d.TaxAmount12) TaxAmount12,
 --  sum(d.TaxAmount0) TaxAmount0,
 --  sum(d.Others) Others     ,                    
 --  sum(d.TaxPayable4)-sum(d.TaxAmount4) as TaxPayable4,
 --  sum(d.TaxPayable12)-sum(d.TaxAmount12) as TaxPayable12,
 --  sum(d.TaxPayable0)- sum(d.TaxAmount0) as TaxPayable0,   
 --  sum(d.OthersTaxAmt)- sum(d.Others) as OthersTaxAmt                    
 -- FROM @TaxAmountDetails d   
  
 --  SELECT                 
                   
 --  sum(d.TaxPayable4) +
 --  sum(d.TaxPayable12)+
 --  sum(d.TaxPayable0)+
 --  sum(d.OthersTaxAmt)                 
 -- FROM @TaxAmountDetails d                      
       
                     
                                           
END                                
                          

                          

                 

  
                 

