--sp_helptext GetMISReportDetails_v1                            

--exec [20GetMISReportDetails] 68,'CurrentMonth',''                        

CREATE PROC [dbo].[GetMISReportDetails](@orgid int,@Pparamtype varchar(100),@Pparamvalue varchar(100))                                   

AS                                                      

Begin                                                  

set nocount ON                                       

--'10-02-2015 12:55' AND '18-02-2015 12:55:18'                                      

declare @Orgid int=68
Declare @Fromdate datetime='2016-01-01 00:00:00',@Todate datetime='2016-04-09 23:59:59'                                        

                                      

--if isnull(@Pparamtype,'CurrentMonth') = 'CurrentMonth'                                        

--Begin                                        

-- select @Fromdate = dateadd(m,0,cast(DATEADD(D,1-DATEPART(d,getdate()),GETDATE()) as date))                                        

-- select @Todate  = GETDATE()                                        

--End                                 

                                

                                      

--if isnull(@Pparamtype,'LastMonth') = 'LastMonth'                                        

--Begin                                        

--select @Fromdate = dateadd(m,-1,cast(DATEADD(D,1-DATEPART(d,getdate()),GETDATE()) as date))                                        

--select @Todate  = cast(DATEADD(D,1-DATEPART(d,getdate()),GETDATE()) as date)                                        

--End                                 

                                                    

DECLARE @patient TABLE                                                  

        (                                                  

           visitdate       VARCHAR(50),                                                  

           VisitNumber     VARCHAR(50),                                                  

           PatientName     VARCHAR(100),                                                  

           Doctorname      VARCHAR(max),                                                  

           InstitutionName VARCHAR(max),                                                  

           ClientName      VARCHAR(max),                                                  

           ClientCity      VARCHAR(100),                                                  

           PhysicianCity   VARCHAR(100),      

           PatientCity     Varchar(100),                                                  

           FinalMRP        DECIMAL(10, 2),                                                  

           FinalDiscount   DECIMAL(10, 2),                                                  

           NetReceivable   DECIMAL(10, 2),                                                  

           testname        VARCHAR(max),                                                  

           amount          DECIMAL(10, 2),                                                  

           FeeId           VARCHAR(100),                                                  

           FeeDescription  VARCHAR(max),                                                  

           FeeType         VARCHAR(100),                                                  

           FinalBillID     VARCHAR(100),                                                  

           dueamount       DECIMAL(10, 2)       ,                  

           Famount decimal(10,2),        

           Testcode     VARCHAR(20),        

            VisitID         INT ,
			
			PatientPhoneNumber varchar(20),
			Email Varchar(50)                                       

        )                                                  

                                                  

      INSERT INTO @patient                                                  

                  (visitdate,                                                  

                   VisitNumber,                                                  

                   PatientName,                      

    Doctorname,                                                  

                  InstitutionName,                                                  

                   ClientName,                                                  

                   ClientCity,                               

                   PhysicianCity,      

                   PatientCity,                                                  

                   FinalMRP,                     

                   FinalDiscount,                                                  

                   NetReceivable,                                                  

                   testname,                                                  

                   FeeId,               

                   FeeDescription,                                                  

                   FeeType,                                    

                   FinalBillID,        

                   VisitID ,      

                   TestCode,
				   PatientPhoneNumber,
			      Email      

                   )                                                  

      SELECT  CONVERT(VARCHAR, Pv.visitdate, 103),                                                  

                      PV.VisitNumber   casenumber,                                                  

                      S.TitleName + '' + P.NAME                      AS PatientName,                                                  

     ( CASE                                                  

                          WHEN PV.ReferingPhysicianID = 0                                                  

                                OR PV.ReferingPhysicianID = -1 THEN ''                                                  

                          ELSE ( CASE                                                  

                                   WHEN PV.ReferingPhysicianName LIKE '%DR.%' THEN PV.ReferingPhysicianName                                                  

                                   ELSE ( CASE                                                  

                                            WHEN PV.ReferingPhysicianName = '' THEN ''                                                  

                                            ELSE 'DR.' + '' + PV.ReferingPhysicianName                                                  

                                          END )                                                  

                                 END )                                                  

                        END )                                        AS Doctorname,                                        

                      HospitalName                                   InstitutionName,                                                  

    CM.ClientName + '(' + CM.ClientCode + ')'      AS ClientName,                                                  

                     ADC.City AS clientcity,                                                  

                      Isnull(AD.city, '') PhysicianCity,  --ss          

                      ISNULL(PA.City,'') PatientCity,                                                                               

                      FB.GrossBillValue                                 FinalMRP,                                                  

                      FB.DiscountAmount                    FinalDiscount,                                                  

                      BD.Amount                                         NetReceivable,                                                  

     --'''' SalesManager,'''' Product,                                                                          

                      oi.NAME                Testname,                                                  

     --OI.name,                                                                                            

              FeeId,             

