using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Edt_AccountsImpactDetails
	{
		#region Fields

		private long edtAccountImpactID=0;
		private long edtMasterBillID=0;
		private int orgID=0;
		private decimal grossBillValue=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal discountPercentage=Decimal.Zero;
		private string discountReason=String.Empty;
		private decimal tax=Decimal.Zero;
		private decimal serviceCharge=Decimal.Zero;
		private decimal roundOffAmount=Decimal.Zero;
		private decimal netValue=Decimal.Zero;
		private decimal previousReceivedAmount=Decimal.Zero;
		private decimal receivedAmount=Decimal.Zero;
		private decimal previousRefundAmount=Decimal.Zero;
		private decimal refundAmount=Decimal.Zero;
		private decimal due=Decimal.Zero;
		private decimal medicalAmount=Decimal.Zero;
		private decimal nonMedicalAmount=Decimal.Zero;
		private DateTime edtDate=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int roleID=0;
		private int deptID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EdtAccountImpactID value.
		/// </summary>
		public long EdtAccountImpactID
		{
			get { return edtAccountImpactID; }
			set { edtAccountImpactID = value; }
		}

		/// <summary>
		/// Gets or sets the EdtMasterBillID value.
		/// </summary>
		public long EdtMasterBillID
		{
			get { return edtMasterBillID; }
			set { edtMasterBillID = value; }
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
		/// Gets or sets the GrossBillValue value.
		/// </summary>
		public decimal GrossBillValue
		{
			get { return grossBillValue; }
			set { grossBillValue = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
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
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOffAmount value.
		/// </summary>
		public decimal RoundOffAmount
		{
			get { return roundOffAmount; }
			set { roundOffAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		public decimal NetValue
		{
			get { return netValue; }
			set { netValue = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousReceivedAmount value.
		/// </summary>
		public decimal PreviousReceivedAmount
		{
			get { return previousReceivedAmount; }
			set { previousReceivedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		public decimal ReceivedAmount
		{
			get { return receivedAmount; }
			set { receivedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousRefundAmount value.
		/// </summary>
		public decimal PreviousRefundAmount
		{
			get { return previousRefundAmount; }
			set { previousRefundAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RefundAmount value.
		/// </summary>
		public decimal RefundAmount
		{
			get { return refundAmount; }
			set { refundAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Due value.
		/// </summary>
		public decimal Due
		{
			get { return due; }
			set { due = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalAmount value.
		/// </summary>
		public decimal MedicalAmount
		{
			get { return medicalAmount; }
			set { medicalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NonMedicalAmount value.
		/// </summary>
		public decimal NonMedicalAmount
		{
			get { return nonMedicalAmount; }
			set { nonMedicalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the EdtDate value.
		/// </summary>
		public DateTime EdtDate
		{
			get { return edtDate; }
			set { edtDate = value; }
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
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}


		#endregion
}
}
