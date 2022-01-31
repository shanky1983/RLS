using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DiscountPolicy
	{
		#region Fields

		private long tODID=0;
		private string code=String.Empty;
		private string basedOn=String.Empty;
		private long rangeFrom=0;
		private long rangeTo=0;
		private decimal valu=Decimal.Zero;
		private long feeID=0;
		private string feeType=String.Empty;
		private string name=String.Empty;
		private string isActive=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string type=String.Empty;
		private string discountName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TODID value.
		/// </summary>
		public long TODID
		{
			get { return tODID; }
			set { tODID = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the BasedOn value.
		/// </summary>
		public string BasedOn
		{
			get { return basedOn; }
			set { basedOn = value; }
		}

		/// <summary>
		/// Gets or sets the RangeFrom value.
		/// </summary>
		public long RangeFrom
		{
			get { return rangeFrom; }
			set { rangeFrom = value; }
		}

		/// <summary>
		/// Gets or sets the RangeTo value.
		/// </summary>
		public long RangeTo
		{
			get { return rangeTo; }
			set { rangeTo = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public decimal Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountName value.
		/// </summary>
		public string DiscountName
		{
			get { return discountName; }
			set { discountName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		string _clientname;
		public string ClientName
		{
			get { return _clientname; }
			set { _clientname = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		string _discount;
		public string Discount
		{
			get { return _discount; }
			set { _discount = value; }
		}

		/// <summary>
		/// Gets or sets the InvName value.
		/// </summary>
		string _invname;
		public string InvName
		{
			get { return _invname; }
			set { _invname = value; }
		}

		/// <summary>
		/// Gets or sets the VolDiscount value.
		/// </summary>
		decimal _voldiscount;
		public decimal VolDiscount
		{
			get { return _voldiscount; }
			set { _voldiscount = value; }
		}

		/// <summary>
		/// Gets or sets the Labelcount value.
		/// </summary>
		long _labelcount;
		public long Labelcount
		{
			get { return _labelcount; }
			set { _labelcount = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		decimal _amount;
		public decimal Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDiscounts value.
		/// </summary>
		decimal _totaldiscounts;
		public decimal TotalDiscounts
		{
			get { return _totaldiscounts; }
			set { _totaldiscounts = value; }
		}


		#endregion
}
}
