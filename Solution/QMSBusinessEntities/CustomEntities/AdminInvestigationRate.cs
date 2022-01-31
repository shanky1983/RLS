using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class AdminInvestigationRate
    {
        private long porgID;
        private long parentID;
        private string descName = string.Empty;
        private string refRange = string.Empty;
        private decimal opRate;
        private decimal ipRate;
        private decimal ipPercent;
        private decimal opPercent;
        private int uOMID = 0;
        private string uOMCode = String.Empty;
        private decimal iPPercentToHostingOrg = Decimal.Zero;
        private decimal oPPercentToHostingOrg = Decimal.Zero;
        private string type = String.Empty;
        private decimal minAdvanceAmt;
        private string splitDetails = String.Empty;

        private decimal generalAmount;
        private decimal diffAmount;
        private decimal diffPercentage;
        private string subCategoryType = String.Empty;
        private decimal cptAmount;
        private decimal cprtAmount;
        private string name = String.Empty;
        private long Createdby = 0;
        private string Displaytxt = string.Empty;
        private string IsamountEditable = String.Empty;
        private string Isrefundable = String.Empty;
        private string Istaxable = String.Empty;
        private string Isdiscountable = String.Empty;
        public long SourceID { get; set; }
		
		  private string serviceCode = String.Empty;
        private string isActive = string.Empty;
        private string discountCategory = String.Empty;
        private long ratetypeid;
        private string ismapped = string.Empty;
		private string _testCode;
        public long ID
        {
            get
            {
                return porgID;
            }
            set
            {
                porgID = value;
            }
        }
        public string DescriptionName
        {
            get
            {
                return descName;
            }
            set
            {
                descName = value;
            }
        }
        public decimal Amount
        {
            get
            {
                return opRate;
            }
            set
            {
                opRate = value;
            }
        }
        public decimal IPAmount
        {
            get
            {
                return ipRate;
            }
            set
            {
                ipRate = value;
            }
        }
        public decimal IPPercent
        {
            get
            {
                return ipPercent;
            }
            set
            {
                ipPercent = value;
            }
        }
        public decimal OPPercent
        {
            get
            {
                return opPercent;
            }
            set
            {
                opPercent = value;
            }
        }
        public string ReferenceRange
        {
            get
            {
                return refRange;
            }
            set
            {
                refRange = value;
            }
        }

        /// <summary>
        /// Gets or sets the UOMID value.
        /// </summary>
        public int UOMID
        {
            get { return uOMID; }
            set { uOMID = value; }
        }

        /// <summary>
        /// Gets or sets the UOMCode value.
        /// </summary>
        public string UOMCode
        {
            get { return uOMCode; }
            set { uOMCode = value; }
        }

        /// <summary>
        /// Gets or sets the IPPercentToHostingOrg value.
        /// </summary>
        public decimal IPPercentToHostingOrg
        {
            get { return iPPercentToHostingOrg; }
            set { iPPercentToHostingOrg = value; }
        }

        /// <summary>
        /// Gets or sets the OPPercentToHostingOrg value.
        /// </summary>
        public decimal OPPercentToHostingOrg
        {
            get { return oPPercentToHostingOrg; }
            set { oPPercentToHostingOrg = value; }
        }
        public string  Type
        {
            get { return type; }
            set { type = value; }
        }
        public decimal MinAdvanceAmt
        {
            get
            {
                return minAdvanceAmt;
            }
            set
            {
                minAdvanceAmt = value;
            }
        }
        public string SplitDetails
        {
            get
            {
                return splitDetails;
            }
            set
            {
                splitDetails = value;
            }
        }

        public decimal GeneralAmount
        {
            get
            {
                return generalAmount;
            }
            set
            {
                generalAmount = value;
            }
        }

        public decimal DiffAmount
        {
            get
            {
                return diffAmount;
            }
            set
            {
                diffAmount = value;
            }
        }

        public decimal DiffPercentage
        {
            get
            {
                return diffPercentage;
            }
            set
            {
                diffPercentage = value;
            }
        }

        public string SubCategoryType
        {
            get
            {
                return subCategoryType;
            }
            set
            {
                subCategoryType = value;
            }
        }
        public decimal CptAmount
        {
            get
            {
                return cptAmount;
            }
            set
            {
                cptAmount = value;
            }
        }
        public decimal CprtAmount
        {
            get
            {
                return cprtAmount;
            }
            set
            {
                cprtAmount = value;
            }
        }

  public long ParentID
        {
            get
            {
                return parentID;
            }
            set
            {
                parentID = value;
            }
        }        
		
		
		public string DiscountCategory
        {
            get
            {
                return discountCategory;
            }
            set
            {
                discountCategory = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public long CreatedBy
        {
            get
            {
                return Createdby;
            }
            set
            {
                Createdby = value;
            }
        }
		public long RateTypeId
        {
            get
            {
                return ratetypeid;
            }
            set
            {
                ratetypeid = value;
            }
        }
        public string IsMapped
        {
            get
            {
                return ismapped;
            }
            set
            {
                ismapped = value;
            }
        }
		public string TestCode
        {
            get
            {
                return _testCode;
            }

            set
            {
                _testCode = value;
            }
        }
  public string DisplayTxt
        {
            get
            {
                return Displaytxt;
            }
            set
            {
                Displaytxt = value;
            }
        }
        public string IsAmountEditable
        {
            get
            {
                return IsamountEditable;
            }
            set
            {
                IsamountEditable = value;
            }
        }
        public string IsRefundable
        {
            get
            {
                return Isrefundable;
            }
            set
            {
                Isrefundable = value;
            }
        }
        public string IsTaxable
        {
            get
            {
                return Istaxable;
            }
            set
            {
                Istaxable = value;
            }
        }
        public string IsDiscountable
        {
            get
            {
                return Isdiscountable;
            }
            set
            {
                Isdiscountable = value;
            }
        }
        private string _sourceType;
        public string SourceType
        {
            get { return _sourceType; }
            set { _sourceType = value; }
        }

        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }

        public string IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
    }
}
