using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PatientAllergyHistoryDisplay
    {
        private long _PatientID;
        private long _PatientVisitID;
        private long _AllergyID;
        private long _AllergyReactionID;
        private long _TreatmentPlanID;
        private long _AllergyActiveAttributeID;
        private long _AllergyActiveAttributeValueID;
        private long _AllergySinceAttributeID;
        private long _AllergySinceAttributeValueID;
        private long _AllergyActivePha;
        private long _AllergySincePha;
        private long _PatientAllergyID;
        private string _AllergySinceAttributeValue;
        private string _AllergyActiveAttributeValueName;
        private string _AllergySinceAttributeValueName;
        private string _AllergyName;
        private string _ReactionName;
        private string _IPTreatmentPlanName;
        private long _sno;
        private long _AllergyNameAttributeID;
        private long _AllergyReactionAttributeID;
        private long _AllergyResolvesWith;

        public long PatientID
        {     
            get{return _PatientID;}
            set { _PatientID = value; }
        }
        public long PatientVisitID
        {
            get { return _PatientVisitID; }
            set { _PatientVisitID = value; }
        }
        public long AllergyID
        {
            get { return _AllergyID; }
            set { _AllergyID = value; }
        }
        public long AllergyReactionID
        {
            get { return _AllergyReactionID; }
            set { _AllergyReactionID = value; }
        }
        public long TreatmentPlanID
        {
            get { return _TreatmentPlanID; }
            set { _TreatmentPlanID = value; }
        }
        public long AllergyActiveAttributeID
        {
            get { return _AllergyActiveAttributeID; }
            set { _AllergyActiveAttributeID = value; }
        }
        public long AllergyActiveAttributeValueID
        {
            get { return _AllergyActiveAttributeValueID; }
            set { _AllergyActiveAttributeValueID = value; }
        }
        public long AllergySinceAttributeID
        {
            get { return _AllergySinceAttributeID; }
            set { _AllergySinceAttributeID = value; }
        }
        public long AllergySinceAttributeValueID
        {
            get { return _AllergySinceAttributeValueID; }
            set { _AllergySinceAttributeValueID = value; }
        }
        public long AllergyActivePha
        {
            get { return _AllergyActivePha; }
            set { _AllergyActivePha = value; }
        }
        public long AllergySincePha
        {
            get { return _AllergySincePha; }
            set { _AllergySincePha = value; }
        }
        public long PatientAllergyID
        {
            get { return _PatientAllergyID; }
            set { _PatientAllergyID = value; }
        }
        public string AllergySinceAttributeValue
        {
            get { return _AllergySinceAttributeValue; }
            set { _AllergySinceAttributeValue = value; }
        }
        public string AllergyActiveAttributeValueName
        {
            get { return _AllergyActiveAttributeValueName; }
            set { _AllergyActiveAttributeValueName = value; }
        }
        public string AllergySinceAttributeValueName
        {
            get { return _AllergySinceAttributeValueName; }
            set { _AllergySinceAttributeValueName = value; }
        }
        public string AllergyName
        {
            get { return _AllergyName; }
            set { _AllergyName = value; }
        }
        public string ReactionName
        {
            get { return _ReactionName; }
            set { _ReactionName = value; }
        }
        public string IPTreatmentPlanName
        {
            get { return _IPTreatmentPlanName; }
            set { _IPTreatmentPlanName = value; }
        }
        public long Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public long AllergyNameAttributeID
        {
            get { return _AllergyNameAttributeID; }
            set { _AllergyNameAttributeID = value; }
        }
        public long AllergyReactionAttributeID
        {
            get { return _AllergyReactionAttributeID; }
            set { _AllergyReactionAttributeID = value; }
        }
        public long AllergyResolvesWith
        {
            get { return _AllergyResolvesWith; }
            set { _AllergyResolvesWith = value; }
        }
    }
}
