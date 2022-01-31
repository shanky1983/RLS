Truncate table  ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(1,'BillLogic','Do you bill the patient before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(2,'CAS','Do you bill the patient for Casualty before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(3,'CON','Do you bill the patient for Consultation before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(4,'Currency','What is the Currency you use?','DDL','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(5,'DisplayCurrencyFormat','Enter currency symbol to print','TEXT','N','String')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(6,'HEALTHPKG','Do you bill the patient for Health Packages before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(7,'IMU','Do you bill the patient for Immunization  before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(8,'INV','Do you bill the patient for Investigations before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(9,'IPMakePayment','Do you allow intermediate payments apart from Advance','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(10,'IsAmountEditable','Allow default amount to be edited by users?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(11,'IsReceptionCashier','Do you have a separate person to collect Cash (Cashier)?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(12,'IsSurgeryAdvance','Do you collect advance for Surgeries seperately?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(13,'NeedIPNumber','Do you want the system to generate separate IP Number?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(14,'PHYSIO','Do you bill the patient for Physiotheraphy before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(15,'PrintReceipt','Do you want to print receipts for intermediate payments?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(16,'PRO','Do you bill the patient for Treatment Procedures before Service is rendered?','RDO','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(17,'RegistrationFees','Enter Registration Fees (if any)','TEXT','N','Numeric')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(18,'ShowDisclaimer','Do you want to show bill disclaimer?(e.g. This is only a receipt and cannot be used for claiming purposes)','CHB','','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(19,'ShowUnbilled','Will you surely collect complete amount during intermediate payments','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(20,'SystemAuthorization','Do you want to show casesheet disclaimer?
(e.g. Since this is a computer generated copy no signature is required)','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(21,'UseInvDrugData','Do you want to show drugs to physicians from your pharmacy?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(22,'UseOrgBasedDrugData','Do you want to use default drug data from Attune?','CHB','N','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(23,'UseSmartCardForPatient','Are you giving smartcards to your patients?','CHB','N','')
--IsInternal--'Y'
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(24,'BillPrintControl','','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(25,'InvestigationReportPath','/InvestigationReport/InvValuesForHospital','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(26,'NormalFlow','Y','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(27,'ReportServerURL','http://attune3/Reports','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(28,'ScheduleDuration','7','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(29,'UploadPath','','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(30,'ServiceTaxREGNO','AADCR0471QSD001','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(31,'HasPCCClientMapping','ClientMapping','','Y','')
INSERT INTO ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,ControlType,IsInternal,ValueType) values(32,'LabelPrinting1','','','Y','')
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey,IsInternal) values(33,'EditableUser','Y')
INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType) VALUES (34,'SampleCollect','Do you want to collect Sample?','Y','','')





---------------------------------------------------------------------
ConfigValueMaster
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(1,1,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(2,1,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(3,2,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(4,2,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(5,3,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(6,3,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(7,4,'Rs')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(8,6,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(9,6,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(10,7,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(11,7,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(12,8,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(13,8,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(14,14,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(15,14,'After')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(16,16,'Before')
INSERT INTO ConfigValueMaster(ConfigValueID,ConfigKeyID,ConfigValue)VALUES(17,16,'After')



--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=11
--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=12

--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=29
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
        WHERE C.OrgID=30
--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=26 
              
--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=31
--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=32
--INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=33 
        
--        INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
--        SELECT K.ConfigKeyID,C.ConfigValue,OrgID from  Config C INNER join ConfigKeyMaster k on k.ConfigKey=C.ConfigKey
--        WHERE C.OrgID=34 
        
        
        
        
        
Update ConfigOrgMaster set ConfigValue='Y' where ConfigValue='True'
Update ConfigOrgMaster set ConfigValue='Y' where ConfigValue='YES'
Update ConfigOrgMaster set ConfigValue='N' where ConfigValue='NO'        