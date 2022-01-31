/* Login  */

delete From Organization where OrgID =29
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)values(29,'Cosh Hospital',1,  0,'')

delete from OrganizationAddress where OrgID = 29
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) 
Values(28,29,'A','No 9, Duraiswamy Nagar,',', Near Madras Christian College',' IAF Road East Tambaram,','600059',0,'Chennai',0,'','044  2279 0340','','East Tambaram')

delete From Login where OrgID =29
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(1687,'Testadmin','Testadmin','N',29,  'A')

insert into IDMaster (OrgID,PatientNumber ,BillNumber ,IPNumber ,VisitNumber )values(29,0,0,0,0)



/* Organization */

/* Users */
delete From Users where OrgID =29
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('Testadmin','M','1',29,1687)



/* Nurse  */

/* Role */
delete From Role where OrgID =29
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(146,'Physician','Doctor',  0,29)--134
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(147,'Nurse','Nurse',  0,29)--135
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(148,'LabTech','Lab Technician',  0,29)--136
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(149,'Patient','Patient',  0,29)--137
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(150,'Reception','Reception',  0,29)--138
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(151,'Admin','Admin',  0,29)--139
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(152,'DialysisTech','Dialysis Technician',  0,29)--140
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(153,'Billing','Billing',  0,29)--141
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(154,'Xray','Xray',  0,29)--142
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(155,'Accounts','Accounts',  0,29)--143
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(156,'Pharmacist','Pharmacist',  0,29)--144
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(157,'Wardsecretary','Wardsecretary',  0,29)--145
INSERT INTO Role (RoleID, RoleName, Description, ParentID, OrgID) VALUES (1616, 'Cashier', 'Cashier', 0, 29)
--134




/* LoginRole  */


Insert Into LoginRole(RoleID,LoginID)values(151,1687)





--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(516,138)








/* MENU MASTer  */
DELETE FROM MenuMaster where OrgId=29
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1667,'Patient Search',0,29,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1668,'Patient Search',0,29,11)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1669,'Patient Search',0,29,12)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1670,'Patient Registration',0,29,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1671,'Home',0,29,8)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1672,'Home',0,29,9)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1673,'Home',0,29,1)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1674,'Home',0,29,14)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1675,'Reports',0,29,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1676,'Set Reminders',0,29,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1677,'Doctor Schedule',7,29,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1678,'Home',0,29,13)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1679,'Home',0,29,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1680,'Investigation Report',0,29,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1681,'Home',0,29,27)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1682,'View Schedules',7,29,37)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1683,'Today''s OP Visits',0,29,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1684,'BillSearch',0,29,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1685,'Cash Closure',0,29,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1686,'Cash Closure',0,29,48)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1687,'Patient Management',1,29,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1688,'View Room Details',1,29,54)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1689,'Visit Search',0,29,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1690,'Manage Rates',2,29,59)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1691,'Add Investigation/Groups',2,29,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1692,'Reference Range Mgmt',2,29,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1693,'Manage User',2,29,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1694,'Patient Search',0,29,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1695,'Cash OutFlow',0,29,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1696,'Check Safety Code',0,29,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1697,'Add Corporate & Client',2,29,72)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1698,'Task ReAssign',0,29,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1699,'Dashboard',0,29,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1791,'Settlement',1,29,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1792,'Billing',1,29,79)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1793,'Plan Vacation',7,29,83)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1794,'Purchase Order',3,29,93)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1795,'Stock Receive',3,29,94)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1796,'Stock Return',3,29,95)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1797,'Stock Damage',3,29,96)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1798,'Inventory Search',3,29,97)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1799,'Categories',3,29,102)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1800,'Products',3,29,103)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1801,'Suppliers',3,29,104)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1802,'Stock Issued',3,29,116)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1803,'Stock In Hand',3,29,107)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1804,'OP Billing',0,29,108)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1805,'IP Billing',0,29,113)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1806,'Bulkload',3,29,114)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1807,'Reorder Level',3,29,115)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1808,'Stock Report',3,29,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1809,'All Schedules',7,29,120)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1810,'In Bound Referral',8,29,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1811,'Out Bound Referral',8,29,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1812,'Summary Reports',0,29,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1813,'Manage Test Kit',2,29,144)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1814,'Manage Test Method',2,29,145)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1815,'Manage Test Principle',2,29,237)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1816,'Manage Test Instrument',2,29,143)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1817,'Lab User Wise Daily Report',20,29,35)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1818,'Lab Summary Reports',20,29,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1819,'Manage Package',2,29,252)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1820,'ChangePassword',0,29,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1889,'Home',0,29,293) -- Cashier Home Page


