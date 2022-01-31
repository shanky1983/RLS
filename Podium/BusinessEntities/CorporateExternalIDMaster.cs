using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CorporateExternalIDMaster
	{
		#region Fields

		private long orgID=0;
		private long externalNo=0;
		private int rowid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalNo value.
		/// </summary>
		public long ExternalNo
		{
			get { return externalNo; }
			set { externalNo = value; }
		}

		/// <summary>
		/// Gets or sets the Rowid value.
		/// </summary>
		public int Rowid
		{
			get { return rowid; }
			set { rowid = value; }
		}


		#endregion
}
}
