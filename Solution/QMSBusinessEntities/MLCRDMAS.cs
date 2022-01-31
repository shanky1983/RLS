using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MLCRDMAS
	{
		#region Fields

		private string cRCODE=String.Empty;
		private string cRNAME=String.Empty;
		private string cRADD1=String.Empty;
		private string cRADD2=String.Empty;
		private string cRADD3=String.Empty;
		private string cRCITY=String.Empty;
		private string cRPIN=String.Empty;
		private string cRFAX=String.Empty;
		private string cRTELE=String.Empty;
		private string cREMAIL=String.Empty;
		private string cRCONTPER=String.Empty;
		private string cRPATHO=String.Empty;
		private string cRPATHOTEL=String.Empty;
		private string cRREGISMSYN=String.Empty;
		private string cRBILLSMSYN=String.Empty;
		private string cRREPSMSYN=String.Empty;
		private string cRMOBNO=String.Empty;
		private string cRMOBNO2=String.Empty;
		private int cRDISPER=0;
		private decimal cRDISAMT=Decimal.Zero;
		private string cRZONE=String.Empty;
		private string cRWORHRS=String.Empty;
		private decimal cRTHRESLMT=Decimal.Zero;
		private short cRROUT=0;
		private string cRSUNYN=String.Empty;
		private string cRACTIVE=String.Empty;
		private string cRSALCODE=String.Empty;
		private string cRREVTYPE=String.Empty;
		private string cRSERVICETAX=String.Empty;
		private string uSRLOCK=String.Empty;
		private string cRLOGIN=String.Empty;
		private DateTime cRDATE=DateTime.MaxValue;
		private string cRCATEGORY=String.Empty;
		private string cRCLINICALTRIALYN=String.Empty;
		private string cRPROTOCOLNO=String.Empty;
		private string cRRPTEMAILYN=String.Empty;
		private string cRSPONSORYN=String.Empty;
		private string cRSPONSORCODE=String.Empty;
		private string cRPONO=String.Empty;
		private string cRREPORTFORMAT=String.Empty;
		private string cRTELE1=String.Empty;
		private string cRAUTHENTICATIONYN=String.Empty;
		private string cRSUMMARYRPTYN=String.Empty;
		private string cRBLINDRPTYN=String.Empty;
		private string cRLOGISTICYN=String.Empty;
		private string cREMAILJPGYN=String.Empty;
		private string oLDSAPCODE=String.Empty;
		private string nEWSAPCODE=String.Empty;
		private string cRACCOUNTGRPCD=String.Empty;
		private int cRTRANSTIME=0;
		private string cRTATPARATYPE=String.Empty;
		private string cRHEADERLOGOYN=String.Empty;
		private string cRSTATIONARYTYPECD=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CRCODE value.
		/// </summary>
		public string CRCODE
		{
			get { return cRCODE; }
			set { cRCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CRNAME value.
		/// </summary>
		public string CRNAME
		{
			get { return cRNAME; }
			set { cRNAME = value; }
		}

		/// <summary>
		/// Gets or sets the CRADD1 value.
		/// </summary>
		public string CRADD1
		{
			get { return cRADD1; }
			set { cRADD1 = value; }
		}

		/// <summary>
		/// Gets or sets the CRADD2 value.
		/// </summary>
		public string CRADD2
		{
			get { return cRADD2; }
			set { cRADD2 = value; }
		}

		/// <summary>
		/// Gets or sets the CRADD3 value.
		/// </summary>
		public string CRADD3
		{
			get { return cRADD3; }
			set { cRADD3 = value; }
		}

		/// <summary>
		/// Gets or sets the CRCITY value.
		/// </summary>
		public string CRCITY
		{
			get { return cRCITY; }
			set { cRCITY = value; }
		}

		/// <summary>
		/// Gets or sets the CRPIN value.
		/// </summary>
		public string CRPIN
		{
			get { return cRPIN; }
			set { cRPIN = value; }
		}

		/// <summary>
		/// Gets or sets the CRFAX value.
		/// </summary>
		public string CRFAX
		{
			get { return cRFAX; }
			set { cRFAX = value; }
		}

		/// <summary>
		/// Gets or sets the CRTELE value.
		/// </summary>
		public string CRTELE
		{
			get { return cRTELE; }
			set { cRTELE = value; }
		}

		/// <summary>
		/// Gets or sets the CREMAIL value.
		/// </summary>
		public string CREMAIL
		{
			get { return cREMAIL; }
			set { cREMAIL = value; }
		}

		/// <summary>
		/// Gets or sets the CRCONTPER value.
		/// </summary>
		public string CRCONTPER
		{
			get { return cRCONTPER; }
			set { cRCONTPER = value; }
		}

		/// <summary>
		/// Gets or sets the CRPATHO value.
		/// </summary>
		public string CRPATHO
		{
			get { return cRPATHO; }
			set { cRPATHO = value; }
		}

		/// <summary>
		/// Gets or sets the CRPATHOTEL value.
		/// </summary>
		public string CRPATHOTEL
		{
			get { return cRPATHOTEL; }
			set { cRPATHOTEL = value; }
		}

		/// <summary>
		/// Gets or sets the CRREGISMSYN value.
		/// </summary>
		public string CRREGISMSYN
		{
			get { return cRREGISMSYN; }
			set { cRREGISMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRBILLSMSYN value.
		/// </summary>
		public string CRBILLSMSYN
		{
			get { return cRBILLSMSYN; }
			set { cRBILLSMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRREPSMSYN value.
		/// </summary>
		public string CRREPSMSYN
		{
			get { return cRREPSMSYN; }
			set { cRREPSMSYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRMOBNO value.
		/// </summary>
		public string CRMOBNO
		{
			get { return cRMOBNO; }
			set { cRMOBNO = value; }
		}

		/// <summary>
		/// Gets or sets the CRMOBNO2 value.
		/// </summary>
		public string CRMOBNO2
		{
			get { return cRMOBNO2; }
			set { cRMOBNO2 = value; }
		}

		/// <summary>
		/// Gets or sets the CRDISPER value.
		/// </summary>
		public int CRDISPER
		{
			get { return cRDISPER; }
			set { cRDISPER = value; }
		}

		/// <summary>
		/// Gets or sets the CRDISAMT value.
		/// </summary>
		public decimal CRDISAMT
		{
			get { return cRDISAMT; }
			set { cRDISAMT = value; }
		}

		/// <summary>
		/// Gets or sets the CRZONE value.
		/// </summary>
		public string CRZONE
		{
			get { return cRZONE; }
			set { cRZONE = value; }
		}

		/// <summary>
		/// Gets or sets the CRWORHRS value.
		/// </summary>
		public string CRWORHRS
		{
			get { return cRWORHRS; }
			set { cRWORHRS = value; }
		}

		/// <summary>
		/// Gets or sets the CRTHRESLMT value.
		/// </summary>
		public decimal CRTHRESLMT
		{
			get { return cRTHRESLMT; }
			set { cRTHRESLMT = value; }
		}

		/// <summary>
		/// Gets or sets the CRROUT value.
		/// </summary>
		public short CRROUT
		{
			get { return cRROUT; }
			set { cRROUT = value; }
		}

		/// <summary>
		/// Gets or sets the CRSUNYN value.
		/// </summary>
		public string CRSUNYN
		{
			get { return cRSUNYN; }
			set { cRSUNYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRACTIVE value.
		/// </summary>
		public string CRACTIVE
		{
			get { return cRACTIVE; }
			set { cRACTIVE = value; }
		}

		/// <summary>
		/// Gets or sets the CRSALCODE value.
		/// </summary>
		public string CRSALCODE
		{
			get { return cRSALCODE; }
			set { cRSALCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CRREVTYPE value.
		/// </summary>
		public string CRREVTYPE
		{
			get { return cRREVTYPE; }
			set { cRREVTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the CRSERVICETAX value.
		/// </summary>
		public string CRSERVICETAX
		{
			get { return cRSERVICETAX; }
			set { cRSERVICETAX = value; }
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
		/// Gets or sets the CRLOGIN value.
		/// </summary>
		public string CRLOGIN
		{
			get { return cRLOGIN; }
			set { cRLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the CRDATE value.
		/// </summary>
		public DateTime CRDATE
		{
			get { return cRDATE; }
			set { cRDATE = value; }
		}

		/// <summary>
		/// Gets or sets the CRCATEGORY value.
		/// </summary>
		public string CRCATEGORY
		{
			get { return cRCATEGORY; }
			set { cRCATEGORY = value; }
		}

		/// <summary>
		/// Gets or sets the CRCLINICALTRIALYN value.
		/// </summary>
		public string CRCLINICALTRIALYN
		{
			get { return cRCLINICALTRIALYN; }
			set { cRCLINICALTRIALYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRPROTOCOLNO value.
		/// </summary>
		public string CRPROTOCOLNO
		{
			get { return cRPROTOCOLNO; }
			set { cRPROTOCOLNO = value; }
		}

		/// <summary>
		/// Gets or sets the CRRPTEMAILYN value.
		/// </summary>
		public string CRRPTEMAILYN
		{
			get { return cRRPTEMAILYN; }
			set { cRRPTEMAILYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRSPONSORYN value.
		/// </summary>
		public string CRSPONSORYN
		{
			get { return cRSPONSORYN; }
			set { cRSPONSORYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRSPONSORCODE value.
		/// </summary>
		public string CRSPONSORCODE
		{
			get { return cRSPONSORCODE; }
			set { cRSPONSORCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CRPONO value.
		/// </summary>
		public string CRPONO
		{
			get { return cRPONO; }
			set { cRPONO = value; }
		}

		/// <summary>
		/// Gets or sets the CRREPORTFORMAT value.
		/// </summary>
		public string CRREPORTFORMAT
		{
			get { return cRREPORTFORMAT; }
			set { cRREPORTFORMAT = value; }
		}

		/// <summary>
		/// Gets or sets the CRTELE1 value.
		/// </summary>
		public string CRTELE1
		{
			get { return cRTELE1; }
			set { cRTELE1 = value; }
		}

		/// <summary>
		/// Gets or sets the CRAUTHENTICATIONYN value.
		/// </summary>
		public string CRAUTHENTICATIONYN
		{
			get { return cRAUTHENTICATIONYN; }
			set { cRAUTHENTICATIONYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRSUMMARYRPTYN value.
		/// </summary>
		public string CRSUMMARYRPTYN
		{
			get { return cRSUMMARYRPTYN; }
			set { cRSUMMARYRPTYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRBLINDRPTYN value.
		/// </summary>
		public string CRBLINDRPTYN
		{
			get { return cRBLINDRPTYN; }
			set { cRBLINDRPTYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRLOGISTICYN value.
		/// </summary>
		public string CRLOGISTICYN
		{
			get { return cRLOGISTICYN; }
			set { cRLOGISTICYN = value; }
		}

		/// <summary>
		/// Gets or sets the CREMAILJPGYN value.
		/// </summary>
		public string CREMAILJPGYN
		{
			get { return cREMAILJPGYN; }
			set { cREMAILJPGYN = value; }
		}

		/// <summary>
		/// Gets or sets the OLDSAPCODE value.
		/// </summary>
		public string OLDSAPCODE
		{
			get { return oLDSAPCODE; }
			set { oLDSAPCODE = value; }
		}

		/// <summary>
		/// Gets or sets the NEWSAPCODE value.
		/// </summary>
		public string NEWSAPCODE
		{
			get { return nEWSAPCODE; }
			set { nEWSAPCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CRACCOUNTGRPCD value.
		/// </summary>
		public string CRACCOUNTGRPCD
		{
			get { return cRACCOUNTGRPCD; }
			set { cRACCOUNTGRPCD = value; }
		}

		/// <summary>
		/// Gets or sets the CRTRANSTIME value.
		/// </summary>
		public int CRTRANSTIME
		{
			get { return cRTRANSTIME; }
			set { cRTRANSTIME = value; }
		}

		/// <summary>
		/// Gets or sets the CRTATPARATYPE value.
		/// </summary>
		public string CRTATPARATYPE
		{
			get { return cRTATPARATYPE; }
			set { cRTATPARATYPE = value; }
		}

		/// <summary>
		/// Gets or sets the CRHEADERLOGOYN value.
		/// </summary>
		public string CRHEADERLOGOYN
		{
			get { return cRHEADERLOGOYN; }
			set { cRHEADERLOGOYN = value; }
		}

		/// <summary>
		/// Gets or sets the CRSTATIONARYTYPECD value.
		/// </summary>
		public string CRSTATIONARYTYPECD
		{
			get { return cRSTATIONARYTYPECD; }
			set { cRSTATIONARYTYPECD = value; }
		}


		#endregion
}
}
