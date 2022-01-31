using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientFamilyHistoryDisplay
    {
        private long _PatientID;
        private long _PatientVisitID;
        private long _PatientAttributeID;
        private long _ComplaintId;
        private long _PatientEyeAttributeValueId;
        private long _EyeAttributeId;
        private long _EyeAttributeValueId;
        private long _PatientRelationShipAttributeValueId;
        private long _RelationShipAttributeId;
        private long _RelationShipAttributeValueId;
        private string _EyeAttributeName;
        private string _Eye;
        private string _RelationShipAttributeName;
        private string _RelatiionShip;
        private string _ComplaintName;
        private long _Sno;
        private long _familynameattributevalueid;
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
        public long PatientAttributeID
        {
            get { return _PatientAttributeID; }
            set { _PatientAttributeID = value; }
        }
        public long ComplaintId
        {
            get { return _ComplaintId; }
            set { _ComplaintId = value; }
        }
        public long PatientEyeAttributeValueId
        {
            get { return _PatientEyeAttributeValueId; }
            set { _PatientEyeAttributeValueId = value; }
        }
        public long EyeAttributeValueId
        {
            get { return _EyeAttributeValueId; }
            set { _EyeAttributeValueId = value; }
        }
        public long EyeAttributeId
        {
            get { return _EyeAttributeId; }
            set { _EyeAttributeId = value; }
        }
        public long PatientRelationShipAttributeValueId
        {
            get { return _PatientRelationShipAttributeValueId; }
            set { _PatientRelationShipAttributeValueId = value; }
        }
        public long RelationShipAttributeId
        {
            get { return _RelationShipAttributeId; }
            set { _RelationShipAttributeId = value; }
        }
        public long RelationShipAttributeValueId
        {
            get { return _RelationShipAttributeValueId; }
            set { _RelationShipAttributeValueId = value; }
        }
        public string EyeAttributeName
        {
            get { return _EyeAttributeName; }
            set { _EyeAttributeName = value; }
        }
        public string Eye
        {
            get { return _Eye; }
            set { _Eye = value; }
        }
        public string RelationShipAttributeName
        {
            get { return _RelationShipAttributeName; }
            set { _RelationShipAttributeName = value; }
        }
        public string RelatiionShip
        {
            get { return _RelatiionShip; }
            set { _RelatiionShip = value; }
        }
        public string ComplaintName
        {
            get { return _ComplaintName; }
            set { _ComplaintName = value; }
        }
        public long Sno
        {
            get { return _Sno; }
            set { _Sno = value; }
        }
        public long familynameattributevalueid
        {
            get { return _familynameattributevalueid; }
            set { _familynameattributevalueid = value; }
        }
    }
}
