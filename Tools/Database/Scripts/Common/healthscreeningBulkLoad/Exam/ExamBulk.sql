 DELETE FROM Examination WHERE ExaminationID IN (928,915, 916, 917, 918,919,920,921,922,923,
 924,925,926,927, 871, 872, 873, 874, 875, 876, 877, 878, 879, 880,881,882,883,884,885,
 886,887,888,889,890,891,892,893,914, 894,895,896,897,898,899,900,901,
 902,903,904,905,906,907,908,909,910,911,912,913)
 
 
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (928, 'Skin', 'Skin', 836, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (915, 'Hair', 'Hair', 836, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (916, 'Nails', 'Nails', 836, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (917, 'Scars', 'Scars', 836, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (918, 'Eye', 'Eye', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (919, 'Distant Vision', 'Distant Vision', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (920, 'Near Vision', 'Near Vision', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (921, 'Color Vision', 'Color Vision', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (922, 'IOL Present', 'Intraocular Present', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (923, 'Pterygium', 'Pterygium', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (924, 'Xanthelasma', 'Xanthelasma', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (925, 'Eye Movements', 'Eye Movements', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (926, 'Pupils', 'Pupils', 918, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (927, 'Tonometry', 'Tonometry', 918, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (871, 'Ear', 'Ear', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (872, 'Auditory Canal', 'Auditory Canal', 871, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (873, 'Ear Drum', 'Ear Drum', 871, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (874, 'Neck', 'Neck', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (875, 'Thyroid Gland', 'Thyroid Gland', 874, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (876, 'Lymph Nodes', 'Lymph Nodes', 874, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (877, 'Respiratory System', 'Respiratory System', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (878, 'Trachea', 'Trachea', 877, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (879, 'Breath Sounds', 'Breath Sounds', 877, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (880, 'Cardiovascular Examination', 'Cardiovascular Examination', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (881, 'Pulse Rhythm', 'Pulse Rhythm', 880, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (882, 'Pulse Volume', 'Pulse Volume', 880, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (883, 'Pulse Character', 'Pulse Character', 880, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (884, 'Peripheral Pulses', 'Peripheral Pulses', 880, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (885, 'Apex Beat', 'Apex Beat', 880, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (886, 'Heart Sounds', 'Heart Sounds', 880, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (887, 'Heart Mummurs', 'Heart Mummurs', 880, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (888, 'Abdominal Examination', 'Abdominal Examination', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (889, 'Abdominal Inspection', 'Abdominal Inspection', 888, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (890, 'Abdominal Palpation', 'Abdominal Palpation', 888, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (891, 'Liver', 'Liver', 888, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (892, 'Spleen', 'Spleen', 888, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (893, 'Kidneys', 'Kidneys', 888, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (914, 'Other Findings', 'Other Findings', 888, 'Y')


INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (894, 'Oral Cavity', 'Oral Cavity', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (895, 'General Appearance', 'General Appearance', 894, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (896, 'Teeth', 'Teeth', 894, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (897, 'Tongue', 'Tongue', 894, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (898, 'Tonsils', 'Tonsils', 894, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (899, 'Pharynx', 'Pharynx', 894, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (900, 'Neurological Examination', 'Neurological Examination', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (901, 'Cranial Nerves', 'Cranial Nerves', 900, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (902, 'Sensory System', 'Sensory System', 900, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (903, 'Reflexes', 'Reflexes', 900, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (904, 'Motor System', 'Motor System', 900, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (905, 'Musculo Skeletal system', 'Musculo Skeletal system', 900, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (906, 'Gait', 'Gait', 900, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (907, 'Gynaecological Examination', 'Gynaecological Examination', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (908, 'Breasts', 'Breasts', 907, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (909, 'Uterus', 'Uterus', 907, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (910, 'External Genetaila', 'External Genetaila', 907, 'Y')

INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, HashAttribute) VALUES (911, 'Rectal Examination', 'Rectal Examination', 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (912, 'Rectum', 'Rectum', 911, 'Y')
INSERT INTO Examination (ExaminationID, ExaminationName, ExaminationDesc, ParentID, HashAttribute) VALUES (913, 'Prostate', 'Prostate', 911, 'Y')
GO


TRUNCATE TABLE ExaminationAttribute
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (1, 928, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (2, 928, 'Lesions', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (3, 915, 'Type', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (4, 916, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (5, 916, 'Description', 4)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (6, 917, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (7, 917, 'Scaretiology', 6)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (8, 917, 'Scar Location', 6)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (9, 919, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (10, 919, 'Right Eye', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (97, 919, 'Left Eye', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (11, 920, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (12, 920, 'Right Eye', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (99, 920, 'Left Eye', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (13, 921, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (14, 921, 'Description', 13) --Changed

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (15, 922, 'Eye', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (16, 923, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (17, 923, 'Description', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (18, 924, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (19, 924, 'Associated Conditions', 18) --Changed

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (20, 925, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (21, 925, 'Abnormality', 20)	--Changed

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (22, 926, 'Size', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (23, 926, 'RightEye', 22)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (24, 926, 'LeftEye', 22)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (25, 926, 'Shape', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (26, 926, 'RightEye', 25)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (27, 926, 'LeftEye', 25)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (28, 926, 'Reaction to Light', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (29, 926, 'RightEye', 28)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (30, 926, 'LeftEye', 28)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (31, 926, 'Abnormalities', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (32, 926, 'Description', 31)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (33, 927, 'Right Top', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (34, 927, 'Left Top', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (35, 872, 'RightEar', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (36, 872, 'LeftEar', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (37, 873, 'RightEar', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (38, 873, 'LeftEar', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (39, 875, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (40, 875, 'Abnormalities', 39)	--Changed

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (41, 876, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (42, 876, 'Location', 41)	--Changed

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (43, 878, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (44, 878, 'Post Tracheostomy', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (45, 879, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (46, 879, 'Abnormalities', 45)	--Changed

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (47, 881, 'Findings', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (48, 882, 'Findings', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (49, 883, 'Findings', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (50, 884, 'Findings/Signs', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (51, 884, 'Location', 50)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (52, 885, 'Findings', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (53, 885, 'Types of abnormalities', 52)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (54, 886, 'Findings', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (55, 886, 'Types of abnormalities', 54)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (56, 887, 'Findings', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (57, 887, 'Types of abnormalities', 56)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (58, 889, 'Inspection', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (59, 890, 'Palpation', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (60, 891, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (61, 891, 'Description', 60)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (62, 892, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (63, 892, 'Description', 62)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (64, 893, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (65, 893, 'Description', 64)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (98, 914, 'Other Findings', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (66, 895, 'Type', NULL)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (67, 896, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (68, 896, 'Abnormalities', 67)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (69, 897, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (70, 897, 'Abnormalities', 69)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (71, 898, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (72, 898, 'Abnormalities', 71)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (73, 899, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (74, 899, 'Abnormalities', 73)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (75, 901, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (76, 901, 'Abnormalities', 75)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (77, 902, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (78, 902, 'Abnormalities', 77)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (79, 903, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (80, 903, 'Abnormalities', 79)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (81, 904, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (82, 904, 'Abnormalities', 81)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (83, 905, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (84, 905, 'Abnormalities', 83)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (85, 906, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (86, 906, 'Abnormalities', 85)

--INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (87, 907, 'Type', NULL)--new

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (87, 908, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (88, 908, 'Abnormalities', 87)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (89, 909, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (90, 909, 'Abnormalities', 89)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (91, 910, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (92, 910, 'Abnormalities', 91)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (93, 912, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (94, 912, 'Abnormalities', 93)

INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (95, 913, 'Type', NULL)
INSERT INTO ExaminationAttribute (AttributeID, ExaminationID, AttributeName, ParentAttributeID) VALUES (96, 913, 'Abnormalities', 95)


GO


TRUNCATE TABLE ExaminationAttributeValues
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (1, 1, 'Dry and Scaly Skin')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (2, 1, 'Dry Skin')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (3, 1, 'Moist Skin')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (4, 1, 'Rough Skin')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (5, 1, 'Oily Skin')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (6, 2, 'Cellulitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (7, 2, 'Eczema')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (8, 2, 'Psoriasis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (9, 2, 'Urticaria')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (10, 2, 'Rashes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (11, 2, 'Acne Vulgaris')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (12, 2, 'Tinea Infection')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (13, 2, 'Seborrheic Candidiasis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (14, 2, 'Atopic Dermatitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (15, 2, 'Vitiligo')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (16, 2, 'Chichen Plassus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (17, 2, 'Contact Dermatitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (18, 2, 'Warts')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (19, 2, 'Others')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (20, 3, 'Normal male balding')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (21, 3, 'Diffuse alopecia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (22, 3, 'Hirsutism')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (23, 3, 'Absent Secondary Sexual Hair')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (24, 3, 'Alopecia Areata')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (25, 3, 'Dandruff')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (26, 3, 'Pediculosis')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (27, 4, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (28, 4, 'AbNormal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (29, 4, 'Deformed Nails')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (30, 4, 'Discloured Nails')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (31, 4, 'Hypertrophied Nails')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (32, 4, 'Brittle Nails')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (33, 4, 'Leuconychia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (34, 4, 'Others')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (422, 5, ' ') --For Description

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (423, 6, 'No obvious Scars')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (424, 6, 'Hypertrophied Scar')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (425, 6, 'Keloid Scar')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (426, 6, 'Healed Scar')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (427, 7, 'Burn Scar')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (428, 7, 'Surgery')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (429, 7, 'Acne')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (430, 7, 'Needle/Body Piercing')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (35, 7, 'Chicken Pox')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (36, 7, 'Pregnancy')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (37, 7, 'Others')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (38, 8, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (39, 9, 'Aided')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (40, 9, 'UnAided')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (41, 10, ' ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (42, 97, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (43, 11, 'Aided')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (44, 11, 'UnAided')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (45, 12, ' ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (46, 99, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (47, 13, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (48, 13, 'Abnormal (Right Eye)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (49, 13, 'Abnormal (Left Eye)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (50, 13, 'Abnormal (Both Eyes)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (51, 14, 'Red-Green Deficiency')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (52, 14, 'Dichromatism')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (53, 14, 'Protanopia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (54, 14, 'Deuteranopia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (55, 14, 'Monochromatism')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (56, 14, 'Achromatopsia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (57, 14, 'Others')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (58, 15, 'Right')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (59, 15, 'Left')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (60, 15, 'Both')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (61, 16, 'Absent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (62, 16, 'Present (Right Eye)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (63, 16, 'Present (Left Eye)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (64, 16, 'Present (Both Eyes)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (65, 17, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (66, 18, 'Absent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (67, 18, 'Present (Right Eye)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (68, 18, 'Present (Left Eye)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (69, 18, 'Present (Both Eyes)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (70, 19, 'Diabetes Mellitus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (71, 19, 'Hypercholesterolemia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (72, 19, 'Family Hypercholesterolemia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (73, 19, 'Biliary Cirrhosis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (74, 19, 'Others')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (75, 20, 'Absent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (76, 20, 'Right Eye')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (77, 20, 'Left Eye')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (78, 20, 'Abnormal (Both Eyes)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (79, 21, 'Esotropia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (80, 21, 'Exotropia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (81, 21, 'Hypertropia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (82, 21, 'Hypotropia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (83, 21, 'Nystagmus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (84, 21, 'Strabismus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (85, 21, 'Orbital Fracture')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (86, 21, 'Others')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (87, 23, ' ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (88, 24, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (89, 26, 'Round')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (431, 26, 'Deformed')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (90, 27, 'Round')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (432, 27, 'Deformed')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (91, 29, 'Brisk')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (92, 29, 'Sluggish')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (93, 29, 'None')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (94, 30, 'Brisk')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (95, 30, 'Sluggish')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (96, 30, 'None')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (97, 31, 'Miosis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (98, 31, 'Mydriasis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (99, 31, 'Anisocoria')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (100, 32, 'Others')
--INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (101, 32, 'Others')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (102, 33, ' ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (103, 34, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (104, 35, 'Ear Wax')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (105, 35, 'Foreign Body')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (106, 35, 'Eczema')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (107, 35, 'Ear Tenderness')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (108, 35, 'AuditoryCanal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (109, 35, 'Edematous Cellutitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (110, 35, 'Others')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (111, 36, 'Ear Wax(Hard Cerumen)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (112, 36, 'Suggestive of (S/O)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (113, 36, 'Otitis Externa')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (114, 36, 'Others')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (115, 37, 'Inflammed')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (116, 37, 'Amber-Colored')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (117, 37, 'Bulging')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (118, 37, 'Translucent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (119, 37, 'Perforation')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (120, 37, 'Retracted')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (121, 37, 'Fluid Level')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (122, 38, 'Inflammed')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (123, 38, 'Amber-Colored')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (124, 38, 'Bulging')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (434, 38, 'Translucent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (435, 38, 'Perforation')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (436, 38, 'Retracted')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (437, 38, 'Fluid Level')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (125, 39, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (126, 39, 'AbNormal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (127, 40, 'Thyroid gland swelling (Enlargement)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (128, 40, 'Presence of bruit')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (130, 41, 'Not Swollen')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (131, 41, 'Lymphademopathy')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (132, 42, 'Supraclavicular (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (133, 42, 'Cervical (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (134, 42, 'Submandibular (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (135, 42, 'Axillary (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (136, 42, 'Auricular (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (137, 42, 'Tonsillar (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (138, 42, 'Inguinal (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (139, 42, 'Supraclavicular (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (140, 42, 'Cervical (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (141, 42, 'Submandibular (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (142, 42, 'Axillary (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (143, 42, 'Auricular (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (144, 42, 'Tonsillar (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (145, 42, 'Inguinal (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (146, 42, 'Supraclavicular (Both)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (147, 42, 'Cervical (Both)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (148, 42, 'Submandibular (Both)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (149, 42, 'Axillary (Both)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (150, 42, 'Auricular (Both)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (151, 42, 'Tonsillar (Both)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (152, 42, 'Inguinal (Both)')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (153, 43, 'Central')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (154, 43, 'Deviated to Right')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (155, 43, 'Deviated to Left')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (156, 44, 'Post Tracheostomy')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (157, 45, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (158, 45, 'Abnormal')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (159, 46, 'Bilateral crackles')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (160, 46, 'Right-sided crackles')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (161, 46, 'Left-sided crackles')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (162, 46, 'Rhonchi')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (163, 46, 'Wheeze')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (164, 46, 'Bronchial sounds')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (165, 46, 'Prolonged expiration')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (166, 47, 'Regular')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (167, 47, 'IrRegular')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (168, 47, 'IrRegularly regular')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (169, 47, 'IrRegularly irregular')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (170, 47, 'Regularly regular')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (171, 47, 'Regularly irregular')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (172, 48, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (173, 48, 'High Volume')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (174, 48, 'Low Volume')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (175, 49, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (176, 49, 'Anacrotic Pulse')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (177, 49, 'Pulsus Bisferiens')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (178, 49, 'Pulsus Alternans')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (179, 49, 'Pulsus Paradoxus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (180, 49, 'Water-Hammer Pulse')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (181, 49, 'Pulsus Parvus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (182, 49, 'Pulsus Parvus et tardus')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (183, 50, 'Felt in All Limbs')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (184, 50, 'Weak')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (185, 50, 'Absent')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (186, 51, 'Lower limbs')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (187, 51, 'Dorsalis pedis (right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (188, 51, 'Dorsalis pedis (left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (438, 51, 'Posterior tibial (right)')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (189, 52, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (190, 52, 'Abnormal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (191, 53, 'Hearing')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (192, 53, 'Displaced')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (193, 53, 'Hyperdynamic')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (194, 53, 'Tapping')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (195, 53, 'Diffuse')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (196, 53, 'Not Palpable')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (197, 53, 'Right Side')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (198, 54, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (199, 54, 'Abnormal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (200, 55, 'Loud S1')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (201, 55, 'Loud S2')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (202, 55, 'Soft S1')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (203, 55, 'S3 Present')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (204, 55, 'S4 Present')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (205, 55, 'Opening Snap')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (206, 55, 'Ejection Snap')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (433, 55, 'Loud P2')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (207, 56, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (208, 56, 'Abnormal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (209, 57, 'Ejection Systolic Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (210, 57, 'Pan Systolic Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (211, 57, 'Mid Systolic Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (212, 57, 'Early Diastolic Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (213, 57, 'Mid Diastolic Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (214, 57, 'Continuous Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (215, 57, 'To-and-Fro Murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (216, 57, 'Systolic murmur')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (217, 58, 'Scars')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (218, 58, 'Striae Gravida')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (219, 58, 'Distended')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (220, 58, 'Flat')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (221, 58, 'Dilated Veins')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (222, 58, 'Inveited Umblicus')
--INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (223, 58, 'Description')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (224, 59, 'Soft and Tender')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (225, 59, 'Soft and non-Tender')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (226, 59, 'Rigid')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (227, 59, 'Guarding')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (228, 59, 'Rebound Tenderness')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (229, 59, 'Doughy')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (230, 59, 'Renal angle Tenderness')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (231, 60, 'Not Palpable')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (232, 60, 'Palpable')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (233, 60, 'Palpable and Tender')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (234, 61, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (235, 62, 'Not Palpable')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (236, 62, 'Palpable')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (237, 62, 'Palpable and Tender')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (238, 63, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (239, 64, 'Not Ballotable')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (240, 64, 'Ballotable right kidney')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (241, 64, 'Ballotable left kidney')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (242, 64, 'Ballotable absent right kidney')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (243, 64, 'Ballotable absent left kidney')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (244, 64, 'Pelvic kidney')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (245, 64, 'Horshoe kidney')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (246, 65, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (247, 98, ' ')


----Oral Cavity (General Appearance)
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (248, 66, 'Clean')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (249, 66, 'Poorly Maintained')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (250, 66, 'Halitosis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (251, 66, 'Angular Stomatitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (252, 66, 'Others')

--Teeth
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (253, 67, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (254, 67, 'Abnormal')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (255, 68, 'dental Caries')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (256, 68, 'Broken Tooth')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (257, 68, 'Malaligned Teeth')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (258, 68, 'Edentulous')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (259, 68, 'Removable Dentures')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (260, 68, 'Permenant Fixations')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (261, 68, 'Plaques')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (262, 68, 'Loose Teeth')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (263, 68, 'Others')

--Tongue
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (264, 69, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (265, 69, 'Abnormal')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (266, 70, 'Glosssitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (267, 70, 'Coated Tongue')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (268, 70, 'Candidial Infection')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (269, 70, 'Fissmed Tongue')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (270, 70, 'Aphthous ulcer')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (271, 70, 'Bite Injury')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (272, 70, 'Strawbery Tongue')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (273, 70, 'Inflammed Tongue')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (274, 70, 'Bald Tongue ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (275, 70, 'Others')

--Tonsils
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (276, 71, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (277, 71, 'Absent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (278, 71, 'Abnormal')



INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (279, 72, 'Enlarged tonsils')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (280, 72, 'Inflammed')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (281, 72, 'Pustular Nodules present')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (282, 72, 'Tonsillar abscess')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (283, 72, 'Others')

--Pharynx

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (284, 73, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (285, 73, 'Abnormal')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (286, 74, 'Pharynxgitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (287, 74, 'Inflammed')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (288, 74, 'Pustular Nodules')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (289, 74, 'Ocdematous')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (290, 74, 'Others')


----Neurological Examination
--Cranial Nerves

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (291, 75, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (292, 75, 'Abnormal')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (293, 76, 'Right Olfactory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (294, 76, 'Left Olfactory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (295, 76, 'Both Olfactory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (296, 76, 'Right Optic')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (297, 76, 'Left Optic')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (298, 76, 'Both Optic')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (299, 76, 'Right Oculomotor')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (300, 76, 'Left Oculomotor')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (301, 76, 'Both Oculomotor')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (302, 76, 'Right Trochlear')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (303, 76, 'Left Trochlear')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (304, 76, 'Both Trochlear')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (305, 76, 'Right Trigeminal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (306, 76, 'Left Trigeminal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (307, 76, 'Both Trigeminal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (308, 76, 'Right Abducent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (309, 76, 'Left Abducent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (310, 76, 'Both Abducent')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (311, 76, 'Right Facial')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (312, 76, 'Left Facial')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (313, 76, 'Both Facial')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (314, 76, 'Right Auditory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (315, 76, 'Left Auditory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (316, 76, 'Both Auditory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (317, 76, 'Right Glossopharygeal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (318, 76, 'Left Glossopharygeal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (319, 76, 'Both Glossopharygeal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (320, 76, 'Right Vagal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (321, 76, 'Left Vagal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (322, 76, 'Both Vagal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (323, 76, 'Right Accessory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (324, 76, 'Left Accessory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (325, 76, 'Both Accessory')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (326, 76, 'Right Hypoglossal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (327, 76, 'Left Hypoglossal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (328, 76, 'Both Hypoglossal')


--Sensory System

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (329, 77, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (330, 77, 'Abnormal')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (331, 78, 'Diabetic Foot')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (332, 78, 'Peripheral Hemopathy')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (333, 78, 'Unilateral Sensory deficit')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (334, 78, 'Sensory loss over finger')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (335, 78, 'Hemiplegic Sensory loss')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (336, 78, 'Paraplegic Sensory loss')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (337, 78, 'Facial Sensory loss')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (338, 78, 'Harseris Hemopathy')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (339, 78, 'Others')




--Reflexes

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (340, 79, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (341, 79, 'Abnormal')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (342, 80, 'Diminished reflexes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (343, 80, 'Absent reflexes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (344, 80, 'Exaggerated reflexes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (345, 80, 'Unilateral loss Right - sided reflexes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (346, 80, 'Unilateral loss Left - sided reflexes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (347, 80, 'Others')


-- Motor System


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (348, 81, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (349, 81, 'Abnormal')



INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (350, 82, 'Proximal muscle weakness')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (351, 82, 'Muscle group weakness')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (352, 82, 'Muscle stiffness')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (353, 82, 'Muscle wasting')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (354, 82, 'Paralysed limb')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (355, 82, 'Paraplgia')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (356, 82, 'Right Hemiplegic ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (357, 82, 'Left Hemiplegic ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (358, 82, 'Others')



--Musculo Skeletal system

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (359, 83, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (360, 83, 'Abnormal')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (361, 84, 'Osteoarthritis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (362, 84, 'Rheumatoid arthritis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (363, 84, 'Lumbar spondylosis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (364, 84, 'Cerrical spondylosis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (365, 84, 'Periarthritis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (366, 84, 'Synovitis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (367, 84, 'Others')


--Gait

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (368, 85, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (369, 85, 'Abnormal')


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (370, 86, 'Slow gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (371, 86, 'Staggering gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (372, 86, 'Shuffling gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (373, 86, 'Waddling gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (374, 86, 'Sailor gait' )
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (375, 86, 'Spastic gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (376, 86, 'Scissoring')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (377, 86, 'Spastic gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (378, 86, 'Propulsive gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (379, 86, 'Trendelenburg gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (380, 86, 'High-Stepping gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (381, 86, 'Antalgic gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (382, 86, 'Magnetic gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (383, 86, 'Pigeon gait')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (384, 86, 'Others')

----Gynaecological Examination

--Gynaecological Examination

--INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (385, 87, 'Normal')
--INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (386, 87, 'Abnormal')

--External Genetaila

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (395, 91, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (396, 91, 'Abnormal')



INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (389, 92, 'bartholins abscess')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (390, 92, 'Candidianis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (391, 92, 'Trichomaniasis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (392, 92, 'herpes simplex')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (393, 92, 'Ulcer')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (394, 92, 'Others')



--Breasts

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (387, 87, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (388, 87, 'Abnormal')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (397, 88, 'Adenomyosis')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (398, 88, 'Fibroadenoma')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (399, 88, 'Breast lump')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (400, 88, 'Nipple retraction')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (401, 88, 'Nipple discharge')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (402, 88, 'la breast')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (403, 88, 'Post mastectomy')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (404, 88, 'galactorrhea')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (405, 88, 'Others')


--Uterus


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (406, 89, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (407, 89, 'Abnormal')



INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (408, 90, 'Anteverted ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (409, 90, 'Retroverted')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (410, 90, 'Fibroids')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (411, 90, 'Cervical erosious ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (412, 90, 'Cervical ulceration')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (413, 90, 'Prolapse')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (414, 90, 'Adnexial mass')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (415, 90, 'Others')




INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (416, 93, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (417, 93, 'Abnormal')
--INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (418, 94, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (419, 95, 'Normal')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (420, 95, 'Abnormal')
--INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (421, 96, ' ')

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (439, 98, ' ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (440, 94, ' ')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (441, 96, ' ')

--Newly Added On Feb-05
--Thyroid gland
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (442, 39, 'Not Palpable')

--Thyroid gland (abnormal)
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (129, 40, 'Asymmetrical lobes')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (443, 40, 'Nodular goiter')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (444, 40, 'Palpable thrill')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (445, 40, 'Others')

--Breath Sounds (abnormal)


INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (446, 46, 'Stridor')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (447, 46, 'Pleural friction rub')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (448, 46, 'Vocal fremitus')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (449, 46, 'Others')

--Heart Sounds(abnormal)

INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (450, 55, 'S3 gallop')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (451, 55, 'LVS4 present')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (452, 55, 'Pericardial rub')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (453, 55, 'Split S2')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (454, 55, 'Others') 

--Heart Mummurs (abnormal)
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (455, 57, 'Diastolic murmur')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (456, 57, 'Others')

--Peripheral Pulses (abnormal)
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (457, 51, 'Carotid (Right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (458, 51, 'Carotid (Left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (459, 51, 'Brachial (right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (460, 51, 'Brachial (left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (461, 51, 'Posterior tibial (left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (462, 51, 'Femoral (right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (463, 51, 'Femoral (left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (464, 51, 'Radial (right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (465, 51, 'Radial (left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (466, 51, 'Ulnar (right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (467, 51, 'Ulnar (left)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (468, 51, 'Popliteal (right)')
INSERT INTO ExaminationAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (469, 51, 'Popliteal (left)')

GO

