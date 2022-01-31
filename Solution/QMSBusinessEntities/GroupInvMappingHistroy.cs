using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class GroupInvMappingHistroy
	{
		#region Fields

		private long investigationID=0;
		private int groupID=0;
		private string modifiedBY=String.Empty;
		private DateTime modifiedAT=DateTime.MaxValue;
		private long sequenceNo=0;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBY value.
		/// </summary>
		public string ModifiedBY
		{
			get { return modifiedBY; }
			set { modifiedBY = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAT value.
		/// </summary>
		public DateTime ModifiedAT
		{
			get { return modifiedAT; }
			set { modifiedAT = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public long SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
