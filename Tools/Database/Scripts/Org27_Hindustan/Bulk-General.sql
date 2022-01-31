DELETE FROM MenuMaster WHERE MenuID IN (1600,1601,1602,1603,1604,1605,1606,1607,1608,1609,1610,1611,1612,1613,1614,1615,1616,1617,1618,1619,1620,1621,1622,1623,1624,1625)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1600,'Patient Registration',0,27,137)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1601,'Patient Search',0,27,32)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1602,'Bill Search',0,27,33)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1603,'Reports',0,27,35)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1604,'Change Password',0,27,20)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1605,'Home',0,27,13)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1606,'Set Reminders',0,27,16)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1607,'Summary Reports',0,27,36)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1608,'Add/Change Hospital',0,27,42)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1609,'Investigation Report',0,27,135)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1610,'Collect Sample',0,27,128)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1611,'Receive Sample',0,27,129)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1612,'Investigation Capture',0,27,130)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1613,'Samples Report',0,27,131)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1614,'Bill Search',0,27,132)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1615,'Due Search',0,27,134)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1616,'Collection Report',0,27,138)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1617,'Add/Change Physician',0,27,141)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1618,'Manage Reference Range',2,27,61)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1619,'Manage Test Instrument',2,27,143)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1620,'Manage Test Kit',2,27,144)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1621,'Manage Test Method',2,27,145)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1622,'Manage Investigation',2,27,60)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1623,'Manage Investigation Rate',2,27,59)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1624,'Dispatch Result',0,27,147)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) values(1625,'Manage Test Principle',2,27,237)

--------------------------------------------------------------------------------------------------------------------
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1600,'receptiongs','receptiongs','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1601,'admings','admings','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1602,'gslab','gslab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1603,'testreceptiongs','testreceptiongs','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1604,'testadmings','testadmings','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1605,'testlabgs','testlabgs','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1606,'gsdispatch','gsdispatch','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1607,'gshematlab','gshematlab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1608,'gsbiolab','gsbiolab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1609,'gsclinicallab','gsclinicallab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1610,'gsimmunolab','gsimmunolab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1611,'gsmicrolab','gsmicrolab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1612,'gshistolab','gshistolab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1613,'gsmolecularlab','gsmolecularlab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1614,'gscytolab','gscytolab','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1780,'kanimozhi1780','kanimozhi','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1781,'rani1781','rani','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1782,'jayashree1782','jayashree','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1783,'loganathan1783','loganathan','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1784,'abdul1784','abdul','N',27,'A')
Insert into Login(loginID,LoginName,Password, IsLocked,OrgID,Status)values(1785,'balaji1785','balaji','N',27,'A')

----------------------------------------------------------------------------------------------------------------------
DELETE FROM Users WHERE LoginID IN (1600,1601,1602,1603,1604,1605,1606,1607,1608,1609,1610,1611,1612,1613,1614)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Reception','M','1',  27,1600)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Admin','M','1',  27,1601)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('GS Lab','M','1',  27,1602)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('TestReception','M','1',  27,1603)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('TestAdmin','M','1',  27,1604)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Test GS Lab','M','1',  27,1605)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Dispatch','M','1',  27,1606)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('HematologyLab','M','1',27, 1607)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('BiochemistryLab','M','1',27, 1608)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('ClinicalPathologyLab','M','1',27, 1609)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('ImmunologyLab','M','1',27, 1610)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('MicrobiologyLab','M','1',27, 1611)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('HistopathologyLab','M','1',27, 1612)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('MolecularBiologyLab','M','1',27, 1613)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('CytogeneticsLab','M','1',27, 1614)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Kanimozhi','F','2',27, 1780)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Rani','F','2',27, 1781)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Jayashree','F','2',27, 1782)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Loganathan','M','1',27, 1783)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Abdul','M','1',27, 1784)
Insert into Users(Name,SEX,TitleCode,OrgID,LoginID) values('Balaji','M','1',27, 1785)

--------------------------------------------------------------------------------------------------------------------------

Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1600,'Reception','Reception', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1601,'Admin','Admin', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1602,'SrLabTech','SrLabTech', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1603,'Dispatch','Dispatch', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1604,'HematologyLab','HematologyLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1605,'BioChemistryLab','BioChemistryLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1606,'ClinicalPathologyLab','ClinicalPathologyLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1607,'ImmunologyLab','ImmunologyLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1608,'MicroBiologyLab','MicroBiologyLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1609,'HistopathologyLab','HistopathologyLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1610,'MolecularBiologyLab','MolecularBiologyLab', 0,27)
Insert into Role(RoleID,RoleName,Description,ParentID,OrgID) Values(1611,'CytogeneticsLab','CytogeneticsLab', 0,27)

