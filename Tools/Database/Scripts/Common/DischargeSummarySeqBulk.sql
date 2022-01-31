
--Default Org Bulk Load
Truncate Table DischargeSummarySeq
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder1','~/DischargeSummary/PatientDetails.ascx','Patient Details',12,'Y',1)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder2','~/DischargeSummary/DateOfAdmission.ascx','Date And Time Of Admission',12,'Y',2)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder3','~/DischargeSummary/DateOfSurgery.ascx','Date And Time of Surgery',12,'Y',3)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder4','~/DischargeSummary/DateOfDischarge.ascx','Date And Time of Discharge',12,'Y',4)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder5','~/DischargeSummary/TypeOfDischarge.ascx','Type of Discharge',12,'Y',5)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder6','~/DischargeSummary/PrimaryConsultant.ascx','Primary Consultant',12,'Y',6)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder7','~/DischargeSummary/ChiefSurgeon.ascx','Chief Surgeon',12,'Y',7)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder8','~/DischargeSummary/PatientAddress.ascx','Address',12,'Y',8)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder9','~/DischargeSummary/ConditionOnDischarge.ascx','CONDITION ON DISCHARGE',12,'Y',9)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder10','~/DischargeSummary/Diagnose.ascx','DIAGNOSIS',12,'Y',10)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder11','~/DischargeSummary/Procedure.ascx','PROCEDURES',12,'N',11)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder12','~/DischargeSummary/History.ascx','HISTORY',12,'Y',12)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder13','~/DischargeSummary/TreatmentPlan.ascx','TREATMENT PLAN',12,'Y',13)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder14','~/DischargeSummary/BackrounMedicalProblem.ascx','BACKROUND MEDICAL PROBLEMS',12,'Y',14)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder15','~/DischargeSummary/AdmissionVitals.ascx','ADMISSION VITALS',12,'Y',15)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder16','~/DischargeSummary/GeneralExamination.ascx','GENERAL EXAMINATION',12,'Y',16)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder17','~/DischargeSummary/SystemicExamination.ascx','Systemic Examination',12,'Y',17)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder18','~/DischargeSummary/DischargeVitals.ascx','DISCHARGE VITALS',12,'Y',18)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder19','~/DischargeSummary/SurgeryDetails.ascx','SURGERY / PROCEDURE DETAILS',12,'Y',19)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder20','~/DischargeSummary/CourseInHospital.ascx','COURSE IN THE HOSPITAL',12,'Y',20)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder21','~/DischargeSummary/Advice.ascx','ADVICE',12,'Y',21)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder22','~/DischargeSummary/DischargePrescription.ascx','DISCHARGE PRESCRIPTION',12,'Y',22)




--Bulk Load Sp 
CREATE TABLE #TempOrgID
(
OrgID int
)


INSERT INTO #TempOrgID
SELECT OrgID from Organization

DECLARE @MinValue int
DECLARE @MaxValue int

SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID)
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID)

WHILE @MinValue <= @MaxValue
BEGIN

IF(@MinValue=(SELECT OrgID FROM Organization WHERE OrgID=@MinValue) and @MinValue<>12)
BEGIN
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)
SELECT PlaceHolderID,ControlName,HeaderName,@MinValue,IsActive ,SequenceNo
       FROM DischargeSummarySeq  WHERE OrgID=12
       
      
      
END

  SET @MinValue = @MinValue + 1
      
END

DROP TABLE #TempOrgID

DELETE FROM DischargeSummarySeq WHERE OrgID=55


