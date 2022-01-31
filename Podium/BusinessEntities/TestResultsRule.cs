using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TestResultsRule
	{
		#region Fields

		private int testResultsRuleId=0;
		private int ruleMasterId=0;
		private string componentName=String.Empty;
		private long resultInvestigationID=0;
		private string resultInvestigation=String.Empty;
		private string resultType=String.Empty;
		private string resultOptr=String.Empty;
        private string resultValue1 = String.Empty;
        private string resultvalue2 = String.Empty;
		private string logicalOperator=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestResultsRuleId value.
		/// </summary>
		public int TestResultsRuleId
		{
			get { return testResultsRuleId; }
			set { testResultsRuleId = value; }
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
		/// Gets or sets the ResultInvestigationID value.
		/// </summary>
		public long ResultInvestigationID
		{
			get { return resultInvestigationID; }
			set { resultInvestigationID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultInvestigation value.
		/// </summary>
		public string ResultInvestigation
		{
			get { return resultInvestigation; }
			set { resultInvestigation = value; }
		}

		/// <summary>
		/// Gets or sets the ResultType value.
		/// </summary>
		public string ResultType
		{
			get { return resultType; }
			set { resultType = value; }
		}

		/// <summary>
		/// Gets or sets the ResultOptr value.
		/// </summary>
		public string ResultOptr
		{
			get { return resultOptr; }
			set { resultOptr = value; }
		}

		/// <summary>
		/// Gets or sets the ResultValue1 value.
		/// </summary>
		public string ResultValue1
		{
			get { return resultValue1; }
			set { resultValue1 = value; }
		}

		/// <summary>
		/// Gets or sets the Resultvalue2 value.
		/// </summary>
        public string Resultvalue2
		{
			get { return resultvalue2; }
			set { resultvalue2 = value; }
		}

		/// <summary>
		/// Gets or sets the LogicalOperator value.
		/// </summary>
		public string LogicalOperator
		{
			get { return logicalOperator; }
			set { logicalOperator = value; }
		}

        private string resultValue = String.Empty;
        public string ResultValue
        {
            get { return resultValue; }
            set { resultValue = value; }
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
