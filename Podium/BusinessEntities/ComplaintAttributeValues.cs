using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ComplaintAttributeValues
	{
		#region Fields

		private long attributevalueID=0;
		private long attributeID=0;
		private string attributeValueName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttributevalueID value.
		/// </summary>
		public long AttributevalueID
		{
			get { return attributevalueID; }
			set { attributevalueID = value; }
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
		/// Gets or sets the ComplaintCode value.
		/// </summary>
		private string _complaintCode=String.Empty;
		public string ComplaintCode
		{
			get { return  _complaintCode; }
			set { _complaintCode = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeCode value.
		/// </summary>
		private string _attributeCode=String.Empty;
		public string AttributeCode
		{
			get { return  _attributeCode; }
			set { _attributeCode = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		private string _uOMCode=String.Empty;
		public string UOMCode
		{
			get { return  _uOMCode; }
			set { _uOMCode = value; }
		}


		#endregion
}
}
