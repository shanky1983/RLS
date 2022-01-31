using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class VisitNumberMaster
	{
		#region Fields

		private long orgID=0;
		private long visitNumber=0;
		private int rowid=0;
		private long orgAddressID=0;

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
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public long VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Rowid value.
		/// </summary>
		public int Rowid
		{
			get { return rowid; }
			set { rowid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}


		#endregion
}
}
