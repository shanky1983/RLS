using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientAttributesFields
	{
		#region Fields

		private long fieldID=0;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private long orgID=0;
		private string fieldName=String.Empty;
		private string dataType=String.Empty;
		private string controlType=String.Empty;
		private string domain=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FieldID value.
		/// </summary>
		public long FieldID
		{
			get { return fieldID; }
			set { fieldID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
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
		/// Gets or sets the FieldName value.
		/// </summary>
		public string FieldName
		{
			get { return fieldName; }
			set { fieldName = value; }
		}

		/// <summary>
		/// Gets or sets the DataType value.
		/// </summary>
		public string DataType
		{
			get { return dataType; }
			set { dataType = value; }
		}

		/// <summary>
		/// Gets or sets the ControlType value.
		/// </summary>
		public string ControlType
		{
			get { return controlType; }
			set { controlType = value; }
		}

		/// <summary>
		/// Gets or sets the Domain value.
		/// </summary>
		public string Domain
		{
			get { return domain; }
			set { domain = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
