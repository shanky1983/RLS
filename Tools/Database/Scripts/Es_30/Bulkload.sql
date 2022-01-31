/* Login  */

delete From Organization where OrgID =30
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)values(30,'ES Hospital',1,  0,'')

delete from OrganizationAddress where OrgID = 30
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) 
Values(29,30,'','',', ',' ,','',0,'Chennai',0,'','','','Villupuram')

delete From Login where OrgID =30
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(1846,'TestEs','TestEs','N',30,  'A')

insert into IDMaster (OrgID,PatientNumber ,BillNumber ,IPNumber ,VisitNumber )values(30,0,0,0,0)



/* Organization */

/* Users */
delete From Users where OrgID =30
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('TestEs','M','1',30,1846)



/* Nurse  */

/* Role */


delete From Role where OrgID =30
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(159,'Physician','Doctor',  0,30)--146
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(160,'Nurse','Nurse',  0,30)--147
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(161,'Lab Technician','Lab Technician',  0,30)--148
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(162,'Patient','Patient',  0,30)--149
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(163,'Receptionist','Receptionist',  0,30)--150
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(164,'Administrator','Administrator',  0,30)--151
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(165,'Dialysis Technician','Dialysis Technician',  0,30)--152
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(166,'Billing','Billing',  0,30)--153
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(167,'Xray','Xray',  0,30)--154
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(168,'Accounts','Accounts',  0,30)--155
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(169,'Pharmacist','Pharmacist',  0,30)--156
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(170,'Wardsecretary','Wardsecretary',  0,30)--157
INSERT INTO Role (RoleID, RoleName, Description, ParentID, OrgID) VALUES (171, 'Cashier', 'Cashier', 0, 30)

--134




/* LoginRole  */


Insert Into LoginRole(RoleID,LoginID)values(164,1846)


/* MENU MASTer  */
DELETE FROM MenuMaster where OrgId=30
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1958,'Patient Search',0,30,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1959,'Patient Search',0,30,11)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1960,'Patient Search',0,30,12)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1961,'Patient Registration',0,30,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1962,'Home',0,30,8)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1963,'Home',0,30,9)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1964,'Home',0,30,1)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1965,'Home',0,30,14)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1966,'Reports',0,30,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1967,'Set Reminders',0,30,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1968,'Doctor Schedule',7,30,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1969,'Home',0,30,13)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1970,'Home',0,30,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1971,'Investigation Report',0,30,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1972,'Home',0,30,27)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1973,'View Schedules',7,30,37)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1974,'Today''s OP Visits',0,30,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1975,'BillSearch',0,30,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1976,'Cash Closure',0,30,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1977,'Cash Closure',0,30,48)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1978,'Patient Management',1,30,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1979,'View Room Details',1,30,54)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1980,'Visit Search',0,30,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1981,'Manage Rates',2,30,59)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1982,'Add Investigation/Groups',2,30,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1983,'Reference Range Mgmt',2,30,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1984,'Manage User',2,30,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1985,'Patient Search',0,30,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1986,'Cash OutFlow',0,30,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1987,'Check Safety Code',0,30,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1988,'Add Corporate & Client',2,30,72)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1989,'Task ReAssign',0,30,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1990,'Dashboard',0,30,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1991,'Settlement',1,30,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1992,'Billing',1,30,79)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1993,'Plan Vacation',7,30,83)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1994,'Purchase Order',3,30,93)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1995,'Stock Receive',3,30,94)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1996,'Stock Return',3,30,95)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1997,'Stock Damage',3,30,96)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1998,'Inventory Search',3,30,97)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1999,'Categories',3,30,102)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2000,'Products',3,30,103)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2001,'Suppliers',3,30,104)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2002,'Stock Issued',3,30,116)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2003,'Stock In Hand',3,30,107)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2004,'OP Billing',0,30,108)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2005,'IP Billing',0,30,113)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2006,'Bulkload',3,30,114)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2007,'Reorder Level',3,30,115)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2008,'Stock Report',3,30,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2009,'All Schedules',7,30,120)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2010,'In Bound Referral',8,30,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2011,'Out Bound Referral',8,30,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2012,'Summary Reports',0,30,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2013,'Manage Test Kit',2,30,144)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2014,'Manage Test Method',2,30,145)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2015,'Manage Test Principle',2,30,237)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2016,'Manage Test Instrument',2,30,143)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2017,'Lab User Wise Daily Report',20,30,35)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2018,'Lab Summary Reports',20,30,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2019,'Manage Package',2,30,252)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2020,'ChangePassword',0,30,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2021,'Home',0,30,293) -- Cashier Home Page
INSERT INTO MenuMaster VALUES(2022,'Help Video',null,null,null,null,21,30,341)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2028,'Surgery Package',2,30,298)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2029,'Manage RateType',2,30,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2030,'ManageSequence No',2,30,269)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2031,'Cash Payment',0,30,67)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2032,'ReceiptSearch',0,30,297)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2033,'TPASearch',1,30,268)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2034,'Voucher Search',0,30,342)


