using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class FeeSplitSeriveDetails
    {

        #region Fields

        private long specID = 0;
        private long iD = 0;
        private long rateId = 0;
        private long  feeID = 0;
        private int orgID = 0;
        private string type = String.Empty;
        private int feeTypeAttributesID = 0;
        private decimal amount = Decimal.Zero;
        private string sourceType = string.Empty;
        private string splitType = string.Empty;
        private long parentItemID = 0;

        public long ParentItemID
        {
            get { return parentItemID; }
            set { parentItemID = value; }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the PhysicianFeeDetailsID value.
        /// </summary>
        public long SpecID
        {
            get { return specID; }
            set { specID = value; }
        }

        /// <summary>
        /// Gets or sets the PhysicianFeeID value.
        /// </summary>
        /// 
        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public long RateId
        {
            get { return rateId; }
            set { rateId = value; }
        }


        public long FeeID
        {
            get { return feeID; }
            set { feeID = value; }
        }


        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the Type value.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Gets or sets the FeeTypeAttributesID value.
        /// </summary>
        public int FeeTypeAttributesID
        {
            get { return feeTypeAttributesID; }
            set { feeTypeAttributesID = value; }
        }

        /// <summary>
        /// Gets or sets the Amount value.
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>

        /// <summary>
        /// Gets or sets the SplitType value.
        /// </summary>

        public string SplitType
        {
            get { return splitType; }
            set { splitType = value; }
        }
		 private string _SourceType;

        public string SourceType
        {
            get { return _SourceType; }
            set { _SourceType = value; }
        }
        #endregion
    }
}
