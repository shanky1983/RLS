using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Allergy_Panel_Tcodes
	{
		#region Fields

		private string tcode=String.Empty;
		private string dEPT=String.Empty;
		private string sECTION=String.Empty;
		private string testschedule=String.Empty;
		private string reportedon=String.Empty;
		private string tNAME1=String.Empty;
		private string tNAME2=String.Empty;
		private string tNAME3=String.Empty;
		private string sampleContainer=String.Empty;
		private string type=String.Empty;

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
		/// Gets or sets the DEPT value.
		/// </summary>
		public string DEPT
		{
			get { return dEPT; }
			set { dEPT = value; }
		}

		/// <summary>
		/// Gets or sets the SECTION value.
		/// </summary>
		public string SECTION
		{
			get { return sECTION; }
			set { sECTION = value; }
		}

		/// <summary>
		/// Gets or sets the Testschedule value.
		/// </summary>
		public string Testschedule
		{
			get { return testschedule; }
			set { testschedule = value; }
		}

		/// <summary>
		/// Gets or sets the Reportedon value.
		/// </summary>
		public string Reportedon
		{
			get { return reportedon; }
			set { reportedon = value; }
		}

		/// <summary>
		/// Gets or sets the TNAME1 value.
		/// </summary>
		public string TNAME1
		{
			get { return tNAME1; }
			set { tNAME1 = value; }
		}

		/// <summary>
		/// Gets or sets the TNAME2 value.
		/// </summary>
		public string TNAME2
		{
			get { return tNAME2; }
			set { tNAME2 = value; }
		}

		/// <summary>
		/// Gets or sets the TNAME3 value.
		/// </summary>
		public string TNAME3
		{
			get { return tNAME3; }
			set { tNAME3 = value; }
		}

		/// <summary>
		/// Gets or sets the SampleContainer value.
		/// </summary>
		public string SampleContainer
		{
			get { return sampleContainer; }
			set { sampleContainer = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}


		#endregion
}
}
