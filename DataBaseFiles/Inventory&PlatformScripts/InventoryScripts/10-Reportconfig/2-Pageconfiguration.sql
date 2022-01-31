
	declare @orgid int =112
	declare @roleID int =(select Roleid from Role where RoleName='InventoryAdmin' and OrgID=@orgid)
	declare @pageid int=0



	DECLARE @ReportGroupID int
	DECLARE @ReportID int
	set @ReportGroupID=(select ReportGroupID from ReportGroupMaster where ReportGroupText='Inventory Reports')

	CREATE TABLE #Temp1 ( orgid int, roleid int,pagename nvarchar(100),pageurl nvarchar(100), id int);
	Insert into #Temp1(orgid,roleid,pagename,pageurl,id)
  SELECT @orgid,@roleID, 'Stock Report','/InventoryReports/StockReport.aspx',1
  UNION SELECT @orgid,@roleID, 'Purchase Report','/InventoryReports/PurchaseOrderReport.aspx',2
  UNION SELECT @orgid,@roleID, 'Stock Issued Report','/InventoryReports/StockIssuedReport.aspx',3
    UNION SELECT @orgid,@roleID, 'Stock Usage Report','/InventoryReports/StockUsageReport.aspx',4


	
	SET @ReportID=(SELECT isnull(MAX(ReportID),0)+1 FROM ReportMaster) 

	Insert into ReportMaster(ReportID,ReportDisplayText,ReportPath,RedirectURL,ReportGroupID,CreatedAt,PageID,CreatedBy)
	select  @ReportID+ROW_NUMBER() OVER(ORDER BY DisplayText) ,DisplayText,ReportPath ,PageURL,ReportGroupID,createdAt,PageID ,'' from		
   (select distinct IP.DisplayText ,NULL as ReportPath,P.PageURL,@ReportGroupID ReportGroupID,GETDATE() createdAt,P.PageID from #Temp1 T
	INNER JOIN PAGES P ON P.PageURL=T.pageurl 
	INNER JOIN INVENTORY_PAGES IP ON IP.PAGEID=IP.PageID AND IP.PageURL=T.pageurl and t.pagename=ip.DisplayText
	LEFT OUTER JOIN ReportMaster RM ON RM.PageID=P.PageID AND ReportGroupID=@ReportGroupID
	WHERE RM.PageID IS  NULL
	) A



	INSERT INTO ReportOrgMapping(ReportID,OrgID,RoleID,IsMapped)

	select ReportID,orgid,roleid,ISMAPPED from 
	(select distinct  rm.ReportID,@orgid orgid,@roleID roleid,'Y' ISMAPPED from #Temp1 T
	INNER JOIN PAGES P ON P.PageURL=T.pageurl 
	INNER JOIN INVENTORY_PAGES IP ON IP.PAGEID=IP.PageID AND IP.PageURL=T.pageurl and t.pagename=ip.DisplayText
	INNER  JOIN ReportMaster RM ON RM.PageID=P.PageID AND ReportGroupID=@ReportGroupID 
	LEFT join ReportOrgMapping ROM ON ROM.ReportID=RM.ReportID AND ROM.OrgID=@orgid AND ROM.RoleID=@roleID
	WHERE rom.ReportID IS  NULL
	)  B



	DELETE  FROM ReportOrgMapping 
	WHERE RoleID=@roleID AND OrgID=@orgid AND 
	
	ReportID IN (

		SELECT  RM.ReportID  FROM PAGES  P
		
		INNER JOIN ReportMaster RM ON RM.PageID=P.PageID 
		WHERE P.PageURL NOT IN (SELECT PAGEURL FROM #Temp1) AND P.PAGEURL  LIKE '%/InventoryReports/%'
		)
	




drop table #Temp1