FeeDescription,                                                  

                      FeeType,                                                  

                      Fb.FinalBillID,        

                      Pv.PatientVisitId ,

                      CMM.CodeName,
					  PA.mobilenumber,
					  P.email

					                                                   

      --Due                                           

      FROM   PatientVisit PV (NoLOck)                                                  

             INNER JOIN OrderedInvestigations OI (NoLOck)                                                 

                     ON OI.VisitID = PV.PatientVisitId                                                  

                        AND OI.OrgID = PV.OrganizationID and  OI.Status NOT IN( 'Cancel' )                                                  

             INNER JOIN CodeMapper CP (NoLOck) on CP.IdentifyingID=OI.ID               

             INNER JOIN CodeMaster CMM (NoLOck) on CP.CodeMasterID=CMM.CodeMasterID and CMM.CodeType=cp.IdentifyingType and 

              CP.IdentifyingType='Investigations' and CMM.CodeSchemeID=4             

             INNER JOIN InvestigationOrgMapping iom (Nolock)on iom.InvestigationID=CP.identifyingid  and iom.OrgID=oi.OrgID                                                      

             LEFT JOIN ReferingPhysician RP (NoLOck)                                                 

                    ON PV.ReferingPhysicianID = RP.ReferingPhysicianID                                                  

                       AND RP.orgid = @orgid                                                  

             LEFT JOIN Addressdetails AD  (NoLOck)                                                

                    ON AD.ReferenceID = RP.ReferingPhysicianID                           

                       AND AD.ReferenceType = 'Refphy'                                                  

                       AND AD.orgid = @orgid    AND AD.AddressTypeID=1                                                                                                                                                                     

                  

             INNER JOIN Patient P   (NoLOck)                                 

                     ON PV.PatientID = P.PatientID                                                  

                        AND P.OrganizationID = @orgid and pv.OrganizationID=p.OrganizationID                                                  

        INNER JOIN Salutation S  (NoLOck)                                                

                     ON P.TITLECode = S.TitleID             

                                                                

              LEFT JOIN PatientAddress PA (NoLOck) ON P.PatientID = PA.PatientID  AND PA.AddressType = 'P' AND P.Status = 'A'                                                                             

             INNER JOIN FinalBill FB (NoLOck)                                                 

                    ON FB.PatientID = PV.PatientID                                                  

                       AND FB.VisitId = PV.PatientVisitId and FB.OrgID=pv.OrganizationID                                                 

                       AND FB.RefFinalBillID IS NULL                                                  

             INNER JOIN Billingdetails BD (NoLOck)                                                 

                     ON BD.FinalBillID = FB.FinalBillID  AND OI.ID = BD.Feeid  AND OI.Type = BD.FeeType and BD.OrgID=@orgid                                                    

                        AND bd.BillingDetailsID NOT IN(SELECT BillingDetailsID                                                  

            FROM   AmountRefundDetails  (NoLOck)                                

            WHERE  OrgID = @orgid and BillStatus IN( 'CANCELLED', 'REFUND' ))                       

             Left  JOIN VisitClientMapping VCM  (NoLOck)                                                

                   ON VCM.VisitID = PV.PatientVisitID                                                  

    AND Isnull(VCM.IsActive, 'Y') <> 'N'                                                  

                       AND vcm.FinalBillID = fb.FinalBillID                                                  

              AND vcm.OrgID = pv.OrganizationID                                                  

             left  JOIN CLientmaster CM  (NoLOck)                                   

                    ON VCM.ClientID = CM.ClientID                                          

                       AND cm.OrgID = VCM.OrgID   

                  LEFT JOIN Addressdetails ADC  (NoLOck)                                                

                    ON ADC.ReferenceID =Cm.ClientID                         

                       AND ADC.ReferenceType = 'Client'                                                  

                       AND ADC.orgid = @orgid     And   ADC.AddressTypeID=1                                                                           