Insert Into LoginRole(RoleID,LoginID)values(1600,1600)
Insert Into LoginRole(RoleID,LoginID)values(1601,1601)
Insert Into LoginRole(RoleID,LoginID)values(1602,1602)
Insert Into LoginRole(RoleID,LoginID)values(1600,1603)
Insert Into LoginRole(RoleID,LoginID)values(1601,1604)
Insert Into LoginRole(RoleID,LoginID)values(1602,1605)
Insert Into LoginRole(RoleID,LoginID)values(1603,1606)
Insert Into LoginRole(RoleID,LoginID)values(1604,1607)
Insert Into LoginRole(RoleID,LoginID)values(1605,1608)
Insert Into LoginRole(RoleID,LoginID)values(1606,1609)
Insert Into LoginRole(RoleID,LoginID)values(1607,1610)
Insert Into LoginRole(RoleID,LoginID)values(1608,1611)
Insert Into LoginRole(RoleID,LoginID)values(1609,1612)
Insert Into LoginRole(RoleID,LoginID)values(1610,1613)
Insert Into LoginRole(RoleID,LoginID)values(1611,1614)

Insert Into LoginRole(RoleID,LoginID)values(1600,1780)
Insert Into LoginRole(RoleID,LoginID)values(1602,1780)

Insert Into LoginRole(RoleID,LoginID)values(1600,1781)
Insert Into LoginRole(RoleID,LoginID)values(1602,1781)


Insert Into LoginRole(RoleID,LoginID)values(1600,1782)
Insert Into LoginRole(RoleID,LoginID)values(1602,1782)
Insert Into LoginRole(RoleID,LoginID)values(1601,1782)

Insert Into LoginRole(RoleID,LoginID)values(1600,1783)
Insert Into LoginRole(RoleID,LoginID)values(1602,1783)


Insert Into LoginRole(RoleID,LoginID)values(1600,1784)
Insert Into LoginRole(RoleID,LoginID)values(1602,1784)


Insert Into LoginRole(RoleID,LoginID)values(1600,1785)
Insert Into LoginRole(RoleID,LoginID)values(1602,1785)
Insert Into LoginRole(RoleID,LoginID)values(1601,1785)

/* VisitPurposeOrgMapping */
DELETE VisitPurposeOrgMapping where VisitPurposeID=3 and OrgID=27
Insert into VisitPurposeOrgMapping(VisitPurposeID,OrgID)  values(3,27)
/* Tasks Mapping */
DELETE TaskActionMapping where OrgID=27 and VisitPurposeID = 3
Insert into TaskActionMapping (OrgID,VisitPurposeID,OtherID,TaskActionID) values(27,3,  0,22)
/* Task ActionOrg Mapping */
DELETE TaskActionOrgMapping where OrgID=27
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1602,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1604,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1605,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1606,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1607,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1608,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1609,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1610,27)
Insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) Values(27,1611,27)
																	  
DELETE invdeptmaster where OrgID=27
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1600,'Lab',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1601,'Hematology',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1602,'Biochemistry',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1603,'Clinical Pathology',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1604,'Immunology',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1605,'Microbiology',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1606,'Histopathology',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1607,'Molecular Biology',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1608,'Cytogenetics',27,'Y')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1609,'Imaging',27,'N')
insert into invdeptmaster (Deptid,deptname,orgid,display) values(1610,'CollectionDesk',27,'N')


/*	RoleDeptMap	*/
DELETE RoleDeptMap where RoleID in (1602,1607,1608,1608,1609,1610,1611,1612,1613,1614)
Insert into RoleDeptMap(RoleID,DeptID)  values(1602,1600)
Insert into RoleDeptMap(RoleID,DeptID)  values(1604,1601)
Insert into RoleDeptMap(RoleID,DeptID)  values(1605,1602)
Insert into RoleDeptMap(RoleID,DeptID)  values(1606,1603)
Insert into RoleDeptMap(RoleID,DeptID)  values(1607,1604)
Insert into RoleDeptMap(RoleID,DeptID)  values(1608,1605)
Insert into RoleDeptMap(RoleID,DeptID)  values(1609,1606)
Insert into RoleDeptMap(RoleID,DeptID)  values(1610,1607)
Insert into RoleDeptMap(RoleID,DeptID)  values(1611,1608)

