using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BulkReferenceRange
	{
		#region Fields

		private string testCode=String.Empty;
		private string rangeType=String.Empty;
		private string genderValue=String.Empty;
		private string subCategoryType=String.Empty;
		private string resultType=String.Empty;
		private string typeMode=String.Empty;
		private string ageRangeType=String.Empty;
		private string ageRange=String.Empty;
		private string referenceName=String.Empty;
		private string valueTypeMode=String.Empty;
		private string valu=String.Empty;
		private string isNormal=String.Empty;
		private string isSourceText=String.Empty;
		private string referenceRange=String.Empty;
		private string interpretation=String.Empty;
		private string device=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private long login=0;
		private bool status=false;
		private long investigationID=0;
		private string investigationName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the RangeType value.
		/// </summary>
		public string RangeType
		{
			get { return rangeType; }
			set { rangeType = value; }
		}

		/// <summary>
		/// Gets or sets the GenderValue value.
		/// </summary>
		public string GenderValue
		{
			get { return genderValue; }
			set { genderValue = value; }
		}

		/// <summary>
		/// Gets or sets the SubCategoryType value.
		/// </summary>
		public string SubCategoryType
		{
			get { return subCategoryType; }
			set { subCategoryType = value; }
		}

		/// <summary>
		/// Gets or sets the ResultType value.
		/// </summary>
		public string ResultType
		{
			get { return resultType; }
			set { resultType = value; }
		}

		/// <summary>
		/// Gets or sets the TypeMode value.
		/// </summary>
		public string TypeMode
		{
			get { return typeMode; }
			set { typeMode = value; }
		}

		/// <summary>
		/// Gets or sets the AgeRangeType value.
		/// </summary>
		public string AgeRangeType
		{
			get { return ageRangeType; }
			set { ageRangeType = value; }
		}

		/// <summary>
		/// Gets or sets the AgeRange value.
		/// </summary>
		public string AgeRange
		{
			get { return ageRange; }
			set { ageRange = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceName value.
		/// </summary>
		public string ReferenceName
		{
			get { return referenceName; }
			set { referenceName = value; }
		}

		/// <summary>
		/// Gets or sets the ValueTypeMode value.
		/// </summary>
		public string ValueTypeMode
		{
			get { return valueTypeMode; }
			set { valueTypeMode = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the IsNormal value.
		/// </summary>
		public string IsNormal
		{
			get { return isNormal; }
			set { isNormal = value; }
		}

		/// <summary>
		/// Gets or sets the IsSourceText value.
		/// </summary>
		public string IsSourceText
		{
			get { return isSourceText; }
			set { isSourceText = value; }
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
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}

		/// <summary>
		/// Gets or sets the Device value.
		/// </summary>
		public string Device
		{
			get { return device; }
			set { device = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Login value.
		/// </summary>
		public long Login
		{
			get { return login; }
			set { login = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
		}


		#endregion
}
}
