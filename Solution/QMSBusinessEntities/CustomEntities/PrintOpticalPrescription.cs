using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PrintOpticalPrescription
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
      
        #endregion 

    }
}
