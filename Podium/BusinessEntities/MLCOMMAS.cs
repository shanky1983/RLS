using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MLCOMMAS
	{
		#region Fields

		private string cMCODE=String.Empty;
		private string cMNAME=String.Empty;
		private string cMABB=String.Empty;
		private decimal cMCHARGE=Decimal.Zero;
		private decimal cMCOLCOM=Decimal.Zero;
		private short cMDAYS=0;
		private string cMREM=String.Empty;
		private string cMMON=String.Empty;
		private string cMTUE=String.Empty;
		private string cMWED=String.Empty;
		private string cMTHUS=String.Empty;
		private string cMFRI=String.Empty;
		private string cMSAT=String.Empty;
		private string cMDAILY=String.Empty;
		private string cMWEEKLY=String.Empty;
		private string cMBIWEEK=String.Empty;
		private string cMMONLY=String.Empty;
		private short cMDYOFMON=0;
		private decimal cMCUTOFF=Decimal.Zero;
		private string cMAMPM=String.Empty;
		private string cMGROUP=String.Empty;
		private decimal cMDUR=Decimal.Zero;
		private string cMSPL=String.Empty;
		private string cMFORMAT=String.Empty;
		private decimal cMSTATIME=Decimal.Zero;
		private string cMSTAMPM=String.Empty;
		private decimal cMOUTSTA=Decimal.Zero;
		private string cMACTIVE=String.Empty;
		private string cMHEALTHYN=String.Empty;
		private string cMSAMPLEYN=String.Empty;
		private string cMONELABLE=String.Empty;
		private string cBOOKNO=String.Empty;
		private string cMSCTCD=String.Empty;
		private string cMFEEDTESTVALYN=String.Empty;
		private string uSRLOCK=String.Empty;
		private string cMLOGIN=String.Empty;
		private DateTime cMDATE=DateTime.MaxValue;
		private string cMCLINICALTRIALYN=String.Empty;
		private string cMSERVICETAXYN=String.Empty;
		private decimal cMDIRECTPATIENTMRP=Decimal.Zero;
		private string oLDCMSCTCD=String.Empty;
		private string mMDOSCODE=String.Empty;
		private string cMFASTTRACK=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CMCODE value.
		/// </summary>
		public string CMCODE
		{
			get { return cMCODE; }
			set { cMCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CMNAME value.
		/// </summary>
		public string CMNAME
		{
			get { return cMNAME; }
			set { cMNAME = value; }
		}

		/// <summary>
		/// Gets or sets the CMABB value.
		/// </summary>
		public string CMABB
		{
			get { return cMABB; }
			set { cMABB = value; }
		}

		/// <summary>
		/// Gets or sets the CMCHARGE value.
		/// </summary>
		public decimal CMCHARGE
		{
			get { return cMCHARGE; }
			set { cMCHARGE = value; }
		}

		/// <summary>
		/// Gets or sets the CMCOLCOM value.
		/// </summary>
		public decimal CMCOLCOM
		{
			get { return cMCOLCOM; }
			set { cMCOLCOM = value; }
		}

		/// <summary>
		/// Gets or sets the CMDAYS value.
		/// </summary>
		public short CMDAYS
		{
			get { return cMDAYS; }
			set { cMDAYS = value; }
		}

		/// <summary>
		/// Gets or sets the CMREM value.
		/// </summary>
		public string CMREM
		{
			get { return cMREM; }
			set { cMREM = value; }
		}

		/// <summary>
		/// Gets or sets the CMMON value.
		/// </summary>
		public string CMMON
		{
			get { return cMMON; }
			set { cMMON = value; }
		}

		/// <summary>
		/// Gets or sets the CMTUE value.
		/// </summary>
		public string CMTUE
		{
			get { return cMTUE; }
			set { cMTUE = value; }
		}

		/// <summary>
		/// Gets or sets the CMWED value.
		/// </summary>
		public string CMWED
		{
			get { return cMWED; }
			set { cMWED = value; }
		}

		/// <summary>
		/// Gets or sets the CMTHUS value.
		/// </summary>
		public string CMTHUS
		{
			get { return cMTHUS; }
			set { cMTHUS = value; }
		}

		/// <summary>
		/// Gets or sets the CMFRI value.
		/// </summary>
		public string CMFRI
		{
			get { return cMFRI; }
			set { cMFRI = value; }
		}

		/// <summary>
		/// Gets or sets the CMSAT value.
		/// </summary>
		public string CMSAT
		{
			get { return cMSAT; }
			set { cMSAT = value; }
		}

		/// <summary>
		/// Gets or sets the CMDAILY value.
		/// </summary>
		public string CMDAILY
		{
			get { return cMDAILY; }
			set { cMDAILY = value; }
		}

		/// <summary>
		/// Gets or sets the CMWEEKLY value.
		/// </summary>
		public string CMWEEKLY
		{
			get { return cMWEEKLY; }
			set { cMWEEKLY = value; }
		}

		/// <summary>
		/// Gets or sets the CMBIWEEK value.
		/// </summary>
		public string CMBIWEEK
		{
			get { return cMBIWEEK; }
			set { cMBIWEEK = value; }
		}

		/// <summary>
		/// Gets or sets the CMMONLY value.
		/// </summary>
		public string CMMONLY
		{
			get { return cMMONLY; }
			set { cMMONLY = value; }
		}

		/// <summary>
		/// Gets or sets the CMDYOFMON value.
		/// </summary>
		public short CMDYOFMON
		{
			get { return cMDYOFMON; }
			set { cMDYOFMON = value; }
		}

		/// <summary>
		/// Gets or sets the CMCUTOFF value.
		/// </summary>
		public decimal CMCUTOFF
		{
			get { return cMCUTOFF; }
			set { cMCUTOFF = value; }
		}

		/// <summary>
		/// Gets or sets the CMAMPM value.
		/// </summary>
		public string CMAMPM
		{
			get { return cMAMPM; }
			set { cMAMPM = value; }
		}

		/// <summary>
		/// Gets or sets the CMGROUP value.
		/// </summary>
		public string CMGROUP
		{
			get { return cMGROUP; }
			set { cMGROUP = value; }
		}

		/// <summary>
		/// Gets or sets the CMDUR value.
		/// </summary>
		public decimal CMDUR
		{
			get { return cMDUR; }
			set { cMDUR = value; }
		}

		/// <summary>
		/// Gets or sets the CMSPL value.
		/// </summary>
		public string CMSPL
		{
			get { return cMSPL; }
			set { cMSPL = value; }
		}

		/// <summary>
		/// Gets or sets the CMFORMAT value.
		/// </summary>
		public string CMFORMAT
		{
			get { return cMFORMAT; }
			set { cMFORMAT = value; }
		}

		/// <summary>
		/// Gets or sets the CMSTATIME value.
		/// </summary>
		public decimal CMSTATIME
		{
			get { return cMSTATIME; }
			set { cMSTATIME = value; }
		}

		/// <summary>
		/// Gets or sets the CMSTAMPM value.
		/// </summary>
		public string CMSTAMPM
		{
			get { return cMSTAMPM; }
			set { cMSTAMPM = value; }
		}

		/// <summary>
		/// Gets or sets the CMOUTSTA value.
		/// </summary>
		public decimal CMOUTSTA
		{
			get { return cMOUTSTA; }
			set { cMOUTSTA = value; }
		}

		/// <summary>
		/// Gets or sets the CMACTIVE value.
		/// </summary>
		public string CMACTIVE
		{
			get { return cMACTIVE; }
			set { cMACTIVE = value; }
		}

		/// <summary>
		/// Gets or sets the CMHEALTHYN value.
		/// </summary>
		public string CMHEALTHYN
		{
			get { return cMHEALTHYN; }
			set { cMHEALTHYN = value; }
		}

		/// <summary>
		/// Gets or sets the CMSAMPLEYN value.
		/// </summary>
		public string CMSAMPLEYN
		{
			get { return cMSAMPLEYN; }
			set { cMSAMPLEYN = value; }
		}

		/// <summary>
		/// Gets or sets the CMONELABLE value.
		/// </summary>
		public string CMONELABLE
		{
			get { return cMONELABLE; }
			set { cMONELABLE = value; }
		}

		/// <summary>
		/// Gets or sets the CBOOKNO value.
		/// </summary>
		public string CBOOKNO
		{
			get { return cBOOKNO; }
			set { cBOOKNO = value; }
		}

		/// <summary>
		/// Gets or sets the CMSCTCD value.
		/// </summary>
		public string CMSCTCD
		{
			get { return cMSCTCD; }
			set { cMSCTCD = value; }
		}

		/// <summary>
		/// Gets or sets the CMFEEDTESTVALYN value.
		/// </summary>
		public string CMFEEDTESTVALYN
		{
			get { return cMFEEDTESTVALYN; }
			set { cMFEEDTESTVALYN = value; }
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
		/// Gets or sets the CMLOGIN value.
		/// </summary>
		public string CMLOGIN
		{
			get { return cMLOGIN; }
			set { cMLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the CMDATE value.
		/// </summary>
		public DateTime CMDATE
		{
			get { return cMDATE; }
			set { cMDATE = value; }
		}

		/// <summary>
		/// Gets or sets the CMCLINICALTRIALYN value.
		/// </summary>
		public string CMCLINICALTRIALYN
		{
			get { return cMCLINICALTRIALYN; }
			set { cMCLINICALTRIALYN = value; }
		}

		/// <summary>
		/// Gets or sets the CMSERVICETAXYN value.
		/// </summary>
		public string CMSERVICETAXYN
		{
			get { return cMSERVICETAXYN; }
			set { cMSERVICETAXYN = value; }
		}

		/// <summary>
		/// Gets or sets the CMDIRECTPATIENTMRP value.
		/// </summary>
		public decimal CMDIRECTPATIENTMRP
		{
			get { return cMDIRECTPATIENTMRP; }
			set { cMDIRECTPATIENTMRP = value; }
		}

		/// <summary>
		/// Gets or sets the OLDCMSCTCD value.
		/// </summary>
		public string OLDCMSCTCD
		{
			get { return oLDCMSCTCD; }
			set { oLDCMSCTCD = value; }
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
		/// Gets or sets the CMFASTTRACK value.
		/// </summary>
		public string CMFASTTRACK
		{
			get { return cMFASTTRACK; }
			set { cMFASTTRACK = value; }
		}


		#endregion
}
}
