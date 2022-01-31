using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientPaymentMode
	{
		#region Fields

		private long clientPaymentModeID=0;
		private long clientID=0;
		private long paymentModeID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientPaymentModeID value.
		/// </summary>
		public long ClientPaymentModeID
		{
			get { return clientPaymentModeID; }
			set { clientPaymentModeID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentModeID value.
		/// </summary>
		public long PaymentModeID
		{
			get { return paymentModeID; }
			set { paymentModeID = value; }
		}


		#endregion
}
}
