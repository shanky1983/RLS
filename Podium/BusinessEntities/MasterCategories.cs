using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MasterCategories
	{
		#region Fields

		private long categoryId=0;
		private string categoryName=String.Empty;
		private int orgID=0;
		private string categoryCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CategoryId value.
		/// </summary>
		public long CategoryId
		{
			get { return categoryId; }
			set { categoryId = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryName value.
		/// </summary>
		public string CategoryName
		{
			get { return categoryName; }
			set { categoryName = value; }
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
		/// Gets or sets the CategoryCode value.
		/// </summary>
		public string CategoryCode
		{
			get { return categoryCode; }
			set { categoryCode = value; }
		}

		/// <summary>
		/// Gets or sets the PatternValue value.
		/// </summary>
		private string _patternValue=String.Empty;
		public string PatternValue
		{
			get { return  _patternValue; }
			set { _patternValue = value; }
		}

		/// <summary>
		/// Gets or sets the IsReset value.
		/// </summary>
		private string _isReset=String.Empty;
		public string IsReset
		{
			get { return  _isReset; }
			set { _isReset = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedDate value.
		/// </summary>
		private DateTime _createdDate=DateTime.MaxValue;
		public DateTime CreatedDate
		{
			get { return  _createdDate; }
			set { _createdDate = value; }
		}

		/// <summary>
		/// Gets or sets the ResetNumber value.
		/// </summary>
		private long _resetNumber=0;
		public long ResetNumber
		{
			get { return  _resetNumber; }
			set { _resetNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ResetOption value.
		/// </summary>
		private string _resetOption=String.Empty;
		public string ResetOption
		{
			get { return  _resetOption; }
			set { _resetOption = value; }
		}

		/// <summary>
		/// Gets or sets the ResetBy value.
		/// </summary>
		private string _resetBy=String.Empty;
		public string ResetBy
		{
			get { return  _resetBy; }
			set { _resetBy = value; }
		}

		/// <summary>
		/// Gets or sets the Pattern value.
		/// </summary>
		private string _pattern=String.Empty;
		public string Pattern
		{
			get { return  _pattern; }
			set { _pattern = value; }
		}


		#endregion
}
}
