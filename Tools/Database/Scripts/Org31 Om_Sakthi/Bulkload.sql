/* Login  */

delete From Organization where OrgID =31
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)values(31,'Om Sakthi Hospital',1,  0,'')

delete from OrganizationAddress where OrgID = 31
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) 
Values(30,31,'','',', ',' ,','',0,'Dharmapuri',0,'','','','Dharmapuri')

/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=31
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN,RateTypeId,RateId)VALUES(2150,31,'GENERAL',1,NULL,'Y',1,2150)

Delete from  RateMaster where OrgID=31
insert into RateMaster(RateId,RateName,RateTypeId,Discount,Status,orgid)values(2150,'GENERAL',1,0.00,'Y',31)

delete From Login where OrgID =31
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(1890,'OmSakthi1890','OmSakthi','N',31,  'A')

insert into IDMaster (OrgID,PatientNumber ,BillNumber ,IPNumber ,VisitNumber )values(31,0,0,0,0)

/* Users */
delete From Users where OrgID =31
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('OmSakthi','M','1',31,1890)

/* LoginRole  */
Insert Into LoginRole(RoleID,LoginID)values(177,1890)

/* Role */
delete From Role where OrgID =31
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(172,'Physician','Doctor',  0,31)--159
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(173,'Nurse','Nurse',  0,31)--160
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(174,'Lab Technician','Lab Technician',  0,31)--161
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(175,'Patient','Patient',  0,31)--162
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(176,'Receptionist','Receptionist',  0,31)--163
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(177,'Administrator','Administrator',  0,31)--164
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(178,'Dialysis Technician','Dialysis Technician',  0,31)--165
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(179,'Billing','Billing',  0,31)--166
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(180,'Xray','Xray',  0,31)--167
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(181,'Accounts','Accounts',  0,31)--168
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(182,'Pharmacist','Pharmacist',  0,31)--169
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(183,'Wardsecretary','Wardsecretary',  0,31)--170
INSERT INTO Role(RoleID,RoleName,Description,ParentID,OrgID) VALUES (184, 'Cashier', 'Cashier', 0, 31)--171
															 



/* MENU MASTer  */
DELETE FROM MenuMaster where OrgId=31
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2037,'Patient Search',0,31,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2038,'Patient Search',0,31,11)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2039,'Patient Search',0,31,12)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2040,'Patient Registration',0,31,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2041,'Home',0,31,8)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2042,'Home',0,31,9)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2043,'Home',0,31,1)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2044,'Home',0,31,14)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2045,'Reports',0,31,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2046,'Set Reminders',0,31,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2047,'Doctor Schedule',7,31,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2048,'Home',0,31,13)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2049,'Home',0,31,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2050,'Investigation Report',0,31,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2051,'Home',0,31,27)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2052,'View Schedules',7,31,37)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2053,'Today''s OP Visits',0,31,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2054,'BillSearch',0,31,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2055,'Cash Closure',0,31,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2056,'Cash Closure',0,31,48)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2057,'Patient Management',1,31,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2058,'View Room Details',1,31,54)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2059,'Visit Search',0,31,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2060,'Manage Rates',2,31,59)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2061,'Add Investigation/Groups',2,31,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2062,'Reference Range Mgmt',2,31,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2063,'Manage User',2,31,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2064,'Patient Search',0,31,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2065,'Cash OutFlow',0,31,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2066,'Check Safety Code',0,31,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2067,'Add Corporate & Client',2,31,72)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2068,'Task ReAssign',0,31,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2069,'Dashboard',0,31,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2070,'Settlement',1,31,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2071,'Billing',1,31,79)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2072,'Plan Vacation',7,31,83)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2073,'Purchase Order',3,31,93)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2074,'Stock Receive',3,31,94)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2075,'Stock Return',3,31,95)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2076,'Stock Damage',3,31,96)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2077,'Inventory Search',3,31,97)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2078,'Categories',3,31,102)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2079,'Products',3,31,103)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2080,'Suppliers',3,31,104)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2081,'Stock Issued',3,31,116)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2082,'Stock In Hand',3,31,107)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2083,'OP Billing',0,31,108)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2084,'IP Billing',0,31,113)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2085,'Bulkload',3,31,114)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2086,'Reorder Level',3,31,115)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2087,'Stock Report',3,31,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2088,'All Schedules',7,31,120)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2089,'In Bound Referral',8,31,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2090,'Out Bound Referral',8,31,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2091,'Summary Reports',0,31,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2092,'Manage Test Kit',2,31,144)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2093,'Manage Test Method',2,31,145)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2094,'Manage Test Principle',2,31,237)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2095,'Manage Test Instrument',2,31,143)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2096,'Lab User Wise Daily Report',20,31,35)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2097,'Lab Summary Reports',20,31,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2098,'Manage Package',2,31,252)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2099,'ChangePassword',0,31,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2100,'Home',0,31,293) -- Cashier Home Page
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(2101,'Help Video',21,31,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2102,'Surgery Package',2,31,298)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2103,'Manage RateType',2,31,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2104,'ManageSequence No',2,31,269)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2105,'Cash Payment',0,31,67)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2106,'ReceiptSearch',0,31,297)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2107,'TPASearch',1,31,268)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2108,'Voucher Search',0,31,342)
																		
