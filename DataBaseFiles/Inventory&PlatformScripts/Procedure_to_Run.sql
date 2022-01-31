/***************1.Delete table records script*******************/
--DELETE FROM 	Bak2712016_invgroupmapmaster 
--DELETE FROM 	bka_codemaster_23_12_15
--DELETE FROM 	BKA_CODEMASTER112_24_12_2015
--DELETE FROM 	BKA_InvestigationOrgAttributes_01Feb2016
--DELETE FROM 	BKA_Investigationorgmapping_01Feb2016
--DELETE FROM 	BKA_InvgroupMapmaster_01FEB2016
--DELETE FROM 	ApprovalTaskDeletionTracker  WHERE CreatedAt<  DATEADD(MONTH,-1, GETDATE()) --- BEFORE TEN DATYS
--DELETE FROM 	Excel_Grp_Cont_128 
--DELETE FROM 	InvDeptSamples
--DELETE FROM 	InvestigationValueHistory
--DELETE FROM 	InvGroupMapMAster_28012016
--DELETE FROM 	InvpackageMapping_28012016
--DELETE FROM 	Machinekey
--DELETE FROM 	PatientInvestigation_Hist  WHERE CreatedAt<  DATEADD(MONTH,-1, GETDATE())
--DELETE FROM 	PatientInvestigationAttributes  
--DELETE FROM 	Print_Audit_History
--DELETE FROM 	ReportPrintHistory 
--DELETE FROM 	Tasks WHERE CreatedAt<  DATEADD(MONTH,-1, GETDATE())
--DELETE FROM 	Tasks_Hist  WHERE CreatedAt<  DATEADD(MONTH,-1, GETDATE())
--SELECT * FROM Notifications WHERE CreatedAt<  DATEADD(MONTH,-1, GETDATE())
--SELECT * FROM ReportSnapshot  WHERE CreatedAt<  DATEADD(MONTH,-1, GETDATE())
/***************2.Create Cluster Index*******************/
--01_CREATE_SCRIPT_4KEYS---Take backup
/***************3.Create Non-Cluster Index*******************/
--02_CREATE_SCRIPT_NC---Take backup
/***************4.Drop Cluster Index*******************/
--03_DROP_SCRIIPT_4KEYS---immediate Run
/***************4.Drop Non-Cluster Index*******************/
--04_DROP_SCRIP_NC---immediate Run
/***************5.Convert varchar to Nvarchar*******************/
--05_NVARCHAR---immediate Run
/***************6.Create Cluster Index*******************/
--01_CREATE_SCRIPT_4KEYS-- from-backup file to run
/***************7.Create Non-Cluster Index*******************/
--02_CREATE_SCRIPT_NC--from-backup file to run
/***************8.Run the Orgid chage tool from *******************/
---Tools\OrgChangeTool
--Note:
--1.Execute first
--1.Execute secound
/***************9.plotform scripts *******************/
---New_Tables_platform Script 
/***************10.plotform scripts *******************/
---AlterPlatform Script 
/***************Finaly Normal Lis sctipt procedures*******************/
--Create Table
--AlterScript
--UDT table 
--Function Table 
--SP_Scripts 

/****************** Inventory Master Data Scripts ******************/
 --Followed by Directory Order. 
 
 /****************** Inventory Master Data Scripts ******************/
--Add Platform Web config changes like Attuneheader,AttuneFooter and AjaxControlToolkit. 





