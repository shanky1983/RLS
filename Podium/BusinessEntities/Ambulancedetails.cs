using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Ambulancedetails
	{
		#region Fields

		private int itemId=0;
		private string itemName=String.Empty;
		private string activeYN=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ItemId value.
		/// </summary>
		public int ItemId
		{
			get { return itemId; }
			set { itemId = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
		}

		/// <summary>
		/// Gets or sets the ActiveYN value.
		/// </summary>
		public string ActiveYN
		{
			get { return activeYN; }
			set { activeYN = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
