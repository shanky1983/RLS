

DELETE FROM History WHERE HistoryID IN (1057, 1058,1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066,1067)



INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1057, 'PATIENT HISTORY', NULL, NULL)
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1058, 'SOCIAL HISTORY', 1057, NULL)
UPDATE History SET ParentID = 1058, HashAttribute = 'YES' WHERE HistoryID = 476
UPDATE History SET ParentID = 1058, HashAttribute = 'YES' WHERE HistoryID = 369
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1059, 'Physical  Activity ', 1058, 'YES')
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1060, 'ALLERGIC HISTORY', 1057, NULL)
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1061, 'Drugs', 1060, 'YES')
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1062, 'Food Allergy', 1060, 'YES')
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1063, 'DRUG HISTORY', 1057, NULL)
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1064, 'VACCINATION HISTORY', 1057, NULL)
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1065, 'GYNAECOLOGICAL HISTORY', 1057, 'YES')
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1066, 'Hormone Replacement Theraphy', 1065, 'YES')
INSERT INTO History (HistoryID, HistoryName, ParentID, HashAttribute) VALUES (1067, 'OBSTRETIC HISTORY', 1057, NULL)

TRUNCATE TABLE HistoryAttribute
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (1, 476, 'Type', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (2, 476, 'Duration', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (3, 476, 'Qty', NULL)

INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (4, 369, 'Type', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (5, 369, 'Duration', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (6, 369, 'Qty', NULL)

INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (7, 1059, 'Physicial Exercise', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (8, 1059, 'Aerobic', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (9, 1059, 'Anaerobic', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (10, 1059, 'Duration', NULL)

INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (11, 1061, 'Type', NULL)

INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (12, 1062, 'Type', NULL)

INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (13, 1065, 'LMP Date', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (14, 1065, 'Menstrual Cycle', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (15, 1065, 'Cycle Length(approx)', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (16, 1065, 'Last Pap Smear', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (17, 1065, 'Contraception', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (18, 1065, 'Age of Menarchy', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (19, 1065, 'Result', 18)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (20, 1065, 'LastMammogram', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (21, 1065, 'Result', 20)

INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (22, 1066, 'Type of HRT', NULL)
INSERT INTO HistoryAttribute (AttributeID, HistoryID, AttributeName, ParentAttributeID) VALUES (23, 1066, 'HRT Delivery', NULL)

TRUNCATE TABLE AttributeValues
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (1, 1, 'Cigarettes ')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (2, 1, 'Cigars')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (3, 1, 'Bidis')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (4, 1, 'Others')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (5, 2, 'day')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (6, 2, 'week')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (7, 2, 'month')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (8, 2, 'year')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (9, 3, '')--Qty

INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (10, 4, 'Beer')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (11, 4, 'Whisky')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (12, 4, 'Others')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (13, 5, 'day')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (14, 5, 'week')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (15, 5, 'month')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (16, 5, 'year')--Duration
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (17, 6, '')--Qty

INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (18, 7, 'No Physicial exertion')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (19, 7, 'Occasional Physicial Activity')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (20, 7, 'Regular Exercise')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (21, 7, 'Athlete')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (22, 8, 'Aerobic')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (23, 9, 'Anaerobic')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (67, 10, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (24, 10, 'Min')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (25, 10, 'Hrs')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (26, 10, 'day')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (27, 10, 'week')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (28, 10, 'month')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (29, 10, 'year')

INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (30, 11, 'Pencillin')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (31, 11, 'Cephalosporins')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (32, 11, 'Digoxm')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (33, 11, 'Sulpha Drugs')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (34, 11, 'Others')

INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (35, 12, 'Shell fish')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (36, 12, 'Tomato')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (37, 12, 'Others')

INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (38, 13, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (39, 14, 'Regularly regular')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (40, 14, 'Regularly irregular')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (41, 14, 'IrRegularly regular')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (42, 14, 'IrRegularly irregular')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (43, 14, 'Regular')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (44, 14, 'IrRegular')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (45, 15, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (46, 16, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (47, 18, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (48, 17, 'IUD')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (49, 17, 'Mechanical')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (50, 17, 'Others')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (51, 19, 'Negative')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (52, 19, 'Positive')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (53, 19, 'Inconclusive')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (54, 19, 'Awaited')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (55, 20, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (56, 21, '')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (57, 22, 'Estrogen')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (58, 22, 'Estrogen + Progesterone')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (59, 22, 'Others')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (60, 23, 'Tablet')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (61, 23, 'Gel')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (62, 23, 'Vaginal ring')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (63, 23, 'Injection')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (64, 23, 'Patch')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (65, 23, 'Cream')
INSERT INTO AttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (66, 23, 'Others')
