using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PublishingMode
	{
		#region Fields

		private long modeID=0;
		private string modeName=String.Empty;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ModeID value.
		/// </summary>
		public long ModeID
		{
			get { return modeID; }
			set { modeID = value; }
		}

		/// <summary>
		/// Gets or sets the ModeName value.
		/// </summary>
		public string ModeName
		{
			get { return modeName; }
			set { modeName = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}


		#endregion
}
}
