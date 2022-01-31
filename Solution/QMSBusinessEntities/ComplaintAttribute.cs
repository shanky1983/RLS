using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ComplaintAttribute
	{
		#region Fields

		private long attributeID=0;
		private long complaintID=0;
		private string attributeName=String.Empty;
		private long parentAttributeID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AttributeID value.
		/// </summary>
		public long AttributeID
		{
			get { return attributeID; }
			set { attributeID = value; }
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
		/// Gets or sets the AttributeName value.
		/// </summary>
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentAttributeID value.
		/// </summary>
		public long ParentAttributeID
		{
			get { return parentAttributeID; }
			set { parentAttributeID = value; }
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


		#endregion
}
}
