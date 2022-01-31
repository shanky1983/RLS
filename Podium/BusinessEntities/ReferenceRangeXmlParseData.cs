using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReferenceRangeXmlParseData
	{
		#region Fields

		private long iD=0;
		private long investigationID=0;
		private string investigationName=String.Empty;
		private string gender=String.Empty;
		private string ageRange=String.Empty;
		private string ageType=String.Empty;
		private string ageRangetype=String.Empty;
		private string valu=String.Empty;
		private string valueType=String.Empty;
		private string subCategory=String.Empty;
		private int orgID=0;
		private string referenceName=String.Empty;
		private string isNormal=String.Empty;
		private string isSourceText=String.Empty;

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
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
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
		/// Gets or sets the AgeRange value.
		/// </summary>
		public string AgeRange
		{
			get { return ageRange; }
			set { ageRange = value; }
		}

		/// <summary>
		/// Gets or sets the AgeType value.
		/// </summary>
		public string AgeType
		{
			get { return ageType; }
			set { ageType = value; }
		}

		/// <summary>
		/// Gets or sets the AgeRangetype value.
		/// </summary>
		public string AgeRangetype
		{
			get { return ageRangetype; }
			set { ageRangetype = value; }
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
		/// Gets or sets the ValueType value.
		/// </summary>
		public string ValueType
		{
			get { return valueType; }
			set { valueType = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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


		#endregion
}
}
