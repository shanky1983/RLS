using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SmartCardMaster
	{
		#region Fields

		private long smartCardID=0;
		private long orgID=0;
		private string displayFormat=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SmartCardID value.
		/// </summary>
		public long SmartCardID
		{
			get { return smartCardID; }
			set { smartCardID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayFormat value.
		/// </summary>
		public string DisplayFormat
		{
			get { return displayFormat; }
			set { displayFormat = value; }
		}


		#endregion
}
}
