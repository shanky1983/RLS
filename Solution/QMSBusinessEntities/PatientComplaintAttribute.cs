using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientComplaintAttribute
	{
		#region Fields

		private long patientComplaintAttributeID=0;
		private long complaintID=0;
		private long patientVisitId=0;
		private long seqID=0;
		private long attributeID=0;
		private long attributevalueID=0;
		private string attributeValueName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientComplaintAttributeID value.
		/// </summary>
		public long PatientComplaintAttributeID
		{
			get { return patientComplaintAttributeID; }
			set { patientComplaintAttributeID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public long ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
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
		/// Gets or sets the AttributeID value.
		/// </summary>
		public long AttributeID
		{
			get { return attributeID; }
			set { attributeID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributevalueID value.
		/// </summary>
		public long AttributevalueID
		{
			get { return attributevalueID; }
			set { attributevalueID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeValueName value.
		/// </summary>
		public string AttributeValueName
		{
			get { return attributeValueName; }
			set { attributeValueName = value; }
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
		/// Gets or sets the ComplaintName value.
		/// </summary>
		string _complaintname;
		public string ComplaintName
		{
			get { return _complaintname; }
			set { _complaintname = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeName value.
		/// </summary>
		string _attributename;
		public string AttributeName
		{
			get { return _attributename; }
			set { _attributename = value; }
		}

		/// <summary>
		/// Gets or sets the ControlName value.
		/// </summary>
		string _controlname;
		public string ControlName
		{
			get { return _controlname; }
			set { _controlname = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		int _patternid;
		public int PatternID
		{
			get { return _patternid; }
			set { _patternid = value; }
		}


		#endregion
}
}
