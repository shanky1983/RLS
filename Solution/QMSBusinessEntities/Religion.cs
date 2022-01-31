using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Religion
	{
		#region Fields

		private short religionID=0;
		private string religionName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReligionID value.
		/// </summary>
		public short ReligionID
		{
			get { return religionID; }
			set { religionID = value; }
		}

		/// <summary>
		/// Gets or sets the ReligionName value.
		/// </summary>
		public string ReligionName
		{
			get { return religionName; }
			set { religionName = value; }
		}


		#endregion
}
}
