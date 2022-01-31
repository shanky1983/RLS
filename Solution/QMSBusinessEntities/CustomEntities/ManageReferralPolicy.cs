using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ManageReferralPolicy
    {
        #region Fields
        private int orgID = 0;
        private long categoryid = 0;
        private string categoryName = string.Empty;
        private long createdby = 0;
        private DateTime createdat = DateTime.MaxValue;
        private long modifiedby = 0;
        private DateTime modifiedat = DateTime.MaxValue;
        private long fromrange = 0;
        private long torange = 0;
        private long payout = 0;
        private int payon = 0;
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        /// <summary>
        /// Gets or sets the Categoryid value.
        /// </summary>
        public long Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        /// <summary>
        /// Gets or sets the CategoryName value.
        /// </summary>
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        /// <summary>
        /// Gets or sets the Createdby value.
        /// </summary>
        public long Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }
        /// <summary>
        /// Gets or sets the Createdat value.
        /// </summary>
        public DateTime Createdat
        {
            get { return createdat; }
            set { createdat = value; }
        }
        /// <summary>
        /// Gets or sets the Modifiedby value.
        /// </summary>
        public long Modifiedby
        {
            get { return modifiedby; }
            set { modifiedby = value; }
        }
        /// <summary>
        /// Gets or sets the Modifiedat value.
        /// </summary>
        public DateTime Modifiedat
        {
            get { return modifiedat; }
            set { modifiedat = value; }
        }
        /// <summary>
        /// Gets or sets the Fromrange value.
        /// </summary>
        public long Fromrange
        {
            get { return fromrange; }
            set { fromrange = value; }
        }
        /// <summary>
        /// Gets or sets the Torange value.
        /// </summary>
        public long Torange
        {
            get { return torange; }
            set { torange = value; }
        }
        /// <summary>
        /// Gets or sets the Payout value.
        /// </summary>
        public long Payout
        {
            get { return payout; }
            set { payout = value; }
        }
        /// <summary>
        /// Gets or sets the Payon value.
        /// </summary>
        public int Payon
        {
            get { return payon; }
            set { payon = value; }
        }
        #endregion

    }
}
