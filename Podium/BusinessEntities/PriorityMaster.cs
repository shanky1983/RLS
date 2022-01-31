using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PriorityMaster
	{
		#region Fields

		private int priorityID=0;
		private string priorityName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PriorityID value.
		/// </summary>
		public int PriorityID
		{
			get { return priorityID; }
			set { priorityID = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityName value.
		/// </summary>
		public string PriorityName
		{
			get { return priorityName; }
			set { priorityName = value; }
		}


		#endregion
}
}
