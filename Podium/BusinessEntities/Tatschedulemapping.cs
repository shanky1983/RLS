using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tatschedulemapping
	{
		#region Fields

		private int schedulemappingid=0;
		private int scheduleid=0;
		private long testid=0;
		private string testtype=String.Empty;
		private long clientid=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime mSRNUM=DateTime.Now;
		private bool isActive=true;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Schedulemappingid value.
		/// </summary>
		public int Schedulemappingid
		{
			get { return schedulemappingid; }
			set { schedulemappingid = value; }
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
		/// Gets or sets the Testid value.
		/// </summary>
		public long Testid
		{
			get { return testid; }
			set { testid = value; }
		}

		/// <summary>
		/// Gets or sets the Testtype value.
		/// </summary>
		public string Testtype
		{
			get { return testtype; }
			set { testtype = value; }
		}

		/// <summary>
		/// Gets or sets the Clientid value.
		/// </summary>
		public long Clientid
		{
			get { return clientid; }
			set { clientid = value; }
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
		/// Gets or sets the MSRNUM value.
		/// </summary>
		public DateTime MSRNUM
		{
			get { return mSRNUM; }
			set { mSRNUM = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryType value.
		/// </summary>
		private string _categoryType=String.Empty;
		public string CategoryType
		{
			get { return  _categoryType; }
			set { _categoryType = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		private long _categoryID=0;
		public long CategoryID
		{
			get { return  _categoryID; }
			set { _categoryID = value; }
		}


		#endregion
}
}