insert into RoleDeptMap values(1602,1601) 
insert into RoleDeptMap values(1602,1602) 
insert into RoleDeptMap values(1602,1603) 
insert into RoleDeptMap values(1602,1604) 
insert into RoleDeptMap values(1602,1605) 
insert into RoleDeptMap values(1602,1606) 
insert into RoleDeptMap values(1602,1607) 
insert into RoleDeptMap values(1602,1608) 

insert into RoleDeptMap values(1600,1610) 
----------------------------------------------------------
/* SearchActions  */
DELETE SearchActions where RoleID in (1600,1601)
Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('Make Investigation Entry',1600,  137,'PatientSearch')
Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('View & Print Bill',1600,  34,'BillSearch')
Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('View & Cancel Bill',1600,  34,'BillSearch')
Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('Due Collection',1600,  136,'BillSearch')
Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('View & Print Bill',1601,  34,'BillSearch')
Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('View & Cancel Bill',1601,  34,'BillSearch')

Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('Change Priority',1600,  139,'BillSearch')

Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('Update Patient Details',1600,  140,'PatientSearch')

Insert into SearchActions(ActionName,RoleID,PageID,Type)  Values('Additional Information',1600,  142,'BillSearch')

/* PageMapping  */
DELETE PageMapping where RoleID in (1600,1601,1602)
Insert into PageMapping(RoleId,PageID,SeqNo) values(1600,137,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(1601,35,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(1601,36,2)
Insert into PageMapping(RoleId,PageID,SeqNo) values(1602,129,1)
Insert into PageMapping(RoleId,PageID,SeqNo) values(1602,30,2)


Insert into OrganizationAddress (AddressID,OrgID,AddressType,  Add1,Add2,Add3,PostalCode,CountryID,City,StateID,MobileNumber,LandLineNumber,  Comments,Location) Values(25,27,'A','','','','',0,'Chennai',0,'','','','Chennai')
-------------------------------------------------------------------------------
DELETE FROM Organization where OrgID = 27
Insert into Organization(OrgID,Name,OrganizationTypeID,AddressID)   values(27,'Hindustan Diagnostics Centre',3,  0)

---------------------------------------------------------------------------
Insert into RoleMenu (MenuID,RoleID)   values(1600,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1601,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1602,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1608,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1608,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1603,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1607,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1613,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1614,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1615,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1606,1602)

Insert into RoleMenu (MenuID,RoleID)   values(1604,1602)
Insert into RoleMenu (MenuID,RoleID)   values(1610,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1602)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1602)
Insert into RoleMenu (MenuID,RoleID)   values(1615,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1617,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1617,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1613,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1616,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1607,1600)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1602)
Insert into RoleMenu (MenuID,RoleID)   values(1618,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1619,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1620,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1621,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1622,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1623,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1625,1601)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1603)
Insert into RoleMenu (MenuID,RoleID)   values(1600,1603)
Insert into RoleMenu (MenuID,RoleID)   values(1613,1603)
Insert into RoleMenu (MenuID,RoleID)   values(1614,1603)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1603)
Insert into RoleMenu (MenuID,RoleID)   values(1624,1603)
Insert into RoleMenu (MenuID,RoleID)   values(1625,1600)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1604)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1604)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1604)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1604)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1604)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1604)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1605)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1605)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1605)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1605)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1605)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1605)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1606)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1606)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1606)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1606)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1606)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1606)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1607)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1607)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1607)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1607)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1607)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1607)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1608)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1608)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1608)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1608)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1608)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1608)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1609)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1609)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1609)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1609)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1609)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1609)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1610)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1610)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1610)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1610)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1610)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1610)

Insert into RoleMenu (MenuID,RoleID)   values(1606,1611)
Insert into RoleMenu (MenuID,RoleID)   values(1612,1611)
Insert into RoleMenu (MenuID,RoleID)   values(1604,1611)
Insert into RoleMenu (MenuID,RoleID)   values(1605,1611)
Insert into RoleMenu (MenuID,RoleID)   values(1611,1611)
Insert into RoleMenu (MenuID,RoleID)   values(1609,1611)
---------------------------------------------------------------------------------------------------------
DELETE FROM LabConsumables WHERE OrgID=27
INSERT INTO labconsumables (ConsumableID,ConsumableName,OrgID) VALUES (1,'Patient Cd',27)
INSERT INTO labconsumables (ConsumableID,ConsumableName,OrgID) VALUES (2,'Extra Flim',27)