--Bulk Load For KDR Hospital
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder1','~/DischargeSummary/PatientDetails.ascx','Patient Details',55,'Y',1)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder2','~/DischargeSummary/PatientAddress.ascx','Address',55,'Y',2)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder3','~/DischargeSummary/DateOfAdmission.ascx','Date Of Admission',55,'Y',3)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder4','~/DischargeSummary/DateOfSurgery.ascx','Date of Surgery',55,'Y',4)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder5','~/DischargeSummary/DateOfDischarge.ascx','Date of Discharge',55,'Y',5)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder6','~/DischargeSummary/TypeOfDischarge.ascx','Type of Discharge',55,'Y',6)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder7','~/DischargeSummary/PrimaryConsultant.ascx','Primary Consultant',55,'Y',7)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder8','~/DischargeSummary/ChiefSurgeon.ascx','Chief Surgeon',55,'N',8)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder9','~/DischargeSummary/Diagnose.ascx','DIAGNOSIS',55,'Y',9)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder10','~/DischargeSummary/Procedure.ascx','PROCEDURES',55,'N',10)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder11','~/DischargeSummary/History.ascx','HISTORY',55,'Y',11)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder12','~/DischargeSummary/TreatmentPlan.ascx','TREATMENT PLAN',55,'Y',12)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder13','~/DischargeSummary/BackrounMedicalProblem.ascx','BACKROUND MEDICAL PROBLEMS',55,'Y',13)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder14','~/DischargeSummary/AdmissionVitals.ascx','ADMISSION VITALS',55,'Y',14)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder15','~/DischargeSummary/GeneralExamination.ascx','GENERAL EXAMINATION',55,'Y',15)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder16','~/DischargeSummary/SystemicExamination.ascx','Systemic Examination',55,'Y',16)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder17','~/DischargeSummary/DischargeVitals.ascx','DISCHARGE VITALS',55,'Y',17)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder18','~/DischargeSummary/SurgeryDetails.ascx','SURGERY / PROCEDURE DETAILS',55,'Y',18)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder19','~/DischargeSummary/CourseInHospital.ascx','COURSE IN THE HOSPITAL',55,'Y',19)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder20','~/DischargeSummary/ConditionOnDischarge.ascx','CONDITION ON DISCHARGE',55,'Y',20)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder21','~/DischargeSummary/Advice.ascx','ADVICE',55,'Y',21)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder22','~/DischargeSummary/DischargePrescription.ascx','DISCHARGE PRESCRIPTION',55,'Y',22)


DELETE FROM DischargeSummarySeq WHERE OrgID=50
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder1','~/DischargeSummary/PatientDetails.ascx','Patient Details',50,'Y',1)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder2','~/DischargeSummary/DateOfAdmission.ascx','Date And Time Of Admission',50,'Y',2)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder3','~/DischargeSummary/DateOfSurgery.ascx','Date And Time of Surgery',50,'Y',3)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder4','~/DischargeSummary/DateOfDischarge.ascx','Date And Time of Discharge',50,'Y',4)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder5','~/DischargeSummary/TypeOfDischarge.ascx','Type of Discharge',50,'Y',5)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder6','~/DischargeSummary/PrimaryConsultant.ascx','Primary Consultant',50,'Y',6)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder7','~/DischargeSummary/ChiefSurgeon.ascx','Chief Surgeon',50,'Y',7)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder8','~/DischargeSummary/PatientAddress.ascx','Address',50,'Y',8)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder9','~/DischargeSummary/ConditionOnDischarge.ascx','CONDITION ON DISCHARGE',50,'Y',9)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder10','~/DischargeSummary/Diagnose.ascx','DIAGNOSIS',50,'Y',10)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder11','~/DischargeSummary/Procedure.ascx','PROCEDURES',50,'N',11)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder12','~/DischargeSummary/History.ascx','HISTORY',50,'Y',12)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder13','~/DischargeSummary/TreatmentPlan.ascx','TREATMENT PLAN',50,'Y',13)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder14','~/DischargeSummary/BackrounMedicalProblem.ascx','BACKROUND MEDICAL PROBLEMS',50,'Y',14)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder15','~/DischargeSummary/AdmissionVitals.ascx','ADMISSION VITALS',50,'Y',15)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder16','~/DischargeSummary/GeneralExamination.ascx','GENERAL EXAMINATION',50,'Y',16)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder17','~/DischargeSummary/SystemicExamination.ascx','Systemic Examination',50,'Y',17)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder18','~/DischargeSummary/DischargeVitals.ascx','DISCHARGE VITALS',50,'Y',18)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder19','~/DischargeSummary/SurgeryDetails.ascx','SURGERY / PROCEDURE DETAILS',50,'Y',19)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder20','~/DischargeSummary/CourseInHospital.ascx','COURSE IN THE HOSPITAL',50,'Y',20)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder21','~/DischargeSummary/Advice.ascx','ADVICE',50,'Y',21)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder22','~/DischargeSummary/DischargePrescription.ascx','DISCHARGE PRESCRIPTION',50,'Y',22)

