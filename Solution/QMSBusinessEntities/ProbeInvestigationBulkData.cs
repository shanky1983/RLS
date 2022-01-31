using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProbeInvestigationBulkData
	{
		#region Fields

		private float resultID=0.0F;
		private string tcode=String.Empty;
		private string name =String.Empty;
		private string valu=String.Empty;
		private string investigationID=String.Empty;
		private long newResultID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResultID value.
		/// </summary>
		public float ResultID
		{
			get { return resultID; }
			set { resultID = value; }
		}

		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public string InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the NewResultID value.
		/// </summary>
		public long NewResultID
		{
			get { return newResultID; }
			set { newResultID = value; }
		}


		#endregion
}
}
