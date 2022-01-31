using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SampleAttributes
	{
		#region Fields

		private int attributesID=0;
		private string attributesName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttributesID value.
		/// </summary>
		public int AttributesID
		{
			get { return attributesID; }
			set { attributesID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributesName value.
		/// </summary>
		public string AttributesName
		{
			get { return attributesName; }
			set { attributesName = value; }
		}


		#endregion
}
}
