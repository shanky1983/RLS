using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MachineErrorRule
	{
		#region Fields

		private int machineErrorRuleId=0;
		private int ruleMasterId=0;
		private string componentName=String.Empty;
		private string errorCode=String.Empty;
		private string logicalOperator=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MachineErrorRuleId value.
		/// </summary>
		public int MachineErrorRuleId
		{
			get { return machineErrorRuleId; }
			set { machineErrorRuleId = value; }
		}

		/// <summary>
		/// Gets or sets the RuleMasterId value.
		/// </summary>
		public int RuleMasterId
		{
			get { return ruleMasterId; }
			set { ruleMasterId = value; }
		}

		/// <summary>
		/// Gets or sets the ComponentName value.
		/// </summary>
		public string ComponentName
		{
			get { return componentName; }
			set { componentName = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCode value.
		/// </summary>
		public string ErrorCode
		{
			get { return errorCode; }
			set { errorCode = value; }
		}

		/// <summary>
		/// Gets or sets the LogicalOperator value.
		/// </summary>
		public string LogicalOperator
		{
			get { return logicalOperator; }
			set { logicalOperator = value; }
		}

        private int remarksId = 0;
        public int RemarksId
        {
            get { return remarksId; }
            set { remarksId = value; }
        }
		#endregion
}
}
