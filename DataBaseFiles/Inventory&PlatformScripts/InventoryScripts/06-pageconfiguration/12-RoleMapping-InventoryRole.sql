

IF OBJECT_ID('tempdb..#tempTable') IS NOT NULL
begin 
DROP TABLE #tempTable;
end 
CREATE TABLE #tempTable ( seqid int identity(1,1),  MenuName varchar( 100 ),LocationTypeCode varchar(100))


declare @orgid int =112
declare @languageCode nvarchar(100) ='en-GB'




Insert into #tempTable(MenuName)
select 'Indent Search'
union select 'Categories'
union select 'Inventory Mgmt'
union select 'Inventory Search'
union select 'Products'
union select 'Purchase Order'
union select 'Quick StockReceived'
--union select 'Quotation Master'
union select 'Raise Indent'
union select 'Reorder level'
union select 'Stock Adjustment'
union select 'Stock Damage'
union select 'Stock Details'
union select 'Stock Issued'
union select 'Stock Receive'
union select 'Stock Return'
union select 'Stock Usage'
union select 'Investigation Product Mapping'
--union select 'Central Purchase Order'
--union select 'Central Stock Receive'
union select 'SubStore Stock Return'
union select 'Suppliers'


--select * from MenuMaster where DisplayText in (select MenuName  from #tempTable) and OrgId=@orgid

Insert into RoleMenu (MenuID,RoleID,IsMapped)


select DISTINCT MM.MenuID,R.RoleID,'Y' from #tempTable TT
INNER JOIN MenuMaster MM on MM.DisplayText=Tt.MenuName AND ISNULL(LanguageCode,'en-GB')=@languageCode
INNER JOIN Role R on R.OrgID=MM.OrgId and R.RoleName ='Inventory'
LEFT  JOIN RoleMenu RM On RM.MenuID=mm.MenuID AND RM.RoleID=r.RoleID 
WHERE RM.UserMenuID IS NULL AND r.OrgID=@orgid ORDER BY MenuID

