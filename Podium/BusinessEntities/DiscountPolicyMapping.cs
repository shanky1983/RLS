using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DiscountPolicyMapping
	{
		#region Fields

		private long policyID=0;
		private string feeType=String.Empty;
		private string categoryCode=String.Empty;
		private decimal discountPercentage=Decimal.Zero;
		private string discountType=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string feeTypeCode=String.Empty;
		private int iD=0;
		private int iCType=0;
		private int calcType=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PolicyID value.
		/// </summary>
		public long PolicyID
		{
			get { return policyID; }
			set { policyID = value; }
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
		/// Gets or sets the CategoryCode value.
		/// </summary>
		public string CategoryCode
		{
			get { return categoryCode; }
			set { categoryCode = value; }
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
		/// Gets or sets the DiscountType value.
		/// </summary>
		public string DiscountType
		{
			get { return discountType; }
			set { discountType = value; }
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
		/// Gets or sets the FeeTypeCode value.
		/// </summary>
		public string FeeTypeCode
		{
			get { return feeTypeCode; }
			set { feeTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the ICType value.
		/// </summary>
		public int ICType
		{
			get { return iCType; }
			set { iCType = value; }
		}

		/// <summary>
		/// Gets or sets the CalcType value.
		/// </summary>
		public int CalcType
		{
			get { return calcType; }
			set { calcType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeName value.
		/// </summary>
		private string _feeName=String.Empty;
		public string FeeName
		{
			get { return  _feeName; }
			set { _feeName = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryName value.
		/// </summary>
		private string _categoryName=String.Empty;
		public string CategoryName
		{
			get { return  _categoryName; }
			set { _categoryName = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountName value.
		/// </summary>
		private string _discountName=String.Empty;
		public string DiscountName
		{
			get { return  _discountName; }
			set { _discountName = value; }
		}


		#endregion
}
}
