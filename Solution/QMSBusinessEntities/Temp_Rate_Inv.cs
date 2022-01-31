using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Temp_Rate_Inv
	{
		#region Fields

		private string tCODE=String.Empty;
		private long investigationID=0;
		private string tESTNAME=String.Empty;
		private string tYPE=String.Empty;
		private decimal gENERAL=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the TESTNAME value.
		/// </summary>
		public string TESTNAME
		{
			get { return tESTNAME; }
			set { tESTNAME = value; }
		}

		/// <summary>
		/// Gets or sets the TYPE value.
		/// </summary>
		public string TYPE
		{
			get { return tYPE; }
			set { tYPE = value; }
		}

		/// <summary>
		/// Gets or sets the GENERAL value.
		/// </summary>
		public decimal GENERAL
		{
			get { return gENERAL; }
			set { gENERAL = value; }
		}


		#endregion
}
}
