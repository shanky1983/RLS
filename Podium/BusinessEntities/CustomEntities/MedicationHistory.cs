using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class MedicationHistory
    {

        private long _sno;
        private string _drugname;
        private string _dose;
        private string _frequerncy;
        private string _eyes;
        private string _duration;
        private string _period;
        private string _medicationnotes;
        private string _medicationEyeAttributeId;
        private string _medicationEyeAttributeValueId;
        private string _medicationDurationAttributeId;
        private string _medicationDurationAttributeValueId;
        private string _medicationActive;
        private long _MedicationActivePatientAttributeValueId;
        private long _MedicationNotesPatientAttributeValueId;
        private long _MedicationEyesPatientAttributeValueId;
        private long _MedicationDosePatientAttributeValueId;
        private long _MedicationDurationPatientAttributeValueId;
        private long _PatientAttributeID;
        private long _MedicationFrequencyAttributeValueID;
        private long _PatientVisitID;
        private long _MedicationDrugPatientAttributeValueId;

        public long Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public string DrugName
        {
            get { return _drugname; }
            set { _drugname = value; }
        }
        public string Dose
        {
            get { return _dose; }
            set { _dose = value; }
        }
        public string Frequerncy
        {
            get { return _frequerncy; }
            set { _frequerncy = value; }
        }
        public string Eyes
        {
            get { return _eyes; }
            set { _eyes = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public string Period
        {
            get { return _period; }
            set { _period = value; }
        }
        public string MedicationNotes
        {
            get { return _medicationnotes; }
            set { _medicationnotes = value; }
        }
        public string MedicationEyeAttributeId
        {
            get { return _medicationEyeAttributeId; }
            set { _medicationEyeAttributeId = value; }
        }
        public string MedicationEyeAttributeValueId
        {
            get { return _medicationEyeAttributeValueId; }
            set { _medicationEyeAttributeValueId = value; }
        }
        public string MedicationDurationAttributeId
        {
            get { return _medicationDurationAttributeId; }
            set { _medicationDurationAttributeId = value; }
        }
        public string MedicationDurationAttributeValueId
        {
            get { return _medicationDurationAttributeValueId; }
            set { _medicationDurationAttributeValueId = value; }
        }
        public string MedicationActive
        {
            get { return _medicationActive; }
            set { _medicationActive = value; }
        }
        public long MedicationActivePatientAttributeValueId
        {
            get { return _MedicationActivePatientAttributeValueId; }
            set { _MedicationActivePatientAttributeValueId = value; }
        }
        public long MedicationNotesPatientAttributeValueId
        {
            get { return _MedicationNotesPatientAttributeValueId; }
            set { _MedicationNotesPatientAttributeValueId = value; }
        }
        public long MedicationEyesPatientAttributeValueId
        {
            get { return _MedicationEyesPatientAttributeValueId; }
            set { _MedicationEyesPatientAttributeValueId = value; }
        }
        public long MedicationDosePatientAttributeValueId
        {
            get { return _MedicationDosePatientAttributeValueId; }
            set { _MedicationDosePatientAttributeValueId = value; }
        }
        public long MedicationDurationPatientAttributeValueId
        {
            get { return _MedicationDurationPatientAttributeValueId; }
            set { _MedicationDurationPatientAttributeValueId = value; }
        }
        public long PatientAttributeID
        {
            get { return _PatientAttributeID; }
            set { _PatientAttributeID = value; }
        }
        public long MedicationFrequencyAttributeValueID
        {
            get { return _MedicationFrequencyAttributeValueID; }
            set { _MedicationFrequencyAttributeValueID = value; }
        }
        public long PatientVisitID
        {
            get { return _PatientVisitID; }
            set { _PatientVisitID = value; }
        }
        public long MedicationDrugPatientAttributeValueId
        {
            get { return _MedicationDrugPatientAttributeValueId; }
            set { _MedicationDrugPatientAttributeValueId = value; }
        }
    }
}