delete  from RoleMenu where RoleID in(146,147,148,149,150,151,152,153,154,155,156,157)
--Admin

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1675,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1674,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1676,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1677,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1682,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1695,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1685,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1684,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1690,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1691,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1692,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1693,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1697,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1698,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1699,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1791,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1688,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1792,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1813,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1814,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1815,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1816,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1819,151)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1817,151)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1818,151)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1694,151)
---Reception							 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1684,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1686,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1695,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1673,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1667,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1683,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1689,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1670,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1682,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1687,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1791,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1792,150)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1688,150)

---Physician

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1672,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1680,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1667,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1683,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1689,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1682,146)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1687,146)

--Lab
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1678,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1680,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1694,148)

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1691,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1697,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1692,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1813,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1814,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1815,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1816,148)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1819,148)


--Nurse

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,147)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1671,147)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1668,147)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1683,147)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1687,147)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1792,147)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1688,147)

--Dial
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1681,152)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,152)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1694,152)
---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1685,155)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1820,155)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1675,155)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1695,155)
insert into RoleMenu (MenuID,RoleID)values(1792,155)

Insert into RoleMenu (MenuID,RoleID)   values(1684,155)
Insert into RoleMenu (MenuID,RoleID)   values(1699,155)
INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1683, 148)
INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1889, 1616)
INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1820, 1616)
																		 
