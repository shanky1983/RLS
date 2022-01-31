using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RefreshTokens
	{
		#region Fields

		private string id=String.Empty;
		private string subject=String.Empty;
		private string clientId=String.Empty;
		private DateTime issuedUtc=DateTime.MaxValue;
		private DateTime expiresUtc=DateTime.MaxValue;
		private string protectedTicket=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Subject value.
		/// </summary>
		public string Subject
		{
			get { return subject; }
			set { subject = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public string ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the IssuedUtc value.
		/// </summary>
		public DateTime IssuedUtc
		{
			get { return issuedUtc; }
			set { issuedUtc = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiresUtc value.
		/// </summary>
		public DateTime ExpiresUtc
		{
			get { return expiresUtc; }
			set { expiresUtc = value; }
		}

		/// <summary>
		/// Gets or sets the ProtectedTicket value.
		/// </summary>
		public string ProtectedTicket
		{
			get { return protectedTicket; }
			set { protectedTicket = value; }
		}


		#endregion
}
}
