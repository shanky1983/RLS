using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HistopathIDMaster
	{
		#region Fields

		private long histoID=0;
		private long orgID=0;
		private long iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HistoID value.
		/// </summary>
		public long HistoID
		{
			get { return histoID; }
			set { histoID = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
