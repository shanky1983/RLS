
--New page with new ID
--DELETE FROM Pages where PageID in(31,32,33,34,35,36,42,43,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65)
DELETE FROM Pages where PageID in(31,32,33,34,35,36,42,128,
129,
130,
131,
132,
133,
134,
135,
136,
137,
138,
139,
140,
141,
142,
143,
144,
145,
146,
147)
Insert into Pages (PageID,PageName,PageURL)values  (31,'SampleRegistration','/Reception/PatientSampleRegistration.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (32,'Lab Patient Search','/Reception/LabPatientSearch.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (33,'Bill Search','/Reception/BillSearch.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (34,'Print Bill','/Reception/ViewBill.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (35,'Reports','/Admin/DailyBillReport.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (36,'Summary Reports','/Admin/LabAdminSummaryReports.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (42,'Add/Change Hospital','/Reception/SaveLabRefOrgDetails.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (128,'Collect Sample','/Lab/InvestigationSample.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (129,'Receive Sample','/Lab/DeptSamplesCollection.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (130,'Investigation Capture','/Investigation/InvestigationCapture.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (131,'Samples Report','/Admin/InvestigationSamplesReport.aspx') 
Insert into Pages (PageID,PageName,PageURL)values  (132,'Bill Search','/Admin/BillSearch.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (133,'Print Bill','/Admin/ViewBill.aspx')

Insert into Pages (PageID,PageName,PageURL)values  (134,'Due Search','/Admin/DueSearch.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (135,'Investigation Report','/Investigation/InvReports.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (136,'Due Collection','/Reception/DueCollection.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (137,'SampleRegistration','/Reception/LabPatientRegistration.aspx') 
Insert into Pages (PageID,PageName,PageURL)values  (138,'InvestigationCollectionReport','/Admin/InvestigationCollectionReport.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (139,'Change Priority','/Reception/ChangePriority.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (140,'Update Patient Details','/Reception/UpdatePatientDetails.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (141,'Add/Change Physician','/Reception/SaveLabRefPhysicianDetails.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (142,'Additional Information','/Reception/AdditionalInformation.aspx')
--Insert into Pages (PageID,PageName,PageURL)values  (143,'Manage Reference Range','/Admin/InvRefRanges.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (143,'Manage Test Instrument','/Admin/ManageInvInstrument.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (144,'Manage Test Kit','/Admin/ManageInvKit.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (145,'Manage Test Method','/Admin/ManageInvMethod.aspx')
--Insert into Pages (PageID,PageName,PageURL)values  (64,'Manage Investigation','/Admin/AddInvGroups.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (146,'Manage Rate','/Admin/RatesUpdation.aspx')
Insert into Pages (PageID,PageName,PageURL)values  (147,'Dispatch Result','/Reception/Dispatch.aspx')


