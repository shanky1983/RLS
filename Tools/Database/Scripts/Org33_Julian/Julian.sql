delete From Organization where OrgID =33
Insert into Organization(OrgID,Name, OrganizationTypeID, AddressID, LogoPath)values(33,'Julian Nursing Home',1,  0,'')

delete from OrganizationAddress where OrgID = 33
Insert into OrganizationAddress (AddressID,OrgID,AddressType,Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) 
Values(33,33,'','',', ',' ,','',0,'Chennai',0,'','','','Chennai')

/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=33
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN,RateTypeId,RateId)VALUES(2250,33,'GENERAL',1,NULL,'Y',1,2250)

Delete from  RateMaster where OrgID=33
insert into RateMaster(RateId,RateName,RateTypeId,Discount,Status,orgid)values(2250,'GENERAL',1,0.00,'Y',33)

delete From Login where OrgID =33
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(1897,'Julian1897','Julian','N',33,  'A')

insert into IDMaster (OrgID,PatientNumber ,BillNumber ,IPNumber ,VisitNumber )values(33,0,0,0,0)

----/* Users */
delete From Users where OrgID =33
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('Julian','M','1',33,1897)

----/* LoginRole  */
Insert Into LoginRole(RoleID,LoginID)values(203,1897)

/* Role */
delete From Role where OrgID =33
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(198,'Physician','Doctor',  0,33)--185
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(199,'Nurse','Nurse',  0,33)--186
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(200,'LabTech','Lab Technician',  0,33)--187
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(201,'Patient','Patient',  0,33)--188
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(202,'Reception','Reception',  0,33)--189
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(203,'Admin','Admin',  0,33)--190
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(204,'DialysisTech','Dialysis Technician',  0,33)--191
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(205,'Billing','Billing',  0,33)--192
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(206,'Xray','Xray',  0,33)--193
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(207,'Accounts','Accounts',  0,33)--194
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(208,'Pharmacist','Pharmacist',  0,33)--195
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(209,'Wardsecretary','Wardsecretary',  0,33)--196
INSERT INTO Role(RoleID,RoleName,Description,ParentID,OrgID) VALUES (210, 'Cashier', 'Cashier', 0,33)--197
																	 
																	 
																	 
																	 
/* MENU MASTer  */													 
DELETE FROM MenuMaster where OrgId=33								 
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2187,'Patient Search',0,33,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2188,'Patient Search',0,33,11)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2189,'Patient Search',0,33,12)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2190,'Patient Registration',0,33,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2191,'Home',0,33,8)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2192,'Home',0,33,9)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2193,'Home',0,33,1)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2194,'Home',0,33,14)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2195,'Reports',0,33,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2196,'Set Reminders',0,33,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2197,'Doctor Schedule',7,33,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2198,'Home',0,33,13)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2199,'Home',0,33,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2200,'Investigation Report',0,33,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2201,'Home',0,33,27)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2202,'View Schedules',7,33,37)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2203,'Today''s OP Visits',0,33,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2204,'BillSearch',0,33,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2205,'Cash Closure',0,33,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2206,'Cash Closure',0,33,48)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2207,'Patient Management',1,33,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2208,'View Room Details',1,33,54)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2209,'Visit Search',0,33,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2210,'Manage Rates',2,33,59)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2211,'Add Investigation/Groups',2,33,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2212,'Reference Range Mgmt',2,33,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2213,'Manage User',2,33,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2214,'Patient Search',0,33,10)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2215,'Cash OutFlow',0,33,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2216,'Check Safety Code',0,33,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2217,'Add Corporate & Client',2,33,72)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2218,'Task ReAssign',0,33,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2219,'Dashboard',0,33,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2220,'Settlement',1,33,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2221,'Billing',1,33,79)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2222,'Plan Vacation',7,33,83)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2223,'Purchase Order',3,33,93)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2224,'Stock Receive',3,33,94)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2225,'Stock Return',3,33,95)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2226,'Stock Damage',3,33,96)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2227,'Inventory Search',3,33,97)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2228,'Categories',3,33,102)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2229,'Products',3,33,103)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2230,'Suppliers',3,33,104)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2231,'Stock Issued',3,33,116)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2232,'Stock In Hand',3,33,107)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2233,'OP Billing',0,33,108)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2234,'IP Billing',0,33,113)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2235,'Bulkload',3,33,114)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2236,'Reorder Level',3,33,115)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2237,'Stock Report',3,33,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2238,'All Schedules',7,33,120)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2239,'In Bound Referral',8,33,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2240,'Out Bound Referral',8,33,138)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2241,'Summary Reports',0,33,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2242,'Manage Test Kit',2,33,144)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2243,'Manage Test Method',2,33,145)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2244,'Manage Test Principle',2,33,237)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2245,'Manage Test Instrument',2,33,143)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2246,'Lab User Wise Daily Report',20,33,35)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2247,'Lab Summary Reports',20,33,36)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2248,'Manage Package',2,33,252)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2249,'ChangePassword',0,33,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2250,'Home',0,33,293) -- Cashier Home Page
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)VALUES(2251,'Help Video',21,33,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2252,'Surgery Package',2,33,298)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2253,'Manage RateType',2,33,337)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2254,'ManageSequence No',2,33,269)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2255,'Cash Payment',0,33,67)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2256,'ReceiptSearch',0,33,297)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2257,'TPASearch',1,33,268)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)values(2258,'Voucher Search',0,33,342)
																		
