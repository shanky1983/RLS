DECLARE                                                    
@pFrom DATETIME,                                      
@pTo DATETIME,                                        
@pLocationID INT,                                        
@pOrgID int,                                                 
@pOrgAddressID INT  

--exec pGetSalesReports @pFrom='01/07/2011 00:00:00',@pTo='13/07/2011 00:00:00',@pLocationID=0,@pOrgID=78,@pOrgAddressID=80                                            

DECLARE @Return AS BIGINT                                                                    
BEGIN                  
SET @Return = -1                                               
                 
 BEGIN               
 
 SELECT @pFrom='01/03/2011 00:00:00'
  SELECT @pTo='31/03/2011 23:59:59:998'
  
  --SELECT @pFrom,@pTo

           
 SET @pLocationID=Null                                   
 --SELECT @pFrom=CONVERT(datetime,@pFrom+' 00:00:00')          
 --SELECT @pTo=CONVERT(datetime,@pTo+' 23:59:59:998')          
     SELECT @pOrgID=78     
 END                    
                   
                  
BEGIN                   
              
DECLARE @Billdetails AS TABLE(   RowNo int identity(1,1),             
 FinalBillID BIGINT,          
 ReceiptNO bigint,             
 FeeID BIGINT,              
 BatchNo varchar(100),              
 Tax varchar(20),              
 Qty decimal(18,2),              
 Rate decimal(18,2),              
 Amt decimal(18,2)  ,          
 NetAmt decimal(18,2) ,          
 CreatedAt DATETIME ,            
   pType varchar(30),
   DEtailsID BIGINT,PID BIGINT 
)              
              
DECLARE @TaxAmountDetails AS TABLE(            
 FinalBillID BIGINT,          
 ReceiptNO bigint,             
 NetAmt decimal(18,2) ,            
 TaxAmount4 decimal(18,2),              
 TaxAmount5 decimal(18,2),            
 TaxAmount12 decimal(18,2),            
 TaxAmount13 decimal(18,2),              
 TaxAmount0 decimal(18,2),              
 Others decimal(18,2),          
 CreatedAt DATETIME             
)              
--today              
DECLARE @TaxAmountDetailsSum AS TABLE(                                    
 FinalBillID BIGINT,            
 ReceiptNO bigint,             
 NetAmt decimal(18,2) ,            
 TaxAmount4 decimal(18,2),              
 TaxAmount5 decimal(18,2),                                  
 TaxAmount12 decimal(18,2),             
 TaxAmount13 decimal(18,2),                                    
 TaxAmount0 decimal(18,2),                                    
 Others decimal(18,2) ,          
 CreatedAt DATETIME,Comments VARCHAR(50),Type VARCHAR(50)                                      
)     
    
 DECLARE @tblFinalBillingDetails TABLE (FinalBillID bigint, ReceiptNo bigint,BillingDetailsID bigint, isCreditBill Char(1), CreatedAt datetime)    
     
 INSERT INTO @tblFinalBillingDetails    
 EXEC pGetBillingDetailsByDateRange @pOrgID, @pFrom, @pTo  
 
 --Select * from @tblFinalBillingDetails  -- 79604
 
 INSERT INTO @Billdetails(FinalBillID,FeeID,BatchNo,Qty,Rate,ReceiptNO,NetAmt,CreatedAt,pType,DEtailsID,PID)              
 SELECT FB.FinalBillID,              
   FeeId,BatchNo,              
   Quantity,              
   Amount,isnull(T.ReceiptNo,0),Quantity*Amount,CONVERT(varchar,T.CreatedAt,103) ,'Bill',BD.BillingDetailsID,FB.PatientID             
 FROM FinalBill FB            
   INNER JOIN BillingDetails BD ON BD.FinalBillID=FB.FinalBillID --AND FeeType='PRM'               
   INNER JOIN @tblFinalBillingDetails T ON BD.BillingDetailsID = T.BillingDetailsID  AND FeeType='PRM'  
   --LEFT JOIN Patient P ON P.PatientID=FB.PatientID
 WHERE FB.OrgID=@pOrgID 
  UNION      all     
  SELECT FB.FinalBillID,                                
   FeeID,BatchNo,                                
   unit,                                
   Amount,isnull(InterimBillNo,0),unit*Amount,CONVERT(varchar,BD.CreatedAt,103) ,'Due',0,FB.PatientID   
 FROM FinalBill FB                          
   INNER JOIN PatientDueChart BD ON BD.VisitID=FB.VisitID AND FeeType='PRM' 
   --LEFT JOIN Patient P ON P.PatientID=FB.PatientID            
 WHERE CONVERT(varchar,BD.CreatedAt,103) BETWEEN @pFrom AND @pTo  and BD.Status in('Saved','Pending')  
 
 Select Count(1) from @Billdetails
 
 DECLARE @tblPatient Table (PatientID bigint)
 
 INSERT INTO @tblPatient 
 SELECT PatientID from Patient 
 Where PatientNumber not in (7851,6100,6755,8026,7205,7497,6442,8949,9268,7998,9529,
9732,10180,10817,11113,10875,10914)


 DELETE @Billdetails where FinalBillID not in(
 SELECT FinalBillID FROM FinalBill T INNER JOIN @tblPatient T1 ON T.PatientID=T1.PatientID)

Select Count(1) from @Billdetails

DECLARE @AMTREF table (BillingDetailsID BIGINT,Quantity DECIMAL )
 
 insert into @AMTREF
 SELECT BillingDetailsID, Quantity  FROM AmountRefundDetails AR
    INNER JOIN FinalBill FB  on  FB.FinalBillID=AR.FinalBillID   
	INNER JOIN PatientVisit PV On FB.VisitID = PV.PatientVisitId AND PV.VisitType=0  
    where RefundType='PHARMACY' 
    and   CONVERT(varchar,AR.CreatedAt,103) BETWEEN @pFrom AND @pTo
    
     UNION   all 
     
   SELECT BillingDetailsID, Quantity  FROM AmountRefundDetails AR
    INNER JOIN FinalBill FB  on  FB.FinalBillID=AR.FinalBillID   
    where RefundType='PHARMACY' AND FB.VisitID<=0   
    and   CONVERT(varchar,AR.CreatedAt,103) BETWEEN @pFrom AND @pTo
   
   --SELECT f.BillNumber , sum(Amount*(b.Quantity-a.Quantity)) FROM @AMTREF A inner join BillingDetails B on a.BillingDetailsID=b.BillingDetailsID
   --inner join FinalBill F on f.FinalBillID=b.FinalBillID
   --group by f.BillNumber
   
    update T SET t.Qty=t.Qty-t1.Quantity FROM @Billdetails T inner join @AMTREF T1 on T.DEtailsID=t1.BillingDetailsID
    where t.pType='Bill'
    
       
               
 --UPDATE T set T.Tax=              
 -- CASE              
 -- WHEN CONVERT(Varchar,S.Tax) IN ('4.00','5.00','12.50','14.50','0.00') THEN CONVERT(Varchar,S.Tax) + '%'              
 -- ELSE 'Others'              
 -- END, Amt=((Qty*Rate)*S.Tax)/100              
 --FROM @Billdetails T INNER JOIN StockInHand S ON S.ProductID=T.FeeID  and S.BatchNo=T.BatchNo         
           
   select  SUM(Qty*Rate) NetAmount from @Billdetails
  
  
   select Tax, SUM(Qty*Rate) NetAmount from @Billdetails
  GROUP BY  Tax
  
  
             
                
                   
 
SET @Return=0                                      
END                        
                  
                  
END                          