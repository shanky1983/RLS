using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NotificationAudit
	{
		#region Fields

		private long auditID=0;
		private string receiverType=String.Empty;
		private long id=0;
		private string notificationTypes=String.Empty;
		private string contactInfo=String.Empty;
		private string message=String.Empty;
		private long createdBy=0;
		private int orgID=0;
		private int orgAddressID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedAt=0;
		private DateTime modifiedBy=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AuditID value.
		/// </summary>
		public long AuditID
		{
			get { return auditID; }
			set { auditID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverType value.
		/// </summary>
		public string ReceiverType
		{
			get { return receiverType; }
			set { receiverType = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationTypes value.
		/// </summary>
		public string NotificationTypes
		{
			get { return notificationTypes; }
			set { notificationTypes = value; }
		}

		/// <summary>
		/// Gets or sets the ContactInfo value.
		/// </summary>
		public string ContactInfo
		{
			get { return contactInfo; }
			set { contactInfo = value; }
		}

		/// <summary>
		/// Gets or sets the Message value.
		/// </summary>
		public string Message
		{
			get { return message; }
			set { message = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public DateTime ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
