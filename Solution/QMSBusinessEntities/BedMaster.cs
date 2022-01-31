using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BedMaster
	{
		#region Fields

		private int bedID=0;
		private string bedName=String.Empty;
		private int roomID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BedID value.
		/// </summary>
		public int BedID
		{
			get { return bedID; }
			set { bedID = value; }
		}

		/// <summary>
		/// Gets or sets the BedName value.
		/// </summary>
		public string BedName
		{
			get { return bedName; }
			set { bedName = value; }
		}

		/// <summary>
		/// Gets or sets the RoomID value.
		/// </summary>
		public int RoomID
		{
			get { return roomID; }
			set { roomID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomName value.
		/// </summary>
		string _roomname;
		public string RoomName
		{
			get { return _roomname; }
			set { _roomname = value; }
		}


		#endregion
}
}
