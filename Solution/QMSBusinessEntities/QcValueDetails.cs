using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class QcValueDetails
    {

        #region Fields

        private long qCValueID = 0;
        private long instrumentID = 0;
        private string qCLevel = String.Empty;
       
        private long orgAddressID = 0;
        private string value1 = String.Empty;
        private string value2 = String.Empty;
        private string value3 = String.Empty;
        private string value4 = String.Empty;
        private DateTime processedAt = DateTime.MaxValue;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime createdBy = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        private DateTime modifiedBy = DateTime.MaxValue;
        private long investigationID = 0;
        private long orgID = 0;
        private int deptID = 0;
        private long headerID = 0;
        private string display = String.Empty;
        private string referenceRange = String.Empty;
        private string displayText = String.Empty;
        private int uOMID = 0;
        private string uOMCode = String.Empty;
        private int sequenceNo = 0;
        private int sampleCode = 0;
        private long methodID = 0;
        private long principleID = 0;
        private long kitID = 0;
     
        private string qCData = String.Empty;
        private string interpretation = String.Empty;
        private int sampleContainerID = 0;
        private int processingAddressID = 0;
        private string investigationCode = String.Empty;
        private long rowID = 0;
        private string panicRange = String.Empty;
        private long autoApproveLoginID = 0;
        private string referenceRangeString = String.Empty;
        private int vmValue = 0;
        private int vmUnitID = 0;
        private int sampleConditionID = 0;
        private string invValidationText = String.Empty;
        private string subCategory = String.Empty;
        private bool isDiscountable = false;
        private bool isOrderable = false;
        private bool isRepeatable = false;
        private bool isSTAT = false;
        private string isActive = String.Empty;
        private string gender = String.Empty;
        private string isNonReportable = String.Empty;
        private string printSeparately = String.Empty;
        private int cONV_UOMID = 0;
        private string cONV_UOMCode = String.Empty;
        private decimal cONV_Factor = Decimal.Zero;
        private int convFac_DecimalPoint = 0;
        private long rCreatedBy = 0;
        private long rModifiedBy = 0;
        private DateTime rCreatedAt = DateTime.MaxValue;
        private DateTime rModifiedAt = DateTime.MaxValue;
        private string isParameter = String.Empty;
        private int protocalGroupID = 0;
        private string outputInvestigationCode = String.Empty;
        private string isColorPrint = String.Empty;
        private string isHeader = String.Empty;
        private string billingName = String.Empty;
        private string isAutoApproveQueue = String.Empty;
        private string isAutoValidate = String.Empty;
        private string isAllowNull = String.Empty;
        private string iscountable = String.Empty;
        private string isConfidentialTest = String.Empty;
        private decimal maxDiscount = Decimal.Zero;
        private decimal redeemAmount = Decimal.Zero;
        private string imageToShow = String.Empty;
        private int preAnalyticalConditionId = 0;
        private int postAnalyticalConditionId = 0;
        private string isRedeem = String.Empty;
        private string abbCode = String.Empty;
        private long sectionID = 0;
        private string testCode = String.Empty;
        private string otherLanguage = String.Empty;
        private string active = String.Empty;
        private DateTime createdat = DateTime.MaxValue;
        private string isUpdate = "N";
        private Int64 lotID = 0;
        private string lotName = string.Empty;

        #endregion

        #region Properties
        public string  IsUpdate
        {
            get { return isUpdate; }
            set { isUpdate = value; }
        }
        public long QCValueID
        {
            get { return qCValueID; }
            set { qCValueID = value; }
        }

        public string QCLevel
        {
            get { return qCLevel; }
            set { qCLevel = value; }
        }

        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }

        public long OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }

        public string Value1
        {
            get { return value1; }
            set { value1 = value; }
        }

        public string Value2
        {
            get { return value2; }
            set { value2 = value; }
        }

        public string Value3
        {
            get { return value3; }
            set { value3 = value; }
        }

        public string Value4
        {
            get { return value4; }
            set { value4 = value; }
        }

        public DateTime ProcessedAt
        {
            get { return processedAt; }
            set { processedAt = value; }
        }



		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}




		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

	

		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
        public Int64 LotID
        {
            get { return lotID; }
            set { lotID = value; }
        }
        public string LotName 
        {
            get { return lotName; }
            set { lotName = value; }
        }


		#endregion
    }
}
