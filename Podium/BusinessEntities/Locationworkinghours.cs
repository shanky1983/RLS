using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Locationworkinghours
	{
		#region Fields

		private int iD=0;
		private int orgID=0;
		private long orgAddressId=0;
		private short weekdayno=0;
		private TimeSpan labstart=TimeSpan.MinValue;
		private TimeSpan labend=TimeSpan.MinValue;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private DateTime mSRNUM=DateTime.Now;
		private string isActive=String.Empty;

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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressId value.
		/// </summary>
		public long OrgAddressId
		{
			get { return orgAddressId; }
			set { orgAddressId = value; }
		}

		/// <summary>
		/// Gets or sets the Weekdayno value.
		/// </summary>
		public short Weekdayno
		{
			get { return weekdayno; }
			set { weekdayno = value; }
		}

		/// <summary>
		/// Gets or sets the Labstart value.
		/// </summary>
		public TimeSpan Labstart
		{
			get { return labstart; }
			set { labstart = value; }
		}

		/// <summary>
		/// Gets or sets the Labend value.
		/// </summary>
		public TimeSpan Labend
		{
			get { return labend; }
			set { labend = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
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
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
