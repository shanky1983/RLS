
DECLARE @orgid AS bigint
DECLARE EMP_CURSOR CURSOR FOR
SELECT orgid FROM Organization where orgid >= 70
OPEN EMP_CURSOR
FETCH NEXT FROM EMP_CURSOR
INTO @orgid
WHILE (@@FETCH_STATUS = 0) 
BEGIN
   INSERT INTO invstatusorgmapping
   select InvestigationStatusID,Status, 'en-GB',@orgid,DisplayText,GETDATE(),0,NULL,NULL from InvestigationStatus(NOLOCK)  where  status not in 
   ( select status from invstatusorgmapping (NOLOCK) where orgid =@orgid)
    FETCH NEXT FROM EMP_CURSOR
    INTO @orgid
END
CLOSE EMP_CURSOR
DEALLOCATE EMP_CURSOR
SET NOCOUNT OFF