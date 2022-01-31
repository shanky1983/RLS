using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientProgressive
	{
		#region Fields

		private int patientProgressiveID=0;
		private long patientVisitID=0;
		private int progressiveID=0;
		private string subjective=String.Empty;
		private string objective=String.Empty;
		private string assesment=String.Empty;
		private string planning=String.Empty;
		private long patientID=0;
		private string physicianName=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime createdBy=DateTime.MaxValue;
		private DateTime dateandTimeofCaseReview=DateTime.MaxValue;
		private long orderTaskID=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientProgressiveID value.
		/// </summary>
		public int PatientProgressiveID
		{
			get { return patientProgressiveID; }
			set { patientProgressiveID = value; }
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
		/// Gets or sets the ProgressiveID value.
		/// </summary>
		public int ProgressiveID
		{
			get { return progressiveID; }
			set { progressiveID = value; }
		}

		/// <summary>
		/// Gets or sets the Subjective value.
		/// </summary>
		public string Subjective
		{
			get { return subjective; }
			set { subjective = value; }
		}

		/// <summary>
		/// Gets or sets the Objective value.
		/// </summary>
		public string Objective
		{
			get { return objective; }
			set { objective = value; }
		}

		/// <summary>
		/// Gets or sets the Assesment value.
		/// </summary>
		public string Assesment
		{
			get { return assesment; }
			set { assesment = value; }
		}

		/// <summary>
		/// Gets or sets the Planning value.
		/// </summary>
		public string Planning
		{
			get { return planning; }
			set { planning = value; }
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
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public DateTime CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the DateandTimeofCaseReview value.
		/// </summary>
		public DateTime DateandTimeofCaseReview
		{
			get { return dateandTimeofCaseReview; }
			set { dateandTimeofCaseReview = value; }
		}

		/// <summary>
		/// Gets or sets the OrderTaskID value.
		/// </summary>
		public long OrderTaskID
		{
			get { return orderTaskID; }
			set { orderTaskID = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
