using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MLCOMDTL
	{
		#region Fields

		private string cDCODE=String.Empty;
		private string cDTEST=String.Empty;
		private int rOWID=0;
		private string uSRLOCK=String.Empty;
		private string cDLOGIN=String.Empty;
		private DateTime cDDATE=DateTime.MaxValue;
		private int oRDERID=0;
		private string cDDELIMITER=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CDCODE value.
		/// </summary>
		public string CDCODE
		{
			get { return cDCODE; }
			set { cDCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CDTEST value.
		/// </summary>
		public string CDTEST
		{
			get { return cDTEST; }
			set { cDTEST = value; }
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
		/// Gets or sets the CDLOGIN value.
		/// </summary>
		public string CDLOGIN
		{
			get { return cDLOGIN; }
			set { cDLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the CDDATE value.
		/// </summary>
		public DateTime CDDATE
		{
			get { return cDDATE; }
			set { cDDATE = value; }
		}

		/// <summary>
		/// Gets or sets the ORDERID value.
		/// </summary>
		public int ORDERID
		{
			get { return oRDERID; }
			set { oRDERID = value; }
		}

		/// <summary>
		/// Gets or sets the CDDELIMITER value.
		/// </summary>
		public string CDDELIMITER
		{
			get { return cDDELIMITER; }
			set { cDDELIMITER = value; }
		}


		#endregion
}
}