delete  from RoleMenu where RoleID in(159,160,161,162,163,164,165,166,167,168,169,170,171)
--Admin

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1966,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1965,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1967,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1968,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1973,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1995,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1976,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1975,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1981,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1982,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1983,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1984,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1988,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1989,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1990,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1991,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1979,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1992,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2013,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2014,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2015,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2016,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2019,164)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1985,164)
insert into RoleMenu (MenuID ,RoleID)values(2028,164)
insert into RoleMenu (MenuID ,RoleID)values(2029,164)
insert into RoleMenu (MenuID ,RoleID)values(2030,164)
insert into RoleMenu (MenuID ,RoleID)values(2031,164)
insert into RoleMenu (MenuID ,RoleID)values(2032,164)
insert into RoleMenu (MenuID ,RoleID)values(2033,164)
insert into RoleMenu (MenuID ,RoleID)values(1993,164)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1817,151)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1818,151)
---Reception							 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1975,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1977,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1986,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1964,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1958,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1974,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1980,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1961,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1973,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1978,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1991,163)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1992,163)
insert into RoleMenu (MenuID ,RoleID)values(2034,163)
insert into RoleMenu (MenuID ,RoleID)values(2033,163)
insert into RoleMenu (MenuID ,RoleID)values(2032,163)
insert into RoleMenu (MenuID ,RoleID)values(1971,163)



--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1959,163)
												
---Physician									
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1963,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1971,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1968,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1974,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1980,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1973,159)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1978,159)
												
--Lab											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1969,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1971,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1985,161)
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1982,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1988,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1983,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2013,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2014,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2015,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2016,161)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2019,161)
												
												
--Nurse											
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,160)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1962,160)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1959,160)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1974,160)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1978,160)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1992,160)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1959,160)
												
--Dial											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1972,165)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,165)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1985,165)
---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1976,168)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2020,168)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1966,168)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1986,168)
insert into RoleMenu (MenuID,RoleID)values(1992,168)

Insert into RoleMenu (MenuID,RoleID)   values(1975,168)
Insert into RoleMenu (MenuID,RoleID)   values(1990,168)


--video---
 insert into RoleMenu values(2026,159,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,160,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,161,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,162,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,163,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,164,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,165,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,166,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,167,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,168,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,169,NULL,NULL,NULL,NULL,NULL)
 insert into RoleMenu values(2026,170,NULL,NULL,NULL,NULL,NULL)


--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1974, 148)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2021, 1616)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2020, 1616)
																		 
