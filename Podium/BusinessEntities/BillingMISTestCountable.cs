using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BillingMISTestCountable
	{
		#region Fields

		private int orgID=0;
		private int pACRPID=0;
		private string pATYPE=String.Empty;
		private int cACRPID=0;
		private string cATYPE=String.Empty;
		private string sRC=String.Empty;
		private int pMRP=0;
		private int cMRP=0;
		private decimal aPERC=Decimal.Zero;
		private string isOrdered=String.Empty;
		private string pTCODE=String.Empty;
		private string pTNAME=String.Empty;
		private string cTCODE=String.Empty;
		private string cTNAME=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PACRPID value.
		/// </summary>
		public int PACRPID
		{
			get { return pACRPID; }
			set { pACRPID = value; }
		}

		/// <summary>
		/// Gets or sets the PATYPE value.
		/// </summary>
		public string PATYPE
		{
			get { return pATYPE; }
			set { pATYPE = value; }
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
		/// Gets or sets the CATYPE value.
		/// </summary>
		public string CATYPE
		{
			get { return cATYPE; }
			set { cATYPE = value; }
		}

		/// <summary>
		/// Gets or sets the SRC value.
		/// </summary>
		public string SRC
		{
			get { return sRC; }
			set { sRC = value; }
		}

		/// <summary>
		/// Gets or sets the PMRP value.
		/// </summary>
		public int PMRP
		{
			get { return pMRP; }
			set { pMRP = value; }
		}

		/// <summary>
		/// Gets or sets the CMRP value.
		/// </summary>
		public int CMRP
		{
			get { return cMRP; }
			set { cMRP = value; }
		}

		/// <summary>
		/// Gets or sets the APERC value.
		/// </summary>
		public decimal APERC
		{
			get { return aPERC; }
			set { aPERC = value; }
		}

		/// <summary>
		/// Gets or sets the IsOrdered value.
		/// </summary>
		public string IsOrdered
		{
			get { return isOrdered; }
			set { isOrdered = value; }
		}

		/// <summary>
		/// Gets or sets the PTCODE value.
		/// </summary>
		public string PTCODE
		{
			get { return pTCODE; }
			set { pTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the PTNAME value.
		/// </summary>
		public string PTNAME
		{
			get { return pTNAME; }
			set { pTNAME = value; }
		}

		/// <summary>
		/// Gets or sets the CTCODE value.
		/// </summary>
		public string CTCODE
		{
			get { return cTCODE; }
			set { cTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CTNAME value.
		/// </summary>
		public string CTNAME
		{
			get { return cTNAME; }
			set { cTNAME = value; }
		}


		#endregion
}
}
