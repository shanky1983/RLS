using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EmergencyPatientIDNameMaster
	{
		#region Fields

		private int rowid=0;
		private long orgID=0;
		private long patientNumber=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Rowid value.
		/// </summary>
		public int Rowid
		{
			get { return rowid; }
			set { rowid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		public long PatientNumber
		{
			get { return patientNumber; }
			set { patientNumber = value; }
		}


		#endregion
}
}
