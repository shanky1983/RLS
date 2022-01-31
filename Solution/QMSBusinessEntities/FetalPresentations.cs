using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FetalPresentations
	{
		#region Fields

		private int fetalPresentationID=0;
		private string fetalPresentationDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FetalPresentationID value.
		/// </summary>
		public int FetalPresentationID
		{
			get { return fetalPresentationID; }
			set { fetalPresentationID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalPresentationDesc value.
		/// </summary>
		public string FetalPresentationDesc
		{
			get { return fetalPresentationDesc; }
			set { fetalPresentationDesc = value; }
		}


		#endregion
}
}
