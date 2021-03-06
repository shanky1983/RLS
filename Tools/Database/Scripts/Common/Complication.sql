Truncate Table Complication
GO
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(1,'General',  'General',NULL)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(2,'Access Site',  'Access Site',NULL)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(3,'Machine',  'Machine Related',NULL)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(4,'Hypertension',  'Hypertension',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(5,'Hypotension',  'Hypotension',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(6,'Dehydration',  'Dehydration',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(7,'Stroke',  'Stroke',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(8,'Fever',  'Fever',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(9,'Bleeding',  'Bleeding',2)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(10,'Infection',  'Infection',2)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(11,'NonFunctional',  'NonFunctional',2)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(12,'TubeLeak',  'TubeLeak',3)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(13,'Improper Dialyser',  'ImproperDialyser',3)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(14,'Improper Dialysate',  'Improper Dialysate',3)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(15,'Muscle Cramps',  'Muscle Cramps',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(16,'Rigors',  'Rigors',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(17,'Nausea',  'Nausea',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(18,'Vomiting',  'Vomiting',1)
Insert into Complication(ComplicationID,ComplicationName,  ComplicationDesc,ParentID) values(19,'Headache',  'Headache',1)


INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(20,'Viral Infections','Viral Infections',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(21,'Hyperemesis Gravidarum','Hyperemesis Gravidarum',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(22,'Venereal Infections','Venereal Infections',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(23,'PROM','Pre-mature rupture of membrane',Null)

INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(24,'Foetus','Pregnancy-Induced Hypertension',Null)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(25,'Maternal','Eclampsia',Null)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(26,'Abnormal Presentation','Abnormal Presentation',24)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(27,'IUGR','IVGR',24)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(28,'Ectopic Gestation','Ectopic Gestation',24)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(29,'Congenital Fetal Anamoly','Congenital Fetal Anamoly',24)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(30,'Foetal Demise','Foetal Demise',24)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(31,'Ovarian','Ovarian',28)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(32,'Tubal','Tubal',28)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(33,'Abdominal','Abdominal',28)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(34,'False Labour Pains','False Labour Pains',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(35,'Hemorrhoids','Hemorrhoids',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(36,'Oligohydramnios','Oligohydramnios',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(37,'Placenta previa','Placenta previa',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(38,'DVT','DVT',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(39,'PIH','PIH',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(40,'Polyhydramnios','Polyhydramnios',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(41,'Threatened Abortion','Threatened Abortion',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(42,'Constipation','Constipation',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(43,'Pre-Eclampsia','Pre-Eclampsia',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(44,'APH','APH',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(45,'Abruptio Placenta','Abruptio Placenta',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(46,'Pyelonephritis','Pyelonephritis',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(47,'Abortion','Abortion',25)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(48,'Atonic PPH', 'Atonic PPH', NULL)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(49,'Eclampsia', 'Eclampsia', NULL)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(50,'Anaemia', 'Anaemia', NULL)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(51, 'Gestational DM', 'Gestational DM', NULL)
INSERT INTO Complication (ComplicationID, ComplicationName, ComplicationDesc,ParentID) Values(52, 'Urinary Tract Infection', 'Urinary Tract Infection', NULL)

GO

DELETE FROM ComplaintComplication WHERE ComplaintID = 534
INSERT INTO ComplaintComplication (ComplaintID, ComplicationID)   VALUES (534, 24)
INSERT INTO ComplaintComplication (ComplaintID, ComplicationID)   VALUES (534, 25)
GO

DELETE FROM SpecialityComplication WHERE SpecialityID = 16
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,51)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,50)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,52)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,20)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,39)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,49)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,22)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,21)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,23)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,29)
insert into SpecialityComplication(SpecialityID, ComplicationID)values(16,48)


GO