/* PageMapping  */
delete from PageMapping where RoleId in(159,160,161,163,164,165,167,170,171)
Insert into PageMapping(RoleId,PageID,SeqNo) values(159,9,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(160,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(161,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(163,1,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(164,14,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(165,27,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(167,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(170,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(168,43,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(169,112,  1)
INSERT INTO PageMapping (RoleId, PageID, SeqNo) VALUES (171, 293, 1)
/* OrgUOMVitalsMapping  */

--OrgUOMVitalsID--identity--
delete from OrgUOMVitalsMapping where OrgID = 30
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(130,30,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(131,30,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(132,30,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(133,30,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(134,30,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(135,30,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(136,30,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(137,30,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(138,30,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(139,30,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(140,30,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(141,30,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(142,30,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(143,30,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(144,30,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(145,30,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(146,30,12,17)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(147,30,53,18)
																			  
																			  
/* ProcedureMaster  */														 
----ProcedureID--identity
delete from ProcedureMaster where OrgID =30
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(18,  'Dialysis','Treatment','Dialysis',30,  'y',1, 'Sep  2 2009 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(19,  'Physiotherapy','Treatment','Physiotherapy',30,  'y',1, 'Feb  27 2010 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(20,  'Others','Treatment','Others',30,  'y',1, 'Feb  27 2010 12:00AM')

/*  OrganizationAddress  */

/* StandardDeduction  */
delete from StandardDeduction where OrgID=30
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(111,30,  'Self Employee', 2,'P')
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(112,30,  'Govt Employee', 100,'V')

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)
DELETE FROM ProcedureFee WHERE ProcedureID IN(18,19,20)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,80,'Short wave Diathermy',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,80,'Ultrasound (9US)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,80,'Cervical Traction (ICT)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,80,'Pelvic Traction (IPT)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,120,'Muscle Stimulation (ES)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,80,'Wax Bath (9WB)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,120,'Comt Pass Mov (CPM)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,100,'Interferential Therapy (9IFT)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,70,'Mobilisation Exercise (Ex)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,70,'Cervical / dumber Exercise',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,70,'Shoulder/knee Exercise',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,70,'Finger Foat Exercise',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,50,'Infra Red Radiation (Irr)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,150,'Combination Therapy (SWD+ICT)(IPT+IFT)',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(19,150,'Manipulation & Mobilisation',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(20,0,'Others',  'Y', 2100, 30)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(18,600,'Dialysis',  'Y', 2100, 30)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =30
---speciality mapping---
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,3,  0,9) 

----procedure Task Mapping
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,7,  19,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,7,  18,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,7,  20,6)
------
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1, 13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  15,11) 
Insert into TaskActionMapping (OrgID,VisitPurposeID,OtherID,TaskActionID) VALUES (30,4,0, 38)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,7,  5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,1,  16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,11,  0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(30,9,  0,36) 

/*  Config  */
delete from Config where OrgID=30
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','After',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','N',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','After',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,30)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,30)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,30)
INSERT INTO Config (ConfigKey, ConfigValue,ParentID,OrgID) VALUES ('NeedIPNumber', 'N', 0, 30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('IPMakePayment','Y',0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('DisplayCurrencyFormat','Rupees',0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('NO','YES',0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('PrintReceipt','YES',0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('ShowDisclaimer','NO',0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('HEALTHPKG','After',0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('ScheduleDuration',7,0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('ScheduleDuration',7,0,30)
insert into Config (ConfigKey,ConfigValue,ParentID,OrgID )values ('ShowUnbilled','N',0,30)
GO

/*  BillSearchActions  */
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Print Bill',163,28)
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Refund / Cancel',164,47)
INSERT INTO BillSearchActions (ActionName ,RoleID,PageID )VALUES('Print Bill',170,28)
INSERT INTO BillSearchActions (ActionName, RoleID, PageID) VALUES ('Print Bill', 168, 28)
INSERT INTO BillSearchActions (ActionName, RoleID, PageID) VALUES ('Refund', 168, 47)
INSERT INTO BillSearchActions (ActionName, RoleID, PageID) VALUES ('Cancel Bill', 168, 47)
GO

delete from OrganizationSpeciality where OrgID =30
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,1,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,2,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,3,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,4,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,5,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,6,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,7,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,8,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,9,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,10,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,11,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,12,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,13,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,14,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,15,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,16,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,17,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,18,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,19,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,20,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,22,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,23,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,24,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,25,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,26,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,27,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,28,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,29,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,30,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,31,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,32,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,33,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,35,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,36,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,37,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,38,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(30,39,  0)


/*  TaskEscalation  */
delete from TaskEscalation where OrgID =30

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,163,30,30)

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,163,30,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,163,30,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID =30
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,160,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,160,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,160,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,165,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,165,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,165,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,161,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,159,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,159,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,161,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,161,  30)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,167,  30)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,167,  30)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,163,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,160,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,159,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,163,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,160,  30)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,163,  30)
INSERT INTO TaskActionOrgMapping (TaskActionID, RoleID, OrgID) VALUES (38, 159, 30)

/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=30
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,30)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,30)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,30)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,30)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,30)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,30)
INSERT INTO VisitPurposeOrgMapping (VisitPurposeID, OrgID) VALUES(4, 30)




/*	invdeptmaster	*/
DELETE FROM InvDeptMaster where OrgID=30
INSERT INTO invdeptmaster(Deptid,deptname,orgid)  VALUES(232,'Lab',30)
INSERT INTO InvDeptMaster(DeptID,DeptName,OrgID) VALUES (233,'Pharmacy',30)
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (234,'BioChemistry',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (235,'Clinical Pathology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (236,'Hematology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (237,'HistoPathology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (238,'MicroBiology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (239,'Imaging',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (240,'X-Ray',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (241,'CT',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (242,'MRI',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (243,'USG',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (244,'ECG',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (245,'Endoscopy',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (246,'Immunology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (247,'Cytogenetics',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (248,'Cytology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (249,'Biochemistry and ClinicalPathology',30,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (250,'Biochemistry, Clinical Pathology and Microbiology',30,'Y')


/*	RoleDeptMap	*/
DELETE FROM RoleDeptMap where RoleID IN (161,167)
Insert into RoleDeptMap(RoleID,DeptID)  values(161,232)
Insert into RoleDeptMap(RoleID,DeptID)  values(167,234)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,234)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,235)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,236)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,237)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,238)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,239)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (167,240)







/* InvestigationOrgSampleStatus	*/

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (30, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (30, 'SampleReceived', 2)





/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=30
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN,RateTypeId,RateId)VALUES(2100,30,'GENERAL',1,NULL,'Y',1,2100)
Delete from  RateMaster where OrgID=30
insert into RateMaster(RateId,RateName,RateTypeId,Discount,Status,orgid)values(2100,'GENERAL',1,0.00,'Y',30)


DELETE FROM ReportOrgMapping WHERE OrgID = 30

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,164,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,164,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,164,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,163,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,164,30)

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,168,30)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,168,30)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,164,30)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,164,30)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,164,30)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,164,30)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,164,30)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,164,30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(21, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(22, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(23, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(24, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(25, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(31, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(32, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(33, 164,  30)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(34, 164,  30)

GO

DELETE FROM CashExpenseMaster WHERE OrgID =30
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',30,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',30,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',30,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',30,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',30,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',30,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',30,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 30
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,30)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,30)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,30)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 163,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 163,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 164,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 164,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 163,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 160,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 163,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 163,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 164,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 163,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 163,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 163,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 161,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 163, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 160, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 160, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 165, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 165,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 159,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 160,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 163,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 160,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 159,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 163,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 160,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 159,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 161,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 163,	2, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 163,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 164,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 163,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 159,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 160,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 163,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 163,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 160,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 163,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 159,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 160,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 163,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 163,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 163,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 163,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 160,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 163,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 161,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 159,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 160,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 163,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 163,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 163,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 164,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 159,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 163,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 161,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 161,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 163,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 163,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 164,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 164,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 164,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 164,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 164,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 164,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 164,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 169,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 169,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 169,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 169,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 169,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 163,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 159,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 163, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 161, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 163, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 160,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 163,	161,10)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 165, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 165,	23,11)

--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 163, 161, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,159,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,159,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,163,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,163,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,163,6,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,160,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,170,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,170,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,170,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,170,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,170,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,170,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,170,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,170,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,170,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,170,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,170,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,170,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,170,28,11)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,170,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,170,28,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (64,163,255,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (66,163,255,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 164,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 163,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 164,	279,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 163,	279,	12)
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)values(26,168,52,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75, 164,	56,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 160, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 161, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 163,	297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 170,	297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73, 163,	280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74, 163,	281,13)


GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =30

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,30, 30)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,30, 30)
INSERT INTO PageActionMapping (PageActionID,OwnerOrgID,SharedOrgID) VALUES (64,30,30)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =30
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',30)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',30)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',30)
GO

DELETE FROM InvKitMaster WHERE OrgID =30
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' , 30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',30)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',30)
GO

DELETE FROM InvestigationMethod WHERE OrgID =30
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',30)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',30)

GO

DELETE FROM InvResultTemplate WHERE OrgID =30

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',30)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',30)
INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 30)
INSERT INTO InvResultTemplate(ResultID,ResultName,ResultTemplateType,ResultValues,OrgID)VALUES (44,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.',30)

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =30
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',30)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',30)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',30)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',30)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =30
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',30)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',30)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',30)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',30)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',30)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(30,30,1)

insert into RoleDeptMap (RoleID ,DeptID )values(161,233)
insert into RoleDeptMap (RoleID ,DeptID )values(161,234)
insert into RoleDeptMap (RoleID ,DeptID )values(161,235)
insert into RoleDeptMap (RoleID ,DeptID )values(161,236)
insert into RoleDeptMap (RoleID ,DeptID )values(161,237)
insert into RoleDeptMap (RoleID ,DeptID )values(161,238)
insert into RoleDeptMap (RoleID ,DeptID )values(161,239)
insert into RoleDeptMap (RoleID ,DeptID )values(161,240)
insert into RoleDeptMap (RoleID ,DeptID )values(161,241)
insert into RoleDeptMap (RoleID ,DeptID )values(161,242)
insert into RoleDeptMap (RoleID ,DeptID )values(161,243)
insert into RoleDeptMap (RoleID ,DeptID )values(161,244)
insert into RoleDeptMap (RoleID ,DeptID )values(161,245)
insert into RoleDeptMap (RoleID ,DeptID )values(161,246)
insert into RoleDeptMap (RoleID ,DeptID )values(161,247)
insert into RoleDeptMap (RoleID ,DeptID )values(161,248)
insert into RoleDeptMap (RoleID ,DeptID )values(161,249)
insert into RoleDeptMap (RoleID ,DeptID )values(161,250)



insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(36,'Medical Management',30)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(37,'Surgery',30)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(38,'Emergency Care',30)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(39,'Intervention',30)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(40,'Medical Evaluation',30)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',30)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',30)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',30)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',30)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',30)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',30)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',30)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',30)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',30)

Delete From IPPaymentsRoleMapping Where Roleid IN (160,170,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,160)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,160)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,160)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,160)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,160)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,163)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,163)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,170)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,170)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,170)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,170)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,170)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,160)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,163)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,168)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,168)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,168)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,168)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,168)
INSERT INTO IPPaymentsRoleMapping  VALUES(11,163)



