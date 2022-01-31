using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvOrgGroup
	{
		#region Fields

		private int attGroupID=0;
		private int orgGroupID=0;
		private int orgID=0;
		private string displayText=String.Empty;
		private int sequenceNo=0;
		private string validationText=String.Empty;
		private string validationRule=String.Empty;
		private string groupCode=String.Empty;
		private string isNonOrderable=String.Empty;
		private string isDiscountable=String.Empty;
		private string isServicetaxable=String.Empty;
		private string classification=String.Empty;
		private string status=String.Empty;
		private int cutOffTimeValue=0;
		private string cutOffTimeType=String.Empty;
		private string subCategory=String.Empty;
		private string hasHistory=String.Empty;
		private string remarks=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string packagecode=String.Empty;
		private string printSeparately=String.Empty;
		private string gender=String.Empty;
		private string groupinterpretation=String.Empty;
		private string testCode=String.Empty;
		private string issummaryworklist=String.Empty;
		private string abbCode=String.Empty;
		private string isSpecialFormat=String.Empty;
		private string eDos=String.Empty;
		private short isTATrandom=0;
		private TimeSpan reportTime=TimeSpan.MinValue;
		private int protocalGroupID=0;
		private string outputGroupingCode=String.Empty;
		private string isSpecialFormatForRetest=String.Empty;
		private string isColorPrint=String.Empty;
		private string billingName=String.Empty;
		private string isCoPublish=String.Empty;
		private int deemedDeptID=0;
		private string iscountable=String.Empty;
		private decimal maxDiscount=Decimal.Zero;
		private bool isAttachmentMandatory=false;
		private string isRedeem=String.Empty;
		private decimal redeemAmount=Decimal.Zero;
		private string isSummaryReport=String.Empty;
		private int processingSequence=0;
		private bool isPkgTransfer=true;
		private string pkgType=String.Empty;
		private bool allowAutoComplete=true;
		private bool isFormulaCalculateOnDevice=true;
		private string isDisplayProfileName=String.Empty;
		private string isoptionaltest=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private string isSynoptic=String.Empty;
		private string isFieldTest=String.Empty;
		private string isSpecialTest=String.Empty;
		private string billngDeptName=String.Empty;
		private string billingDeptName=String.Empty;
		private int scheduleid=0;
		private byte riskassessmentpackage=0x00;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttGroupID value.
		/// </summary>
		public int AttGroupID
		{
			get { return attGroupID; }
			set { attGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		public int OrgGroupID
		{
			get { return orgGroupID; }
			set { orgGroupID = value; }
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
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
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
		/// Gets or sets the ValidationText value.
		/// </summary>
		public string ValidationText
		{
			get { return validationText; }
			set { validationText = value; }
		}

		/// <summary>
		/// Gets or sets the ValidationRule value.
		/// </summary>
		public string ValidationRule
		{
			get { return validationRule; }
			set { validationRule = value; }
		}

		/// <summary>
		/// Gets or sets the GroupCode value.
		/// </summary>
		public string GroupCode
		{
			get { return groupCode; }
			set { groupCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsNonOrderable value.
		/// </summary>
		public string IsNonOrderable
		{
			get { return isNonOrderable; }
			set { isNonOrderable = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
		}

		/// <summary>
		/// Gets or sets the IsServicetaxable value.
		/// </summary>
		public string IsServicetaxable
		{
			get { return isServicetaxable; }
			set { isServicetaxable = value; }
		}

		/// <summary>
		/// Gets or sets the Classification value.
		/// </summary>
		public string Classification
		{
			get { return classification; }
			set { classification = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the CutOffTimeValue value.
		/// </summary>
		public int CutOffTimeValue
		{
			get { return cutOffTimeValue; }
			set { cutOffTimeValue = value; }
		}

		/// <summary>
		/// Gets or sets the CutOffTimeType value.
		/// </summary>
		public string CutOffTimeType
		{
			get { return cutOffTimeType; }
			set { cutOffTimeType = value; }
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
		/// Gets or sets the HasHistory value.
		/// </summary>
		public string HasHistory
		{
			get { return hasHistory; }
			set { hasHistory = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Packagecode value.
		/// </summary>
		public string Packagecode
		{
			get { return packagecode; }
			set { packagecode = value; }
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
		/// Gets or sets the Gender value.
		/// </summary>
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the Groupinterpretation value.
		/// </summary>
		public string Groupinterpretation
		{
			get { return groupinterpretation; }
			set { groupinterpretation = value; }
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
		/// Gets or sets the Issummaryworklist value.
		/// </summary>
		public string Issummaryworklist
		{
			get { return issummaryworklist; }
			set { issummaryworklist = value; }
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
		/// Gets or sets the IsSpecialFormat value.
		/// </summary>
		public string IsSpecialFormat
		{
			get { return isSpecialFormat; }
			set { isSpecialFormat = value; }
		}

		/// <summary>
		/// Gets or sets the EDos value.
		/// </summary>
		public string EDos
		{
			get { return eDos; }
			set { eDos = value; }
		}

		/// <summary>
		/// Gets or sets the IsTATrandom value.
		/// </summary>
		public short IsTATrandom
		{
			get { return isTATrandom; }
			set { isTATrandom = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTime value.
		/// </summary>
		public TimeSpan ReportTime
		{
			get { return reportTime; }
			set { reportTime = value; }
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
		/// Gets or sets the OutputGroupingCode value.
		/// </summary>
		public string OutputGroupingCode
		{
			get { return outputGroupingCode; }
			set { outputGroupingCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsSpecialFormatForRetest value.
		/// </summary>
		public string IsSpecialFormatForRetest
		{
			get { return isSpecialFormatForRetest; }
			set { isSpecialFormatForRetest = value; }
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
		/// Gets or sets the BillingName value.
		/// </summary>
		public string BillingName
		{
			get { return billingName; }
			set { billingName = value; }
		}

		/// <summary>
		/// Gets or sets the IsCoPublish value.
		/// </summary>
		public string IsCoPublish
		{
			get { return isCoPublish; }
			set { isCoPublish = value; }
		}

		/// <summary>
		/// Gets or sets the DeemedDeptID value.
		/// </summary>
		public int DeemedDeptID
		{
			get { return deemedDeptID; }
			set { deemedDeptID = value; }
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
		/// Gets or sets the MaxDiscount value.
		/// </summary>
		public decimal MaxDiscount
		{
			get { return maxDiscount; }
			set { maxDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the IsAttachmentMandatory value.
		/// </summary>
		public bool IsAttachmentMandatory
		{
			get { return isAttachmentMandatory; }
			set { isAttachmentMandatory = value; }
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
		/// Gets or sets the RedeemAmount value.
		/// </summary>
		public decimal RedeemAmount
		{
			get { return redeemAmount; }
			set { redeemAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IsSummaryReport value.
		/// </summary>
		public string IsSummaryReport
		{
			get { return isSummaryReport; }
			set { isSummaryReport = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingSequence value.
		/// </summary>
		public int ProcessingSequence
		{
			get { return processingSequence; }
			set { processingSequence = value; }
		}

		/// <summary>
		/// Gets or sets the IsPkgTransfer value.
		/// </summary>
		public bool IsPkgTransfer
		{
			get { return isPkgTransfer; }
			set { isPkgTransfer = value; }
		}

		/// <summary>
		/// Gets or sets the PkgType value.
		/// </summary>
		public string PkgType
		{
			get { return pkgType; }
			set { pkgType = value; }
		}

		/// <summary>
		/// Gets or sets the AllowAutoComplete value.
		/// </summary>
		public bool AllowAutoComplete
		{
			get { return allowAutoComplete; }
			set { allowAutoComplete = value; }
		}

		/// <summary>
		/// Gets or sets the IsFormulaCalculateOnDevice value.
		/// </summary>
		public bool IsFormulaCalculateOnDevice
		{
			get { return isFormulaCalculateOnDevice; }
			set { isFormulaCalculateOnDevice = value; }
		}

		/// <summary>
		/// Gets or sets the IsDisplayProfileName value.
		/// </summary>
		public string IsDisplayProfileName
		{
			get { return isDisplayProfileName; }
			set { isDisplayProfileName = value; }
		}

		/// <summary>
		/// Gets or sets the Isoptionaltest value.
		/// </summary>
		public string Isoptionaltest
		{
			get { return isoptionaltest; }
			set { isoptionaltest = value; }
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
		/// Gets or sets the IsSpecialTest value.
		/// </summary>
		public string IsSpecialTest
		{
			get { return isSpecialTest; }
			set { isSpecialTest = value; }
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
		/// Gets or sets the Scheduleid value.
		/// </summary>
		public int Scheduleid
		{
			get { return scheduleid; }
			set { scheduleid = value; }
		}

		/// <summary>
		/// Gets or sets the Riskassessmentpackage value.
		/// </summary>
		public byte Riskassessmentpackage
		{
			get { return riskassessmentpackage; }
			set { riskassessmentpackage = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		private string _groupName=String.Empty;
		public string GroupName
		{
			get { return  _groupName; }
			set { _groupName = value; }
		}

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		private string _codeName=String.Empty;
		public string CodeName
		{
			get { return  _codeName; }
			set { _codeName = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the IsReflex value.
		/// </summary>
		private string _isReflex=String.Empty;
		public string IsReflex
		{
			get { return  _isReflex; }
			set { _isReflex = value; }
		}

		/// <summary>
		/// Gets or sets the IsReportable value.
		/// </summary>
		private string _isReportable=String.Empty;
		public string IsReportable
		{
			get { return  _isReportable; }
			set { _isReportable = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		private long _investigationID=0;
		public long InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		private int _packageID=0;
		public int PackageID
		{
			get { return  _packageID; }
			set { _packageID = value; }
		}

		/// <summary>
		/// Gets or sets the InvGrpID value.
		/// </summary>
		private string _invGrpID=String.Empty;
		public string InvGrpID
		{
			get { return  _invGrpID; }
			set { _invGrpID = value; }
		}


		#endregion
}
}