WHERE   PV.VisitDate BETWEEN @Fromdate And @Todate  --'01-02-2015 00:00:00' AND '28-02-2015 23:59:59'                                                     

             AND OI.orgid = @orgid        AND OI.Status NOT IN( 'Cancel' )  and OI.Type in('INV')  and isnull(OI.PkgID,0)=0  

             union

                 SELECT  CONVERT(VARCHAR, Pv.visitdate, 103),                                                  

                      PV.VisitNumber   casenumber,                                                  

                      S.TitleName + '' + P.NAME                      AS PatientName,                                                  

     ( CASE                                                  

                          WHEN PV.ReferingPhysicianID = 0                                                  

                                OR PV.ReferingPhysicianID = -1 THEN ''                                                  

                          ELSE ( CASE                                                  

                                   WHEN PV.ReferingPhysicianName LIKE '%DR.%' THEN PV.ReferingPhysicianName                                                  

                                   ELSE ( CASE                                                  

                                            WHEN PV.ReferingPhysicianName = '' THEN ''                                                  

                                            ELSE 'DR.' + '' + PV.ReferingPhysicianName                                                  

                                          END )                                                  

                                 END )                                                  

                        END )                                        AS Doctorname,                                        

                      HospitalName                                   InstitutionName,                                                  

    CM.ClientName + '(' + CM.ClientCode + ')'      AS ClientName,                                                  

         

                     isnull(ADC.City,'') AS clientcity,                                                  

                      Isnull(AD.city, '') PhysicianCity,  --ss          

                      ISNULL(PA.City,'') PatientCity,                                                                               

                      FB.GrossBillValue                                 FinalMRP,                                                  

                      FB.DiscountAmount                    FinalDiscount,                                                  

                      BD.Amount      NetReceivable,                                                       --'''' SalesManager,'''' Product,                                                                                 

                         

                      oi.NAME                Testname,                                                  

     --OI.name,                                                                                            

                      FeeId,             

