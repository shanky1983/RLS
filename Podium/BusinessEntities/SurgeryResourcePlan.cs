using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SurgeryResourcePlan
	{
		#region Fields

		private long surResourcePlanID=0;
		private long oTRequestID=0;
		private long patientID=0;
		private long orgID=0;
		private long oTID=0;
		private long plannedByID=0;
		private long approvedByID=0;
		private string approvalStatus=String.Empty;
		private string resourcePlanStatus=String.Empty;
		private string comments=String.Empty;
		private string status=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private long modifiedBy=0;
		private string plannedByName=String.Empty;
		private string approvedByName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SurResourcePlanID value.
		/// </summary>
		public long SurResourcePlanID
		{
			get { return surResourcePlanID; }
			set { surResourcePlanID = value; }
		}

		/// <summary>
		/// Gets or sets the OTRequestID value.
		/// </summary>
		public long OTRequestID
		{
			get { return oTRequestID; }
			set { oTRequestID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OTID value.
		/// </summary>
		public long OTID
		{
			get { return oTID; }
			set { oTID = value; }
		}

		/// <summary>
		/// Gets or sets the PlannedByID value.
		/// </summary>
		public long PlannedByID
		{
			get { return plannedByID; }
			set { plannedByID = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedByID value.
		/// </summary>
		public long ApprovedByID
		{
			get { return approvedByID; }
			set { approvedByID = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalStatus value.
		/// </summary>
		public string ApprovalStatus
		{
			get { return approvalStatus; }
			set { approvalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ResourcePlanStatus value.
		/// </summary>
		public string ResourcePlanStatus
		{
			get { return resourcePlanStatus; }
			set { resourcePlanStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
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
		/// Gets or sets the PlannedByName value.
		/// </summary>
		public string PlannedByName
		{
			get { return plannedByName; }
			set { plannedByName = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedByName value.
		/// </summary>
		public string ApprovedByName
		{
			get { return approvedByName; }
			set { approvedByName = value; }
		}


		#endregion
}
}
