using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BiopsyNotification
	{
		#region Fields

		private string visitNumber=String.Empty;
		private string externalvisitid=String.Empty;
		private string patientName=String.Empty;
		private long vISITID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Externalvisitid value.
		/// </summary>
		public string Externalvisitid
		{
			get { return externalvisitid; }
			set { externalvisitid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the VISITID value.
		/// </summary>
		public long VISITID
		{
			get { return vISITID; }
			set { vISITID = value; }
		}


		#endregion
}
}
