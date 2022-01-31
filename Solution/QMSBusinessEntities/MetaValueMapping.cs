using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MetaValueMapping
	{
		#region Fields

		private long metaMappingID=0;
		private long metaValueId=0;
		private string identifyingType=String.Empty;
		private long identifyingValue=0;
		private long parentvalueid=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MetaMappingID value.
		/// </summary>
		public long MetaMappingID
		{
			get { return metaMappingID; }
			set { metaMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the MetaValueId value.
		/// </summary>
		public long MetaValueId
		{
			get { return metaValueId; }
			set { metaValueId = value; }
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
