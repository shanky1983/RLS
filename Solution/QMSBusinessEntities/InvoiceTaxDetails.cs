using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvoiceTaxDetails
	{
		#region Fields

		private long taxDetailsID=0;
		private long invoiceID=0;
		private long clientID=0;
		private int taxID=0;
		private string taxName=String.Empty;
		private decimal taxAmount=Decimal.Zero;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int sequenceNo=0;
		private long taxPercentage=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaxDetailsID value.
		/// </summary>
		public long TaxDetailsID
		{
			get { return taxDetailsID; }
			set { taxDetailsID = value; }
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
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxID value.
		/// </summary>
		public int TaxID
		{
			get { return taxID; }
			set { taxID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxName value.
		/// </summary>
		public string TaxName
		{
			get { return taxName; }
			set { taxName = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount value.
		/// </summary>
		public decimal TaxAmount
		{
			get { return taxAmount; }
			set { taxAmount = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the TaxPercentage value.
		/// </summary>
		public long TaxPercentage
		{
			get { return taxPercentage; }
			set { taxPercentage = value; }
		}


		#endregion
}
}
