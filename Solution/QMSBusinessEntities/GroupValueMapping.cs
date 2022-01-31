using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class GroupValueMapping
	{
		#region Fields

		private long groupMappingID=0;
		private long groupValueId=0;
		private string identifyingType=String.Empty;
		private long identifyingValue=0;
		private long parentvalueid=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GroupMappingID value.
		/// </summary>
		public long GroupMappingID
		{
			get { return groupMappingID; }
			set { groupMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupValueId value.
		/// </summary>
		public long GroupValueId
		{
			get { return groupValueId; }
			set { groupValueId = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingType value.
		/// </summary>
		public string IdentifyingType
		{
			get { return identifyingType; }
			set { identifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingValue value.
		/// </summary>
		public long IdentifyingValue
		{
			get { return identifyingValue; }
			set { identifyingValue = value; }
		}

		/// <summary>
		/// Gets or sets the Parentvalueid value.
		/// </summary>
		public long Parentvalueid
		{
			get { return parentvalueid; }
			set { parentvalueid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