FeeDescription,                                                  

                      FeeType,                                                  

                      Fb.FinalBillID,        

                      Pv.PatientVisitId   ,

                      CMM.CodeName   ,
					  PA.mobilenumber,
					  P.email                                            

      --Due                                           

      FROM   PatientVisit PV (NoLOck)                                                  

             INNER JOIN OrderedInvestigations OI (NoLOck)                                                 

                     ON OI.VisitID = PV.PatientVisitId                                                  

                        AND OI.OrgID = PV.OrganizationID and  OI.Status NOT IN( 'Cancel' )                                                  

             INNER JOIN InvOrgGroup IOG (NoLOck) on OI.ID=IOG.AttGroupID AND OI.OrgID=IOG.OrgID              

             INNER JOIN CodeMapper CP (NoLOck)  on CP.IdentifyingID=IOG.OrgGroupID and CP.IdentifyingType=OI.Type            

             INNER JOIN CodeMaster CMM (NoLOck) on CP.CodeMasterID=CMM.CodeMasterID and CMM.CodeType='GRP' and CMM.CodeSchemeID=4                                                                  

             LEFT JOIN ReferingPhysician RP (NoLOck)                                                 

                    ON PV.ReferingPhysicianID = RP.ReferingPhysicianID                                                  

                       AND RP.orgid = @orgid                                                  

             LEFT JOIN Addressdetails AD  (NoLOck)                                                

                    ON AD.ReferenceID = RP.ReferingPhysicianID                           

                       AND AD.ReferenceType = 'Refphy'                                                  

                       AND AD.orgid = @orgid                                                                                                                                                                         

                    AND AD.AddressTypeID=1     

             INNER JOIN Patient P   (NoLOck)                                 

                     ON PV.PatientID = P.PatientID                                                  

                        AND P.OrganizationID = @orgid and pv.OrganizationID=p.OrganizationID                                                  

        INNER JOIN Salutation S  (NoLOck)                                                

                     ON P.TITLECode = S.TitleID             

                                                                

              LEFT JOIN PatientAddress PA (NoLOck) ON P.PatientID = PA.PatientID  AND PA.AddressType = 'P' AND P.Status = 'A'                                                                             

             INNER JOIN FinalBill FB (NoLOck)                                                 

                    ON FB.PatientID = PV.PatientID                                                  

                       AND FB.VisitId = PV.PatientVisitId and FB.OrgID=pv.OrganizationID                                                 

                       AND FB.RefFinalBillID IS NULL                                                  

             INNER JOIN Billingdetails BD (NoLOck)                                                 

                     ON BD.FinalBillID = FB.FinalBillID  AND OI.ID = BD.Feeid  AND OI.Type = BD.FeeType and BD.OrgID=@orgid                                                    

          AND bd.BillingDetailsID NOT IN(SELECT BillingDetailsID                                                  

            FROM   AmountRefundDetails  (NoLOck)                                

            WHERE  OrgID = @orgid and BillStatus IN( 'CANCELLED', 'REFUND' ))                                                  

             Left  JOIN VisitClientMapping VCM  (NoLOck)                                                

                   ON VCM.VisitID = PV.PatientVisitID                                                  

                       AND Isnull(VCM.IsActive, 'Y') <> 'N'                                                  

                       AND vcm.FinalBillID = fb.FinalBillID                                                  

              AND vcm.OrgID = pv.OrganizationID                                                  

             left  JOIN CLientmaster CM  (NoLOck)                                   

                    ON VCM.ClientID = CM.ClientID                                          

                       AND cm.OrgID = VCM.OrgID      

                          LEFT JOIN Addressdetails ADC  (NoLOck)                                                

                    ON ADC.ReferenceID =Cm.ClientID                         

                       AND ADC.ReferenceType = 'Client'                                                  

                       AND ADC.orgid = @orgid     And   ADC.AddressTypeID=1                                         

