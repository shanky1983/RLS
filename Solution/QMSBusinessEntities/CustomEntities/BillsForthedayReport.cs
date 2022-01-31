using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BillsfortheDayReport
    {
        #region Fields

        
        private long feeId = 0;
        private string feeType = String.Empty;
        private string feeDescription = String.Empty;
        private int totalcount = 0;
        private decimal billedamount = 0;
        private decimal grossamount = 0;
        private long clientid = 0;
        private string clientcode = String.Empty;
        private string clientname = String.Empty;
        private string clientcurrency = String.Empty;
        private string orgcurrency = String.Empty;
        private string countryName = String.Empty;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the countryName value.
        /// </summary>
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        /// <summary>
        /// Gets or sets the clientname value.
        /// </summary>
        public string OrgCurrency
        {
            get { return orgcurrency; }
            set { orgcurrency = value; }
        }

        /// <summary>
        /// Gets or sets the clientname value.
        /// </summary>
        public string ClientCurrency
        {
            get { return clientcurrency; }
            set { clientcurrency = value; }
        }

        /// <summary>
        /// Gets or sets the clientname value.
        /// </summary>
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }

        /// <summary>
        /// Gets or sets the clinetcode value.
        /// </summary>
        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }

        /// <summary>
        /// Gets or sets the clinetid value.
        /// </summary>
        public long ClientID
        {
            get { return clientid; }
            set { clientid = value; }
        }
        
        /// <summary>
        /// Gets or sets the FeeId value.
        /// </summary>
        public long FeeId
        {
            get { return feeId; }
            set { feeId = value; }
        }

        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }

        /// <summary>
        /// Gets or sets the FeeDescription value.
        /// </summary>
        public string FeeDescription
        {
            get { return feeDescription; }
            set { feeDescription = value; }
        }

        /// <summary>
        /// Gets or sets the CancelledCount value.
        /// </summary>
        public int TotalCount
        {
            get { return totalcount; }
            set { totalcount = value; }
        }

        /// <summary>
        /// Gets or sets the CancelledCount value.
        /// </summary>
        public decimal BilledAmount
        {
            get { return billedamount; }
            set { billedamount = value; }
        }
        /// <summary>
        /// Gets or sets the CancelledPercentge value.
        /// </summary>
        public decimal GrossAmount
        {
            get { return grossamount; }
            set { grossamount = value; }
        }            


        #endregion
    }
}
