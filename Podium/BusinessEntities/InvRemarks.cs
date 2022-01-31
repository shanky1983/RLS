using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvRemarks
	{
		#region Fields

		private long invRemarksID=0;
		private long remarksID=0;
		private long iD=0;
		private string type=String.Empty;
		private long roleID=0;
		private int orgID=0;
		private string comments=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvRemarksID value.
		/// </summary>
		public long InvRemarksID
		{
			get { return invRemarksID; }
			set { invRemarksID = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksID value.
		/// </summary>
		public long RemarksID
		{
			get { return remarksID; }
			set { remarksID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksText value.
		/// </summary>
		private string _remarksText=String.Empty;
		public string RemarksText
		{
			get { return  _remarksText; }
			set { _remarksText = value; }
		}


		#endregion
}
}
