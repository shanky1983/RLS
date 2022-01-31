using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AnalyteMaster
	{
		#region Fields

		private long investigationid=0;
		private long departmentID=0;
		private long contatinerID=0;
		private string resultValueType=String.Empty;
		private long sampleID=0;
		private string decimalPlaces=String.Empty;
		private long methodID=0;
		private long princlipleID=0;
		private string classification=String.Empty;
		private string isNABL=String.Empty;
		private string isActive=String.Empty;
		private long orgId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int cutOffTimeValue=0;
		private string cutOffTimeType=String.Empty;
		private long iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public long Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the DepartmentID value.
		/// </summary>
		public long DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}

		/// <summary>
		/// Gets or sets the ContatinerID value.
		/// </summary>
		public long ContatinerID
		{
			get { return contatinerID; }
			set { contatinerID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultValueType value.
		/// </summary>
		public string ResultValueType
		{
			get { return resultValueType; }
			set { resultValueType = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public long SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the DecimalPlaces value.
		/// </summary>
		public string DecimalPlaces
		{
			get { return decimalPlaces; }
			set { decimalPlaces = value; }
		}

		/// <summary>
		/// Gets or sets the MethodID value.
		/// </summary>
		public long MethodID
		{
			get { return methodID; }
			set { methodID = value; }
		}

		/// <summary>
		/// Gets or sets the PrinclipleID value.
		/// </summary>
		public long PrinclipleID
		{
			get { return princlipleID; }
			set { princlipleID = value; }
		}

		/// <summary>
		/// Gets or sets the Classification value.
		/// </summary>
		public string Classification
		{
			get { return classification; }
			set { classification = value; }
		}

		/// <summary>
		/// Gets or sets the IsNABL value.
		/// </summary>
		public string IsNABL
		{
			get { return isNABL; }
			set { isNABL = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the CutOffTimeValue value.
		/// </summary>
		public int CutOffTimeValue
		{
			get { return cutOffTimeValue; }
			set { cutOffTimeValue = value; }
		}

		/// <summary>
		/// Gets or sets the CutOffTimeType value.
		/// </summary>
		public string CutOffTimeType
		{
			get { return cutOffTimeType; }
			set { cutOffTimeType = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
