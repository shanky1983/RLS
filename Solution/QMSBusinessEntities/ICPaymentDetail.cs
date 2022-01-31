using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ICPaymentDetail
	{
		#region Fields

		private int iCPaymentDetailID=0;
		private int iCPaymentID=0;
		private int physicianid=0;
		private short billCount=0;
		private decimal billAmount=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal netAmount=Decimal.Zero;
		private decimal payableamount=Decimal.Zero;
		private decimal payamount=Decimal.Zero;
		private byte paystatus=0x00;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ICPaymentDetailID value.
		/// </summary>
		public int ICPaymentDetailID
		{
			get { return iCPaymentDetailID; }
			set { iCPaymentDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the ICPaymentID value.
		/// </summary>
		public int ICPaymentID
		{
			get { return iCPaymentID; }
			set { iCPaymentID = value; }
		}

		/// <summary>
		/// Gets or sets the Physicianid value.
		/// </summary>
		public int Physicianid
		{
			get { return physicianid; }
			set { physicianid = value; }
		}

		/// <summary>
		/// Gets or sets the BillCount value.
		/// </summary>
		public short BillCount
		{
			get { return billCount; }
			set { billCount = value; }
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
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
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
		/// Gets or sets the Payableamount value.
		/// </summary>
		public decimal Payableamount
		{
			get { return payableamount; }
			set { payableamount = value; }
		}

		/// <summary>
		/// Gets or sets the Payamount value.
		/// </summary>
		public decimal Payamount
		{
			get { return payamount; }
			set { payamount = value; }
		}

		/// <summary>
		/// Gets or sets the Paystatus value.
		/// </summary>
		public byte Paystatus
		{
			get { return paystatus; }
			set { paystatus = value; }
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