INSERT INTO InvRateMaster (ClientID,ID,Rate,Type) VALUES (1600,1,0,'LCON')
INSERT INTO InvRateMaster (ClientID,ID,Rate,Type) VALUES (1600,2,0,'LCON')
--------------------------------------------------------------------------------------------
DELETE FROM InvestigationOrgSampleStatus WHERE OrgID =27
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (27, 'Paid', 1)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (27, 'SampleCollected', 2)
INSERT INTO InvestigationOrgSampleStatus (OrgID, SampleStatus, SeqNo) values  (27, 'SampleReceived', 3)
-------------------------------------------------------------------------------------------------
DELETE FROM InvClientMaster WHERE OrgID =27
INSERT INTO InvClientMaster(ClientID,orgid,clientname,clienttypeid,ActiveYN )VALUES(1600,27,'General Hospital',1,'Y')
--------------------------------------------------------------------------------------------
Delete from DiscountMaster where OrgID=27
INSERT INTO DiscountMaster (DiscountName,OrgID,Discount) VALUES ('Staff',27,1.0)
INSERT INTO DiscountMaster (DiscountName,OrgID,Discount) VALUES ('Dependent',27,0.75)
INSERT INTO DiscountMaster (DiscountName,OrgID,Discount) VALUES ('Relative',27,0.5)
----------------------------------------------------------------------------------------

DELETE RoleMenu where RoleID in (134,135,136,137,138,139,140,141,142,143,144,145)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (4,1600,139,9)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (15,1600,136,9)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (28,1600,137,10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (21,1600,140,10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (46,1601,34,9)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (47,1600,34,9)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (47,1601,34,9)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (46,1600,34,9)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (24,1600,159,10)
INSERT INTO ActionRoleMapping (ActionID, RoleID, RedirectPageID, SearchTypeID) VALUES (24,1601,159,10)

GO

DELETE ReferralActionOption WHERE RoleID IN(600)
Insert into ReferralActionOption(ActionID,ActionName,RoleID,Type,OnSelectChange,PageID)  Values(11,'Make Visit Entry',1600,'In','Picked',137)
Insert into ReferralActionOption(ActionID,ActionName,RoleID,Type,OnSelectChange,PageID)  Values(12,'Reject Referral',1600,'In','Reject',227)
Insert into ReferralActionOption(ActionID,ActionName,RoleID,Type,OnSelectChange)  Values(13,'Cancel Referral',1600,'Out','Cancel')
Insert into ReferralActionOption(ActionID,ActionName,RoleID,Type)  Values(14,'Print Referral',1600,'Out')
Insert into ReferralActionOption(ActionID,ActionName,RoleID,Type)  Values(15,'Edit Referral',1600,'Out')
Insert into ReferralActionOption(ActionID,ActionName,RoleID,Type,PageID)  Values(18,'Book Slots',1600,'Out',120)

GO

insert into Config (ConfigKey,ConfigValue,ParentID,OrgID)
 Select ConfigKey,ConfigValue,ParentID,27 FROM Config where OrgID = 12


DELETE FROM InvStatusmapping WHERE OrgID = 27
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (6,2,27,3)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (6,3,27,2)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (6,4,27,1)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (2,3,27,2)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (2,5,27,1)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (4,2,27,1)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (4,3,27,2)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (4,4,27,3)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (1,2,27,3)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (1,3,27,2)
INSERT INTO InvStatusmapping (InvestigationStatusID,MappingID,OrgID,SeqNo) VALUES (1,4,27,1)
-------------------------------------------------------------------------------------------------------------


--Female Fertility Profile = 40
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1600
DELETE FROM InvGroupMapMaster WHERE GroupID = 1600
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (40,1600,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4776,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4807,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4821,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4855,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4773,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,3117,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1600,4821,NULL)

--Male Fertility Profile = 39
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1601
DELETE FROM InvGroupMapMaster WHERE GroupID = 1601
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (39,1601,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4190,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4776,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4807,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4844,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4855,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1601,5085,NULL)

--Liver Function Test = 2
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1602
DELETE FROM InvGroupMapMaster WHERE GroupID = 1602
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (2,1602,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,4846,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,4731,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3038,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3039,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3040,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3041,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3032,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3033,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,3034,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1602,4732,NULL)

--Lipid Profile = 10
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1603
DELETE FROM InvGroupMapMaster WHERE GroupID = 1603
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (10,1603,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,3057,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,3058,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,4460,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,4759,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,5577,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,5578,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1603,5579,NULL)

--Renal Profile =1
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1604
DELETE FROM InvGroupMapMaster WHERE GroupID = 1604
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (1,1604,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1604,1626,'Y')--Electrolytes (serum)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1604,4765,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1604,4856,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1604,4857,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1604,4145,NULL)

--Thyroid Profile, Total Levels = 9
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1605
DELETE FROM InvGroupMapMaster WHERE GroupID = 1605
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (9,1605,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1605,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1605,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1605,4855,NULL)

--Thyroid Profile, Free Levels = 47
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1606
DELETE FROM InvGroupMapMaster WHERE GroupID = 1606
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (47,'Thyroid Profile, Free Levels','GRP')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (47,1606,27)

INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1606,4777,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1606,4778,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1606,4855,NULL)

