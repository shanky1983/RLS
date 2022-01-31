
DECLARE @LANGCODE NVARCHAR(100)='en-GB'
DECLARE @OrgID int=112
DECLARE @Parentid int=3



IF OBJECT_ID('tempdb..#tempTable') IS NOT NULL
begin 
DROP TABLE #tempTable;
end 
CREATE TABLE #tempTable ( seqid int identity(1,1),  MenuName varchar( 100 ),LocationTypeCode varchar(100))


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
union select 'Home',@LocationTypeCode
union select 'Inventory Location',@LocationTypeCode

DECLARE @MAMMENUID BIGINT =(SELECT MAX(MenuID) FROM MENUMASTER)

INSERT INTO MENUMASTER (MenuID, DisplayText, Parentid, OrgId, PageID, LanguageCode)

SELECT @MAMMENUID+ROW_NUMBER() OVER (ORDER BY TMP.PAGENAME,TMP.PAGEURL ),TMP.DisplayText,@Parentid,@OrgID,p.PageID,@LANGCODE FROM Inventory_Pages TMP
INNER JOIN Pages P ON P.PageURL=TMP.PAGEURL 
INNER JOIN #tempTable T ON T.MenuName=TMP.DisplayText
left JOIN MenuMaster MM ON MM.PageID=P.PageID AND ISNULL(MM.LanguageCode,'en-GB')=@LANGCODE
WHERE MM.PAGEID  IS NULL

