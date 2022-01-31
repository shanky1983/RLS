using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ColorMaster
	{
		#region Fields

		private int colorID=0;
		private string colorName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ColorID value.
		/// </summary>
		public int ColorID
		{
			get { return colorID; }
			set { colorID = value; }
		}

		/// <summary>
		/// Gets or sets the ColorName value.
		/// </summary>
		public string ColorName
		{
			get { return colorName; }
			set { colorName = value; }
		}


		#endregion
}
}
