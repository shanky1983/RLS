using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GeneralBillingMaster
	{
		#region Fields

		private long genBillID=0;
		private string genBillName=String.Empty;
		private long orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string code=String.Empty;
		private string hasAddlnDetails=String.Empty;
		private string isDefaultBilling=String.Empty;
		private string isDiscountable=String.Empty;
		private string isTaxable=String.Empty;
		private string isVariable=String.Empty;
		private string isStatFee=String.Empty;
		private string autoCalculate=String.Empty;
		private string feeSubType=String.Empty;
		private string chartAccCode=String.Empty;
		private string isAmountEditable=String.Empty;
		private string isRefundable=String.Empty;
		private string isActive=String.Empty;
		private string serviceCode=String.Empty;
		private long feeTypeGroupOrgID=0;
		private string isRedeem=String.Empty;
		private decimal redeemAmount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GenBillID value.
		/// </summary>
		public long GenBillID
		{
			get { return genBillID; }
			set { genBillID = value; }
		}

		/// <summary>
		/// Gets or sets the GenBillName value.
		/// </summary>
		public string GenBillName
		{
			get { return genBillName; }
			set { genBillName = value; }
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
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the HasAddlnDetails value.
		/// </summary>
		public string HasAddlnDetails
		{
			get { return hasAddlnDetails; }
			set { hasAddlnDetails = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefaultBilling value.
		/// </summary>
		public string IsDefaultBilling
		{
			get { return isDefaultBilling; }
			set { isDefaultBilling = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
		}

		/// <summary>
		/// Gets or sets the IsTaxable value.
		/// </summary>
		public string IsTaxable
		{
			get { return isTaxable; }
			set { isTaxable = value; }
		}

		/// <summary>
		/// Gets or sets the IsVariable value.
		/// </summary>
		public string IsVariable
		{
			get { return isVariable; }
			set { isVariable = value; }
		}

		/// <summary>
		/// Gets or sets the IsStatFee value.
		/// </summary>
		public string IsStatFee
		{
			get { return isStatFee; }
			set { isStatFee = value; }
		}

		/// <summary>
		/// Gets or sets the AutoCalculate value.
		/// </summary>
		public string AutoCalculate
		{
			get { return autoCalculate; }
			set { autoCalculate = value; }
		}

		/// <summary>
		/// Gets or sets the FeeSubType value.
		/// </summary>
		public string FeeSubType
		{
			get { return feeSubType; }
			set { feeSubType = value; }
		}

		/// <summary>
		/// Gets or sets the ChartAccCode value.
		/// </summary>
		public string ChartAccCode
		{
			get { return chartAccCode; }
			set { chartAccCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsAmountEditable value.
		/// </summary>
		public string IsAmountEditable
		{
			get { return isAmountEditable; }
			set { isAmountEditable = value; }
		}

		/// <summary>
		/// Gets or sets the IsRefundable value.
		/// </summary>
		public string IsRefundable
		{
			get { return isRefundable; }
			set { isRefundable = value; }
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
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeGroupOrgID value.
		/// </summary>
		public long FeeTypeGroupOrgID
		{
			get { return feeTypeGroupOrgID; }
			set { feeTypeGroupOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsRedeem value.
		/// </summary>
		public string IsRedeem
		{
			get { return isRedeem; }
			set { isRedeem = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemAmount value.
		/// </summary>
		public decimal RedeemAmount
		{
			get { return redeemAmount; }
			set { redeemAmount = value; }
		}


		#endregion
}
}
