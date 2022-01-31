using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Attune.Solution.QMSBusinessEntities
{
    [DataContract]
    public class InsertBlock
    {
        private long _SNo;
        private long _ResourceId;
        private string _ResourceName;
        private string _StartTime;
        private string _EndTime;
        private string _Reason;
        private int _VaccationID;
        private string _status;

        [DataMember]
        public long Sno
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        [DataMember]
        public long BlkResourceId
        {
            get { return _ResourceId; }
            set { _ResourceId = value; }
        }
        [DataMember]
        public string ResourceName
        {
            get { return _ResourceName; }
            set { _ResourceName = value; }
        }
        [DataMember]
        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        [DataMember]
        public string EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }
        [DataMember]
        public string Reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }
        [DataMember]
        public int VaccationID
        {
            get { return _VaccationID; }
            set { _VaccationID = value; }
        }
        [DataMember]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
