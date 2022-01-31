using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class RateCardMaster
    {
        #region Fields

        private int sNo = 0;
        private int rateTypeID = 0;
        private int orgID = 0;
        private string testCode = String.Empty;
        private string testType = String.Empty;
        private string testName = String.Empty;
        private string rateName = String.Empty;
        private decimal rate = 0;
        private string flag = String.Empty;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the RateId value.
        /// </summary>
        public int SNo
        {
            get { return sNo; }
            set { sNo = value; }
        }
        public int RateTypeID
        {
            get { return rateTypeID; }
            set { rateTypeID = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }
        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }
        public string TestType
        {
            get { return testType; }
            set { testType = value; }
        }
        public string RateName
        {
            get { return rateName; }
            set { rateName = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public string Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        #endregion
    }
}
