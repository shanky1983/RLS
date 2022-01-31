using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DischargeSummary
	{
		#region Fields

		private long dischargeSummaryID=0;
		private long patientVistID=0;
		private long patientID=0;
		private DateTime dateOfDischarge=DateTime.MaxValue;
		private int typeOfDischarge=0;
		private string conditionOnDischarge=String.Empty;
		private string hospitalCourse=String.Empty;
		private string nextReviewAfter=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string summaryStatus=String.Empty;
		private string preparedBy=String.Empty;
		private string procedureDesc=String.Empty;
		private string printNegativeExam=String.Empty;
		private string printNegativeHistory=String.Empty;
		private string printGeneralAdvice=String.Empty;
		private string reviewReason=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeSummaryID value.
		/// </summary>
		public long DischargeSummaryID
		{
			get { return dischargeSummaryID; }
			set { dischargeSummaryID = value; }
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
		/// Gets or sets the DateOfDischarge value.
		/// </summary>
		public DateTime DateOfDischarge
		{
			get { return dateOfDischarge; }
			set { dateOfDischarge = value; }
		}

		/// <summary>
		/// Gets or sets the TypeOfDischarge value.
		/// </summary>
		public int TypeOfDischarge
		{
			get { return typeOfDischarge; }
			set { typeOfDischarge = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionOnDischarge value.
		/// </summary>
		public string ConditionOnDischarge
		{
			get { return conditionOnDischarge; }
			set { conditionOnDischarge = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalCourse value.
		/// </summary>
		public string HospitalCourse
		{
			get { return hospitalCourse; }
			set { hospitalCourse = value; }
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
		/// Gets or sets the SummaryStatus value.
		/// </summary>
		public string SummaryStatus
		{
			get { return summaryStatus; }
			set { summaryStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PreparedBy value.
		/// </summary>
		public string PreparedBy
		{
			get { return preparedBy; }
			set { preparedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureDesc value.
		/// </summary>
		public string ProcedureDesc
		{
			get { return procedureDesc; }
			set { procedureDesc = value; }
		}

		/// <summary>
		/// Gets or sets the PrintNegativeExam value.
		/// </summary>
		public string PrintNegativeExam
		{
			get { return printNegativeExam; }
			set { printNegativeExam = value; }
		}

		/// <summary>
		/// Gets or sets the PrintNegativeHistory value.
		/// </summary>
		public string PrintNegativeHistory
		{
			get { return printNegativeHistory; }
			set { printNegativeHistory = value; }
		}

		/// <summary>
		/// Gets or sets the PrintGeneralAdvice value.
		/// </summary>
		public string PrintGeneralAdvice
		{
			get { return printGeneralAdvice; }
			set { printGeneralAdvice = value; }
		}

		/// <summary>
		/// Gets or sets the ReviewReason value.
		/// </summary>
		public string ReviewReason
		{
			get { return reviewReason; }
			set { reviewReason = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeTypeName value.
		/// </summary>
		string _dischargetypename;
		public string DischargeTypeName
		{
			get { return _dischargetypename; }
			set { _dischargetypename = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		#endregion
}
}
