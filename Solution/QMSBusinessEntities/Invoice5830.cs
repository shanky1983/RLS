using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Invoice5830
	{
		#region Fields

		private long invoiceDetailsID=0;
		private long invoiceID=0;
		private long finalBillID=0;
		private long clientID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long refID=0;
		private string refType=String.Empty;
		private string status=String.Empty;
		private string reason=String.Empty;
		private long actualClientID=0;
		private long actualOrgID=0;
		private decimal billedAmount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvoiceDetailsID value.
		/// </summary>
		public long InvoiceDetailsID
		{
			get { return invoiceDetailsID; }
			set { invoiceDetailsID = value; }
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
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the RefID value.
		/// </summary>
		public long RefID
		{
			get { return refID; }
			set { refID = value; }
		}

		/// <summary>
		/// Gets or sets the RefType value.
		/// </summary>
		public string RefType
		{
			get { return refType; }
			set { refType = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the ActualClientID value.
		/// </summary>
		public long ActualClientID
		{
			get { return actualClientID; }
			set { actualClientID = value; }
		}

		/// <summary>
		/// Gets or sets the ActualOrgID value.
		/// </summary>
		public long ActualOrgID
		{
			get { return actualOrgID; }
			set { actualOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the BilledAmount value.
		/// </summary>
		public decimal BilledAmount
		{
			get { return billedAmount; }
			set { billedAmount = value; }
		}


		#endregion
}
}
