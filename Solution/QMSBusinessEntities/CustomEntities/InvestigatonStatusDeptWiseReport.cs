using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InvestigatonStatusDeptWiseReport
    {
        #region Fields       
        private long approve = 0;
        private long cancel = 0;
        private long completed = 0;
        private long pending = 0;
        private long recheck = 0;
        private long reject = 0;
        private long samplecollected = 0;
        private long  samplereceived= 0;
        private decimal pendingpercentage=0;
        private string department = String.Empty;

        #endregion

        #region Properties
        
        /// <summary>
        /// Gets or sets the approve value.
        /// </summary>
        public long Approve
        {
            get { return approve; }
            set { approve = value; }
        }
        public long Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }
        public long Completed
        {
            get { return completed; }
            set { completed = value; }
        }
        public long Pending
        {
            get { return pending; }
            set { pending = value; }
        }
        public long Recheck
        {
            get { return recheck; }
            set { recheck = value; }
        }
        public long Reject
        {
            get { return reject; }
            set { reject = value; }
        }
        public long SampleCollected
        {
            get { return samplecollected; }
            set { samplecollected = value; }
        }

        public long SampleReceived
        {
            get { return samplereceived; }
            set { samplereceived = value; }
        }
        
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public decimal PendingPercentage
        {
            get { return pendingpercentage; }
            set { pendingpercentage = value; }
        }
       #endregion
    }
}