WHERE   PV.VisitDate BETWEEN @Fromdate And @Todate  --'01-02-2015 00:00:00' AND '28-02-2015 23:59:59'                                                     

             AND OI.orgid = @orgid        AND OI.Status NOT IN( 'Cancel' )  and OI.Type in('GRP')  and isnull(OI.PkgID,0)=0                                    

                                            

             union                                      

                                              

      SELECT  CONVERT(VARCHAR, Pv.visitdate, 103),                                     

                      PV.VisitNumber                                 casenumber,                                                  

                      S.TitleName + '' + P.NAME                      AS PatientName,                                          

                      ( CASE                                                  

                          WHEN PV.ReferingPhysicianID = 0                                                  

                                OR PV.ReferingPhysicianID = -1 THEN ''                                                 

                          ELSE ( CASE                                                  

                                   WHEN PV.ReferingPhysicianName LIKE '%DR.%' THEN PV.ReferingPhysicianName                                                  

                          ELSE ( CASE                                                  

                                            WHEN PV.ReferingPhysicianName = '' THEN ''                                                  

            ELSE 'DR.' + '' + PV.ReferingPhysicianName                                                  

                                          END )                                                  

                                 END )                                                  

                        END )                                        AS Doctorname,                                                 

                      HospitalName                                   InstitutionName,                                                  

                      CM.ClientName + '(' + CM.ClientCode + ')'      AS ClientName,                                                  

                     ADC.City AS clientcity,       

                      Isnull(AD.city, '') PhysicianCity,        

                      ISNULL(PA.City,'') PatientCity, 

                      FB.GrossBillValue  FinalMRP,                                                  

                      FB.DiscountAmount  FinalDiscount,                                                  

                      BD.Amount  NetReceivable,                                                  

                      --'''' SalesManager,'''' Product,                                            

                      oi.PkgName Testname,                                         

                     -- DBO.[Fn_GetTestName](OI.VisitID,OI.OrgID)Testname,                                                  

                     --OI.name,                                                                                            

                      FeeId,                                                  

       FeeDescription,                  

       FeeType,                                                  

                      Fb.FinalBillID,        

                       PV.PatientVisitId ,

                       CMM.CodeName  ,
					   PA.mobilenumber,
					   P.Email                                                

      --Due                                 

      FROM   PatientVisit PV   (NoLOck)                                      

             INNER JOIN OrderedInvestigations OI  (NoLOck)                                                

                     ON OI.VisitID = PV.PatientVisitId                                                  

        AND OI.OrgID = PV.OrganizationID and  OI.Status NOT IN( 'Cancel' )                                                  

             INNER JOIN InvOrgGroup IOG (NoLOck) on OI.PkgID=IOG.AttGroupID AND OI.OrgID=IOG.OrgID              

             INNER JOIN CodeMapper CP (NoLOck) on CP.IdentifyingID=IOG.OrgGroupID              

             INNER JOIN CodeMaster CMM (NoLOck) on CP.CodeMasterID=CMM.CodeMasterID and CMM.CodeType='PKG' and CMM.CodeSchemeID=4 --and OI.Type=CM.IdentifyingType                                                                                

                                                          

             LEFT JOIN ReferingPhysician RP (NoLOck)                                                 

                    ON PV.ReferingPhysicianID = RP.ReferingPhysicianID                                                  

                       AND RP.orgid = @orgid                                      

             LEFT JOIN Addressdetails AD     (NoLOck)                                             

                    ON AD.ReferenceID = RP.ReferingPhysicianID                                                  

          AND AD.ReferenceType = 'Refphy'    and ad.AddressTypeID=1                                              

                       AND AD.orgid = @orgid                                                  

             --INNER JOIN VisitPurpose VP on PV.VisitPurposeID=VP.VisitPurposeID                                                            

             --LEFT JOIN OrganizationAddress OA on OA.AddressID=PV.OrgAddressID                                                                                                                                                                               








  

    

      

       

             INNER JOIN Patient P  (NoLOck)                                                

                     ON PV.PatientID = P.PatientID                                             

                        AND P.OrganizationID = @orgid and pv.OrganizationID=p.OrganizationID                                                 

             INNER JOIN Salutation S (NoLOck)                                                 

                     ON P.TITLECode = S.TitleID        

                                                                

             LEFT JOIN PatientAddress PA (NoLOck) ON P.PatientID = PA.PatientID  AND PA.AddressType = 'P' AND P.Status = 'A'                                         

             INNER JOIN FinalBill FB   (NoLOck)                                    

                    ON FB.PatientID = PV.PatientID                                                  

                       AND FB.VisitId = PV.PatientVisitId and FB.OrgID=pv.OrganizationID                                                 

                       AND FB.RefFinalBillID IS NULL                                                  

             INNER JOIN Billingdetails BD (NoLOck)                                                 

                     ON BD.FinalBillID = FB.FinalBillID  AND OI.PkgID = BD.Feeid and BD.OrgID=@orgid                                                    

     AND bd.BillingDetailsID NOT IN(SELECT BillingDetailsID                                                  

      FROM   AmountRefundDetails  (NoLOck)                                                

      WHERE  OrgID = @orgid and BillStatus IN( 'CANCELLED', 'REFUND' ))                                                  

             Left  JOIN VisitClientMapping VCM      (NoLOck)                                            

                    ON VCM.VisitID = PV.PatientVisitID                                                  

                       AND Isnull(VCM.IsActive, 'Y') <> 'N'                                                  

                       AND vcm.FinalBillID = fb.FinalBillID                                                  

                       AND vcm.OrgID = pv.OrganizationID                                                  

             left  JOIN CLientmaster CM  (NoLOck)                                        

            ON VCM.ClientID = CM.ClientID                                          

                       AND cm.OrgID = VCM.OrgID    

                         LEFT JOIN Addressdetails ADC  (NoLOck)                                                

                    ON ADC.ReferenceID =Cm.ClientID                         

                       AND ADC.ReferenceType = 'Client'                                                  

                       AND ADC.orgid = @orgid     And   ADC.AddressTypeID=1                                               

      WHERE                              

      --CONVERT(VARCHAR, CONVERT(DATETIME, PV.VisitDate, 105), 110) BETWEEN @fromdate AND @Todate                                 

      PV.VisitDate BETWEEN @fromdate AND @Todate                                                  

             AND OI.orgid = @orgid        AND OI.Status NOT IN( 'Cancel' )  and BD.FeeType in('PKG') and OI.PkgID is not null                                        

                                                  

