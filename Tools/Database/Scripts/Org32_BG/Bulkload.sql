delete From Organization where OrgID =32
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)values(32,'B.G.Hospital',1,  0,'')

delete from OrganizationAddress where OrgID = 32
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) 
Values(32,32,'','',', ',' ,','',0,'Tiruchendur',0,'','','','Tiruchendur')

/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=32
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN,RateTypeId,RateId)VALUES(2200,32,'GENERAL',1,NULL,'Y',1,2200)

Delete from  RateMaster where OrgID=32
insert into RateMaster(RateId,RateName,RateTypeId,Discount,Status,orgid)values(2200,'GENERAL',1,0.00,'Y',32)

delete From Login where OrgID =32
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(1893,'Testbg1893','Testbg1893','N',32,  'A')

insert into IDMaster (OrgID,PatientNumber ,BillNumber ,IPNumber ,VisitNumber )values(32,0,0,0,0)

/* Users */
delete From Users where OrgID =32
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('Testbg','M','1',32,1893)

/* LoginRole  */
Insert Into LoginRole(RoleID,LoginID)values(190,1893)

/* Role */
delete From Role where OrgID =32
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(185,'Physician','Doctor',  0,32)--172
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(186,'Nurse','Nurse',  0,32)--173
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(187,'Lab Technician','Lab Technician',  0,32)--174
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(188,'Patient','Patient',  0,32)--175
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(189,'Receptionist','Receptionist',  0,32)--176
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(190,'Administrator','Administrator',  0,32)--177
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(191,'Dialysis Technician','Dialysis Technician',  0,32)--178
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(192,'Billing','Billing',  0,32)--179
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(193,'Xray','Xray',  0,32)--180
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(194,'Accounts','Accounts',  0,32)--181
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(195,'Pharmacist','Pharmacist',  0,32)--182
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(196,'Wardsecretary','Wardsecretary',  0,32)--183
INSERT INTO Role(RoleID,RoleName,Description,ParentID,OrgID) VALUES (197, 'Cashier', 'Cashier', 0,32)--184
															



/* MENU MASTer  */
DELETE FROM MenuMaster where OrgId=32
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2115,'Patient Search',0,32,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2116,'Patient Search',0,32,11)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2117,'Patient Search',0,32,12)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2118,'Patient Registration',0,32,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2119,'Home',0,32,8)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2120,'Home',0,32,9)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2121,'Home',0,32,1)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2122,'Home',0,32,14)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2123,'Reports',0,32,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2124,'Set Reminders',0,32,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2125,'Doctor Schedule',7,32,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2126,'Home',0,32,13)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2127,'Home',0,32,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2128,'Investigation Report',0,32,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2129,'Home',0,32,27)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2130,'View Schedules',7,32,37)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2131,'Today''s OP Visits',0,32,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2132,'BillSearch',0,32,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2133,'Cash Closure',0,32,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2134,'Cash Closure',0,32,48)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2135,'Patient Management',1,32,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2136,'View Room Details',1,32,54)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2137,'Visit Search',0,32,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2138,'Manage Rates',2,32,59)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2139,'Add Investigation/Groups',2,32,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2140,'Reference Range Mgmt',2,32,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2141,'Manage User',2,32,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2142,'Patient Search',0,32,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2143,'Cash OutFlow',0,32,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2144,'Check Safety Code',0,32,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2145,'Add Corporate & Client',2,32,72)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2146,'Task ReAssign',0,32,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2147,'Dashboard',0,32,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2148,'Settlement',1,32,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2149,'Billing',1,32,79)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2150,'Plan Vacation',7,32,83)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2151,'Purchase Order',3,32,93)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2152,'Stock Receive',3,32,94)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2153,'Stock Return',3,32,95)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2154,'Stock Damage',3,32,96)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2155,'Inventory Search',3,32,97)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2156,'Categories',3,32,102)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2157,'Products',3,32,103)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2158,'Suppliers',3,32,104)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2159,'Stock Issued',3,32,116)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2160,'Stock In Hand',3,32,107)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2161,'OP Billing',0,32,108)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2162,'IP Billing',0,32,113)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2163,'Bulkload',3,32,114)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2164,'Reorder Level',3,32,115)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2165,'Stock Report',3,32,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2166,'All Schedules',7,32,120)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2167,'In Bound Referral',8,32,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2168,'Out Bound Referral',8,32,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2169,'Summary Reports',0,32,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2170,'Manage Test Kit',2,32,144)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2171,'Manage Test Method',2,32,145)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2172,'Manage Test Principle',2,32,237)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2173,'Manage Test Instrument',2,32,143)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2174,'Lab User Wise Daily Report',20,32,35)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2175,'Lab Summary Reports',20,32,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2176,'Manage Package',2,32,252)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2177,'ChangePassword',0,32,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2178,'Home',0,32,293) -- Cashier Home Page
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(2179,'Help Video',21,32,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2180,'Surgery Package',2,32,298)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2181,'Manage RateType',2,32,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2182,'ManageSequence No',2,32,269)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2183,'Cash Payment',0,32,67)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2184,'ReceiptSearch',0,32,297)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2185,'TPASearch',1,32,268)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2186,'Voucher Search',0,32,342)
																		
