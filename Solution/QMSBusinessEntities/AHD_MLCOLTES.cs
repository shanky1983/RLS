using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AHD_MLCOLTES
	{
		#region Fields

		private string cTCOL=String.Empty;
		private string cTTEST=String.Empty;
		private string cTDESC=String.Empty;
		private decimal cTSLAB=Decimal.Zero;
		private decimal cTCOMM=Decimal.Zero;
		private decimal cTCOMAMT=Decimal.Zero;
		private string uSRLOCK=String.Empty;
		private string cTLOGIN=String.Empty;
		private DateTime cTDATE=DateTime.MaxValue;

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
		/// Gets or sets the USRLOCK value.
		/// </summary>
		public string USRLOCK
		{
			get { return uSRLOCK; }
			set { uSRLOCK = value; }
		}

		/// <summary>
		/// Gets or sets the CTLOGIN value.
		/// </summary>
		public string CTLOGIN
		{
			get { return cTLOGIN; }
			set { cTLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the CTDATE value.
		/// </summary>
		public DateTime CTDATE
		{
			get { return cTDATE; }
			set { cTDATE = value; }
		}


		#endregion
}
}