delete  from RoleMenu where RoleID in(198,199,200,201,202,203,204,205,206,207,208,209,210)
--Admin																	
																		 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,203)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2195,203)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2194,203)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2196,203)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2197,203)					
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2202,203)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2224,203)					 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2205,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2204,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2210,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2211,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2212,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2213,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2217,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2218,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2219,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2220,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2208,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2221,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2242,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2243,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2244,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2245,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2248,203)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2214,203)
insert into RoleMenu (MenuID,RoleID)values(2252,203)
insert into RoleMenu (MenuID,RoleID)values(2253,203)
insert into RoleMenu (MenuID,RoleID)values(2254,203)
insert into RoleMenu (MenuID,RoleID)values(2255,203)
insert into RoleMenu (MenuID,RoleID)values(2256,203)
insert into RoleMenu (MenuID,RoleID)values(2257,203)
insert into RoleMenu (MenuID,RoleID)values(2222,203)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1817,151)
--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1818,151)
---Reception							 
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2204,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2206,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2215,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2193,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2187,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2203,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2209,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2190,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2202,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2207,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2220,202)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2221,202)
insert into RoleMenu (MenuID,RoleID)values(2258,202)
insert into RoleMenu (MenuID,RoleID)values(2257,202)
insert into RoleMenu (MenuID,RoleID)values(2256,202)
insert into RoleMenu (MenuID,RoleID)values(2200,202)



--INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1959,163)
												
---Physician									
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2192,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2200,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2197,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2203,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2209,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2202,198)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2207,198)
												
--Lab											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2198,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2200,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2214,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2211,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2217,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2212,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2242,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2243,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2244,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2245,200)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2248,200)
												
												
--Nurse											
												
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,199)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2191,199)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2188,199)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2203,199)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2207,199)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2221,199)

												
--Dial											
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2201,204)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,204)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2214,204)
---Accounts
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2205,207)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2249,207)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2195,207)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(2215,207)
insert into RoleMenu (MenuID,RoleID)values(2221,207)
Insert into RoleMenu (MenuID,RoleID)values(2226,207)
Insert into RoleMenu (MenuID,RoleID)values(2241,207)


--video---
 insert into RoleMenu (MenuID,RoleID)values(2251,197)
 insert into RoleMenu (MenuID,RoleID)values(2251,198)
 insert into RoleMenu (MenuID,RoleID)values(2251,199)
 insert into RoleMenu (MenuID,RoleID)values(2251,200)
 insert into RoleMenu (MenuID,RoleID)values(2251,201)
 insert into RoleMenu (MenuID,RoleID)values(2251,202)
 insert into RoleMenu (MenuID,RoleID)values(2251,203)
 insert into RoleMenu (MenuID,RoleID)values(2251,204)
 insert into RoleMenu (MenuID,RoleID)values(2251,205)
 insert into RoleMenu (MenuID,RoleID)values(2251,206)
 insert into RoleMenu (MenuID,RoleID)values(2251,207)
 insert into RoleMenu (MenuID,RoleID)values(2251,208)
												 
												 
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (1211974, 148)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2212021, 1616)
--INSERT INTO RoleMenu (MenuID, RoleID) VALUES (2020, 1616)
																		 
