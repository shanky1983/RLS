using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StandardDeduction
	{
		#region Fields

		private long stdDedID=0;
		private long orgID=0;
		private string stdDedName=String.Empty;
		private string stdDedValue=String.Empty;
		private string stdDedType=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StdDedID value.
		/// </summary>
		public long StdDedID
		{
			get { return stdDedID; }
			set { stdDedID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedName value.
		/// </summary>
		public string StdDedName
		{
			get { return stdDedName; }
			set { stdDedName = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedValue value.
		/// </summary>
		public string StdDedValue
		{
			get { return stdDedValue; }
			set { stdDedValue = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedType value.
		/// </summary>
		public string StdDedType
		{
			get { return stdDedType; }
			set { stdDedType = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the StdDedDetails value.
		/// </summary>
		string _stddeddetails;
		public string StdDedDetails
		{
			get { return _stddeddetails; }
			set { _stddeddetails = value; }
		}


		#endregion
}
}
