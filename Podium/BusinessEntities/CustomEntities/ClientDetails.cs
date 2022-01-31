using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ClientDetails
    {

        #region Fields
        private long orgid = 0;
        private long clientid = 0;
        private string clientcode = String.Empty;
        private string clientname = String.Empty;
        private long attgroupid = 0;
        private long orggroupid = 0;
        private string testcode = String.Empty;
        private string testtype = String.Empty;
        private string testname = String.Empty;
        private string discountcategory = String.Empty;
        private string baseratecard = String.Empty;
        private string appliedratecard = String.Empty;
        private string ratetype = String.Empty;
        private string discountpolicy = String.Empty;
        private decimal discountapplied = Decimal.Zero;
        private decimal mrp = Decimal.Zero; 
        private decimal rate = Decimal.Zero;

        private decimal collectioncharges = Decimal.Zero;
        private int rateid = 0;
        private string ratename = String.Empty;

        private DateTime validfrom = DateTime.MaxValue;
        private DateTime validto = DateTime.MaxValue;
        private int priority = 0;
        private string policyname = String.Empty;
        private string baserate = String.Empty;
        #endregion


        #region Properties


        public long OrgId
        {
            get { return orgid; }
            set { orgid = value; }
        }
        public long ClientID
        {
            get { return clientid; }
            set { clientid = value; }
        }
        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public long Test_Attune_Code
        {
            get { return attgroupid; }
            set { attgroupid = value; }
        }
        public long Test_Org_Code
        {
            get { return orggroupid; }
            set { orggroupid = value; }
        }
        public string Test_EDOS_Code
        {
            get { return testcode; }
            set { testcode = value; }
        }
        public string Test_Type
        {
            get { return testtype; }
            set { testtype = value; }
        }
        public string Test_Name
        {
            get { return testname; }
            set { testname = value; }
        }
        public string Discount_Catergory
        {
            get { return discountcategory; }
            set { discountcategory = value; }
        }
        public string Base_Rate_Card
        {
            get { return baseratecard; }
            set { baseratecard = value; }
        }
        public string Applied_Rate_Card
        {
            get { return appliedratecard; }
            set { appliedratecard = value; }
        }
        public string RateType
        {
            get { return ratetype; }
            set { ratetype = value; }
        }
        public string Discount_Policy
        {
            get { return discountpolicy; }
            set { discountpolicy = value; }

        }
        public decimal Discount_Applied
        {
            get { return discountapplied; }
            set { discountapplied = value; }
        }
        public decimal MRP
        {
            get { return mrp; }
            set { mrp = value; }
        }       
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public decimal Collection_Charges
        {
            get { return collectioncharges; }
            set { collectioncharges = value; }
        }

        public int RateId
        {
            get { return rateid; }
            set { rateid = value; }
        }
        public string RateName
        {
            get { return ratename; }
            set { ratename = value; }
        }
        public DateTime ValidFrom
        {
            get { return validfrom; }
            set { validfrom = value; }
        }
        public DateTime ValidTo
        {
            get { return validto; }
            set { validto = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public string PolicyName
        {
            get { return policyname; }
            set { policyname = value; }
        }
        public string BaseRate
        {
            get { return baserate; }
            set { baserate = value; }
        }
     
        #endregion
    }
}

