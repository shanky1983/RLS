using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Stage_MHL_T_03_Package_Master
	{
		#region Fields

		private string lAB=String.Empty;
		private string pACKAGE_NAME=String.Empty;
		private string mETROLAB_PROFILECODE=String.Empty;
		private string dOSCODE=String.Empty;
		private string orgGroupID=String.Empty;
		private string investigationID=String.Empty;
		private string testName=String.Empty;
		private string tEST_SEQUENCE_NO=String.Empty;
		private string test_Name=String.Empty;
		private string dISPLAY_NAME=String.Empty;
		private string tAT_POLICY=String.Empty;
		private string iS_ORDERABLE=String.Empty;
		private string cLASSIFICATION=String.Empty;
		private string iS_NABL=String.Empty;
		private string iS_CAP=String.Empty;
		private string iS_STAT=String.Empty;
		private string validationText=String.Empty;
		private string validationRule=String.Empty;
		private string isDiscountable=String.Empty;
		private string isServicetaxable=String.Empty;
		private string status=String.Empty;
		private string cutOffTimeValue=String.Empty;
		private string cutOffTimeType=String.Empty;
		private string subCategory=String.Empty;
		private string hasHistory=String.Empty;
		private string remarks=String.Empty;
		private string printSeparately=String.Empty;
		private string gender=String.Empty;
		private string groupinterpretation=String.Empty;
		private string issummaryworklist=String.Empty;
		private string isSpecialFormat=String.Empty;
		private string aBBREVATION=String.Empty;
		private string groupid=String.Empty;
		private string protocolGroup=String.Empty;
		private int protocolGroupID=0;
		private string i_Tcode=String.Empty;
		private string billing_Name=String.Empty;
		private string flag=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LAB value.
		/// </summary>
		public string LAB
		{
			get { return lAB; }
			set { lAB = value; }
		}

		/// <summary>
		/// Gets or sets the PACKAGE_NAME value.
		/// </summary>
		public string PACKAGE_NAME
		{
			get { return pACKAGE_NAME; }
			set { pACKAGE_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the METROLAB_PROFILECODE value.
		/// </summary>
		public string METROLAB_PROFILECODE
		{
			get { return mETROLAB_PROFILECODE; }
			set { mETROLAB_PROFILECODE = value; }
		}

		/// <summary>
		/// Gets or sets the DOSCODE value.
		/// </summary>
		public string DOSCODE
		{
			get { return dOSCODE; }
			set { dOSCODE = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		public string OrgGroupID
		{
			get { return orgGroupID; }
			set { orgGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public string InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the TEST_SEQUENCE_NO value.
		/// </summary>
		public string TEST_SEQUENCE_NO
		{
			get { return tEST_SEQUENCE_NO; }
			set { tEST_SEQUENCE_NO = value; }
		}

		/// <summary>
		/// Gets or sets the Test_Name value.
		/// </summary>
		public string Test_Name
		{
			get { return test_Name; }
			set { test_Name = value; }
		}

		/// <summary>
		/// Gets or sets the DISPLAY_NAME value.
		/// </summary>
		public string DISPLAY_NAME
		{
			get { return dISPLAY_NAME; }
			set { dISPLAY_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the TAT_POLICY value.
		/// </summary>
		public string TAT_POLICY
		{
			get { return tAT_POLICY; }
			set { tAT_POLICY = value; }
		}

		/// <summary>
		/// Gets or sets the IS_ORDERABLE value.
		/// </summary>
		public string IS_ORDERABLE
		{
			get { return iS_ORDERABLE; }
			set { iS_ORDERABLE = value; }
		}

		/// <summary>
		/// Gets or sets the CLASSIFICATION value.
		/// </summary>
		public string CLASSIFICATION
		{
			get { return cLASSIFICATION; }
			set { cLASSIFICATION = value; }
		}

		/// <summary>
		/// Gets or sets the IS_NABL value.
		/// </summary>
		public string IS_NABL
		{
			get { return iS_NABL; }
			set { iS_NABL = value; }
		}

		/// <summary>
		/// Gets or sets the IS_CAP value.
		/// </summary>
		public string IS_CAP
		{
			get { return iS_CAP; }
			set { iS_CAP = value; }
		}

		/// <summary>
		/// Gets or sets the IS_STAT value.
		/// </summary>
		public string IS_STAT
		{
			get { return iS_STAT; }
			set { iS_STAT = value; }
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
		public string CutOffTimeValue
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
		/// Gets or sets the Issummaryworklist value.
		/// </summary>
		public string Issummaryworklist
		{
			get { return issummaryworklist; }
			set { issummaryworklist = value; }
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
		/// Gets or sets the ABBREVATION value.
		/// </summary>
		public string ABBREVATION
		{
			get { return aBBREVATION; }
			set { aBBREVATION = value; }
		}

		/// <summary>
		/// Gets or sets the Groupid value.
		/// </summary>
		public string Groupid
		{
			get { return groupid; }
			set { groupid = value; }
		}

		/// <summary>
		/// Gets or sets the ProtocolGroup value.
		/// </summary>
		public string ProtocolGroup
		{
			get { return protocolGroup; }
			set { protocolGroup = value; }
		}

		/// <summary>
		/// Gets or sets the ProtocolGroupID value.
		/// </summary>
		public int ProtocolGroupID
		{
			get { return protocolGroupID; }
			set { protocolGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the I_Tcode value.
		/// </summary>
		public string I_Tcode
		{
			get { return i_Tcode; }
			set { i_Tcode = value; }
		}

		/// <summary>
		/// Gets or sets the Billing_Name value.
		/// </summary>
		public string Billing_Name
		{
			get { return billing_Name; }
			set { billing_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Flag value.
		/// </summary>
		public string Flag
		{
			get { return flag; }
			set { flag = value; }
		}


		#endregion
}
}
