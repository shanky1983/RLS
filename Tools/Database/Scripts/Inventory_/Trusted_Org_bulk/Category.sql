--ALTER TABLE Products Add ParentProductID BIGINT
--ALTER TABLE Suppliers Add ParentSupplierID BIGINT
--ALTER TABLE ProductCategories Add ParentCategorieID BIGINT
--UPDATE ProductCategories SET ParentCategorieID=0 
--SELECT * FROM ProductCategories

--set nocount on
DECLARE @parORGID int =88
DECLARE @tb TABLE(RowID INT,ID INT)
INSERT INTO @tb SELECT 1,67
INSERT INTO @tb SELECT 2,66


declare @Count int =0,@loop int =1,@CatID int=0,@ID INT 
select @Count=count(1) from @tb

DECLARE @tbTableList TABLE (AutoID INT IDENTITY(1,1),CatID BIGINT)
DECLARE @CatCount int,@CatLoop int=1
 
INSERT @tbTableList
SELECT   CategoryID FROM ProductCategories where orgid=@parORGID
update ProductCategories set ParentCategorieID=CategoryID where OrgID=@parORGID


WHILE @loop <= @Count
BEGIN
SELECT @ID=ID FROM @tb where RowID=@loop

SELECT @CatCount=COUNT(*) FROM @tbTableList

SELECT @CatLoop =1


WHILE @CatLoop <= @CatCount
BEGIN
--select @CatLoop
SELECT @CatID=CatID FROM @tbTableList where AutoID=@CatLoop

INSERT ProductCategories (CategoryName,OrgID,Description,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressID,IsDeleted,ParentCategorieID)
SELECT CategoryName,@ID,Description,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,0,IsDeleted,CategoryID FROM ProductCategories where CategoryID=@CatID

SELECT @CatLoop=@CatLoop+1
END 

SELECT @loop=@loop+1
END
---------------------------------------------------------------------------------------------------------



















