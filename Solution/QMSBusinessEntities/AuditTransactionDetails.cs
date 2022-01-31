using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AuditTransactionDetails
	{
		#region Fields

		private long attributeID=0;
		private string attributeName=String.Empty;
		private long auditID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;

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
		/// Gets or sets the AttributeName value.
		/// </summary>
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
		}

		/// <summary>
		/// Gets or sets the AuditID value.
		/// </summary>
		public long AuditID
		{
			get { return auditID; }
			set { auditID = value; }
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


		#endregion
}
}