delete  from RoleMenu where RoleID in(185,186,187,188,189,190,191,192,193,194,195,196,197)
--Admin																	
																		 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,190)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2123,190)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2122,190)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2124,190)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2125,190)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2130,190)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2152,190)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2133,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2132,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2138,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2139,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2140,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2141,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2145,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2146,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2147,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2148,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2136,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2149,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2170,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2171,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2172,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2173,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2176,190)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2142,190)
insert into RoleMenu (MenuID,RoleID)values(2180,190)
insert into RoleMenu (MenuID,RoleID)values(2181,190)
insert into RoleMenu (MenuID,RoleID)values(2182,190)
insert into RoleMenu (MenuID,RoleID)values(2183,190)
insert into RoleMenu (MenuID,RoleID)values(2184,190)
insert into RoleMenu (MenuID,RoleID)values(2185,190)
insert into RoleMenu (MenuID,RoleID)values(2150,190)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1817,151)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1818,151)
---Reception							 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2132,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2134,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2143,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2121,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2115,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2131,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2137,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2118,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2130,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2135,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2148,189)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2149,189)
insert into RoleMenu (MenuID,RoleID)values(2186,189)
insert into RoleMenu (MenuID,RoleID)values(2185,189)
insert into RoleMenu (MenuID,RoleID)values(2184,189)
insert into RoleMenu (MenuID,RoleID)values(2128,189)



--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1959,163)
												
---Physician									
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2120,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2128,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2125,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2131,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2137,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2130,185)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2135,185)
												
--Lab											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2126,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2128,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2142,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2139,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2145,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2140,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2170,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2171,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2172,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2173,187)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2176,187)
												
												
--Nurse											
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,186)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2119,186)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2116,186)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2131,186)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2135,186)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2149,186)

												
--Dial											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2129,191)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,191)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2142,191)
---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2133,194)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2177,194)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2123,194)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2143,194)
insert into RoleMenu (MenuID,RoleID)values(2149,194)
Insert into RoleMenu (MenuID,RoleID)values(2054,194)
Insert into RoleMenu (MenuID,RoleID)values(2069,194)


--video---
 insert into RoleMenu (MenuID,RoleID)values(2179,185)
 insert into RoleMenu (MenuID,RoleID)values(2179,186)
 insert into RoleMenu (MenuID,RoleID)values(2179,187)
 insert into RoleMenu (MenuID,RoleID)values(2179,188)
 insert into RoleMenu (MenuID,RoleID)values(2179,189)
 insert into RoleMenu (MenuID,RoleID)values(2179,190)
 insert into RoleMenu (MenuID,RoleID)values(2179,191)
 insert into RoleMenu (MenuID,RoleID)values(2179,192)
 insert into RoleMenu (MenuID,RoleID)values(2179,193)
 insert into RoleMenu (MenuID,RoleID)values(2179,194)
 insert into RoleMenu (MenuID,RoleID)values(2179,195)
 insert into RoleMenu (MenuID,RoleID)values(2179,196)


--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1974, 148)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2021, 1616)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2020, 1616)
																		 
