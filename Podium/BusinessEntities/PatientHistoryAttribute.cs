using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _historyName=String.Empty;
		public string HistoryName
		{
			get { return  _historyName; }
			set { _historyName = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeName value.
		/// </summary>
		private string _attributeName=String.Empty;
		public string AttributeName
		{
			get { return  _attributeName; }
			set { _attributeName = value; }
		}

		/// <summary>
		/// Gets or sets the ControlName value.
		/// </summary>
		private string _controlName=String.Empty;
		public string ControlName
		{
			get { return  _controlName; }
			set { _controlName = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		private int _patternID=0;
		public int PatternID
		{
			get { return  _patternID; }
			set { _patternID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		private long _investigationID=0;
		public long InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		private long _patientID=0;
		public long PatientID
		{
			get { return  _patientID; }
			set { _patientID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedUserName value.
		/// </summary>
		private string _createdUserName=String.Empty;
		public string CreatedUserName
		{
			get { return  _createdUserName; }
			set { _createdUserName = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		private string _testName=String.Empty;
		public string TestName
		{
			get { return  _testName; }
			set { _testName = value; }
		}


		#endregion
}
}
