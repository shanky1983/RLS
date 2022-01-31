--insert Pages(PageID,PageName,PageURL)
--SELECT @PageID ,p.PageName,p.PageURL FROM Inventory_Pages p where RowID=@LoopCount

DECLARE @MAXPAGEID INT
SET @MAXPAGEID=(SELECT ISNULL(MAX(PAGEID),0)+1 FROM PAGES)


 INSERT INTO  Pages(PageID,PageName,PageURL,CreatedAt)
SELECT @MAXPAGEID+ROW_NUMBER() OVER(ORDER BY IP.PAGENAME) , IP.PageName,Ip.PageURL,GETDATE() FROM Inventory_Pages Ip
LEFT JOIN Pages P ON P.PageName=IP.PageName AND P.PageURL=IP.PageURL
WHERE P.PageURL IS NULL




update i set i.PageID=p.PageID from Inventory_Pages i
inner join Pages p on i.PageName=p.PageName and i.PageURL=p.PageURL 
