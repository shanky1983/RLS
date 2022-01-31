--SELECT name
--        ,database_id
--        ,USER_NAME(owner_sid) as DBOwner
--FROM sys.databases WHERE name ='KMH'

--Exec sp_changedbowner 'sa'


--EXEC sys.sp_cdc_enable_db 


EXEC sys.sp_cdc_enable_table 
@source_schema = N'dbo', 
@source_name   = N'FinalBill', 
@role_name     = NULL 

ALTER TABLE cdc.dbo_FinalBill_CT  
 ADD SUMMA VARCHAR(100) 

--SELECT * FROM cdc.dbo_FinalBill_CT 

select * from SYS.tables WHERE name LIKE '%FinalBill_CT%'

alter TABLE FinalBill ADD SUMMA VARCHAR(100) 


DECLARE @begin_time DATETIME, @end_time DATETIME, @begin_lsn BINARY(10), @end_lsn BINARY(10);
SELECT @begin_time = GETDATE()-1, @end_time = GETDATE(); 
SELECT @begin_lsn = sys.fn_cdc_map_time_to_lsn('smallest greater than', @begin_time); 
SELECT @end_lsn = sys.fn_cdc_map_time_to_lsn('largest less than or equal', @end_time); 

--select @end_lsn,@begin_lsn
SELECT * FROM cdc.fn_cdc_get_all_changes_dbo_FinalBill(@begin_lsn,@end_lsn,'all')