using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Stage2_MHL_T_02_RATE_MASTER
	{
		#region Fields

		private long sNO=0;
		private int orgID=0;
		private string testCode=String.Empty;
		private string testType=String.Empty;
		private string testName=String.Empty;
		private string rateName=String.Empty;
		private decimal rate=Decimal.Zero;
		private string flag=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SNO value.
		/// </summary>
		public long SNO
		{
			get { return sNO; }
			set { sNO = value; }
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
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the TestType value.
		/// </summary>
		public string TestType
		{
			get { return testType; }
			set { testType = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		public string RateName
		{
			get { return rateName; }
			set { rateName = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		/// <summary>
		/// Gets or sets the Flag value.
		/// </summary>
		public string Flag
		{
			get { return flag; }
			set { flag = value; }
		}
        //arun changes
        private decimal labShareAmount = Decimal.Zero;
        public decimal LabShareAmount
        {
            get { return labShareAmount; }
            set { labShareAmount = value; }
        }
        private decimal franchiseeShareAmount = Decimal.Zero;
        public decimal FranchiseeShareAmount
        {
            get { return franchiseeShareAmount; }
            set { franchiseeShareAmount = value; }
        }
        //
		#endregion
}
}
