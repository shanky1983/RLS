using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AHD_MLCRDTES
	{
		#region Fields

		private string cRCODE=String.Empty;
		private string cRTEST=String.Empty;
		private string cRDESC=String.Empty;
		private decimal cRSLAB=Decimal.Zero;
		private decimal cRCOMM=Decimal.Zero;
		private string uSRLOCK=String.Empty;
		private string cRLOGIN=String.Empty;
		private DateTime cRDATE=DateTime.MaxValue;

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
		/// Gets or sets the CRTEST value.
		/// </summary>
		public string CRTEST
		{
			get { return cRTEST; }
			set { cRTEST = value; }
		}

		/// <summary>
		/// Gets or sets the CRDESC value.
		/// </summary>
		public string CRDESC
		{
			get { return cRDESC; }
			set { cRDESC = value; }
		}

		/// <summary>
		/// Gets or sets the CRSLAB value.
		/// </summary>
		public decimal CRSLAB
		{
			get { return cRSLAB; }
			set { cRSLAB = value; }
		}

		/// <summary>
		/// Gets or sets the CRCOMM value.
		/// </summary>
		public decimal CRCOMM
		{
			get { return cRCOMM; }
			set { cRCOMM = value; }
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


		#endregion
}
}
