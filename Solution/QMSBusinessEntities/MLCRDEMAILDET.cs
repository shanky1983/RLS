using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MLCRDEMAILDET
	{
		#region Fields

		private string cRCODE=String.Empty;
		private string cREMAIL=String.Empty;
		private string uSRLOCK=String.Empty;
		private string cRLOGIN=String.Empty;
		private DateTime cRDATE=DateTime.MaxValue;
		private string isValid=String.Empty;

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
		/// Gets or sets the CREMAIL value.
		/// </summary>
		public string CREMAIL
		{
			get { return cREMAIL; }
			set { cREMAIL = value; }
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
		/// Gets or sets the IsValid value.
		/// </summary>
		public string IsValid
		{
			get { return isValid; }
			set { isValid = value; }
		}


		#endregion
}
}
