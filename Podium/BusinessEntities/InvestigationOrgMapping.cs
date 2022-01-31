using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationOrgMapping
	{
		#region Fields

		private long investigationID=0;
		private int orgID=0;
		private int deptID=0;
		private long headerID=0;
		private string display=String.Empty;
		private string referenceRange=String.Empty;
		private string displayText=String.Empty;
		private int uOMID=0;
		private string uOMCode=String.Empty;
		private int sequenceNo=0;
		private int sampleCode=0;
		private long methodID=0;
		private long principleID=0;
		private long kitID=0;
		private long instrumentID=0;
		private string qCData=String.Empty;
		private string interpretation=String.Empty;
		private int sampleContainerID=0;
		private int processingAddressID=0;
		private string investigationCode=String.Empty;
		private long rowID=0;
		private string panicRange=String.Empty;
		private long autoApproveLoginID=0;
		private string referenceRangeString=String.Empty;
		private int vmValue=0;
		private int vmUnitID=0;
		private int sampleConditionID=0;
		private string invValidationText=String.Empty;
		private string subCategory=String.Empty;
		private bool isDiscountable=false;
		private bool isOrderable=false;
		private bool isRepeatable=false;
		private bool isSTAT=false;
		private string isActive=String.Empty;
		private string gender=String.Empty;
		private string isNonReportable=String.Empty;
		private string printSeparately=String.Empty;
		private int cONV_UOMID=0;
		private string cONV_UOMCode=String.Empty;
		private decimal cONV_Factor=Decimal.Zero;
		private int convFac_DecimalPoint=0;
		private long rCreatedBy=0;
		private long rModifiedBy=0;
		private DateTime rCreatedAt=DateTime.MaxValue;
		private DateTime rModifiedAt=DateTime.MaxValue;
		private string isParameter=String.Empty;
		private int protocalGroupID=0;
		private string outputInvestigationCode=String.Empty;
		private string isColorPrint=String.Empty;
		private string isHeader=String.Empty;
		private string billingName=String.Empty;
		private string isAutoApproveQueue=String.Empty;
		private string isAutoValidate=String.Empty;
		private string isAllowNull=String.Empty;
		private string iscountable=String.Empty;
		private string isConfidentialTest=String.Empty;
		private decimal maxDiscount=Decimal.Zero;
		private decimal redeemAmount=Decimal.Zero;
		private string imageToShow=String.Empty;
		private int preAnalyticalConditionId=0;
		private int postAnalyticalConditionId=0;
		private string isRedeem=String.Empty;
		private string abbCode=String.Empty;
		private long sectionID=0;
		private string testCode=String.Empty;
		private string otherLanguage=String.Empty;
		private string active=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isSynoptic=String.Empty;
		private string isFieldTest=String.Empty;
		private bool trend=false;
		private string billngDeptName=String.Empty;
		private string billingDeptName=String.Empty;
		private string prefix=String.Empty;
		private int scheduleid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderID value.
		/// </summary>
		public long HeaderID
		{
			get { return headerID; }
			set { headerID = value; }
		}

		/// <summary>
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public int SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the MethodID value.
		/// </summary>
		public long MethodID
		{
			get { return methodID; }
			set { methodID = value; }
		}

		/// <summary>
		/// Gets or sets the PrincipleID value.
		/// </summary>
		public long PrincipleID
		{
			get { return principleID; }
			set { principleID = value; }
		}

		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the QCData value.
		/// </summary>
		public string QCData
		{
			get { return qCData; }
			set { qCData = value; }
		}

		/// <summary>
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}

		/// <summary>
		/// Gets or sets the SampleContainerID value.
		/// </summary>
		public int SampleContainerID
		{
			get { return sampleContainerID; }
			set { sampleContainerID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingAddressID value.
		/// </summary>
		public int ProcessingAddressID
		{
			get { return processingAddressID; }
			set { processingAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationCode value.
		/// </summary>
		public string InvestigationCode
		{
			get { return investigationCode; }
			set { investigationCode = value; }
		}

		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public long RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}

		/// <summary>
		/// Gets or sets the PanicRange value.
		/// </summary>
		public string PanicRange
		{
			get { return panicRange; }
			set { panicRange = value; }
		}

		/// <summary>
		/// Gets or sets the AutoApproveLoginID value.
		/// </summary>
		public long AutoApproveLoginID
		{
			get { return autoApproveLoginID; }
			set { autoApproveLoginID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRangeString value.
		/// </summary>
		public string ReferenceRangeString
		{
			get { return referenceRangeString; }
			set { referenceRangeString = value; }
		}

		/// <summary>
		/// Gets or sets the VmValue value.
		/// </summary>
		public int VmValue
		{
			get { return vmValue; }
			set { vmValue = value; }
		}

		/// <summary>
		/// Gets or sets the VmUnitID value.
		/// </summary>
		public int VmUnitID
		{
			get { return vmUnitID; }
			set { vmUnitID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleConditionID value.
		/// </summary>
		public int SampleConditionID
		{
			get { return sampleConditionID; }
			set { sampleConditionID = value; }
		}

		/// <summary>
		/// Gets or sets the InvValidationText value.
		/// </summary>
		public string InvValidationText
		{
			get { return invValidationText; }
			set { invValidationText = value; }
		}

		/// <summary>
		/// Gets or sets the SubCategory value.
		/// </summary>
		public string SubCategory
		{
			get { return subCategory; }
			set { subCategory = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public bool IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
		}

		/// <summary>
		/// Gets or sets the IsOrderable value.
		/// </summary>
		public bool IsOrderable
		{
			get { return isOrderable; }
			set { isOrderable = value; }
		}

		/// <summary>
		/// Gets or sets the IsRepeatable value.
		/// </summary>
		public bool IsRepeatable
		{
			get { return isRepeatable; }
			set { isRepeatable = value; }
		}

		/// <summary>
		/// Gets or sets the IsSTAT value.
		/// </summary>
		public bool IsSTAT
		{
			get { return isSTAT; }
			set { isSTAT = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Gender value.
		/// </summary>
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the IsNonReportable value.
		/// </summary>
		public string IsNonReportable
		{
			get { return isNonReportable; }
			set { isNonReportable = value; }
		}

		/// <summary>
		/// Gets or sets the PrintSeparately value.
		/// </summary>
		public string PrintSeparately
		{
			get { return printSeparately; }
			set { printSeparately = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_UOMID value.
		/// </summary>
		public int CONV_UOMID
		{
			get { return cONV_UOMID; }
			set { cONV_UOMID = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_UOMCode value.
		/// </summary>
		public string CONV_UOMCode
		{
			get { return cONV_UOMCode; }
			set { cONV_UOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_Factor value.
		/// </summary>
		public decimal CONV_Factor
		{
			get { return cONV_Factor; }
			set { cONV_Factor = value; }
		}

		/// <summary>
		/// Gets or sets the ConvFac_DecimalPoint value.
		/// </summary>
		public int ConvFac_DecimalPoint
		{
			get { return convFac_DecimalPoint; }
			set { convFac_DecimalPoint = value; }
		}

		/// <summary>
		/// Gets or sets the RCreatedBy value.
		/// </summary>
		public long RCreatedBy
		{
			get { return rCreatedBy; }
			set { rCreatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the RModifiedBy value.
		/// </summary>
		public long RModifiedBy
		{
			get { return rModifiedBy; }
			set { rModifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the RCreatedAt value.
		/// </summary>
		public DateTime RCreatedAt
		{
			get { return rCreatedAt; }
			set { rCreatedAt = value; }
		}

		/// <summary>
		/// Gets or sets the RModifiedAt value.
		/// </summary>
		public DateTime RModifiedAt
		{
			get { return rModifiedAt; }
			set { rModifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsParameter value.
		/// </summary>
		public string IsParameter
		{
			get { return isParameter; }
			set { isParameter = value; }
		}

		/// <summary>
		/// Gets or sets the ProtocalGroupID value.
		/// </summary>
		public int ProtocalGroupID
		{
			get { return protocalGroupID; }
			set { protocalGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the OutputInvestigationCode value.
		/// </summary>
		public string OutputInvestigationCode
		{
			get { return outputInvestigationCode; }
			set { outputInvestigationCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsColorPrint value.
		/// </summary>
		public string IsColorPrint
		{
			get { return isColorPrint; }
			set { isColorPrint = value; }
		}

		/// <summary>
		/// Gets or sets the IsHeader value.
		/// </summary>
		public string IsHeader
		{
			get { return isHeader; }
			set { isHeader = value; }
		}

		/// <summary>
		/// Gets or sets the BillingName value.
		/// </summary>
		public string BillingName
		{
			get { return billingName; }
			set { billingName = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoApproveQueue value.
		/// </summary>
		public string IsAutoApproveQueue
		{
			get { return isAutoApproveQueue; }
			set { isAutoApproveQueue = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoValidate value.
		/// </summary>
		public string IsAutoValidate
		{
			get { return isAutoValidate; }
			set { isAutoValidate = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllowNull value.
		/// </summary>
		public string IsAllowNull
		{
			get { return isAllowNull; }
			set { isAllowNull = value; }
		}

		/// <summary>
		/// Gets or sets the Iscountable value.
		/// </summary>
		public string Iscountable
		{
			get { return iscountable; }
			set { iscountable = value; }
		}

		/// <summary>
		/// Gets or sets the IsConfidentialTest value.
		/// </summary>
		public string IsConfidentialTest
		{
			get { return isConfidentialTest; }
			set { isConfidentialTest = value; }
		}

		/// <summary>
		/// Gets or sets the MaxDiscount value.
		/// </summary>
		public decimal MaxDiscount
		{
			get { return maxDiscount; }
			set { maxDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemAmount value.
		/// </summary>
		public decimal RedeemAmount
		{
			get { return redeemAmount; }
			set { redeemAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ImageToShow value.
		/// </summary>
		public string ImageToShow
		{
			get { return imageToShow; }
			set { imageToShow = value; }
		}

		/// <summary>
		/// Gets or sets the PreAnalyticalConditionId value.
		/// </summary>
		public int PreAnalyticalConditionId
		{
			get { return preAnalyticalConditionId; }
			set { preAnalyticalConditionId = value; }
		}

		/// <summary>
		/// Gets or sets the PostAnalyticalConditionId value.
		/// </summary>
		public int PostAnalyticalConditionId
		{
			get { return postAnalyticalConditionId; }
			set { postAnalyticalConditionId = value; }
		}

		/// <summary>
		/// Gets or sets the IsRedeem value.
		/// </summary>
		public string IsRedeem
		{
			get { return isRedeem; }
			set { isRedeem = value; }
		}

		/// <summary>
		/// Gets or sets the AbbCode value.
		/// </summary>
		public string AbbCode
		{
			get { return abbCode; }
			set { abbCode = value; }
		}

		/// <summary>
		/// Gets or sets the SectionID value.
		/// </summary>
		public long SectionID
		{
			get { return sectionID; }
			set { sectionID = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the OtherLanguage value.
		/// </summary>
		public string OtherLanguage
		{
			get { return otherLanguage; }
			set { otherLanguage = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsSynoptic value.
		/// </summary>
		public string IsSynoptic
		{
			get { return isSynoptic; }
			set { isSynoptic = value; }
		}

		/// <summary>
		/// Gets or sets the IsFieldTest value.
		/// </summary>
		public string IsFieldTest
		{
			get { return isFieldTest; }
			set { isFieldTest = value; }
		}

		/// <summary>
		/// Gets or sets the Trend value.
		/// </summary>
		public bool Trend
		{
			get { return trend; }
			set { trend = value; }
		}

		/// <summary>
		/// Gets or sets the BillngDeptName value.
		/// </summary>
		public string BillngDeptName
		{
			get { return billngDeptName; }
			set { billngDeptName = value; }
		}

		/// <summary>
		/// Gets or sets the BillingDeptName value.
		/// </summary>
		public string BillingDeptName
		{
			get { return billingDeptName; }
			set { billingDeptName = value; }
		}

		/// <summary>
		/// Gets or sets the Prefix value.
		/// </summary>
		public string Prefix
		{
			get { return prefix; }
			set { prefix = value; }
		}

		/// <summary>
		/// Gets or sets the Scheduleid value.
		/// </summary>
		public int Scheduleid
		{
			get { return scheduleid; }
			set { scheduleid = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		private long _loginID=0;
		public long LoginID
		{
			get { return  _loginID; }
			set { _loginID = value; }
		}

		/// <summary>
		/// Gets or sets the OutsourceProcessingAddressID value.
		/// </summary>
		private long _outsourceProcessingAddressID=0;
		public long OutsourceProcessingAddressID
		{
			get { return  _outsourceProcessingAddressID; }
			set { _outsourceProcessingAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private long _type=0;
		public long Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the AutoApproveLoginName value.
		/// </summary>
		private string _autoApproveLoginName=String.Empty;
		public string AutoApproveLoginName
		{
			get { return  _autoApproveLoginName; }
			set { _autoApproveLoginName = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		private decimal _amount=Decimal.Zero;
		public decimal Amount
		{
			get { return  _amount; }
			set { _amount = value; }
		}


		#endregion
}
}
