using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AHD_MLCOLEMAILDET
	{
		#region Fields

		private string cLCODE=String.Empty;
		private string cLEMAIL=String.Empty;
		private string uSRLOCK=String.Empty;
		private string cLLOGIN=String.Empty;
		private DateTime cLDATE=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CLCODE value.
		/// </summary>
		public string CLCODE
		{
			get { return cLCODE; }
			set { cLCODE = value; }
		}

		/// <summary>
		/// Gets or sets the CLEMAIL value.
		/// </summary>
		public string CLEMAIL
		{
			get { return cLEMAIL; }
			set { cLEMAIL = value; }
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
		/// Gets or sets the CLLOGIN value.
		/// </summary>
		public string CLLOGIN
		{
			get { return cLLOGIN; }
			set { cLLOGIN = value; }
		}

		/// <summary>
		/// Gets or sets the CLDATE value.
		/// </summary>
		public DateTime CLDATE
		{
			get { return cLDATE; }
			set { cLDATE = value; }
		}


		#endregion
}
}
