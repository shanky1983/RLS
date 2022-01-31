/* Login  */
delete From Login where OrgID =26
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(336,'Sowmya336','Sowmya','N',26,  'A')
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(339,'wards','wards','N',26,  'A')



/* Organization */
delete From Organization where OrgID =26
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)   values(26,'Rakshith Hospital',1,  0,'')

/* Users */
delete From Users where OrgID =26
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('wards','F','2',   26,339)



/* Nurse  */

/* Role */
delete From Role where OrgID =26
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(134,'Physician','Doctor',  0,26)--123
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(135,'Nurse','Nurse',  0,26)--124
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(136,'LabTech','Lab Technician',  0,26)--125
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(137,'Patient','Patient',  0,26)--126
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(138,'Reception','Reception',  0,26)--127
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(139,'Admin','Admin',  0,26)--128
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(140,'DialysisTech','Dialysis Technician',  0,26)--129
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(141,'Billing','Billing',  0,26)--130
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(142,'Xray','Xray',  0,26)--131
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(143,'Accounts','Accounts',  0,26)--132
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(144,'Pharmacist','Pharmacist',  0,26)--133
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(145,'Wardsecretary','Wardsecretary',  0,26)--133



/* LoginRole  */


Insert Into LoginRole(RoleID,LoginID)values(139,336)
Insert Into LoginRole(RoleID,LoginID)values(145,339)



