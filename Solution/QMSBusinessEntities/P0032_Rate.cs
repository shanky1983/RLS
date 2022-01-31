using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class P0032_Rate
	{
		#region Fields

		private string tESTCODE=String.Empty;
		private string pRICETYPE=String.Empty;
		private float rATE=0.0F;
		private string iSCHANGED=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TESTCODE value.
		/// </summary>
		public string TESTCODE
		{
			get { return tESTCODE; }
			set { tESTCODE = value; }
		}

		/// <summary>
		/// Gets or sets the PRICETYPE value.
		/// </summary>
		public string PRICETYPE
		{
			get { return pRICETYPE; }
			set { pRICETYPE = value; }
		}

		/// <summary>
		/// Gets or sets the RATE value.
		/// </summary>
		public float RATE
		{
			get { return rATE; }
			set { rATE = value; }
		}

		/// <summary>
		/// Gets or sets the ISCHANGED value.
		/// </summary>
		public string ISCHANGED
		{
			get { return iSCHANGED; }
			set { iSCHANGED = value; }
		}


		#endregion
}
}
