using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AHD_MLCOLMAS
	{
		#region Fields

		private string cLCODE=String.Empty;
		private string cLNAME=String.Empty;
		private string cLADD1=String.Empty;
		private string cLADD2=String.Empty;
		private string cLADD3=String.Empty;
		private string cLSTATE=String.Empty;
		private string cLCITY=String.Empty;
		private string cLFAX=String.Empty;
		private string cLPIN=String.Empty;
		private string cLTELE=String.Empty;
		private string cLEMAIL=String.Empty;
		private string cLPATHO=String.Empty;
		private string cLPATHOTEL=String.Empty;
		private string cLCOPER=String.Empty;
		private decimal cLCOMM=Decimal.Zero;
		private int cLCOMAMT=0;
		private string cLZONE=String.Empty;
		private string cLMAIN=String.Empty;
		private string cLWORHRS=String.Empty;
		private decimal cLTHRELMT=Decimal.Zero;
		private short cLROUT=0;
		private string cLRECYN=String.Empty;
		private string cLFREN=String.Empty;
		private string cLOUTSTA=String.Empty;
		private string cLAREA=String.Empty;
		private string cLACTIVE=String.Empty;
		private string cLSALCODE=String.Empty;
		private string cLRATEUPDATEYN=String.Empty;
		private string cLBILLYN=String.Empty;
		private string cLREVTYPE=String.Empty;
		private string cLBRANCH=String.Empty;
		private string uSRLOCK=String.Empty;
		private string cLLOGIN=String.Empty;
		private DateTime cLDATE=DateTime.MaxValue;
		private string cLHTMLYN=String.Empty;
		private string cLREGISMSYN=String.Empty;
		private string cLBILLSMSYN=String.Empty;
		private string cLREPSMSYN=String.Empty;
		private string cLMOBNO=String.Empty;
		private string cLMOBNO2=String.Empty;
		private string cLRPTEMAILYN=String.Empty;
		private string cLHEADERLOGOYN=String.Empty;
		private string cLSTATIONARYTYPECD=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CLCODE value.
		/// </summary>
		public string CLCODE
		{
			get { return cLCODE; }
			set { cLCODE = value; }
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
		/// Gets or sets the CLADD1 value.
		/// </summary>
		public string CLADD1
		{
			get { return cLADD1; }
			set { cLADD1 = value; }
		}

		/// <summary>
		/// Gets or sets the CLADD2 value.
		/// </summary>
		public string CLADD2
		{
			get { return cLADD2; }
			set { cLADD2 = value; }
		}

		/// <summary>
		/// Gets or sets the CLADD3 value.
		/// </summary>
		public string CLADD3
		{
			get { return cLADD3; }
			set { cLADD3 = value; }
		}

		/// <summary>
		/// Gets or sets the CLSTATE value.
		/// </summary>
		public string CLSTATE
		{
			get { return cLSTATE; }
			set { cLSTATE = value; }
		}

		/// <summary>
		/// Gets or sets the CLCITY value.
		/// </summary>
		public string CLCITY
		{
			get { return cLCITY; }
			set { cLCITY = value; }
		}

		/// <summary>
		/// Gets or sets the CLFAX value.
		/// </summary>
		public string CLFAX
		{
			get { return cLFAX; }
			set { cLFAX = value; }
		}

		/// <summary>
		/// Gets or sets the CLPIN value.
		/// </summary>
		public string CLPIN
		{
			get { return cLPIN; }
			set { cLPIN = value; }
		}

		/// <summary>
		/// Gets or sets the CLTELE value.
		/// </summary>
		public string CLTELE
		{
			get { return cLTELE; }
			set { cLTELE = value; }
		}

		/// <summary>
		/// Gets or sets the CLEMAIL value.
		/// </summary>
		public string CLEMAIL
		{
			get { return cLEMAIL; }
			set { cLEMAIL = value; }
		}

		/// <summary>
		/// Gets or sets the CLPATHO value.
		/// </summary>
		public string CLPATHO
		{
			get { return cLPATHO; }
			set { cLPATHO = value; }
		}

		/// <summary>
		/// Gets or sets the CLPATHOTEL value.
		/// </summary>
		public string CLPATHOTEL
		{
			get { return cLPATHOTEL; }
			set { cLPATHOTEL = value; }
		}

		/// <summary>
		/// Gets or sets the CLCOPER value.
		/// </summary>
		public string CLCOPER
		{
			get { return cLCOPER; }
			set { cLCOPER = value; }
		}

		/// <summary>
		/// Gets or sets the CLCOMM value.
		/// </summary>
		public decimal CLCOMM
		{
			get { return cLCOMM; }
			set { cLCOMM = value; }
		}

		/// <summary>
		/// Gets or sets the CLCOMAMT value.
		/// </summary>
		public int CLCOMAMT
		{
			get { return cLCOMAMT; }
			set { cLCOMAMT = value; }
		}

		/// <summary>
		/// Gets or sets the CLZONE value.
		/// </summary>
		public string CLZONE
		{
			get { return cLZONE; }
			set { cLZONE = value; }
		}

		/// <summary>
		/// Gets or sets the CLMAIN value.
		/// </summary>
		public string CLMAIN
		{
			get { return cLMAIN; }
			set { cLMAIN = value; }
		}

		/// <summary>
		/// Gets or sets the CLWORHRS value.
		/// </summary>
		public string CLWORHRS
		{
			get { return cLWORHRS; }
			set { cLWORHRS = value; }
		}

		/// <summary>
		/// Gets or sets the CLTHRELMT value.
		/// </summary>
		public decimal CLTHRELMT
		{
			get { return cLTHRELMT; }
			set { cLTHRELMT = value; }
		}

		/// <summary>
		/// Gets or sets the CLROUT value.
		/// </summary>
		public short CLROUT
		{
			get { return cLROUT; }
			set { cLROUT = value; }
		}

		/// <summary>
		/// Gets or sets the CLRECYN value.
		/// </summary>
		public string CLRECYN
		{
			get { return cLRECYN; }
			set { cLRECYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLFREN value.
		/// </summary>
		public string CLFREN
		{
			get { return cLFREN; }
			set { cLFREN = value; }
		}

		/// <summary>
		/// Gets or sets the CLOUTSTA value.
		/// </summary>
		public string CLOUTSTA
		{
			get { return cLOUTSTA; }
			set { cLOUTSTA = value; }
		}

		/// <summary>
		/// Gets or sets the CLAREA value.
		/// </summary>
		public string CLAREA
		{
			get { return cLAREA; }
			set { cLAREA = value; }
		}

		/// <summary>
		/// Gets or sets the CLACTIVE value.
		/// </summary>
		public string CLACTIVE
		{
			get { return cLACTIVE; }
			set { cLACTIVE = value; }
		}

		/// <summary>
		/// Gets or sets the CLSALCODE value.
		/// </summary>
		public string CLSALCODE
		{
			get { return cLSALCODE; }
			set { cLSALCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CLRATEUPDATEYN value.
		/// </summary>
		public string CLRATEUPDATEYN
		{
			get { return cLRATEUPDATEYN; }
			set { cLRATEUPDATEYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLBILLYN value.
		/// </summary>
		public string CLBILLYN
		{
			get { return cLBILLYN; }
			set { cLBILLYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLREVTYPE value.
		/// </summary>
		public string CLREVTYPE
		{
			get { return cLREVTYPE; }
			set { cLREVTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the CLBRANCH value.
		/// </summary>
		public string CLBRANCH
		{
			get { return cLBRANCH; }
			set { cLBRANCH = value; }
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
		/// Gets or sets the CLLOGIN value.
		/// </summary>
		public string CLLOGIN
		{
			get { return cLLOGIN; }
			set { cLLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the CLDATE value.
		/// </summary>
		public DateTime CLDATE
		{
			get { return cLDATE; }
			set { cLDATE = value; }
		}

		/// <summary>
		/// Gets or sets the CLHTMLYN value.
		/// </summary>
		public string CLHTMLYN
		{
			get { return cLHTMLYN; }
			set { cLHTMLYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLREGISMSYN value.
		/// </summary>
		public string CLREGISMSYN
		{
			get { return cLREGISMSYN; }
			set { cLREGISMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLBILLSMSYN value.
		/// </summary>
		public string CLBILLSMSYN
		{
			get { return cLBILLSMSYN; }
			set { cLBILLSMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLREPSMSYN value.
		/// </summary>
		public string CLREPSMSYN
		{
			get { return cLREPSMSYN; }
			set { cLREPSMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLMOBNO value.
		/// </summary>
		public string CLMOBNO
		{
			get { return cLMOBNO; }
			set { cLMOBNO = value; }
		}

		/// <summary>
		/// Gets or sets the CLMOBNO2 value.
		/// </summary>
		public string CLMOBNO2
		{
			get { return cLMOBNO2; }
			set { cLMOBNO2 = value; }
		}

		/// <summary>
		/// Gets or sets the CLRPTEMAILYN value.
		/// </summary>
		public string CLRPTEMAILYN
		{
			get { return cLRPTEMAILYN; }
			set { cLRPTEMAILYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLHEADERLOGOYN value.
		/// </summary>
		public string CLHEADERLOGOYN
		{
			get { return cLHEADERLOGOYN; }
			set { cLHEADERLOGOYN = value; }
		}

		/// <summary>
		/// Gets or sets the CLSTATIONARYTYPECD value.
		/// </summary>
		public string CLSTATIONARYTYPECD
		{
			get { return cLSTATIONARYTYPECD; }
			set { cLSTATIONARYTYPECD = value; }
		}


		#endregion
}
}
