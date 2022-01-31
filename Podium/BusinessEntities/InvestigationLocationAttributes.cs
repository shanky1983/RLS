using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationLocationAttributes
	{
		#region Fields

		private long iD=0;
		private long investigationID=0;
		private long orgID=0;
		private long orgAddressid=0;
		private string isNABL=String.Empty;

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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the OrgAddressid value.
		/// </summary>
		public long OrgAddressid
		{
			get { return orgAddressid; }
			set { orgAddressid = value; }
		}

		/// <summary>
		/// Gets or sets the IsNABL value.
		/// </summary>
		public string IsNABL
		{
			get { return isNABL; }
			set { isNABL = value; }
		}


		#endregion
}
}
