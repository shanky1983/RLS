using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientCommunication_Hist
	{
		#region Fields

		private int histId=0;
		private int clientCommunicationID=0;
		private int clientId=0;
		private string comMode=String.Empty;
		private string notifyType=String.Empty;
		private string comDetails=String.Empty;
		private bool blockNotify=false;
		private bool status=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HistId value.
		/// </summary>
		public int HistId
		{
			get { return histId; }
			set { histId = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCommunicationID value.
		/// </summary>
		public int ClientCommunicationID
		{
			get { return clientCommunicationID; }
			set { clientCommunicationID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public int ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the ComMode value.
		/// </summary>
		public string ComMode
		{
			get { return comMode; }
			set { comMode = value; }
		}

		/// <summary>
		/// Gets or sets the NotifyType value.
		/// </summary>
		public string NotifyType
		{
			get { return notifyType; }
			set { notifyType = value; }
		}

		/// <summary>
		/// Gets or sets the ComDetails value.
		/// </summary>
		public string ComDetails
		{
			get { return comDetails; }
			set { comDetails = value; }
		}

		/// <summary>
		/// Gets or sets the BlockNotify value.
		/// </summary>
		public bool BlockNotify
		{
			get { return blockNotify; }
			set { blockNotify = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
