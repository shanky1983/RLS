using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class N146
	{
		#region Fields

		private int notificationID=0;
		private string actionType=String.Empty;
		private string valu=String.Empty;
		private string additionalContext=String.Empty;
		private string category=String.Empty;
		private string version=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long orgAddressID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string template=String.Empty;
		private string contextType=String.Empty;
		private string isAttachment=String.Empty;
		private string subject=String.Empty;
		private int seq_Num=0;
		private int retryCount=0;
		private int priority=0;
		private string attachmentName=String.Empty;
		private string identityID=String.Empty;
		private DateTime completionTime=DateTime.MaxValue;
		private string isConfidentialTest=String.Empty;
		private string isClientBlinding=String.Empty;
		private long roundID=0;
		private string emailCC=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NotificationID value.
		/// </summary>
		public int NotificationID
		{
			get { return notificationID; }
			set { notificationID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionType value.
		/// </summary>
		public string ActionType
		{
			get { return actionType; }
			set { actionType = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalContext value.
		/// </summary>
		public string AdditionalContext
		{
			get { return additionalContext; }
			set { additionalContext = value; }
		}

		/// <summary>
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
		}

		/// <summary>
		/// Gets or sets the Version value.
		/// </summary>
		public string Version
		{
			get { return version; }
			set { version = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		public long OrgAddressID
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the Template value.
		/// </summary>
		public string Template
		{
			get { return template; }
			set { template = value; }
		}

		/// <summary>
		/// Gets or sets the ContextType value.
		/// </summary>
		public string ContextType
		{
			get { return contextType; }
			set { contextType = value; }
		}

		/// <summary>
		/// Gets or sets the IsAttachment value.
		/// </summary>
		public string IsAttachment
		{
			get { return isAttachment; }
			set { isAttachment = value; }
		}

		/// <summary>
		/// Gets or sets the Subject value.
		/// </summary>
		public string Subject
		{
			get { return subject; }
			set { subject = value; }
		}

		/// <summary>
		/// Gets or sets the Seq_Num value.
		/// </summary>
		public int Seq_Num
		{
			get { return seq_Num; }
			set { seq_Num = value; }
		}

		/// <summary>
		/// Gets or sets the RetryCount value.
		/// </summary>
		public int RetryCount
		{
			get { return retryCount; }
			set { retryCount = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public int Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the AttachmentName value.
		/// </summary>
		public string AttachmentName
		{
			get { return attachmentName; }
			set { attachmentName = value; }
		}

		/// <summary>
		/// Gets or sets the IdentityID value.
		/// </summary>
		public string IdentityID
		{
			get { return identityID; }
			set { identityID = value; }
		}

		/// <summary>
		/// Gets or sets the CompletionTime value.
		/// </summary>
		public DateTime CompletionTime
		{
			get { return completionTime; }
			set { completionTime = value; }
		}

		/// <summary>
		/// Gets or sets the IsConfidentialTest value.
		/// </summary>
		public string IsConfidentialTest
		{
			get { return isConfidentialTest; }
			set { isConfidentialTest = value; }
		}

		/// <summary>
		/// Gets or sets the IsClientBlinding value.
		/// </summary>
		public string IsClientBlinding
		{
			get { return isClientBlinding; }
			set { isClientBlinding = value; }
		}

		/// <summary>
		/// Gets or sets the RoundID value.
		/// </summary>
		public long RoundID
		{
			get { return roundID; }
			set { roundID = value; }
		}

		/// <summary>
		/// Gets or sets the EmailCC value.
		/// </summary>
		public string EmailCC
		{
			get { return emailCC; }
			set { emailCC = value; }
		}


		#endregion
}
}