--Thyroid Profile, Free and Total Levels = 48
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1607
DELETE FROM InvGroupMapMaster WHERE GroupID = 1607
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (48,'Thyroid Profile, Free and Total Levels','GRP')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (48,1607,27)

INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1607,4838,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1607,4839,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1607,4855,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1607,4777,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1607,4778,NULL)



--ToRCH Panel = 4
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1608
DELETE FROM InvGroupMapMaster WHERE GroupID = 1608
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (4,1608,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1608,4343,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1608,4344,NULL)

--Complete Hemogram = 49
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1609
DELETE FROM InvGroupMapMaster WHERE GroupID = 1609
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (49,'Complete Hemogram','GRP')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (49,1609,27)

INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,2013,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,2014,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,2031,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4362,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4391,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4787,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4810,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4811,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4819,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4830,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,4876,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1609,1627,'Y')--DC

--Complete Blood Count = 5
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1610
DELETE FROM InvGroupMapMaster WHERE GroupID = 1610
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (5,1610,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,2013,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,2014,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4362,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4787,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4810,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4811,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4819,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4830,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,4876,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1610,1627,'Y')--DC

--Coagulation Assay = 6
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1611
DELETE FROM InvGroupMapMaster WHERE GroupID = 1611
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (6,1611,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1611,2043,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1611,2045,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1611,2051,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1611,4151,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1611,4290,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1611,4872,NULL)

--Antiphosphilipid Antibodies = 50
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1612
DELETE FROM InvGroupMapMaster WHERE GroupID = 1612
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (50,'Antiphosphilipid Antibodies','GRP')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (50,1612,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1612,4343,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1612,4344,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1612,4801,NULL)

--Cardiolipin Antibodies = 51
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1613
DELETE FROM InvGroupMapMaster WHERE GroupID = 1613
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (51,'Cardiolipin Antibodies','GRP')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (51,1613,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1613,4343,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1613,4344,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1613,4801,NULL)

--Urine Analysis, Routine = 15
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1614
DELETE FROM InvGroupMapMaster WHERE GroupID = 1614
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (15,1614,27)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4010)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4028)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4007)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4011)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,5726)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,5725)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,5033)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4014)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4016)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4004)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4005)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4017)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4453)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4018)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4019)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4031)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4430)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1614,4443)

--Motion Analysis = 19
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1615
DELETE FROM InvGroupMapMaster WHERE GroupID = 1615
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (19,1615,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,3130,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,4813,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,4816,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,5006,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,5196,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,5586,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1615,5589,NULL)

--Semen Analysis = 20
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1616
DELETE FROM InvGroupMapMaster WHERE GroupID = 1616
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (20,1616,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1616,4298,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1616,5085,NULL)











-- Master Health Checkup = 60
DELETE FROM InvGroupMaster WHERE GroupID = 60
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1617
DELETE FROM InvPackageMapping WHERE PackageID = 1617
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (60,'Master Health Checkup','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (60,1617,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4759,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,3057,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,5577,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,5578,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4460,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,5579,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4781,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4782,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4846,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4731,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,3038,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,3039,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,3032,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4732,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,3041,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,3040,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4856,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4765,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4857,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4836,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4820,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4758,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4752,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4756,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4817,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4792,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4800,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,1610,'GRP')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,1614,'GRP')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,1615,'GRP')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1617,4277,'INV')


--Anaemia Profile I = 52
DELETE FROM InvGroupMaster WHERE GroupID = 52
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1618
DELETE FROM InvPackageMapping WHERE PackageID = 1618
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (52,'Anaemia Profile I','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (52,1618,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1618,1610,'GRP')--CBC
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1618,1615,'GRP')--Motion Analysis
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1618,4391,'INV')

