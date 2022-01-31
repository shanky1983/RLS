using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		private bool active=false;
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


		#endregion
}
}
