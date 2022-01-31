/* Login  */
delete From Login where OrgID ='13'
Insert into Login(loginID,LoginName,Password,  IsLocked,OrgID,Status)values(326,'Sowmya326','Sowmya','N',13,  'A')



/* Organization */
delete From Organization where OrgID ='13'
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID,LogoPath)   values(13,'GS Hospital',1,  0,'')

/* Users */
delete From Users where OrgID ='13'
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID)  values('Sowmya','F','2',   13,326)



/* Nurse  */

/* Role */
delete From Role where OrgID ='13'
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(123,'Physician','Doctor',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(124,'Nurse','Nurse',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(125,'LabTech','Lab Technician',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(126,'Patient','Patient',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(127,'Reception','Reception',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(128,'Admin','Admin',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(129,'DialysisTech','Dialysis Technician',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(130,'Billing','Billing',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(131,'Xray','Xray',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(132,'Accounts','Accounts',  0,13)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID)  Values(133,'Pharmacist','Pharmacist',  0,13)



/* LoginRole  */
delete From LoginRole where LoginID IN (326 )

Insert Into LoginRole(RoleID,LoginID)values(128,326)



/* Role Menu */
--Delete from RoleMenu WHERE MenuID IN (329,322,319,326,331,329,321,318,329,328,323,320,435,329,329,325,442,326,327,329,332,346,346,346,362, 363, 364)


INSERT INTO RoleMenu (MenuID,RoleID) values(447,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(443,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(442,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(444,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(445,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(451,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(464,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(454,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(453,128)





INSERT INTO RoleMenu (MenuID,RoleID) values(459,128)


INSERT INTO RoleMenu (MenuID,RoleID) values(460,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(461,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(462,128)
INSERT INTO RoleMenu (MenuID,RoleID) values(445,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(496,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(497,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(498,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(499,128)



INSERT INTO RoleMenu (MenuID,RoleID)VALUES(466,128)

INSERT INTO RoleMenu (MenuID,RoleID)   values(467,128)

INSERT INTO RoleMenu (MenuID,RoleID)   values(468,128)





INSERT INTO RoleMenu (MenuID,RoleID) VALUES(453,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(455,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(464,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(447,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(441,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(449,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(435,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(452,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(458,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(438,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(451,127)
INSERT INTO RoleMenu (MenuID,RoleID) values(445,127)



delete from RoleMenu where MenuID =455 and RoleID =123

INSERT INTO RoleMenu (MenuID,RoleID) VALUES(453,123)
--INSERT INTO RoleMenu (MenuID,RoleID) values(455,123)
--INSERT INTO RoleMenu (MenuID,RoleID) values(464,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(447,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(440,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(449,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(437,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(452,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(458,123)
INSERT INTO RoleMenu (MenuID,RoleID) values(451,123)

----
INSERT INTO RoleMenu (MenuID,RoleID) VALUES(447,125)
INSERT INTO RoleMenu (MenuID,RoleID) values(446,125)
INSERT INTO RoleMenu (MenuID,RoleID) values(449,125)
INSERT INTO RoleMenu (MenuID,RoleID) values(463,125)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(496,125)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(497,125)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(498,125)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(499,125)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(460,125)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(461,125)

----
INSERT INTO RoleMenu (MenuID,RoleID) VALUES(447,124)
INSERT INTO RoleMenu (MenuID,RoleID) values(439,124)
INSERT INTO RoleMenu (MenuID,RoleID) values(436,124)
INSERT INTO RoleMenu (MenuID,RoleID) values(452,124)

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1632,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1633,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1634,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1635,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1636,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1637,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1638,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1639,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1640,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1641,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1642,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1643,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1644,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1645,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1646,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1647,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1648,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1649,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1650,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1651,133)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1666,133)


INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1652,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1653,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1654,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1655,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1656,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1657,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1658,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1659,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1660,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1661,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1662,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1663,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1664,128)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(1665,128)


INSERT INTO RoleMenu (MenuID,RoleID)VALUES(443,132)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(454,132)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(464,132)

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(450,129)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(447,129)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(463,129)





/* MENU MASTer  */
DELETE FROM MenuMaster where OrgId=13
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(435,'Patient Search',0,13,10)--317--r
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(436,'Patient Search',0,13,11)--n
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(437,'Patient Search',0,13,12)---phy
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(438,'Patient Registration',0,13,2)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(439,'Home',0,13,8)--N
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(440,'Home',0,13,9)--p
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(441,'Home',0,13,1)--R
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(442,'Home',0,13,14)--ad
--INSERT INTo MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(325,'Reports',0,13,15)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(443,'Reports',0,13,43)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(444,'Set Reminders',0,13,16)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(445,'Doctor Schedule',7,13,17)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(446,'Home',0,13,13)--lab
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(447,'Change Password',0,13,20)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(448,'Home',0,13,25)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(449,'Investigation Report',0,13,55)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(450,'Home',0,13,27)---332--dial


INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(451,'View Schedules',7,13,37)--346
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(452,'Today''s OP Visits',0,13,40)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(453,'BillSearch',0,13,226)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(454,'Cash Closure',0,13,46)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(455,'Cash Closure',0,13,48)--354


INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(456,'Patient Management',1,13,49)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(457,'View Room Details',1,13,54)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(458,'Visit Search',0,13,18)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(459,'Manage Rates',2,13,59)

--INSERT INTo MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(363,'Purchase Order',3,13,62)
--INSERT INTo MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(364,'Receive Stock',3,13,63)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(460,'Add Investigation/Groups',2,13,60)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(461,'Reference Range Mgmt',2,13,61)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(462,'Manage User',2,13,64)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(463,'Patient Search',0,13,10)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(464,'Cash OutFlow',0,13,67)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(465,'Check Safety Code',0,13,69)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES (466,'Add Corporate & Client',2,13,72)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(467,'Task ReAssign',0,13,75)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(468,'Dashboard',0,13,77)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(469,'Settlement',1,13,78)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(470,'Billing',1,13,79)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(471,'Plan Vacation',7,13,83)
 
 
 
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(472,'Purchase Order',3,13,93)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(473,'Stock Receive',3,13,94)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(478,'Stock Return',3,13,95)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(479,'Stock Damage',3,13,96)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(480,'Inventory Search',3,13,97)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(481,'Categories',3,13,102)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(482,'Products',3,13,103)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(483,'Suppliers',3,13,104)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(484,'Stock Issued',3,13,116)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(485,'Stock In Hand',3,13,107)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(486,'OP Billing',0,13,108)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(487,'IP Billing',0,13,113)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(488,'Bulkload',3,13,114)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(489,'Reorder Level',3,13,115)

Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(490,'Stock Report',3,13,117)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(491,'All Schedules',7,13,120)

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(492,'In Bound Referral',8,13,126)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(493,'Out Bound Referral',8,13,127)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  VALUES(494,'Summary Reports',0,13,36)
INSERT INTO MenuMaster (MenuID,DisplayText,Parentid,OrgId,PageID) values(495,'Stock Details',3,	12,	236)


Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(496,'Manage Test Kit',2,13,144)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(497,'Manage Test Method',2,13,145)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(498,'Manage Test Principle',2,13,237)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(499,'Manage Test Instrument',2,13,143)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1632,'Purchase Order',3,13,93)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1633,'Stock Receive',3,13,94)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1634,'Stock Return',3,13,95)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1635,'Stock Damage',3,13,96)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1636,'Inventory Search',3,13,97)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1637,'Reorder level',3,13,107)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1638,'OP Billing',0,13,108)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1639,'IP Billing',0,13,113)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1640,'Stock Report',3,13,117)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1641,'Categories',3,13,102)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1642,'Products',3,13,103)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1643,'Suppliers',3,13,104)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1644,'Update Reorderlevel',3,13,115)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1645,'ScheduleDrugReport',3,13,230)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1646,'Cash Closure',0,13,48)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1647,'Cash Payments',0,13,67)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1648,'Change Password',0,13,20)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1649,'Stock Details',3,13,236)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1650,'Bill Search',0,13,238)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1651,'Home',0,13,112)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1666,'Inventory Mgmt',3,13,231)

INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1652,'Purchase Order',3,13,93)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1553,'Stock Receive',3,13,94)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1654,'Stock Return',3,13,95)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1655,'Stock Damage',3,13,96)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1656,'Inventory Search',3,13,97)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1657,'Categories',3,13,102)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1658,'Products',3,13,103)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1659,'Suppliers',3,13,104)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1660,'Reorder level',3,13,107)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1661,'Stock Report',3,13,117)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1662,'Update Reorderlevel',3,13,115)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1663,'ScheduleDrugReport',3,13,230)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1664,'ScheduleDrugReport',3,13,230)
INSERT INTO menumaster  (MenuID,DisplayText,Parentid,OrgId,PageID) VALUES (1665,'Dispensing Report',3,13,239)
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)  values(1824,'Manage Package',2,13,252)


