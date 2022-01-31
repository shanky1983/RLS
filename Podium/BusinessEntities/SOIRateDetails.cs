using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SOIRateDetails
	{
		#region Fields

		private int sOIRateDetailsID=0;
		private long sOIID=0;
		private long orgID=0;
		private int feeTypeAttributesID=0;
		private decimal amount=Decimal.Zero;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int rateRefID=0;
		private int rateID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SOIRateDetailsID value.
		/// </summary>
		public int SOIRateDetailsID
		{
			get { return sOIRateDetailsID; }
			set { sOIRateDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the SOIID value.
		/// </summary>
		public long SOIID
		{
			get { return sOIID; }
			set { sOIID = value; }
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
		/// Gets or sets the FeeTypeAttributesID value.
		/// </summary>
		public int FeeTypeAttributesID
		{
			get { return feeTypeAttributesID; }
			set { feeTypeAttributesID = value; }
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
		/// Gets or sets the RateRefID value.
		/// </summary>
		public int RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeDescription value.
		/// </summary>
		private string _feeDescription=String.Empty;
		public string FeeDescription
		{
			get { return  _feeDescription; }
			set { _feeDescription = value; }
		}


		#endregion
}
}
