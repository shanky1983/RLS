using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FlowCyto_ReferenceRange
	{
		#region Fields

		private string displayText=String.Empty;
		private string referenceRange=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}


		#endregion
}
}
