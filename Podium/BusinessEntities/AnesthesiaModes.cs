using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AnesthesiaModes
	{
		#region Fields

		private int anesthesiaModeID=0;
		private string anesthesiaMode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AnesthesiaModeID value.
		/// </summary>
		public int AnesthesiaModeID
		{
			get { return anesthesiaModeID; }
			set { anesthesiaModeID = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaMode value.
		/// </summary>
		public string AnesthesiaMode
		{
			get { return anesthesiaMode; }
			set { anesthesiaMode = value; }
		}


		#endregion
}
}
