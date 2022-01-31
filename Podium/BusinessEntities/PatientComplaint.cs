using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientComplaint
	{
		#region Fields

		private long patientVisitID=0;
		private int complaintID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string description=String.Empty;
		private string query=String.Empty;
		private string complaintName=String.Empty;
		private string position=String.Empty;
		private string complaintType=String.Empty;
		private string hashAttribute=String.Empty;
		private long seqID=0;
		private string iCDCode=String.Empty;
		private string iCDDescription=String.Empty;
		private string iCDCodeStatus=String.Empty;
		private string physicianComments=String.Empty;
		private long onBehalf=0;
		private string isNewlydiagnosed=String.Empty;
		private string isPrimaryDiagnosis=String.Empty;
		private string physicianType=String.Empty;
		private long orderTaskID=0;
		private long patientVisitAttribID=0;
		private bool status=false;

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
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Query value.
		/// </summary>
		public string Query
		{
			get { return query; }
			set { query = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		public string ComplaintName
		{
			get { return complaintName; }
			set { complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the Position value.
		/// </summary>
		public string Position
		{
			get { return position; }
			set { position = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintType value.
		/// </summary>
		public string ComplaintType
		{
			get { return complaintType; }
			set { complaintType = value; }
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
		/// Gets or sets the ICDCode value.
		/// </summary>
		public string ICDCode
		{
			get { return iCDCode; }
			set { iCDCode = value; }
		}

		/// <summary>
		/// Gets or sets the ICDDescription value.
		/// </summary>
		public string ICDDescription
		{
			get { return iCDDescription; }
			set { iCDDescription = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCodeStatus value.
		/// </summary>
		public string ICDCodeStatus
		{
			get { return iCDCodeStatus; }
			set { iCDCodeStatus = value; }
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
		/// Gets or sets the OnBehalf value.
		/// </summary>
		public long OnBehalf
		{
			get { return onBehalf; }
			set { onBehalf = value; }
		}

		/// <summary>
		/// Gets or sets the IsNewlydiagnosed value.
		/// </summary>
		public string IsNewlydiagnosed
		{
			get { return isNewlydiagnosed; }
			set { isNewlydiagnosed = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrimaryDiagnosis value.
		/// </summary>
		public string IsPrimaryDiagnosis
		{
			get { return isPrimaryDiagnosis; }
			set { isPrimaryDiagnosis = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianType value.
		/// </summary>
		public string PhysicianType
		{
			get { return physicianType; }
			set { physicianType = value; }
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
		/// Gets or sets the PatientVisitAttribID value.
		/// </summary>
		public long PatientVisitAttribID
		{
			get { return patientVisitAttribID; }
			set { patientVisitAttribID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		private string _physicianName=String.Empty;
		public string PhysicianName
		{
			get { return  _physicianName; }
			set { _physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the GestationalWeek value.
		/// </summary>
		private int _gestationalWeek=0;
		public int GestationalWeek
		{
			get { return  _gestationalWeek; }
			set { _gestationalWeek = value; }
		}

		/// <summary>
		/// Gets or sets the GestationalDays value.
		/// </summary>
		private int _gestationalDays=0;
		public int GestationalDays
		{
			get { return  _gestationalDays; }
			set { _gestationalDays = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitTime value.
		/// </summary>
		private String _patientVisitTime=String.Empty;
		public String PatientVisitTime
		{
			get { return  _patientVisitTime; }
			set { _patientVisitTime = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfUltraSound value.
		/// </summary>
		private string _dateOfUltraSound=String.Empty;
		public string DateOfUltraSound
		{
			get { return  _dateOfUltraSound; }
			set { _dateOfUltraSound = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		private string _specialityName=String.Empty;
		public string SpecialityName
		{
			get { return  _specialityName; }
			set { _specialityName = value; }
		}


		#endregion
}
}
