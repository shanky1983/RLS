using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class AbberantQueue
    {
        string fromDate = string.Empty;
        string toDate = string.Empty;
        string clCount = string.Empty;
        string olCount = string.Empty;
        string status = string.Empty;
        private long statusID = -1;
        string displayStatus = string.Empty;

        public string FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        public string ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        public string CLCount
        {
            get { return clCount; }
            set { clCount = value; }
        }
        public string OLCount
        {
            get { return olCount; }
            set { olCount = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public long StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }

        public string DisplayStatus
        {
            get { return displayStatus; }
            set { displayStatus = value; }
        }
    }
}
