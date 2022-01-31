using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AppearanceMaster
	{
		#region Fields

		private int appearanceID=0;
		private string appearanceName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AppearanceID value.
		/// </summary>
		public int AppearanceID
		{
			get { return appearanceID; }
			set { appearanceID = value; }
		}

		/// <summary>
		/// Gets or sets the AppearanceName value.
		/// </summary>
		public string AppearanceName
		{
			get { return appearanceName; }
			set { appearanceName = value; }
		}


		#endregion
}
}
