using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientServiceCodeMapping
	{
		#region Fields

		private long clientID=0;
		private long orgID=0;
		private string clientName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string needServiceBill=String.Empty;
		private string isCorporatetBill=String.Empty;
		private string showActualDiscAmt=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
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
		/// Gets or sets the NeedServiceBill value.
		/// </summary>
		public string NeedServiceBill
		{
			get { return needServiceBill; }
			set { needServiceBill = value; }
		}

		/// <summary>
		/// Gets or sets the IsCorporatetBill value.
		/// </summary>
		public string IsCorporatetBill
		{
			get { return isCorporatetBill; }
			set { isCorporatetBill = value; }
		}

		/// <summary>
		/// Gets or sets the ShowActualDiscAmt value.
		/// </summary>
		public string ShowActualDiscAmt
		{
			get { return showActualDiscAmt; }
			set { showActualDiscAmt = value; }
		}


		#endregion
}
}
