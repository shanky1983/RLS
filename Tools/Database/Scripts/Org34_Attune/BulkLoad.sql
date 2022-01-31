delete From Organization where OrgID =34
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)values(34,'Attune',1,  0,'')

delete from OrganizationAddress where OrgID = 34
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) 
Values(34,34,'','',', ',' ,','',0,'Chennai',0,'','','','Chennai')

/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=34
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN,RateTypeId,RateId)VALUES(2300,34,'GENERAL',1,NULL,'Y',1,2300)

Delete from  RateMaster where OrgID=34
insert into RateMaster(RateId,RateName,RateTypeId,Discount,Status,orgid)values(2300,'GENERAL',1,0.00,'Y',34)

delete From Login where OrgID =34
Insert into Login(loginID,LoginName,Password,IsLocked,OrgID,Status)values(1916,'Attune1916','Attune','N',34,'A')

insert into IDMaster (OrgID,PatientNumber ,BillNumber ,IPNumber ,VisitNumber )values(34,0,0,0,0)

--/* Users */
delete From Users where OrgID =34
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('Attune','M','1',34,1916)

--/* LoginRole  */
Insert Into LoginRole(RoleID,LoginID)values(216,1916)

/* Role */
delete From Role where OrgID =34
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(211,'Physician','Doctor',  0,34)--198
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(212,'Nurse','Nurse',  0,34)--199
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(213,'Lab Technician','Lab Technician',  0,34)--200
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(214,'Patient','Patient',  0,34)--201
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(215,'Receptionist','Receptionist',  0,34)--202
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(216,'Administrator','Administrator',  0,34)--203
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(217,'Dialysis Technician','Dialysis Technician',  0,34)--204
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(218,'Billing','Billing',  0,34)--205
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(219,'Xray','Xray',  0,34)--206
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(220,'Accounts','Accounts',  0,34)--207
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(221,'Pharmacist','Pharmacist',  0,34)--208
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(222,'Wardsecretary','Wardsecretary',  0,34)--209
INSERT INTO Role(RoleID,RoleName,Description,ParentID,OrgID) VALUES (223, 'Cashier', 'Cashier', 0,34)--210
																	 
																	 
																	 
																	 
/* MENU MASTer  */													 
DELETE FROM MenuMaster where OrgId=34								 
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2259,'Patient Search',0,34,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2260,'Patient Search',0,34,11)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2261,'Patient Search',0,34,12)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2262,'Patient Registration',0,34,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2263,'Home',0,34,8)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2264,'Home',0,34,9)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2265,'Home',0,34,1)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2266,'Home',0,34,14)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2267,'Reports',0,34,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2268,'Set Reminders',0,34,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2269,'Doctor Schedule',7,34,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2270,'Home',0,34,13)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2271,'Home',0,34,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2272,'Investigation Report',0,34,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2273,'Home',0,34,27)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2274,'View Schedules',7,34,37)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2275,'Today''s OP Visits',0,34,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2276,'BillSearch',0,34,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2277,'Cash Closure',0,34,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2278,'Cash Closure',0,34,48)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2279,'Patient Management',1,34,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2280,'View Room Details',1,34,54)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2281,'Visit Search',0,34,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2282,'Manage Rates',2,34,59)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2283,'Add Investigation/Groups',2,34,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2284,'Reference Range Mgmt',2,34,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2285,'Manage User',2,34,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2286,'Patient Search',0,34,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2287,'Cash OutFlow',0,34,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2288,'Check Safety Code',0,34,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2289,'Add Corporate & Client',2,34,72)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2290,'Task ReAssign',0,34,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2291,'Dashboard',0,34,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2292,'Settlement',1,34,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2293,'Billing',1,34,79)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2294,'Plan Vacation',7,34,83)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2295,'Purchase Order',3,34,93)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2296,'Stock Receive',3,34,94)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2297,'Stock Return',3,34,95)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2298,'Stock Damage',3,34,96)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2299,'Inventory Search',3,34,97)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2300,'Categories',3,34,102)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2301,'Products',3,34,103)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2302,'Suppliers',3,34,104)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2303,'Stock Issued',3,34,116)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2304,'Stock In Hand',3,34,107)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2305,'OP Billing',0,34,108)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2306,'IP Billing',0,34,113)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2307,'Bulkload',3,34,114)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2308,'Reorder Level',3,34,115)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2309,'Stock Report',3,34,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2310,'All Schedules',7,34,120)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2311,'In Bound Referral',8,34,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2312,'Out Bound Referral',8,34,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2313,'Summary Reports',0,34,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2314,'Manage Test Kit',2,34,144)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2315,'Manage Test Method',2,34,145)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2316,'Manage Test Principle',2,34,237)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2317,'Manage Test Instrument',2,34,143)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2318,'Lab User Wise Daily Report',20,34,35)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2319,'Lab Summary Reports',20,34,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2320,'Manage Package',2,34,252)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2321,'ChangePassword',0,34,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2322,'Home',0,34,293) -- Cashier Home Page
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(2323,'Help Video',25,34,341)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2324,'Surgery Package',2,34,298)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2325,'Manage RateType',2,34,347)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2326,'ManageSequence No',2,34,269)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2327,'Cash Payment',0,34,67)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2328,'ReceiptSearch',0,34,297)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2329,'TPASearch',1,34,268)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2330,'Voucher Search',0,34,342)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(2331,'NewInstanceCreation',2,34,354)
																		