delete  from RoleMenu where RoleID in(172,173,174,175,176,177,178,179,180,181,182,183,184)
--Admin																	
																		 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,177)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2045,177)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2044,177)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2046,177)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2047,177)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2052,177)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2074,177)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2055,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2054,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2060,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2061,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2062,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2063,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2067,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2068,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2069,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2070,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2058,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2071,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2092,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2093,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2094,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2095,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2098,177)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2064,177)
insert into RoleMenu (MenuID,RoleID)values(2102,177)
insert into RoleMenu (MenuID,RoleID)values(2103,177)
insert into RoleMenu (MenuID,RoleID)values(2104,177)
insert into RoleMenu (MenuID,RoleID)values(2105,177)
insert into RoleMenu (MenuID,RoleID)values(2106,177)
insert into RoleMenu (MenuID,RoleID)values(2107,177)
insert into RoleMenu (MenuID,RoleID)values(2072,177)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1817,151)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1818,151)
---Reception							 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2054,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2056,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2065,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2043,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2037,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2053,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2059,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2040,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2052,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2057,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2070,176)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2071,176)
insert into RoleMenu (MenuID ,RoleID)values(2108,176)
insert into RoleMenu (MenuID ,RoleID)values(2107,176)
insert into RoleMenu (MenuID ,RoleID)values(2106,176)
insert into RoleMenu (MenuID ,RoleID)values(2050,176)



--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1959,163)
												
---Physician									
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2042,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2050,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2047,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2053,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2059,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2052,172)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2057,172)
												
--Lab											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2048,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2050,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2064,174)
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2061,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2067,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2062,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2092,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2093,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2094,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2095,174)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2098,174)
												
												
--Nurse											
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,173)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2041,173)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2038,173)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2053,173)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2057,173)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2071,173)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2038,173)
												
--Dial											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2051,178)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,178)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2064,178)
---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2055,181)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2099,181)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2045,181)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2065,181)
insert into RoleMenu (MenuID,RoleID)values(2071,181)

Insert into RoleMenu (MenuID,RoleID)   values(2054,181)
Insert into RoleMenu (MenuID,RoleID)   values(2069,181)


--video---
 insert into RoleMenu (MenuID,RoleID)values(2101,172)
 insert into RoleMenu (MenuID,RoleID)values(2101,173)
 insert into RoleMenu (MenuID,RoleID)values(2101,174)
 insert into RoleMenu (MenuID,RoleID)values(2101,175)
 insert into RoleMenu (MenuID,RoleID)values(2101,176)
 insert into RoleMenu (MenuID,RoleID)values(2101,177)
 insert into RoleMenu (MenuID,RoleID)values(2101,178)
 insert into RoleMenu (MenuID,RoleID)values(2101,179)
 insert into RoleMenu (MenuID,RoleID)values(2101,180)
 insert into RoleMenu (MenuID,RoleID)values(2101,181)
 insert into RoleMenu (MenuID,RoleID)values(2101,182)
 insert into RoleMenu (MenuID,RoleID)values(2101,183)


