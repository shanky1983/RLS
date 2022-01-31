using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PatientSurgicalDisplay
    {
        long _Sno;
        long _PatientAttributeID;
        long _PatientID;
        long _PatientVisitID;
        string _IPTreatmentPlanName;
        int _TreatmentPlanID;
        long _DateAttributeId;
        long _DateAttributeValueId;
        string _DateAttributeValueName;
        long _DatePatientAttributeValueId;
        long _SurgeryCentreAttributeId;
        long _SurgeryCentreAttributeValueId;
        string _SurgeryCentreAttributeValueName;
        long _SurgeryCentrePatientAttributeValueId;
        long _NotesAttributeId;
        long _NotesAttributeValueId;
        string _NotesAttributeValueName;
        long _NotesPatientAttributeValueId;
        long _SurgeryOnAttributeId;
        long _SurgeryOnAttributeValueId;
        string _SurgeryOnAttributeValueName;
        long _SurgeryOnPatientAttributeValueId;
        long _SurgeryPatientAttributeValueID;
    
        public long Sno 
        {
            get { return _Sno; }
            set { _Sno = value; }
        }
        public long PatientAttributeID
        {
            get { return _PatientAttributeID; }
            set { _PatientAttributeID = value; }
        }
        public long PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        public long PatientVisitID
        {
            get { return _PatientVisitID; }
            set { _PatientVisitID = value; }
        }
        public string IPTreatmentPlanName
        {
            get { return _IPTreatmentPlanName; }
            set { _IPTreatmentPlanName = value; }
        }
        public int TreatmentPlanID
        {
            get { return _TreatmentPlanID; }
            set { _TreatmentPlanID = value; }
        }
        public long DateAttributeId
        {
            get { return _DateAttributeId; }
            set { _DateAttributeId = value; }
        }
        public long DateAttributeValueId
        {
            get { return _DateAttributeValueId; }
            set { _DateAttributeValueId = value; }
        }
        public string DateAttributeValueName
        {
            get { return _DateAttributeValueName; }
            set { _DateAttributeValueName = value; }
        }
        public long DatePatientAttributeValueId
        {
            get { return _DatePatientAttributeValueId; }
            set { _DatePatientAttributeValueId = value; }
        }
        public long SurgeryCentreAttributeId
        {
            get { return _SurgeryCentreAttributeId; }
            set { _SurgeryCentreAttributeId = value; }
        }
        public long SurgeryCentreAttributeValueId
        {
            get { return _SurgeryCentreAttributeValueId; }
            set { _SurgeryCentreAttributeValueId = value; }
        }
        public string SurgeryCentreAttributeValueName
        {
            get { return _SurgeryCentreAttributeValueName; }
            set { _SurgeryCentreAttributeValueName = value; }
        }
        public long SurgeryCentrePatientAttributeValueId
        {
            get { return _SurgeryCentrePatientAttributeValueId; }
            set { _SurgeryCentrePatientAttributeValueId = value; }
        }
        public long NotesAttributeId
        {
            get { return _NotesAttributeId; }
            set { _NotesAttributeId = value; }
        }
        public long NotesAttributeValueId
        {
            get { return _NotesAttributeValueId; }
            set { _NotesAttributeValueId = value; }
        }
        public string NotesAttributeValueName
        {
            get { return _NotesAttributeValueName; }
            set { _NotesAttributeValueName = value; }
        }
        public long NotesPatientAttributeValueId
        {
            get { return _NotesPatientAttributeValueId; }
            set { _NotesPatientAttributeValueId = value; }
        }
        public long SurgeryOnAttributeId
        {
            get { return _SurgeryOnAttributeId; }
            set { _SurgeryOnAttributeId = value; }
        }
        public long SurgeryOnAttributeValueId
        {
            get { return _SurgeryOnAttributeValueId; }
            set { _SurgeryOnAttributeValueId = value; }
        }
        public string SurgeryOnAttributeValueName
        {
            get { return _SurgeryOnAttributeValueName; }
            set { _SurgeryOnAttributeValueName = value; }
        }
        public long SurgeryOnPatientAttributeValueId
        {
            get { return _SurgeryOnPatientAttributeValueId; }
            set { _SurgeryOnPatientAttributeValueId = value; }
        }
        public long SurgeryPatientAttributeValueID
        {
            get { return _SurgeryPatientAttributeValueID; }
            set { _SurgeryPatientAttributeValueID = value; }
        }
    }
}
