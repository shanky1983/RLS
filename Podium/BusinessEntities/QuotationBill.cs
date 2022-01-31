using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class QuotationBill
	{
		#region Fields

		private long quotationBillID=0;
		private long quotationID=0;
		private string isFreeOfCost=String.Empty;
		private string fOCRemarks=String.Empty;
		private int discountTypeID=0;
		private decimal discountPercentage=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;
		private int discountReasonID=0;
		private long authorizedBy=0;
		private int taxID=0;
		private decimal grossBillAmount=Decimal.Zero;
		private decimal taxAmount=Decimal.Zero;
		private decimal roundOff=Decimal.Zero;
		private decimal netAmount=Decimal.Zero;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QuotationBillID value.
		/// </summary>
		public long QuotationBillID
		{
			get { return quotationBillID; }
			set { quotationBillID = value; }
		}

		/// <summary>
		/// Gets or sets the QuotationID value.
		/// </summary>
		public long QuotationID
		{
			get { return quotationID; }
			set { quotationID = value; }
		}

		/// <summary>
		/// Gets or sets the IsFreeOfCost value.
		/// </summary>
		public string IsFreeOfCost
		{
			get { return isFreeOfCost; }
			set { isFreeOfCost = value; }
		}

		/// <summary>
		/// Gets or sets the FOCRemarks value.
		/// </summary>
		public string FOCRemarks
		{
			get { return fOCRemarks; }
			set { fOCRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountTypeID value.
		/// </summary>
		public int DiscountTypeID
		{
			get { return discountTypeID; }
			set { discountTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPercentage value.
		/// </summary>
		public decimal DiscountPercentage
		{
			get { return discountPercentage; }
			set { discountPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountReasonID value.
		/// </summary>
		public int DiscountReasonID
		{
			get { return discountReasonID; }
			set { discountReasonID = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizedBy value.
		/// </summary>
		public long AuthorizedBy
		{
			get { return authorizedBy; }
			set { authorizedBy = value; }
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
		/// Gets or sets the GrossBillAmount value.
		/// </summary>
		public decimal GrossBillAmount
		{
			get { return grossBillAmount; }
			set { grossBillAmount = value; }
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
		/// Gets or sets the RoundOff value.
		/// </summary>
		public decimal RoundOff
		{
			get { return roundOff; }
			set { roundOff = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		public decimal NetAmount
		{
			get { return netAmount; }
			set { netAmount = value; }
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


		#endregion
}
}