delete  from RoleMenu where RoleID in(211,212,213,214,215,216,217,218,219,220,221,222,223)
--Admin																	
																		 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,216)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2267,216)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2266,216)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2268,216)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2269,216)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2274,216)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2296,216)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2277,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2276,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2282,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2283,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2284,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2285,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2289,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2290,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2291,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2292,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2280,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2293,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2314,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2315,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2316,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2317,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2320,216)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2286,216)
insert into RoleMenu (MenuID,RoleID)values(2324,216)
insert into RoleMenu (MenuID,RoleID)values(2325,216)
insert into RoleMenu (MenuID,RoleID)values(2326,216)
insert into RoleMenu (MenuID,RoleID)values(2327,216)
insert into RoleMenu (MenuID,RoleID)values(2328,216)
insert into RoleMenu (MenuID,RoleID)values(2329,216)
insert into RoleMenu (MenuID,RoleID)values(2294,216)
insert into RoleMenu (MenuID,RoleID)values(2331,216)

---Reception							 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2276,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2278,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2287,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2265,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2259,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2275,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2281,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2262,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2274,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2279,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2292,215)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2293,215)
insert into RoleMenu (MenuID,RoleID)values(2330,215)
insert into RoleMenu (MenuID,RoleID)values(2329,215)
insert into RoleMenu (MenuID,RoleID)values(2328,215)
insert into RoleMenu (MenuID,RoleID)values(2272,215)


												
---Physician									
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2264,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2272,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2269,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2275,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2281,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2274,211)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2279,211)
												
--Lab											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2270,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2272,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2286,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2283,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2289,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2284,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2314,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2315,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2316,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2317,213)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2320,213)
												
												
--Nurse											
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,212)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2263,212)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2260,212)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2275,212)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2279,212)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2293,212)

												
--Dial											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2273,217)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,217)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2286,217)
---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2277,220)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2321,220)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2267,220)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2287,220)
insert into RoleMenu (MenuID,RoleID)values(2293,220)
Insert into RoleMenu (MenuID,RoleID)values(2298,220)
Insert into RoleMenu (MenuID,RoleID)values(2313,220)


--video---
 insert into RoleMenu (MenuID,RoleID)values(2323,211)
 insert into RoleMenu (MenuID,RoleID)values(2323,212)
 insert into RoleMenu (MenuID,RoleID)values(2323,213)
 insert into RoleMenu (MenuID,RoleID)values(2323,214)
 insert into RoleMenu (MenuID,RoleID)values(2323,215)
 insert into RoleMenu (MenuID,RoleID)values(2323,216)
 insert into RoleMenu (MenuID,RoleID)values(2323,217)
 insert into RoleMenu (MenuID,RoleID)values(2323,218)
 insert into RoleMenu (MenuID,RoleID)values(2323,219)
 insert into RoleMenu (MenuID,RoleID)values(2323,220)
 insert into RoleMenu (MenuID,RoleID)values(2323,221)
 insert into RoleMenu (MenuID,RoleID)values(2323,222)
  insert into RoleMenu(MenuID,RoleID)values(2323,223)
												 
																		 
