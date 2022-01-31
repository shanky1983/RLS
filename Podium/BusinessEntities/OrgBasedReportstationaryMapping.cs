using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrgBasedReportstationaryMapping
	{
		#region Fields

		private long iD=0;
		private int orgID=0;
		private long orgAddressId=0;
		private long imageGroupID=0;
		private long orgImageID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the OrgAddressId value.
		/// </summary>
		public long OrgAddressId
		{
			get { return orgAddressId; }
			set { orgAddressId = value; }
		}

		/// <summary>
		/// Gets or sets the ImageGroupID value.
		/// </summary>
		public long ImageGroupID
		{
			get { return imageGroupID; }
			set { imageGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgImageID value.
		/// </summary>
		public long OrgImageID
		{
			get { return orgImageID; }
			set { orgImageID = value; }
		}


		#endregion
}
}