--Anaemia Profile II = 53
DELETE FROM InvGroupMaster WHERE GroupID = 53
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1619
DELETE FROM InvPackageMapping WHERE PackageID = 1619
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (53,'Anaemia Profile II','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (53,1619,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1619,1610,'GRP')--CBC
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1619,1615,'GRP')--Motion Analysis
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1619,4391,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1619,3069,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1619,4845,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1619,3066,'INV')

--Antenatal Profile I = 54 
DELETE FROM InvGroupMaster WHERE GroupID = 54
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1620
DELETE FROM InvPackageMapping WHERE PackageID = 1620
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (54,'Antenatal Profile I','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (54,1620,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,1614,'GRP')--Urine Analysis, Routine
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,4787,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,2031,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,4089,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,4783,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,4793,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1620,4800,'INV')


--Antenatal Profile II = 55
DELETE FROM InvGroupMaster WHERE GroupID = 55
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1621
DELETE FROM InvPackageMapping WHERE PackageID = 1621
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (55,'Antenatal Profile II','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (55,1621,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1621,1614,'GRP')--Urine Analysis, Routine
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1621,4787,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1621,2031,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1621,4089,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1621,4783,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1621,4793,'INV')


--Cardiac Profile I = 56
DELETE FROM InvGroupMaster WHERE GroupID = 56
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1622
DELETE FROM InvPackageMapping WHERE PackageID = 1622
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (56,'Cardiac Profile I','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (56,1622,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,1603,'GRP')--Lipid Profile
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,4765,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,4856,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,4857,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,3040,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,3041,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,4277,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,4221,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1622,4787,'INV')

--Cardiac Profile II = 57
DELETE FROM InvGroupMaster WHERE GroupID = 57
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1623
DELETE FROM InvPackageMapping WHERE PackageID = 1623
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (57,'Cardiac Profile II','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (57,1623,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,1603,'GRP')--Lipid Profile
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4765,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4856,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4857,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,3040,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,3041,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4277,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4221,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4335,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1623,4787,'INV')

--Diabetic Profile = 58
DELETE FROM InvGroupMaster WHERE GroupID = 58
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1624
DELETE FROM InvPackageMapping WHERE PackageID = 1624
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (58,'Diabetic Profile','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (58,1624,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,1603,'GRP')--Lipid Profile
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,4789,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,4856,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,4861,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,4781,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,4765,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1624,4782,'INV')

--Arthritis Profile = 59
DELETE FROM InvGroupMaster WHERE GroupID = 59
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1625
DELETE FROM InvPackageMapping WHERE PackageID = 1625
INSERT INTO InvGroupMaster (GroupID,GroupName,Type) VALUES (59,'Arthritis Profile','PKG')
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (59,1625,27)
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1625,4857,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1625,4756,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1625,5591,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1625,5590,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1625,4091,'INV')
INSERT INTO InvPackageMapping (PackageID,ID,Type) VALUES (1625,4097,'INV')

--Serum Electrolytes = 3
DELETE FROM InvOrgGroup WHERE OrgGroupID = 1626
DELETE FROM InvGroupMapMaster WHERE GroupID = 1626
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (3,1626,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,4836,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,3007,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,4820,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,4758,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,4752,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,3009,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1626,3008,NULL)

DELETE FROM InvOrgGroup WHERE OrgGroupID = 1627
DELETE FROM InvGroupMapMaster WHERE GroupID = 1627
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (8,1627,27)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,2005,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,2006,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,2007,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,2008,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,2009,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,4055,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,5733,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,5734,NULL)
INSERT INTO InvGroupMapMaster(GroupID,InvestigationID,Parent) VALUES (1627,5735,NULL)

DELETE FROM InvOrgGroup WHERE OrgGroupID = 1629
INSERT INTO InvOrgGroup (AttGroupID,OrgGroupID,OrgID) VALUES (34,1629,27)
DELETE FROM InvGroupMapMaster WHERE GroupID = 1629
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4062)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,3032)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4004)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4005)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4863)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4876)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4017)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4453)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4018)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4019)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4031)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4430)
INSERT INTO InvGroupMapMaster (GroupID,InvestigationID) VALUES (1629,4443)

DELETE FROM LabConsumables WHERE OrgID = 27
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(1,'Patient CD',27)
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(2,'Extra Film',27)
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(3,'X-Ray Reporting Charge',27)
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(4,'ECG Reporting Charge',27)
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(5,'Medical Examination',27)
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(6,'Doctor Consultation',27)
INSERT INTO LabConsumables (ConsumableID,ConsumableName,OrgID)VALUES(7,'Service Charge',27)
