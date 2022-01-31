using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Edt_BillMasterDetails
	{
		#region Fields

		private long edtBillMasterDetailsID=0;
		private long edtBillMasterID=0;
		private long finalBillID=0;
		private int orgID=0;
		private DateTime edtDate=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int roleID=0;
		private int deptID=0;
		private decimal grossBillValue=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal tax=Decimal.Zero;
		private decimal serviceCharge=Decimal.Zero;
		private decimal roundOffAmount=Decimal.Zero;
		private decimal netValue=Decimal.Zero;
		private decimal receivedAmount=Decimal.Zero;
		private decimal refundAmount=Decimal.Zero;
		private decimal due=Decimal.Zero;
		private string billNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EdtBillMasterDetailsID value.
		/// </summary>
		public long EdtBillMasterDetailsID
		{
			get { return edtBillMasterDetailsID; }
			set { edtBillMasterDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the EdtBillMasterID value.
		/// </summary>
		public long EdtBillMasterID
		{
			get { return edtBillMasterID; }
			set { edtBillMasterID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		public decimal ReceivedAmount
		{
			get { return receivedAmount; }
			set { receivedAmount = value; }
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
		/// Gets or sets the BillNumber value.
		/// </summary>
		public string BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
		}


		#endregion
}
}