/* PageMapping  */
delete from PageMapping where RoleId in(198,199,200,202,203,204,205,206,207,208,210)
Insert into PageMapping(RoleId,PageID,SeqNo) values(198,9,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(199,8,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(200,13,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(202,1,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(203,14,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(204,27,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(205,13,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(206,8,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(207,256,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(208,112,1)
INSERT INTO PageMapping(RoleId,PageID,SeqNo) VALUES(210,293,1)
/* OrgUOMVitalsMapping  */		
					                  
												           
--OrgUOMVitalsID--identity--						
delete from OrgUOMVitalsMapping where OrgID = 33 	
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(184,33,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(185,33,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(186,33,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(187,33,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(188,33,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(189,33,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(190,33,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(191,33,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(192,33,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(193,33,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(194,33,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(195,33,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(196,33,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(197,33,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(198,33,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(199,33,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(200,33,12,17)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)Values(201,33,53,18)
																		   
																			  
/* ProcedureMaster  */													 
----ProcedureID--identity
delete from ProcedureMaster where OrgID =33
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,ProcedureDesc,OrgID,IsAVisitPurpose,CreatedBy,CreatedAt)values(27,'Dialysis','Treatment','Dialysis',33,  'y',1, 'Sep  2 2009 12:00AM')--24
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,ProcedureDesc,OrgID,IsAVisitPurpose,CreatedBy,CreatedAt)values(28,'Physiotherapy','Treatment','Physiotherapy',33,  'y',1, 'Feb  27 2010 12:00AM')--25
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,ProcedureDesc,OrgID,IsAVisitPurpose,CreatedBy,CreatedAt)values(29,'Others','Treatment','Others',33,  'y',1, 'Feb  27 2010 12:00AM')--26

/*  OrganizationAddress  */

/* StandardDeduction manually increase the standard deduction id as(StdDedID + 1)*/
delete from StandardDeduction where OrgID=33
Insert into StandardDeduction(StdDedID,OrgID,StdDedName,StdDedValue,StdDedType)values(117,33,'Self Employee',2,'P')--115
Insert into StandardDeduction(StdDedID,OrgID,StdDedName,StdDedValue,StdDedType)values(118,33,'Govt Employee',100,'V')--116

--/* ProcedureFee  */

--Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(12,600,'Dialysis',  'Y', 1701, 26)
DELETE FROM ProcedureFee WHERE ProcedureID IN(27,28,29)

Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,40,'Wax Bath (U/L)','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,60,'Wax Bath (B/L)','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,40,'IFT(U/L)','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,50,'US(U/L)','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,60,'US(B/L)','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,50,'Exercise','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(28,60,'Stimulation','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(29,0,'Others','Y',2250,33)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)values(27,600,'Dialysis','Y',2250,33)

/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =33
---speciality mapping---
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,3,0,9) 

----procedure Task Mapping
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,7,27,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,7,28,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,7,29,6)
------
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,15,11) 
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)VALUES(33,4,0,38)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,7,5,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,1,16,32)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,11,0,35)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)values(33,9,0,36) 

/*  Config  */
delete from Config where OrgID=33
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('INV','Before',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('CON','Before',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('PRO','Before',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('ISI','0.4',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('PHYSIO','Before',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('ReportServerURL','http://attune3/Reports',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('UseSmartCardForPatient','N',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('UseOrgBasedDrugData','Y',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('IsReceptionCashier','N',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('SystemAuthorization','N',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('IMU','After',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('Currency','Rs',  0,33)
Insert into config(ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('UseInvDrugData','N',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,33)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('IsAmountEditable','N',  0,33)
INSERT INTO Config(ConfigKey,ConfigValue,ParentID,OrgID)VALUES('NeedIPNumber', 'N', 0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('IPMakePayment','Y',0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('DisplayCurrencyFormat','Rupees',0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('NO','YES',0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('PrintReceipt','YES',0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('ShowDisclaimer','NO',0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('HEALTHPKG','After',0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('ScheduleDuration',7,0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('ScheduleDuration',7,0,33)
insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)values('ShowUnbilled','N',0,33)
GO

/*  BillSearchActions  */
delete from BillSearchActions where RoleID in(202,203,209,207)
Insert into BillSearchActions(ActionName,RoleID,PageID)Values('Print Bill',202,28)
Insert into BillSearchActions(ActionName,RoleID,PageID)Values('Refund / Cancel',203,47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID)VALUES('Print Bill',209,28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID)VALUES('Print Bill', 207, 28)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID)VALUES('Refund',207,47)
INSERT INTO BillSearchActions(ActionName,RoleID,PageID)VALUES('Cancel Bill',207,47)
GO

delete from OrganizationSpeciality where OrgID =33
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,1,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,2,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,3,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,4,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,5,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,6,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,7,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,8,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,9,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,10,0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,11,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,12,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,13,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,14,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,15,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,16,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,17,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,18,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,19,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,20,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,22,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,23,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,24,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,25,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,26,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,27,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,28,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,29,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,30,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,31,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,32,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,33,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,35,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,36,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,37,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,38,0)  
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)values(33,39,0)  
																				   

/*  TaskEscalation  */
delete from TaskEscalation where OrgID =33

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0 ,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0 ,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0 ,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0 ,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,202,33,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,202,33,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID =33
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,199,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,199,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,199,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,204,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,204,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,204,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,200,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,198,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,198,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,198,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,198,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,198,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,200,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,200,33)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,167,  30)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,206,33)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,163,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,199,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,198,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,202,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,199,33)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,202,33)
INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  VALUES(38,198,33)

/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=33
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,33)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,33)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,33)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,33)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,33)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,33)
INSERT INTO VisitPurposeOrgMapping(VisitPurposeID,OrgID)  VALUES(4,33)

/* InvestigationOrgSampleStatus	*/

INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (33, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (33, 'SampleReceived', 2)



DELETE FROM ReportOrgMapping WHERE OrgID = 33

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,203,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,203,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,203,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,202,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,203,33)

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,207,33)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,207,33)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,203,33)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,203,33)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,203,33)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,203,33)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,203,33)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(21,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(22,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(23,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)Values(24,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(25,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(31,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(32,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(33,203,33)
Insert into ReportOrgMapping(ReportID,RoleID, OrgID)values(34,203,33)

GO

DELETE FROM CashExpenseMaster WHERE OrgID =33
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',33,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',33,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',33,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',33,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',33,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',33,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',33,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 33
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,33)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,33)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,33)
GO



--


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 202,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 202,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 203,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 203,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 202,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 199,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 202,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 202,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 203,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 202,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 202,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 202,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 200,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 202, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 199, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 199, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 204, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 204,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 198,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 199,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 202,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 199,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 198,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 202,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 199,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 198,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 200,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 202,	2, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 202,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 203,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 202,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 198,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 199,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 202,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 202,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 199,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 202,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 198,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 199,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 202,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 202,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 202,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 202,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 160,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 202,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 200,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 202,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 202,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 202,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 202,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 202,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 202,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 202,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 202,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 202,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 198,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 199,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 202,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 202,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 202,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 163,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 202,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 202,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 202,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 202,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 203,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 198,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 202,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 200,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 200,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 202,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 202,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 203,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 203,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 203,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 203,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 203,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 203,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 203,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 208,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 208,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 208,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 208,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 208,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 202,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 198,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 202, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 200, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 202, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 199,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 202,	161,10)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 204, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 204,	23,11)

--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 163, 161, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,198,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,198,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,202,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,202,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,202,6,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,199,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(3,209,54,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,209,6,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,209,6,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(13,209,81,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,209,58,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(18,209,39,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(25,209,71,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(26,209,52,5)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(30,209,82,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(37,209,118,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(11,209,6,12)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(14,209,58,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,209,28,11)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,209,28,13)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES(34,209,28,19)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (64,202,255,10)
INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) VALUES (66,202,255,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(71,203,278,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(71,203,278,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(72,203,279,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES(72,202,279,12)
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID)values(26,207,52,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75,203,56,5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63,199,254,19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (63,200,254,19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81,202,297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (81,209,297,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73,202,280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74,202,281,13)


GO
-----------

DELETE FROM PageActionMapping WHERE OwnerOrgID =33

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,33,33)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (64,33,33)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID =33
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',33)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',33)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',33)
GO

DELETE FROM InvKitMaster WHERE OrgID =33
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' ,33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',33)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',33)
GO

DELETE FROM InvestigationMethod WHERE OrgID =33
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',33)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',33)

GO

DELETE FROM InvResultTemplate WHERE OrgID =33

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',33)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',33)
INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 33)
INSERT INTO InvResultTemplate(ResultID,ResultName,ResultTemplateType,ResultValues,OrgID)VALUES (44,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.',33)

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID =33
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',33)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',33)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',33)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',26)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',26)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',33)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID =33
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',33)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',33)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',33)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',33)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',33)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(33,33,1)


insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(51,'Medical Management',33)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(52,'Surgery',33)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(53,'Emergency Care',33)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(54,'Intervention',33)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(55,'Medical Evaluation',33)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',33)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',33)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',33)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',33)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',33)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',33)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',33)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',33)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',33)

Delete From IPPaymentsRoleMapping Where Roleid IN (199,209,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,199)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,199)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,199)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,199)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,199)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,202)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,202)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,209)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,209)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,209)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,209)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,209)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,199)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,202)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,207)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,207)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,207)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,207)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,207)
INSERT INTO IPPaymentsRoleMapping  VALUES(11,207)



