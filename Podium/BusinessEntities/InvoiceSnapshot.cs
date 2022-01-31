using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvoiceSnapshot
	{
		#region Fields

		private long iD=0;
		private byte[] content=new byte[0];
		private long clientID=0;
		private long invoiceID=0;
		private string invoicePath=String.Empty;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime tODate=DateTime.MaxValue;
		private int orgID=0;
		private long orgAddressID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int notificationID=0;
		private int seq_Num=0;
		private string type=String.Empty;
		private string hasChangedFolderPath=String.Empty;

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
		/// Gets or sets the Content value.
		/// </summary>
		public byte[] Content
		{
			get { return content; }
			set { content = value; }
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
		/// Gets or sets the InvoiceID value.
		/// </summary>
		public long InvoiceID
		{
			get { return invoiceID; }
			set { invoiceID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoicePath value.
		/// </summary>
		public string InvoicePath
		{
			get { return invoicePath; }
			set { invoicePath = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the TODate value.
		/// </summary>
		public DateTime TODate
		{
			get { return tODate; }
			set { tODate = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the NotificationID value.
		/// </summary>
		public int NotificationID
		{
			get { return notificationID; }
			set { notificationID = value; }
		}

		/// <summary>
		/// Gets or sets the Seq_Num value.
		/// </summary>
		public int Seq_Num
		{
			get { return seq_Num; }
			set { seq_Num = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the HasChangedFolderPath value.
		/// </summary>
		public string HasChangedFolderPath
		{
			get { return hasChangedFolderPath; }
			set { hasChangedFolderPath = value; }
		}


		#endregion
}
}
