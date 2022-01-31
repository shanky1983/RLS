using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RefundReasonMaster
	{
		#region Fields

		private int reasonId=0;
		private string reasonDesc=String.Empty;
		private long orgID=0;
		private long orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReasonId value.
		/// </summary>
		public int ReasonId
		{
			get { return reasonId; }
			set { reasonId = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonDesc value.
		/// </summary>
		public string ReasonDesc
		{
			get { return reasonDesc; }
			set { reasonDesc = value; }
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
