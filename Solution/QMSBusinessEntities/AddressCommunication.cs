using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AddressCommunication
	{
		#region Fields

		private int addressCommunicationID=0;
		private int addressID=0;
		private string comMode=String.Empty;
		private string notifyType=String.Empty;
		private string comDetails=String.Empty;
		private bool blockNotify=false;
		private bool status=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AddressCommunicationID value.
		/// </summary>
		public int AddressCommunicationID
		{
			get { return addressCommunicationID; }
			set { addressCommunicationID = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public int AddressID
		{
			get { return addressID; }
			set { addressID = value; }
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
