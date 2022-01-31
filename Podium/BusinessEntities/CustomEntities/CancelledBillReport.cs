using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CancelledBillReport
    {
        #region Fields

        
        private long feeId = 0;
        private string feeType = String.Empty;
        private string feeDescription = String.Empty;
        private int totalcount = 0;
        private int cancelledcount = 0;
        private string country = String.Empty;
        private decimal cancelledpercentage = Decimal.Zero;       

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the CountryName value.
        /// </summary>
        public string CountryName
        {
            get { return country; }
            set { country = value; }
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
        public int CancelledCount
        {
            get { return cancelledcount; }
            set { cancelledcount = value; }
        }
        /// <summary>
        /// Gets or sets the CancelledPercentge value.
        /// </summary>
        public decimal CancelledPercentage
        {
            get { return cancelledpercentage; }
            set { cancelledpercentage = value; }
        }            


        #endregion
    }
}