--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1974, 148)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2021, 1616)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2020, 1616)
																		 
/* PageMapping  */
delete from PageMapping where RoleId in(172,173,174,176,177,178,180,183,181,182,184)
Insert into PageMapping(RoleId,PageID,SeqNo) values(172,9,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(173,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(174,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(176,1,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(177,14,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(178,27,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(180,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(183,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(181,256,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(182,112,  1)
INSERT INTO PageMapping (RoleId, PageID, SeqNo) VALUES (184, 293, 1)
/* OrgUOMVitalsMapping  */


--OrgUOMVitalsID--identity--
delete from OrgUOMVitalsMapping where OrgID = 31
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(148,31,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(149,31,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(150,31,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(151,31,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(152,31,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(153,31,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(154,31,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(155,31,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(156,31,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(157,31,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(158,31,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(159,31,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(160,31,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(161,31,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(162,31,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(163,31,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(164,31,12,17)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(165,31,53,18)
																			  
																			  
/* ProcedureMaster  */														 
----ProcedureID--identity
delete from ProcedureMaster where OrgID =31
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(21,  'Dialysis','Treatment','Dialysis',31,  'y',1, 'Sep  2 2009 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(22,  'Physiotherapy','Treatment','Physiotherapy',31,  'y',1, 'Feb  27 2010 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(23,  'Others','Treatment','Others',31,  'y',1, 'Feb  27 2010 12:00AM')

/*  OrganizationAddress  */

/* StandardDeduction manually increase the standard deduction id as(StdDedID + 1)*/
delete from StandardDeduction where OrgID=31
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(113,31,  'Self Employee', 2,'P')
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(114,31,  'Govt Employee', 100,'V')

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)
DELETE FROM ProcedureFee WHERE ProcedureID IN(21,22,23)

Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,40,'Wax Bath (U/L)',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,60,'Wax Bath (B/L)',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,40,'IFT(U/L)',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,50,'US(U/L)',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,60,'US(B/L)',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,50,'Exercise',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(22,60,'Stimulation',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(23,0,'Others',  'Y', 2150, 31)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(21,600,'Dialysis',  'Y', 2150, 31)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =31
---speciality mapping---
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,3,0,9) 

----procedure Task Mapping
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,7,22,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,7,21,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,7,23,6)
------
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,15,11) 
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  VALUES(31,4,0,38)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,7,5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,1,16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,11,0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(31,9,0,36) 

/*  Config  */
delete from Config where OrgID=31
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','After',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','N',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','After',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,31)
Insert into config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('NormalFlow','True',0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,31)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,31)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES ('NeedIPNumber', 'N', 0, 31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('IPMakePayment','Y',0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('DisplayCurrencyFormat','Rupees',0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('NO','YES',0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('PrintReceipt','YES',0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ShowDisclaimer','NO',0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('HEALTHPKG','After',0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ScheduleDuration',7,0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ScheduleDuration',7,0,31)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ShowUnbilled','N',0,31)
GO

/*  BillSearchActions  */
delete from BillSearchActions where RoleID in(176,177,183,181)
Insert into BillSearchActions(ActionName,RoleID,PageID) Values('Print Bill',176,28)
Insert into BillSearchActions(ActionName,RoleID,PageID) Values('Refund / Cancel',177,47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Print Bill',183,28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Print Bill', 181, 28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Refund', 181, 47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Cancel Bill', 181, 47)
GO

delete from OrganizationSpeciality where OrgID =31
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,1,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,2,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,3,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,4,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,5,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,6,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,7,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,8,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,9,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,10,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,11,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,12,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,13,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,14,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,15,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,16,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,17,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,18,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,19,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,20,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,22,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,23,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,24,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,25,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,26,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,27,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,28,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,29,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,30,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,31,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,32,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,33,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,35,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,36,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,37,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,38,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(31,39,  0)


/*  TaskEscalation  */
delete from TaskEscalation where OrgID =31

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,176,31,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,176,31,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID =31
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,173,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,173,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,173,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,178,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,178,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,178,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,174,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,172,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,172,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,174,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,174,31)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,167,  30)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,180,31)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,163,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,173,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,172,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,176,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,173,31)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,176,31)
INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  VALUES(38,172,31)

/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=31
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,31)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,31)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,31)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,31)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,31)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,31)
INSERT INTO VisitPurposeOrgMapping(VisitPurposeID,OrgID)  VALUES(4,31)




--/*	invdeptmaster	*/
--DELETE FROM InvDeptMaster where OrgID=31
--INSERT INTO invdeptmaster (Deptid,deptname,orgid)  VALUES(251,'Lab',31)--232
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID) VALUES (252,'Pharmacy',31)--233
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (253,'BioChemistry',31,'Y')--234
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (254,'Clinical Pathology',31,'Y')--235
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (255,'Hematology',31,'Y')--236
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (256,'HistoPathology',31,'Y')--237
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (257,'MicroBiology',31,'Y')--238
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (258,'Imaging',31,'Y')--239
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (259,'X-Ray',31,'Y')--240
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (260,'CT',31,'Y')--241
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (261,'MRI',31,'Y')--242
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (262,'USG',31,'Y')--243
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (263,'ECG',31,'Y')--244
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (264,'Endoscopy',31,'Y')--245
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (265,'Immunology',31,'Y')--246
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (266,'Cytogenetics',31,'Y')--247
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (267,'Cytology',31,'Y')--248
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (268,'Biochemistry and ClinicalPathology',31,'Y')--249
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (269,'Biochemistry, Clinical Pathology and Microbiology',31,'Y')--250


--/*	RoleDeptMap	*/
--DELETE FROM RoleDeptMap where RoleID IN (174,180)
--Insert into RoleDeptMap(RoleID,DeptID)  values(174,251)
--Insert into RoleDeptMap(RoleID,DeptID)  values(180,253)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,253)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,254)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,255)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,256)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,257)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,258)
--INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES(180,259)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,252)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,253)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,254)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,255)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,256)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,257)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,258)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,259)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,260)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,261)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,262)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,263)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,264)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,265)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,266)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,267)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,268)
--insert into RoleDeptMap (RoleID ,DeptID )values(174,269)






