using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MLPRFDTLATTUNE
	{
		#region Fields

		private string pTCODE=String.Empty;
		private string pTTCCD=String.Empty;
		private int rOWID=0;
		private string uSRLOCK=String.Empty;
		private string pTLOGIN=String.Empty;
		private DateTime pTDATE=DateTime.MaxValue;
		private string pDOSCODE=String.Empty;
		private string cDOSCODE=String.Empty;
		private string pACTIVE=String.Empty;
		private string iSCT=String.Empty;
		private int cACRPID=0;
		private int cAORGID=0;
		private string cATYPE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PTCODE value.
		/// </summary>
		public string PTCODE
		{
			get { return pTCODE; }
			set { pTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the PTTCCD value.
		/// </summary>
		public string PTTCCD
		{
			get { return pTTCCD; }
			set { pTTCCD = value; }
		}

		/// <summary>
		/// Gets or sets the ROWID value.
		/// </summary>
		public int ROWID
		{
			get { return rOWID; }
			set { rOWID = value; }
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
		/// Gets or sets the PTLOGIN value.
		/// </summary>
		public string PTLOGIN
		{
			get { return pTLOGIN; }
			set { pTLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the PTDATE value.
		/// </summary>
		public DateTime PTDATE
		{
			get { return pTDATE; }
			set { pTDATE = value; }
		}

		/// <summary>
		/// Gets or sets the PDOSCODE value.
		/// </summary>
		public string PDOSCODE
		{
			get { return pDOSCODE; }
			set { pDOSCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CDOSCODE value.
		/// </summary>
		public string CDOSCODE
		{
			get { return cDOSCODE; }
			set { cDOSCODE = value; }
		}

		/// <summary>
		/// Gets or sets the PACTIVE value.
		/// </summary>
		public string PACTIVE
		{
			get { return pACTIVE; }
			set { pACTIVE = value; }
		}

		/// <summary>
		/// Gets or sets the ISCT value.
		/// </summary>
		public string ISCT
		{
			get { return iSCT; }
			set { iSCT = value; }
		}

		/// <summary>
		/// Gets or sets the CACRPID value.
		/// </summary>
		public int CACRPID
		{
			get { return cACRPID; }
			set { cACRPID = value; }
		}

		/// <summary>
		/// Gets or sets the CAORGID value.
		/// </summary>
		public int CAORGID
		{
			get { return cAORGID; }
			set { cAORGID = value; }
		}

		/// <summary>
		/// Gets or sets the CATYPE value.
		/// </summary>
		public string CATYPE
		{
			get { return cATYPE; }
			set { cATYPE = value; }
		}


		#endregion
}
}
