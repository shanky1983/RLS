using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Precaution
	{
		#region Fields

		private int preCautionID=0;
		private string name=String.Empty;
		private string description=String.Empty;
		private string cautionType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PreCautionID value.
		/// </summary>
		public int PreCautionID
		{
			get { return preCautionID; }
			set { preCautionID = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the CautionType value.
		/// </summary>
		public string CautionType
		{
			get { return cautionType; }
			set { cautionType = value; }
		}


		#endregion
}
}
