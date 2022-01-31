using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ML_Client_HQ
	{
		#region Fields

		private int clientid=0;
		private string clientCode=String.Empty;
		private string clientName=String.Empty;
		private string hQ=String.Empty;
		private int hQID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Clientid value.
		/// </summary>
		public int Clientid
		{
			get { return clientid; }
			set { clientid = value; }
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
		/// Gets or sets the HQ value.
		/// </summary>
		public string HQ
		{
			get { return hQ; }
			set { hQ = value; }
		}

		/// <summary>
		/// Gets or sets the HQID value.
		/// </summary>
		public int HQID
		{
			get { return hQID; }
			set { hQID = value; }
		}


		#endregion
}
}
