
INSERT INTO Complaint(ComplaintId,ComplaintName,ComplaintDesc,HashAttribute)values(536,'Thalassemia Trait','Thalassemia Trait','Y')
INSERT INTO Complaint(ComplaintId,ComplaintName,ComplaintDesc,HashAttribute)values(537,'Hepatitis B carrier','Hepatitis B carrier','Y')

UPDATE Complaint Set HashAttribute='Y' WHERE ComplaintId in(402,332,389,438,409,372,246,536,537)


TRUNCATE TABLE ComplaintAttribute
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (1, 402, 'Duration', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (2, 402, 'Treatment', NULL)

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (3, 332, 'Disease Type', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (4, 332, 'Disease', NULL)

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (5, 389, 'Duration', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (6, 389, 'Type', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (7, 389, 'Treatment', NULL)


INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (8, 438, 'Date', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (9, 438, 'Recovery', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (10, 438, 'Type Of CVA', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (11, 438, 'Area/Loab Affected', 10)--parent id



INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (12, 409, 'Duration', NULL)

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (13, 372, 'Type Of Cancer', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (14, 372, 'Stage Of Cancer', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (15, 372, 'Treatment', NULL)

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (16, 246, 'Duration', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (17, 246, 'Treatment', NULL)--need 
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (18, 246, 'Exacerbations', NULL)

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (19, 536, 'Trait', NULL)

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (20, 537, 'Duration', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (21, 537, 'Treatment', NULL)--need

INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (22, 0, 'Surgery Name', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (23, 0, 'Date', NULL)
INSERT INTO ComplaintAttribute(AttributeID, ComplaintId, AttributeName, ParentAttributeID) VALUES (24, 0, 'Hospital', NULL)






--ComplaintAttributeValues

TRUNCATE TABLE ComplaintAttributeValues


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (1, 1, 'Year')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (2, 1, 'Months')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (3, 1, 'Weeks')



INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (4, 2, 'Beta-Blockers')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (5, 2, 'CCB')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (6, 2, 'ACEI/ARB')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (7, 2, 'ACEI/ARB-diuretic')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (8, 2, 'Alpha-Blockers')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (9, 2, 'Others')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (10, 3, 'Coronary artery disease')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (11, 3, 'Congenital heart disease')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (12, 3, 'Arrhythmia')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (13, 3, 'Valvular Heart disease')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (14, 3, 'Heart Failure')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (15, 3, 'cardiomypathy')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (16, 3, 'Others')




INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (17, 4, '')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (18, 5, 'Year')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (19, 5, 'Months')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (20, 5, 'Weeks')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (21, 6, 'Type2')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (22, 6, 'Type1')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (23, 6, 'MODY')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (24, 6, 'IGT')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (25, 7, 'None')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (26, 7, 'OHAs')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (27, 7, 'OHAs-insulin')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (28, 7, 'insulin')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (29, 7, 'Native medicin')



INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (30, 8, '')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (31, 9, 'Fully Recovered')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (32, 9, 'Partially Recovered')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (33, 9, 'Not Recovered')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (34, 10, 'Infarct')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (35, 10, 'Hemorrhage')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (36, 11, '')



INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (37, 12, 'Year')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (38, 12, 'Months')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (39, 12, 'Weeks')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (40, 13, 'Breast' )
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (41, 13, 'Prostate')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (42, 13, 'Liver')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (43, 13, 'Kidney')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (44, 13, 'Lung')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (45, 13, 'ovarian')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (46, 13, 'Leukemia')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (47, 14, 'Stage1')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (48, 14, 'Stage11')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (49, 14, 'Stage111')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (50, 14, 'Stage11v')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (51, 15, 'Chemotherapy')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (52, 15, 'Radiationtherapy')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (53, 15, 'both')





INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (54, 16, 'Year')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (55, 16, 'Months')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (56, 16, 'Weeks')





INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (57, 18, 'Year')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (58, 18, 'Months')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (59, 18, 'Weeks')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (60, 19, 'alpha')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (61, 19, 'Beta')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (62, 19, 'gamma')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (63, 20, 'Year')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (64, 20, 'Months')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (65, 20, 'Weeks')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (66, 21, '')
--treatment in 246,17

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (67, 17, 'No Treatment')

INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (68, 7, 'Others')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (69, 10, 'Hemorrhagic Infarct')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (70, 17, 'Steroids')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (71, 17, 'Bronchodilators')


INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (72, 13, 'Others')
INSERT INTO ComplaintAttributeValues (AttributevalueID, AttributeID, AttributeValueName) VALUES (73, 15, 'Others')








