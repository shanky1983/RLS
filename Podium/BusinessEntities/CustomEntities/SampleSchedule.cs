using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class SampleSchedule
    {

        #region Fields



       private long rowID = 0;
        private int orgID = 0;
        private long quotationID = 0;
        private String mobileNo = string.Empty;
        private long sampleCollBy = 0;
        private DateTime quotationDate = DateTime.MaxValue;
        private DateTime expiryDate = DateTime.MaxValue;
        private DateTime scheduledTime = DateTime.MaxValue;
        private DateTime scheduledTimeString = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string clientName = string.Empty;
        private string testName = string.Empty;
        private string sampleType = string.Empty;
        private string sampleID = string.Empty;
        private string quotationNO = string.Empty;
        private string testingAddress = string.Empty;
        private string collectedBy = string.Empty;
        private string fieldTest = string.Empty;
        private string status = string.Empty;
        private string modifiedBy = string.Empty;
        private string clientType = string.Empty;
        private string salesPerson = string.Empty;



        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        /// 
        public long RowID
        {
            get { return rowID; }
            set { rowID = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public long QuotationID
        {
            get { return quotationID; }
            set { quotationID = value; }
        }




        public String QuotationNO
        {
            get { return quotationNO; }
            set { quotationNO = value; }
        }

        public long CollectedBy
        {
            get { return sampleCollBy; }
            set { sampleCollBy = value; }
        }

       


        public String MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }

       

        public DateTime QuotationDate
        {
            get { return quotationDate; }
            set { quotationDate = value; }
        }

        public DateTime ScheduledTime
        {
            get { return scheduledTime; }
            set { scheduledTime = value; }
        }
        public string ScheduledTimeString
        {
            get { return scheduledTime.ToString(); }
            set { scheduledTime = Convert.ToDateTime(value); }
        }

        public DateTime ModifiedAt
        {
            get { return modifiedAt ; }
            set { modifiedAt = value; }
        }

        public string ModifiedAtTimeString
        {
            get { return modifiedAt.ToString(); }
            set { modifiedAt = Convert.ToDateTime(value); }
        }


        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate =value; }
        }
       
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }
        public string SampleType
        {
            get { return sampleType; }
            set { sampleType = value; }
        }
        public string SampleID
        {
            get { return sampleID; }
            set { sampleID = value; }
        }
        public string TestingAddress
        {
            get { return testingAddress; }
            set { testingAddress = value; }
        }
        public string CollectionPerson
        {
            get { return collectedBy; }
            set { collectedBy = value; }
        }

        public string ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

       
        public string FieldTest
        {
            get { return fieldTest; }
            set { fieldTest = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }


        public string SalesPerson
        {
            get { return salesPerson; }
            set { salesPerson = value; }
        }


       

        #endregion
    }
}
