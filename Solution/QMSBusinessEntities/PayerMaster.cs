using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PayerMaster
	{
		#region Fields

		private int payerID=0;
		private string payerName=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PayerID value.
		/// </summary>
		public int PayerID
		{
			get { return payerID; }
			set { payerID = value; }
		}

		/// <summary>
		/// Gets or sets the PayerName value.
		/// </summary>
		public string PayerName
		{
			get { return payerName; }
			set { payerName = value; }
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