/* PageMapping  */
delete from PageMapping where RoleId in(185,186,187,189,190,191,192,193,194,195,197)
Insert into PageMapping(RoleId,PageID,SeqNo) values(185,9,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(186,8,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(187,13,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(189,1,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(190,14,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(191,27,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(192,13,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(193,8,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(194,256,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(195,112,1)
INSERT INTO PageMapping(RoleId,PageID,SeqNo) VALUES(197,293,1)
/* OrgUOMVitalsMapping  */


--OrgUOMVitalsID--identity--
delete from OrgUOMVitalsMapping where OrgID = 32
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(166,32,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(167,32,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(168,32,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(169,32,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(170,32,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(171,32,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(172,32,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(173,32,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(174,32,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(175,32,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(176,32,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(177,32,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(178,32,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(179,32,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(180,32,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(181,32,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(182,32,12,17)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(183,32,53,18)
																	
																			  
/* ProcedureMaster  */														 
----ProcedureID--identity
delete from ProcedureMaster where OrgID =32
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(24,  'Dialysis','Treatment','Dialysis',32,  'y',1, 'Sep  2 2009 12:00AM')--21
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(25,  'Physiotherapy','Treatment','Physiotherapy',32,  'y',1, 'Feb  27 2010 12:00AM')--22
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(26,  'Others','Treatment','Others',32,  'y',1, 'Feb  27 2010 12:00AM')--23

/*  OrganizationAddress  */

/* StandardDeduction manually increase the standard deduction id as(StdDedID + 1)*/
delete from StandardDeduction where OrgID=32
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(115,32,  'Self Employee', 2,'P')--113
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(116,32,  'Govt Employee', 100,'V')--114

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)
DELETE FROM ProcedureFee WHERE ProcedureID IN(24,25,26)

Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,40,'Wax Bath (U/L)',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,60,'Wax Bath (B/L)',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,40,'IFT(U/L)',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,50,'US(U/L)',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,60,'US(B/L)',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,50,'Exercise',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(25,60,'Stimulation',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(26,0,'Others',  'Y', 2200,32)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(24,600,'Dialysis',  'Y', 2200,32)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =32
---speciality mapping---
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,3,0,9) 

----procedure Task Mapping
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,7,24,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,7,25,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,7,26,6)
------
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,15,11) 
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  VALUES(32,4,0,38)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,7,5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,1,16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,11,0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(32,9,0,36) 

/*  Config  */
delete from Config where OrgID=32
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','Before',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','N',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','After',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,32)
Insert into config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('NormalFlow','True',0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,32)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,32)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES ('NeedIPNumber', 'N', 0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('IPMakePayment','Y',0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('DisplayCurrencyFormat','Rupees',0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('NO','YES',0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('PrintReceipt','YES',0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ShowDisclaimer','NO',0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('HEALTHPKG','After',0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ScheduleDuration',7,0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ScheduleDuration',7,0,32)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ShowUnbilled','N',0,32)
GO

/*  BillSearchActions  */
delete from BillSearchActions where RoleID in(189,190,196,194)
Insert into BillSearchActions(ActionName,RoleID,PageID) Values('Print Bill',189,28)
Insert into BillSearchActions(ActionName,RoleID,PageID) Values('Refund / Cancel',190,47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Print Bill',196,28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Print Bill', 194, 28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Refund', 194, 47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Cancel Bill', 194, 47)
GO

delete from OrganizationSpeciality where OrgID =32
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,1,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,2,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,3,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,4,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,5,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,6,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,7,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,8,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,9,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,10,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,11,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,12,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,13,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,14,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,15,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,16,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,17,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,18,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,19,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,20,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,22,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,23,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,24,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,25,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,26,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,27,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,28,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,29,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,30,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,31,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,32,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,33,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,35,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,36,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,37,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,38,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(32,39,0)  
																				   

/*  TaskEscalation  */
delete from TaskEscalation where OrgID =32

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0 ,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0 ,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0 ,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0 ,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,189,32,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,189,32,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID =32
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,186,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,186,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,186,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,191,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,191,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,191,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,187,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,185,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,185,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,187,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,187,32)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,167,  30)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,193,32)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,163,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,186,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,185,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,189,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,186,32)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,189,32)
INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  VALUES(38,185,32)

/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=32
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,32)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,32)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,32)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,32)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,32)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,32)
INSERT INTO VisitPurposeOrgMapping(VisitPurposeID,OrgID)  VALUES(4,32)




--/*	invdeptmaster	*/
--DELETE FROM InvDeptMaster where OrgID=31
--INSERT INTO invdeptmaster (Deptid,deptname,orgid)  VALUES(251,'Lab',32)--232
--INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID) VALUES (252,'Pharmacy',32)--233
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

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (32, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (32, 'SampleReceived', 2)



DELETE FROM ReportOrgMapping WHERE OrgID = 32

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,190,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,190,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,190,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,189,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,190,32)

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,194,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,194,32)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,190,32)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,190,32)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,190,32)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,190,32)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,190,32)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(21,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(22,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(23,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)Values(24,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(25,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(31,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(32,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(33,190,32)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(34,190,32)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(42,190,32)

GO

DELETE FROM CashExpenseMaster WHERE OrgID =32
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',32,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',32,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',32,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',32,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',32,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',32,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',32,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 32
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,32)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,32)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,32)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 189,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 189,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 190,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 190,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 189,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 186,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 189,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 189,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 190,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 189,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 189,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 189,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 187,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 189, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 186, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 186, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 191, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 191,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 185,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 186,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 189,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 186,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 185,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 189,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 186,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 185,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 187,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 189,	2, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 189,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 190,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 189,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 185,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 186,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 189,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 189,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 186,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 189,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 185,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 186,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 189,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 189,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 189,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 189,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 160,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 189,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 187,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 189,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 189,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 189,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 189,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 189,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 189,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 189,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 189,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 189,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 185,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 186,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 189,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 189,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 189,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 189,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 189,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 189,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 189,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 190,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 185,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 189,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 187,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 187,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 189,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 189,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 190,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 190,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 190,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 190,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 190,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 190,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 190,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 195,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 195,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 195,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 195,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 195,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 189,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 185,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 189, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 187, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 189, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 186,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 189,	161,10)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 191, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 191,	23,11)

--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 163, 161, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,185,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,185,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,189,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,189,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,189,6,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,186,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,196,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,196,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,196,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,196,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,196,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,196,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,196,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,196,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,196,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,196,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,196,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,196,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,196,28,11)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,196,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,196,28,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (64,189,255,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (66,189,255,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(71,190,278,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(71,190,278,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(72,190,279,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(72,189,279,12)
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)values(26,194,52,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75, 190,	56,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 186, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63, 187, 254, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 189,	297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81, 196,	297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73, 189,	280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74, 189,	281,13)


GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =32

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,32,32)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (64,32,32)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =32
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',32)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',32)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',32)
GO

DELETE FROM InvKitMaster WHERE OrgID =32
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' ,32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',32)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',32)
GO

DELETE FROM InvestigationMethod WHERE OrgID =32
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',32)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',32)

GO

DELETE FROM InvResultTemplate WHERE OrgID =32

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',32)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',32)
INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 32)
INSERT INTO InvResultTemplate(ResultID,ResultName,ResultTemplateType,ResultValues,OrgID)VALUES (44,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.',32)

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =32
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',32)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',32)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',32)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',32)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =32
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',32)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',32)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',32)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',32)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',32)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(32,32,1)


insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(46,'Medical Management',32)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(47,'Surgery',32)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(48,'Emergency Care',32)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(49,'Intervention',32)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(50,'Medical Evaluation',32)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',32)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',32)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',32)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',32)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',32)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',32)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',32)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',32)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',32)

