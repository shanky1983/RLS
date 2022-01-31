--ALTER TABLE Products Add ParentProductID BIGINT
--ALTER TABLE Suppliers Add ParentSupplierID BIGINT
--ALTER TABLE ProductCategories Add ParentCategorieID BIGINT
--UPDATE ProductCategories SET ParentCategorieID=0 
--SELECT * FROM ProductCategories

DECLARE @parORGID int =88
set nocount on
DECLARE @tb TABLE(RowID INT,ID INT)
INSERT INTO @tb SELECT 1,1
INSERT INTO @tb SELECT 2,2


declare @Count int =0,@loop int =1,@CatID int=0,@ID INT 
select @Count=count(1) from @tb

DECLARE @tbTableList TABLE (AutoID INT IDENTITY(1,1),CatID BIGINT)
DECLARE @CatCount int,@CatLoop int=1
delete @tbTableList

INSERT @tbTableList
SELECT   ProductID FROM Products where orgid=@parORGID
update Products set ParentProductID=ProductID where orgid=@parORGID


WHILE @loop <= @Count
BEGIN
SELECT @ID=ID FROM @tb where RowID=@loop


SELECT @CatCount=COUNT(*) FROM @tbTableList
--SELECT @CatCount
SELECT @CatLoop =1

WHILE @CatLoop <= @CatCount
BEGIN
--select @CatLoop
SELECT @CatID=CatID FROM @tbTableList where AutoID=@CatLoop

INSERT Products (ProductName,CategoryID,OrgID,Specification1,Description,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,ReOrderLevel,
IsScheduleHDrug,OrgAddressID,LSU,HasExpiryDate,TypeID,HasBatchNo,HasUsage,HasAttributes,UsageCount,Attributes,MfgName,
MfgCode,IsDeleted,ParentProductID)
SELECT ProductName,
(SELECT CategoryID FROM ProductCategories WHERE ParentCategorieID=P.CategoryID and OrgID=@ID)  ,
@ID,Specification1,Description,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,ReOrderLevel,
IsScheduleHDrug,OrgAddressID,LSU,HasExpiryDate,TypeID,HasBatchNo,HasUsage,HasAttributes,UsageCount,Attributes,MfgName,
MfgCode,IsDeleted,ProductID FROM Products p where ProductID=@CatID

SELECT @CatLoop=@CatLoop+1
END 

SELECT @loop=@loop+1
END
---------------------------------------------------------------------------------------------------------



















