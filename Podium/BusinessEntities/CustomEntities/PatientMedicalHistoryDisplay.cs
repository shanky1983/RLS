using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientMedicalHistoryDisplay
    {
        private long _sno;
        private int _complaintID;
        private string _complaintName;
        private long _complaintAttributeId;
        private string _complaintHistoryDuration;
        private long _complaintHistoryDurationID;
        private string _complaintHistoryDurationValue;
        private string _attributeName;
        private string _eyesMedicalHistory;
        private string _eyesMedicalHistoryValue;
        private long _patientID;
        private long _patientVisitID;
        private long _treatmentId;
        private long _identifingTypeCode;
        private string _iPTreatmentPlanName;
        private long _medicalHistoryDurationAttributeID;
        private string _medicalHistoryDurationValueDisplay;
        private long _medicalHistoryDurationAttributevalueID;
        private string _medicalHistoryDurationValue;
        private long _mastTreatmentValueId;
        private string _pastTreatmentStatus;
        private string _notes;
        private long _notesPatientAttributeValueId;
        private long _pastPatientAttributeValueId;
        private long _durationPatientAttributeValueId;
        private long _patientComplaintAttributeId;
        private long _seqID;
        private long _eyesPatientAttributeValueId;
        private long _complaintPatientAttributeId;
        private long _treatmentPatientAttributeId;
        private long _eyesAttributeValueId;
        private long _eyesAttributeId;
        private long _treatmentPatientAttributeValueId;

        public long Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public int ComplaintID
        {
            get { return _complaintID; }
            set { _complaintID = value; }
        }
        public string ComplaintName
        {
            get { return _complaintName; }
            set { _complaintName = value; }
        }
        public long ComplaintAttributeId
        {
            get { return _complaintAttributeId; }
            set { _complaintAttributeId = value; }
        }
        public string ComplaintHistoryDuration
        {
            get { return _complaintHistoryDuration; }
            set { _complaintHistoryDuration = value; }
        }
        public long ComplaintHistoryDurationID
        {
            get { return _complaintHistoryDurationID; }
            set { _complaintHistoryDurationID = value; }
        }
        public string ComplaintHistoryDurationValue
        {
            get { return _complaintHistoryDurationValue; }
            set { _complaintHistoryDurationValue = value; }
        }
        public string AttributeName
        {
            get { return _attributeName; }
            set { _attributeName = value; }
        }
        public string EyesMedicalHistory
        {
            get { return _eyesMedicalHistory; }
            set { _eyesMedicalHistory = value; }
        }
        public string EyesMedicalHistoryValue
        {
            get { return _eyesMedicalHistoryValue; }
            set { _eyesMedicalHistoryValue = value; }
        }
        public long PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }
        public long PatientVisitID
        {
            get { return _patientVisitID; }
            set { _patientVisitID = value; }
        }
        public long TreatmentId
        {
            get { return _treatmentId; }
            set { _treatmentId = value; }
        }
        public long IdentifingTypeCode
        {
            get { return _identifingTypeCode; }
            set { _identifingTypeCode = value; }
        }
        public string IPTreatmentPlanName
        {
            get { return _iPTreatmentPlanName; }
            set { _iPTreatmentPlanName = value; }
        }
        public long MedicalHistoryDurationAttributeID
        {
            get { return _medicalHistoryDurationAttributeID; }
            set { _medicalHistoryDurationAttributeID = value; }
        }
        public string MedicalHistoryDurationValueDisplay
        {
            get { return _medicalHistoryDurationValueDisplay; }
            set { _medicalHistoryDurationValueDisplay = value; }
        }
        public long MedicalHistoryDurationAttributevalueID
        {
            get { return _medicalHistoryDurationAttributevalueID; }
            set { _medicalHistoryDurationAttributevalueID = value; }
        }
        public string MedicalHistoryDurationValue
        {
            get { return _medicalHistoryDurationValue; }
            set { _medicalHistoryDurationValue = value; }
        }
        public long PastTreatmentValueId
        {
            get { return _mastTreatmentValueId; }
            set { _mastTreatmentValueId = value; }
        }
        public string PastTreatmentStatus
        {
            get { return _pastTreatmentStatus; }
            set { _pastTreatmentStatus = value; }
        }
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
        public long NotesPatientAttributeValueId
        {
            get { return _notesPatientAttributeValueId; }
            set { _notesPatientAttributeValueId = value; }
        }
        public long PastPatientAttributeValueId
        {
            get { return _pastPatientAttributeValueId; }
            set { _pastPatientAttributeValueId = value; }
        }
        public long DurationPatientAttributeValueId
        {
            get { return _durationPatientAttributeValueId; }
            set { _durationPatientAttributeValueId = value; }
        }
        public long PatientComplaintAttributeId
        {
            get { return _patientComplaintAttributeId; }
            set { _patientComplaintAttributeId = value; }
        }
        public long SeqID
        {
            get { return _seqID; }
            set { _seqID = value; }
        }
        public long EyesPatientAttributeValueId
        {
            get { return _eyesPatientAttributeValueId; }
            set { _eyesPatientAttributeValueId = value; }
        }
        public long ComplaintPatientAttributeId
        {
            get { return _complaintPatientAttributeId; }
            set { _complaintPatientAttributeId = value; }
        }
        public long TreatmentPatientAttributeId
        {
            get { return _treatmentPatientAttributeId; }
            set { _treatmentPatientAttributeId = value; }
        }
        public long EyesAttributeValueId
        {
            get { return _eyesAttributeValueId; }
            set { _eyesAttributeValueId = value; }
        }
        public long EyesAttributeId
        {
            get { return _eyesAttributeId; }
            set { _eyesAttributeId = value; }
        }
        public long TreatmentPatientAttributeValueId
        {
            get { return _treatmentPatientAttributeValueId; }
            set { _treatmentPatientAttributeValueId = value; }
        }
        private string createdDate;
        public string CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private string createdTime;
        public string CreatedTime
        {
            get { return createdTime; }
            set { createdTime = value; }
        }
        private string createdDateTime;
        public string CreatedDateTime
        {
            get { return createdDateTime; }
            set { createdDateTime = value; }
        }
    }
} 
