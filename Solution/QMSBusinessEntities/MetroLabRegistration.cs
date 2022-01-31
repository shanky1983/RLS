using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MetroLabRegistration
	{
		#region Fields

		private float hLABNO=0.0F;
		private string hDATE=String.Empty;
		private string hTIME=String.Empty;
		private string hPATNAM=String.Empty;
		private float hAGE=0.0F;
		private string hSEX=String.Empty;
		private string hREFDOC=String.Empty;
		private string dNAME=String.Empty;
		private string tDEPT=String.Empty;
		private string metrolabCode=String.Empty;
		private string eDOSCODE=String.Empty;
		private string dTDESC=String.Empty;
		private string hCOLCD=String.Empty;
		private string cLNAME=String.Empty;
		private string hCOLLDATE=String.Empty;
		private string hCOLLTIME=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLABNO value.
		/// </summary>
		public float HLABNO
		{
			get { return hLABNO; }
			set { hLABNO = value; }
		}

		/// <summary>
		/// Gets or sets the HDATE value.
		/// </summary>
		public string HDATE
		{
			get { return hDATE; }
			set { hDATE = value; }
		}

		/// <summary>
		/// Gets or sets the HTIME value.
		/// </summary>
		public string HTIME
		{
			get { return hTIME; }
			set { hTIME = value; }
		}

		/// <summary>
		/// Gets or sets the HPATNAM value.
		/// </summary>
		public string HPATNAM
		{
			get { return hPATNAM; }
			set { hPATNAM = value; }
		}

		/// <summary>
		/// Gets or sets the HAGE value.
		/// </summary>
		public float HAGE
		{
			get { return hAGE; }
			set { hAGE = value; }
		}

		/// <summary>
		/// Gets or sets the HSEX value.
		/// </summary>
		public string HSEX
		{
			get { return hSEX; }
			set { hSEX = value; }
		}

		/// <summary>
		/// Gets or sets the HREFDOC value.
		/// </summary>
		public string HREFDOC
		{
			get { return hREFDOC; }
			set { hREFDOC = value; }
		}

		/// <summary>
		/// Gets or sets the DNAME value.
		/// </summary>
		public string DNAME
		{
			get { return dNAME; }
			set { dNAME = value; }
		}

		/// <summary>
		/// Gets or sets the TDEPT value.
		/// </summary>
		public string TDEPT
		{
			get { return tDEPT; }
			set { tDEPT = value; }
		}

		/// <summary>
		/// Gets or sets the MetrolabCode value.
		/// </summary>
		public string MetrolabCode
		{
			get { return metrolabCode; }
			set { metrolabCode = value; }
		}

		/// <summary>
		/// Gets or sets the EDOSCODE value.
		/// </summary>
		public string EDOSCODE
		{
			get { return eDOSCODE; }
			set { eDOSCODE = value; }
		}

		/// <summary>
		/// Gets or sets the DTDESC value.
		/// </summary>
		public string DTDESC
		{
			get { return dTDESC; }
			set { dTDESC = value; }
		}

		/// <summary>
		/// Gets or sets the HCOLCD value.
		/// </summary>
		public string HCOLCD
		{
			get { return hCOLCD; }
			set { hCOLCD = value; }
		}

		/// <summary>
		/// Gets or sets the CLNAME value.
		/// </summary>
		public string CLNAME
		{
			get { return cLNAME; }
			set { cLNAME = value; }
		}

		/// <summary>
		/// Gets or sets the HCOLLDATE value.
		/// </summary>
		public string HCOLLDATE
		{
			get { return hCOLLDATE; }
			set { hCOLLDATE = value; }
		}

		/// <summary>
		/// Gets or sets the HCOLLTIME value.
		/// </summary>
		public string HCOLLTIME
		{
			get { return hCOLLTIME; }
			set { hCOLLTIME = value; }
		}


		#endregion
}
}