/* PageMapping  */
delete from PageMapping where RoleId IN(123,124,125,127,128,129,131)
Insert into PageMapping(RoleId,PageID,SeqNo) values(123,9,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(124,8,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(125,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(127,1,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(128,14,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(129,27,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(131,13,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(122,112,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(133,112,  1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(132,188,  1)




/* OrgUOMVitalsMapping  */

delete from OrgUOMVitalsMapping where OrgID = 13
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(52,13,8,1)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(53,13,2,2)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(54,13,2,3)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(55,13,3,4)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(56,13,4,5)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(57,13,5,6)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(58,13,6,7)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(59,13,7,8)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(60,13,8,9)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(61,13,2,10)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(62,13,2,11)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(63,13,2,12)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(64,13,2,13)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(65,13,9,14)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(66,13,9,15)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(67,13,7,16)
Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(68,13,12,17)

Insert into OrgUOMVitalsMapping(OrgUOMVitalsID,OrgID,UOMID,VitalsID)   Values(69,13,53,18)

/* ProcedureMaster  */
delete from ProcedureMaster where OrgID =13
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(4,  'Dialysis','Treatment','Dialysis',13,  'y',1, 'Sep  2 2009 12:00AM')

Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(5,  'Physiotherapy','Treatment','Physiotherapy',13,  'y',1, 'Sep  2 2009 12:00AM')
Insert into ProcedureMaster(ProcedureID,Procedurename,ProcedureType,  ProcedureDesc, OrgID, IsAVisitPurpose, CreatedBy,CreatedAt) values(8,  'Others','Treatment','Others',13,  'y',1, 'Aug  31 2009 12:00AM')




/*  OrganizationAddress  */
delete from OrganizationAddress where OrgID = 13
Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) Values(24,13,'A','#466,3rd Avenue,Indira Nagar','','','600041',0,'Chennai',0,'','044124411819','','IndiraNagar')



/* StandardDeduction  */
delete from StandardDeduction where OrgID=13
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(105,13,  'Self Employee', 2,'P')
Insert into StandardDeduction(StdDedID,OrgID,  StdDedName,StdDedValue,StdDedType)  values(106,13,  'Govt Employee', 100,'V')



/*  TaskActionMapping  */
delete from TaskActionMapping where OrgID =13
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  1,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  8,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  9,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  17,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  18,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  6,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  5,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  19,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  20,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  21,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  4,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  10,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  14,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  3,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  22,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  11,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  7,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  23,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  24,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  25,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  2,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,7,  4,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,3,  0,9) 

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1, 13,11)

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  26,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  13,11)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  15,11) 
INSERT INTO TaskActionMapping (OrgID, VisitPurposeID, OtherID, TaskActionID) VALUES (13, 4, 0, 38)
GO

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,7,  5,6)
--Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(12,9,0,21)

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  16,33)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  16,32)
--Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(12,1,  16,34)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,11,  0,35)

Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,9,  0,36) 
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,7,  9,6)-----
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,7,  10,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,7,  11,6)
Insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID)  values(13,1,  30,11)
/*  Config  */
delete from Config where OrgID=13
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('INV','Before',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('CON','Before',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PRO','Before',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ISI','0.4',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('PHYSIO','Before',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('ReportServerURL','http://attune3/Reports',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseSmartCardForPatient','N',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','Y',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('InvestigationReportPath','/InvestigationReport/InvValuesForHospital',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsReceptionCashier','N',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('SystemAuthorization','N',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IMU','After',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('Currency','Rs',  0,13)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseInvDrugData','N',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('IsAmountEditable','N',  0,13)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UploadPath','\\\\\\attune1\\Imageupload\\Org12\\',  0,13)
INSERT INTO Config (ConfigKey, ConfigValue, ParentID, OrgID) VALUES ('NeedIPNumber', 'N', 0, 13)
INSERT INTO Config (ConfigKey, ConfigValue, ParentID, OrgID) VALUES ('IPMakePayment', 'Y', 0, 13)
GO

/*  BillSearchActions  */
DELETE FROM BillSearchActions WHERE ROLEID IN(13,14)
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Print Bill',127,28)
--Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Order services',115,41)
Insert into BillSearchActions(ActionName,RoleID,PageID)  Values('Refund / Cancel',128,47)
GO



delete from OrganizationSpeciality where OrgID = 13
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,1,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,8,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,9,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,17,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,18,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,6,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,15,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,19,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,20,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,21,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,4,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,10,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,14,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,3,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,22,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,11,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,7,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,23,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,24,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,25,  0)

Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,28,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,29,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,30,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,31,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,13,  0)
Insert into OrganizationSpeciality(OrgID,SpecialityID,Amount)   values(13,12,  0)


/*  TaskEscalation  */
delete from TaskEscalation where OrgID = 13
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(6,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(7,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(8,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(9,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(10,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(11,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(13,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(14,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(15,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(16,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(17,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(18,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(19,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(20,0,128,13,30)

Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(32,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(33,0,128,13,30)
Insert into TaskEscalation(TaskActionID,EscalateToUserID,EscalateToRoleID,  OrgID,AllowedElaspsedTime) values(34,0,128,13,30)

/*  TaskActionOrgMapping  */
delete from TaskActionOrgMapping where OrgID = 13
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(1,112,  12)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(2,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(3,124,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(4,124,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(5,124,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(6,129,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(7,129,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(8,129,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(9,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(10,125,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(11,123,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(12,123,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(13,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(14,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(15,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,125,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(17,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(18,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(19,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(20,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,125,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(22,131,  13)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(16,119,  13)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,127,12)
--Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(21,116,12)

Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(32,124,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(33,123,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(34,127,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(35,124,  13)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID)  Values(36,127,  13)
INSERT INTO TaskActionOrgMapping (TaskActionID, RoleID, OrgID) VALUES (38, 123, 13)
INSERT INTO TaskActionOrgMapping (TaskActionID, RoleID, OrgID) VALUES (40, 128, 13)

/*   VisitPurposeOrgMapping  */
delete from VisitPurposeOrgMapping where OrgID=13	
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(1,13)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,13)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,13)

Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(9,13)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(11,13)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(13,13)
INSERT INTO VisitPurposeOrgMapping (VisitPurposeID, OrgID) VALUES (4, 13)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(6,13)
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(7,13)


/*	invdeptmaster	*/
DELETE FROM InvDeptMaster where OrgID=13
INSERT INTO invdeptmaster(Deptid,deptname,orgid)  VALUES(171,'Lab',13)
INSERT INTO InvDeptMaster(DeptID,DeptName,OrgID) VALUES (172,'Pharmacy',13)
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (173,'BioChemistry',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (174,'Clinical Pathology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (175,'Hematology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (176,'HistoPathology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (177,'MicroBiology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (178,'Imaging',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (179,'X-Ray',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (180,'CT',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (181,'MRI',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (182,'USG',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (183,'ECG',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (184,'Endoscopy',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (185,'Immunology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (186,'Cytogenetics',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (187,'Cytology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (188,'Biochemistry and ClinicalPathology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (189,'Biochemistry, Clinical Pathology and Microbiology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (229,'Molecular Biology',13,'Y')
INSERT INTO InvDeptMaster (DeptID,DeptName,OrgID,Display) VALUES (230,'CollectionDesk',13,'N')

/*	RoleDeptMap	*/
DELETE FROM RoleDeptMap where RoleID IN (125)
Insert into RoleDeptMap(RoleID,DeptID)  values(125,171)
Insert into RoleDeptMap(RoleID,DeptID)  values(131,173)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,173)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,174)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,175)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,176)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,177)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,178)
INSERT INTO RoleDeptMap (RoleID, DeptID) VALUES (131,179)



/*	investigationstatus	*/
delete from InvestigationStatus where OrgID = 13
insert into investigationstatus(orgid,status)  values(13,'Pending')
insert into investigationstatus(orgid,status)  values(13,'Completed')
insert into investigationstatus(orgid,status)  values(13,'Rejected')



/* InvestigationOrgSampleStatus	*/
delete from InvestigationOrgSampleStatus where OrgID = 13
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (13, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (13, 'SampleReceived', 2)

/*	Prasanna Added	Ends	*/


/*    InvGroupMaster   */
--delete from InvGroupMaster where OrgID = 13
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (601,'Renal function test','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (602,'Liver function test','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (603,'Serum Electrolytes','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (604,'ToRCH Panel','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (605,'Complete Blood Count','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (606,'Coagulation Profile','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (607,'Cardiac enzymes','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (608,'Differential Leukocyte Count','GRP',5,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (609,'Thyroid function test','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (610,'Lipid profile','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (611,'Serology','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (612,'HIV','GRP',11,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (613,'Hepatitis Virus','GRP',11,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (614,'Tumor Markers','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (615,'Urine analysis - Complete','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (616,'Urine analysis - Microscopy','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (617,'24-h Urine analysis','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (618,'Spot Urine analysis','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (619,'Stool analysis - Routine','GRP',NULL,12)
--insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (620,'Semen analysis','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (621,'Ascitic fluid analysis ','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (622,'Widal','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (623,'Macroscopic Semen analysis','GRP',20,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (624,'Microscopic Semen analysis','GRP',20,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (625,'RBC','GRP',5,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (626,'Platelets ','GRP',NULL,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (627,'Motility','GRP',24,12)
----insert  into InvGroupMaster(Groupid,GroupName,Type,parentID,OrgID) values (628,'Peripheral Smear','GRP',NULL,12)

--/*		InvGroupMapMaster		*/
--select * from InvGroupMapMaster
--delete from InvGroupMapMaster where GroupID IN(601,602,603,604,605,625,608,606,607,609,610,612,613,611,614,615,616,617,618,619,621,623,627,624,625,628,620,622, 626, 629, 630, 631,632, 633,634, 635, 636, 637, 638)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1501,3018)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1501,3019)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3032)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3033)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3034)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3040)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3041)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(602,3035)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3037)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3038)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3042)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,3039)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1502,4846)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(602,3043)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(602,3051)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1503,3003)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1503,3004)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1503,3005)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1503,3006)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(603,3007)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(603,3008)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(603,3009)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1004)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1005)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1006)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1007)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1008)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1009)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1010)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(604,1011)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2002)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2014)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(625,2018)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(625,2019)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2012)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2015)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2003)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2013)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,4053)	--LNH	
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2058)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1508,2005)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1508,2006)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1508,2007)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1508,2008)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1508,2009)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1508,2010)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2032)	--LNH	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2033)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2034)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1505,2035)	--LNH
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1506,2043)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1506,2045)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1506,2047)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1506,2054)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1506,2053)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1506,2051)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1507,3046)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(607,3047)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1507,3048)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1507,3049)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1507,3050)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1507,3051)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(609,3079)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(609,3083)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1509,3084)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(609,3081)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1509,3080)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1509,3082)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1510,3053)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1510,3054)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1510,3055)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1510,3056)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1510,3057)	--LNH
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1512,4084)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1512,4085)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1513,4013)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1513,4127)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(613,4129)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4089)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(614,3072)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(614,3073)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(614,3074)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(614,3075)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(614,3124)

