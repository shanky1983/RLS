using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BodyPartChildItems
	{
		#region Fields

		private long bodyPartChildItemsID=0;
		private string name=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BodyPartChildItemsID value.
		/// </summary>
		public long BodyPartChildItemsID
		{
			get { return bodyPartChildItemsID; }
			set { bodyPartChildItemsID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}


		#endregion
}
}
