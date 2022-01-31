using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvRuleMaster
	{
		#region Fields

		private int ruleMasterId=0;
		private int ruleTypeID=0;
		private long investigationID=0;
        private string investigationName=String.Empty;
		private int postTriggerFunctionId=0;
		private string postTriggerFunction=String.Empty;
		private string invRemarksValue=String.Empty;
        private int orgId = 0;
        private string invtype = String.Empty;
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RuleMasterId value.
		/// </summary>
		public int RuleMasterId
		{
			get { return ruleMasterId; }
			set { ruleMasterId = value; }
		}

		/// <summary>
		/// Gets or sets the RuleTypeID value.
		/// </summary>
		public int RuleTypeID
		{
			get { return ruleTypeID; }
			set { ruleTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

        /// <summary>
        /// Gets or sets the InvestigationName value.
        /// </summary>
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }

		/// <summary>
		/// Gets or sets the PostTriggerFunctionId value.
		/// </summary>
		public int PostTriggerFunctionId
		{
			get { return postTriggerFunctionId; }
			set { postTriggerFunctionId = value; }
		}

		/// <summary>
		/// Gets or sets the PostTriggerFunction value.
		/// </summary>
		public string PostTriggerFunction
		{
			get { return postTriggerFunction; }
			set { postTriggerFunction = value; }
		}

		/// <summary>
		/// Gets or sets the InvRemarksValue value.
		/// </summary>
		public string InvRemarksValue
		{
			get { return invRemarksValue; }
			set { invRemarksValue = value; }
		}


        public int OrgId
        {
            get { return orgId; }
            set { orgId = value; }
        }

        private string code = String.Empty;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string InvType
        {
            get { return invtype; }
            set { invtype = value; }
        }

        private string componentName = String.Empty;
         public string ComponentName
        {
            get { return componentName; }
            set { componentName = value; }
        }

         private int remarksId = 0;
         public int RemarksId
         {
             get { return remarksId; }
             set { remarksId = value; }
         }

         private string condition = String.Empty;
         public string Condition
         {
             get { return condition; }
             set { condition = value; }
         }
		#endregion
}
}
