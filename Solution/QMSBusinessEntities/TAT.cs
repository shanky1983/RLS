using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TAT
	{
		#region Fields

		private string tCODE=String.Empty;
		private string tNAME1=String.Empty;
		private string tNAME2=String.Empty;
		private string tNAME3=String.Empty;
		private string tESTSCHEDULE=String.Empty;
		private string rEPORTEDON=String.Empty;
		private float hOURS=0.0F;
		private string rB=String.Empty;
		private float lABSTART=0.0F;
		private float lABEND=0.0F;
		private float eARLYREPORT=0.0F;
		private float cUTOFF=0.0F;
		private string sCHEDULE=String.Empty;
		private string fORMAT=String.Empty;
		private float tD=0.0F;
		private float nOOFBATCHESPERDAY=0.0F;
		private float sTM=0.0F;
		private float dAYBATCHNO=0.0F;
		private float nEXTBATCHTD=0.0F;
		private float rEPTIME=0.0F;
		private float fCUTOFF=0.0F;
		private string invistigationID=String.Empty;
		private float batchesPerWeek=0.0F;
		private string dEPT=String.Empty;
		private string sECTION=String.Empty;

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
		/// Gets or sets the TESTSCHEDULE value.
		/// </summary>
		public string TESTSCHEDULE
		{
			get { return tESTSCHEDULE; }
			set { tESTSCHEDULE = value; }
		}

		/// <summary>
		/// Gets or sets the REPORTEDON value.
		/// </summary>
		public string REPORTEDON
		{
			get { return rEPORTEDON; }
			set { rEPORTEDON = value; }
		}

		/// <summary>
		/// Gets or sets the HOURS value.
		/// </summary>
		public float HOURS
		{
			get { return hOURS; }
			set { hOURS = value; }
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
		/// Gets or sets the EARLYREPORT value.
		/// </summary>
		public float EARLYREPORT
		{
			get { return eARLYREPORT; }
			set { eARLYREPORT = value; }
		}

		/// <summary>
		/// Gets or sets the CUTOFF value.
		/// </summary>
		public float CUTOFF
		{
			get { return cUTOFF; }
			set { cUTOFF = value; }
		}

		/// <summary>
		/// Gets or sets the SCHEDULE value.
		/// </summary>
		public string SCHEDULE
		{
			get { return sCHEDULE; }
			set { sCHEDULE = value; }
		}

		/// <summary>
		/// Gets or sets the FORMAT value.
		/// </summary>
		public string FORMAT
		{
			get { return fORMAT; }
			set { fORMAT = value; }
		}

		/// <summary>
		/// Gets or sets the TD value.
		/// </summary>
		public float TD
		{
			get { return tD; }
			set { tD = value; }
		}

		/// <summary>
		/// Gets or sets the NOOFBATCHESPERDAY value.
		/// </summary>
		public float NOOFBATCHESPERDAY
		{
			get { return nOOFBATCHESPERDAY; }
			set { nOOFBATCHESPERDAY = value; }
		}

		/// <summary>
		/// Gets or sets the STM value.
		/// </summary>
		public float STM
		{
			get { return sTM; }
			set { sTM = value; }
		}

		/// <summary>
		/// Gets or sets the DAYBATCHNO value.
		/// </summary>
		public float DAYBATCHNO
		{
			get { return dAYBATCHNO; }
			set { dAYBATCHNO = value; }
		}

		/// <summary>
		/// Gets or sets the NEXTBATCHTD value.
		/// </summary>
		public float NEXTBATCHTD
		{
			get { return nEXTBATCHTD; }
			set { nEXTBATCHTD = value; }
		}

		/// <summary>
		/// Gets or sets the REPTIME value.
		/// </summary>
		public float REPTIME
		{
			get { return rEPTIME; }
			set { rEPTIME = value; }
		}

		/// <summary>
		/// Gets or sets the FCUTOFF value.
		/// </summary>
		public float FCUTOFF
		{
			get { return fCUTOFF; }
			set { fCUTOFF = value; }
		}

		/// <summary>
		/// Gets or sets the InvistigationID value.
		/// </summary>
		public string InvistigationID
		{
			get { return invistigationID; }
			set { invistigationID = value; }
		}

		/// <summary>
		/// Gets or sets the BatchesPerWeek value.
		/// </summary>
		public float BatchesPerWeek
		{
			get { return batchesPerWeek; }
			set { batchesPerWeek = value; }
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


		#endregion
}
}
