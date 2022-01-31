using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MLTESMAS
	{
		#region Fields

		private string tCODE=String.Empty;
		private string tNAME=String.Empty;
		private string tRESNAME=String.Empty;
		private string tDEPT=String.Empty;
		private string tWRKSHT=String.Empty;
		private string tRESVAL=String.Empty;
		private string tPOSVAL=String.Empty;
		private string tDEFVAL=String.Empty;
		private decimal tCHARGES=Decimal.Zero;
		private decimal tCOMM=Decimal.Zero;
		private string tUNIT=String.Empty;
		private string tSMSYN=String.Empty;
		private decimal tCRITICALVAL=Decimal.Zero;
		private string tCRITICALLESSYN=String.Empty;
		private string tREVENUECONSIDERATIONYN=String.Empty;
		private string tSEX=String.Empty;
		private int tREPDAY=0;
		private string tINHOUSE=String.Empty;
		private string tCOLMET=String.Empty;
		private string tGROUP=String.Empty;
		private string tMON=String.Empty;
		private string tTUES=String.Empty;
		private string tWED=String.Empty;
		private string tTHUS=String.Empty;
		private string tFRI=String.Empty;
		private string tSAT=String.Empty;
		private string tDAILY=String.Empty;
		private string tWEEKLY=String.Empty;
		private string tMONTHLY=String.Empty;
		private string tBWEEK=String.Empty;
		private short tDYOFMON=0;
		private decimal tCUTOFF=Decimal.Zero;
		private decimal tTDUR=Decimal.Zero;
		private string tAMPM=String.Empty;
		private decimal tCHARG1=Decimal.Zero;
		private decimal tCHARG2=Decimal.Zero;
		private string tIND=String.Empty;
		private string tLOC=String.Empty;
		private string tMETHOD=String.Empty;
		private string tSPL=String.Empty;
		private string tFORMAT=String.Empty;
		private string tPOP=String.Empty;
		private short tDECIMAL=0;
		private string tMULTI=String.Empty;
		private string tNORMAL=String.Empty;
		private string tLMPMOVE=String.Empty;
		private decimal tSTATIME=Decimal.Zero;
		private string tSTAMPM=String.Empty;
		private decimal tOUTSTA=Decimal.Zero;
		private string tHEALTH=String.Empty;
		private string tACTIVE=String.Empty;
		private string tSAMPLEYN=String.Empty;
		private string tWORKLOADYN=String.Empty;
		private string tINTERFACEDYN=String.Empty;
		private string tIVFTEST=String.Empty;
		private string tBOOKNO=String.Empty;
		private string tSCTCODE=String.Empty;
		private decimal tLOWVAL=Decimal.Zero;
		private decimal tHIGHVAL=Decimal.Zero;
		private string tNONFEED=String.Empty;
		private string uSRLOCK=String.Empty;
		private string tLOGIN=String.Empty;
		private DateTime tDATE=DateTime.MaxValue;
		private string tSERVICETAXYN=String.Empty;
		private decimal tDIRECTPATIENTMRP=Decimal.Zero;
		private string oLDTSCTCODE=String.Empty;
		private string mMDOSCODE=String.Empty;
		private string tQUALIFICATIONCODE=String.Empty;
		private string tPARTOFSUMMARYYN=String.Empty;
		private string tSUBQUALIFICATIONCODE=String.Empty;
		private string tFASTTRACK=String.Empty;
		private string tEXTNORYN=String.Empty;
		private string tTRAILEDRESVALYN=String.Empty;

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
		/// Gets or sets the TNAME value.
		/// </summary>
		public string TNAME
		{
			get { return tNAME; }
			set { tNAME = value; }
		}

		/// <summary>
		/// Gets or sets the TRESNAME value.
		/// </summary>
		public string TRESNAME
		{
			get { return tRESNAME; }
			set { tRESNAME = value; }
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
		/// Gets or sets the TWRKSHT value.
		/// </summary>
		public string TWRKSHT
		{
			get { return tWRKSHT; }
			set { tWRKSHT = value; }
		}

		/// <summary>
		/// Gets or sets the TRESVAL value.
		/// </summary>
		public string TRESVAL
		{
			get { return tRESVAL; }
			set { tRESVAL = value; }
		}

		/// <summary>
		/// Gets or sets the TPOSVAL value.
		/// </summary>
		public string TPOSVAL
		{
			get { return tPOSVAL; }
			set { tPOSVAL = value; }
		}

		/// <summary>
		/// Gets or sets the TDEFVAL value.
		/// </summary>
		public string TDEFVAL
		{
			get { return tDEFVAL; }
			set { tDEFVAL = value; }
		}

		/// <summary>
		/// Gets or sets the TCHARGES value.
		/// </summary>
		public decimal TCHARGES
		{
			get { return tCHARGES; }
			set { tCHARGES = value; }
		}

		/// <summary>
		/// Gets or sets the TCOMM value.
		/// </summary>
		public decimal TCOMM
		{
			get { return tCOMM; }
			set { tCOMM = value; }
		}

		/// <summary>
		/// Gets or sets the TUNIT value.
		/// </summary>
		public string TUNIT
		{
			get { return tUNIT; }
			set { tUNIT = value; }
		}

		/// <summary>
		/// Gets or sets the TSMSYN value.
		/// </summary>
		public string TSMSYN
		{
			get { return tSMSYN; }
			set { tSMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the TCRITICALVAL value.
		/// </summary>
		public decimal TCRITICALVAL
		{
			get { return tCRITICALVAL; }
			set { tCRITICALVAL = value; }
		}

		/// <summary>
		/// Gets or sets the TCRITICALLESSYN value.
		/// </summary>
		public string TCRITICALLESSYN
		{
			get { return tCRITICALLESSYN; }
			set { tCRITICALLESSYN = value; }
		}

		/// <summary>
		/// Gets or sets the TREVENUECONSIDERATIONYN value.
		/// </summary>
		public string TREVENUECONSIDERATIONYN
		{
			get { return tREVENUECONSIDERATIONYN; }
			set { tREVENUECONSIDERATIONYN = value; }
		}

		/// <summary>
		/// Gets or sets the TSEX value.
		/// </summary>
		public string TSEX
		{
			get { return tSEX; }
			set { tSEX = value; }
		}

		/// <summary>
		/// Gets or sets the TREPDAY value.
		/// </summary>
		public int TREPDAY
		{
			get { return tREPDAY; }
			set { tREPDAY = value; }
		}

		/// <summary>
		/// Gets or sets the TINHOUSE value.
		/// </summary>
		public string TINHOUSE
		{
			get { return tINHOUSE; }
			set { tINHOUSE = value; }
		}

		/// <summary>
		/// Gets or sets the TCOLMET value.
		/// </summary>
		public string TCOLMET
		{
			get { return tCOLMET; }
			set { tCOLMET = value; }
		}

		/// <summary>
		/// Gets or sets the TGROUP value.
		/// </summary>
		public string TGROUP
		{
			get { return tGROUP; }
			set { tGROUP = value; }
		}

		/// <summary>
		/// Gets or sets the TMON value.
		/// </summary>
		public string TMON
		{
			get { return tMON; }
			set { tMON = value; }
		}

		/// <summary>
		/// Gets or sets the TTUES value.
		/// </summary>
		public string TTUES
		{
			get { return tTUES; }
			set { tTUES = value; }
		}

		/// <summary>
		/// Gets or sets the TWED value.
		/// </summary>
		public string TWED
		{
			get { return tWED; }
			set { tWED = value; }
		}

		/// <summary>
		/// Gets or sets the TTHUS value.
		/// </summary>
		public string TTHUS
		{
			get { return tTHUS; }
			set { tTHUS = value; }
		}

		/// <summary>
		/// Gets or sets the TFRI value.
		/// </summary>
		public string TFRI
		{
			get { return tFRI; }
			set { tFRI = value; }
		}

		/// <summary>
		/// Gets or sets the TSAT value.
		/// </summary>
		public string TSAT
		{
			get { return tSAT; }
			set { tSAT = value; }
		}

		/// <summary>
		/// Gets or sets the TDAILY value.
		/// </summary>
		public string TDAILY
		{
			get { return tDAILY; }
			set { tDAILY = value; }
		}

		/// <summary>
		/// Gets or sets the TWEEKLY value.
		/// </summary>
		public string TWEEKLY
		{
			get { return tWEEKLY; }
			set { tWEEKLY = value; }
		}

		/// <summary>
		/// Gets or sets the TMONTHLY value.
		/// </summary>
		public string TMONTHLY
		{
			get { return tMONTHLY; }
			set { tMONTHLY = value; }
		}

		/// <summary>
		/// Gets or sets the TBWEEK value.
		/// </summary>
		public string TBWEEK
		{
			get { return tBWEEK; }
			set { tBWEEK = value; }
		}

		/// <summary>
		/// Gets or sets the TDYOFMON value.
		/// </summary>
		public short TDYOFMON
		{
			get { return tDYOFMON; }
			set { tDYOFMON = value; }
		}

		/// <summary>
		/// Gets or sets the TCUTOFF value.
		/// </summary>
		public decimal TCUTOFF
		{
			get { return tCUTOFF; }
			set { tCUTOFF = value; }
		}

		/// <summary>
		/// Gets or sets the TTDUR value.
		/// </summary>
		public decimal TTDUR
		{
			get { return tTDUR; }
			set { tTDUR = value; }
		}

		/// <summary>
		/// Gets or sets the TAMPM value.
		/// </summary>
		public string TAMPM
		{
			get { return tAMPM; }
			set { tAMPM = value; }
		}

		/// <summary>
		/// Gets or sets the TCHARG1 value.
		/// </summary>
		public decimal TCHARG1
		{
			get { return tCHARG1; }
			set { tCHARG1 = value; }
		}

		/// <summary>
		/// Gets or sets the TCHARG2 value.
		/// </summary>
		public decimal TCHARG2
		{
			get { return tCHARG2; }
			set { tCHARG2 = value; }
		}

		/// <summary>
		/// Gets or sets the TIND value.
		/// </summary>
		public string TIND
		{
			get { return tIND; }
			set { tIND = value; }
		}

		/// <summary>
		/// Gets or sets the TLOC value.
		/// </summary>
		public string TLOC
		{
			get { return tLOC; }
			set { tLOC = value; }
		}

		/// <summary>
		/// Gets or sets the TMETHOD value.
		/// </summary>
		public string TMETHOD
		{
			get { return tMETHOD; }
			set { tMETHOD = value; }
		}

		/// <summary>
		/// Gets or sets the TSPL value.
		/// </summary>
		public string TSPL
		{
			get { return tSPL; }
			set { tSPL = value; }
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
		/// Gets or sets the TPOP value.
		/// </summary>
		public string TPOP
		{
			get { return tPOP; }
			set { tPOP = value; }
		}

		/// <summary>
		/// Gets or sets the TDECIMAL value.
		/// </summary>
		public short TDECIMAL
		{
			get { return tDECIMAL; }
			set { tDECIMAL = value; }
		}

		/// <summary>
		/// Gets or sets the TMULTI value.
		/// </summary>
		public string TMULTI
		{
			get { return tMULTI; }
			set { tMULTI = value; }
		}

		/// <summary>
		/// Gets or sets the TNORMAL value.
		/// </summary>
		public string TNORMAL
		{
			get { return tNORMAL; }
			set { tNORMAL = value; }
		}

		/// <summary>
		/// Gets or sets the TLMPMOVE value.
		/// </summary>
		public string TLMPMOVE
		{
			get { return tLMPMOVE; }
			set { tLMPMOVE = value; }
		}

		/// <summary>
		/// Gets or sets the TSTATIME value.
		/// </summary>
		public decimal TSTATIME
		{
			get { return tSTATIME; }
			set { tSTATIME = value; }
		}

		/// <summary>
		/// Gets or sets the TSTAMPM value.
		/// </summary>
		public string TSTAMPM
		{
			get { return tSTAMPM; }
			set { tSTAMPM = value; }
		}

		/// <summary>
		/// Gets or sets the TOUTSTA value.
		/// </summary>
		public decimal TOUTSTA
		{
			get { return tOUTSTA; }
			set { tOUTSTA = value; }
		}

		/// <summary>
		/// Gets or sets the THEALTH value.
		/// </summary>
		public string THEALTH
		{
			get { return tHEALTH; }
			set { tHEALTH = value; }
		}

		/// <summary>
		/// Gets or sets the TACTIVE value.
		/// </summary>
		public string TACTIVE
		{
			get { return tACTIVE; }
			set { tACTIVE = value; }
		}

		/// <summary>
		/// Gets or sets the TSAMPLEYN value.
		/// </summary>
		public string TSAMPLEYN
		{
			get { return tSAMPLEYN; }
			set { tSAMPLEYN = value; }
		}

		/// <summary>
		/// Gets or sets the TWORKLOADYN value.
		/// </summary>
		public string TWORKLOADYN
		{
			get { return tWORKLOADYN; }
			set { tWORKLOADYN = value; }
		}

		/// <summary>
		/// Gets or sets the TINTERFACEDYN value.
		/// </summary>
		public string TINTERFACEDYN
		{
			get { return tINTERFACEDYN; }
			set { tINTERFACEDYN = value; }
		}

		/// <summary>
		/// Gets or sets the TIVFTEST value.
		/// </summary>
		public string TIVFTEST
		{
			get { return tIVFTEST; }
			set { tIVFTEST = value; }
		}

		/// <summary>
		/// Gets or sets the TBOOKNO value.
		/// </summary>
		public string TBOOKNO
		{
			get { return tBOOKNO; }
			set { tBOOKNO = value; }
		}

		/// <summary>
		/// Gets or sets the TSCTCODE value.
		/// </summary>
		public string TSCTCODE
		{
			get { return tSCTCODE; }
			set { tSCTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TLOWVAL value.
		/// </summary>
		public decimal TLOWVAL
		{
			get { return tLOWVAL; }
			set { tLOWVAL = value; }
		}

		/// <summary>
		/// Gets or sets the THIGHVAL value.
		/// </summary>
		public decimal THIGHVAL
		{
			get { return tHIGHVAL; }
			set { tHIGHVAL = value; }
		}

		/// <summary>
		/// Gets or sets the TNONFEED value.
		/// </summary>
		public string TNONFEED
		{
			get { return tNONFEED; }
			set { tNONFEED = value; }
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
		/// Gets or sets the TLOGIN value.
		/// </summary>
		public string TLOGIN
		{
			get { return tLOGIN; }
			set { tLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the TDATE value.
		/// </summary>
		public DateTime TDATE
		{
			get { return tDATE; }
			set { tDATE = value; }
		}

		/// <summary>
		/// Gets or sets the TSERVICETAXYN value.
		/// </summary>
		public string TSERVICETAXYN
		{
			get { return tSERVICETAXYN; }
			set { tSERVICETAXYN = value; }
		}

		/// <summary>
		/// Gets or sets the TDIRECTPATIENTMRP value.
		/// </summary>
		public decimal TDIRECTPATIENTMRP
		{
			get { return tDIRECTPATIENTMRP; }
			set { tDIRECTPATIENTMRP = value; }
		}

		/// <summary>
		/// Gets or sets the OLDTSCTCODE value.
		/// </summary>
		public string OLDTSCTCODE
		{
			get { return oLDTSCTCODE; }
			set { oLDTSCTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the MMDOSCODE value.
		/// </summary>
		public string MMDOSCODE
		{
			get { return mMDOSCODE; }
			set { mMDOSCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TQUALIFICATIONCODE value.
		/// </summary>
		public string TQUALIFICATIONCODE
		{
			get { return tQUALIFICATIONCODE; }
			set { tQUALIFICATIONCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TPARTOFSUMMARYYN value.
		/// </summary>
		public string TPARTOFSUMMARYYN
		{
			get { return tPARTOFSUMMARYYN; }
			set { tPARTOFSUMMARYYN = value; }
		}

		/// <summary>
		/// Gets or sets the TSUBQUALIFICATIONCODE value.
		/// </summary>
		public string TSUBQUALIFICATIONCODE
		{
			get { return tSUBQUALIFICATIONCODE; }
			set { tSUBQUALIFICATIONCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TFASTTRACK value.
		/// </summary>
		public string TFASTTRACK
		{
			get { return tFASTTRACK; }
			set { tFASTTRACK = value; }
		}

		/// <summary>
		/// Gets or sets the TEXTNORYN value.
		/// </summary>
		public string TEXTNORYN
		{
			get { return tEXTNORYN; }
			set { tEXTNORYN = value; }
		}

		/// <summary>
		/// Gets or sets the TTRAILEDRESVALYN value.
		/// </summary>
		public string TTRAILEDRESVALYN
		{
			get { return tTRAILEDRESVALYN; }
			set { tTRAILEDRESVALYN = value; }
		}


		#endregion
}
}
