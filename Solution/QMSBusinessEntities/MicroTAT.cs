using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MicroTAT
	{
		#region Fields

		private string tcode=String.Empty;
		private string type=String.Empty;
		private string tATDAYS=String.Empty;
		private float hR=0.0F;
		private string labStart=String.Empty;
		private string labEnd=String.Empty;
		private string earlyreport=String.Empty;
		private string rB=String.Empty;
		private string schedule=String.Empty;
		private string iD=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the LabStart value.
		/// </summary>
		public string LabStart
		{
			get { return labStart; }
			set { labStart = value; }
		}

		/// <summary>
		/// Gets or sets the LabEnd value.
		/// </summary>
		public string LabEnd
		{
			get { return labEnd; }
			set { labEnd = value; }
		}

		/// <summary>
		/// Gets or sets the Earlyreport value.
		/// </summary>
		public string Earlyreport
		{
			get { return earlyreport; }
			set { earlyreport = value; }
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

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public string ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
