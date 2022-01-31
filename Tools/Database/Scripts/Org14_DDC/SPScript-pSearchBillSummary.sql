
/****** Object:  StoredProcedure [dbo].[pSearchBillSummary]    Script Date: 04/22/2009 16:58:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pSearchBillSummary]
(	
	@pBillNo varchar(20),
	@pBillFromDate varchar(20),
	@pBillToDate varchar(20),
	@pPatientName varchar(50),
	@pDrName varchar(50),
	@pHospitalName varchar(50),
	@pClientID varchar(10),
	@pCollectionCentreID varchar(10),
	@pOrgID int,
	@flag int
)
AS

DECLARE @select nvarchar(1000)
DECLARE @where nvarchar(1000)
DECLARE @query nvarchar(2000)	
DECLARE @ret bigint

	BEGIN
	SET @ret = -1
	SET DATEFORMAT DMY
	Select @where = ''
		
	IF (@pBillNo is Not Null and @pBillNo != '')
	IF (@where = '')
	Select @where = @where + 'BM.BillID  =' + @pBillNo 
	ELSE
	Select @where = @where + ' AND BM.BillID =' + @pBillNo 
	
	IF ((@pBillFromDate is Not Null AND @pBillFromDate != '') AND (@pBillToDate is Null OR @pBillToDate = ''))
	IF (@where = '')
	Select @where = @where + 'Convert(varchar(15),BM.BillDate,103) = ''' + Convert(varchar(15), @pBillFromDate) + ''''
	ELSE
	Select @where = @where + ' AND Convert(varchar(15),BM.BillDate,103) = ''' + Convert(varchar(15), @pBillFromDate) + ''''
				
	IF ((@pBillFromDate is Not Null AND @pBillFromDate != '')AND(@pBillToDate is Not Null AND @pBillToDate != ''))
	IF (@where = '')
	Select @where = @where + 'Convert(varchar(15),BM.BillDate,103) BETWEEN ''' + Convert(varchar(15), @pBillFromDate) + ''' AND '''+ Convert(varchar(15), @pBillToDate) + ''''
	ELSE
	Select @where = @where + ' AND Convert(varchar(15),BM.BillDate,103) BETWEEN ''' + Convert(varchar(15), @pBillFromDate) + ''' AND '''+ Convert(varchar(15), @pBillToDate) + ''''
	
	if(@flag=1)
	BEGIN
	IF (@pClientID is Not Null and @pClientID != '')
	IF (@where = '')
	Select @where = @where + 'BM.ClientID  =' + @pClientID 
	ELSE
	Select @where = @where + ' AND BM.ClientID =' + @pClientID 
	END	
	
	if(@flag=2)
	BEGIN
	IF (@pDrName is Not Null and @pDrName != '')
	IF (@where = '')
	Select @where = @where + 'LV.ReferingPhysicianName like ''' + @pDrName + ''''
	ELSE
	Select @where = @where + ' AND LV.ReferingPhysicianName like ''' + @pDrName + ''''
	END
	
	if(@flag=3)
	BEGIN	
	IF (@pHospitalName is Not Null and @pHospitalName != '')
	IF (@where = '')
	Select @where = @where + 'LV.HospitalName like ''' + @pHospitalName + ''''
	ELSE
	Select @where = @where + ' AND LV.HospitalName like ''' + @pHospitalName + ''''
	END	
	
	if(@flag=4)
	BEGIN
	IF (@pCollectionCentreID is Not Null and @pCollectionCentreID != '')
	IF (@where = '')
	Select @where = @where + 'BM.CollectionCentreID  =' + @pCollectionCentreID 
	ELSE
	Select @where = @where + ' AND BM.CollectionCentreID =' + @pCollectionCentreID 
	END	
		
	IF (@pPatientName is Not Null and @pPatientName != '')
	IF (@where = '')
	Select @where = @where + 'P.Name like ''%' + @pPatientName + '%'' OR P.AliasName like ''%' + @pPatientName +  '%'''
	ELSE
	Select @where = @where + ' AND P.Name like ''%' + @pPatientName + '%'' OR P.AliasName like ''%' + @pPatientName +  '%'''
	
	IF (@where = '')
	Select @where = @where + '(BM.Status IS NULL OR BM.Status!=''C'')'
	ELSE
	Select @where = @where + ' AND (BM.Status IS NULL OR BM.Status!=''C'')'

	
	if(@flag=1)
	BEGIN
	SELECT @select = 'select distinct CM.ClientName as DrName,sum((BM.GrossAmount-BM.Discount+(BM.GrossAmount-BM.Discount)* (BM.TaxPercent/100))) as Amount from Billmaster BM
			INNER JOIN PatientVisit LV ON LV.VisitID = BM.VisitID 
			INNER JOIN InvClientMaster CM ON CM.ClientID = BM.ClientID'
	END 
			
	if(@flag=2)
	BEGIN
	SELECT @select = 'select distinct LV.ReferingPhysicianName as DrName,sum((BM.GrossAmount-BM.Discount+(BM.GrossAmount-BM.Discount)* (BM.TaxPercent/100))) as Amount from Billmaster BM
			INNER JOIN PatientVisit LV ON LV.VisitID = BM.VisitID 
			INNER JOIN InvClientMaster CM ON CM.ClientID = BM.ClientID'
	END
	
	if(@flag=3)
	BEGIN
	SELECT @select = 'select distinct LV.HospitalName as DrName,sum((BM.GrossAmount-BM.Discount+(BM.GrossAmount-BM.Discount)* (BM.TaxPercent/100))) as Amount from Billmaster BM
			INNER JOIN PatientVisit LV ON LV.VisitID = BM.VisitID 
			INNER JOIN InvClientMaster CM ON CM.ClientID = BM.ClientID'
	END
	
	if(@flag=4)
	BEGIN
	SELECT @select = 'select distinct CC.CollectionCentreName as DrName,sum((BM.GrossAmount-BM.Discount+(BM.GrossAmount-BM.Discount)* (BM.TaxPercent/100))) as Amount from Billmaster BM
			INNER JOIN PatientVisit LV ON LV.VisitID = BM.VisitID 
			INNER JOIN InvClientMaster CM ON CM.ClientID = BM.ClientID
			INNER JOIN CollectionCentreMaster CC ON CC.CollectionCentreID = BM.CollectionCentreID'
	END 
	

	If (@where != '')
	begin
	Select @where = ' WHERE '+ @where +' AND LV.OrgID=BM.OrgID AND BM.OrgID='+CONVERT(varchar,@pOrgID)
	end
	
	if(@flag=1)
	BEGIN
	Select @query = @Select + @where +' group by CM.ClientName'
	END
	
	if(@flag=2)
	BEGIN
	Select @query = @Select + @where +' group by LV.ReferingPhysicianName'
	END
	
	if(@flag=3)
	BEGIN
	Select @query = @Select + @where +' group by LV.HospitalName'
	END
	
	if(@flag=4)
	BEGIN
	Select @query = @Select + @where +' group by CC.CollectionCentreName'
	END
	
	Print @query

	EXECUTE sp_executesql @query;
	
	SET @ret = 0   
	RETURN @ret
	END		

GO

