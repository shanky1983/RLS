using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SampleArchival
	{
		#region Fields

		private int iD=0;
		private int storageRackID=0;
		private short rowNo=0;
		private short columnNo=0;
		private string barcodeNo=String.Empty;
		private int deptID=0;
		private int instrumentID=0;
		private int orgID=0;
		private int orgAddressID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool active=true;
		private string status=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the StorageRackID value.
		/// </summary>
		public int StorageRackID
		{
			get { return storageRackID; }
			set { storageRackID = value; }
		}

		/// <summary>
		/// Gets or sets the RowNo value.
		/// </summary>
		public short RowNo
		{
			get { return rowNo; }
			set { rowNo = value; }
		}

		/// <summary>
		/// Gets or sets the ColumnNo value.
		/// </summary>
		public short ColumnNo
		{
			get { return columnNo; }
			set { columnNo = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNo value.
		/// </summary>
		public string BarcodeNo
		{
			get { return barcodeNo; }
			set { barcodeNo = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public int InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the Active value.
		/// </summary>
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		private string _deptName=String.Empty;
		public string DeptName
		{
			get { return  _deptName; }
			set { _deptName = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentName value.
		/// </summary>
		private string _instrumentName=String.Empty;
		public string InstrumentName
		{
			get { return  _instrumentName; }
			set { _instrumentName = value; }
		}

		/// <summary>
		/// Gets or sets the BuildingID value.
		/// </summary>
		private int _buildingID=0;
		public int BuildingID
		{
			get { return  _buildingID; }
			set { _buildingID = value; }
		}

		/// <summary>
		/// Gets or sets the FloorID value.
		/// </summary>
		private short _floorID=0;
		public short FloorID
		{
			get { return  _floorID; }
			set { _floorID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomID value.
		/// </summary>
		private int _roomID=0;
		public int RoomID
		{
			get { return  _roomID; }
			set { _roomID = value; }
		}

		/// <summary>
		/// Gets or sets the StorageUnitID value.
		/// </summary>
		private int _storageUnitID=0;
		public int StorageUnitID
		{
			get { return  _storageUnitID; }
			set { _storageUnitID = value; }
		}

		/// <summary>
		/// Gets or sets the IsReady value.
		/// </summary>
		private string _isReady=String.Empty;
		public string IsReady
		{
			get { return  _isReady; }
			set { _isReady = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		private int _roomTypeID=0;
		public int RoomTypeID
		{
			get { return  _roomTypeID; }
			set { _roomTypeID = value; }
		}


		#endregion
}
}
