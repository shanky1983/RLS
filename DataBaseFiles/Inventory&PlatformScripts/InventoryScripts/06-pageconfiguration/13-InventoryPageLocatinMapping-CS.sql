IF OBJECT_ID('tempdb..#tempTable') IS NOT NULL
begin 
DROP TABLE #tempTable;
end 
CREATE TABLE #tempTable ( seqid int identity(1,1),  MenuName varchar( 100 ),LocationTypeCode varchar(100))

declare @orgid int =112
declare @LocationTypeCode nvarchar(100)='CS'
Insert into #tempTable(MenuName,LocationTypeCode)
select 'Indent Search',@LocationTypeCode
union select 'Quick StockReceived',@LocationTypeCode
union select 'Raise Indent',@LocationTypeCode
union select 'Stock Details',@LocationTypeCode
union select 'Inventory Mgmt',@LocationTypeCode

union select 'Stock Adjustment',@LocationTypeCode

union select 'Stock Issued',@LocationTypeCode
union select 'Stock Usage',@LocationTypeCode


union select 'Inventory Mgmt',@LocationTypeCode
union select 'Stock Receive',@LocationTypeCode
union select 'Stock Damage',@LocationTypeCode

union select 'Indent Search',@LocationTypeCode

union select 'Inventory Search',@LocationTypeCode
union select 'Products',@LocationTypeCode
union select 'Quotation Master',@LocationTypeCode
union select 'Purchase Order',@LocationTypeCode
union select 'Stock Return',@LocationTypeCode
union select 'Investigation Product Mapping',@LocationTypeCode
--union select 'Central Purchase Order',@LocationTypeCode
--union select 'Central Stock Receive',@LocationTypeCode
union select 'SubStore Stock Return',@LocationTypeCode
union select 'Categories',@LocationTypeCode
union select 'Suppliers',@LocationTypeCode



declare @seqid int =1
declare @maxseqid int =(select MAX(seqid) from #tempTable)
while @seqid<=@maxseqid
begin 

declare @DisplayText varchar(100)=(select MenuName from #tempTable where seqid=@seqid)

Insert into InventoryPageMap(PageMapID,LocationTypeID,PageID)
	SELECT top 1  (select isnull(MAX(pagemapid),0) from InventoryPageMap)+1,
				LT.LocationTypeID ,mm.PageID
				FROM  RoleMenu  RM
	inner join MenuMaster MM on MM.MenuID=rm.MenuID and DisplayText=@DisplayText and orgid=@orgid
	inner join LocationType LT on LT.LocationTypeID=lt.LocationTypeID
	left outer join InventoryPageMap IPM on IPM.PageID=mm.PageID and ipm.LocationTypeID=lt.LocationTypeID

where LocationTypeCode in (@LocationTypeCode) and  ipm.PageID is null
set @seqid=@seqid+1

end 


--select * from Pages where PageName='Reorder level'



--It will remove Existing Menu from Inventory Pagemapping
delete  IPM from 
MenuMaster MM
Inner join InventoryPageMap IPM on IPM.PageID=	mm.PageID 
inner join LocationType LT on LT.LocationTypeID=IPM.LocationTypeID 
where DisplayText not in (select  MenuName from #tempTable) 
and OrgId=@orgid and LT.LocationTypeCode=@LocationTypeCode




