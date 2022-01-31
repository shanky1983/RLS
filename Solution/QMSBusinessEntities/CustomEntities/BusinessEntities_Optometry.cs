using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class Optometry
    {
        #region Fields
        private long _ExaminationID;
        private string _MappingCode;
        private string _IdentifyingType;
        private string _ExaminationName;
      
        private string _AttributeName;
        private string _AttributeValueName;
        private long _AttributeID;
        private long _AttributevalueID;
        private long _EditMode;
        private long _seqId;
        #endregion 

        #region Properties
        public long ExaminationID
        {
            get { return _ExaminationID; }
            set { _ExaminationID = value; }
        }
        public string MappingCode
        {
            get { return _MappingCode; }
            set { _MappingCode = value; }
        }
        public string IdentifyingType
        {
            get { return _IdentifyingType; }
            set { _IdentifyingType = value; }
        }
        public string ExaminationName
        {
            get { return _ExaminationName; }
            set { _ExaminationName = value; }
        }
      
        public string AttributeName
        {
            get { return _AttributeName; }
            set { _AttributeName = value; }
        }
        public string AttributeValueName
        {
            get { return _AttributeValueName; }
            set { _AttributeValueName = value; }
        }
        public long AttributeID
        {
            get { return _AttributeID; }
            set { _AttributeID = value; }
        }
        public long AttributevalueID
        {
            get { return _AttributevalueID; }
            set { _AttributevalueID = value; }
        }
        public long EditMode
        {
            get { return _EditMode; }
            set { _EditMode = value; }
        }
        public long SeqId
        {
            get { return _seqId; }
            set { _seqId = value; }
        }
        public string CreatedBy { get; set; }

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
        #endregion 

    }
}
