using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PeriodWiseMeanTAT
    {
        #region Fields

        
        
        private string feeDescription = String.Empty;
        private int totalcount = 0;
        private int mins = 0;
        private decimal totalhours = Decimal.Zero;
        private decimal avghours = Decimal.Zero;

        #endregion

        #region Properties        
        
        /// <summary>
        /// Gets or sets the FeeDescription value.
        /// </summary>
        public string FeeDescription
        {
            get { return feeDescription; }
            set { feeDescription = value; }
        }

        /// <summary>
        /// Gets or sets the TotalCount value.
        /// </summary>
        public int TotalCount
        {
            get { return totalcount; }
            set { totalcount = value; }
        }

        /// <summary>
        /// Gets or sets the Mins value.
        /// </summary>
        public int Mins
        {
            get { return mins; }
            set { mins = value; }
        }
        /// <summary>
        /// Gets or sets the TotalHours value.
        /// </summary>
        public decimal TotalHours
        {
            get { return totalhours; }
            set { totalhours = value; }
        }

        /// <summary>
        /// Gets or sets the AvgHours value.
        /// </summary>
        public decimal AvgHours
        {
            get { return avghours; }
            set { avghours = value; }
        }  


        #endregion
    }
}
