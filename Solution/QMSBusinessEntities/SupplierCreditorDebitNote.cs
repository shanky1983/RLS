using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SupplierCreditorDebitNote
	{
		#region Fields

		private long supplierID=0;
		private decimal creditAmount=Decimal.Zero;
		private decimal usedAmount=Decimal.Zero;
		private decimal debitAmount=Decimal.Zero;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SupplierID value.
		/// </summary>
		public long SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
		}

		/// <summary>
		/// Gets or sets the CreditAmount value.
		/// </summary>
		public decimal CreditAmount
		{
			get { return creditAmount; }
			set { creditAmount = value; }
		}

		/// <summary>
		/// Gets or sets the UsedAmount value.
		/// </summary>
		public decimal UsedAmount
		{
			get { return usedAmount; }
			set { usedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DebitAmount value.
		/// </summary>
		public decimal DebitAmount
		{
			get { return debitAmount; }
			set { debitAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