/*                                            

      UPDATE p                                                  

      SET    p.amount = Isnull(IRM.Rate, 0)                                                  

         FROM   @patient P                                                  

             INNER JOIN FinalBill FB                                                  

                     ON P.FinalBillID = FB.FinalBillID  and FB.OrgID=@orgid                      

    INNER JOIN visitclientmapping VCM on vcm.VisitID=FB.VisitID                      

                     AND vcm.FinalBillID=fb.FinalBillID   AND Isnull(VCM.IsActive, 'Y') <> 'N'                      

                     AND fb.OrgID=vcm.OrgID AND VCM.OrgID=@OrgID                                                                           

             INNER JOIN InvRateMaster IRM                                                  

                   ON P.FeeId = IRM.ID                                                  

                        AND P.FeeType = IRM.Type                                                  

AND P.FeeType = 'INV'                                                  

                        -- and Irm.OrgiD=68                                       

                        AND IRm.RateID = VCM.RateID  --and IRM.RateRefID=3081                                    

                                                  

      UPDATE p                                                  

      SET    p.amount = Isnull(IRM.Rate, 0)                                          

      FROM   @patient P                                                  

             INNER JOIN FinalBill FB                                                

                     ON P.FinalBillID = FB.FinalBillID and FB.OrgID=@orgid                       

             INNER JOIN visitclientmapping VCM on vcm.VisitID=FB.VisitID                      

                     AND vcm.FinalBillID=fb.FinalBillID   AND Isnull(VCM.IsActive, 'Y') <> 'N'                      

                     AND fb.OrgID=vcm.OrgID  AND VCM.OrgID=@OrgID                                                           

             INNER JOIN Invorggroup iog                                                  

                     ON IOG.AttGroupID = P.FeeId                                                  

                        AND IOG.OrgID = @orgid                                                  

             INNER JOIN InvRateMaster IRM                                                  

                     ON IRM.ID = IOG.OrgGroupID                                                  

                        AND P.FeeType = IRM.Type          

                       AND p.FeeType IN ( 'GRP', 'PKG' )                                                  

                        -- and Irm.OrgiD=68                                                                                               

                        AND IRm.RateID = VCM.RateID                       

  */                                        

                                          

      UPDATE p                                                  

      SET    p.Famount = Isnull(IRM.Rate, 0)                                                  

         FROM   @patient P                                                  

     INNER JOIN FinalBill FB  (NoLOck)                                                

                     ON P.FinalBillID = FB.FinalBillID  and FB.OrgID=@orgid                      

                                                                                 

             INNER JOIN InvRateMaster IRM  (NoLOck)                                                

                   ON P.FeeId = IRM.ID                              

                        AND P.FeeType = IRM.Type                           

                        AND P.FeeType = 'INV'                                                  

                        -- and Irm.OrgiD=68                                                                                               

                        AND IRm.RateID = 2  --and IRM.RateRefID=3081                                                

                                                  

      UPDATE p                                                  

      SET    p.Famount = Isnull(IRM.Rate, 0)                                          

      FROM   @patient P                                                  

             INNER JOIN FinalBill FB   (NoLOck)                                               

                     ON P.FinalBillID = FB.FinalBillID and FB.OrgID=@orgid           

             INNER JOIN Invorggroup iog  (NoLOck)                                                

                     ON IOG.AttGroupID = P.FeeId                                                  

                        AND IOG.OrgID = @orgid                                                  

             INNER JOIN InvRateMaster IRM   (NoLOck)                                        

                     ON IRM.ID = IOG.OrgGroupID                                                  

                  AND P.FeeType = IRM.Type                                          

        AND p.FeeType IN ( 'GRP', 'PKG' )                                          

                        -- and Irm.OrgiD=68                                                                                               

                        AND IRm.RateID = 2            

                                

   /*                      update P Set P.Testcode=CMM.CodeName from @patient P inner join               

                         OrderedInvestigations OI (nolock)on P.VisitID= OI.VisitID and P.FeeId=OI.ID and P.FeeType=OI.Type              

                         inner join CodeMapper CM (NoLOck) on CM.IdentifyingID=OI.ID               

                         inner join CodeMaster CMM (NoLOck) on CM.CodeMasterID=CMM.CodeMasterID and CM.IdentifyingType='Investigations' and CMM.CodeSchemeID=4             

                         --INNER JOIN CodingSchemeOrgMapping com ON  CMM.CodeSchemeID= com.CodingSchemeOrgID AND com.OrgID=@orgid AND com.IsPrimary='Y'            

                         where --VisitNumber='15-C07152' and               

                         OI.Type='INV'              

                                       

                                        

                         update P Set P.Testcode=CMM.CodeName from @patient P inner join                

                         OrderedInvestigations OI (nolock)on P.VisitID= OI.VisitID and P.FeeId=OI.ID and P.FeeType=OI.Type              

    Inner join InvOrgGroup IOG (NoLOck) on OI.ID=IOG.AttGroupID AND OI.OrgID=IOG.OrgID              

                         inner join CodeMapper CM (NoLOck)  on CM.IdentifyingID=IOG.OrgGroupID and CM.IdentifyingType=OI.Type            

                         inner join CodeMaster CMM (NoLOck) on CM.CodeMasterID=CMM.CodeMasterID and CMM.CodeType='GRP' and CMM.CodeSchemeID=4             

                         --INNER JOIN CodingSchemeOrgMapping com ON  CMM.CodeSchemeID= com.CodingSchemeOrgID AND com.OrgID=@orgid AND com.IsPrimary='Y'            

                         where --VisitNumber='15-C07152' and             

                         ISNULL(OI.PkgID,0)=0 and              

                         OI.Type='GRP'             

                                       

                         update P Set P.Testcode=CMM.CodeName from @patient P inner join                

                         OrderedInvestigations OI (nolock)on P.VisitID= OI.VisitID and P.FeeId=OI.PkgID              

                         Inner join InvOrgGroup IOG (NoLOck) on OI.PkgID=IOG.AttGroupID AND OI.OrgID=IOG.OrgID              

                         inner join CodeMapper CM (NoLOck) on CM.IdentifyingID=IOG.OrgGroupID              

                         inner join CodeMaster CMM (NoLOck) on CM.CodeMasterID=CMM.CodeMasterID and CMM.CodeType='PKG' and CMM.CodeSchemeID=4 --and OI.Type=CM.IdentifyingType              

                         --INNER JOIN CodingSchemeOrgMapping com ON  CMM.CodeSchemeID= com.CodingSchemeOrgID AND com.OrgID=@orgid AND com.IsPrimary='Y'            

                         where --VisitNumber='15-C07152' and            

                          ISNULL(OI.PkgID,0)>0 and              

                         OI.Type='GRP'              

                   */                          

                                                                                         

      UPDATE p                                                  

      SET    FinalDiscount = CASE                                                  

                                                                               

                               WHEN NetReceivable = 0.00 THEN Famount-NetReceivable                    

                               WHEN NetReceivable < Famount THEN Famount - NetReceivable                                               

                          

                               ELSE 0                                                  

                             END                                  

      FROM   @patient p                                                

                                          

      --update p set FinalMRP=Famount-finaldiscount from @patient p                                            

      

      



		

                                                  

	SELECT  1  as Vdate,VisitDate,                                                  

			VisitNumber,                                                  

			PatientName,                                                  

			DoctorName,                                                  

			InstitutionName,                                                  

			ClientName,                                   

			ClientCity,                                                  

			PhysicianCity,      

			PatientCity,             

			Famount [Gross Amount],             

			FinalDiscount     Discount,                                              

			FB.DiscountAmount AS [Bill Level Discount],

			NetReceivable  AS [Net Amount],                                                  

			TestName,  FeeType,      

			Testcode ,
			PatientPhoneNumber,
			Email


			

	FROM	@patient P

			INNER JOIN FinalBill FB(NOLOCK)

			ON	P.FinalBillID	=	FB.FinalBillID

	WHERE	FB.OrgID	=	@orgid

	ORDER  BY CONVERT(DATE, VisitDate, 105) ASC                                                         

End