using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NeonatalNotes
	{
		#region Fields

		private long neonatalNotesID=0;
		private long patientVistID=0;
		private long patientID=0;
		private int orgID=0;
		private string respiratorySupport=String.Empty;
		private string fluidsandNutrition=String.Empty;
		private string generalCourse=String.Empty;
		private string plans=String.Empty;
		private string immunizationSchedule=String.Empty;
		private string nextReviewAfter=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string neonatalStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NeonatalNotesID value.
		/// </summary>
		public long NeonatalNotesID
		{
			get { return neonatalNotesID; }
			set { neonatalNotesID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVistID value.
		/// </summary>
		public long PatientVistID
		{
			get { return patientVistID; }
			set { patientVistID = value; }
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
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the RespiratorySupport value.
		/// </summary>
		public string RespiratorySupport
		{
			get { return respiratorySupport; }
			set { respiratorySupport = value; }
		}

		/// <summary>
		/// Gets or sets the FluidsandNutrition value.
		/// </summary>
		public string FluidsandNutrition
		{
			get { return fluidsandNutrition; }
			set { fluidsandNutrition = value; }
		}

		/// <summary>
		/// Gets or sets the GeneralCourse value.
		/// </summary>
		public string GeneralCourse
		{
			get { return generalCourse; }
			set { generalCourse = value; }
		}

		/// <summary>
		/// Gets or sets the Plans value.
		/// </summary>
		public string Plans
		{
			get { return plans; }
			set { plans = value; }
		}

		/// <summary>
		/// Gets or sets the ImmunizationSchedule value.
		/// </summary>
		public string ImmunizationSchedule
		{
			get { return immunizationSchedule; }
			set { immunizationSchedule = value; }
		}

		/// <summary>
		/// Gets or sets the NextReviewAfter value.
		/// </summary>
		public string NextReviewAfter
		{
			get { return nextReviewAfter; }
			set { nextReviewAfter = value; }
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
		/// Gets or sets the NeonatalStatus value.
		/// </summary>
		public string NeonatalStatus
		{
			get { return neonatalStatus; }
			set { neonatalStatus = value; }
		}


		#endregion
}
}