DELETE from DischargeSummarySeq where OrgID=62
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder1','~/DischargeSummary/PatientDetails.ascx','Patient Details',62,'Y',1)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder2','~/DischargeSummary/DateOfAdmission.ascx','Date And Time Of Admission',62,'Y',2)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder3','~/DischargeSummary/DateOfSurgery.ascx','Date And Time of Surgery',62,'Y',3)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder4','~/DischargeSummary/DateOfDischarge.ascx','Date And Time of Discharge',62,'Y',4)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder5','~/DischargeSummary/TypeOfDischarge.ascx','Type of Discharge',62,'Y',5)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder6','~/DischargeSummary/PrimaryConsultant.ascx','Primary Consultant',62,'Y',6)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder7','~/DischargeSummary/ChiefSurgeon.ascx','Chief Surgeon',62,'Y',7)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder8','~/DischargeSummary/PatientAddress.ascx','Address',62,'Y',8)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder9','~/DischargeSummary/ConditionOnDischarge.ascx','CONDITION ON DISCHARGE',62,'Y',9)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder10','~/DischargeSummary/Diagnose.ascx','FINAL DIAGNOSIS',62,'Y',10)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder11','~/DischargeSummary/Procedure.ascx','PROCEDURE(S)',62,'Y',11)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder12','~/DischargeSummary/History.ascx','HISTORY',62,'Y',12)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder13','~/DischargeSummary/TreatmentPlan.ascx','TREATMENT PLAN',62,'Y',13)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder14','~/DischargeSummary/BackrounMedicalProblem.ascx','BACKROUND MEDICAL PROBLEMS',62,'Y',14)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder15','~/DischargeSummary/AdmissionVitals.ascx','ADMISSION VITALS',62,'Y',15)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder16','~/DischargeSummary/GeneralExamination.ascx','ON EXAMINATION',62,'Y',16)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder17','~/DischargeSummary/SystemicExamination.ascx','Systemic Examination',62,'Y',17)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder18','~/DischargeSummary/DischargeVitals.ascx','DISCHARGE VITALS',62,'Y',18)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder19','~/DischargeSummary/SurgeryDetails.ascx','SURGERY / PROCEDURE DETAILS',62,'Y',19)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder20','~/DischargeSummary/CourseInHospital.ascx','COURSE IN THE HOSPITAL',62,'Y',20)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder21','~/DischargeSummary/Advice.ascx','ADVICE',62,'Y',21)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder22','~/DischargeSummary/DischargePrescription.ascx','DISCHARGE PRESCRIPTION',62,'Y',22)


DELETE FROM DischargeSummarySeq where OrgID=78
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder1','~/DischargeSummary/KMHPatientDetails.ascx','Patient Details',78,'Y',1)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder2','~/DischargeSummary/ConditionOnDischarge.ascx','CONDITION ON DISCHARGE',78,'Y',2)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder3','~/DischargeSummary/Diagnose.ascx','DIAGNOSIS',78,'Y',3)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder4','~/DischargeSummary/Procedure.ascx','PROCEDURES',78,'N',4)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder5','~/DischargeSummary/History.ascx','HISTORY',78,'Y',5)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder6','~/DischargeSummary/TreatmentPlan.ascx','TREATMENT PLAN',78,'Y',6)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder7','~/DischargeSummary/BackrounMedicalProblem.ascx','BACKROUND MEDICAL PROBLEMS',78,'Y',7)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder8','~/DischargeSummary/KMHAdmissionVitals.ascx','ADMISSION VITALS',78,'Y',8)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder9','~/DischargeSummary/GeneralExamination.ascx','GENERAL EXAMINATION',78,'Y',9)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder10','~/DischargeSummary/SystemicExamination.ascx','Systemic Examination',78,'Y',10)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder11','~/DischargeSummary/KMHDischargeVitals.ascx','DISCHARGE VITALS',78,'Y',11)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder12','~/DischargeSummary/SurgeryDetails.ascx','SURGERY / PROCEDURE DETAILS',78,'Y',12)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder13','~/DischargeSummary/PreOpInv.ascx','Pre-Op Investigation',78,'Y',13)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder14','~/DischargeSummary/PostOpInv.ascx','Post-Op Investigation',78,'Y',14)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder15','~/DischargeSummary/RoutineInv.ascx','Routine Investigation',78,'Y',15)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder16','~/DischargeSummary/CourseInHospital.ascx','COURSE IN THE HOSPITAL',78,'Y',16)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder17','~/DischargeSummary/Advice.ascx','ADVICE',78,'Y',17)
INSERT INTO DischargeSummarySeq(PlaceHolderID,ControlName,HeaderName,OrgID,IsActive,SequenceNo)VALUES('PlaceHolder18','~/DischargeSummary/DischargePrescription.ascx','DISCHARGE PRESCRIPTION',78,'Y',18)





       