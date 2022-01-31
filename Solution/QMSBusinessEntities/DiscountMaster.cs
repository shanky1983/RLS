using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DiscountMaster
	{
		#region Fields

		private int discountID=0;
		private string discountName=String.Empty;
		private long orgID=0;
		private decimal discount=Decimal.Zero;
		private string discountPercentage=String.Empty;
		private string isDeleted=String.Empty;
		private string code=String.Empty;
		private string discountReason=String.Empty;
		private string discountType=String.Empty;
		private decimal ceilingValue=Decimal.Zero;
		private string dataSetname=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isRequiresReason=String.Empty;
		private string isApprovalRequired=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DiscountID value.
		/// </summary>
		public int DiscountID
		{
			get { return discountID; }
			set { discountID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		public string DiscountPercentage
		{
			get { return discountPercentage; }
			set { discountPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
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
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
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
		/// Gets or sets the CeilingValue value.
		/// </summary>
		public decimal CeilingValue
		{
			get { return ceilingValue; }
			set { ceilingValue = value; }
		}

		/// <summary>
		/// Gets or sets the DataSetname value.
		/// </summary>
		public string DataSetname
		{
			get { return dataSetname; }
			set { dataSetname = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the IsRequiresReason value.
		/// </summary>
		public string IsRequiresReason
		{
			get { return isRequiresReason; }
			set { isRequiresReason = value; }
		}

		/// <summary>
		/// Gets or sets the IsApprovalRequired value.
		/// </summary>
		public string IsApprovalRequired
		{
			get { return isApprovalRequired; }
			set { isApprovalRequired = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
