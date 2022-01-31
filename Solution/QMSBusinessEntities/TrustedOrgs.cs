using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TrustedOrgs
	{
		#region Fields

		private long detailsID=0;
		private long trustedGroupID=0;
		private long trustedOrgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
		}

		/// <summary>
		/// Gets or sets the TrustedGroupID value.
		/// </summary>
		public long TrustedGroupID
		{
			get { return trustedGroupID; }
			set { trustedGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the TrustedOrgID value.
		/// </summary>
		public long TrustedOrgID
		{
			get { return trustedOrgID; }
			set { trustedOrgID = value; }
		}


		#endregion
}
}
