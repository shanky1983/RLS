-----------------------------------LabReception----------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AddessBook')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('AddessBook','Client','Client','en-GB',0),
('AddessBook','Refering Physician','ReferingPhysician','en-GB',0),
('AddessBook','Collection Centers / OrgLocations','CollectionCenters/OrgLocations','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Client' and Domain='AddessBook')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Client')
set @metaid= (select metadataid from MetaData where DisplayText ='ReferingPhysician' and Domain='AddessBook')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ReferingPhysician')
set @metaid= (select metadataid from MetaData where DisplayText ='CollectionCenters/OrgLocations' and Domain='AddessBook')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','CollectionCenters/OrgLocations')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
----------------------------------------\Reception\Reception.aspx----------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TypeClient')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('TypeClient','IN','INVOICE NO','en-GB',0),
('TypeClient','BILL','BILL NO','en-GB',0),
('TypeClient','OTHERS','OTHERS','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='INVOICE NO' and Domain='TypeClient')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','INVOICE NO')
set @metaid= (select metadataid from MetaData where DisplayText ='BILL NO' and Domain='TypeClient')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','BILL NO')
set @metaid= (select metadataid from MetaData where DisplayText ='OTHERS' and Domain='TypeClient')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','OTHERS')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------Reception\CreditDebitSummary.aspx -------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Reminder')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Reminder','email','E-Mail','en-GB',0),
('Reminder','SMS','SMS','en-GB',0),
('Reminder','Both','Both(SMS And E-Mail)','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='E-Mail' and Domain='Reminder')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','E-Mail')
set @metaid= (select metadataid from MetaData where DisplayText ='SMS' and Domain='Reminder')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','SMS')
set @metaid= (select metadataid from MetaData where DisplayText ='Both(SMS And E-Mail)' and Domain='Reminder')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Both(SMS And E-Mail)')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='IssueReason')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('IssueReason','0','Select a reason','en-GB',0),
('IssueReason','1','Card Lost','en-GB',0),
('IssueReason','2','Card Damaged','en-GB',0),
('IssueReason','3','Other','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Select a reason' and Domain='IssueReason')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Select a reason')
set @metaid= (select metadataid from MetaData where DisplayText ='Card Lost' and Domain='IssueReason')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Card Lost')
set @metaid= (select metadataid from MetaData where DisplayText ='Card Damaged' and Domain='IssueReason')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Card Damaged')
set @metaid= (select metadataid from MetaData where DisplayText ='Other' and Domain='IssueReason')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Other')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Sex')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Sex','M','Male','en-GB',0),
('Sex','F','Female','en-GB',0),
('Sex','NotKnown','NotKnown','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Male' and Domain='Sex')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Male')
set @metaid= (select metadataid from MetaData where DisplayText ='Female' and Domain='Sex')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Female')
set @metaid= (select metadataid from MetaData where DisplayText ='NotKnown' and Domain='Sex')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','NotKnown')

end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Food')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Food','35','Shellfish','en-GB',0),
('Food','36','Tomato','en-GB',0),
('Food','37','Others','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Shellfish' and Domain='Food')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Shellfish')
set @metaid= (select metadataid from MetaData where DisplayText ='Tomato' and Domain='Food')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Tomato')
set @metaid= (select metadataid from MetaData where DisplayText ='Others' and Domain='Food')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Others')

end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TypeDrugs')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('TypeDrugs','30','Pencillin','en-GB',0),
('TypeDrugs','31','Cephalosporins','en-GB',0),
('TypeDrugs','32','Digoxin','en-GB',0),
('TypeDrugs','33','SulphaDrugs','en-GB',0),
('TypeDrugs','34','Others','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Pencillin' and Domain='TypeDrugs')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Pencillin')
set @metaid= (select metadataid from MetaData where DisplayText ='Cephalosporins' and Domain='TypeDrugs')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Cephalosporins')
set @metaid= (select metadataid from MetaData where DisplayText ='Digoxin' and Domain='TypeDrugs')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Digoxin')
set @metaid= (select metadataid from MetaData where DisplayText ='SulphaDrugs' and Domain='TypeDrugs')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','SulphaDrugs')
set @metaid= (select metadataid from MetaData where DisplayText ='Others' and Domain='TypeDrugs')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Others')


end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='FollowPhy')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('FollowPhy','1','Next 1 Day','en-GB',0),
('FollowPhy','2','Next 1 Week','en-GB',0)


END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Next 1 Day' and Domain='FollowPhy')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Next 1 Day')
set @metaid= (select metadataid from MetaData where DisplayText ='Next 1 Week' and Domain='FollowPhy')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Next 1 Week')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='rdbType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('rdbType','1','Visit Number','en-GB',0),
('rdbType','2','Barcode Number','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Visit Number' and Domain='rdbType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Visit Number')
set @metaid= (select metadataid from MetaData where DisplayText ='Barcode Number' and Domain='rdbType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Barcode Number')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
------------------------------------------------------------------------------------------------------------
----------------------------------Admin\AddInvandGroup.aspx----------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AdminInvorGroup')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('AdminInvorGroup','INV','Investigation','en-GB',0),
('AdminInvorGroup','GRP','Group','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Investigation'  and Domain='AdminInvorGroup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Investigation')
set @metaid= (select metadataid from MetaData where DisplayText ='Group' and Domain='AdminInvorGroup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Group')
END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

-------------------------------PackageProfileControl.ascx/Pkgprofilectrl-----------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pkgprofilectrl')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Pkgprofilectrl','Consultation','Consultation','en-GB',0),
('Pkgprofilectrl','Treatment Procedure','Treatment Procedure','en-GB',0),
('Pkgprofilectrl','General Health Checkup','General Health Checkup','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Consultation'  and Domain='Pkgprofilectrl')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Consultation')
set @metaid= (select metadataid from MetaData where DisplayText ='Treatment Procedure' and Domain='Pkgprofilectrl')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Treatment Procedure')
set @metaid= (select metadataid from MetaData where DisplayText ='General Health Checkup' and Domain='Pkgprofilectrl')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','General Health Checkup')
END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

-----------------------PhyShedule.ascx//'AdminPhyschEmailSMS' ----------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AdminPhyschEmailSMS')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('AdminPhyschEmailSMS','Email','E-Mail','en-GB',0),
('AdminPhyschEmailSMS','SMS','SMS','en-GB',0),
('AdminPhyschEmailSMS','Both','Both(SMS And E-Mail)','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='E-Mail' and Domain='AdminPhyschEmailSMS')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','E-Mail')
set @metaid= (select metadataid from MetaData where DisplayText ='SMS' and Domain='AdminPhyschEmailSMS')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','SMS')
set @metaid= (select metadataid from MetaData where DisplayText ='Both(SMS And E-Mail)' and Domain='AdminPhyschEmailSMS')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Both(SMS And E-Mail)')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

