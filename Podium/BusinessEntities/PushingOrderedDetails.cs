using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PushingOrderedDetails
	{
		#region Fields

		private int pOrderedID=0;
		private string actionType=String.Empty;
		private string valu=String.Empty;
		private string category=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long orgAddressID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string template=String.Empty;
		private string isAttachment=String.Empty;
		private int seq_Num=0;
		private int retryCount=0;
		private string attachmentName=String.Empty;
		private string identityID=String.Empty;
		private DateTime completionTime=DateTime.MaxValue;
		private string content=String.Empty;
		private string errorMessaage=String.Empty;
		private string errorMessage=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the POrderedID value.
		/// </summary>
		public int POrderedID
		{
			get { return pOrderedID; }
			set { pOrderedID = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
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
		/// Gets or sets the IsAttachment value.
		/// </summary>
		public string IsAttachment
		{
			get { return isAttachment; }
			set { isAttachment = value; }
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
		/// Gets or sets the Content value.
		/// </summary>
		public string Content
		{
			get { return content; }
			set { content = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorMessaage value.
		/// </summary>
		public string ErrorMessaage
		{
			get { return errorMessaage; }
			set { errorMessaage = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorMessage value.
		/// </summary>
		public string ErrorMessage
		{
			get { return errorMessage; }
			set { errorMessage = value; }
		}


		#endregion
}
}
