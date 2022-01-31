using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CashFlowTransactionDetails
	{
		#region Fields

		private long cashFlowTransactionID=0;
		private long cashFlowID=0;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private string invoiceNo=String.Empty;
		private decimal amountPaid=Decimal.Zero;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CashFlowTransactionID value.
		/// </summary>
		public long CashFlowTransactionID
		{
			get { return cashFlowTransactionID; }
			set { cashFlowTransactionID = value; }
		}

		/// <summary>
		/// Gets or sets the CashFlowID value.
		/// </summary>
		public long CashFlowID
		{
			get { return cashFlowID; }
			set { cashFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		public string InvoiceNo
		{
			get { return invoiceNo; }
			set { invoiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the AmountPaid value.
		/// </summary>
		public decimal AmountPaid
		{
			get { return amountPaid; }
			set { amountPaid = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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


		#endregion
}
}
