using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CouponValueMaster
	{
		#region Fields

		private int couponId=0;
		private string couponName=String.Empty;
		private string couponBarcode=String.Empty;
		private decimal couponValue=Decimal.Zero;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private long physicianId=0;
		private int orgID=0;
		private long addressId=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string status=String.Empty;
		private long investigationID=0;
		private string type=String.Empty;
		private string isDelete=String.Empty;
		private int totalAllowedCount=0;
		private int usedCount=0;
		private string couponType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CouponId value.
		/// </summary>
		public int CouponId
		{
			get { return couponId; }
			set { couponId = value; }
		}

		/// <summary>
		/// Gets or sets the CouponName value.
		/// </summary>
		public string CouponName
		{
			get { return couponName; }
			set { couponName = value; }
		}

		/// <summary>
		/// Gets or sets the CouponBarcode value.
		/// </summary>
		public string CouponBarcode
		{
			get { return couponBarcode; }
			set { couponBarcode = value; }
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
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianId value.
		/// </summary>
		public long PhysicianId
		{
			get { return physicianId; }
			set { physicianId = value; }
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
		/// Gets or sets the AddressId value.
		/// </summary>
		public long AddressId
		{
			get { return addressId; }
			set { addressId = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the IsDelete value.
		/// </summary>
		public string IsDelete
		{
			get { return isDelete; }
			set { isDelete = value; }
		}

		/// <summary>
		/// Gets or sets the TotalAllowedCount value.
		/// </summary>
		public int TotalAllowedCount
		{
			get { return totalAllowedCount; }
			set { totalAllowedCount = value; }
		}

		/// <summary>
		/// Gets or sets the UsedCount value.
		/// </summary>
		public int UsedCount
		{
			get { return usedCount; }
			set { usedCount = value; }
		}

		/// <summary>
		/// Gets or sets the CouponType value.
		/// </summary>
		public string CouponType
		{
			get { return couponType; }
			set { couponType = value; }
		}


		#endregion
}
}
