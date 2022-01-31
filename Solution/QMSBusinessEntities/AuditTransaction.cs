using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AuditTransaction
	{
		#region Fields

		private long auditId=0;
		private string categoryCode=String.Empty;
		private string typeCode=String.Empty;
		private int orgAddressID=0;
		private int orgID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AuditId value.
		/// </summary>
		public long AuditId
		{
			get { return auditId; }
			set { auditId = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryCode value.
		/// </summary>
		public string CategoryCode
		{
			get { return categoryCode; }
			set { categoryCode = value; }
		}

		/// <summary>
		/// Gets or sets the TypeCode value.
		/// </summary>
		public string TypeCode
		{
			get { return typeCode; }
			set { typeCode = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
