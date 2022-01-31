using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationValidation
	{
		#region Fields

		private int validationID=0;
		private long investigationID=0;
		private int range=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ValidationID value.
		/// </summary>
		public int ValidationID
		{
			get { return validationID; }
			set { validationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Range value.
		/// </summary>
		public int Range
		{
			get { return range; }
			set { range = value; }
		}


		#endregion
}
}