GO


DELETE FROM SurgeryType WHERE OrgID = 30
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',30)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',30)
GO

/* OperationType */
DELETE FROM OperationType WHERE OrgID = 30
insert into OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',30)
insert into OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',30)
GO

delete  from InvStatusmapping where OrgID =30
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,30,3)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,30,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,30,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,30,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,30,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,30,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,30,2)
GO

DELETE FROM FeeTypeConfig WHERE OrgID = 30
INSERT INTO FeeTypeConfig (Feetype, UseEdit, OrgID) VALUES ('CON', 'Y', 30)
GO
delete CasualtyCharges where OrgID =30
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (40, 'C18',  'POP', 'CAS', 0.00, 30)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (41, 'C19',  'Dressing - Small', 'CAS', 30.00, 30)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (42, 'C20',  'Dressing - Medium', 'CAS', 50.00, 30)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (43, 'C21',  'Dressing - Large', 'CAS', 100.00, 30)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (44, 'C22',  'Injection ', 'CAS', 20.00, 30)





DELETE FROM FloorMaster WHERE OrgAddID=30
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID,OrgID) VALUES(12,'1ST FLOOR',30,30)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID,OrgID) VALUES(13,'Ground Floor',30,30)

DELETE FROM RoomType WHERE OrgAddID=30
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('SINGLE NON A/C',30,30)--22
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('A/C SINGLE ROOM',30,30)--23
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('General Ward',30,30)--24
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('ICU',30,30)--25
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('CCU',30,30)--26


