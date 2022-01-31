using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrgBasedReportstationary
	{
		#region Fields

		private long orgImageID=0;
		private string withStationary=String.Empty;
		private string withOutStationary=String.Empty;
		private string oMark=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgImageID value.
		/// </summary>
		public long OrgImageID
		{
			get { return orgImageID; }
			set { orgImageID = value; }
		}

		/// <summary>
		/// Gets or sets the WithStationary value.
		/// </summary>
		public string WithStationary
		{
			get { return withStationary; }
			set { withStationary = value; }
		}

		/// <summary>
		/// Gets or sets the WithOutStationary value.
		/// </summary>
		public string WithOutStationary
		{
			get { return withOutStationary; }
			set { withOutStationary = value; }
		}

		/// <summary>
		/// Gets or sets the OMark value.
		/// </summary>
		public string OMark
		{
			get { return oMark; }
			set { oMark = value; }
		}


		#endregion
}
}
