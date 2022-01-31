using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BirthHistoryDisplay
    {
        private long _sno;
        private string _birthstatus;
        private string _childhoodeyeproblem;
        private string _apgar;
        private string _birthhistorynotes;
        private string _iptreatmentplanname;
        private long _birthStatusId;
        private long _childhoodeyeProblemId;
        private long _PatientAttributeID;
		private long _TreatmentPatientAttributeID;
		private long _ChildPatientAttributeValueID;
		private long _ApgarPatientAttributeValueID;
        private long _BirthHistoryNotesPatientValueID;
        private long _ChildHoodAttributeID;
        private long _treatmentPatientAttributeValueID;
        private long _PatientVisitID;
        public long Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public long BirthStatusID
        {
            get { return _birthStatusId; }
            set { _birthStatusId = value; }
        }
        public long ChildHoodEyeProblemID
        {
            get { return _childhoodeyeProblemId; }
            set { _childhoodeyeProblemId = value; }
        }
        public string BirthStatus
        {
            get { return _birthstatus; }
            set { _birthstatus = value; }
        }
        public string ChildHoodEyeProblem
        {
            get { return _childhoodeyeproblem; }
            set { _childhoodeyeproblem = value; }
        }
        public string APGAR
        {
            get { return _apgar; }
            set { _apgar = value; }
        }
        public string BirthHistoryNotes
        {
            get { return _birthhistorynotes; }
            set { _birthhistorynotes = value; }
        }
        public string IPTreatmentPlanName
        {
            get { return _iptreatmentplanname; }
            set { _iptreatmentplanname = value; }
        }
        public long PatientAttributeID
        {
            get { return _PatientAttributeID; }
            set { _PatientAttributeID = value; }
        }
        public long TreatmentPatientAttributeID
        {
            get { return _TreatmentPatientAttributeID; }
            set { _TreatmentPatientAttributeID = value; }
        }
        public long ChildPatientAttributeValueID
        {
            get { return _ChildPatientAttributeValueID; }
            set { _ChildPatientAttributeValueID = value; }
        }
        public long ApgarPatientAttributeValueID
        {
            get { return _ApgarPatientAttributeValueID; }
            set { _ApgarPatientAttributeValueID = value; }
        }
        public long BirthHistoryNotesPatientValueID
        {
            get { return _BirthHistoryNotesPatientValueID; }
            set { _BirthHistoryNotesPatientValueID = value; }
        }
        public long ChildHoodAttributeID
        {
            get { return _ChildHoodAttributeID; }
            set { _ChildHoodAttributeID = value; }
        }
        public long treatmentPatientAttributeValueID
        {
            get { return _treatmentPatientAttributeValueID; }
            set { _treatmentPatientAttributeValueID = value; }
        }
        public long PatientVisitID
        {
            get { return _PatientVisitID; }
            set { _PatientVisitID = value; }
        }
    }
}