/* InvestigationOrgSampleStatus	*/

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (31, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (31, 'SampleReceived', 2)



DELETE FROM ReportOrgMapping WHERE OrgID = 31

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,177,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,177,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,177,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,176,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,177,31)

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,181,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,181,31)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,177,31)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,177,31)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,177,31)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,177,31)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,177,31)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(21,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(22,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(23,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)Values(24,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(25,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(31,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(32,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(33,177,31)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(34,177,31)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(42,177,31)

GO

DELETE FROM CashExpenseMaster WHERE OrgID =31
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',31,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',31,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',31,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',31,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',31,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',31,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',31,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 31
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,31)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,31)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,31)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 176,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 176,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 177,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 177,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 176,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 173,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 176,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 176,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 177,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 176,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 176,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 176,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 174,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 176, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 173, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 173, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 178, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 178,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 172,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 173,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 176,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 173,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 172,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 176,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 173,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 172,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 174,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 176,	2, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 176,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 177,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 176,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 172,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 173,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 176,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 176,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 173,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 176,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 172,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 173,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 176,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 176,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 176,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 176,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 160,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 176,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 174,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 176,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 176,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 176,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 176,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 176,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 176,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 176,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 176,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 176,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 172,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 173,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 176,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 176,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 176,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 176,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 176,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 176,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 176,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 177,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 172,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 176,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 174,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 174,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 176,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 176,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 177,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 177,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 177,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 177,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 177,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 177,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 177,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 182,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 182,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 182,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 182,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 182,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 176,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 172,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 176, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 174, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 176, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 173,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 176,	161,10)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 178, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 178,	23,11)

--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 163, 161, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,172,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,172,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,176,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,176,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,176,6,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,173,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,183,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,183,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,183,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,183,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,183,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,183,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,183,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,183,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,183,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,183,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,183,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,183,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,183,28,11)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,183,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,183,28,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (64,176,255,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (66,176,255,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 177,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 177,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 177,	279,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 176,	279,	12)
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)values(26,181,52,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75, 177,	56,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 173, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 174, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 176,	297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 183,	297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73, 176,	280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74, 176,	281,13)


GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =31

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,31,31)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (64,31,31)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =31
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',31)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',31)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',31)
GO

DELETE FROM InvKitMaster WHERE OrgID =31
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' ,31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',31)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',31)
GO

DELETE FROM InvestigationMethod WHERE OrgID =31
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',31)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',31)

GO

DELETE FROM InvResultTemplate WHERE OrgID =31

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',31)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',31)
INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 31)
INSERT INTO InvResultTemplate(ResultID,ResultName,ResultTemplateType,ResultValues,OrgID)VALUES (44,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.',31)

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =31
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',31)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',31)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',31)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',31)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =31
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',31)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',31)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',31)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',31)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',31)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(31,31,1)


insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(41,'Medical Management',31)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(42,'Surgery',31)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(43,'Emergency Care',31)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(44,'Intervention',31)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(45,'Medical Evaluation',31)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',31)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',31)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',31)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',31)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',31)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',31)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',31)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',31)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',31)

Delete From IPPaymentsRoleMapping Where Roleid IN (173,183,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,173)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,173)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,173)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,173)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,173)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,176)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,176)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,183)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,183)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,183)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,183)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,183)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,173)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,176)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,181)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,181)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,181)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,181)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,181)
INSERT INTO IPPaymentsRoleMapping  VALUES(11,181)



GO


DELETE FROM SurgeryType WHERE OrgID = 31
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',31)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',31)
GO

/* OperationType */
DELETE FROM OperationType WHERE OrgID = 31
insert into OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',31)
insert into OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',31)
GO

delete  from InvStatusmapping where OrgID =31
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,31,3)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,31,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,31,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,31,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,31,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,31,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,31,2)
GO

DELETE FROM FeeTypeConfig WHERE OrgID = 31
INSERT INTO FeeTypeConfig (Feetype, UseEdit, OrgID) VALUES ('CON', 'Y', 31)
GO





insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(1,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(2,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(3,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(4,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(5,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(6,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(7,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(8,31,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(9,31,0.00)

insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,1,31)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,2,31)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(4,6,31)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,7,31)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 31

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 31, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 31, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 31, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 31, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 31, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 31, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 31, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 31, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 31, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 31, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 31, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 31, 'IP')
GO



DELETE FROM FloorMaster WHERE OrgAddID=31
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID,OrgID) VALUES(14,'1ST FLOOR',31,31)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID,OrgID) VALUES(15,'2ND FLOOR',31,31)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID,OrgID) VALUES(16,'3RD FLOOR',31,31)

DELETE FROM RoomType WHERE OrgAddID=31
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('NON A/C',31,31)--27
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('Double NON A/C',31,31)--28
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('SPECIAL ROOM AC',31,31)--29
INSERT INTO RoomType(RoomTypeName,OrgAddID,OrgID) VALUES ('ICU',31,31)--30



DELETE FROM RoomMaster WHERE  FloorID in(14,15,16)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(138,'47',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(139,'48',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(140,'49',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(141,'50',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(142,'52',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(143,'53',16,27)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(144,'54',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(145,'56',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(146,'57',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(147,'58',16,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(148,'42',16,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(149,'43',16,28)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(150,'44',16,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(151,'45',16,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(152,'46',16,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(153,'59',16,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(154,'55',16,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(156,'ICU',16,30)
--INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(155,'60',16,28)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(157,'24',15,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(158,'32',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(159,'34',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(160,'38',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(161,'39',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(162,'25',15,28)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(163,'26',15,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(164,'27',15,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(165,'28',15,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(166,'29',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(167,'30',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(168,'31',15,27)


INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(169,'33',15,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(170,'35',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(171,'36',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(172,'37',15,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(173,'40',15,27)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(174,'14',14,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(175,'ICU',14,30)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(176,'16',14,28)


DELETE FROM BedMaster WHERE RoomID between 199 and 264
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(199,'BED1',138)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(200,'BED1',139)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(201,'BED1',140)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(202,'BED1',141)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(203,'BED1',142)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(204,'BED1',143)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(205,'BED1',144)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(206,'BED1',145)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(207,'BED1',146)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(208,'BED1',147)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(209,'BED1',148)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(210,'BED2',148)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(211,'BED1',149)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(212,'BED2',149)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(213,'BED1',150)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(214,'BED2',150)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(215,'BED1',151)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(216,'BED2',151)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(217,'BED1',152)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(218,'BED2',152)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(219,'BED1',157)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(220,'BED1',158)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(221,'BED1',153)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(222,'BED2',153)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(223,'BED1',154)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(224,'BED2',154)
--INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(225,'BED1',60)
--INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(226,'BED2',60)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(227,'BED1',159)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(228,'BED1',160)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(229,'BED1',161)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(230,'BED1',162)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(231,'BED2',162)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(232,'BED1',163)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(233,'BED2',163)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(234,'BED1',164)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(235,'BED2',164)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(236,'BED1',165)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(237,'BED2',165)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(238,'BED1',166)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(239,'BED2',166)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(240,'BED1',167)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(241,'BED2',167)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(242,'BED1',168)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(243,'BED2',168)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(244,'BED1',169)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(245,'BED2',169)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(246,'BED1',170)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(247,'BED2',170)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(248,'BED1',171)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(249,'BED2',171)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(250,'BED1',172)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(251,'BED2',172)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(252,'BED1',173)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(253,'BED2',173)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(254,'BED1',174)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(255,'BED1',176)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(256,'BED2',176)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(257,'BED1',175)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(258,'BED2',175)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(259,'BED3',175)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(260,'BED4',175)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(261,'BED2',156)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(262,'BED3',156)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(263,'BED1',156)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(264,'BED4',156)

insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(27,1,300,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(27,6,150,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(27,5,150,'N','N')
  
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(28,1,500,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(28,6,150,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(28,5,150,'N','N')
  
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(29,1,1000,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(29,6,150,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(29,5,150,'N','N')
  
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(30,1,100,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(30,6,200,'N','N')
insert into RoomTypeFeeMapping(RoomTypeID,FeeID,Amount,ISVariable,ISOptional)values(30,5,200,'N','N')
  
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(21,1,'Receipt',31,30)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(22,2,'Voucher',31,30)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(23,3,'OPBill',31,30)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(24,4,'IPBill',31,30)


Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',21)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',22)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',23)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',24)

----------------------Header Font 
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',21)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',22)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',23)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',24)

----------------------Header Font Size
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',22)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',23)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',24)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',25)

----------------------Header Content

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Om Sakthi Hospital',21)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Om Sakthi Hospital',22)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Om Sakthi Hospital',23)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Om Sakthi Hospital',24)

---------------------- Contents Font

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',22)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',23)                                                                           
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',24)                                                                       
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',25)


---------------------- Contents Font Size

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',22)                                                                                
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',23)                                                                                  
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',24)                                                                                   
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',25)


---------------------- Border Style

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',22)                                                              
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',23)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',24)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',25)


---------------------- Border Width

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','75%',22)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1'  ,23)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1' ,24)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1' ,25)

 