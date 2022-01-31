using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable]
	public class DueClearance
	{
		#region Fields

		private long receiptNo=0;
		private long visitID=0;
		private string itemName=String.Empty;
		private decimal quantity=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private long feeID=0;
		private string feeType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public long ReceiptNo
		{
			get { return receiptNo; }
			set { receiptNo = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
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
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}


		#endregion
}
}
