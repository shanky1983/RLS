using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class OccupationHistory
    {
        private long _sno;
        private string _occupationtype;
        private string _occupationdisease;
        private long _occupationAttributeId;
        private long _occupationAttributevalueId;
        private long _patientAttributeValueID;
        private long _occupationTypeId;
        private long _patientvisitid;
        private long _patientid;
        public long Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public string OccupationType
        {
            get { return _occupationtype; }
            set { _occupationtype = value; }
        }
        public string OccupationDisease
        {
            get { return _occupationdisease; }
            set { _occupationdisease = value; }
        }
        public long OccupationAttributeId
        {
            get { return _occupationAttributeId; }
            set { _occupationAttributeId = value; }
        }
        public long OccupationAttributevalueId
        {
            get { return _occupationAttributevalueId; }
            set { _occupationAttributevalueId = value; }
        }
        public long _PatientAttributeValueID
        {
            get { return _patientAttributeValueID; }
            set { _patientAttributeValueID = value; }
        }
        public long OccupationTypeId
        {
            get { return _occupationTypeId; }
            set { _occupationTypeId = value; }
        }
        public long PatientID
        {
            get { return _patientid; }
            set { _patientid = value; }
        }
        public long PatientVisitID
        {
            get { return _patientvisitid; }
            set { _patientvisitid = value; }
        }
    }
}
