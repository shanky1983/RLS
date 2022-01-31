using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NBCommunicationMaster
	{
		#region Fields

		private long commID=0;
		private string commCode=String.Empty;
		private int commType=0;
		private int orgID=0;
		private string broadcastedBy=String.Empty;
		private string subject=String.Empty;
		private string commContent=String.Empty;
		private DateTime validity=DateTime.MaxValue;
		private string ackRequired=String.Empty;
		private string sendSMS=String.Empty;
		private long refCommID=0;
		private long parentCommID=0;
		private int sequence=0;
		private long commCategoryID=0;
		private string priorityLevel=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long roleID=0;
		private long loginID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CommID value.
		/// </summary>
		public long CommID
		{
			get { return commID; }
			set { commID = value; }
		}

		/// <summary>
		/// Gets or sets the CommCode value.
		/// </summary>
		public string CommCode
		{
			get { return commCode; }
			set { commCode = value; }
		}

		/// <summary>
		/// Gets or sets the CommType value.
		/// </summary>
		public int CommType
		{
			get { return commType; }
			set { commType = value; }
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
		/// Gets or sets the BroadcastedBy value.
		/// </summary>
		public string BroadcastedBy
		{
			get { return broadcastedBy; }
			set { broadcastedBy = value; }
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
		/// Gets or sets the CommContent value.
		/// </summary>
		public string CommContent
		{
			get { return commContent; }
			set { commContent = value; }
		}

		/// <summary>
		/// Gets or sets the Validity value.
		/// </summary>
		public DateTime Validity
		{
			get { return validity; }
			set { validity = value; }
		}

		/// <summary>
		/// Gets or sets the AckRequired value.
		/// </summary>
		public string AckRequired
		{
			get { return ackRequired; }
			set { ackRequired = value; }
		}

		/// <summary>
		/// Gets or sets the SendSMS value.
		/// </summary>
		public string SendSMS
		{
			get { return sendSMS; }
			set { sendSMS = value; }
		}

		/// <summary>
		/// Gets or sets the RefCommID value.
		/// </summary>
		public long RefCommID
		{
			get { return refCommID; }
			set { refCommID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentCommID value.
		/// </summary>
		public long ParentCommID
		{
			get { return parentCommID; }
			set { parentCommID = value; }
		}

		/// <summary>
		/// Gets or sets the Sequence value.
		/// </summary>
		public int Sequence
		{
			get { return sequence; }
			set { sequence = value; }
		}

		/// <summary>
		/// Gets or sets the CommCategoryID value.
		/// </summary>
		public long CommCategoryID
		{
			get { return commCategoryID; }
			set { commCategoryID = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityLevel value.
		/// </summary>
		public string PriorityLevel
		{
			get { return priorityLevel; }
			set { priorityLevel = value; }
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
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}


		#endregion
}
}
