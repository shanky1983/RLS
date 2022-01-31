using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientAttributesDetails_Hist
	{
		#region Fields

		private long attributesDetailsID=0;
		private long clientID=0;
		private long attributesID=0;
		private string valu=String.Empty;
		private string description=String.Empty;
		private int orgID=0;
		private DateTime historyCreatedAt=DateTime.MaxValue;
		private long historyCreatedBy=0;
		private string reason=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttributesDetailsID value.
		/// </summary>
		public long AttributesDetailsID
		{
			get { return attributesDetailsID; }
			set { attributesDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesID value.
		/// </summary>
		public long AttributesID
		{
			get { return attributesID; }
			set { attributesID = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the HistoryCreatedAt value.
		/// </summary>
		public DateTime HistoryCreatedAt
		{
			get { return historyCreatedAt; }
			set { historyCreatedAt = value; }
		}

		/// <summary>
		/// Gets or sets the HistoryCreatedBy value.
		/// </summary>
		public long HistoryCreatedBy
		{
			get { return historyCreatedBy; }
			set { historyCreatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}


		#endregion
}
}
