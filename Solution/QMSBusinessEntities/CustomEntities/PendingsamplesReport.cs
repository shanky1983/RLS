using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PendingsamplesReport
    {
        #region Fields
        private string barcodenumber = String.Empty;
        private string clientname = String.Empty;
        private string testname = String.Empty;
        private string status = String.Empty;        
        private decimal hours = Decimal.Zero;
        private string samplecollectedat = String.Empty;
        private string samplereceivedat = String.Empty;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the SampleCollectedAt value.
        /// </summary>
        public string SampleReceivedAt
        {
            get { return samplereceivedat; }
            set { samplereceivedat = value; }
        }
        /// <summary>
        /// Gets or sets the SampleCollectedAt value.
        /// </summary>
        public string SampleCollectedAt
        {
            get { return samplecollectedat; }
            set { samplecollectedat = value; }
        }
        
        /// <summary>
        /// Gets or sets the FeeId value.
        /// </summary>
        public string BarcodeNumber
        {
            get { return barcodenumber; }
            set { barcodenumber = value; }
        }

        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }

        /// <summary>
        /// Gets or sets the FeeDescription value.
        /// </summary>
        public string TestName
        {
            get { return testname; }
            set { testname = value; }
        }

        /// <summary>
        /// Gets or sets the CancelledCount value.
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        
        /// <summary>
        /// Gets or sets the CancelledPercentge value.
        /// </summary>
        public decimal Hours
        {
            get { return hours; }
            set { hours = value; }
        }            


        #endregion
    }
}
