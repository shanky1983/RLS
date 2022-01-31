using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private int _attGroupID=0;
		public int AttGroupID
		{
			get { return  _attGroupID; }
			set { _attGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgGroupID value.
		/// </summary>
		private int _orgGroupID=0;
		public int OrgGroupID
		{
			get { return  _orgGroupID; }
			set { _orgGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		private string _displayText=String.Empty;
		public string DisplayText
		{
			get { return  _displayText; }
			set { _displayText = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		private Decimal _rate=Decimal.Zero;
		public Decimal Rate
		{
			get { return  _rate; }
			set { _rate = value; }
		}

		/// <summary>
		/// Gets or sets the GroupNameCommands value.
		/// </summary>
		private string _groupNameCommands=String.Empty;
		public string GroupNameCommands
		{
			get { return  _groupNameCommands; }
			set { _groupNameCommands = value; }
		}

		/// <summary>
		/// Gets or sets the CodeName value.
		/// </summary>
		private string _codeName=String.Empty;
		public string CodeName
		{
			get { return  _codeName; }
			set { _codeName = value; }
		}


		#endregion
}
}
