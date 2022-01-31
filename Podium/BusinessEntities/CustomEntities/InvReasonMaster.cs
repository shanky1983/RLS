using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvReasonMasters
    {
        private long reasonID = 0;
        private string reasonDesc = String.Empty;
        private long statusID;

        private int reasonTypeID = 0;
        private string reason = String.Empty;
        private string reasonCode = String.Empty;
        private string status = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string reasonTypeCode = String.Empty;
        private int sequenceNo = 0;


        public long StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }
        public long ReasonID
        {
            get { return reasonID; }
            set { reasonID = value; }
        }
        public string ReasonDesc
        {
            get { return reasonDesc; }
            set { reasonDesc = value; }
        }
        public int ReasonTypeID
        {
            get { return reasonTypeID; }
            set { reasonTypeID = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        public string ReasonCode
        {
            get { return reasonCode; }
            set { reasonCode = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }
        short _categoryid;
        public short CategoryID
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }
        public string ReasonTypeCode
        {
            get { return reasonTypeCode; }
            set { reasonTypeCode = value; }
        }
        public int SequenceNo
        {
            get { return sequenceNo; }
            set { sequenceNo = value; }
        }
    }
}
