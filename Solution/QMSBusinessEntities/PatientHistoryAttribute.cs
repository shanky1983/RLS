using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientHistoryAttribute
	{
		#region Fields

		private long patientHistoryAttributeID=0;
		private long patientVisitID=0;
		private long historyID=0;
		private long seqID=0;
		private long attributeID=0;
		private long attributevalueID=0;
		private string attributeValueName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int invID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientHistoryAttributeID value.
		/// </summary>
		public long PatientHistoryAttributeID
		{
			get { return patientHistoryAttributeID; }
			set { patientHistoryAttributeID = value; }
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
		/// Gets or sets the HistoryID value.
		/// </summary>
		public long HistoryID
		{
			get { return historyID; }
			set { historyID = value; }
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
		/// Gets or sets the InvID value.
		/// </summary>
		public int InvID
		{
			get { return invID; }
			set { invID = value; }
		}

		/// <summary>
		/// Gets or sets the HistoryName value.
		/// </summary>
		string _historyname;
		public string HistoryName
		{
			get { return _historyname; }
			set { _historyname = value; }
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

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		long _investigationid;
		public long InvestigationID
		{
			get { return _investigationid; }
			set { _investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		long _patientid;
		public long PatientID
		{
			get { return _patientid; }
			set { _patientid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedUserName value.
		/// </summary>
		string _createdusername;
		public string CreatedUserName
		{
			get { return _createdusername; }
			set { _createdusername = value; }
		}


		#endregion
}
}
