using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TAT_17
	{
		#region Fields

		private string tCODE=String.Empty;
		private string tATDAYS=String.Empty;
		private float hR=0.0F;
		private float lABSTART=0.0F;
		private float lABEND=0.0F;
		private float reportTime=0.0F;
		private string rB=String.Empty;
		private string schedule=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TATDAYS value.
		/// </summary>
		public string TATDAYS
		{
			get { return tATDAYS; }
			set { tATDAYS = value; }
		}

		/// <summary>
		/// Gets or sets the HR value.
		/// </summary>
		public float HR
		{
			get { return hR; }
			set { hR = value; }
		}

		/// <summary>
		/// Gets or sets the LABSTART value.
		/// </summary>
		public float LABSTART
		{
			get { return lABSTART; }
			set { lABSTART = value; }
		}

		/// <summary>
		/// Gets or sets the LABEND value.
		/// </summary>
		public float LABEND
		{
			get { return lABEND; }
			set { lABEND = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTime value.
		/// </summary>
		public float ReportTime
		{
			get { return reportTime; }
			set { reportTime = value; }
		}

		/// <summary>
		/// Gets or sets the RB value.
		/// </summary>
		public string RB
		{
			get { return rB; }
			set { rB = value; }
		}

		/// <summary>
		/// Gets or sets the Schedule value.
		/// </summary>
		public string Schedule
		{
			get { return schedule; }
			set { schedule = value; }
		}


		#endregion
}
}
