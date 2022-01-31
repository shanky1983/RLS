using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FetalFHS
	{
		#region Fields

		private int fetalFHSID=0;
		private string fetalFHSDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FetalFHSID value.
		/// </summary>
		public int FetalFHSID
		{
			get { return fetalFHSID; }
			set { fetalFHSID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalFHSDesc value.
		/// </summary>
		public string FetalFHSDesc
		{
			get { return fetalFHSDesc; }
			set { fetalFHSDesc = value; }
		}


		#endregion
}
}
