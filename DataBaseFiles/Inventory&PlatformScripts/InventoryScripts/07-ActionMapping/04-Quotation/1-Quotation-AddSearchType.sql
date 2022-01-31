


DECLARE @SearchTypeName NVARCHAR(100) = 'Quotation'
DECLARE @StockTypeName NVARCHAR(100) = 'Quotation'
DECLARE @SearchTypeID BIGINT

----INSERT SEARCHTYPE MASTER---
INSERT INTO SearchTypeMaster (SearchTypeID,SearchTypeName,CreatedAt)
select (select max(SearchTypeID)+1 from SearchTypeMaster), @SearchTypeName,GETDATE()
where not exists(select 1 from SearchTypeMaster where SearchTypeName=@SearchTypeName)


----INSERT STOCKTYPEMASTER MASTER---
INSERT INTO StockType(StockTypeID,StockTypeName,SearchTypeID,createdat)
select (select max(StockTypeID)+1 from StockType), @StockTypeName,STM.SearchTypeID,GETDATE()
FROM SearchTypeMaster STM 
LEFT JOIN StockType ST ON ST.SearchTypeID=STM.SearchTypeID AND ST.StockTypeName=@StockTypeName
where SearchTypeName=@SearchTypeName AND ST.StockTypeID IS  NULL



DECLARE @MAXSTOCKSTATUSID INT=(SELECT ISNULL(MAX(StockStatusID),0)+1 FROM StockStatus)
;WITH CTEQUOTATION(STATUS)
AS
(

SELECT 'Approved'
UNION SELECT 'Cancelled'
UNION SELECT 'Received'
UNION SELECT 'Inprogress'
UNION SELECT 'Pending'
)
--SELECT * FROM StockStatus

INSERT INTO StockStatus(StockStatusID,StockStatusName,StockTypeID,createdat)

SELECT @MAXSTOCKSTATUSID+ROW_NUMBER() OVER(ORDER BY CTE.STATUS) ,CTE.STATUS,ST.StockTypeID,GETDATE() FROM SearchTypeMaster STM 
INNER JOIN StockType ST ON ST.SearchTypeID=STM.SearchTypeID
INNER JOIN CTEQUOTATION CTE ON CTE.STATUS=CTE.STATUS
LEFT JOIN StockStatus SS ON SS.StockStatusName=CTE.STATUS AND SS.StockTypeID=ST.StockTypeID

WHERE SearchTypeName=@SearchTypeName AND ST.StockTypeName=@StockTypeName AND SS.StockStatusName IS NULL