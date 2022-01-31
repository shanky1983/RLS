using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EmergencyPatientTracker
	{
		#region Fields

		private long emergencyPatientTrackerID=0;
		private long patientID=0;
		private long patientVisitID=0;
		private long emergencySeverityOrgMappingID=0;
		private string patientStatus=String.Empty;
		private DateTime dischargeDateTime=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long identifiedPatientID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmergencyPatientTrackerID value.
		/// </summary>
		public long EmergencyPatientTrackerID
		{
			get { return emergencyPatientTrackerID; }
			set { emergencyPatientTrackerID = value; }
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
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
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
		/// Gets or sets the PatientStatus value.
		/// </summary>
		public string PatientStatus
		{
			get { return patientStatus; }
			set { patientStatus = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeDateTime value.
		/// </summary>
		public DateTime DischargeDateTime
		{
			get { return dischargeDateTime; }
			set { dischargeDateTime = value; }
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

		/// <summary>
		/// Gets or sets the IdentifiedPatientID value.
		/// </summary>
		public long IdentifiedPatientID
		{
			get { return identifiedPatientID; }
			set { identifiedPatientID = value; }
		}


		#endregion
}
}
