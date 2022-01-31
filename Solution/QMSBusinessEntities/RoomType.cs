using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RoomType
	{
		#region Fields

		private int roomTypeID=0;
		private string roomTypeName=String.Empty;
		private long orgAddID=0;
		private int orgID=0;
		private string allowSlotBooking=String.Empty;
		private string isAnOT=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeName value.
		/// </summary>
		public string RoomTypeName
		{
			get { return roomTypeName; }
			set { roomTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public long OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the AllowSlotBooking value.
		/// </summary>
		public string AllowSlotBooking
		{
			get { return allowSlotBooking; }
			set { allowSlotBooking = value; }
		}

		/// <summary>
		/// Gets or sets the IsAnOT value.
		/// </summary>
		public string IsAnOT
		{
			get { return isAnOT; }
			set { isAnOT = value; }
		}


		#endregion
}
}
