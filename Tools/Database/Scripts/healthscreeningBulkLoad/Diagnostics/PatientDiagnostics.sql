TRUNCATE TABLE Diagnostics
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, HashAttribute) VALUES (1, 'Diagnostics', 'Diagnostics', 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (2, 'ECG', 'ECG', 1, 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (3, 'Echocardiogram', 'Echocardiogram', 1, 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (4, 'Treadmill Test', 'Treadmill Test', 1, 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (5, 'Myocardial Perfusion Study', 'Myocardial Perfusion Study', 1, 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (6, 'Myocardial Viability Study', 'Myocardial Viability Study', 1, 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (7, 'Coronary Angiogram', 'Coronary Angiogram', 1, 'Y')
INSERT INTO Diagnostics (DiagnosticsID, DiagnosticsName, DiagnosticsDesc, ParentID, HashAttribute) VALUES (8, 'Other Diagnostics', 'ECG', 1, 'Y')


TRUNCATE TABLE DiagnosticsAttribute
--ECG
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (1, 2, 'Type', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (2, 2, 'Abnormalities', 1)

--Echocardiogram
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (3, 3, 'Myocardium', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (4, 3, 'RWMA', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (5, 3, 'Valve Abnormality', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (6, 3, 'Ejection Fraction', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (7, 3, 'Other Lesions', NULL)

--Treadmill Test
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (8, 4, 'Treadmill Test Result', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (9, 4, 'Stress Related ECG Changes', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (10, 4, 'Associated Symptoms', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (11, 4, 'MPHR', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (12, 4, 'MAHR', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (13, 4, 'Work Load', NULL)


--Myocardial Perfusion Study
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (14, 5, 'Type', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (15, 5, 'Description', 14)

--Myocardial Viability Study
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (16, 6, 'Type', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (17, 6, 'Description', 16)

--Coronary Angiogram

INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (18, 7, 'Coronary Angiogram Result', NULL)
INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (19, 7, 'Coronary Vessel', 18)

--Other Diagnostics

INSERT INTO DiagnosticsAttribute (AttributeID, DiagnosticsID, AttributeName, ParentAttributeID) VALUES (20, 8, 'Other Diagnostics', NULL)



TRUNCATE TABLE DiagnosticsAttributeValues
--ECG 
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (1, 1, 'NSR,WNL')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (2, 1, 'Abnormal')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (3, 2, 'Ventricular ectopics')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (4, 2, 'Atrial ectopics')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (5, 2, 'Non-specific ST-T changes')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (6, 2, 'Atrial fibrillation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (7, 2, 'Atrial flutter')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (8, 2, 'First-degree AV block')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (9, 2, 'Second-degree AV block')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (10, 2, 'Complete heart block')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (11, 2, 'Wenckebach phenomenon')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (12, 2, 'High-grade AV block')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (13, 2, 'Non-sustained VT')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (14, 2, 'Sustained VT')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (15, 2, 'Junctional rhythm')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (16, 2, 'Old MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (17, 2, 'Recent AWMI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (18, 2, 'Recent IWMI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (19, 2, 'Hypokalemic changes')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (20, 2, 'Digitalis effect')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (21, 2, 'Digitalis toxicity')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (22, 2, 'Acute Anterior Wall MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (23, 2, 'Acute Anteroseptal MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (24, 2, 'Acute extensive Anterior wall MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (25, 2, 'Acute Inferior Wall MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (26, 2, 'Acute Inferoposterior MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (27, 2, 'Acute lateral wall MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (28, 2, 'Acute high lateral MI')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (29, 2, 'Low voltage complexes')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (30, 2, 'Left ventricular hypertrophy (LVH)')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (31, 2, 'Left ventricular hypertrophy (LVH) with strain')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (32, 2, 'Hyperkalemic changes')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (33, 2, 'Others')

--Echocardiogram
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (34, 3, 'Normal biventricular function')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (35, 3, 'Normal LV function')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (36, 3, 'Mild LV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (37, 3, 'Moderate LV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (38, 3, 'Severe LV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (39, 3, 'Severe biventricular dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (40, 3, 'Moderate biventricular dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (41, 3, 'Severe LV dysfunction, Moderate RV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (42, 3, 'Severe RV dysfunction, Moderate LV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (43, 3, 'Moderate LV dysfunction, Mild RV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (44, 3, 'Moderate RV dysfunction, Mild LV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (45, 3, 'Severe LV dysfunction, Mild RV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (46, 3, 'Severe RV dysfunction, Mild LV dysfunction')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (47, 3, 'LV Diastolic Dysfunction, Type I')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (48, 3, 'LV Diastolic Dysfunction, Type II')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (49, 3, 'LV Diastolic Dysfunction, Type III')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (50, 3, 'Others')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (51, 4, 'RWMA')


INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (52, 5, 'Normal Valves')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (53, 5, 'Normally functioning prosthesis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (54, 5, 'Mitral valve prolapse')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (55, 5, 'Severe Mitral regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (56, 5, 'Moderate Mitral regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (57, 5, 'Mild Mitral regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (58, 5, 'Severe Mitral stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (59, 5, 'Moderate Mitral stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (60, 5, 'Mild Mitral stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (61, 5, 'Severe Aortic stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (62, 5, 'Moderate Aortic stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (63, 5, 'Mild Aortic stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (64, 5, 'Evidence of Infective endocarditis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (65, 5, 'Severe Aortic regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (66, 5, 'Moderate Aortic regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (67, 5, 'Mild Aortic regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (68, 5, 'Severe Tricuspid regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (69, 5, 'Moderate Tricuspid regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (70, 5, 'Mild Tricuspid regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (71, 5, 'Severe Pulmonary regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (72, 5, 'Moderate Pulmonary regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (73, 5, 'Mild Pulmonary regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (74, 5, 'Severe Tricuspid stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (75, 5, 'Moderate Tricuspid stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (76, 5, 'Mild Tricuspid stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (77, 5, 'Severe Pulmonic stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (78, 5, 'Moderate Pulmonic stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (79, 5, 'Mild Pulmonic stenosis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (80, 5, 'Normally functioning aortic prosthesis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (81, 5, 'Normally functioning mitral prosthesis')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (82, 5, 'Mitral valve prolapse with mitral regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (83, 5, 'Mitral valve prolapse without mitral regurgitation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (84, 5, 'Others')
																								  
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (85, 6, ' ')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (86, 7, ' ')


--Treadmill Test
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (87, 8, 'Negative')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (88, 8, 'Mildly Positive')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (89, 8, 'Positive')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (90, 8, 'Strongly Positive')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (91, 9, 'ST-T changes')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (92, 9, 'ST elevation')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (93, 9, 'ST depression')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (94, 9, 'T inversion')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (95, 9, 'Ventricular ectopics')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (96, 9, 'Atrial ectopics')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (97, 9, 'Non-sustained VT')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (98, 9, 'Ventricular tachycardia')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (99, 9, 'Prolonged PR interval')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (100, 9, 'Wenckebach phenomenon')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (101, 9, 'Complete heart block')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (102, 9, 'Arrhythmia')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (103, 9, 'Hear blocks')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (104, 9, 'Exercise-induced LBBB')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (105, 9, 'Exercise-induced RBBB')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (106, 9, 'Exercise induced SVT')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (107, 9, 'Intermittent AV block')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (108, 9, 'Others')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (109, 10, 'Chest discomfort')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (110, 10, 'Breathlessness')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (111, 10, 'Palpitations')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (112, 10, 'Others')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (113, 11, ' ')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (114, 12, ' ')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (115, 13, ' ')



--Myocardial Perfusion Study

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (116, 14, 'No perfusion defect')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (117, 14, 'Perfusion defect in LAD territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (118, 14, 'Perfusion defect in RCA territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (119, 14, 'Perfusion defect in LCX territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (120, 14, 'Perfusion defect in LCA territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (121, 14, 'Perfusion defect in LAD, RCA territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (122, 14, 'Perfusion defect in LCX, RCA territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (123, 14, 'Perfusion defect in LCA, RCA territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (124, 14, 'Others')

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (125, 15, ' ')

--Myocardial Viability Study
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (126, 16, 'Good viability in all territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (127, 16, 'Poor viability in LAD territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (128, 16, 'Poor viability in RCA territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (129, 16, 'Poor viability in LCX territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (130, 16, 'Poor viability in LCA territory')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (131, 16, 'Poor viability in LAD, RCA territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (132, 16, 'Poor viability in LCX, RCA territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (133, 16, 'Poor viability in LCA, RCA territories')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (134, 16, 'Others')


INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (135, 17, ' ')



--Coronary Angiogram 
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (136, 18, 'Normal epicardial Coronaries')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (137, 18, 'Coronary artery disease')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (138, 18, 'Recanalized vessel')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (139, 18, 'Single vessel disease')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (140, 18, 'Double vessel disease')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (141, 18, 'Triple vessel disease')


INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (142, 19, 'LAD')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (143, 19, 'LCX')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (144, 19, 'RCA')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (145, 19, 'LMCA')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (146, 19, 'PDA')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (147, 19, 'PLV')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (148, 19, 'L-PDA')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (149, 19, 'D-1')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (150, 19, 'D-2')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (151, 19, 'OM-1')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (152, 19, 'OM-2')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (153, 19, 'OM-3')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (154, 19, 'Major Diagonal')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (155, 19, 'Diagonal branch')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (156, 19, 'Major OM')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (157, 19, 'OM branch')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (158, 19, 'Major Septal')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (159, 19, 'Septal branch')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (160, 19, 'Conus branch')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (161, 19, 'Acute marginals')
INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (162, 19, 'Others')
																								  
--Other Diagnostics

INSERT INTO DiagnosticsAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (163, 20, ' ')





