using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class QCRuleMaster
	{
		#region Fields

        private long qcrId = 0;
        private long orgId = 0;
		private long lotId=0;
		private string lotName=String.Empty;
		private string lotCode=String.Empty;
		private string level=String.Empty;
		private long levelId=0;
		private string levelCode=String.Empty;
		private long levelTypeId=0;
		private long analyteId=0;
		private string analyteName=String.Empty;
		private string manufacturerRefRange=String.Empty;
		private string manufacturerMean=String.Empty;
		private int run=0;
        private string labRefRange = String.Empty;
		private decimal labMean=Decimal.Zero;
		private decimal labSD=Decimal.Zero;
		private string lJChartCalc=String.Empty;
		private string descriptions=String.Empty;
		private string actions=String.Empty;
		private long createdby=0;
        private string createdAt = String.Empty;
		private long modifiedby=0;
        private string modifiedAt = String.Empty;

		#endregion

		#region Properties
        /// <summary>
        /// Gets or sets the LotId value.
        /// </summary>
        public long QCRID
        {
            get { return qcrId; }
            set { qcrId = value; }
        }

        /// <summary>
        /// Gets or sets the OrgId value.
        /// </summary>
        public long OrgId
        {
            get { return orgId; }
            set { orgId = value; }
        }
		/// <summary>
		/// Gets or sets the LotId value.
		/// </summary>
		public long LotId
		{
			get { return lotId; }
			set { lotId = value; }
		}

		/// <summary>
		/// Gets or sets the LotName value.
		/// </summary>
		public string LotName
		{
			get { return lotName; }
			set { lotName = value; }
		}

		/// <summary>
		/// Gets or sets the LotCode value.
		/// </summary>
		public string LotCode
		{
			get { return lotCode; }
			set { lotCode = value; }
		}

		/// <summary>
		/// Gets or sets the Level value.
		/// </summary>
		public string Level
		{
			get { return level; }
			set { level = value; }
		}

		/// <summary>
		/// Gets or sets the LevelId value.
		/// </summary>
		public long LevelId
		{
			get { return levelId; }
			set { levelId = value; }
		}

		/// <summary>
		/// Gets or sets the LevelCode value.
		/// </summary>
		public string LevelCode
		{
			get { return levelCode; }
			set { levelCode = value; }
		}

		/// <summary>
		/// Gets or sets the LevelTypeId value.
		/// </summary>
		public long LevelTypeId
		{
			get { return levelTypeId; }
			set { levelTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the AnalyteId value.
		/// </summary>
		public long AnalyteId
		{
			get { return analyteId; }
			set { analyteId = value; }
		}

		/// <summary>
		/// Gets or sets the AnalyteName value.
		/// </summary>
		public string AnalyteName
		{
			get { return analyteName; }
			set { analyteName = value; }
		}

		/// <summary>
		/// Gets or sets the ManufacturerRefRange value.
		/// </summary>
		public string ManufacturerRefRange
		{
			get { return manufacturerRefRange; }
			set { manufacturerRefRange = value; }
		}

		/// <summary>
		/// Gets or sets the ManufacturerMean value.
		/// </summary>
		public string ManufacturerMean
		{
			get { return manufacturerMean; }
			set { manufacturerMean = value; }
		}

		/// <summary>
		/// Gets or sets the Run value.
		/// </summary>
		public int Run
		{
			get { return run; }
			set { run = value; }
		}

		/// <summary>
		/// Gets or sets the LabRefRange value.
		/// </summary>
		public string LabRefRange
		{
			get { return labRefRange; }
			set { labRefRange = value; }
		}

		/// <summary>
		/// Gets or sets the LabMean value.
		/// </summary>
		public decimal LabMean
		{
			get { return labMean; }
			set { labMean = value; }
		}

		/// <summary>
		/// Gets or sets the LabSD value.
		/// </summary>
		public decimal LabSD
		{
			get { return labSD; }
			set { labSD = value; }
		}

		/// <summary>
		/// Gets or sets the LJChartCalc value.
		/// </summary>
		public string LJChartCalc
		{
			get { return lJChartCalc; }
			set { lJChartCalc = value; }
		}

		/// <summary>
		/// Gets or sets the Descriptions value.
		/// </summary>
		public string Descriptions
		{
			get { return descriptions; }
			set { descriptions = value; }
		}

		/// <summary>
		/// Gets or sets the Actions value.
		/// </summary>
		public string Actions
		{
			get { return actions; }
			set { actions = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
        public string CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the Modifyiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the ModifyiedAt value.
		/// </summary>
        public string ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
