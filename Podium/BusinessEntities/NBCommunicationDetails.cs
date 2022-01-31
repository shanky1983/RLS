using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class NBCommunicationDetails
	{
		#region Fields

		private long detailID=0;
		private long commID=0;
		private string commCode=String.Empty;
		private int commType=0;
		private int orgID=0;
		private long loginID=0;
		private int roleID=0;
		private string aCKRequired=String.Empty;
		private int aCKStatus=0;
		private string priorityLevel=String.Empty;
		private string remarks=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailID value.
		/// </summary>
		public long DetailID
		{
			get { return detailID; }
			set { detailID = value; }
		}

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
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the ACKRequired value.
		/// </summary>
		public string ACKRequired
		{
			get { return aCKRequired; }
			set { aCKRequired = value; }
		}

		/// <summary>
		/// Gets or sets the ACKStatus value.
		/// </summary>
		public int ACKStatus
		{
			get { return aCKStatus; }
			set { aCKStatus = value; }
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
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
		/// Gets or sets the CommContent value.
		/// </summary>
		private string _commContent=String.Empty;
		public string CommContent
		{
			get { return  _commContent; }
			set { _commContent = value; }
		}

		/// <summary>
		/// Gets or sets the Validity value.
		/// </summary>
		private DateTime _validity=DateTime.MaxValue;
		public DateTime Validity
		{
			get { return  _validity; }
			set { _validity = value; }
		}

		/// <summary>
		/// Gets or sets the BroadcastedBy value.
		/// </summary>
		private string _broadcastedBy=String.Empty;
		public string BroadcastedBy
		{
			get { return  _broadcastedBy; }
			set { _broadcastedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ToName value.
		/// </summary>
		private string _toName=String.Empty;
		public string ToName
		{
			get { return  _toName; }
			set { _toName = value; }
		}

		/// <summary>
		/// Gets or sets the Sub value.
		/// </summary>
		private string _sub=String.Empty;
		public string Sub
		{
			get { return  _sub; }
			set { _sub = value; }
		}


		#endregion
}
}
