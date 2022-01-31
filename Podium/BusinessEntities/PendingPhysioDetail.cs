using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PendingPhysioDetail
	{
		#region Fields

		private long patientID=0;
		private long sVisitID=0;
		private long eVisitID=0;
		private int orgAddID=0;
		private int orgID=0;
		private long procedureID=0;
		private string procedureName=String.Empty;
		private int advisedNoOfSitting=0;
		private int currentNoOfSitting=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string todayVisit=String.Empty;
		private DateTime todayVisitDate=DateTime.MaxValue;
		private string physicianComments=String.Empty;

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
		/// Gets or sets the SVisitID value.
		/// </summary>
		public long SVisitID
		{
			get { return sVisitID; }
			set { sVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the EVisitID value.
		/// </summary>
		public long EVisitID
		{
			get { return eVisitID; }
			set { eVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
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
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public long ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureName value.
		/// </summary>
		public string ProcedureName
		{
			get { return procedureName; }
			set { procedureName = value; }
		}

		/// <summary>
		/// Gets or sets the AdvisedNoOfSitting value.
		/// </summary>
		public int AdvisedNoOfSitting
		{
			get { return advisedNoOfSitting; }
			set { advisedNoOfSitting = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentNoOfSitting value.
		/// </summary>
		public int CurrentNoOfSitting
		{
			get { return currentNoOfSitting; }
			set { currentNoOfSitting = value; }
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
		/// Gets or sets the TodayVisit value.
		/// </summary>
		public string TodayVisit
		{
			get { return todayVisit; }
			set { todayVisit = value; }
		}

		/// <summary>
		/// Gets or sets the TodayVisitDate value.
		/// </summary>
		public DateTime TodayVisitDate
		{
			get { return todayVisitDate; }
			set { todayVisitDate = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianComments value.
		/// </summary>
		public string PhysicianComments
		{
			get { return physicianComments; }
			set { physicianComments = value; }
		}


		#endregion
}
}
