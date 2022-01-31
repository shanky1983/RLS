using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrganizationSpeciality
	{
		#region Fields

		private int orgID=0;
		private int specialityID=0;
		private decimal amount=Decimal.Zero;
		private decimal iPAmount=Decimal.Zero;
		private long rateID=0;
		private long orgSpecialityID=0;
		private string name=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string chartAccCode=String.Empty;
		private string isAmountEditable=String.Empty;
		private string isRefundable=String.Empty;
		private string isTaxable=String.Empty;
		private string isDiscountable=String.Empty;
		private string isActive=String.Empty;
		private string serviceCode=String.Empty;
		private long feeTypeGroupOrgID=0;
		private string isFollowUpLogic=String.Empty;
		private string dischargeSummary=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the IPAmount value.
		/// </summary>
		public decimal IPAmount
		{
			get { return iPAmount; }
			set { iPAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgSpecialityID value.
		/// </summary>
		public long OrgSpecialityID
		{
			get { return orgSpecialityID; }
			set { orgSpecialityID = value; }
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
		/// Gets or sets the IsTaxable value.
		/// </summary>
		public string IsTaxable
		{
			get { return isTaxable; }
			set { isTaxable = value; }
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
		/// Gets or sets the IsFollowUpLogic value.
		/// </summary>
		public string IsFollowUpLogic
		{
			get { return isFollowUpLogic; }
			set { isFollowUpLogic = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeSummary value.
		/// </summary>
		public string DischargeSummary
		{
			get { return dischargeSummary; }
			set { dischargeSummary = value; }
		}


		#endregion
}
}