--------------------------------------------FileUpload.aspx\'AnalyzerFupld'---------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AnalyzerFupld')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('AnalyzerFupld','0','SOP','en-GB',0),
('AnalyzerFupld','1','MOU','en-GB',0),
('AnalyzerFupld','2','SLA','en-GB',0),
('AnalyzerFupld','3','Price Sheet','en-GB',0),
('AnalyzerFupld','4','Others','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='SOP' and Domain='AnalyzerFupld')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','SOP')
set @metaid= (select metadataid from MetaData where DisplayText ='MOU' and Domain='AnalyzerFupld')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','MOU')
set @metaid= (select metadataid from MetaData where DisplayText ='SLA' and Domain='AnalyzerFupld')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','SLA')
set @metaid= (select metadataid from MetaData where DisplayText ='Price Sheet' and Domain='AnalyzerFupld')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Price Sheet')
set @metaid= (select metadataid from MetaData where DisplayText ='Others' and Domain='AnalyzerFupld')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Others')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


-------------------------------------------DoctorSchedule.aspx\'AdminDoctorScheduleSelect'--------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AdminDoctorScheduleSelect')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES
('AdminDoctorScheduleSelect','1','Daily','en-GB',0),
('AdminDoctorScheduleSelect','2','Weekly','en-GB',0),
('AdminDoctorScheduleSelect','3','Monthly','en-GB',0),
('AdminDoctorScheduleSelect','4','Yearly','en-GB',0)
END

BEGIN
declare @metaid int

