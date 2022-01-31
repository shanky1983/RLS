using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InPatientDischargedWith
	{
		#region Fields

		private int dischargedWithID=0;
		private int dischargeID=0;
		private string dischargedWithName=String.Empty;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargedWithID value.
		/// </summary>
		public int DischargedWithID
		{
			get { return dischargedWithID; }
			set { dischargedWithID = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeID value.
		/// </summary>
		public int DischargeID
		{
			get { return dischargeID; }
			set { dischargeID = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedWithName value.
		/// </summary>
		public string DischargedWithName
		{
			get { return dischargedWithName; }
			set { dischargedWithName = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}


		#endregion
}
}