DELETE FROM RoomMaster WHERE  FloorID in(12,13)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(120,'101',12,22)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(121,'102',12,22)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(122,'103',12,22)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(123,'104',12,22)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(124,'106',12,22)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(125,'105',12,23)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(126,'107',12,23)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(127,'109',12,23)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(128,'111',12,23)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(129,'112',12,22)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(130,'113',12,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(131,'114',12,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(132,'115',12,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(133,'118',12,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(134,'119',12,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(135,'121',12,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(136,'ICU',13,25)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(137,'CCU',13,26)



DELETE FROM BedMaster WHERE RoomID between 120 and 137
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(151,'BED1',120)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(152,'BED1',121)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(153,'BED1',122)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(154,'BED1',123)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(155,'BED1',124)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(156,'BED1',125)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(157,'BED1',126)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(158,'BED1',127)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(159,'BED1',128)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(160,'BED1',129)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(161,'BED1',130)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(162,'BED2',130)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(163,'BED3',130)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(164,'BED1',131)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(165,'BED2',131)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(166,'BED3',131)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(167,'BED1',132)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(168,'BED2',132)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(169,'BED3',132)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(170,'BED4',132)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(171,'BED5',132)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(172,'BED6',132)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(173,'BED1',133)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(174,'BED2',133)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(175,'BED3',133)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(176,'BED4',133)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(177,'BED5',133)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(178,'BED6',133)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(179,'BED1',134)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(180,'BED2',134)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(181,'BED3',134)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(182,'BED4',134)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(183,'BED5',134)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(184,'BED6',134)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(185,'BED1',135)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(186,'BED1',135)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(187,'BED1',135)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(189,'BED1',136)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(190,'BED2',136)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(191,'BED3',136)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(192,'BED4',136)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(193,'BED5',136)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(194,'BED6',136)


INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(195,'BED1',137)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(196,'BED2',137)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(197,'BED3',137)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(198,'BED4',137)


                     
                          
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(22,1,400,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(22,6,200,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(22,5,300,'N','N')
  
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(23,1,650,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(23,6,200,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(23,5,300,'N','N')
  
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(24,1,300,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(24,6,100,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(24,5,200,'N','N')
  
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(24,1,300,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(24,6,100,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(24,5,200,'N','N')
  
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(25,1,750,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(25,6,200,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(25,5,200,'N','N')
  
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(25,1,750,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(25,6,200,'N','N')
  insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(25,5,400,'N','N')

  


insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(1,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(2,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(3,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(4,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(5,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(6,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(7,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(8,30,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(9,30,0.00)

insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,1,30)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,2,30)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(4,6,30)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,7,30)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 30

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 30, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 30, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 30, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 30, 'IP')
GO