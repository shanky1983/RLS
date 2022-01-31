using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MIS_NEWTECHDOS
	{
		#region Fields

		private string tcode=String.Empty;
		private string dEPT=String.Empty;
		private string sECTION=String.Empty;
		private string mETHOD=String.Empty;
		private string aMBIENT25C=String.Empty;
		private string r28C=String.Empty;
		private string f20C=String.Empty;
		private string shippingtemp=String.Empty;
		private string aNALYTEDESCRIPTIONPREREQUESITES=String.Empty;
		private string qUANTITY=String.Empty;
		private string testschedule=String.Empty;
		private string reportedon=String.Empty;
		private string mLTCODE=String.Empty;
		private string mLTTYPE=String.Empty;
		private int mLTCHILDS=0;
		private int mLCCHILDS=0;
		private int mLCTCHILDS=0;
		private string mLTNAME=String.Empty;
		private string sAMPLETYPE=String.Empty;
		private string tNAME1=String.Empty;
		private string tNAME2=String.Empty;
		private string tNAME3=String.Empty;
		private string sampleContainer=String.Empty;
		private string uOM=String.Empty;
		private string aBBRIVATION=String.Empty;
		private DateTime lOD=DateTime.MaxValue;
		private int nOSAMPLES=0;
		private string cATEGORY=String.Empty;
		private decimal latestSID=Decimal.Zero;
		private string tFORMAT=String.Empty;
		private string tATTYPE=String.Empty;
		private string tATTECH=String.Empty;
		private int sRNO=0;
		private string oST=String.Empty;
		private string oCN=String.Empty;
		private string pCTS=String.Empty;
		private string mACHNE=String.Empty;
		private int tATHOURS=0;
		private string rB=String.Empty;
		private int nOOFCHILDS=0;
		private DateTime lIVEDATE=DateTime.MaxValue;
		private int iSGREENFIELD=0;
		private int nSRNO=0;
		private string isOrderable=String.Empty;

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
		/// Gets or sets the METHOD value.
		/// </summary>
		public string METHOD
		{
			get { return mETHOD; }
			set { mETHOD = value; }
		}

		/// <summary>
		/// Gets or sets the AMBIENT25C value.
		/// </summary>
		public string AMBIENT25C
		{
			get { return aMBIENT25C; }
			set { aMBIENT25C = value; }
		}

		/// <summary>
		/// Gets or sets the R28C value.
		/// </summary>
		public string R28C
		{
			get { return r28C; }
			set { r28C = value; }
		}

		/// <summary>
		/// Gets or sets the F20C value.
		/// </summary>
		public string F20C
		{
			get { return f20C; }
			set { f20C = value; }
		}

		/// <summary>
		/// Gets or sets the Shippingtemp value.
		/// </summary>
		public string Shippingtemp
		{
			get { return shippingtemp; }
			set { shippingtemp = value; }
		}

		/// <summary>
		/// Gets or sets the ANALYTEDESCRIPTIONPREREQUESITES value.
		/// </summary>
		public string ANALYTEDESCRIPTIONPREREQUESITES
		{
			get { return aNALYTEDESCRIPTIONPREREQUESITES; }
			set { aNALYTEDESCRIPTIONPREREQUESITES = value; }
		}

		/// <summary>
		/// Gets or sets the QUANTITY value.
		/// </summary>
		public string QUANTITY
		{
			get { return qUANTITY; }
			set { qUANTITY = value; }
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
		/// Gets or sets the MLTCODE value.
		/// </summary>
		public string MLTCODE
		{
			get { return mLTCODE; }
			set { mLTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the MLTTYPE value.
		/// </summary>
		public string MLTTYPE
		{
			get { return mLTTYPE; }
			set { mLTTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the MLTCHILDS value.
		/// </summary>
		public int MLTCHILDS
		{
			get { return mLTCHILDS; }
			set { mLTCHILDS = value; }
		}

		/// <summary>
		/// Gets or sets the MLCCHILDS value.
		/// </summary>
		public int MLCCHILDS
		{
			get { return mLCCHILDS; }
			set { mLCCHILDS = value; }
		}

		/// <summary>
		/// Gets or sets the MLCTCHILDS value.
		/// </summary>
		public int MLCTCHILDS
		{
			get { return mLCTCHILDS; }
			set { mLCTCHILDS = value; }
		}

		/// <summary>
		/// Gets or sets the MLTNAME value.
		/// </summary>
		public string MLTNAME
		{
			get { return mLTNAME; }
			set { mLTNAME = value; }
		}

		/// <summary>
		/// Gets or sets the SAMPLETYPE value.
		/// </summary>
		public string SAMPLETYPE
		{
			get { return sAMPLETYPE; }
			set { sAMPLETYPE = value; }
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
		/// Gets or sets the UOM value.
		/// </summary>
		public string UOM
		{
			get { return uOM; }
			set { uOM = value; }
		}

		/// <summary>
		/// Gets or sets the ABBRIVATION value.
		/// </summary>
		public string ABBRIVATION
		{
			get { return aBBRIVATION; }
			set { aBBRIVATION = value; }
		}

		/// <summary>
		/// Gets or sets the LOD value.
		/// </summary>
		public DateTime LOD
		{
			get { return lOD; }
			set { lOD = value; }
		}

		/// <summary>
		/// Gets or sets the NOSAMPLES value.
		/// </summary>
		public int NOSAMPLES
		{
			get { return nOSAMPLES; }
			set { nOSAMPLES = value; }
		}

		/// <summary>
		/// Gets or sets the CATEGORY value.
		/// </summary>
		public string CATEGORY
		{
			get { return cATEGORY; }
			set { cATEGORY = value; }
		}

		/// <summary>
		/// Gets or sets the LatestSID value.
		/// </summary>
		public decimal LatestSID
		{
			get { return latestSID; }
			set { latestSID = value; }
		}

		/// <summary>
		/// Gets or sets the TFORMAT value.
		/// </summary>
		public string TFORMAT
		{
			get { return tFORMAT; }
			set { tFORMAT = value; }
		}

		/// <summary>
		/// Gets or sets the TATTYPE value.
		/// </summary>
		public string TATTYPE
		{
			get { return tATTYPE; }
			set { tATTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the TATTECH value.
		/// </summary>
		public string TATTECH
		{
			get { return tATTECH; }
			set { tATTECH = value; }
		}

		/// <summary>
		/// Gets or sets the SRNO value.
		/// </summary>
		public int SRNO
		{
			get { return sRNO; }
			set { sRNO = value; }
		}

		/// <summary>
		/// Gets or sets the OST value.
		/// </summary>
		public string OST
		{
			get { return oST; }
			set { oST = value; }
		}

		/// <summary>
		/// Gets or sets the OCN value.
		/// </summary>
		public string OCN
		{
			get { return oCN; }
			set { oCN = value; }
		}

		/// <summary>
		/// Gets or sets the PCTS value.
		/// </summary>
		public string PCTS
		{
			get { return pCTS; }
			set { pCTS = value; }
		}

		/// <summary>
		/// Gets or sets the MACHNE value.
		/// </summary>
		public string MACHNE
		{
			get { return mACHNE; }
			set { mACHNE = value; }
		}

		/// <summary>
		/// Gets or sets the TATHOURS value.
		/// </summary>
		public int TATHOURS
		{
			get { return tATHOURS; }
			set { tATHOURS = value; }
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
		/// Gets or sets the NOOFCHILDS value.
		/// </summary>
		public int NOOFCHILDS
		{
			get { return nOOFCHILDS; }
			set { nOOFCHILDS = value; }
		}

		/// <summary>
		/// Gets or sets the LIVEDATE value.
		/// </summary>
		public DateTime LIVEDATE
		{
			get { return lIVEDATE; }
			set { lIVEDATE = value; }
		}

		/// <summary>
		/// Gets or sets the ISGREENFIELD value.
		/// </summary>
		public int ISGREENFIELD
		{
			get { return iSGREENFIELD; }
			set { iSGREENFIELD = value; }
		}

		/// <summary>
		/// Gets or sets the NSRNO value.
		/// </summary>
		public int NSRNO
		{
			get { return nSRNO; }
			set { nSRNO = value; }
		}

		/// <summary>
		/// Gets or sets the IsOrderable value.
		/// </summary>
		public string IsOrderable
		{
			get { return isOrderable; }
			set { isOrderable = value; }
		}


		#endregion
}
}
