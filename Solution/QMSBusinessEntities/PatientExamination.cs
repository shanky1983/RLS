using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientExamination
	{
		#region Fields

		private long patientVisitID=0;
		private int examinationID=0;
		private string examinationName=String.Empty;
		private int complaintId=0;
		private string description=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string hashAttribute=String.Empty;
		private long seqID=0;

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
		/// Gets or sets the ExaminationID value.
		/// </summary>
		public int ExaminationID
		{
			get { return examinationID; }
			set { examinationID = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationName value.
		/// </summary>
		public string ExaminationName
		{
			get { return examinationName; }
			set { examinationName = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		public int ComplaintId
		{
			get { return complaintId; }
			set { complaintId = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
		}

		/// <summary>
		/// Gets or sets the SeqID value.
		/// </summary>
		public long SeqID
		{
			get { return seqID; }
			set { seqID = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationDesc value.
		/// </summary>
		string _examinationdesc;
		public string ExaminationDesc
		{
			get { return _examinationdesc; }
			set { _examinationdesc = value; }
		}


		#endregion
}
}
