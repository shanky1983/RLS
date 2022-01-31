using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ANCAdvice
	{
		#region Fields

		private string description=String.Empty;
		private int duration=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Duration value.
		/// </summary>
		public int Duration
		{
			get { return duration; }
			set { duration = value; }
		}


		#endregion
}
}