/* PageMapping  */
delete from PageMapping where RoleId in(146,147,148,150,151,152,154,157)
Insert into PageMapping(RoleId,PageID,SeqNo) values(146,9,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(147,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(148,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(150,1,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(151,14,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(152,27,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(154,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(157,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(155,43,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(156,112,  1)
INSERT INTO PageMapping (RoleId, PageID, SeqNo) VALUES (1616, 293, 1)
/* OrgUOMVitalsMapping  */

--OrgUOMVitalsID--identity--
delete from OrgUOMVitalsMapping where OrgID = 29
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(112,29,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(113,29,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(114,29,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(115,29,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(116,29,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(117,29,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(118,29,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(119,29,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(120,29,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(121,29,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(122,29,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(123,29,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(124,29,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(125,29,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(126,29,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(127,29,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(128,29,12,17)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(129,29,53,18)


/* ProcedureMaster  */
----ProcedureID--identity
delete from ProcedureMaster where OrgID =29
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(15,  'Dialysis','Treatment','Dialysis',29,  'y',1, 'Sep  2 2009 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(16,  'Physiotherapy','Treatment','Physiotherapy',29,  'y',1, 'Feb  27 2010 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(17,  'Others','Treatment','Others',29,  'y',1, 'Feb  27 2010 12:00AM')

/*  OrganizationAddress  */

/* StandardDeduction  */
delete from StandardDeduction where OrgID=29
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(109,29,  'Self Employee', 2,'P')
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(110,29,  'Govt Employee', 100,'V')

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)

Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,80,'Short wave Diathermy',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,80,'Ultrasound (9US)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,80,'Cervical Traction (ICT)',  'Y', 1900, 26)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,80,'Pelvic Traction (IPT)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,120,'Muscle Stimulation (ES)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,80,'Wax Bath (9WB)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,120,'Comt Pass Mov (CPM)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,100,'Interferential Therapy (9IFT)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,70,'Mobilisation Exercise (Ex)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,70,'Cervical / dumber Exercise',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,70,'Shoulder/knee Exercise',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,70,'Finger Foat Exercise',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,50,'Infra Red Radiation (Irr)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,150,'Combination Therapy (SWD+ICT)(IPT+IFT)',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(16,150,'Manipulation & Mobilisation',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(17,0,'Others',  'Y', 1900, 29)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(15,600,'Dialysis',  'Y', 1900, 29)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =29
---speciality mapping---
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,3,  0,9) 

----procedure Task Mapping
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,7,  16,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,7,  15,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,7,  17,6)
------
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1, 13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  15,11) 
Insert into TaskActionMapping (OrgID,VisitPurposeID,OtherID,TaskActionID) VALUES (29,4,0, 38)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,7,  5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,1,  16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,11,  0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(29,9,  0,36) 

/*  Config  */
delete from Config where OrgID=29
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','Before',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','Y',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','After',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,29)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,29)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,29)
INSERT INTO Config (ConfigKey, ConfigValue, ParentID, OrgID) VALUES ('NeedIPNumber', 'N', 0, 29)
GO

/*  BillSearchActions  */
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Print Bill',150,28)
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Refund / Cancel',151,47)
INSERT INTO BillSearchActions (ActionName ,RoleID,PageID )VALUES('Print Bill',157,28)
INSERT INTO BillSearchActions (ActionName, RoleID, PageID) VALUES ('Print Bill', 155, 28)
INSERT INTO BillSearchActions (ActionName, RoleID, PageID) VALUES ('Refund', 155, 47)
INSERT INTO BillSearchActions (ActionName, RoleID, PageID) VALUES ('Cancel Bill', 155, 47)
GO

delete from OrganizationSpeciality where OrgID =29
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,1,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,2,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,3,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,4,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,5,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,6,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,7,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,8,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,9,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,10,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,11,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,12,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,13,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,14,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,15,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,16,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,17,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,18,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,19,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,20,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,22,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,23,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,24,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,25,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,26,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,27,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,28,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,29,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,30,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,31,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,32,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,33,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,35,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,36,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,37,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,38,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(29,39,  0)


/*  TaskEscalation  */
delete from TaskEscalation where OrgID =29

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,150,29,30)

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,150,29,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,150,29,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID =29
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,147,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,147,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,147,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,152,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,152,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,152,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,1616,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,148,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,146,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,146,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,1616,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,148,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,1616,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,148,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,131,  29)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,154,  29)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,150,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,147,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,146,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,150,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,147,  29)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,1616,  29)
INSERT INTO TaskActionOrgMapping (TaskActionID, RoleID, OrgID) VALUES (38, 146, 29)


/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=29
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,29)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,29)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,29)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,29)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,29)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,29)
INSERT INTO VisitPurposeOrgMapping (VisitPurposeID, OrgID) VALUES(4, 29)




/*	invdeptmaster	*/
DELETE FROM InvDeptMaster where OrgID=29
INSERT INTO invdeptmaster(Deptid,deptname,orgid)  VALUES(210,'Lab',29)
INSERT INTO InvDeptMaster(DeptID,DeptName,OrgID) VALUES (211,'Pharmacy',29)
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (212,'BioChemistry',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (213,'Clinical Pathology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (214,'Hematology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (215,'HistoPathology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (216,'MicroBiology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (217,'Imaging',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (218,'X-Ray',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (219,'CT',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (220,'MRI',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (221,'USG',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (222,'ECG',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (223,'Endoscopy',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (224,'Immunology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (225,'Cytogenetics',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (226,'Cytology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (227,'Biochemistry and ClinicalPathology',29,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (228,'Biochemistry, Clinical Pathology and Microbiology',29,'Y')


/*	RoleDeptMap	*/
DELETE FROM RoleDeptMap where RoleID IN (148,154)
Insert into RoleDeptMap(RoleID,DeptID)  values(148,210)
Insert into RoleDeptMap(RoleID,DeptID)  values(154,212)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,212)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,213)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,214)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,215)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,216)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,217)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (154,218)







/* InvestigationOrgSampleStatus	*/

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (29, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (29, 'SampleReceived', 2)





/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=29
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN)VALUES(1900,29,'GENERAL',1,NULL,'Y')


DELETE FROM ReportOrgMapping WHERE OrgID = 29

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,151,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,151,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,151,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,150,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,151,29)

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,155,29)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,155,29)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,151,29)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,151,29)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,151,29)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,151,29)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,151,29)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,151,29)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(21, 151,  29)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(22, 151,  29)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(23, 151,  29)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(24, 151,  29)
GO

DELETE FROM CashExpenseMaster WHERE OrgID =29
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',29,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',29,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',29,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',29,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',29,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',29,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',29,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 29
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,29)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,29)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,29)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 150,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 150,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 151,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 151,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 150,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 147,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 150,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 150,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 151,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 150,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 150,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 150,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 148,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 150, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 147, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 147, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 152, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 152,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 146,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 147,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 150,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 147,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 146,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 150,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 147,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 146,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 148,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 150,	2, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 150,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 151,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 150,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 146,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 147,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 150,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 150,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 147,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 150,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 146,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 147,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 150,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 150,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 150,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 150,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 147,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 150,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 148,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 150,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 150,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 150,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 150,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 150,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 150,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 150,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 150,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 150,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 150,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 150,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 150,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 146,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 147,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 150,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 150,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 150,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 150,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 150,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 150,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 150,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 150,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 151,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 146,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 150,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 148,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 148,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 150,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 150,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 151,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 151,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 151,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 151,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 151,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 151,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 151,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 156,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 156,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 156,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 156,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 156,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 150,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 146,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 150, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 148, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 150, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 147,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 150,	148,10)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 152, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 152,	23,11)

--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 150, 148, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,146,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,146,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,150,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,150,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,150,6,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,147,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,157,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,157,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,157,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,157,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,157,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,157,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,157,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,157,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,157,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,157,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,157,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,157,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,157,28,11)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,157,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,157,28,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (64,150,255,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (66,150,255,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 151,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 150,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 151,	279,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 150,	279,	12)
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)values(26,155,52,5)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75, 151,	56,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 147, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 148, 254, 19)


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 150,	297,12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 157,	297,12)


GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =29

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,29, 29)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,29, 29)
INSERT INTO PageActionMapping (PageActionID,OwnerOrgID,SharedOrgID) VALUES (64,29,29)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =29
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',29)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',29)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',29)
GO

