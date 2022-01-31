using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CommunicationMaster
	{
		#region Fields

		private long commId=0;
		private int commCtyId=0;
		private int orgId=0;
		private long postedBy=0;
		private string commContent=String.Empty;
		private string validity=String.Empty;
		private string ackRequired=String.Empty;
		private long refCommID=0;
		private long parentCommID=0;
		private int sequence=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long roleID=0;
		private long loginID=0;
		private long replyTypeId=0;
		private long postedRole=0;
		private long commResponseTypeId=0;
		private string isCriticalYN=String.Empty;
		private string identificationRemarks=String.Empty;
		private long commType=0;
		private long postedTo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CommId value.
		/// </summary>
		public long CommId
		{
			get { return commId; }
			set { commId = value; }
		}

		/// <summary>
		/// Gets or sets the CommCtyId value.
		/// </summary>
		public int CommCtyId
		{
			get { return commCtyId; }
			set { commCtyId = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the PostedBy value.
		/// </summary>
		public long PostedBy
		{
			get { return postedBy; }
			set { postedBy = value; }
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
		public string Validity
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

		/// <summary>
		/// Gets or sets the ReplyTypeId value.
		/// </summary>
		public long ReplyTypeId
		{
			get { return replyTypeId; }
			set { replyTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the PostedRole value.
		/// </summary>
		public long PostedRole
		{
			get { return postedRole; }
			set { postedRole = value; }
		}

		/// <summary>
		/// Gets or sets the CommResponseTypeId value.
		/// </summary>
		public long CommResponseTypeId
		{
			get { return commResponseTypeId; }
			set { commResponseTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the IsCriticalYN value.
		/// </summary>
		public string IsCriticalYN
		{
			get { return isCriticalYN; }
			set { isCriticalYN = value; }
		}

		/// <summary>
		/// Gets or sets the IdentificationRemarks value.
		/// </summary>
		public string IdentificationRemarks
		{
			get { return identificationRemarks; }
			set { identificationRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the CommType value.
		/// </summary>
		public long CommType
		{
			get { return commType; }
			set { commType = value; }
		}

		/// <summary>
		/// Gets or sets the PostedTo value.
		/// </summary>
		public long PostedTo
		{
			get { return postedTo; }
			set { postedTo = value; }
		}


		#endregion
}
}
