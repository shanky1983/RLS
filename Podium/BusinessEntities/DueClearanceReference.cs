using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DueClearanceReference
	{
		#region Fields

		private string receiptNo=String.Empty;
		private long visitID=0;
		private string itemName=String.Empty;
		private decimal quantity=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private long feeID=0;
		private string feeType=String.Empty;
		private string batchNo=String.Empty;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private DateTime expiryDate=DateTime.MaxValue;
		private string isReimbursable=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal eligibleAmount=Decimal.Zero;
		private long locationid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public string ReceiptNo
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

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
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
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the IsReimbursable value.
		/// </summary>
		public string IsReimbursable
		{
			get { return isReimbursable; }
			set { isReimbursable = value; }
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
		/// Gets or sets the EligibleAmount value.
		/// </summary>
		public decimal EligibleAmount
		{
			get { return eligibleAmount; }
			set { eligibleAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Locationid value.
		/// </summary>
		public long Locationid
		{
			get { return locationid; }
			set { locationid = value; }
		}

		/// <summary>
		/// Gets or sets the Total value.
		/// </summary>
		private decimal _total=Decimal.Zero;
		public decimal Total
		{
			get { return  _total; }
			set { _total = value; }
		}

		/// <summary>
		/// Gets or sets the UnitPrice value.
		/// </summary>
		private decimal _unitPrice=Decimal.Zero;
		public decimal UnitPrice
		{
			get { return  _unitPrice; }
			set { _unitPrice = value; }
		}


		#endregion
}
}