/* PageMapping  */
delete from PageMapping where RoleId in(211,212,213,215,216,217,218,219,220,221,223)
Insert into PageMapping(RoleId,PageID,SeqNo) values(211,9,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(212,8,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(213,13,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(215,1,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(216,14,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(217,27,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(218,13,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(219,8,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(220,256,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(221,112,1)
INSERT INTO PageMapping(RoleId,PageID,SeqNo) VALUES(223,293,1)
/* OrgUOMVitalsMapping  */		
					                  
												           
--OrgUOMVitalsID--identity--						
delete from OrgUOMVitalsMapping where OrgID = 34 	
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(202,34,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(203,34,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(204,34,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(205,34,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(206,34,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(207,34,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(208,34,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(209,34,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(210,34,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(211,34,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(212,34,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(213,34,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(214,34,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(215,34,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(216,34,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(217,34,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(218,34,12,17)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(219,34,53,18)
																		   
																			  
/* ProcedureMaster  */													   
----ProcedureID--identity
delete from ProcedureMaster where OrgID =34
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(30,  'Dialysis','Treatment','Dialysis',34,  'y',1, 'Sep  2 2009 12:00AM')--27
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(31,  'Physiotherapy','Treatment','Physiotherapy',34,  'y',1, 'Feb  27 2010 12:00AM')--28
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(32,  'Others','Treatment','Others',34,  'y',1, 'Feb  27 2010 12:00AM')--29

/*  OrganizationAddress  */

/* StandardDeduction manually increase the standard deduction id as(StdDedID + 1)*/
delete from StandardDeduction where OrgID=34
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(119,34,  'Self Employee', 2,'P')--117
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(120,34,  'Govt Employee', 100,'V')--118

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)
DELETE FROM ProcedureFee WHERE ProcedureID IN(30,31,32)

Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(31,40,'Wax Bath (U/L)',  'Y', 2300,34)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(31,60,'Wax Bath (B/L)',  'Y', 2300,34)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(31,40,'IFT(U/L)',  'Y', 2300,34)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(31,50,'US(U/L)',  'Y', 2300,34)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(31,60,'US(B/L)',  'Y', 2300,34)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(31,50,'Exercise',  'Y',2300,34)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =34
---speciality mapping---
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,3,0,9) 

----procedure Task Mapping
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,7,30,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,7,31,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,7,32,6)
------
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,15,11) 
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  VALUES(34,4,0,38)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,7,5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,1,16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,11,0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(34,9,0,36) 

/*  Config  */
delete from Config where OrgID=34
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','Before',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','N',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','Before',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,34)
Insert into config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('NormalFlow','True',0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,34)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,34)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)  VALUES ('NeedIPNumber', 'N', 0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('IPMakePayment','Y',0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('DisplayCurrencyFormat','Rupees',0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('NO','YES',0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('PrintReceipt','YES',0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ShowDisclaimer','NO',0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('HEALTHPKG','Before',0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ScheduleDuration',7,0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ScheduleDuration',7,0,34)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values ('ShowUnbilled','N',0,34)
GO

/*  BillSearchActions  */
delete from BillSearchActions where RoleID in(215,216,222,220)
Insert into BillSearchActions(ActionName,RoleID,PageID) Values('Print Bill',215,28)
Insert into BillSearchActions(ActionName,RoleID,PageID) Values('Refund / Cancel',216,47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Print Bill',222,28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Print Bill', 220, 28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Refund',220,47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID) VALUES('Cancel Bill',220,47)
GO

delete from OrganizationSpeciality where OrgID =34
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,1,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,2,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,3,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,4,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,5,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,6,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,7,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,8,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,9,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,10,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,11,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,12,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,13,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,14,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,15,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,16,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,17,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,18,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,19,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,20,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,22,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,23,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,24,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,25,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,26,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,27,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,28,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,29,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,30,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,31,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,32,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,33,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,35,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,36,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,37,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,38,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(34,39,0)  
																				   

/*  TaskEscalation  */
delete from TaskEscalation where OrgID =34

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0 ,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0 ,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0 ,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0 ,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,215,34,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,215,34,30)

					
delete from TaskActionOrgMapping where OrgID =34

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,212,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,212,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,212,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,217,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,217,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,217,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,213,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,211,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,211,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,213,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,213,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,219,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,212,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,211,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,215,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,212,34)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,215,34)
INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  VALUES(38,211,34)


/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=34
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,34)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,34)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,34)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,34)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,34)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,34)
INSERT INTO VisitPurposeOrgMapping(VisitPurposeID,OrgID)  VALUES(4,34)




--/*	invdeptmaster	*/
--DELETE FROM InvDeptMaster where OrgID=34
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

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (34, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (34, 'SampleReceived', 2)



DELETE FROM ReportOrgMapping WHERE OrgID = 34

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,216,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,216,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,216,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,215,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,216,34)

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,220,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,220,34)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,216,34)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,216,34)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,216,34)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,216,34)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,216,34)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(21,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(22,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(23,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)Values(24,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(25,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(31,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(32,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(33,216,34)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(34,216,34)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(42,216,34)

GO

DELETE FROM CashExpenseMaster WHERE OrgID =34
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',34,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',34,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',34,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',34,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',34,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',34,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',34,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 34
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,34)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,34)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,34)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 215,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 215,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 216,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 216,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 216,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 212,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 215,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 215,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 216,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 215,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 215,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 215,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 213,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 215, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 212, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 212, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 217, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 217,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 211,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 212,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 215,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 212,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 211,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 215,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 212,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 211,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 213,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 215,	2, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 215,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 216,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 215,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 211,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 212,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 215,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 215,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 212,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 215,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 211,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 211,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 215,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 215,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 215,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 215,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 160,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 215,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 213,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 215,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 215,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 215,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 215,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 215,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 215,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 215,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 215,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 215,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 211,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 212,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 215,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 215,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 215,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 215,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 215,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 215,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 215,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 216,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 211,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 215,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 213,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 213,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 216,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 215,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 216,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 216,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 216,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 216,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 216,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 216,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 216,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 221,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 221,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 221,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 221,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 221,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 215,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 211,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 215, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 213, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 215, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 212,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 215,	161,10)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 217, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 217,	23,11)


Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,211,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,211,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,215,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,215,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,215,6,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,212,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,222,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,222,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,222,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,222,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,222,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,222,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,222,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,222,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,222,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,222,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,222,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,222,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,222,28,11)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,222,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,222,28,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (64,215,255,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (66,215,255,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(71,216,278,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(71,216,278,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(72,216,279,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(72,215,279,12)
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)values(26,220,52,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75,216,56,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63,212,254,19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63,213,254,19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81,215,297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81,222,297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73,215,280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74,215,281,13)


GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =34

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,34,34)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (64,34,34)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =34
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',34)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',34)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',34)
GO

DELETE FROM InvKitMaster WHERE OrgID =34
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' ,34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',34)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',34)
GO

DELETE FROM InvestigationMethod WHERE OrgID =34
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',34)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',34)

GO

DELETE FROM InvResultTemplate WHERE OrgID =34

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',34)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',34)
INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 33)
INSERT INTO InvResultTemplate(ResultID,ResultName,ResultTemplateType,ResultValues,OrgID)VALUES (44,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.',34)

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =34
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',34)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',34)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',34)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',34)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =34
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',34)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',34)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',34)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',34)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',34)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(34,34,1)


insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(56,'Medical Management',34)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(57,'Surgery',34)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(58,'Emergency Care',34)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(59,'Intervention',34)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(60,'Medical Evaluation',34)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',34)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',34)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',34)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',34)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',34)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',34)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',34)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',34)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',34)

Delete From IPPaymentsRoleMapping Where Roleid IN (212,222,215)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,212)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,212)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,212)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,212)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,212)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,222)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,222)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,229)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,229)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,229)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,229)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,229)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,212)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,215)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,220)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,220)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,220)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,220)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,220)
INSERT INTO IPPaymentsRoleMapping  VALUES(11,220)



