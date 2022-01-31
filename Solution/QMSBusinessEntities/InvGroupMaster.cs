using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvGroupMaster
	{
		#region Fields

		private int groupID=0;
		private string groupName=String.Empty;
		private string type=String.Empty;
		private long parentID=0;
		private int orgID=0;
		private int sequenceNo=0;
		private string testCode=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the AttGroupID value.
		/// </summary>
		int _attgroupid;
		public int AttGroupID
		{
			get { return _attgroupid; }
			set { _attgroupid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		int _orggroupid;
		public int OrgGroupID
		{
			get { return _orggroupid; }
			set { _orggroupid = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		string _displaytext;
		public string DisplayText
		{
			get { return _displaytext; }
			set { _displaytext = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		Decimal _rate;
		public Decimal Rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		/// <summary>
		/// Gets or sets the GroupNameCommands value.
		/// </summary>
		string _groupnamecommands;
		public string GroupNameCommands
		{
			get { return _groupnamecommands; }
			set { _groupnamecommands = value; }
		}


		#endregion
}
}
