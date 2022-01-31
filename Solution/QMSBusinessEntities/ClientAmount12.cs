using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientAmount12
	{
		#region Fields

		private string clientcode=String.Empty;
		private decimal amount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Clientcode value.
		/// </summary>
		public string Clientcode
		{
			get { return clientcode; }
			set { clientcode = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}


		#endregion
}
}