GO


DELETE FROM SurgeryType WHERE OrgID = 34
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',34)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',34)
GO

/* OperationType */
DELETE FROM OperationType WHERE OrgID = 34
insert into OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',34)
insert into OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',34)
GO

delete  from InvStatusmapping where OrgID =34
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,34,3)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,34,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,34,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,34,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,34,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,34,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,34,2)
GO

DELETE FROM FeeTypeConfig WHERE OrgID = 34
INSERT INTO FeeTypeConfig (Feetype, UseEdit, OrgID) VALUES ('CON', 'Y', 34)
GO





insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(1,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(2,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(3,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(4,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(5,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(6,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(7,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(8,34,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(9,34,0.00)

insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,1,34)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,2,34)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(4,6,34)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,7,34)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 34

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 34, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 34, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 34, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 34, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 34, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 34, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 34, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 34, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 34, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 34, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 34, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 34, 'IP')
GO



Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(38,1,'Receipt',34,34)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(39,2,'Voucher',34,34)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(40,3,'OPBill',34,34)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(41,4,'IPBill',34,34)


Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',38)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',39)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',40)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',41)

----------------------Header Font 
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',38)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',39)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',40)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',41)

----------------------Header Font Size
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',38)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',39)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',40)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',41)

----------------------Header Content

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','ATTUNE',38)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','ATTUNE',39)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','ATTUNE',40)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','ATTUNE',41)

---------------------- Contents Font

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',38)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',39)                                                                           
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',40)                                                                       
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',41)


---------------------- Contents Font Size

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',38)                                                                                
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',39)                                                                                  
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',40)                                                                                   
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',41)


---------------------- Border Style

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',38)                                                              
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',39)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',40)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',41)


---------------------- Border Width

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','75%',38)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1'  ,39)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1'  ,40)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1'  ,41)

 