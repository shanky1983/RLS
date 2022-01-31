using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ICPaymentBilldetail
	{
		#region Fields

		private long iCBilldetailid=0;
		private int iCPaymentDetailID=0;
		private long finalbillid=0;
		private decimal billAmount=Decimal.Zero;
		private decimal disamount=Decimal.Zero;
		private bool payblock=false;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ICBilldetailid value.
		/// </summary>
		public long ICBilldetailid
		{
			get { return iCBilldetailid; }
			set { iCBilldetailid = value; }
		}

		/// <summary>
		/// Gets or sets the ICPaymentDetailID value.
		/// </summary>
		public int ICPaymentDetailID
		{
			get { return iCPaymentDetailID; }
			set { iCPaymentDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the Finalbillid value.
		/// </summary>
		public long Finalbillid
		{
			get { return finalbillid; }
			set { finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the BillAmount value.
		/// </summary>
		public decimal BillAmount
		{
			get { return billAmount; }
			set { billAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Disamount value.
		/// </summary>
		public decimal Disamount
		{
			get { return disamount; }
			set { disamount = value; }
		}

		/// <summary>
		/// Gets or sets the Payblock value.
		/// </summary>
		public bool Payblock
		{
			get { return payblock; }
			set { payblock = value; }
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