DELETE FROM InvKitMaster WHERE OrgID =29
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' , 29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',29)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',29)
GO

DELETE FROM InvestigationMethod WHERE OrgID =29
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',26)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',29)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',29)

GO

DELETE FROM InvResultTemplate WHERE OrgID =29

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',29)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',29)
INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 29)
INSERT INTO InvResultTemplate(ResultID,ResultName,ResultTemplateType,ResultValues,OrgID)VALUES (44,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.',29)

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =29
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',29)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',29)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',29)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',29)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =29
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',29)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',29)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',29)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',29)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',29)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(29,29,1)

insert into RoleDeptMap (RoleID ,DeptID )values(148,211)
insert into RoleDeptMap (RoleID ,DeptID )values(148,212)
insert into RoleDeptMap (RoleID ,DeptID )values(148,213)
insert into RoleDeptMap (RoleID ,DeptID )values(148,214)
insert into RoleDeptMap (RoleID ,DeptID )values(148,215)
insert into RoleDeptMap (RoleID ,DeptID )values(148,216)
insert into RoleDeptMap (RoleID ,DeptID )values(148,217)
insert into RoleDeptMap (RoleID ,DeptID )values(148,218)
insert into RoleDeptMap (RoleID ,DeptID )values(148,219)
insert into RoleDeptMap (RoleID ,DeptID )values(148,220)
insert into RoleDeptMap (RoleID ,DeptID )values(148,221)
insert into RoleDeptMap (RoleID ,DeptID )values(148,222)
insert into RoleDeptMap (RoleID ,DeptID )values(148,223)
insert into RoleDeptMap (RoleID ,DeptID )values(148,224)
insert into RoleDeptMap (RoleID ,DeptID )values(148,225)
insert into RoleDeptMap (RoleID ,DeptID )values(148,226)
insert into RoleDeptMap (RoleID ,DeptID )values(148,227)
insert into RoleDeptMap (RoleID ,DeptID )values(148,228)



insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(31,'Medical Management',29)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(32,'Surgery',29)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(33,'Emergency Care',29)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(34,'Intervention',29)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(35,'Medical Evaluation',29)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',29)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',29)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',29)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',29)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',29)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',29)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',29)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',29)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',29)

Delete From IPPaymentsRoleMapping Where Roleid IN (147,157,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,147)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,147)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,147)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,147)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,147)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,150)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,150)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,157)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,157)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,157)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,157)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,157)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,147)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,150)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,155)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,155)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,155)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,155)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,155)



INSERT INTO IPPaymentsRoleMapping  VALUES(11,150)



GO


DELETE FROM SurgeryType WHERE OrgID = 29
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',29)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',29)
GO

/* OperationType */
DELETE FROM OperationType WHERE OrgID = 29
insert into OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',29)
insert into OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',29)
GO

delete  from InvStatusmapping where OrgID =29
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,29,3)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,29,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,29,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,29,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,29,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,29,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,29,2)
GO

DELETE FROM FeeTypeConfig WHERE OrgID = 29
INSERT INTO FeeTypeConfig (Feetype, UseEdit, OrgID) VALUES ('CON', 'Y', 29)
GO
delete CasualtyCharges where OrgID =29
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (35, 'C18',  'POP', 'CAS', 0.00, 29)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (36, 'C19',  'Dressing - Small', 'CAS', 30.00, 29)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (37, 'C20',  'Dressing - Medium', 'CAS', 50.00, 29)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (38, 'C21',  'Dressing - Large', 'CAS', 100.00, 29)
INSERT INTO CasualtyCharges (CasualtyID, CasualtyCode, TestName, FeeType, CasualtyRate, OrgID) VALUES (39, 'C22',  'Injection ', 'CAS', 20.00, 29)


DELETE FROM FloorMaster WHERE OrgAddID=29
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(6,'1ST FLOOR',29)

INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(10,'2NT FLOOR',29)
GO 
DELETE FROM RoomType WHERE OrgAddID=29
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('A/C SINGLE ROOM',29)
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('SINGLE ROOM',29)

DELETE FROM RoomMaster WHERE RoomTypeID =6 AND FloorID =11
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(91,'ROOM11',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(92,'ROOM12',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(93,'ROOM13',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(94,'ROOM14',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(95,'ROOM15',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(96,'ROOM16',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(97,'ROOM17',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(98,'ROOM18',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(99,'ROOM19',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(100,'ROOM20',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(101,'ROOM21',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(102,'ROOM22',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(103,'ROOM23',6,11)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(116,'ROOM1',10,18)

DELETE FROM BedMaster WHERE RoomID between 91 and 103
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(105,'BED1',91)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(106,'BED1',92)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(107,'BED1',93)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(108,'BED1',94)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(109,'BED1',95)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(110,'BED1',96)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(111,'BED1',97)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(112,'BED1',98)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(113,'BED1',99)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(114,'BED1',100)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(115,'BED1',101)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(116,'BED1',102)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(117,'BED1',103)

INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(136,'BED1',116)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(137,'BED2',116)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(138,'BED3',116)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(139,'BED4',116)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(140,'BED5',116)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(141,'BED6',116)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 29

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 29, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 29, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 29, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 29, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 29, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 29, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 29, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 29, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 29, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 29, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 29, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 29, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 29, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 29, 'IP')
GO