----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4003)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4004)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4005)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,4010)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,4011)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,4014)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,4016)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4017)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4018)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4019)

----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4030)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4031)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4028)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4029)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4027)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4026)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(616,4011)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4037)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4038)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4039)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4040)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4015)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(618,4020)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(618,4021)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(618,4022)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(618,4023)
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,3128)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5029)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5030)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5031)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5032)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5033)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5034)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5035)		
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,5036)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3129)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,3130)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3132)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3133)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3135)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3134)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3137)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1519,3131)
	
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4046)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4051)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4052)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4053)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4057)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4058)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4060)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4061)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4062)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4063)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4064)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(621,4065)

--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1521,5021)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1521,5022)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1521,5023)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1521,5024)	--LNH

----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(623,4104)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(623,4105)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(623,4106)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(623,4107)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(623,4108)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(627,4112)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(627,4113)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(627,4114)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(627,4115)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(624,NULL)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(625,2020)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(625,2021)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(625,2022)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2005)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2006)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2007)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2008)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2009)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2010)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(605,2032)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(608,2011)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(608,2012)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2018)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2019)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2024)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2025)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2026)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2028)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2029)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1528,2030)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(606,2015)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(606,2048)
	
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(619,3136)	--LNH
	
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4093)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4127)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4129)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4091)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4089)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4084)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4085)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4828)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4829)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4221)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4222)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1511,4223)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4092)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4091)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4090)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4088)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(611,4087)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4015)	--LNH
	
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4021)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4022)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4023)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4024)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,4007)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4008)	--LNH
	
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4150)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4151)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4152)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4153)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4155)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4156)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(615,4154)	--LNH
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4035)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4036)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4041)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4042)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4043)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(617,4044)
	
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(620,4110)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(620,4116)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,4118)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,4119)	--LNH
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(620,4120)	--LNH
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,4104)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,4105)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,4106)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,4107)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,5040)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,5041)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,5042)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1520,5043)	--LNH	


