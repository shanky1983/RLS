using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Invvaluess
	{
		#region Fields

		private long patientvisitid=0;
		private int investigationid=0;
		private string valu=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Patientvisitid value.
		/// </summary>
		public long Patientvisitid
		{
			get { return patientvisitid; }
			set { patientvisitid = value; }
		}

		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public int Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}


		#endregion
}
}
