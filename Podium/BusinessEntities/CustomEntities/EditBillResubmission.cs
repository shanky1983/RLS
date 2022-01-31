using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EditBillResubmission
	{
		#region Fields

		private string feeType=String.Empty;
		private long feeID=0;
		private string description=String.Empty;
		private decimal unit=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private decimal totalAmount=Decimal.Zero;
		private decimal claimAmount=Decimal.Zero;
		private long detailsID=0;
		private decimal itemCopay=Decimal.Zero;
		private string itemCoPayType=String.Empty;
		private decimal rejectionAmount=Decimal.Zero;
		private string rejectionReason=String.Empty;
		private string resubmissionType=String.Empty;
		private string comments=String.Empty;
		private string preAuthNo=String.Empty;
		private DateTime preAuthDate=DateTime.MaxValue;
		private string isReimbursable=String.Empty;
		private decimal reimbursableAmount=Decimal.Zero;
		private decimal nonReimbursableAmount=Decimal.Zero;
		private string discountReason=String.Empty;
		private decimal discountPercent=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;
		private string serviceCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Unit value.
		/// </summary>
		public decimal Unit
		{
			get { return unit; }
			set { unit = value; }
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
		/// Gets or sets the TotalAmount value.
		/// </summary>
		public decimal TotalAmount
		{
			get { return totalAmount; }
			set { totalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimAmount value.
		/// </summary>
		public decimal ClaimAmount
		{
			get { return claimAmount; }
			set { claimAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCopay value.
		/// </summary>
		public decimal ItemCopay
		{
			get { return itemCopay; }
			set { itemCopay = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCoPayType value.
		/// </summary>
		public string ItemCoPayType
		{
			get { return itemCoPayType; }
			set { itemCoPayType = value; }
		}

		/// <summary>
		/// Gets or sets the RejectionAmount value.
		/// </summary>
		public decimal RejectionAmount
		{
			get { return rejectionAmount; }
			set { rejectionAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RejectionReason value.
		/// </summary>
		public string RejectionReason
		{
			get { return rejectionReason; }
			set { rejectionReason = value; }
		}

		/// <summary>
		/// Gets or sets the ResubmissionType value.
		/// </summary>
		public string ResubmissionType
		{
			get { return resubmissionType; }
			set { resubmissionType = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthNo value.
		/// </summary>
		public string PreAuthNo
		{
			get { return preAuthNo; }
			set { preAuthNo = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthDate value.
		/// </summary>
		public DateTime PreAuthDate
		{
			get { return preAuthDate; }
			set { preAuthDate = value; }
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
		/// Gets or sets the ReimbursableAmount value.
		/// </summary>
		public decimal ReimbursableAmount
		{
			get { return reimbursableAmount; }
			set { reimbursableAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NonReimbursableAmount value.
		/// </summary>
		public decimal NonReimbursableAmount
		{
			get { return nonReimbursableAmount; }
			set { nonReimbursableAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPercent value.
		/// </summary>
		public decimal DiscountPercent
		{
			get { return discountPercent; }
			set { discountPercent = value; }
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
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
		}


		#endregion
}
}
