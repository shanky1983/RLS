using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvOrgGroup_History
	{
		#region Fields

		private long iD=0;
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
		private long modifiedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string gender=String.Empty;
		private string packagecode=String.Empty;
		private string printSeparately=String.Empty;
		private string groupinterpretation=String.Empty;
		private string testCode=String.Empty;
		private string issummaryworklist=String.Empty;
		private string abbCode=String.Empty;
		private string isSpecialFormat=String.Empty;
		private string eDos=String.Empty;
		private short isTATrandom=0;
		private int protocalGroupID=0;
		private string outputGroupingCode=String.Empty;
		private string isSpecialFormatForRetest=String.Empty;
		private string isColorPrint=String.Empty;
		private string isCoPublish=String.Empty;
		private int deemedDeptID=0;
		private string iscountable=String.Empty;
		private decimal maxDiscount=Decimal.Zero;
		private string historyReason=String.Empty;
		private TimeSpan reportTime=TimeSpan.MinValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the HistoryReason value.
		/// </summary>
		public string HistoryReason
		{
			get { return historyReason; }
			set { historyReason = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
