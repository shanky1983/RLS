using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CasualtyCharges
	{
		#region Fields

		private int sNO=0;
		private int casualtyID=0;
		private string casualtyCode=String.Empty;
		private string testName=String.Empty;
		private string feeType=String.Empty;
		private decimal casualtyRate=Decimal.Zero;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long rateID=0;
		private long rateRefID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SNO value.
		/// </summary>
		public int SNO
		{
			get { return sNO; }
			set { sNO = value; }
		}

		/// <summary>
		/// Gets or sets the CasualtyID value.
		/// </summary>
		public int CasualtyID
		{
			get { return casualtyID; }
			set { casualtyID = value; }
		}

		/// <summary>
		/// Gets or sets the CasualtyCode value.
		/// </summary>
		public string CasualtyCode
		{
			get { return casualtyCode; }
			set { casualtyCode = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
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
		/// Gets or sets the CasualtyRate value.
		/// </summary>
		public decimal CasualtyRate
		{
			get { return casualtyRate; }
			set { casualtyRate = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}


		#endregion
}
}
