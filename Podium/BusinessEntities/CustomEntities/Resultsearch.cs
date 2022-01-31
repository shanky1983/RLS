using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ResultSearch
    {

        #region Fields
         private long finalbillid = 0;
        private long billingdetailsid = 0;
        private string clientname = String.Empty;
        private string visitnumber = String.Empty;
        private DateTime visitdate = DateTime.MaxValue;
        private DateTime fromdate = DateTime.MaxValue;
        private DateTime todate = DateTime.MaxValue;
        private string name = String.Empty;
        private string feedescription = String.Empty;
        private string feetype = String.Empty;
        private decimal amount = Decimal.Zero;
        private decimal mamount = Decimal.Zero;
        private string ratecard = String.Empty;
        private string mratecard = String.Empty;
        private decimal baseamount = Decimal.Zero;
        private decimal mbaseamount = Decimal.Zero;
        private string baseratecard = String.Empty;
        private string mbaseratecard = String.Empty;
        private string discountcategory = String.Empty;
        private string mdiscountcategory = String.Empty;
        private string discountpolicy = String.Empty;
        private string mdiscountpolicy = String.Empty;
        private int orgID = 0;
        private long rateid = 0;
        private long mrateid = 0;
        private long baserateid = 0;
        private long mbaserateid = 0;
        private long discountpolicyid = 0;
        private long mdiscountpolicyid = 0;
        private long discountpercentage = 0;





       

        #endregion


        #region Properties
         public long FinalBillID
        {
            get { return finalbillid; }
            set { finalbillid = value; }
        }
        public long BillingDetailsID
        {
            get { return billingdetailsid; }
            set { billingdetailsid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        public DateTime ToDate
        {
            get { return todate; }
            set { todate = value; }
        }
        public DateTime FromDate
        {
            get { return fromdate; }
            set { fromdate = value; }
        }
        public DateTime VisitDate
        {
            get { return visitdate; }
            set { visitdate = value; }
        }
        public string FeeDescription
        {
            get { return feedescription; }
            set { feedescription = value; }
        }
        public string FeeType
        {
            get { return feetype; }
            set { feetype = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal MAmount
        {
            get { return mamount; }
            set { mamount = value; }
        }

        public string RateCard
        {
            get { return ratecard; }
            set { ratecard = value; }
        }
        public string MRatecard
        {
            get { return mratecard; }
            set { mratecard = value; }
        }
        public decimal BaseAmount
        {
            get { return baseamount; }
            set { baseamount = value; }
        }

        public decimal MBaseAmount
        {
            get { return mbaseamount; }
            set { mbaseamount = value; }
        }

        public string BaseRateCard
        {
            get { return baseratecard; }
            set { baseratecard = value; }
        }
        public string MBaseRatecard
        {
            get { return mbaseratecard; }
            set { mbaseratecard = value; }
        }
        public string DiscounCategory
        {
            get { return discountcategory; }
            set { discountcategory = value; }
        }

        public string MDiscounCategory
        {
            get { return mdiscountcategory; }
            set { mdiscountcategory = value; }
        }
        public string DiscountPolicy
        {
            get { return discountpolicy; }
            set { discountpolicy = value; }

        }
        public string MDiscountPolicy
        {
            get { return mdiscountpolicy; }
            set { mdiscountpolicy = value; }
        }
        public int OrgId
        {
            get { return orgID; }
            set { orgID = value; }
        }
          public long RateID
        {
            get { return rateid; }
            set { rateid = value; }
        }

          public long MRateID
          {
              get { return mrateid; }
              set { mrateid = value; }
          }
          public long BaseRateID
          {
              get { return baserateid; }
              set { baserateid = value; }
          }
          public long MBaseRateID
          {
              get { return mbaserateid; }
              set { mbaserateid = value; }
          }
          public long DiscountPolicyID
          {
              get { return discountpolicyid; }
              set { discountpolicyid = value; }
          }
          public long MDiscountPolicyID
          {
              get { return mdiscountpolicyid; }
              set { mdiscountpolicyid = value; }
          }
                public long DiscountPercentage
          {
              get { return discountpercentage; }
              set { discountpercentage = value; }
          }
   
        
        #endregion
    }
}

