using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TrainingProgram_QMS
	{
		#region Fields

		private long trainingProgramID=0;
		private long orgID=0;
		private long planScheduleID=0;
		private string examType=String.Empty;
		private string participant=String.Empty;
		private int totalMarks=0;
		private int marksObtained=0;
		private string remarks=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TrainingProgramID value.
		/// </summary>
		public long TrainingProgramID
		{
			get { return trainingProgramID; }
			set { trainingProgramID = value; }
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
		/// Gets or sets the PlanScheduleID value.
		/// </summary>
		public long PlanScheduleID
		{
			get { return planScheduleID; }
			set { planScheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the ExamType value.
		/// </summary>
		public string ExamType
		{
			get { return examType; }
			set { examType = value; }
		}

		/// <summary>
		/// Gets or sets the Participant value.
		/// </summary>
		public string Participant
		{
			get { return participant; }
			set { participant = value; }
		}

		/// <summary>
		/// Gets or sets the TotalMarks value.
		/// </summary>
		public int TotalMarks
		{
			get { return totalMarks; }
			set { totalMarks = value; }
		}

		/// <summary>
		/// Gets or sets the MarksObtained value.
		/// </summary>
		public int MarksObtained
		{
			get { return marksObtained; }
			set { marksObtained = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
