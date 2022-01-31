using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AMIEAL_EMAIL
	{
		#region Fields

		private int clientID=0;
		private string clientCode=String.Empty;
		private string clientName=String.Empty;
		private string email=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
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
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}


		#endregion
}
}
