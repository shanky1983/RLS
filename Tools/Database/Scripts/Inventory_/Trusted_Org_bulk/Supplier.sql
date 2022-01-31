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
SELECT   SupplierID FROM Suppliers where orgid=@parORGID
update Suppliers set ParentSupplierID=SupplierID where OrgID=@parORGID


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

INSERT Suppliers (SupplierName,ContactPerson,Address1,Address2,City,EmailID,Phone,Mobile,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressID,TinNo,ParentSupplierID)
SELECT SupplierName,ContactPerson,Address1,Address2,City,EmailID,Phone,Mobile,@ID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,0,TinNo,SupplierID FROM Suppliers where SupplierID=@CatID

SELECT @CatLoop=@CatLoop+1
END 

SELECT @loop=@loop+1
END
---------------------------------------------------------------------------------------------------------



















