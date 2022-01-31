using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StorageRackMaster
	{
		#region Fields

		private int iD=0;
		private string name=String.Empty;
		private string rackType=String.Empty;
		private int storageUnitID=0;
		private short totalRows=0;
		private short totalColumns=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool active=false;
		private long sampleGroupID=0;
		private long sampleCode=0;

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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the RackType value.
		/// </summary>
		public string RackType
		{
			get { return rackType; }
			set { rackType = value; }
		}

		/// <summary>
		/// Gets or sets the StorageUnitID value.
		/// </summary>
		public int StorageUnitID
		{
			get { return storageUnitID; }
			set { storageUnitID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalRows value.
		/// </summary>
		public short TotalRows
		{
			get { return totalRows; }
			set { totalRows = value; }
		}

		/// <summary>
		/// Gets or sets the TotalColumns value.
		/// </summary>
		public short TotalColumns
		{
			get { return totalColumns; }
			set { totalColumns = value; }
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
		/// Gets or sets the Active value.
		/// </summary>
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		/// <summary>
		/// Gets or sets the SampleGroupID value.
		/// </summary>
		public long SampleGroupID
		{
			get { return sampleGroupID; }
			set { sampleGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public long SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}


		#endregion
}
}
