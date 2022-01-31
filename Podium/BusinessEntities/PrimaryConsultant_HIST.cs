using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PrimaryConsultant_HIST
	{
		#region Fields

		private long primaryConsultantID_HISTID=0;
		private long primaryConsultantID=0;
		private string physicianName=String.Empty;
		private long patientID=0;
		private long visitID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdRole=0;
		private long tableGroupID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PrimaryConsultantID_HISTID value.
		/// </summary>
		public long PrimaryConsultantID_HISTID
		{
			get { return primaryConsultantID_HISTID; }
			set { primaryConsultantID_HISTID = value; }
		}

		/// <summary>
		/// Gets or sets the PrimaryConsultantID value.
		/// </summary>
		public long PrimaryConsultantID
		{
			get { return primaryConsultantID; }
			set { primaryConsultantID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}

		/// <summary>
		/// Gets or sets the TableGroupID value.
		/// </summary>
		public long TableGroupID
		{
			get { return tableGroupID; }
			set { tableGroupID = value; }
		}


		#endregion
}
}
