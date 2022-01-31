using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StorageRackDayMaster
	{
		#region Fields

		private int iD=0;
		private int storageRackID=0;
		private short number=0;
		private string name=String.Empty;
		private int orgID=0;
		private bool active=false;

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
		/// Gets or sets the Number value.
		/// </summary>
		public short Number
		{
			get { return number; }
			set { number = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}


		#endregion
}
}
