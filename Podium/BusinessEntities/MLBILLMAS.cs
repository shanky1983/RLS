using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MLBILLMAS
	{
		#region Fields

		private string bCOMP=String.Empty;
		private string bDEPT=String.Empty;
		private string bCOLCD=String.Empty;
		private string bBILLNO=String.Empty;
		private DateTime bBILLDATE=DateTime.MaxValue;
		private decimal bTOTAMT=Decimal.Zero;
		private decimal bAMTPAID=Decimal.Zero;
		private decimal bBALAMT=Decimal.Zero;
		private decimal bCOMAMT=Decimal.Zero;
		private decimal bCOMPAID=Decimal.Zero;
		private decimal bCOMBAL=Decimal.Zero;
		private decimal bTURNOVERDISC=Decimal.Zero;
		private decimal bTDSAMOUNT=Decimal.Zero;
		private decimal bTESTDISCOUNT=Decimal.Zero;
		private decimal bNETAMOUNT=Decimal.Zero;
		private decimal bADJUSTMENT=Decimal.Zero;
		private string bTYPE=String.Empty;
		private string bDRCR=String.Empty;
		private string bREM1=String.Empty;
		private string bREM2=String.Empty;
		private string bREM3=String.Empty;
		private string bTURNDISYN=String.Empty;
		private string bVCHNO=String.Empty;
		private string bORGVCH=String.Empty;
		private string bORGVCHDT=String.Empty;
		private string bADVNO=String.Empty;
		private string bIND=String.Empty;
		private string bFALINK=String.Empty;
		private decimal bROUND=Decimal.Zero;
		private decimal bSERVICETAXAMT=Decimal.Zero;
		private decimal bCESSAMT=Decimal.Zero;
		private string uSRLOCK=String.Empty;
		private string bLOGIN=String.Empty;
		private DateTime bLDATE=DateTime.MaxValue;
		private decimal bHIGHEDUCESSAMT=Decimal.Zero;
		private string aTTUNEBILLNO=String.Empty;
		private decimal aTTUNEGROSS=Decimal.Zero;
		private decimal aTTUNECOLLCHG=Decimal.Zero;
		private decimal aTTUNENET=Decimal.Zero;
		private decimal aTTUNETOD=Decimal.Zero;
		private decimal aTTUNELESSTOD=Decimal.Zero;
		private decimal tOTALNET=Decimal.Zero;
		private decimal rEVISEDTOD=Decimal.Zero;
		private decimal tOTALLESSTOD=Decimal.Zero;
		private decimal tODDIFF=Decimal.Zero;
		private string tOPOST=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BCOMP value.
		/// </summary>
		public string BCOMP
		{
			get { return bCOMP; }
			set { bCOMP = value; }
		}

		/// <summary>
		/// Gets or sets the BDEPT value.
		/// </summary>
		public string BDEPT
		{
			get { return bDEPT; }
			set { bDEPT = value; }
		}

		/// <summary>
		/// Gets or sets the BCOLCD value.
		/// </summary>
		public string BCOLCD
		{
			get { return bCOLCD; }
			set { bCOLCD = value; }
		}

		/// <summary>
		/// Gets or sets the BBILLNO value.
		/// </summary>
		public string BBILLNO
		{
			get { return bBILLNO; }
			set { bBILLNO = value; }
		}

		/// <summary>
		/// Gets or sets the BBILLDATE value.
		/// </summary>
		public DateTime BBILLDATE
		{
			get { return bBILLDATE; }
			set { bBILLDATE = value; }
		}

		/// <summary>
		/// Gets or sets the BTOTAMT value.
		/// </summary>
		public decimal BTOTAMT
		{
			get { return bTOTAMT; }
			set { bTOTAMT = value; }
		}

		/// <summary>
		/// Gets or sets the BAMTPAID value.
		/// </summary>
		public decimal BAMTPAID
		{
			get { return bAMTPAID; }
			set { bAMTPAID = value; }
		}

		/// <summary>
		/// Gets or sets the BBALAMT value.
		/// </summary>
		public decimal BBALAMT
		{
			get { return bBALAMT; }
			set { bBALAMT = value; }
		}

		/// <summary>
		/// Gets or sets the BCOMAMT value.
		/// </summary>
		public decimal BCOMAMT
		{
			get { return bCOMAMT; }
			set { bCOMAMT = value; }
		}

		/// <summary>
		/// Gets or sets the BCOMPAID value.
		/// </summary>
		public decimal BCOMPAID
		{
			get { return bCOMPAID; }
			set { bCOMPAID = value; }
		}

		/// <summary>
		/// Gets or sets the BCOMBAL value.
		/// </summary>
		public decimal BCOMBAL
		{
			get { return bCOMBAL; }
			set { bCOMBAL = value; }
		}

		/// <summary>
		/// Gets or sets the BTURNOVERDISC value.
		/// </summary>
		public decimal BTURNOVERDISC
		{
			get { return bTURNOVERDISC; }
			set { bTURNOVERDISC = value; }
		}

		/// <summary>
		/// Gets or sets the BTDSAMOUNT value.
		/// </summary>
		public decimal BTDSAMOUNT
		{
			get { return bTDSAMOUNT; }
			set { bTDSAMOUNT = value; }
		}

		/// <summary>
		/// Gets or sets the BTESTDISCOUNT value.
		/// </summary>
		public decimal BTESTDISCOUNT
		{
			get { return bTESTDISCOUNT; }
			set { bTESTDISCOUNT = value; }
		}

		/// <summary>
		/// Gets or sets the BNETAMOUNT value.
		/// </summary>
		public decimal BNETAMOUNT
		{
			get { return bNETAMOUNT; }
			set { bNETAMOUNT = value; }
		}

		/// <summary>
		/// Gets or sets the BADJUSTMENT value.
		/// </summary>
		public decimal BADJUSTMENT
		{
			get { return bADJUSTMENT; }
			set { bADJUSTMENT = value; }
		}

		/// <summary>
		/// Gets or sets the BTYPE value.
		/// </summary>
		public string BTYPE
		{
			get { return bTYPE; }
			set { bTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the BDRCR value.
		/// </summary>
		public string BDRCR
		{
			get { return bDRCR; }
			set { bDRCR = value; }
		}

		/// <summary>
		/// Gets or sets the BREM1 value.
		/// </summary>
		public string BREM1
		{
			get { return bREM1; }
			set { bREM1 = value; }
		}

		/// <summary>
		/// Gets or sets the BREM2 value.
		/// </summary>
		public string BREM2
		{
			get { return bREM2; }
			set { bREM2 = value; }
		}

		/// <summary>
		/// Gets or sets the BREM3 value.
		/// </summary>
		public string BREM3
		{
			get { return bREM3; }
			set { bREM3 = value; }
		}

		/// <summary>
		/// Gets or sets the BTURNDISYN value.
		/// </summary>
		public string BTURNDISYN
		{
			get { return bTURNDISYN; }
			set { bTURNDISYN = value; }
		}

		/// <summary>
		/// Gets or sets the BVCHNO value.
		/// </summary>
		public string BVCHNO
		{
			get { return bVCHNO; }
			set { bVCHNO = value; }
		}

		/// <summary>
		/// Gets or sets the BORGVCH value.
		/// </summary>
		public string BORGVCH
		{
			get { return bORGVCH; }
			set { bORGVCH = value; }
		}

		/// <summary>
		/// Gets or sets the BORGVCHDT value.
		/// </summary>
		public string BORGVCHDT
		{
			get { return bORGVCHDT; }
			set { bORGVCHDT = value; }
		}

		/// <summary>
		/// Gets or sets the BADVNO value.
		/// </summary>
		public string BADVNO
		{
			get { return bADVNO; }
			set { bADVNO = value; }
		}

		/// <summary>
		/// Gets or sets the BIND value.
		/// </summary>
		public string BIND
		{
			get { return bIND; }
			set { bIND = value; }
		}

		/// <summary>
		/// Gets or sets the BFALINK value.
		/// </summary>
		public string BFALINK
		{
			get { return bFALINK; }
			set { bFALINK = value; }
		}

		/// <summary>
		/// Gets or sets the BROUND value.
		/// </summary>
		public decimal BROUND
		{
			get { return bROUND; }
			set { bROUND = value; }
		}

		/// <summary>
		/// Gets or sets the BSERVICETAXAMT value.
		/// </summary>
		public decimal BSERVICETAXAMT
		{
			get { return bSERVICETAXAMT; }
			set { bSERVICETAXAMT = value; }
		}

		/// <summary>
		/// Gets or sets the BCESSAMT value.
		/// </summary>
		public decimal BCESSAMT
		{
			get { return bCESSAMT; }
			set { bCESSAMT = value; }
		}

		/// <summary>
		/// Gets or sets the USRLOCK value.
		/// </summary>
		public string USRLOCK
		{
			get { return uSRLOCK; }
			set { uSRLOCK = value; }
		}

		/// <summary>
		/// Gets or sets the BLOGIN value.
		/// </summary>
		public string BLOGIN
		{
			get { return bLOGIN; }
			set { bLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the BLDATE value.
		/// </summary>
		public DateTime BLDATE
		{
			get { return bLDATE; }
			set { bLDATE = value; }
		}

		/// <summary>
		/// Gets or sets the BHIGHEDUCESSAMT value.
		/// </summary>
		public decimal BHIGHEDUCESSAMT
		{
			get { return bHIGHEDUCESSAMT; }
			set { bHIGHEDUCESSAMT = value; }
		}

		/// <summary>
		/// Gets or sets the ATTUNEBILLNO value.
		/// </summary>
		public string ATTUNEBILLNO
		{
			get { return aTTUNEBILLNO; }
			set { aTTUNEBILLNO = value; }
		}

		/// <summary>
		/// Gets or sets the ATTUNEGROSS value.
		/// </summary>
		public decimal ATTUNEGROSS
		{
			get { return aTTUNEGROSS; }
			set { aTTUNEGROSS = value; }
		}

		/// <summary>
		/// Gets or sets the ATTUNECOLLCHG value.
		/// </summary>
		public decimal ATTUNECOLLCHG
		{
			get { return aTTUNECOLLCHG; }
			set { aTTUNECOLLCHG = value; }
		}

		/// <summary>
		/// Gets or sets the ATTUNENET value.
		/// </summary>
		public decimal ATTUNENET
		{
			get { return aTTUNENET; }
			set { aTTUNENET = value; }
		}

		/// <summary>
		/// Gets or sets the ATTUNETOD value.
		/// </summary>
		public decimal ATTUNETOD
		{
			get { return aTTUNETOD; }
			set { aTTUNETOD = value; }
		}

		/// <summary>
		/// Gets or sets the ATTUNELESSTOD value.
		/// </summary>
		public decimal ATTUNELESSTOD
		{
			get { return aTTUNELESSTOD; }
			set { aTTUNELESSTOD = value; }
		}

		/// <summary>
		/// Gets or sets the TOTALNET value.
		/// </summary>
		public decimal TOTALNET
		{
			get { return tOTALNET; }
			set { tOTALNET = value; }
		}

		/// <summary>
		/// Gets or sets the REVISEDTOD value.
		/// </summary>
		public decimal REVISEDTOD
		{
			get { return rEVISEDTOD; }
			set { rEVISEDTOD = value; }
		}

		/// <summary>
		/// Gets or sets the TOTALLESSTOD value.
		/// </summary>
		public decimal TOTALLESSTOD
		{
			get { return tOTALLESSTOD; }
			set { tOTALLESSTOD = value; }
		}

		/// <summary>
		/// Gets or sets the TODDIFF value.
		/// </summary>
		public decimal TODDIFF
		{
			get { return tODDIFF; }
			set { tODDIFF = value; }
		}

		/// <summary>
		/// Gets or sets the TOPOST value.
		/// </summary>
		public string TOPOST
		{
			get { return tOPOST; }
			set { tOPOST = value; }
		}


		#endregion
}
}
