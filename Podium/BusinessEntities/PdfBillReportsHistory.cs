using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PdfBillReportsHistory
	{
		#region Fields

		private string visitnumber=String.Empty;
		private long finalBillID=0;
		private int orgID=0;
		private long visitID=0;
		private string isProcessed=String.Empty;
		private string path=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Visitnumber value.
		/// </summary>
		public string Visitnumber
		{
			get { return visitnumber; }
			set { visitnumber = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the IsProcessed value.
		/// </summary>
		public string IsProcessed
		{
			get { return isProcessed; }
			set { isProcessed = value; }
		}

		/// <summary>
		/// Gets or sets the Path value.
		/// </summary>
		public string Path
		{
			get { return path; }
			set { path = value; }
		}


		#endregion
}
}
