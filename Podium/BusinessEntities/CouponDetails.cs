using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CouponDetails
	{
		#region Fields

		private long couponDetailID=0;
		private long couponID=0;
		private string startSerialNo=String.Empty;
		private string endSerialNo=String.Empty;
		private string batchNo=String.Empty;
		private long orderedUnits=0;
		private decimal couponValue=Decimal.Zero;
		private DateTime expiryDate=DateTime.MaxValue;
		private long consumedUnits=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CouponDetailID value.
		/// </summary>
		public long CouponDetailID
		{
			get { return couponDetailID; }
			set { couponDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the CouponID value.
		/// </summary>
		public long CouponID
		{
			get { return couponID; }
			set { couponID = value; }
		}

		/// <summary>
		/// Gets or sets the StartSerialNo value.
		/// </summary>
		public string StartSerialNo
		{
			get { return startSerialNo; }
			set { startSerialNo = value; }
		}

		/// <summary>
		/// Gets or sets the EndSerialNo value.
		/// </summary>
		public string EndSerialNo
		{
			get { return endSerialNo; }
			set { endSerialNo = value; }
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
		/// Gets or sets the OrderedUnits value.
		/// </summary>
		public long OrderedUnits
		{
			get { return orderedUnits; }
			set { orderedUnits = value; }
		}

		/// <summary>
		/// Gets or sets the CouponValue value.
		/// </summary>
		public decimal CouponValue
		{
			get { return couponValue; }
			set { couponValue = value; }
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
		/// Gets or sets the ConsumedUnits value.
		/// </summary>
		public long ConsumedUnits
		{
			get { return consumedUnits; }
			set { consumedUnits = value; }
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

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		private string _code=String.Empty;
		public string Code
		{
			get { return  _code; }
			set { _code = value; }
		}


		#endregion
}
}
