using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Manufacturer
	{
		#region Fields

		private int mfgID=0;
		private string mfgName=String.Empty;
		private string mfgCode=String.Empty;
		private string eMail=String.Empty;
		private string phone=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MfgID value.
		/// </summary>
		public int MfgID
		{
			get { return mfgID; }
			set { mfgID = value; }
		}

		/// <summary>
		/// Gets or sets the MfgName value.
		/// </summary>
		public string MfgName
		{
			get { return mfgName; }
			set { mfgName = value; }
		}

		/// <summary>
		/// Gets or sets the MfgCode value.
		/// </summary>
		public string MfgCode
		{
			get { return mfgCode; }
			set { mfgCode = value; }
		}

		/// <summary>
		/// Gets or sets the EMail value.
		/// </summary>
		public string EMail
		{
			get { return eMail; }
			set { eMail = value; }
		}

		/// <summary>
		/// Gets or sets the Phone value.
		/// </summary>
		public string Phone
		{
			get { return phone; }
			set { phone = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
