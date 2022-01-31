using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CashClosureDenominationMaster
	{
		#region Fields

		private long iD=0;
		private decimal rupees=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Rupees value.
		/// </summary>
		public decimal Rupees
		{
			get { return rupees; }
			set { rupees = value; }
		}


		#endregion
}
}
