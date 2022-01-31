using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DepartmentRateCardMapping
	{
		#region Fields

		private int deptRateCardMapID=0;
		private long departmentID=0;
		private string departmentCode=String.Empty;
		private int rateID=0;
		private int orgID=0;
		private string specialityCode=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptRateCardMapID value.
		/// </summary>
		public int DeptRateCardMapID
		{
			get { return deptRateCardMapID; }
			set { deptRateCardMapID = value; }
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
		/// Gets or sets the DepartmentCode value.
		/// </summary>
		public string DepartmentCode
		{
			get { return departmentCode; }
			set { departmentCode = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the SpecialityCode value.
		/// </summary>
		public string SpecialityCode
		{
			get { return specialityCode; }
			set { specialityCode = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
