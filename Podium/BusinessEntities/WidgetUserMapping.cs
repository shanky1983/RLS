using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WidgetUserMapping
	{
		#region Fields

		private long wUMID=0;
		private long wRID=0;
		private long wDID=0;
		private long loginID=0;
		private long orgID=0;
		private string active=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WUMID value.
		/// </summary>
		public long WUMID
		{
			get { return wUMID; }
			set { wUMID = value; }
		}

		/// <summary>
		/// Gets or sets the WRID value.
		/// </summary>
		public long WRID
		{
			get { return wRID; }
			set { wRID = value; }
		}

		/// <summary>
		/// Gets or sets the WDID value.
		/// </summary>
		public long WDID
		{
			get { return wDID; }
			set { wDID = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
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
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}


		#endregion
}
}
