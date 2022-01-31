using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EMRAttribute
	{
		#region Fields

		private int fieldId=0;
		private int eMRExaminationMappingID=0;
		private string fieldTitle=String.Empty;
		private string fieldType=String.Empty;
		private string fieldValue=String.Empty;
		private string fieldOptions=String.Empty;
		private bool fieldRequired=false;
		private bool fieldDisabled=false;
		private int parentId=0;
		private short seqNo=0;
		private string type=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool status=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FieldId value.
		/// </summary>
		public int FieldId
		{
			get { return fieldId; }
			set { fieldId = value; }
		}

		/// <summary>
		/// Gets or sets the EMRExaminationMappingID value.
		/// </summary>
		public int EMRExaminationMappingID
		{
			get { return eMRExaminationMappingID; }
			set { eMRExaminationMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the FieldTitle value.
		/// </summary>
		public string FieldTitle
		{
			get { return fieldTitle; }
			set { fieldTitle = value; }
		}

		/// <summary>
		/// Gets or sets the FieldType value.
		/// </summary>
		public string FieldType
		{
			get { return fieldType; }
			set { fieldType = value; }
		}

		/// <summary>
		/// Gets or sets the FieldValue value.
		/// </summary>
		public string FieldValue
		{
			get { return fieldValue; }
			set { fieldValue = value; }
		}

		/// <summary>
		/// Gets or sets the FieldOptions value.
		/// </summary>
		public string FieldOptions
		{
			get { return fieldOptions; }
			set { fieldOptions = value; }
		}

		/// <summary>
		/// Gets or sets the FieldRequired value.
		/// </summary>
		public bool FieldRequired
		{
			get { return fieldRequired; }
			set { fieldRequired = value; }
		}

		/// <summary>
		/// Gets or sets the FieldDisabled value.
		/// </summary>
		public bool FieldDisabled
		{
			get { return fieldDisabled; }
			set { fieldDisabled = value; }
		}

		/// <summary>
		/// Gets or sets the ParentId value.
		/// </summary>
		public int ParentId
		{
			get { return parentId; }
			set { parentId = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public short SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
