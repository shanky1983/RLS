using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Print_Audit_History
	{
		#region Fields

		private int print_Audit_History_ID=0;
		private int notificationID=0;
		private int identityID=0;
		private string actionType=String.Empty;
		private string category=String.Empty;
		private string type=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long orgAddressID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private int seq_Num=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Print_Audit_History_ID value.
		/// </summary>
		public int Print_Audit_History_ID
		{
			get { return print_Audit_History_ID; }
			set { print_Audit_History_ID = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationID value.
		/// </summary>
		public int NotificationID
		{
			get { return notificationID; }
			set { notificationID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentityID value.
		/// </summary>
		public int IdentityID
		{
			get { return identityID; }
			set { identityID = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the Seq_Num value.
		/// </summary>
		public int Seq_Num
		{
			get { return seq_Num; }
			set { seq_Num = value; }
		}


		#endregion
}
}
