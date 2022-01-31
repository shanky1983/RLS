using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatienttoScanforANC
	{
		#region Fields

		private long patientVisitID=0;
		private long patienID=0;
		private string scanStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the PatienID value.
		/// </summary>
		public long PatienID
		{
			get { return patienID; }
			set { patienID = value; }
		}

		/// <summary>
		/// Gets or sets the ScanStatus value.
		/// </summary>
		public string ScanStatus
		{
			get { return scanStatus; }
			set { scanStatus = value; }
		}


		#endregion
}
}
