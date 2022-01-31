using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TATVIDLockExclude
	{
		#region Fields

		private int iD=0;
		private int startValue=0;
		private int endValue=0;
		private string valueType=String.Empty;
		private int orgID=0;
		private bool isactive=true;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime mSRNUM=DateTime.Now;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the StartValue value.
		/// </summary>
		public int StartValue
		{
			get { return startValue; }
			set { startValue = value; }
		}

		/// <summary>
		/// Gets or sets the EndValue value.
		/// </summary>
		public int EndValue
		{
			get { return endValue; }
			set { endValue = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Isactive value.
		/// </summary>
		public bool Isactive
		{
			get { return isactive; }
			set { isactive = value; }
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


		#endregion
}
}
