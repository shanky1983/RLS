using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DispatchRuleMaster
	{
		#region Fields

		private long ruleId=0;
		private string ruleType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RuleId value.
		/// </summary>
		public long RuleId
		{
			get { return ruleId; }
			set { ruleId = value; }
		}

		/// <summary>
		/// Gets or sets the RuleType value.
		/// </summary>
		public string RuleType
		{
			get { return ruleType; }
			set { ruleType = value; }
		}


		#endregion
}
}