----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(622,4121)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(622,4122)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(622,4123)
----INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(622,4124)

--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1529,4872)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1529,4873)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1529,4874)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1529,4875)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1529,4876)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1529,5045)	--LNH

--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1530,5021)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1530,5022)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1530,5023)	--LNH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1530,5024)	--LNH
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1531,4878)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1532,5024)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1533,4988)	--KMH

--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,5025)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,5026)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,5027)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1515,5028)	
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4003)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4005)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4004)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4014)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4016)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4018)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4019)
		
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4007)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4010)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,4011)
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,5025)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,5026)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,5027)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,5028)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1534,5044)

--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1535,5021)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1535,5022)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1535,5023)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1535,5024)	--KMH
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1536,5021)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1536,5022)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1536,5023)	--KMH
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1536,5024)	--KMH	
	
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,3128)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5029)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5030)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5031)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5032)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5033)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5034)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5035)		
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,5036)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3129)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,3130)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3132)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3133)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3135)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3134)
--	--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(637,3137)
--	INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,3131)	

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1587,4946)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1587,4944)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1587,4943)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1587,4945)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1587,4769)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1589,4770)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1590,4828)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1590,4829)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1591,2043)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1591,2045)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1592,4873)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1592,4151)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1592,4877) -----------------

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1593,4891)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1593,4892)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1594,5085)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1594,4298)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1595,5059)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1595,5060)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1596,4222)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1596,4223)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1597,5186)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1597,4725)

--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,3131)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,3131)
--INSERT into InvGroupMapMaster(GROUPID,InvestigationID)values(1537,3131)	
	
GO

/*	ComplaintGroupOrgMapping	*/