Delete From IPPaymentsRoleMapping Where Roleid IN (186,196,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,186)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,186)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,186)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,186)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,186)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,189)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,189)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,196)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,196)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,196)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,196)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,196)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,186)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,189)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,194)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,194)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,194)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,194)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,194)
INSERT INTO IPPaymentsRoleMapping  VALUES(11,194)



GO


DELETE FROM SurgeryType WHERE OrgID = 32
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',32)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',32)
GO

/* OperationType */
DELETE FROM OperationType WHERE OrgID = 32
insert into OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',32)
insert into OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',32)
GO

delete  from InvStatusmapping where OrgID =32
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,32,3)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,32,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,32,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,32,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,32,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,32,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,32,2)
GO

DELETE FROM FeeTypeConfig WHERE OrgID = 32
INSERT INTO FeeTypeConfig (Feetype, UseEdit, OrgID) VALUES ('CON', 'Y', 32)
GO





insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(1,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(2,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(3,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(4,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(5,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(6,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(7,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(8,32,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(9,32,0.00)

insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,1,32)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,2,32)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(4,6,32)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,7,32)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 32

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 32, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 32, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 32, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 32, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 32, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 32, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 32, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 32, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 32, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 32, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 32, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 32, 'IP')
GO



Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(25,1,'Receipt',32,32)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(26,2,'Voucher',32,32)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(27,3,'OPBill',32,32)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(28,4,'IPBill',32,32)


Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',25)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',26)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',27)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',28)

----------------------Header Font 
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',25)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',26)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',27)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',28)

----------------------Header Font Size
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',25)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',26)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',27)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',28)

----------------------Header Content

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','B.G Hospital',25)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','B.G Hospital',26)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','B.G Hospital',27)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','B.G Hospital',28)

---------------------- Contents Font

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',25)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',26)                                                                           
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',27)                                                                       
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',28)


---------------------- Contents Font Size

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',25)                                                                                
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',26)                                                                                  
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',27)                                                                                   
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',28)


---------------------- Border Style

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',25)                                                              
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',26)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',27)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',28)


---------------------- Border Width

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','75%',25)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1',26)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1',27)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1',28)

 