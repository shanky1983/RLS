using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _patternvalue;
		public string PatternValue
		{
			get { return _patternvalue; }
			set { _patternvalue = value; }
		}

		/// <summary>
		/// Gets or sets the IsReset value.
		/// </summary>
		string _isreset;
		public string IsReset
		{
			get { return _isreset; }
			set { _isreset = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedDate value.
		/// </summary>
		DateTime _createddate;
		public DateTime CreatedDate
		{
			get { return _createddate; }
			set { _createddate = value; }
		}

		/// <summary>
		/// Gets or sets the ResetNumber value.
		/// </summary>
		long _resetnumber;
		public long ResetNumber
		{
			get { return _resetnumber; }
			set { _resetnumber = value; }
		}

		/// <summary>
		/// Gets or sets the ResetOption value.
		/// </summary>
		string _resetoption;
		public string ResetOption
		{
			get { return _resetoption; }
			set { _resetoption = value; }
		}

		/// <summary>
		/// Gets or sets the ResetBy value.
		/// </summary>
		string _resetby;
		public string ResetBy
		{
			get { return _resetby; }
			set { _resetby = value; }
		}

		/// <summary>
		/// Gets or sets the Pattern value.
		/// </summary>
		string _pattern;
		public string Pattern
		{
			get { return _pattern; }
			set { _pattern = value; }
		}


		#endregion
}
}
