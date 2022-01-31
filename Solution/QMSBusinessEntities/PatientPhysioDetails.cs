using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientPhysioDetails
	{
		#region Fields

		private long patientPhysioDtlID=0;
		private long procedureID=0;
		private string procedureName=String.Empty;
		private long patientID=0;
		private long visitID=0;
		private int orgAddID=0;
		private int orgID=0;
		private int advisedNoOfSitting=0;
		private int currentNoOfSitting=0;
		private decimal durationValue=Decimal.Zero;
		private string durationUnits=String.Empty;
		private decimal scoreCardValue=Decimal.Zero;
		private string scoreCardUnit=String.Empty;
		private string remarks=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private string nextReview=String.Empty;
		private string hasPending=String.Empty;
		private string physicianComments=String.Empty;
		private string symptoms=String.Empty;
		private long parentID=0;
		private string visitType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientPhysioDtlID value.
		/// </summary>
		public long PatientPhysioDtlID
		{
			get { return patientPhysioDtlID; }
			set { patientPhysioDtlID = value; }
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
		/// Gets or sets the DurationValue value.
		/// </summary>
		public decimal DurationValue
		{
			get { return durationValue; }
			set { durationValue = value; }
		}

		/// <summary>
		/// Gets or sets the DurationUnits value.
		/// </summary>
		public string DurationUnits
		{
			get { return durationUnits; }
			set { durationUnits = value; }
		}

		/// <summary>
		/// Gets or sets the ScoreCardValue value.
		/// </summary>
		public decimal ScoreCardValue
		{
			get { return scoreCardValue; }
			set { scoreCardValue = value; }
		}

		/// <summary>
		/// Gets or sets the ScoreCardUnit value.
		/// </summary>
		public string ScoreCardUnit
		{
			get { return scoreCardUnit; }
			set { scoreCardUnit = value; }
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

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the NextReview value.
		/// </summary>
		public string NextReview
		{
			get { return nextReview; }
			set { nextReview = value; }
		}

		/// <summary>
		/// Gets or sets the HasPending value.
		/// </summary>
		public string HasPending
		{
			get { return hasPending; }
			set { hasPending = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianComments value.
		/// </summary>
		public string PhysicianComments
		{
			get { return physicianComments; }
			set { physicianComments = value; }
		}

		/// <summary>
		/// Gets or sets the Symptoms value.
		/// </summary>
		public string Symptoms
		{
			get { return symptoms; }
			set { symptoms = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		public string VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		Decimal _quantity;
		public Decimal Quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		/// <summary>
		/// Gets or sets the Duration value.
		/// </summary>
		string _duration;
		public string Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		string _complaintname;
		public string ComplaintName
		{
			get { return _complaintname; }
			set { _complaintname = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		string _visitdate;
		public string VisitDate
		{
			get { return _visitdate; }
			set { _visitdate = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureCount value.
		/// </summary>
		long _procedurecount;
		public long ProcedureCount
		{
			get { return _procedurecount; }
			set { _procedurecount = value; }
		}

		/// <summary>
		/// Gets or sets the VisitCount value.
		/// </summary>
		long _visitcount;
		public long VisitCount
		{
			get { return _visitcount; }
			set { _visitcount = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		int _complaintid;
		public int ComplaintID
		{
			get { return _complaintid; }
			set { _complaintid = value; }
		}

		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		int _rowid;
		public int RowID
		{
			get { return _rowid; }
			set { _rowid = value; }
		}


		#endregion
}
}
