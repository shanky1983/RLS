using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientAgeGenderRule
	{
		#region Fields

		private int patientAgeGenderRuleId=0;
		private int ruleMasterId=0;
		private string componentName=String.Empty;
		private string gender=String.Empty;
		private string subCategory=String.Empty;
		private string ageType=String.Empty;
		private string ageOptr=String.Empty;
		private int ageValue1=0;
		private int agevalue2=0;
		private string logicalOperator=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientAgeGenderRuleId value.
		/// </summary>
		public int PatientAgeGenderRuleId
		{
			get { return patientAgeGenderRuleId; }
			set { patientAgeGenderRuleId = value; }
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
		/// Gets or sets the Gender value.
		/// </summary>
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the SubCategory value.
		/// </summary>
		public string SubCategory
		{
			get { return subCategory; }
			set { subCategory = value; }
		}

		/// <summary>
		/// Gets or sets the AgeType value.
		/// </summary>
		public string AgeType
		{
			get { return ageType; }
			set { ageType = value; }
		}

		/// <summary>
		/// Gets or sets the AgeOptr value.
		/// </summary>
		public string AgeOptr
		{
			get { return ageOptr; }
			set { ageOptr = value; }
		}

		/// <summary>
		/// Gets or sets the AgeValue1 value.
		/// </summary>
		public int AgeValue1
		{
			get { return ageValue1; }
			set { ageValue1 = value; }
		}

		/// <summary>
		/// Gets or sets the Agevalue2 value.
		/// </summary>
		public int Agevalue2
		{
			get { return agevalue2; }
			set { agevalue2 = value; }
		}

		/// <summary>
		/// Gets or sets the LogicalOperator value.
		/// </summary>
		public string LogicalOperator
		{
			get { return logicalOperator; }
			set { logicalOperator = value; }
		}

        private string gend = String.Empty;
        public string PatientGender
        {
            get { return gend; }
            set { gend = value; }
        }

        private string page = String.Empty;
        public string Age
        {
            get { return page; }
            set { page = value; }
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
