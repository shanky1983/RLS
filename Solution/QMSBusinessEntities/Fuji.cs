using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Fuji
	{
		#region Fields

		private float rowID=0.0F;
		private string deviceID=String.Empty;
		private string testCode=String.Empty;
		private float investigationID=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public float RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public float InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}


		#endregion
}
}
