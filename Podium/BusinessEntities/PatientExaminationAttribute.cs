using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientExaminationAttribute
	{
		#region Fields

		private long patientExaminationAttributeID=0;
		private long patientVisitID=0;
		private long examinationID=0;
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
		/// Gets or sets the PatientExaminationAttributeID value.
		/// </summary>
		public long PatientExaminationAttributeID
		{
			get { return patientExaminationAttributeID; }
			set { patientExaminationAttributeID = value; }
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
		/// Gets or sets the ExaminationID value.
		/// </summary>
		public long ExaminationID
		{
			get { return examinationID; }
			set { examinationID = value; }
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
		/// Gets or sets the ExaminationName value.
		/// </summary>
		private string _examinationName=String.Empty;
		public string ExaminationName
		{
			get { return  _examinationName; }
			set { _examinationName = value; }
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


		#endregion
}
}
