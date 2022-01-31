using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvQualitativeResultMaster
	{
		#region Fields

		private int qualitativeResultId=0;
		private string qualitativeResultName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QualitativeResultId value.
		/// </summary>
		public int QualitativeResultId
		{
			get { return qualitativeResultId; }
			set { qualitativeResultId = value; }
		}

		/// <summary>
		/// Gets or sets the QualitativeResultName value.
		/// </summary>
		public string QualitativeResultName
		{
			get { return qualitativeResultName; }
			set { qualitativeResultName = value; }
		}


		#endregion
}
}
