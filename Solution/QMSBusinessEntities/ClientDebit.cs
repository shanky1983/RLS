using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientDebit
	{
		#region Fields

		private long debitID=0;
		private DateTime debitDate=DateTime.MaxValue;
		private int orgID=0;
		private string category=String.Empty;
		private string sourceCode=String.Empty;
		private string subSourceCode=String.Empty;
		private string narration=String.Empty;
		private string barCode=String.Empty;
		private decimal amount=Decimal.Zero;
		private string remarks=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long invoiceID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DebitID value.
		/// </summary>
		public long DebitID
		{
			get { return debitID; }
			set { debitID = value; }
		}

		/// <summary>
		/// Gets or sets the DebitDate value.
		/// </summary>
		public DateTime DebitDate
		{
			get { return debitDate; }
			set { debitDate = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
		}

		/// <summary>
		/// Gets or sets the SourceCode value.
		/// </summary>
		public string SourceCode
		{
			get { return sourceCode; }
			set { sourceCode = value; }
		}

		/// <summary>
		/// Gets or sets the SubSourceCode value.
		/// </summary>
		public string SubSourceCode
		{
			get { return subSourceCode; }
			set { subSourceCode = value; }
		}

		/// <summary>
		/// Gets or sets the Narration value.
		/// </summary>
		public string Narration
		{
			get { return narration; }
			set { narration = value; }
		}

		/// <summary>
		/// Gets or sets the BarCode value.
		/// </summary>
		public string BarCode
		{
			get { return barCode; }
			set { barCode = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
		/// Gets or sets the InvoiceID value.
		/// </summary>
		public long InvoiceID
		{
			get { return invoiceID; }
			set { invoiceID = value; }
		}


		#endregion
}
}
