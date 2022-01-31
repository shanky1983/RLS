using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RoomMaster
	{
		#region Fields

		private string roomName=String.Empty;
		private short floorID=0;
		private int roomTypeID=0;
		private int wardID=0;
		private short roomID=0;
		private short priority=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RoomName value.
		/// </summary>
		public string RoomName
		{
			get { return roomName; }
			set { roomName = value; }
		}

		/// <summary>
		/// Gets or sets the FloorID value.
		/// </summary>
		public short FloorID
		{
			get { return floorID; }
			set { floorID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the WardID value.
		/// </summary>
		public int WardID
		{
			get { return wardID; }
			set { wardID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomID value.
		/// </summary>
		public short RoomID
		{
			get { return roomID; }
			set { roomID = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public short Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the NoBeds value.
		/// </summary>
		int _nobeds;
		public int NoBeds
		{
			get { return _nobeds; }
			set { _nobeds = value; }
		}


		#endregion
}
}
