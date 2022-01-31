using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IPTreatmentPlan
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private int iPTreatmentPlanID=0;
		private string iPTreatmentPlanName=String.Empty;
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
		private int treatmentPlanID=0;

		#endregion

		#region Properties
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
		/// Gets or sets the IPTreatmentPlanID value.
		/// </summary>
		public int IPTreatmentPlanID
		{
			get { return iPTreatmentPlanID; }
			set { iPTreatmentPlanID = value; }
		}

		/// <summary>
		/// Gets or sets the IPTreatmentPlanName value.
		/// </summary>
		public string IPTreatmentPlanName
		{
			get { return iPTreatmentPlanName; }
			set { iPTreatmentPlanName = value; }
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
		/// Gets or sets the TreatmentPlanID value.
		/// </summary>
		public int TreatmentPlanID
		{
			get { return treatmentPlanID; }
			set { treatmentPlanID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		string _physicianname;
		public string PhysicianName
		{
			get { return _physicianname; }
			set { _physicianname = value; }
		}

		/// <summary>
		/// Gets or sets the FromTime value.
		/// </summary>
		DateTime _fromtime;
		public DateTime FromTime
		{
			get { return _fromtime; }
			set { _fromtime = value; }
		}

		/// <summary>
		/// Gets or sets the OperationFindings value.
		/// </summary>
		string _operationfindings;
		public string OperationFindings
		{
			get { return _operationfindings; }
			set { _operationfindings = value; }
		}

		/// <summary>
		/// Gets or sets the PostOperationFindings value.
		/// </summary>
		string _postoperationfindings;
		public string PostOperationFindings
		{
			get { return _postoperationfindings; }
			set { _postoperationfindings = value; }
		}


		#endregion
}
}