GO


DELETE FROM SurgeryType WHERE OrgID = 33
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(1,'Elective',33)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID) values(2,'Emergency',33)
GO

/* OperationType */
DELETE FROM OperationType WHERE OrgID = 33
insert into OperationType(OperationTypeID,TypeName,OrgID) values(1,'Major',33)
insert into OperationType(OperationTypeID,TypeName,OrgID) values(2,'Minor',33)
GO

delete  from InvStatusmapping where OrgID =33
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,2,33,3)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,3,33,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(6,4,33,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,3,33,2)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(2,5,33,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,2,33,1)
insert into InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo )values(4,3,33,2)
GO

DELETE FROM FeeTypeConfig WHERE OrgID = 33
INSERT INTO FeeTypeConfig (Feetype, UseEdit, OrgID) VALUES ('CON', 'Y', 33)
GO





insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(1,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(2,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(3,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(4,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(5,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(6,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(7,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(8,33,0.00)
insert into PaymentTypeOrgMapping (PaymentTypeID,OrgID,ServiceCharge)values(9,33,0.00)

insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,1,33)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,2,33)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(4,6,33)
insert into PatDtlsVPActionMapping(VisitPurposeID,VPActionID,OrgID)values(1,7,33)

DELETE FROM FeeTypeOrgMapping WHERE OrgID = 33

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 33, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 33, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 33, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 33, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 33, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 33, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 33, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 33, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 30, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 33, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 33, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 33, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 33, 'IP')
GO



Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(29,1,'Receipt',33,33)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(30,2,'Voucher',33,33)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(31,3,'OPBill',33,33)
Insert into BilltypeMaster (BillTypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)Values(32,4,'IPBill',33,33)


Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',29)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',30)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',31)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Logo','',32)

----------------------Header Font 
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',29)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',30)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',31)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font','Verdana',32)

----------------------Header Font Size
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',29)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',30)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',31)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Font Size','14px',32)

----------------------Header Content

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Julian Nursing Home',29)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Julian Nursing Home',30)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Julian Nursing Home',31)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Header Content','Julian Nursing Home',32)

---------------------- Contents Font

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',29)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',30)                                                                           
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',31)                                                                       
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font','Verdana',32)


---------------------- Contents Font Size

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',29)                                                                                
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',30)                                                                                  
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',31)                                                                                   
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Contents Font Size','10px',32)


---------------------- Border Style

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',29)                                                              
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',30)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',31)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Style','solid',32)


---------------------- Border Width

Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','75%',29)                                                                        
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1',30)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1',31)
Insert into BillConfig (ConfigKey,ConfigValue,BillTypeID)Values('Border Width','1',32)

 