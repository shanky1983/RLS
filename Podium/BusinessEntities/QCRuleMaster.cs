using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class QCRuleMaster
	{
		#region Fields

		private long qCRID=0;
		private long lotId=0;
		private long analyte=0;
		private string manufacturerRefRange=String.Empty;
		private string manufacturerMean=String.Empty;
		private int run=0;
		private string labRefRange=String.Empty;
		private decimal labMean=Decimal.Zero;
		private decimal labSD=Decimal.Zero;
		private string lJChartCalc=String.Empty;
		private long orgId=0;
		private string isActive=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long qCLevelID=0;
		private string qCLevel=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QCRID value.
		/// </summary>
		public long QCRID
		{
			get { return qCRID; }
			set { qCRID = value; }
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
		/// Gets or sets the Analyte value.
		/// </summary>
		public long Analyte
		{
			get { return analyte; }
			set { analyte = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the QCLevelID value.
		/// </summary>
		public long QCLevelID
		{
			get { return qCLevelID; }
			set { qCLevelID = value; }
		}

		/// <summary>
		/// Gets or sets the QCLevel value.
		/// </summary>
		public string QCLevel
		{
			get { return qCLevel; }
			set { qCLevel = value; }
		}


		#endregion
}
}