/* Role Menu */
--delete  from RoleMenu where RoleID in(134,135,136,137,138,139,140,141,142,143,144)
--INSERT INTO RoleMenu (MenuID,RoleID) values(512,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(508,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(507,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(509,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(510,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(516,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(529,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(519,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(518,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(524,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(525,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(526,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(527,139)
--INSERT INTO RoleMenu (MenuID,RoleID) values(510,139)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(531,139)
--INSERT INTO RoleMenu (MenuID,RoleID)   values(532,139)
--INSERT INTO RoleMenu (MenuID,RoleID)   values(533,139)
--INSERT INTO RoleMenu (MenuID,RoleID) VALUES(518,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(520,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(529,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(512,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(506,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(524,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(500,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(517,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(523,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(503,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(516,138)
--INSERT INTO RoleMenu (MenuID,RoleID) values(510,138)
--INSERT INTO RoleMenu (MenuID,RoleID) VALUES(518,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(512,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(505,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(514,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(502,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(517,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(523,134)
--INSERT INTO RoleMenu (MenuID,RoleID) values(516,134)
--INSERT INTO RoleMenu (MenuID,RoleID) VALUES(512,136)
--INSERT INTO RoleMenu (MenuID,RoleID) values(511,136)
--INSERT INTO RoleMenu (MenuID,RoleID) values(514,136)
--INSERT INTO RoleMenu (MenuID,RoleID) values(528,136)
------
--INSERT INTO RoleMenu (MenuID,RoleID) VALUES(512,135)
--INSERT INTO RoleMenu (MenuID,RoleID) values(504,135)
--INSERT INTO RoleMenu (MenuID,RoleID) values(501,135)
--INSERT INTO RoleMenu (MenuID,RoleID) values(517,135)
--insert into RoleMenu(MenuID,RoleID ) values(522,138)
--insert into RoleMenu(MenuID,RoleID ) values(522,139)
--insert into RoleMenu(MenuID,RoleID ) values(522,135)

delete  from RoleMenu where RoleID in(134,135,136,137,138,139,140,141,142,143,144,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(512,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(508,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(507,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(509,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(510,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(516,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(529,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(519,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(518,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(524,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(525,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(526,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(527,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(531,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(532,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(533,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(518,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(520,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(529,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(512,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(506,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(500,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(517,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(523,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(503,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(516,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(518,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(512,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(505,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(514,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(500,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(517,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(523,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(516,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(512,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(511,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(514,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(528,136)

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(557,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(558,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(559,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(560,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(525,136)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(526,136)
-----------
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(512,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(504,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(501,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(517,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(521,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(534,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(535,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(521,134)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(534,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(521,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(535,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(522,138)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(522,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(522,135)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(535,139)

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(557,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(558,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(559,139)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(560,139)

-------
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(512,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(504,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(501,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(517,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(521,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(535,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(522,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(518,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(523,145)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(514,145)

---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(529,143)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(519,143)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(508,143)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(521,139)

INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1885, 139)

--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(516,138)








/* MENU MASTer  */
DELETE FROM MenuMaster where OrgId=26
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(500,'Patient Search',0,26,10)--317--r
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(501,'Patient Search',0,26,11)--n
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(502,'Patient Search',0,26,12)---phy
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(503,'Patient Registration',0,26,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(504,'Home',0,26,8)--N
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(505,'Home',0,26,9)--p
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(506,'Home',0,26,1)--R
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(507,'Home',0,26,14)--ad
--INSERT INTo MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(325,'Reports',0,26,15)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(508,'Reports',0,26,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(509,'Set Reminders',0,26,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(510,'Doctor Schedule',7,26,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(511,'Home',0,26,13)--lab

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(512,'Change Password',0,26,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(513,'Home',0,26,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(514,'Investigation Report',0,26,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(515,'Home',0,26,27)---332--dial


INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(516,'View Schedules',7,26,37)--346
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(517,'Today''s OP Visits',0,26,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(518,'BillSearch',0,26,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(519,'Cash Closure',0,26,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(520,'Cash Closure',0,26,48)--354


INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(521,'Patient Management',1,26,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(522,'View Room Details',1,26,54)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(523,'Visit Search',0,26,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(524,'Manage Rates',2,26,59)

--INSERT INTo MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(363,'Purchase Order',3,26,62)
--INSERT INTo MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(364,'Receive Stock',3,26,63)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(525,'Add Investigation/Groups',2,26,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(526,'Reference Range Mgmt',2,26,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(527,'Manage User',2,26,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(528,'Patient Search',0,26,10)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(529,'Cash OutFlow',0,26,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(530,'Check Safety Code',0,26,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES (531,'Add Corporate & Client',2,26,72)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(532,'Task ReAssign',0,26,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(533,'Dashboard',0,26,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(534,'Settlement',1,26,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(535,'Billing',1,26,79)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(536,'Plan Vacation',7,26,83)
 
 
 
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(537,'Purchase Order',3,26,93)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(538,'Stock Receive',3,26,94)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(539,'Stock Return',3,26,95)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(540,'Stock Damage',3,26,96)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(541,'Inventory Search',3,26,97)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(542,'Categories',3,26,102)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(543,'Products',3,26,103)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(544,'Suppliers',3,26,104)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(545,'Stock Issued',3,26,116)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(546,'Stock In Hand',3,26,107)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(547,'OP Billing',0,26,108)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(548,'IP Billing',0,26,113)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(549,'Bulkload',3,26,114)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(550,'Reorder Level',3,26,115)

Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(551,'Stock Report',3,26,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(552,'All Schedules',7,26,120)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(553,'In Bound Referral',8,26,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(554,'Out Bound Referral',8,26,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(555,'Summary Reports',0,26,36)
INSERT INTO MenuMaster (MenuID,DisplayText,Parentid,OrgId,PageID) values(556,'Stock Details',3,	12,	236)


Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(557,'Manage Test Kit',2,26,144)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(558,'Manage Test Method',2,26,145)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(559,'Manage Test Principle',2,26,237)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(560,'Manage Test Instrument',2,26,143)


/* PageMapping  */
delete from PageMapping where RoleId IN(134,135,136,138,139,140,142)
Insert into PageMapping(RoleId,PageID,SeqNo) values(134,9,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(135,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(136,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(138,1,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(139,14,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(140,27,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(142,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(145,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(143,188,  1)



/* OrgUOMVitalsMapping  */

delete from OrgUOMVitalsMapping where OrgID = 26
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(52,26,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(53,26,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(54,26,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(55,26,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(56,26,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(57,26,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(58,26,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(59,26,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(60,26,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(61,26,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(62,26,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(63,26,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(64,26,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(65,26,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(66,26,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(67,26,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(68,26,12,17)

Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(69,26,53,18)

/* ProcedureMaster  */
delete from ProcedureMaster where OrgID =26
--Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(12,  'Dialysis','Treatment','Dialysis',26,  'y',1, 'Feb  27 2010 12:00AM')

Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(13,  'Physiotherapy','Treatment','Physiotherapy',26,  'y',1, 'Feb  27 2010 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(14,  'Others','Treatment','Others',26,  'y',1, 'Feb  27 2010 12:00AM')

/*  OrganizationAddress  */
delete from OrganizationAddress where OrgID = 26
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) Values(25,26,'A','153 Arcot Road, Sai square complex','','','600087',0,'Chennai',0,'','044 42749916','','Valasaravakkam')

/* StandardDeduction  */
delete from StandardDeduction where OrgID=26
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(107,26,  'Self Employee', 2,'P')
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(108,26,  'Govt Employee', 100,'V')

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)

Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,50,'EXERCISE THERAPY',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,50,'HYDROCOLLATERAL BATH(HOT PACK)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'WAX BATH',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'INTERFERENTIAL THERAPY(IFT)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'ULTRASOUND THERAPY(UST)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'TENS(TRANSCUTANEOUS STIMULATOR)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'ELECTRICAL STIMULATOR(ES)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'IPT(TRACTION)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'ICT(TRACTION)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,120,'BEDSIDE TRACTION(PER DAY)',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,80,'SHORT WAVE DIATHERMY',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,150,'CPM',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,150,'TILTING TABLE',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(13,250,'LASER THERAPY',  'Y', 1701, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(14,0,'Others',  'Y', 1701, 26)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =26
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  2,11)
--delete from TaskActionMapping where OrgID = 26 and OtherID = 4 and TaskActionID = 6 and VisitPurposeID = 7
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,7,  13,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,3,  0,9) 

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1, 13,11)

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  15,11) 
INSERT INTO TaskActionMapping (OrgID, VisitPurposeID, OtherID, TaskActionID) VALUES (26, 4, 0, 38)
GO
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,7,  5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,1,  16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,11,  0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,9,  0,36) 
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(26,6,  0,36)
INSERT INTO TaskActionMapping (OrgID, VisitPurposeID, OtherID, TaskActionID) values (26, 1, 12, 11)
/*  Config  */
delete from Config where OrgID=26
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','Before',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','N',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','After',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,26)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CAS','Before',  0, 26)
INSERT INTO Config (ConfigKey, ConfigValue, ParentID, OrgID) VALUES ('NeedIPNumber', 'Y', 0, 26)
INSERT INTO Config (ConfigKey, ConfigValue, ParentID, OrgID) VALUES ('IPMakePayment', 'N', 0, 26)

INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES('BillPrintLogo','',0,26)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES('ShowUnbilled','Y',0,26)
INSERT INTO Config(ConfigKey,ConfigValue,OrgID,ParentID)  VALUES('EditableUser',145,26,0)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES('DisplayCurrencyFormat','Rupees',0,26)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES('ShowDisclaimer','NO',0,26)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES('ScheduleDuration',7,0,26)

GO

/*  BillSearchActions  */
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Print Bill',138,28)
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Refund / Cancel',139,47)
INSERT INTO BillSearchActions (ActionName ,RoleID,PageID )VALUES('Print Bill',145,28)

GO

delete from OrganizationSpeciality where OrgID =26
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,1,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,2,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,3,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,4,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,5,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,6,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,7,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,8,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,9,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,10,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,11,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,12,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,13,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,14,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,15,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,16,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,17,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,18,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,19,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,20,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,22,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,23,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,24,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,25,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,26,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,27,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,28,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,29,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,30,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,31,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,32,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,33,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,35,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,36,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,37,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,38,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(26,39,  0)
INSERT INTO OrganizationSpeciality(OrgID, SpecialityID, Amount) values (26, 40, 0)
INSERT INTO OrganizationSpeciality(OrgID, SpecialityID, Amount) values (26, 21, 0)
/*  TaskEscalation  */
delete from TaskEscalation where OrgID =26
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,139,26,30)

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,139,26,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,139,26,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID =26
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,135,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,135,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,135,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,130,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,130,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,130,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,136,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,134,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,134,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,136,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,136,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,131,  26)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,142,  26)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,138,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,135,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,134,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,138,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,135,  26)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,138,  26)
INSERT INTO TaskActionOrgMapping (TaskActionID, RoleID, OrgID) VALUES (38, 134, 26)
INSERT INTO TaskActionOrgMapping (TaskActionID, RoleID, OrgID) VALUES (40, 139, 26)

/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=26
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,26)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,26)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,26)

Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,26)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,26)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,26)
INSERT INTO VisitPurposeOrgMapping (VisitPurposeID, OrgID) VALUES (4, 26)
INSERT INTO VisitPurposeOrgMapping (VisitPurposeID, OrgID) VALUES (6, 26)



/*	invdeptmaster	*/
DELETE FROM InvDeptMaster where OrgID=26
INSERT INTO invdeptmaster(Deptid,deptname,orgid)  VALUES(190,'Lab',26)
INSERT INTO InvDeptMaster(DeptID,DeptName,OrgID) VALUES (191,'Pharmacy',26)
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (192,'BioChemistry',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (193,'Clinical Pathology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (194,'Hematology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (195,'HistoPathology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (196,'MicroBiology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (197,'Imaging',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (198,'X-Ray',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (199,'CT',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (200,'MRI',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (201,'USG',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (202,'ECG',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (203,'Endoscopy',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (204,'Immunology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (205,'Cytogenetics',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (206,'Cytology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (207,'Biochemistry and ClinicalPathology',26,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (208,'Biochemistry, Clinical Pathology and Microbiology',26,'Y')


/*	RoleDeptMap	*/
DELETE FROM RoleDeptMap where RoleID IN (136,142)
Insert into RoleDeptMap(RoleID,DeptID)  values(136,190)
Insert into RoleDeptMap(RoleID,DeptID)  values(142,192)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,192)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,193)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,194)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,195)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,196)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,197)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (142,198)







/* InvestigationOrgSampleStatus	*/

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (26, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (26, 'SampleReceived', 2)

/*	Prasanna Added	Ends	*/


/*    InvGroupMaster   */
delete from InvGroupMaster where OrgID =26

/*		InvGroupMapMaster		*/

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1701,3018)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1701,3019)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3032)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3033)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3034)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3040)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3041)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3037)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3038)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3042)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,3039)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1702,4846)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1703,3003)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1703,3004)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1703,3005)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1703,3006)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2002)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2014)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2015)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2003)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2013)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,4053)	--LNH	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1708,2005)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1708,2006)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1708,2007)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1708,2008)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1708,2009)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1708,2010)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2032)	--LNH	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2033)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2034)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1705,2035)	--LNH
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1706,2043)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1706,2045)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1706,2047)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1706,2054)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1706,2053)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1706,2051)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1707,3046)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1707,3048)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1707,3049)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1707,3050)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1707,3051)	--LNH
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(609,3079)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(609,3083)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1709,3084)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(609,3081)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1709,3080)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1709,3082)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1710,3053)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1710,3054)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1710,3055)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1710,3056)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1710,3057)	--LNH
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1712,4084)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1712,4085)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1713,4013)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1713,4127)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,4010)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,4011)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,4014)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,4016)	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,3128)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5029)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5030)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5031)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5032)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5033)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5034)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5035)		
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,5036)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,3130)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1719,3131)
	

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1721,5021)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1721,5022)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1721,5023)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1721,5024)	--LNH

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2018)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2019)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2024)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2025)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2026)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2028)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2029)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1728,2030)

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4127)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4129)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4091)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4089)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4084)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4085)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4828)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4829)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4221)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4222)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1711,4223)	--LNH

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,4007)	--LNH
	
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,4118)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,4119)	--LNH
	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(620,4120)	--LNH
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,4104)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,4105)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,4106)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,4107)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,5040)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,5041)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,5042)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1720,5043)	--LNH	

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1729,4872)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1729,4873)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1729,4874)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1729,4875)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1729,4876)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1729,5045)	--LNH

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1730,5021)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1730,5022)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1730,5023)	--LNH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1730,5024)	--LNH
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1731,4878)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1732,5024)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1733,4988)	--KMH

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,5025)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,5026)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,5027)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1715,5028)	
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4003)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4005)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4004)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4014)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4016)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4018)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4019)
		
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4007)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4010)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,4011)
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,5025)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,5026)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,5027)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,5028)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1734,5044)

	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1735,5021)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1735,5022)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1735,5023)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1735,5024)	--KMH
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1736,5021)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1736,5022)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1736,5023)	--KMH
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1736,5024)	--KMH	
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,3128)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5029)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5030)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5031)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5032)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5033)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5034)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5035)		
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,5036)
	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3129)
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,3130)
	
	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,3131)	

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1787,4946)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1787,4944)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1787,4943)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1787,4945)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1787,4769)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1789,4770)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1790,4828)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1790,4829)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1791,2043)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1791,2045)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1792,4873)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1792,4151)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1792,4877) -----------------

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1793,4891)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1793,4892)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1794,5085)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1794,4298)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1795,5059)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1795,5060)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1796,4222)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1796,4223)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1797,5186)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1797,4725)

INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,3131)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,3131)
INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1737,3131)	
	
GO

/*	ComplaintGroupOrgMapping	*/

delete from ComplaintGroupOrgMapping where OrgID = 26
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (1, 1701, 26)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (2, 1702, 26)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (3, 1703, 26)	--LNH
--INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (4, 604, 26)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (5, 1705, 26)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (6, 1706, 26)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (7, 1707, 26)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (8, 1708, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (9, 1709, 26)	
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (10, 1710, 26)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (11, 1711, 26)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (12, 1712, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (13, 1713, 26)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (15, 1715, 26)	--LNH
--INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (16, 616, 26)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (19, 1719, 26)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (20, 1720, 26)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (21, 1721, 26)
--INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (26, 626, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (28, 1728, 26)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (29, 1729, 26)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (30, 1730, 26)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (31, 1731, 26)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (32, 1732, 26)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (33, 1733, 26)	--KMH
	
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (34, 1734, 26)	--LNH
	
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (35, 1735, 26)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (36, 1736, 26)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (37, 1737, 26)	--LNH

INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (46, 1787, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (47, 1788, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (48, 1789, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (49, 1790, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (50, 1791, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (51, 1792, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (52, 1793, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (53, 1794, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (54, 1795, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (55, 1796, 26)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (56, 1797, 26)



GO



/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=26
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN)VALUES(1701,26,'GENERAL',1,NULL,'Y')

GO

/*		InvOrgGroup		*/
DELETE FROM InvOrgGroup where OrgID =26
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (2, 1702, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (3, 1703, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (5, 1705, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (7, 1707, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (10, 1710, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (11, 1711, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (15, 1715, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (19, 1719, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (20, 1720, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (29, 1729, 26)

INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (1,  1701, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (21, 1721, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (6, 1706, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (8, 1708, 26)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (26, 626, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (28,1728, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (12, 1712, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (9,  1709, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (13, 1713, 26)

INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (30, 1730, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (31, 1731, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (32, 1732, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (33, 1733, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (34, 1734, 26)

INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (35, 1735, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (36, 1736, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (37, 1737, 26)

INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (87, 1787, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (88, 1788, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (89, 1789, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (90, 1790, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (91, 1791, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (92, 1792, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (93, 1793, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (94, 1794, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (95, 1795, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (96, 1796, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (97, 1797, 26)
INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (98, 1798, 26)

GO

DELETE FROM ReportOrgMapping WHERE OrgID = 26

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,139,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,139,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,139,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,138,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,139,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,139,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,139,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,143,26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,143,26)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,139,26)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,139,26)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,139,26)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,139,26)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,139,26)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,139,26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(21, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(22, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(23, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(24, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(25, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(31, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(31, 1615, 26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(32, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(32, 1615, 26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(33, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(33, 1615, 26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(34, 139,  26)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(34, 1615, 26)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(42,139,26)

GO

DELETE FROM CashExpenseMaster WHERE OrgID =26
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',26,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',26,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',26,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',26,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',26,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',26,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',26,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 26
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,26)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,26)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,26)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 138,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 138,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 139,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 139,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 138,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 135,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 138,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 138,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 139,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 138,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 138,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 138,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 136,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 138, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 135, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 135, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 140, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 140,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 134,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 135,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 138,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 135,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 134,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 138,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 135,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 134,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 136,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 138,	2, 10)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 138,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 139,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 138,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 134,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 135,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 138,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 138,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 135,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 138,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 134,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 135,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 138,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 138,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 138,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 138,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 135,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 138,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 136,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 138,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 138,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 138,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 138,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 138,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 138,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 134,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 135,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 138,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 138,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 138,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 138,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 138,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 138,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 138,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 139,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 134,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 138,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 136,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 136,	55,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 138,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 138,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 139,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 139,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 139,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 139,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 139,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 139,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 139,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 144,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 144,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 144,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 144,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 144,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 138,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 134,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 138, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 136, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 138, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 135,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 138,	148,10)

--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 138, 148, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,134,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,134,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,138,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,138,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,138,6,19)

INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,135,58,19)

INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,145,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,145,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,145,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,145,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,145,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,145,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,145,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,145,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,145,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,145,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,145,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,145,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,145,28,11)
--INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,145,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,145,28,19)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (64, 138,	255,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (61, 138, 148, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (61, 138, 148, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (61, 138, 148, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (66, 138,	255,	12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 138,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 138,	55,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 138,	118,13)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 145,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 145,	55,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 145,	118,13)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 139,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 139,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 138,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 139,	279,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 138,	279,	12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73, 138,	280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74, 138,	281,13)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73, 145,	280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74, 145,	281,13)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75, 139,	56,5)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (70, 134,	270,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (70, 145,	270,12)


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (76, 145,	284,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (76, 134,	284,12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) values (72, 145, 279, 12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (77, 138,	285,13)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (78, 138, 291, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (78, 139, 291, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (78, 145, 291, 12)


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 138,	297,12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 145,	297,12)


INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) values(78,138,291,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) values(78,139,291,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) values(78,145,291,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) values(78,1615,291,13)

GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =26

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,26, 26)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,26, 26)
INSERT INTO PageActionMapping (PageActionID,OwnerOrgID,SharedOrgID) VALUES (64,26,26)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =26
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',26)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',26)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',26)
GO

DELETE FROM InvKitMaster WHERE OrgID =26
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' , 26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',26)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',26)
GO

DELETE FROM InvestigationMethod WHERE OrgID =26
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',26)

GO

DELETE FROM InvResultTemplate WHERE OrgID =26

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',26)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',26)

INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 26)
INSERT INTO InvResultTemplate(ResultID,OrgID,ResultName,ResultTemplateType,ResultValues)VALUES (44,26,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.')

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =26
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',26)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =26
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',26)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',26)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',26)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',26)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',26)
GO


INSERT INTO TrustedOrgDetails(LoggedOrgID,SharingOrgID,ShareTypeID)VALUES(26,26,1)

INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,191)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,192)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,193)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,194)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,195)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,196)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,197)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,198)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,199)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,200)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,201)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,202)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,203)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,204)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,205)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,206)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,207)
INSERT INTO RoleDeptMap (RoleID ,DeptID )VALUES(136,208)



 
DELETE FROM FloorMaster WHERE OrgAddID=26
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(3,'1ST FLOOR',26)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(4,'2ND FLOOR',26)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(5,'3RD FLOOR',26)
GO
 
DELETE FROM RoomType WHERE OrgAddID=26
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('PRIVATE A/C',26)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('PRIVATE NON A/C',26)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('ICU',26)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('NICU',26)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('GW',26)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('STEP DOWN ICU',26)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('DELUXE',26)

GO

DELETE FROM RoomMaster WHERE RoomTypeID IN (5,6,7,8,9,10)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(32,'N400',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(33,'N401',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(34,'N402',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(35,'N403',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(36,'N405',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(37,'N406',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(38,'N407',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(39,'N409',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(40,'N410',5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(41,'N306',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(42,'N307',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(43,'N308',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(44,'N309',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(45,'N310',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(46,'N311',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(47,'N312',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(48,'N313',4,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(49,'*N400',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(50,'*N401',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(51,'*N402',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(52,'*N403',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(53,'*N405',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(54,'*N407',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(55,'*N409',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(56,'*N410',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(57,'*N411',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(58,'*N412',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(59,'*N417',5,6)
																			    
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(60,'N411' ,5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(61,'N412' ,5,5)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(62,'N413' ,5,5)



INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(64,'N408',5,8)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(66,'N315',4,9)

--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(68,'N315/1',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(68,'N315/2',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(69,'N315/3',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(70,'N315/4',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(71,'N315/5',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(72,'N315/6',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(73,'N315/7',4,9)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(67,'N317',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(67,'N317/1',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(74,'N317/2',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(75,'N317/3',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(76,'N317/4',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(77,'N317/5',4,9)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(78,'N317/6',4,9)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(83,'N202',3,10)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(83,'N202/1',3,10)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(84,'N202/2',3,10)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(84,'N203',3,7)

--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(63,'N203/1',3,7)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(65,'N203/2',3,7)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(79,'N203/3',3,7)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(80,'N203/4',4,7)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(81,'N203/5',3,7)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(82,'N203/6',4,7)



INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(85,'*N413',5,6)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(86,'N417',5,5)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(87,'*N416',5,6)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(88,'*N406',5,6)
INSERT INTO RoomMaster (RoomID,RoomName,FloorID,RoomTypeID)values(89,'Male General Ward',3,9)
INSERT INTO RoomMaster (RoomID,RoomName,FloorID,RoomTypeID)values(90,'Female General Ward',3,9)

																 
 GO																

DELETE FROM BedMaster WHERE RoomID between 32 and 59

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(32,'N400',32)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(33,'N401',33)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(34,'N402',34)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(35,'N403',35)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(36,'N405',36)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(37,'N406',37)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(38,'N407',38)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(39,'N409',39)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(40,'N410',40)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(41,'N306',41)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(42,'N307',42)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(43,'N308',43)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(44,'N309',44)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(45,'N310',45)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(46,'N311',46)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(47,'N312',47)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(48,'N313',48)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(49,'*N400',49)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(50,'*N401',50)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(51,'*N402',51)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(52,'*N403',52)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(53,'*N405',53)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(54,'*N407',54)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(55,'*N409',55)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(56,'*N410',56)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(57,'*N411',57)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(58,'*N412',58)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(59,'*N417',59)
--INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(60,'',29)
--INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(61,'',30)
--INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(62,'',31)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(60,'N411',60)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(61,'N412',61)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(62,'N413',62)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(63,'N203/1',63)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(64,'N408',64)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(65,'N203/2',65)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(66,'N315/1',66)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(67,'N3171' ,67)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(68,'N315/2',68)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(69,'N315/3',69)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(70,'N315/4',70)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(71,'N315/5',71)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(72,'N315/6',72)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(73,'N315/7',73)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(74,'N317/2',74)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(75,'N317/3',75)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(76,'N317/4',76)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(77,'N317/5',77)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(78,'N317/6',78)
												
	
	
	---
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(79,'N203/3',79)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(80,'N203/4',80)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(81,'N203/5',81)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(82,'N203/6',82)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(83,'N202/1',83)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(84,'N202/2',84)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(85,'*N413',85)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(86,'N417' ,86)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(87,'*N416',87)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(88,'*N406',88)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(89,'315/1',89)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(90,'315/2',89)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(91,'315/3',89)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(92,'315/4',89)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(93,'315/5',89)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(94,'317/1',90)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(95,'317/2',90)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(96,'317/3',90)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(97,'317/4',90)
INSERT INTO BedMaster (BedID,BedName,RoomID)values(98,'317/5',90)


DELETE FROM RoomTypeFeeMapping Where RoomTypeID IN (5,6,7,8,9,10)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount) VALUES(5,1,1400)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount) VALUES(6,1,900)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount) VALUES(7,1,2000)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount) VALUES(8,1,1500)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount) VALUES(9,1,500)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount) VALUES(10,1,1250)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (9,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (9,5,75)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (9,7,0)

INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (6,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (6,5,75)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (6,7,0)

INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (5,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (5,5,75)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (5,7,0)

INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (8,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (8,5,75)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (8,7,0)

INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (7,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (7,5,300)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (7,7,0)

INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (10,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (10,5,300)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (10,7,0)

INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (11,6,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (11,5,100)
INSERT INTO RoomTypeFeeMapping (RoomTypeID,FeeID,Amount)VALUES (11,7,0)

INSERT INTO PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(21,'Medical Management',26)
INSERT INTO PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(22,'Surgery',26)
INSERT INTO PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(23,'Emergency Care',26)
INSERT INTO PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(24,'Intervention',26)
INSERT INTO PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(25,'Medical Evaluation',26)

INSERT INTO SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',26)
INSERT INTO SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',26)
INSERT INTO OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',26)
INSERT INTO OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',26)

INSERT INTO AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',26)
INSERT INTO AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',26)
INSERT INTO AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',26)
INSERT INTO AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',26)
INSERT INTO AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',26)

DELETE FROM IPPaymentsRoleMapping Where Roleid IN (135,145,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,135)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,135)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,135)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,135)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,135)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,138)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,138)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,145)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,145)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,145)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,145)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,145)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,135)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,138)

INSERT INTO IPPaymentsRoleMapping  VALUES(11,138)

GO


DELETE FROM SurgeryType WHERE OrgID = 26
INSERT INTO SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',26)
INSERT INTO SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',26)

/* OPERATIONType */
DELETE FROM OperationType WHERE OrgID = 26
INSERT INTO OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',26)
INSERT INTO OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',26)

DELETE  FROM InvStatusmapping where OrgID =26
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,26,3)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,26,2)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,26,1)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,26,2)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,26,1)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,26,1)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,26,2)
GO

DELETE FROM CasualtyCharges WHERE OrgID = 26
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (1, 'C1',  'ECG', 'CAS', 120.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (2, 'C2',  'INJECTION CHARGE', 'CAS', 20.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (3, 'C3',  'BP', 'CAS', 10.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (4, 'C4',  'PULSEOXIMETER', 'CAS', 50.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (5, 'C5',  'DIETICIAN CHARGES', 'CAS', 50.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (6, 'C6',  'CONSULTATION(CMO)', 'CAS', 50.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (7, 'C7',  'CONSULTATION(CONSULTANT)', 'CAS', 150.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (8, 'C8',  'NEBULIZER', 'CAS', 100.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (9, 'C9',  'AMBULANCE CHARGES', 'CAS', 150.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (10, 'C10',  'PROCEDURE', 'CAS', 500.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (11, 'C11',  'OXYGEN', 'CAS', 150.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (12, 'C12',  'DRESSING CHARGES(SMALL)', 'CAS', 50.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (13, 'C13',  'DRESSING CHARGES(MEDIUM)', 'CAS', 150.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (14, 'C14',  'DRESSING CHARGE(LARGE)', 'CAS', 250.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (15, 'C15',  'CTG', 'CAS', 200.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (16, 'C16',  'CBG', 'CAS', 50.00, 26)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (17, 'C17',  'OBSERVATION', 'CAS', 300.00, 26)
GO

DELETE FROM MedicalIndents WHERE OrgID=26

--INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(15,'OTHERS',NULL,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(16,'OXYGEN',300.00,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(17,'DIGIFUSA',150.00,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(18,'ALPHA BED',100.00,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(19,'NEBULISATION',100.00,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(20,'VENTILATOR',2400.00,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID) VALUES(21,'VENTILATOR OXYGEN',1200.00,26)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(22,'WHOLE BLOOD',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(23,'PACKED CELLS',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(24,'FFP',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(25,'PLASMA',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(26,'CRYOPRECIPATE',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(27,'PLATELETS',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(28,'NIBP',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(29,'MONITOR',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(30,'DRESSING (large)',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(31,'DRESSING (Medium)',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(32,'DRESSING (Small)',300.00,26, 100.00)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(33, 'ICU Ventilator', 150, 12, 150)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(34, 'Criticare Monitor', 20, 12, 20)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(35, 'L & T Monitor', 15, 12, 15)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(36, 'Pulse Oxymeter', 10, 12, 10)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(37, 'DC Shock', 150, 12, 150)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(38, 'Diginfusa', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(39, 'Tegaderm', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(40, 'Thermometer', 30, 12, 30)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(41, 'Central 02 At 2 Litre', 10, 12, 10)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(42, 'Central 02 At 4 Litre', 25, 12, 25)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(43, 'Central 02 At 6 Litre', 35, 12, 35)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(44, 'Central 02 At 8-10 Litre', 45, 12, 45)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(45, 'Water Bed', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(46, 'Alpha Bed', 120, 12, 120)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(47, 'ECG - ICU', 120, 12, 120)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(48, 'ET Intubation', 200, 12, 200)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(49, 'Nebulizer', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(50, 'Nebulizer Kit', 60, 12, 60)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(51, 'Suturing Kit', 200, 12, 200)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(52, 'Suture Removal Kit', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(53, 'Foleys Catheterisation Kit', 200, 12, 200)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(54, 'Peritoneal Dialysis Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(55, 'ICD Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(56, 'Pleural Aspiration Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(57, 'Ascitic Aspiration Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(58, 'Trachestomy Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(59, 'Bone Marrow Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(60, 'Venesection Kit (cutdown)', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(61, 'Suprapubic Catheterization Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(62, 'CVP Jugalar Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(63, 'Liver Aspiration Kit', 300, 12, 300)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(64, 'Ortho Pad 2 Pieces Set', 30, 12, 30)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(65, 'G-Pad Set 2 Pieces', 20, 12, 20)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(66, 'Extra Pad 2 Pieces', 15, 12, 15)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(67, 'Dynaplast', 30, 12, 30)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(68, 'Extra Gauze', 20, 12, 20)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(69, 'T Bandaging', 100, 12, 100)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(70, 'Pelvic Traction', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(71, 'Abdominal Binder', 100, 12, 100)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(72, 'Savlon Soakage', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(73, 'KMNO4 Soakage', 100, 12, 100)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(74, 'Condom Drainage', 100, 12, 100)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(75, 'Suppository', 30, 12, 30)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(76, 'CPAP Ventilator CIRCUIT', 1750, 12, 1750)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(77, 'Ventilator Circuit', 850, 12, 850)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(78, 'Venturi Mask', 200, 12, 200)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(79, 'Walker', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(80, 'Lumbar Puncture Kit ', 250, 12, 250)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(81, 'Gauze Pack', 15, 12, 15)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(82, 'O2', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(83, 'Crutch', 50, 12, 50)
INSERT INTO MedicalIndents (ItemID,ItemName,Rate,OrgID, IPAmount) VALUES(84, 'Tripod', 50, 12, 50)

GO

DELETE FROM PaymentTypeOrgMapping WHERE OrgID= 26
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(1,26,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(2,26,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(3,26,1.50)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(4,26,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(5,26,1.50)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(6,26,1.50)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(7,26,1.50)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(8,26,1.50)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(9,26,1.50)

GO
INSERT INTO Config (ConfigKey,ConfigValue,ParentID,OrgID) VALUES ('BillPrintControl','RakshithBillPrint.ascx',0,26)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 26

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 26, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 26, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 26, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 26, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 26, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 26, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 26, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 26, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 26, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 26, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 26, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 26, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 26, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 26, 'IP')
GO