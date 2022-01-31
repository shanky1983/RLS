using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BillingAuthorisedBy
	{
		#region Fields

		private int autoID=0;
		private int authorisedID=0;
		private string authorisedName=String.Empty;
		private string authorisedFor=String.Empty;
		private long orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AutoID value.
		/// </summary>
		public int AutoID
		{
			get { return autoID; }
			set { autoID = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorisedID value.
		/// </summary>
		public int AuthorisedID
		{
			get { return authorisedID; }
			set { authorisedID = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorisedName value.
		/// </summary>
		public string AuthorisedName
		{
			get { return authorisedName; }
			set { authorisedName = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorisedFor value.
		/// </summary>
		public string AuthorisedFor
		{
			get { return authorisedFor; }
			set { authorisedFor = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
