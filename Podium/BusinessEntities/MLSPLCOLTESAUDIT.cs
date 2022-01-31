using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MLSPLCOLTESAUDIT
	{
		#region Fields

		private string cTCOL=String.Empty;
		private string cTTEST=String.Empty;
		private string cTDESC=String.Empty;
		private decimal cTSLAB=Decimal.Zero;
		private decimal cTCOMM=Decimal.Zero;
		private decimal cTCOMAMT=Decimal.Zero;
		private int clientID=0;
		private string clientName=String.Empty;
		private int aCRPID=0;
		private int aORGID=0;
		private string aTYPE=String.Empty;
		private decimal attuneRate=Decimal.Zero;
		private string rateCard=String.Empty;
		private string tCODE=String.Empty;
		private string tNAME=String.Empty;
		private string aTCODE=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CTCOL value.
		/// </summary>
		public string CTCOL
		{
			get { return cTCOL; }
			set { cTCOL = value; }
		}

		/// <summary>
		/// Gets or sets the CTTEST value.
		/// </summary>
		public string CTTEST
		{
			get { return cTTEST; }
			set { cTTEST = value; }
		}

		/// <summary>
		/// Gets or sets the CTDESC value.
		/// </summary>
		public string CTDESC
		{
			get { return cTDESC; }
			set { cTDESC = value; }
		}

		/// <summary>
		/// Gets or sets the CTSLAB value.
		/// </summary>
		public decimal CTSLAB
		{
			get { return cTSLAB; }
			set { cTSLAB = value; }
		}

		/// <summary>
		/// Gets or sets the CTCOMM value.
		/// </summary>
		public decimal CTCOMM
		{
			get { return cTCOMM; }
			set { cTCOMM = value; }
		}

		/// <summary>
		/// Gets or sets the CTCOMAMT value.
		/// </summary>
		public decimal CTCOMAMT
		{
			get { return cTCOMAMT; }
			set { cTCOMAMT = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the ACRPID value.
		/// </summary>
		public int ACRPID
		{
			get { return aCRPID; }
			set { aCRPID = value; }
		}

		/// <summary>
		/// Gets or sets the AORGID value.
		/// </summary>
		public int AORGID
		{
			get { return aORGID; }
			set { aORGID = value; }
		}

		/// <summary>
		/// Gets or sets the ATYPE value.
		/// </summary>
		public string ATYPE
		{
			get { return aTYPE; }
			set { aTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the AttuneRate value.
		/// </summary>
		public decimal AttuneRate
		{
			get { return attuneRate; }
			set { attuneRate = value; }
		}

		/// <summary>
		/// Gets or sets the RateCard value.
		/// </summary>
		public string RateCard
		{
			get { return rateCard; }
			set { rateCard = value; }
		}

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
		/// Gets or sets the ATCODE value.
		/// </summary>
		public string ATCODE
		{
			get { return aTCODE; }
			set { aTCODE = value; }
		}


		#endregion
}
}