set @metaid= (select metadataid from MetaData where DisplayText ='Daily' and Domain='AdminDoctorScheduleSelect')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Daily')
set @metaid= (select metadataid from MetaData where DisplayText ='Weekly' and Domain='AdminDoctorScheduleSelect')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Weekly')
set @metaid= (select metadataid from MetaData where DisplayText ='Monthly' and Domain='AdminDoctorScheduleSelect')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Monthly')
set @metaid= (select metadataid from MetaData where DisplayText ='Yearly' and Domain='AdminDoctorScheduleSelect')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Yearly')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------DoctorSchedule   \'AdminDoctorScheduleRadio'-----------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AdminDoctorScheduleRadio')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('AdminDoctorScheduleRadio','day of the month','day of the month','en-GB',0),
('AdminDoctorScheduleRadio','day of the week','day of the week','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='day of the month' and Domain='AdminDoctorScheduleRadio')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','day of the month')
set @metaid= (select metadataid from MetaData where DisplayText ='day of the week' and Domain='AdminDoctorScheduleRadio')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','day of the week')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------AdminDoctorScheduleWeekDays\'AdminDoctorScheduleWeekDays'--------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AdminDoctorScheduleWeekDays')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('AdminDoctorScheduleWeekDays',0,'Sun','en-GB',0),
('AdminDoctorScheduleWeekDays',1,'Mon','en-GB',0),
('AdminDoctorScheduleWeekDays',2,'Tue','en-GB',0),
('AdminDoctorScheduleWeekDays',3,'Wed','en-GB',0),
('AdminDoctorScheduleWeekDays',4,'Thu','en-GB',0),
('AdminDoctorScheduleWeekDays',5,'Fri','en-GB',0),
('AdminDoctorScheduleWeekDays',6,'Sat','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Sun' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sun')
set @metaid= (select metadataid from MetaData where DisplayText ='Mon' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Mon')
set @metaid= (select metadataid from MetaData where DisplayText ='Tue' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Tue')
set @metaid= (select metadataid from MetaData where DisplayText ='Wed' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Wed')
set @metaid= (select metadataid from MetaData where DisplayText ='Thu' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Thu')
set @metaid= (select metadataid from MetaData where DisplayText ='Fri' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Fri')
set @metaid= (select metadataid from MetaData where DisplayText ='Sat' and Domain='AdminDoctorScheduleWeekDays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sat')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------GeneralBillingItemMaster\'BillItemMasterChk'---------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillItemMasterChk')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('BillItemMasterChk','IsDefaultBilling','IsDefaultBilling','en-GB',0),
('BillItemMasterChk','IsDiscountable','IsDiscountable','en-GB',0),
('BillItemMasterChk','IsTaxable','IsTaxable','en-GB',0),
('BillItemMasterChk','IsVariable','IsVariable','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='IsDefaultBilling' and Domain='BillItemMasterChk')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IsDefaultBilling')
set @metaid= (select metadataid from MetaData where DisplayText ='IsDiscountable' and Domain='BillItemMasterChk')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IsDiscountable')
set @metaid= (select metadataid from MetaData where DisplayText ='IsTaxable' and Domain='BillItemMasterChk')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IsTaxable')
set @metaid= (select metadataid from MetaData where DisplayText ='IsVariable' and Domain='BillItemMasterChk')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IsVariable')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

--------------------------------TestMaster.ascx OperatorRange\'TMasterCtrlOperRange'-------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TMasterCtrlOperRange')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES
('TMasterCtrlOperRange','<','<','en-GB',0),
('TMasterCtrlOperRange','<=','<=','en-GB',0),
('TMasterCtrlOperRange','=','=','en-GB',0),
('TMasterCtrlOperRange','>','>','en-GB',0),
('TMasterCtrlOperRange','=>','=>','en-GB',0),
('TMasterCtrlOperRange','Between','Between','en-GB',0)

END

BEGIN
declare @metaid int

set @metaid= (select metadataid from MetaData where DisplayText ='<' and Domain='TMasterCtrlOperRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','<')
set @metaid= (select metadataid from MetaData where DisplayText ='<=' and Domain='TMasterCtrlOperRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','<=')
set @metaid= (select metadataid from MetaData where DisplayText ='=' and Domain='TMasterCtrlOperRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','=')
set @metaid= (select metadataid from MetaData where DisplayText ='>' and Domain='TMasterCtrlOperRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','>')
set @metaid= (select metadataid from MetaData where DisplayText ='=>' and Domain='TMasterCtrlOperRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','=>')
set @metaid= (select metadataid from MetaData where DisplayText ='Between' and Domain='TMasterCtrlOperRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Between')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------TestMaster.ascx Operator Range1\'TMasterCtrlOperRange1'----------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TMasterCtrlOperRange1')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES
('TMasterCtrlOperRange1','<','<','en-GB',0),
('TMasterCtrlOperRange1','<=','<=','en-GB',0),
('TMasterCtrlOperRange1','=','=','en-GB',0),
('TMasterCtrlOperRange1','>','>','en-GB',0),
('TMasterCtrlOperRange1','=>','=>','en-GB',0),
('TMasterCtrlOperRange1','Between','Between','en-GB',0),
('TMasterCtrlOperRange1','Source','Source','en-GB',0)
END

BEGIN
declare @metaid int

set @metaid= (select metadataid from MetaData where DisplayText ='<' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','<')
set @metaid= (select metadataid from MetaData where DisplayText ='<=' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','<=')
set @metaid= (select metadataid from MetaData where DisplayText ='=' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','=')
set @metaid= (select metadataid from MetaData where DisplayText ='>' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','>')
set @metaid= (select metadataid from MetaData where DisplayText ='=>' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','=>')
set @metaid= (select metadataid from MetaData where DisplayText ='Between' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Between')
set @metaid= (select metadataid from MetaData where DisplayText ='Source' and Domain='TMasterCtrlOperRange1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Source')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------TMasterCtrlInterpretation\'TMasterCtrlInterpretation'---------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TMasterCtrlInterpretation')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES
('TMasterCtrlInterpretation','Interpretation','Interpretation','en-GB',0),
('TMasterCtrlInterpretation','Interpretation and Value','Interpretation and Value','en-GB',0)
END

BEGIN
declare @metaid int

set @metaid= (select metadataid from MetaData where DisplayText ='Interpretation' and Domain='TMasterCtrlInterpretation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Interpretation')
set @metaid= (select metadataid from MetaData where DisplayText ='Interpretation and Value' and Domain='TMasterCtrlInterpretation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Interpretation and Value')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------'TMasterCtrlSubCategory'--------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TMasterCtrlSubCategory')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES
('TMasterCtrlSubCategory','Age','Age','en-GB',0),
('TMasterCtrlSubCategory','Common','Common','en-GB',0),
('TMasterCtrlSubCategory','Other','Other','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Age' and Domain='TMasterCtrlSubCategory')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Age')
set @metaid= (select metadataid from MetaData where DisplayText ='Common' and Domain='TMasterCtrlSubCategory')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Common')
set @metaid= (select metadataid from MetaData where DisplayText ='Other' and Domain='TMasterCtrlSubCategory')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Other')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


------------------------------'PayTypeCCCC'---------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='PayTypeCCCC')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('PayTypeCCCC','0','Cash','en-GB',0),
('PayTypeCCCC','1','Credit','en-GB',0),
('PayTypeCCCC','2','Credit&Cash','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Cash' and Domain='PayTypeCCCC')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Cash')
set @metaid= (select metadataid from MetaData where DisplayText ='Credit' and Domain='PayTypeCCCC')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Credit')
set @metaid= (select metadataid from MetaData where DisplayText ='Credit&Cash' and Domain='PayTypeCCCC')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Credit&Cash')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------ReportLims\'ReportHdr'-----------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ReportHdr')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('ReportHdr','0','IMAGING','en-GB',0),
('ReportHdr','1','LAB','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='IMAGING'  and Domain='ReportHdr')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IMAGING' )
set @metaid= (select metadataid from MetaData where DisplayText ='LAB'  and Domain='ReportHdr')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','LAB' )
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

------------------------Blood Group CommonControls  EmployerRegDetails.ascx\'BloodGrup'----------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BloodGrup')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('BloodGrup','0','O+','en-GB',0),
('BloodGrup','1','A+','en-GB',0),
('BloodGrup','2','B+','en-GB',0),
('BloodGrup','3','O-','en-GB',0),
('BloodGrup','4','A-','en-GB',0),
('BloodGrup','5','B-','en-GB',0),
('BloodGrup','6','A1+','en-GB',0),
('BloodGrup','7','A1-','en-GB',0),
('BloodGrup','8','AB+','en-GB',0),
('BloodGrup','9','AB-','en-GB',0),
('BloodGrup','10','A1B+','en-GB',0),
('BloodGrup','11','A1B-','en-GB',0),
('BloodGrup','12','A2+','en-GB',0),
('BloodGrup','13','A2-','en-GB',0),
('BloodGrup','14','A2B+','en-GB',0),
('BloodGrup','15','A2B-','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='O+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','O+')
set @metaid= (select metadataid from MetaData where DisplayText ='A+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A+')
set @metaid= (select metadataid from MetaData where DisplayText ='B+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','B+')
set @metaid= (select metadataid from MetaData where DisplayText ='O-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','O-')
set @metaid= (select metadataid from MetaData where DisplayText ='A-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A-')
set @metaid= (select metadataid from MetaData where DisplayText ='B-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','B-')
set @metaid= (select metadataid from MetaData where DisplayText ='A1+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A1+')
set @metaid= (select metadataid from MetaData where DisplayText ='A1-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A1-')
set @metaid= (select metadataid from MetaData where DisplayText ='AB+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','AB+')
set @metaid= (select metadataid from MetaData where DisplayText ='AB-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','AB-')
set @metaid= (select metadataid from MetaData where DisplayText ='A1B+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A1B+')
set @metaid= (select metadataid from MetaData where DisplayText ='A1B-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A1B-')
set @metaid= (select metadataid from MetaData where DisplayText ='A2+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A2+')
set @metaid= (select metadataid from MetaData where DisplayText ='A2-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A2-')
set @metaid= (select metadataid from MetaData where DisplayText ='A2B+' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A2B+')
set @metaid= (select metadataid from MetaData where DisplayText ='A2B-' and Domain='BloodGrup')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','A2B-')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
----------------------------------------------------------------------------------------------------------




GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Btc_Type')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Btc_Type',0,'Normal','en-GB',0),('Btc_Type',1,'Abnormal','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Normal' and Domain='Btc_Type')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Normal')
set @metaid= (select metadataid from MetaData where DisplayText ='Abnormal' and Domain='Btc_Type')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Abnormal')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO 

----BatchwiseEnterresult.aspx
----BatchwiseEnterresult.aspx.cs
--------------------------------------------------------------------------------------------------------




GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='WL_Type')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('WL_Type','Portrait Format','Portrait Format','en-GB',0),
('WL_Type','Group Contents in Column','Group Contents in Column','en-GB',0),
('WL_Type','3 Column Group Contents','3 Column Group Contents','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Portrait Format' and Domain='WL_Type')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Portrait Format')
set @metaid= (select metadataid from MetaData where DisplayText ='Group Contents in Column' and Domain='WL_Type')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Group Contents in Column')
set @metaid= (select metadataid from MetaData where DisplayText ='Group Contents in Column' and Domain='WL_Type')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','3 Column Group Contents')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='WL_TestType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('WL_TestType','All','All','en-GB',0),('WL_TestType','Retest','Retest','en-GB',0),
('WL_TestType','STAT','STAT','en-GB',0),('WL_TestType','VIP','VIP','en-GB',0),
('WL_TestType','Recheck','Recheck','en-GB',0),('WL_TestType','Reflex','Reflex','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='All' and Domain='WL_TestType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','All')
set @metaid= (select metadataid from MetaData where DisplayText ='Retest' and Domain='WL_TestType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Retest')
set @metaid= (select metadataid from MetaData where DisplayText ='STAT' and Domain='WL_TestType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','STAT')
set @metaid= (select metadataid from MetaData where DisplayText ='VIP' and Domain='WL_TestType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','VIP')
set @metaid= (select metadataid from MetaData where DisplayText ='Recheck' and Domain='WL_TestType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Recheck')
set @metaid= (select metadataid from MetaData where DisplayText ='Reflex' and Domain='WL_TestType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Reflex')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO



-----------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Chk_pendingdays')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Chk_pendingdays',0,'0','en-GB',0),('Chk_pendingdays',1,'1','en-GB',0),
('Chk_pendingdays',2,'3','en-GB',0),('Chk_pendingdays',3,'5','en-GB',0),
('Chk_pendingdays',4,'7','en-GB',0),('Chk_pendingdays',5,'10','en-GB',0),('Chk_pendingdays',6,'21','en-GB',0),
('Chk_pendingdays',7,'42','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='0' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','0')
set @metaid= (select metadataid from MetaData where DisplayText ='1' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','1')
set @metaid= (select metadataid from MetaData where DisplayText ='3' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','3')
set @metaid= (select metadataid from MetaData where DisplayText ='5' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','5')
set @metaid= (select metadataid from MetaData where DisplayText ='7' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','7')
set @metaid= (select metadataid from MetaData where DisplayText ='10' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','10')
set @metaid= (select metadataid from MetaData where DisplayText ='21' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','21')
set @metaid= (select metadataid from MetaData where DisplayText ='42' and Domain='Chk_pendingdays')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','42')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


----------------------BatchWiseWorkList.aspx
----------------------BatchWiseWorkList.aspx.cs
-----------------------------------------------------------------------------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pattern_StartTime')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Pattern_StartTime',0,'1','en-GB',0),('Pattern_StartTime',1,'2','en-GB',0),
('Pattern_StartTime',2,'3','en-GB',0),('Pattern_StartTime',3,'4','en-GB',0),
('Pattern_StartTime',4,'5','en-GB',0),('Pattern_StartTime',5,'6','en-GB',0),('Pattern_StartTime',6,'7','en-GB',0),
('Pattern_StartTime',7,'8','en-GB',0),('Pattern_StartTime',8,'9','en-GB',0),('Pattern_StartTime',9,'10','en-GB',0),
('Pattern_StartTime',10,'11','en-GB',0),('Pattern_StartTime',11,'12','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='1' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','1')
set @metaid= (select metadataid from MetaData where DisplayText ='2' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','2')
set @metaid= (select metadataid from MetaData where DisplayText ='3' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','3')
set @metaid= (select metadataid from MetaData where DisplayText ='4' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','4')
set @metaid= (select metadataid from MetaData where DisplayText ='5' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','5')
set @metaid= (select metadataid from MetaData where DisplayText ='6' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','6')
set @metaid= (select metadataid from MetaData where DisplayText ='7' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','7')
set @metaid= (select metadataid from MetaData where DisplayText ='8' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','8')
set @metaid= (select metadataid from MetaData where DisplayText ='9' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','9')
set @metaid= (select metadataid from MetaData where DisplayText ='10' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','10')
set @metaid= (select metadataid from MetaData where DisplayText ='11' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','11')
set @metaid= (select metadataid from MetaData where DisplayText ='12' and Domain='Pattern_StartTime')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','12')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

---------------------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pattern_ampm')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Pattern_ampm',0,'am','en-GB',0),('Pattern_ampm',1,'pm','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='am' and Domain='Pattern_ampm')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','am')
set @metaid= (select metadataid from MetaData where DisplayText ='pm' and Domain='Pattern_ampm')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','pm')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pattern_TimeInterval')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Pattern_TimeInterval',0,'10','en-GB',0),('Pattern_TimeInterval',1,'20','en-GB',0),
('Pattern_TimeInterval',2,'30','en-GB',0),('Pattern_TimeInterval',3,'40','en-GB',0),
('Pattern_TimeInterval',4,'50','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='10' and Domain='Pattern_TimeInterval')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','10')
set @metaid= (select metadataid from MetaData where DisplayText ='20' and Domain='Pattern_TimeInterval')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','20')
set @metaid= (select metadataid from MetaData where DisplayText ='30' and Domain='Pattern_TimeInterval')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','30')
set @metaid= (select metadataid from MetaData where DisplayText ='40' and Domain='Pattern_TimeInterval')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','40')
set @metaid= (select metadataid from MetaData where DisplayText ='50' and Domain='Pattern_TimeInterval')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','50')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------------CultureandSensitivityReport.ascx--------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pattern_GrowthStatus')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Pattern_GrowthStatus',1,'Scanty','en-GB',0),('Pattern_GrowthStatus',2,'Moderate','en-GB',0),
('Pattern_GrowthStatus',3,'Heavy','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Scanty' and Domain='Pattern_GrowthStatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Scanty')
set @metaid= (select metadataid from MetaData where DisplayText ='Moderate' and Domain='Pattern_GrowthStatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Moderate')
set @metaid= (select metadataid from MetaData where DisplayText ='Heavy' and Domain='Pattern_GrowthStatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Heavy')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------------------------CultureandSensitivityReportV1.ascx
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='CustomPeriodRange')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('CustomPeriodRange',1,'This Week','en-GB',0),
('CustomPeriodRange',2,'This Month','en-GB',0),
('CustomPeriodRange',3,'This Year','en-GB',0),
('CustomPeriodRange',4,'CustomPeriod','en-GB',0),
('CustomPeriodRange',5,'Today','en-GB',0),
('CustomPeriodRange',6,'Last Month','en-GB',0),
('CustomPeriodRange',7,'Last Week','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='This Week' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','This Week')
set @metaid= (select metadataid from MetaData where DisplayText ='This Month' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','This Month')
set @metaid= (select metadataid from MetaData where DisplayText ='This Year' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','This Year')
set @metaid= (select metadataid from MetaData where DisplayText ='CustomPeriod' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','CustomPeriod')
set @metaid= (select metadataid from MetaData where DisplayText ='Today' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Today')
set @metaid= (select metadataid from MetaData where DisplayText ='Last Month' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Last Month')
set @metaid= (select metadataid from MetaData where DisplayText ='Last Week' and Domain='CustomPeriodRange')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Last Week')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------------------------------------------------------------------FluidAnalysisCytologyPattern.ascx----------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Absent')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Absent',0,'Absent','en-GB',0),
('Absent',1,'Present','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Absent' and Domain='Absent')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Absent')
set @metaid= (select metadataid from MetaData where DisplayText ='Present' and Domain='Absent')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Present')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ProcessingMethods')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('ProcessingMethods',1,'Routine','en-GB',0),
('ProcessingMethods',2,'Frozen Section','en-GB',0),('ProcessingMethods',3,'Microwave Value','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Routine' and Domain='ProcessingMethods')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Routine')
set @metaid= (select metadataid from MetaData where DisplayText ='Frozen Section' and Domain='ProcessingMethods')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Frozen Section')
set @metaid= (select metadataid from MetaData where DisplayText ='Microwave Value' and Domain='ProcessingMethods')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Microwave Value')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO




GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Staining')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('Staining',1,'Hematoxylin and Eosin','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Hematoxylin and Eosin' and Domain='Staining')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Hematoxylin and Eosin')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO



GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='PrintType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
values('PrintType','0','Investigation Report','en-GB',0),
('PrintType','1','Dispatch Checklist','en-GB',0),
('PrintType','2','Receipt','en-GB',0),
 ('PrintType','BILL','Receipt Dispatch','en-GB',0),
  ('PrintType','RPT','Report Dispatch','en-GB',0),
   ('PrintType','RPTCHK','Report Checklist','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Investigation Report' and Domain='PrintType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Investigation Report')
set @metaid= (select metadataid from MetaData where DisplayText ='Dispatch Checklist' and Domain='PrintType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Dispatch Checklist')
set @metaid= (select metadataid from MetaData where DisplayText ='Receipt' and Domain='PrintType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Receipt')
set @metaid= (select metadataid from MetaData where DisplayText ='Receipt Dispatch' and Domain='PrintType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Receipt Dispatch')
set @metaid= (select metadataid from MetaData where DisplayText ='Report Dispatch' and Domain='PrintType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Report Dispatch')
set @metaid= (select metadataid from MetaData where DisplayText ='Report Dispatch' and Domain='PrintType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Report Checklis')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

-----------------------------------------------------------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Printstatus')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
values('Printstatus','Non Printed','Non Printed','en-GB',0),
('Printstatus','Printed','Printed','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Non Printed' and Domain='Printstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Non Printed')
set @metaid= (select metadataid from MetaData where DisplayText ='Printed' and Domain='Printstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Printed')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

--------------------------------------------------------------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='InvResultTemplate')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
values('InvResultTemplate',0,'TextReport','en-GB',0),
('InvResultTemplate',1,'Letter','en-GB',0),
('InvResultTemplate',2,'Referral','en-GB',0),
('InvResultTemplate',3,'Fitness','en-GB',0),
('InvResultTemplate',4,'Suggestions','en-GB',0),
('InvResultTemplate',5,'ResultSummary','en-GB',0),
('InvResultTemplate',6,'Imaging','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='TextReport' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','TextReport')
set @metaid= (select metadataid from MetaData where DisplayText ='Letter' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Letter')
set @metaid= (select metadataid from MetaData where DisplayText ='Referral' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Referral')
set @metaid= (select metadataid from MetaData where DisplayText ='Fitness' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Fitness')
set @metaid= (select metadataid from MetaData where DisplayText ='Suggestions' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Suggestions')
set @metaid= (select metadataid from MetaData where DisplayText ='ResultSummary' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ResultSummary')
set @metaid= (select metadataid from MetaData where DisplayText ='Imaging' and Domain='InvResultTemplate')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Imaging')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

----------------------------------------------------------------------------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Motality')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
values('Motality',0,'grade0','en-GB',0),
('Motality',1,'gradeI','en-GB',0),
('Motality',2,'gradeII','en-GB',0),
('Motality',3,'gradeIII','en-GB',0),
('Motality',4,'gradeIV','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='grade0' and Domain='Motality')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','grade0')
set @metaid= (select metadataid from MetaData where DisplayText ='gradeI' and Domain='Motality')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','gradeI')
set @metaid= (select metadataid from MetaData where DisplayText ='gradeII' and Domain='Motality')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','gradeII')
set @metaid= (select metadataid from MetaData where DisplayText ='gradeIII' and Domain='Motality')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','gradeIII')
set @metaid= (select metadataid from MetaData where DisplayText ='gradeIV' and Domain='Motality')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','gradeIV')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

----------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='CultureType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
values('CultureType',1,'ABO Group','en-GB',0),
('CultureType',2,'Micro Serology','en-GB',0),
('CultureType',3,'PAP Smear','en-GB',0),
('CultureType',4,'Urinalysis','en-GB',0),
('CultureType',5,'Urine Drug','en-GB',0),
('CultureType',6,'Urine Pregnancy Test','en-GB',0),
('CultureType',7,'VDRL (RPR)','en-GB',0)


END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='ABO Group' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ABO Group')
set @metaid= (select metadataid from MetaData where DisplayText ='Micro Serology' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Micro Serology')
set @metaid= (select metadataid from MetaData where DisplayText ='PAP Smear' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','PAP Smear')
set @metaid= (select metadataid from MetaData where DisplayText ='Urinalysis' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Urinalysis')
set @metaid= (select metadataid from MetaData where DisplayText ='Urine Drug' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Urine Drug')
set @metaid= (select metadataid from MetaData where DisplayText ='Urine Pregnancy Test' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Urine Pregnancy Test')
set @metaid= (select metadataid from MetaData where DisplayText ='VDRL (RPR)' and Domain='CultureType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','VDRL (RPR)')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

----------------------------------------------------------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Mode')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
values('Mode',1,'ALL','en-GB',0)


END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='ALL' and Domain='Mode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ALL')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

----------------------------------------------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='SampleTimeType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('SampleTimeType','AM','AM','en-GB',0),('SampleTimeType','PM','PM','en-GB',0),('SampleTimeType','0','','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='AM' and Domain='SampleTimeType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','AM')
set @metaid= (select metadataid from MetaData where DisplayText ='PM' and Domain='SampleTimeType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','PM')
set @metaid= (select metadataid from MetaData where DisplayText ='' and Domain='SampleTimeType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','0')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO 


--------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='SearchType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('SearchType','4','None','en-GB',0,null),('SearchType','0','Name','en-GB',0,null),
('SearchType','1','PID','en-GB',0,null),
('SearchType','2','Mobile/Phone','en-GB',0,null),
('SearchType','3','Booking Number','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='None' and Domain='SearchType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','None')




set @metaid= (select metadataid from MetaData where DisplayText ='Name' and Domain='SearchType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Name')




set @metaid= (select metadataid from MetaData where DisplayText ='PID' and Domain='SearchType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','PID')




set @metaid= (select metadataid from MetaData where DisplayText ='Mobile/Phone' and Domain='SearchType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Mobile/Phone')




set @metaid= (select metadataid from MetaData where DisplayText ='Booking Number' and Domain='SearchType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Booking Number')



set @metaid= (select metadataid from MetaData where DisplayText ='Booking Number' and Domain='SearchType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Booking Number')
END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


-----------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ReceiptType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('ReceiptType',1,'IP Payments','en-GB',0,null),
('ReceiptType',2,'Advance','en-GB',0,null),
('ReceiptType',3,'Deposit','en-GB',0,null),
('ReceiptType',4,'Co Payment','en-GB',0,null),
('ReceiptType',6,'Cash In Flow','en-GB',0,null),
('ReceiptType',7,'Due Receipt','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='IP Payments' and Domain='ReceiptType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IP Payments')





set @metaid= (select metadataid from MetaData where DisplayText ='Advance' and Domain='ReceiptType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Advance')





set @metaid= (select metadataid from MetaData where DisplayText ='Deposit' and Domain='ReceiptType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Deposit')





set @metaid= (select metadataid from MetaData where DisplayText ='Co Payment' and Domain='ReceiptType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Co Payment')



set @metaid= (select metadataid from MetaData where DisplayText ='Cash In Flow' and Domain='ReceiptType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Cash In Flow')



set @metaid= (select metadataid from MetaData where DisplayText ='Due Receipt' and Domain='ReceiptType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Due Receipt')
END


END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


---------------------------------------------------------------------------------------------------------------------------------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='RemoteType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('RemoteType','None','None','en-GB',0,null),
('RemoteType','Client_Access','Client Access','en-GB',0,null),
('RemoteType','Remote_Registration','Remote Registration','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='None' and Domain='RemoteType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','None')

set @metaid= (select metadataid from MetaData where DisplayText ='Client Access' and Domain='RemoteType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Client Access')

set @metaid= (select metadataid from MetaData where DisplayText ='Remote Registration' and Domain='RemoteType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Remote Registration')
END

END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


-------------------------------------------------------------------------------------------------------------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ThresholdType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('ThresholdType',1,'Threshold amount in value','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Threshold amount in value' and Domain='ThresholdType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Threshold amount in value')
END

END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

----------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='VirtualType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('VirtualType','Virtual_Credit_% ','Virtual Credit % ','en-GB',0,null),
('VirtualType','Virtual_Credit_Amt','Virtual Credit Amt','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Virtual Credit % ' and Domain='VirtualType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Virtual Credit % ')

set @metaid= (select metadataid from MetaData where DisplayText ='Virtual Credit Amt' and Domain='VirtualType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Virtual Credit Amt')
END

END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO


-------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='InvoiceCycle1')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('InvoiceCycle1','15_Days','15 Days','en-GB',0,null),
('InvoiceCycle1','1_Month','1 Month','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='15 Days' and Domain='InvoiceCycle1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','15 Days')


set @metaid= (select metadataid from MetaData where DisplayText ='1 Month' and Domain='InvoiceCycle1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','1 Month')
END

END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO


----------------------------------------------------------------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='SelectType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('SelectType','Lab_Investigation','Lab Investigation','en-GB',0,null),
('SelectType','Consultation','Consultation','en-GB',0,null),

('SelectType','Treatment_Procedure','Treatment Procedure','en-GB',0,null),
('SelectType','General_Health_Checkup','General Health Checkup','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Lab Investigation' and Domain='SelectType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Lab Investigation')

set @metaid= (select metadataid from MetaData where DisplayText ='Consultation' and Domain='SelectType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Consultation')

set @metaid= (select metadataid from MetaData where DisplayText ='Treatment Procedure' and Domain='SelectType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Treatment Procedure')

set @metaid= (select metadataid from MetaData where DisplayText ='General Health Checkup' and Domain='SelectType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','General Health Checkup')
END





END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ServiceType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('ServiceType',1,'Mapped Services','en-GB',0,null),
('ServiceType',2,'Un-Mapped Service','en-GB',0,null),

('ServiceType',3,'Zero-Value services','en-GB',0,null),
('ServiceType',4,'Zero-Value with mapped Services','en-GB',0,null),
('ServiceType',5,'Zero With Un-Mapped Services','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Mapped Services' and Domain='ServiceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Mapped Services')

set @metaid= (select metadataid from MetaData where DisplayText ='Un-Mapped Service' and Domain='ServiceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Un-Mapped Service')

set @metaid= (select metadataid from MetaData where DisplayText ='Zero-Value services' and Domain='ServiceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Zero-Value services')

set @metaid= (select metadataid from MetaData where DisplayText ='Zero-Value with mapped Services' and Domain='ServiceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Zero-Value with mapped Services')

set @metaid= (select metadataid from MetaData where DisplayText ='Zero With Un-Mapped Services' and Domain='ServiceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Zero With Un-Mapped Services')
END







END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='OptionType1')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('OptionType1',1,'Department','en-GB',0,null),
('OptionType1',2,'Analyzer','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Department' and Domain='OptionType1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Department')

set @metaid= (select metadataid from MetaData where DisplayText ='Analyzer' and Domain='OptionType1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Analyzer')


END






END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO



------------------------------------------------------------------------------------------------------------



GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AddReduceType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('AddReduceType','ADD','Add','en-GB',0,null),
('AddReduceType','REDUCE','Reduce','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Add' and Domain='AddReduceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Add')

set @metaid= (select metadataid from MetaData where DisplayText ='Reduce' and Domain='AddReduceType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Reduce')
END








END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO


------------------------------------------------------------------------------------------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='PercentageValueType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('PercentageValueType','PER','Percentage','en-GB',0,null),
('PercentageValueType','VAL','Value','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Percentage' and Domain='PercentageValueType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Percentage')

set @metaid= (select metadataid from MetaData where DisplayText ='Value' and Domain='PercentageValueType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Value')
END







END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO

---------------------------------------------------------------------------------------------------------------------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ValidationType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('ValidationType','Select','Select','en-GB',0,null),
('ValidationType','Days','Days','en-GB',0,null),
('ValidationType','Weeks','Weeks','en-GB',0,null),

('ValidationType','Months','Months','en-GB',0,null),
('ValidationType','Year','Year','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Days' and Domain='ValidationType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Days')

set @metaid= (select metadataid from MetaData where DisplayText ='Weeks' and Domain='ValidationType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Weeks')

set @metaid= (select metadataid from MetaData where DisplayText ='Months' and Domain='ValidationType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Months')

set @metaid= (select metadataid from MetaData where DisplayText ='Year' and Domain='ValidationType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Year')
END







END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO

------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='LogicType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('LogicType','FULDAY','Fully Day','en-GB',0,null),
('LogicType','HLFDAY','Half Day','en-GB',0,null),

('LogicType','HOURLY','Hour Basic','en-GB',0,null)


END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Fully Day' and Domain='LogicType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Fully Day')

set @metaid= (select metadataid from MetaData where DisplayText ='Half Day' and Domain='LogicType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Half Day')

set @metaid= (select metadataid from MetaData where DisplayText ='Hour Basic' and Domain='LogicType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Hour Basic')
END








END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO
-------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='LocationType')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('LocationType','1','Ordered Location','en-GB',0,null),
('LocationType','0','Process Location','en-GB',0,null)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Ordered Location' and Domain='LocationType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Ordered Location')

set @metaid= (select metadataid from MetaData where DisplayText ='Process Location' and Domain='LocationType')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Process Location')
END








END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO

------------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='VisitType1')
BEGIN	
INSERT INTO metadata(
Domain,
Code,
DisplayText,
LangCode,
ParentID,
SeqNo)
VALUES('VisitType1','0','IP','en-GB',0,null),
('VisitType1','1','OP','en-GB',0,null),
('VisitType1','-1','OP&IP','en-GB',0,null)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='IP' and Domain='VisitType1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','IP')

set @metaid= (select metadataid from MetaData where DisplayText ='OP' and Domain='VisitType1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','OP')

set @metaid= (select metadataid from MetaData where DisplayText ='OP&IP' and Domain='VisitType1')


INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','OP&IP')
END







END
SET @MinValue = @MinValue + 1 
END

drop table #TempOrgID  
GO

--------------------------------------------------------------------------------------------------------------
----------------------------------Lab/deptsamplecollection---------------------------------------

GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Labpriority')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Labpriority','1','STAT','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='STAT' and Domain='Labpriority')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','STAT')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


-----------------------------Lab/pending list---------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pendinglist')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Pendinglist','Sample Received','Sample Received','en-GB',0),
('Pendinglist','Sample Received','Sample Loaded','en-GB',0),
('Pendinglist','Sample Received','Pending','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Sample Received' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample Received')
set @metaid= (select metadataid from MetaData where DisplayText ='Sample Loaded' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample Loaded')
set @metaid= (select metadataid from MetaData where DisplayText ='Pending' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Pending')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------------Lab/investigationqueue-----------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='invlist')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('invlist','1','Order Investigation','en-GB',0),
('invlist','2','Collect sample','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Order Investigation' and Domain='invlist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Order Investigation')
set @metaid= (select metadataid from MetaData where DisplayText ='Collect sample' and Domain='invlist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Collect sample')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------Lab/homecollection ----------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Homecollstatus')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Homecollstatus','B','Booked','en-GB',0),
('Homecollstatus','R','Registered','en-GB',0),
('Homecollstatus','C','Cancelled','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Booked' and Domain='Homecollstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Booked')
set @metaid= (select metadataid from MetaData where DisplayText ='Registered' and Domain='Homecollstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Registered')
set @metaid= (select metadataid from MetaData where DisplayText ='Cancelled' and Domain='Homecollstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Cancelled')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------------------Lab/investigationorgchange----------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='statusorg')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('statusorg','Pending','Pending','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Pending' and Domain='statusorg')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Pending')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------------Lab/receivebatch-----------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='batchstatus')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('batchstatus','1','Transferred','en-GB',0),
('batchstatus','2','Received','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Transferred' and Domain='batchstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Transferred')
set @metaid= (select metadataid from MetaData where DisplayText ='Received' and Domain='batchstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Received')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
------------------------------------------------------Lab/pendingsamplecollection----------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='samplesearchtype')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('samplesearchtype','1','Visit No.','en-GB',0),
('samplesearchtype','2','Sample ID','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Visit No.' and Domain='samplesearchtype')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Visit No.')
set @metaid= (select metadataid from MetaData where DisplayText ='Sample ID' and Domain='samplesearchtype')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample ID')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
--------------------------------------------------------Lab/batchsheet---------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='batchmode')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('batchmode','1','Generate New Batch','en-GB',0),
('batchmode','2','Add To Exist Batch','en-GB',0),
('batchmode','5','View Exist Batch','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Generate New Batch' and Domain='batchmode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Generate New Batch')
set @metaid= (select metadataid from MetaData where DisplayText ='Add To Exist Batch' and Domain='batchmode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Add To Exist Batch')
set @metaid= (select metadataid from MetaData where DisplayText ='View Exist Batch' and Domain='batchmode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','View Exist Batch')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
------------------------------------------------------------Admin/manageinvcomputation----------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='InvComputation')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('InvComputation','const','Number','en-GB',0),
('InvComputation','+','+','en-GB',0),
('InvComputation','-','-','en-GB',0),
('InvComputation','/','/','en-GB',0),
('InvComputation','*','*','en-GB',0),
('InvComputation','(','(','en-GB',0),
('InvComputation',')',')','en-GB',0),
('InvComputation','Round','Round','en-GB',0),
('InvComputation','+toFixed','toFixed','en-GB',0),
('InvComputation','Power','Power','en-GB',0),
('InvComputation',',',',','en-GB',0),
('InvComputation','logBaseE','logBaseE','en-GB',0),
('InvComputation','logBase10','logBase10','en-GB',0),
('InvComputation','ALogBase10','ALogBase10','en-GB',0),
('InvComputation','ALogBaseE','ALogBaseE','en-GB',0),
('InvComputation','e','e','en-GB',0),
('InvComputation','^','^','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Number' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Number')
set @metaid= (select metadataid from MetaData where DisplayText ='+' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','+')
set @metaid= (select metadataid from MetaData where DisplayText ='-' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','-')
set @metaid= (select metadataid from MetaData where DisplayText ='/' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','/')
set @metaid= (select metadataid from MetaData where DisplayText ='*' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','*')
set @metaid= (select metadataid from MetaData where DisplayText ='(' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','(')
set @metaid= (select metadataid from MetaData where DisplayText =')' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB',')')
set @metaid= (select metadataid from MetaData where DisplayText ='Round' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Round')
set @metaid= (select metadataid from MetaData where DisplayText ='toFixed' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','toFixed')
set @metaid= (select metadataid from MetaData where DisplayText ='Power' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Power')
set @metaid= (select metadataid from MetaData where DisplayText =',' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB',',')
set @metaid= (select metadataid from MetaData where DisplayText ='logBaseE' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','logBaseE')
set @metaid= (select metadataid from MetaData where DisplayText ='logBase10' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','logBase10')
set @metaid= (select metadataid from MetaData where DisplayText ='ALogBase10' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ALogBase10')
set @metaid= (select metadataid from MetaData where DisplayText ='ALogBaseE' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ALogBaseE')
set @metaid= (select metadataid from MetaData where DisplayText ='e' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','e')
set @metaid= (select metadataid from MetaData where DisplayText ='^' and Domain='InvComputation')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','^')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
----------------------------------------------------------Admin/addorchangenumberpattern-----------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='YearFormat')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('YearFormat','YY','YY','en-GB',0),
('YearFormat','YYY','YYY','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='YY' and Domain='YearFormat')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','YY')
set @metaid= (select metadataid from MetaData where DisplayText ='YYY' and Domain='YearFormat')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','YYY')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='MonthFormat')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('MonthFormat','MM','MM','en-GB',0),
('MonthFormat','MMM','MMM','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='MM' and Domain='MonthFormat')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','MM')
set @metaid= (select metadataid from MetaData where DisplayText ='MMM' and Domain='MonthFormat')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','MMM')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='months')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('months','1','January','en-GB',0),
('months','2','February','en-GB',0),
('months','3','March','en-GB',0),
('months','4','April','en-GB',0),
('months','5','May','en-GB',0),
('months','6','June','en-GB',0),
('months','7','July','en-GB',0),
('months','8','August','en-GB',0),
('months','9','September','en-GB',0),
('months','10','October','en-GB',0),
('months','11','November','en-GB',0),
('months','12','December','en-GB',0),
('months','0','EveryMonth','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='January' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','January')
set @metaid= (select metadataid from MetaData where DisplayText ='February' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','February')
set @metaid= (select metadataid from MetaData where DisplayText ='March' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','March')
set @metaid= (select metadataid from MetaData where DisplayText ='April' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','April')
set @metaid= (select metadataid from MetaData where DisplayText ='May' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','May')
set @metaid= (select metadataid from MetaData where DisplayText ='June' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','June')
set @metaid= (select metadataid from MetaData where DisplayText ='July' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','July')
set @metaid= (select metadataid from MetaData where DisplayText ='August' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','August')
set @metaid= (select metadataid from MetaData where DisplayText ='September' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','September')
set @metaid= (select metadataid from MetaData where DisplayText ='October' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','October')
set @metaid= (select metadataid from MetaData where DisplayText ='November' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','November')
set @metaid= (select metadataid from MetaData where DisplayText ='December' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','December')
set @metaid= (select metadataid from MetaData where DisplayText ='EveryMonth' and Domain='months')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','EveryMonth')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
------------------------------------------------admin/labadminsummaryreport-------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='summaryreport')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('summaryreport','2','Summary','en-GB',0),
('summaryreport','1','Detail','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Summary' and Domain='summaryreport')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Summary')
set @metaid= (select metadataid from MetaData where DisplayText ='Detail' and Domain='summaryreport')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Detail')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
------------------------------------------------admin/changedocschedule---------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='duration')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('duration','5','5','en-GB',0),
('duration','10','10','en-GB',0),
('duration','15','15','en-GB',0),
('duration','20','20','en-GB',0),
('duration','25','25','en-GB',0),
('duration','30','30','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='5' and Domain='duration')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','5')
set @metaid= (select metadataid from MetaData where DisplayText ='10' and Domain='duration')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','10')
set @metaid= (select metadataid from MetaData where DisplayText ='15' and Domain='duration')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','15')
set @metaid= (select metadataid from MetaData where DisplayText ='20' and Domain='duration')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','20')
set @metaid= (select metadataid from MetaData where DisplayText ='25' and Domain='duration')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','25')
set @metaid= (select metadataid from MetaData where DisplayText ='30' and Domain='duration')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','30')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------------------------admin/investigationCollectionReport----------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='invreport')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('invreport','rdoALL','ALL','en-GB',0),
('invreport','rdoINV','Investigation','en-GB',0),
('invreport','rdoGRP','Group','en-GB',0),
('invreport','rdoPKG','Package','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='ALL' and Domain='invreport')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','ALL')
set @metaid= (select metadataid from MetaData where DisplayText ='Investigation' and Domain='invreport')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Investigation')
set @metaid= (select metadataid from MetaData where DisplayText ='Group' and Domain='invreport')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Group')
set @metaid= (select metadataid from MetaData where DisplayText ='Package' and Domain='invreport')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Package')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------------------investigation/investigationreport-----------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='invstatus')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('invstatus','Approved','Approved','en-GB',0),
('invstatus','Completed','Completed','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Approved' and Domain='invstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Approved')
set @metaid= (select metadataid from MetaData where DisplayText ='Completed' and Domain='invstatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Completed')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
----------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='refundmode')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES ('refundmode','1','Cash','en-GB',0),
('refundmode','2','Cheque','en-GB',0),
('refundmode','11','Credit Note','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Cash' and Domain='refundmode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Cash')
set @metaid= (select metadataid from MetaData where DisplayText ='Cheque' and Domain='refundmode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Cheque')
set @metaid= (select metadataid from MetaData where DisplayText ='Credit Note' and Domain='refundmode')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Credit Note')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO


-------------------------------------------------------------------------------
GO
Declare @OrgID int
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TGender')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('TGender','Female','Female','en-GB',0),
('TGender','Male','Male','en-GB',0),
('TGender','Both','Both','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Female' and Domain='TGender')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Female')
set @metaid= (select metadataid from MetaData where DisplayText ='Male' and Domain='TGender')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Male')
set @metaid= (select metadataid from MetaData where DisplayText ='Both' and Domain='TGender')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Both')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------
------------------Vijayalakshmi.M -------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='SampleStore')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('SampleStore','BUILDING','Building','en-GB',0),
('SampleStore','FLOOR','Floor','en-GB',0),
('SampleStore','SLOT','Slot','en-GB',0),
('SampleStore','STORAGE_AREA','Storage Area','en-GB',0),
('SampleStore','STORAGE_UNITS','Sample Storage Units','en-GB',0),
('SampleStore','TRAY','Tray','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Building' and Domain='SampleStore')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Building')
set @metaid= (select metadataid from MetaData where DisplayText ='Floor' and Domain='SampleStore')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Floor')
set @metaid= (select metadataid from MetaData where DisplayText ='Slot' and Domain='SampleStore')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Slot')
set @metaid= (select metadataid from MetaData where DisplayText ='Storage Area' and Domain='SampleStore')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Storage Area')
set @metaid= (select metadataid from MetaData where DisplayText ='Sample Storage Units' and Domain='SampleStore')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample Storage Units')
set @metaid= (select metadataid from MetaData where DisplayText ='Tray' and Domain='SampleStore')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Tray')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
----------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='TrayType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('TrayType','0','--Select--','en-GB',0),
('TrayType','1','Routine','en-GB',0),
('TrayType','2','Batch','en-GB',0),
('TrayType','3','Referred','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='--Select--' and Domain='TrayType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','--Select--')
set @metaid= (select metadataid from MetaData where DisplayText ='Routine' and Domain='TrayType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Routine')
set @metaid= (select metadataid from MetaData where DisplayText ='Batch' and Domain='TrayType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Batch')
set @metaid= (select metadataid from MetaData where DisplayText ='Referred' and Domain='TrayType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Referred')

end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Days')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Days','0','All','en-GB',0),
('Days','1','Sun','en-GB',0),
('Days','2','Mon','en-GB',0),
('Days','3','Tue','en-GB',0),
('Days','4','Wed','en-GB',0),
('Days','5','Thu','en-GB',0),
('Days','6','Fri','en-GB',0),
('Days','7','Sat','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='All' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','All')
set @metaid= (select metadataid from MetaData where DisplayText ='Sun' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sun')
set @metaid= (select metadataid from MetaData where DisplayText ='Mon' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Mon')
set @metaid= (select metadataid from MetaData where DisplayText ='Tue' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Tue')
set @metaid= (select metadataid from MetaData where DisplayText ='Wed' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Wed')
set @metaid= (select metadataid from MetaData where DisplayText ='Thu' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Thu')
set @metaid= (select metadataid from MetaData where DisplayText ='Fri' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Fri')
set @metaid= (select metadataid from MetaData where DisplayText ='Sat' and Domain='Days')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sat')

end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------------------------------------------------------------------------


CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='ReportFormat1')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('ReportFormat1',0,'Summary','en-GB',0),
('ReportFormat1',1,'Detailed','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Summary' and Domain='ReportFormat1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Summary')
set @metaid= (select metadataid from MetaData where DisplayText ='Detailed' and Domain='ReportFormat1')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Detailed')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO



------------------------------------------


CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BTList')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('BTList','CB','Credit Bills','en-GB',0),
('BTList','NCB','Non Credit Bills','en-GB',0),
('BTList','B','Both','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Credit Bills' and Domain='BTList')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Credit Bills')
set @metaid= (select metadataid from MetaData where DisplayText ='Non Credit Bills' and Domain='BTList')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Non Credit Bills')
set @metaid= (select metadataid from MetaData where DisplayText ='Both' and Domain='BTList')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Both')

end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO