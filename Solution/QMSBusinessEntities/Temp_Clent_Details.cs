using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Temp_Clent_Details
	{
		#region Fields

		private string clientcode=String.Empty;
		private string clientName=String.Empty;
		private string address1=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;

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
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the Address1 value.
		/// </summary>
		public string Address1
		{
			get { return address1; }
			set { address1 = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}


		#endregion
}
}
