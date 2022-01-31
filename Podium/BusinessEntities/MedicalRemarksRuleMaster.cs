using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class MedicalRemarksRuleMaster
	{
		#region Fields

		private int id=0;
		private int ruleTypeID=0;
		private long investigationID=0;
		private int componentID=0;
		private long crossParameterID=0;
		private string rule=String.Empty;
		private string _operator=String.Empty;
		private long additionalConditionID=0;
		private long orgID=0;
		private long remarksID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
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
		/// Gets or sets the ComponentID value.
		/// </summary>
		public int ComponentID
		{
			get { return componentID; }
			set { componentID = value; }
		}

		/// <summary>
		/// Gets or sets the CrossParameterID value.
		/// </summary>
		public long CrossParameterID
		{
			get { return crossParameterID; }
			set { crossParameterID = value; }
		}

		/// <summary>
		/// Gets or sets the Rule value.
		/// </summary>
		public string Rule
		{
			get { return rule; }
			set { rule = value; }
		}

		/// <summary>
		/// Gets or sets the Operator value.
		/// </summary>
		public string Operator
		{
			get { return _operator; }
			set { _operator = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalConditionID value.
		/// </summary>
		public long AdditionalConditionID
		{
			get { return additionalConditionID; }
			set { additionalConditionID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksID value.
		/// </summary>
		public long RemarksID
		{
			get { return remarksID; }
			set { remarksID = value; }
		}


        private string remarkstext=String.Empty;
        public string RemarksText
        {
            get {return remarkstext;}
            set {remarkstext =value;}
        }

        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private long _accessionnumber;
        public long AccessionNumber
        {
            get { return _accessionnumber; }
            set { _accessionnumber = value; }
        }

        private long _invaccessionnumber;
        public long InvAccessionNumber
        {
            get { return _invaccessionnumber; }
            set { _invaccessionnumber = value; }
        }
        private bool _RemarksCondition = false;
        public bool RemarksCondition
        {
            get { return _RemarksCondition; }
            set { _RemarksCondition = value; }
        }
		#endregion
}
}
