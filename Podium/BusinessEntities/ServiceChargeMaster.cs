using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ServiceChargeMaster
	{
		#region Fields

		private int serviceChargeID=0;
		private string serviceCharegeDesc=String.Empty;
		private string percentage=String.Empty;
		private decimal chargeAmount=Decimal.Zero;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ServiceChargeID value.
		/// </summary>
		public int ServiceChargeID
		{
			get { return serviceChargeID; }
			set { serviceChargeID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharegeDesc value.
		/// </summary>
		public string ServiceCharegeDesc
		{
			get { return serviceCharegeDesc; }
			set { serviceCharegeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the Percentage value.
		/// </summary>
		public string Percentage
		{
			get { return percentage; }
			set { percentage = value; }
		}

		/// <summary>
		/// Gets or sets the ChargeAmount value.
		/// </summary>
		public decimal ChargeAmount
		{
			get { return chargeAmount; }
			set { chargeAmount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
