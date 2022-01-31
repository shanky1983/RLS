using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SOIRateMapping
	{
		#region Fields

		private long sOIID=0;
		private long rateID=0;
		private decimal amount=Decimal.Zero;
		private int orgID=0;
		private int rateRefID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SOIID value.
		/// </summary>
		public long SOIID
		{
			get { return sOIID; }
			set { sOIID = value; }
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the RateRefID value.
		/// </summary>
		public int RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}


		#endregion
}
}
