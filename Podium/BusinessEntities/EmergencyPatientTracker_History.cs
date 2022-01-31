using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EmergencyPatientTracker_History
	{
		#region Fields

		private long emergencyPatientTrackerHisId=0;
		private long emergencyPatientTrackerId=0;
		private long patientID=0;
		private long patientVisitId=0;
		private long emergencySeverityOrgMappingID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmergencyPatientTrackerHisId value.
		/// </summary>
		public long EmergencyPatientTrackerHisId
		{
			get { return emergencyPatientTrackerHisId; }
			set { emergencyPatientTrackerHisId = value; }
		}

		/// <summary>
		/// Gets or sets the EmergencyPatientTrackerId value.
		/// </summary>
		public long EmergencyPatientTrackerId
		{
			get { return emergencyPatientTrackerId; }
			set { emergencyPatientTrackerId = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the EmergencySeverityOrgMappingID value.
		/// </summary>
		public long EmergencySeverityOrgMappingID
		{
			get { return emergencySeverityOrgMappingID; }
			set { emergencySeverityOrgMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
