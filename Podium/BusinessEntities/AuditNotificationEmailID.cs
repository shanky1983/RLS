using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AuditNotificationEmailID
	{
		#region Fields

		private long iD=0;
		private string email=String.Empty;
		private int orgid=0;

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
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}


		#endregion
}
}
