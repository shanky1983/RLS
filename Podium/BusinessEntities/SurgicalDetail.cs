using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SurgicalDetail
	{
		#region Fields

		private long patientVisitID=0;
		private int surgeryID=0;
		private string surgeryName=String.Empty;
		private string prosthesis=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private long operationID=0;
		private int parentID=0;
		private string parentName=String.Empty;
		private DateTime treatmentPlanDate=DateTime.MaxValue;
		private string status=String.Empty;
		private string stagePlanned=String.Empty;
		private string hospitalName=String.Empty;
		private string hashAttribute=String.Empty;

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
		/// Gets or sets the SurgeryID value.
		/// </summary>
		public int SurgeryID
		{
			get { return surgeryID; }
			set { surgeryID = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryName value.
		/// </summary>
		public string SurgeryName
		{
			get { return surgeryName; }
			set { surgeryName = value; }
		}

		/// <summary>
		/// Gets or sets the Prosthesis value.
		/// </summary>
		public string Prosthesis
		{
			get { return prosthesis; }
			set { prosthesis = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OperationID value.
		/// </summary>
		public long OperationID
		{
			get { return operationID; }
			set { operationID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentName value.
		/// </summary>
		public string ParentName
		{
			get { return parentName; }
			set { parentName = value; }
		}

		/// <summary>
		/// Gets or sets the TreatmentPlanDate value.
		/// </summary>
		public DateTime TreatmentPlanDate
		{
			get { return treatmentPlanDate; }
			set { treatmentPlanDate = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the StagePlanned value.
		/// </summary>
		public string StagePlanned
		{
			get { return stagePlanned; }
			set { stagePlanned = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalName value.
		/// </summary>
		public string HospitalName
		{
			get { return hospitalName; }
			set { hospitalName = value; }
		}

		/// <summary>
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
		}


		#endregion
}
}
