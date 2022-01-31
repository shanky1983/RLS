using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Diet_FoodMenuWardMapping
	{
		#region Fields

		private long foodMenuWardMapping=0;
		private long foodMenuID=0;
		private int wardID=0;
		private int roomTypeID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FoodMenuWardMapping value.
		/// </summary>
		public long FoodMenuWardMapping
		{
			get { return foodMenuWardMapping; }
			set { foodMenuWardMapping = value; }
		}

		/// <summary>
		/// Gets or sets the FoodMenuID value.
		/// </summary>
		public long FoodMenuID
		{
			get { return foodMenuID; }
			set { foodMenuID = value; }
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
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the BuildingName value.
		/// </summary>
		private string _buildingName=String.Empty;
		public string BuildingName
		{
			get { return  _buildingName; }
			set { _buildingName = value; }
		}

		/// <summary>
		/// Gets or sets the WardName value.
		/// </summary>
		private string _wardName=String.Empty;
		public string WardName
		{
			get { return  _wardName; }
			set { _wardName = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeName value.
		/// </summary>
		private string _roomTypeName=String.Empty;
		public string RoomTypeName
		{
			get { return  _roomTypeName; }
			set { _roomTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the FoodMenuName value.
		/// </summary>
		private string _foodMenuName=String.Empty;
		public string FoodMenuName
		{
			get { return  _foodMenuName; }
			set { _foodMenuName = value; }
		}

		/// <summary>
		/// Gets or sets the BuildingID value.
		/// </summary>
		private long _buildingID=0;
		public long BuildingID
		{
			get { return  _buildingID; }
			set { _buildingID = value; }
		}


		#endregion
}
}
