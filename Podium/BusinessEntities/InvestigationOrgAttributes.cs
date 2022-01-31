using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationOrgAttributes
	{
		#region Fields

		private long iD=0;
		private long investigationID=0;
		private int orgID=0;
		private string resultValueType=String.Empty;
		private decimal cPT=Decimal.Zero;
		private decimal cPRT=Decimal.Zero;
		private string decimalPlaces=String.Empty;
		private int cutOffTimeValue=0;
		private string cutOffTimeType=String.Empty;
		private string classification=String.Empty;
		private string isInterfaced=String.Empty;
		private string isSMS=String.Empty;
		private string isServiceTax=String.Empty;
		private string isNABL=String.Empty;
		private string isCAP=String.Empty;
		private string isDiscountable=String.Empty;
		private string isRepeatable=String.Empty;
		private string isSTAT=String.Empty;
		private string category=String.Empty;
		private string hasHistory=String.Empty;
		private string isNonReportable=String.Empty;
		private string isCoAuthorized=String.Empty;
		private short isTATrandom=0;
		private TimeSpan reportTime=TimeSpan.MinValue;
		private bool isNonEditable=false;
		private string isRateEditable=String.Empty;
		private string isSecondaryBarCode=String.Empty;

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
		/// Gets or sets the ResultValueType value.
		/// </summary>
		public string ResultValueType
		{
			get { return resultValueType; }
			set { resultValueType = value; }
		}

		/// <summary>
		/// Gets or sets the CPT value.
		/// </summary>
		public decimal CPT
		{
			get { return cPT; }
			set { cPT = value; }
		}

		/// <summary>
		/// Gets or sets the CPRT value.
		/// </summary>
		public decimal CPRT
		{
			get { return cPRT; }
			set { cPRT = value; }
		}

		/// <summary>
		/// Gets or sets the DecimalPlaces value.
		/// </summary>
		public string DecimalPlaces
		{
			get { return decimalPlaces; }
			set { decimalPlaces = value; }
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
		/// Gets or sets the Classification value.
		/// </summary>
		public string Classification
		{
			get { return classification; }
			set { classification = value; }
		}

		/// <summary>
		/// Gets or sets the IsInterfaced value.
		/// </summary>
		public string IsInterfaced
		{
			get { return isInterfaced; }
			set { isInterfaced = value; }
		}

		/// <summary>
		/// Gets or sets the IsSMS value.
		/// </summary>
		public string IsSMS
		{
			get { return isSMS; }
			set { isSMS = value; }
		}

		/// <summary>
		/// Gets or sets the IsServiceTax value.
		/// </summary>
		public string IsServiceTax
		{
			get { return isServiceTax; }
			set { isServiceTax = value; }
		}

		/// <summary>
		/// Gets or sets the IsNABL value.
		/// </summary>
		public string IsNABL
		{
			get { return isNABL; }
			set { isNABL = value; }
		}

		/// <summary>
		/// Gets or sets the IsCAP value.
		/// </summary>
		public string IsCAP
		{
			get { return isCAP; }
			set { isCAP = value; }
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
		/// Gets or sets the IsRepeatable value.
		/// </summary>
		public string IsRepeatable
		{
			get { return isRepeatable; }
			set { isRepeatable = value; }
		}

		/// <summary>
		/// Gets or sets the IsSTAT value.
		/// </summary>
		public string IsSTAT
		{
			get { return isSTAT; }
			set { isSTAT = value; }
		}

		/// <summary>
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
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
		/// Gets or sets the IsNonReportable value.
		/// </summary>
		public string IsNonReportable
		{
			get { return isNonReportable; }
			set { isNonReportable = value; }
		}

		/// <summary>
		/// Gets or sets the IsCoAuthorized value.
		/// </summary>
		public string IsCoAuthorized
		{
			get { return isCoAuthorized; }
			set { isCoAuthorized = value; }
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
		/// Gets or sets the IsNonEditable value.
		/// </summary>
		public bool IsNonEditable
		{
			get { return isNonEditable; }
			set { isNonEditable = value; }
		}

		/// <summary>
		/// Gets or sets the IsRateEditable value.
		/// </summary>
		public string IsRateEditable
		{
			get { return isRateEditable; }
			set { isRateEditable = value; }
		}

		/// <summary>
		/// Gets or sets the IsSecondaryBarCode value.
		/// </summary>
		public string IsSecondaryBarCode
		{
			get { return isSecondaryBarCode; }
			set { isSecondaryBarCode = value; }
		}


		#endregion
}
}