delete from ComplaintGroupOrgMapping where OrgID = 13
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (1, 1501, 13)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (2, 1502, 13)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (3, 1503, 13)	--LNH
--INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (4, 604, 13)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (5, 1505, 13)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (6, 1506, 13)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (7, 1507, 13)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (8, 1508, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (9, 1509, 13)	
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (10, 1510, 13)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (11, 1511, 13)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (12, 1512, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (13, 1513, 13)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (15, 1515, 13)	--LNH
--INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (16, 616, 13)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (19, 1519, 13)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (20, 1520, 13)	--LNH
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (21, 1521, 13)
--INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (26, 626, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (28, 1528, 13)
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (29, 1529, 13)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (30, 1530, 13)	--LNH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (31, 1531, 13)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (32, 1532, 13)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (33, 1533, 13)	--KMH
	
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (34, 1534, 13)	--LNH
	
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (35, 1535, 13)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (36, 1536, 13)	--KMH
	INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (37, 1537, 13)	--LNH

INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (46, 1587, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (47, 1588, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (48, 1589, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (49, 1590, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (50, 1591, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (51, 1592, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (52, 1593, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (53, 1594, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (54, 1595, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (55, 1596, 13)
INSERT INTO ComplaintGroupOrgMapping(CompiantInvID,INVGroupID,OrgID) VALUES (56, 1597, 13)



GO



/*	InvClientMaster		*/
Delete from  InvClientMaster where OrgID=13
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,type,ActiveYN)VALUES(1601,13,'GENERAL',1,NULL,'Y')

GO

/*		InvOrgGroup		*/
--DELETE FROM InvOrgGroup where OrgID = 13
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (2, 1502, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (3, 1503, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (5, 1505, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (7, 1507, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (10, 1510, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (11, 1511, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (15, 1515, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (19, 1519, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (20, 1520, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (29, 1529, 13)

--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (1,  1501, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (21, 1521, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (6, 1506, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (8, 1508, 13)
----INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (26, 626, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (28,1528, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (12, 1512, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (9,  1509, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (13, 1513, 13)

--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (30, 1530, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (31, 1531, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (32, 1532, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (33, 1533, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (34, 1534, 13)

--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (35, 1535, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (36, 1536, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (37, 1537, 13)

--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (87, 1587, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (88, 1588, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (89, 1589, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (90, 1590, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (91, 1591, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (92, 1592, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (93, 1593, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (94, 1594, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (95, 1595, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (96, 1596, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (97, 1597, 13)
--INSERT INTO InvOrgGroup (AttGroupID, OrgGroupID, OrgID) VALUES (98, 1598, 13)

GO

DELETE FROM ReportOrgMapping WHERE OrgID = 13

insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,128,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,128,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,128,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(4,127,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,128,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,128,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,128,13)

INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(12,128,13)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(13,128,13)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(14,128,13)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(15,128,13)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(16,128,13)
INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID)values(20,128,13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(21, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(22, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(23, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(24, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(25, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(31, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(32, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(33, 128,  13)
Insert into ReportOrgMapping(ReportID, RoleID, OrgID) values(34, 128,  13)

GO

DELETE FROM CashExpenseMaster WHERE OrgID = 13
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Physician',13,'PHY')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Staff Welfare',13,'STW')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Postage',13,'POS')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Hospitality',13,'HOP')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Travelling',13,'TRV')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Printing',13,'PRT')
INSERT INTO CashExpenseMaster(HeadName ,OrgID, HeadDesc ) VALUES ('Others',13,'OTH')

DELETE FROM TaskDependency WHERE OrgID = 13
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (11,11,13)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,33,13)
INSERT INTO TaskDependency (PrimaryTaskActionID, DependentTaskActionID, OrgID) VALUES (33,32,13)
GO



--
DELETE FROM ActionRoleMapping WHERE RoleID IN (123,124,125,127,128,129,131,133)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 127,	73, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (1, 127,	73, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 128,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (2, 128,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 127,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (3, 124,	54, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (5, 127,	80, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 127,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (6, 128,	76, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 127,	70, 11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (7, 127,	70, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (8, 127,	29, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (9, 125,	65, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (10, 127, 122, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 124, 6, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 124, 6, 19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 129, 7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (12, 129,	23,11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 123,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 124,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (13, 127,	81,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 124,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (14, 123,	58,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (17, 127,	57,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (18, 124,	39,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (19, 123,	44,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (20, 125,	68,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21, 127,	2, 10)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 127,	118, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 128,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (23, 127,	56,	6)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 123,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 124,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (25, 127,	71,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 127,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (26, 124,	52,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (29, 127,	3,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 123,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 124,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (30, 127,	82,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 127,	74,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (31, 127,	74,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 127,	38,  11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 124,	119, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (32, 127,	38,  19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (33, 125,	66,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 127,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 127,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 127,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (35, 127,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 127,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (36, 127,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 123,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 124,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (37, 127,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (38, 127,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 127,	28,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 127,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (39, 127,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 127,	28,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (40, 127,	28,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (41, 128,	47,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 123,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 127,	55,	11)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 125,	55,	4)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 125,	55,	11)
--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 127,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 127,	55,	19)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (43, 128,	121, 5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (45, 128,	128, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 128,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 128,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 128,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 128,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 128,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 122,	98, 14)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 122,	99, 15)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 122,	100, 18)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 122,	101, 16)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (48, 122,	105, 17)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (49, 127,	53,	5)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (50, 123,	7, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 127, 18, 10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 125, 18,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (51, 127, 18, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (11, 124,	6, 12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 127,	148,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)  VALUES(48,133,98,14)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)  VALUES(48,133,99,15)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)  VALUES(48,133,100,18)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)  VALUES(48,133,101,16)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)  VALUES(48,133,105,17)



--INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (52, 127, 148, 10)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (53,123,224,19)
Insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID) Values (32,123,38,19)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,127,6,10)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,127,6,12)
INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (11,127,6,19)

INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID)VALUES (14,124,58,19)


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (64, 127,	255,	10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (66, 127,	255,	12)

INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (34, 127,	28,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (42, 127,	55,	13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 127,	118,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (22, 128,	118,12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 128,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (71, 127,	278,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 128,	279,	12)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (72, 127,	279,	12)


INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (73, 127,	280,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (74, 127,	281,13)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (75, 128,	56,5)


GO

DELETE FROM PageActionMapping WHERE OwnerOrgID = 13

INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (1,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (2,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (3,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (4,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (5,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (6,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (7,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (8,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (9,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (10,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (11,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (12,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (13,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (14,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (15,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (16,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (17,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (18,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (19,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (20,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (21,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (22,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (23,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (24,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (25,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (26,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (27,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (28,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (29,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (30,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (31,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (32,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (33,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (34,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (35,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (36,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (37,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (38,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (39,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (40,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (41,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (42,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (43,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (44,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (45,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (46,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (47,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (48,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (49,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (50,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (51,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (52,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (53,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (54,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (55,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (56,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (57,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (58,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (59,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (60,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (61,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (62,13, 13)
INSERT INTO PageActionMapping (PageActionID, OwnerOrgID, SharedOrgID) VALUES (63,13, 13)
INSERT INTO PageActionMapping (PageActionID,OwnerOrgID,SharedOrgID) VALUES (64,13,13)

GO


DELETE FROM InvInstrumentMaster WHERE OrgID = 13
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (1,'Randox Imola, UK',13)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (2,'Immulite, UK',13)
INSERT INTO InvInstrumentMaster (InstrumentID,InstrumentName,OrgID) VALUES (3,'Centaur CP, USA',13)
GO

DELETE FROM InvKitMaster WHERE OrgID = 13
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (1,'Diasys, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (2,'Randox, UK',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (3,'Ensure Biotech' , 13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (4,'Roche, USA',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (5,'EURO IMMUN, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (6,'DiaMed Ag, Switzerland (For Rapid Test)',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (7,'Diagnostic Products Corporation, UK',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (8,'Plasmatec UK',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (9,'Tulip Diagnostics',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (10,'Immunocomb Israel',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (11,'Stago Diagnostica, France',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (12,'Biomerieux, Netherland',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (13,'Alfa Scientific Designs Inc, USA',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (14,'Omega Diagnostics, UK',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (15,'SIEMENS Medical Solutions Diagnostics, USA',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (16,'Known Pooled Cells; Bovine Serum Albumin 22%; Anti–Human Globulin; Anti–IgG; C3d Polyspecific Mediclone, India',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (17,'AIDA GMBH, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (18,'Wantai, ROC',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (19,'Genedia, Korea',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (20,'Orgenics, Israel',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (21,'Grenier, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (22,'Aeskueilsa, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (23,'Orgentec, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (24,'AESKU DIAGNOSTICS, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (25,'BIOSERV, Germany',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (26,'United Biotech Inc, USA',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (27,'Panbio, Australia',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (28,'Gamma, Belgium',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (29,'Tulip, India',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (30,'Diagnova ELISCAN HIV Advance',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (31,'Gene Labs, USA 2.2 Version*',13)
INSERT INTO InvKitMaster (KitID,KitName,OrgID) VALUES (32,'Equipar, Italy',13)
GO

DELETE FROM InvestigationMethod WHERE OrgID = 13
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (1,'Immunoturbidometric Assay',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (2,'Hexokinase',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (4,'Reflectometry',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (6,'Antigen Antibody  Reaction with  Latex Agglutination',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (7,'Micro & Macro Aggulutination(MAT)',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (8,'ELISA',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (9,'Both Forward and Reverse Technique',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (10,'Agglutination of Latex particles coated with purified Anti RF',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (11,'Human Gamma Globulins causes Agglutination',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (12,'When come in contact with Rh Eunatoid factor',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (13,'Immunochromatogrphic detection of F Protein of Respiratory Syncytial Virus',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (14,'Immunochromatography',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (15,'Western Blot Assay',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (16,'Immunoflourescence Assay ',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (17,'4th Generation Ag+AB ELISA',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (18,'Atomic Absorption Spectro Photometry',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (19,'Tube Agglutination',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (20,'Latex Agglutination',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (21,'Heam Agglutination Technique',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (22,'U/l',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (23,'RPR Flocculation Technique',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (24,'Tube Method with Serial Dilution',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (25,'Saline Tube Technique in AHG Medium',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (26,'Saline Tube Technique in Saline Mediium',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (27,'Saline Tube Technique in Albumin Medium ',13)
INSERT INTO InvestigationMethod (MethodID,MethodName,OrgID) VALUES (28,'Saline Tube Technique in AHG Medium',13)

GO

DELETE FROM InvResultTemplate WHERE OrgID = 13

insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(1,'CHRONIC NON-SPECIFIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC NON-SPECIFIC CERVICITIS.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(2,'CHRONIC CERVICITIS','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM. SUBEPITHELIAL LAYER SHOWS INFLAMMATORY CELLS. </Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(3,'CHRONIC CERVICITIS WITH EROSION(S)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY SQUAMOUS EPITHELIUM REPLACED IN SOME AREAS BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(4,'CHRONIC CERVICITIS WITH EROSION(C)','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(5,'CHRONIC CERVICITIS WITH EROSION AND EPIDERMIDALISATION','<Value><Microscopy>SECTIONS SHOW STRUCTURE OF CERVIX LINED BY ENDOCERVICAL COLUMNAR EPITHELIUM. SUBEPITHELIAL LAYER SHOWS ENDOCERVICAL GLANDS AND INFLAMMATORY CELLS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF CHRONIC CERVICITIS WITH EROSION.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(6,'MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA','<Value><Microscopy>SECTIONS SHOW SHEETS OF POLYGONAL CELLS WITH HYPERCHROMATIC NUCLEI INFILTRATING INTO DEEPER LAYERS.</Microscopy><Impression>PICTURE IS SUGGESTIVE OF MODERATELY DIFFERENTIATED SQUAMOUS CELL CARCINOMA.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(7,'PROLIFERATIVE PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY COLUMNAR EPITHELIUM IN PROLIFERATIVE PHASE. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(8,'MID-SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS ARE LINED BY CUBOIDAL EPITHELIUM IN MID-SECRETORY PHASE. STROMA IS EDEMATOUS. NO EVIDENCE OF TUBERCULOSIS IN THE SECTIONS STUDIED.</Microscopy><Impression>MID-SECRETORY PHASE.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(9,'LATE SECRETORY PHASE','<Value><Microscopy>ENDOMETRIAL GLANDS WITH SAW-TOOTH CONTOUR ARE IN LATE SECRETORY PHASE. STROMA IS EDEMATOUS.</Microscopy><Impression>LATE SECRETORY PHASE.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(10,'PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH MILD CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(11,'PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA','<Value><Microscopy>ENDOMETRIAL GLANDS ARE IN PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA. STROMA IS COMPACT.</Microscopy><Impression>PROLIFERATIVE PHASE WITH CYSTOGLANDULAR HYPERPLASIA.</Impression></Value>','Biopsy',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(12,'MR','<Value><InvestigationFindings> The study reveals moderate osteoarthritic changes in both tibiofemoral joints with formation of prominent periarticular      osteophytes, spiking of tibial spines, loss of joint space and multiple subchondral cysts in the tibial condyle and interocndylar region(more marked on right side).      Mild fluid seen in both knee joints.      Small osseous loose body posteriorly on right side.     Mild fluid seen in both knee joints.      Patellofemoral joint also shows degenerative changes with periarticular osteophytes, reduced joint space, irregularity of the articular surface and mild lateral tracking of patella.       The bones around both knee joints are otherwise normal. No obvious bony destruction seen.      There is no hematoma in the muscles.     The intermuscular fat planes and the neurovascular bundle are normal.      </InvestigationFindings><Impression>Moderate osteoarthritic changes in tibiofemoral and Patellofemoral joints bilaterally. Please correlate clinically.</Impression></Value>','Imaging',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(13,'CT Coronary Angiogram (64 slice scanner)','<Value>                   <InvestigationDetails>                   </InvestigationDetails>                  <InvestigationFindings>            Technique:             ECG gated high resolution multislice computed tomography was performed in siemens heart view 64 slice CT.             Coronary calcium scoring was done             CT coronary angiography was performed with intravenous injection of 50cc of non-ionic contrast medium (Omnipaque). Appropriate 3D, MIP, thin MIP and VRT view were obtained from multiple phase reconstructions.            </InvestigationFindings>                  <Impression>          His calcium score is 0.No obvious plaques or stenosis noted in the coronary arteries.         </Impression>        </Value>','Imaging',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(14,'MRI Scan of Brain','<Value>                   <InvestigationDetails>         No abnormal signals are visualized in the cerebral hemispheres.  No evidence of abnormal signal intensity or volume loss in the hippocampii.  The thalami, basal ganglia and internal capsules are normal on both sides.  The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  The posterior fossa shows normal cerebellum.  The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles are clear. The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.          </InvestigationDetails>                  <InvestigationFindings>            MR Angiogram:  The anterior , middle and posterior cerebral arteries appear normal.  The vertebral and basilar arteries appear normal.   No evidence of stenosis or occlusion noted.  No evidence of aneurysm / arteriovenous malformation.  No evidence of tortuous vessels impinging the lower cranial nerves.           </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Brain.       </Impression>        </Value>','Imaging',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(15,'CT Scan Neck','<Value>                   <InvestigationDetails>         Spiral axial sections of neck were made from base of skull to the sternoclavicular joint with and without IV contrast.          </InvestigationDetails>                  <InvestigationFindings>            The visualized sections of the nasopharynx, oropharynx and laryngopharynx show normal configuration and densities.  No mass lesion or extrinsic compression of the air columns is noted.  The epiglottis, valleculae and pyriform fossa are normal.  No abnormality is seen in the vocal cords or larynx.  The visualized visceral, retropharyngeal, parapharyngeal, prevertebral and carotid spaces of the neck show normal configuration and densities.  The parotid and submandibular salivary glands appear normal on both sides.  Both carotid arteries and internal jugular veins appear normal.  No significantly enlarged nodes are seen in the neck.  Both lobes and isthmus of the thyroid gland show normal configuration and densities. No focal lesion is noted.  The thyroid cartilage, cricoid cartilage and trachea are normal.  Visualized sections of base of skull and cervical spine appears normal.  No lytic sclerotic lesion is seen.         </InvestigationFindings>                  <Impression>  No significant abnormality is seen in the Neck.      </Impression>        </Value>','Imaging',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(16,'MRI Scan of Brain','<Value>  <InvestigationFindings>   Both cerebral hemispheres show normal grey and white matter signal intensities.   No focal lesion visualized on either side.   The thalami, basal ganglia and internal capsules are normal on both sides. Corpus callosum is normal.   The ventricles and sulci are normal for the age.  The pituitary gland, infundibulum and hypothalamus are normal for the age.  No evidence of hemorrhage, mass lesion, arteriovenous malformations or demyelination is seen.  Both cerebellar hemispheres and vermis appear normal.   The medulla, pons and mid brain shows normal signals in all the sequences.  Both CP angles, VII/VIII nerve complexes are normal.   The basal cisterns are normal.  Normal flow void is seen in the major dural venous sinuses and arteries.  The visualized paranasal sinuses and orbits are normal.   No evidence of Chiari malformation/ basal invagination seen.          </InvestigationFindings>         <Impression>          No significant abnormality detected.</Impression>        </Value>','Imaging',13)
insert into InvResultTemplate(resultid,resultname,resultvalues,resulttemplatetype,orgid)values(17,'CT -Cerebral Angiogram ','<Value>                   <InvestigationDetails>           Volume scan of the Brain was done with I.V. Contrast. MIP and neuro DSA reconstructions done in appropriate planes.           </InvestigationDetails>                  <InvestigationFindings>           The petrous, cavernous and supraclinoid parts of both ICA appear normal.           A1, A2, A3 segments of both ACA appear normal.           M1, M2, M3, M4 segments of both MCA appear normal.           P1, P2, P3, P4 segments of both PCA appear normal.           The anterior and posterior communicating arteries appear normal.          The basilar artery appears normal. SCA and AICA are normally seen.           Both vertebral arteries are normal. PICA is normally seen.           No evidence of stenosis or occlusion is visualized.          No evidence of aneurysm or arteriovenous malformation.         </InvestigationFindings>                  <Impression>          No significant abnormality detected.         </Impression>        </Value>','Imaging',13)

INSERT INTO InvResultTemplate (ResultID, ResultName, ResultValues, ResultTemplateType, OrgID) VALUES (18, 'Referral Letter', 'Dear Sir', 'Letter', 13)
INSERT INTO InvResultTemplate(ResultID,OrgID,ResultName,ResultTemplateType,ResultValues)VALUES (44,13,'Smear','TextReport','Normocytic Normochromic RBCs.<br />  Normal WBC count and morphology.<br />  Normal platelet morphology and distribution.<br />  No parasites seen.')

GO

DELETE FROM LabSummaryReportParameter WHERE OrgID = 13
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (1,'Client',13)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (2,'Doctor',13)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (3,'Hospital',13)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (4,'CollectionCentre',13)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (5,'Insurance',13)
--INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (6,'Branch',13)
INSERT INTO LabSummaryReportParameter (ParameterValue,ParameterName,OrgID) VALUES (7,'DEPARTMENT',13)
GO

DELETE FROM InvPrincipleMaster WHERE OrgID = 13
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (1,'Immunoturbidometric Assay',13)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (2,'Hexokinase',13)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (3,'Antigen Antibody Agglutination Test',13)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (4,'Reflectometry',13)
INSERT INTO InvPrincipleMaster (PrincipleID,PrincipleName,OrgID) VALUES (5,'Chemiluminescence Immuno Assay',13)
GO


insert into TrustedOrgDetails(LoggedOrgID ,SharingOrgID ,ShareTypeID )values(13,13,1)

insert into RoleDeptMap (RoleID ,DeptID )values(125,172)
insert into RoleDeptMap (RoleID ,DeptID )values(125,173)
insert into RoleDeptMap (RoleID ,DeptID )values(125,174)
insert into RoleDeptMap (RoleID ,DeptID )values(125,175)
insert into RoleDeptMap (RoleID ,DeptID )values(125,176)
insert into RoleDeptMap (RoleID ,DeptID )values(125,177)
insert into RoleDeptMap (RoleID ,DeptID )values(125,178)
insert into RoleDeptMap (RoleID ,DeptID )values(125,179)
insert into RoleDeptMap (RoleID ,DeptID )values(125,180)
insert into RoleDeptMap (RoleID ,DeptID )values(125,181)
insert into RoleDeptMap (RoleID ,DeptID )values(125,182)
insert into RoleDeptMap (RoleID ,DeptID )values(125,183)
insert into RoleDeptMap (RoleID ,DeptID )values(125,184)
insert into RoleDeptMap (RoleID ,DeptID )values(125,185)
insert into RoleDeptMap (RoleID ,DeptID )values(125,186)
insert into RoleDeptMap (RoleID ,DeptID )values(125,187)
insert into RoleDeptMap (RoleID ,DeptID )values(125,188)
insert into RoleDeptMap (RoleID ,DeptID )values(125,189)



insert into PurposeOfAdmission(PurposeOfAdmissionID ,PurposeOfAdmissionName,OrgID)values(26,'Medical Management',13)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(27,'Surgery',13)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(28,'Emergency Care',13)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(29,'Intervention',13)
insert into PurposeOfAdmission(PurposeOfAdmissionID,PurposeOfAdmissionName,OrgID)values(30,'Medical Evaluation',13)

insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(1,'Elective',13)
insert into SurgeryType(SurgeryTypeID,TypeName,OrgID)values(2,'Emergency',13)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(1,'Major',13)
insert into OperationType(OperationTypeID,TypeName,OrgID)values(2,'Minor',13)

insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(1,'General',13)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(2,'Local',13)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(3,'Spinal-Epidural',13)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(4,'Spinal-Intrathecal',13)
insert into AnesthesiaType(AnesthesiaTypeID,TypeName,OrgID)values(5,'Nerve Block',13)


INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('PHARMA_LiNo_24','GS',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('PHARMA_TinNo_24','GS',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('PharmacyLocation_24','24',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('PharmacyName_24','GS Pharmacy',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Required_PO_Approval','Y',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Required_Stock_Receive_Approval','N',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Required_Stock_Return_Approval','N',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Required_Stock_Damage_Approval','N',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Stock_Receive_Action_128','Y',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Stock_Receive_Action_133','N',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Quick_Billing_133','Y',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('Quick_Billing_128','N',13)
INSERT INTO InventoryConfig(ConfigKey,ConfigValue,OrgID)  VALUES('IsCreditBill','N',13)


INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Approved',1,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Cancelled',1,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Received',1,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Inprogress',1,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Pending',1,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Approved',2,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Received',2,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Inprogress',2,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Pending',2,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Approved',3,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Pending',3,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Approved',4,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Pending',4,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Approved',5,13,null)
INSERT INTO StockStatus VALUES ((SELECT MAX(StockStatusID)+1 FROM StockStatus),'Pending',5,13,null)

GO

DELETE FROM PaymentTypeOrgMapping WHERE OrgID= 13
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(1,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(2,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(3,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(4,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(5,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(6,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(7,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(8,13,0.00)
INSERT INTO PaymentTypeOrgMapping(PaymentTypeID,OrgID,ServiceCharge) VALUES(9,13,0.00)
GO

DELETE FROM GeneralBillingItems WHERE OrgID = 13
INSERT INTO GeneralBillingItems (ItemID, ItemName, Rate, OrgID, ClientID) VALUES (4, 'AMBULANCE', 25.00, 13, 1601)
GO





--Female Fertility Profile = 40
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1500
DELETE FROM InvGroupMapMaster WHERE GroupID = 1500
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (40,1500,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4776,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4807,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4821,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4855,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4773,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,3117,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1500,4821,NULL)

--Male Fertility Profile = 39
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1501
DELETE FROM InvGroupMapMaster WHERE GroupID = 1501
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (39,1501,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4190,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4776,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4807,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4844,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4855,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1501,5085,NULL)

--Liver Function Test = 2
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1502
DELETE FROM InvGroupMapMaster WHERE GroupID = 1502
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (2,1502,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,4846,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,4731,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3038,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3039,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3040,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3041,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3032,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3033,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,3034,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1502,4732,NULL)

--Lipid Profile = 10
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1503
DELETE FROM InvGroupMapMaster WHERE GroupID = 1503
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (10,1503,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,3057,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,3058,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,4460,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,4759,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,5577,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,5578,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1503,5579,NULL)

--Renal Profile =1
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1504
DELETE FROM InvGroupMapMaster WHERE GroupID = 1504
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (1,1504,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1504,1626,'Y')--Electrolytes (serum)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1504,4765,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1504,4856,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1504,4857,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1504,4145,NULL)

--Thyroid Profile, Total Levels = 9
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1505
DELETE FROM InvGroupMapMaster WHERE GroupID = 1505
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (9,1505,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1505,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1505,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1505,4855,NULL)

--Thyroid Profile, Free Levels = 47
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1506
DELETE FROM InvGroupMapMaster WHERE GroupID = 1506
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (47,1506,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1506,4777,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1506,4778,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1506,4855,NULL)

--Thyroid Profile, Free and Total Levels = 48
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1507
DELETE FROM InvGroupMapMaster WHERE GroupID = 1507
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (48,1507,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1507,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1507,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1507,4855,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1507,4777,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1507,4778,NULL)



--ToRCH Panel = 4
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1508
DELETE FROM InvGroupMapMaster WHERE GroupID = 1508
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (4,1508,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1508,4343,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1508,4344,NULL)

--Complete Hemogram = 49
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1509
DELETE FROM InvGroupMapMaster WHERE GroupID = 1509
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (49,1509,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,2013,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,2014,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,2031,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4362,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4391,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4787,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4810,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4811,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4819,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4830,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,4876,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1509,1627,'Y')--DC

--Complete Blood Count = 5
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1510
DELETE FROM InvGroupMapMaster WHERE GroupID = 1510
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (5,1510,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,2013,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,2014,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4362,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4787,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4810,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4811,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4819,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4830,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,4876,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1510,1627,'Y')--DC

--Coagulation Assay = 6
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1511
DELETE FROM InvGroupMapMaster WHERE GroupID = 1511
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (6,1511,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1511,2043,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1511,2045,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1511,2051,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1511,4151,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1511,4290,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1511,4872,NULL)

--Antiphosphilipid Antibodies = 50
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1512
DELETE FROM InvGroupMapMaster WHERE GroupID = 1512
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (50,1512,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1512,4343,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1512,4344,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1512,4801,NULL)

--Cardiolipin Antibodies = 51
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1513
DELETE FROM InvGroupMapMaster WHERE GroupID = 1513
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (51,1513,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1513,4343,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1513,4344,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1513,4801,NULL)

--Urine Analysis, Routine = 15
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1514
DELETE FROM InvGroupMapMaster WHERE GroupID = 1514
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (15,1514,13)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4010)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4028)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4007)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4011)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,5726)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,5725)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,5033)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4014)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4016)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4004)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4005)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4017)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4453)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4018)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4019)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4031)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4430)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1514,4443)

--Motion Analysis = 19
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1515
DELETE FROM InvGroupMapMaster WHERE GroupID = 1515
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (19,1515,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,3130,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,4813,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,4816,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,5006,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,5196,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,5586,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1515,5589,NULL)

--Semen Analysis = 20
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1516
DELETE FROM InvGroupMapMaster WHERE GroupID = 1516
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (20,1516,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1516,4298,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1516,5085,NULL)


--Serum Electrolytes = 3
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1526
DELETE FROM InvGroupMapMaster WHERE GroupID = 1526
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (3,1526,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,4836,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,3007,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,4820,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,4758,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,4752,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,3009,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1526,3008,NULL)

DELETE FROM InvOrgGroup WHERE OrgGroupID = 1527
DELETE FROM InvGroupMapMaster WHERE GroupID = 1527
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (8,1527,13)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,2005,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,2006,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,2007,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,2008,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,2009,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,4055,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,5733,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,5734,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1527,5735,NULL)

DELETE FROM InvOrgGroup WHERE OrgGroupID = 1529
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (34,1529,13)
DELETE FROM InvGroupMapMaster WHERE GroupID = 1529
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4062)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,3032)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4004)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4005)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4863)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4876)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4017)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4453)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4018)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4019)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4031)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4430)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1529,4443)

INSERT INTO RoleMenu (MenuID,RoleID)VALUES(443,132)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(454,132)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(464,132)
INSERT INTO RoleMenu (MenuID,RoleID)VALUES(456,128)

Insert into PageMapping(RoleId,PageID,SeqNo) values(132,188,  1)


insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(1,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(2,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(3,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(5,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(6,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(7,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(8,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(9,132,13)
insert into ReportOrgMapping (ReportID,RoleID,OrgID)values(10,132,13)


Delete From IPPaymentsRoleMapping Where Roleid IN (124,127)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,127)--n
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,127)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,127)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,127)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(9,127)

Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(1,124)---r
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(2,124)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(3,124)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(4,124)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(5,124)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(6,124)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(7,124)
Insert into IPPaymentsRoleMapping (IpPaymentsID,Roleid) Values(8,124)

INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,124)
INSERT INTO IPPaymentsRoleMapping (IpPaymentsID,Roleid)VALUES(10,127)

GO


Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,50,'EXERCISE THERAPY',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,50,'HYDROCOLLATERAL BATH(HOT PACK)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'WAX BATH',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'INTERFERENTIAL THERAPY(IFT)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'ULTRASOUND THERAPY(UST)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'TENS(TRANSCUTANEOUS STIMULATOR)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'ELECTRICAL STIMULATOR(ES)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'IPT(TRACTION)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'ICT(TRACTION)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,120,'BEDSIDE TRACTION(PER DAY)',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,80,'SHORT WAVE DIATHERMY',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,150,'CPM',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,150,'TILTING TABLE',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(10,250,'LASER THERAPY',  'Y', 1601, 13)
Insert into ProcedureFee(ProcedureID,Amount,ProcedureDesc,IsVariable,ClientID,OrgID)   values(11,0,'Others',  'Y', 1601, 13)



DELETE FROM FloorMaster WHERE OrgAddID=13
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(7,'Ground FLOOR',13)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(8,'1ST FLOOR',13)
INSERT INTO FloorMaster(FloorID,FloorName,OrgAddID) VALUES(9,'2ND FLOOR',13)

DELETE FROM RoomType WHERE OrgAddID=13
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('NON-AC,Semiprivate',13)--12--24
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('ICU',13)--13--25
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('Post-Op Ward',13)--14--26
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('OT',13)--15--27
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('NON-AC,Private',13)--16--28
INSERT INTO RoomType(RoomTypeName,OrgAddID) VALUES ('General Ward',13)--17--29
GO
DELETE FROM RoomMaster WHERE RoomTypeID IN (24,25,26,27,28,29)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(104,'Room1',7,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(105,'Room3',7,25)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(106,'Room5',8,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(107,'Room6',8,26)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(108,'Room7',8,24)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(109,'Room8',8,27)

INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(110,'Room10',9,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(111,'Room11',9,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(112,'Room12',9,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(113,'Room14',9,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(114,'Room15',9,28)
INSERT INTO RoomMaster(RoomID,RoomName,FloorID,RoomTypeID) VALUES(115,'Room16',9,29)

DELETE FROM BedMaster WHERE RoomID between 104 and 115
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(118,'BED1',104)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(119,'BED2',104)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(120,'BED1',105)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(121,'BED1',106)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(122,'BED2',106)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(123,'BED1',107)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(124,'BED1',108)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(125,'BED2',108)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(126,'BED1',109)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(127,'BED1',110)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(128,'BED1',111)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(129,'BED1',112)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(130,'BED1',113)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(131,'BED1',114)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(132,'BED1',115)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(133,'BED2',115)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(134,'BED3',115)
INSERT INTO BedMaster(BedID,BedName,RoomID)  VALUES(135,'BED4',115)



DELETE FROM FeeTypeOrgMapping WHERE OrgID = 13

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 13, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 13, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 13, 'OP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 13, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 13, 'OP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 13, 'OP')

INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (1, 13, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (2, 13, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (3, 13, 'IP')
--INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (4, 13, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (5, 13, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (6, 13, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (14, 13, 'IP')
INSERT INTO FeeTypeOrgMapping (FeeTypeID, OrgID, VisitType) VALUES (15, 13, 'IP')
GO