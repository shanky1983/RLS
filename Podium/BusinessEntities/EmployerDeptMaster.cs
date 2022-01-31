using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EmployerDeptMaster
	{
		#region Fields

		private long empDeptID=0;
		private string empDeptName=String.Empty;
		private int orgID=0;
		private string empDeptText=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string code=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmpDeptID value.
		/// </summary>
		public long EmpDeptID
		{
			get { return empDeptID; }
			set { empDeptID = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptName value.
		/// </summary>
		public string EmpDeptName
		{
			get { return empDeptName; }
			set { empDeptName = value; }
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
		/// Gets or sets the EmpDeptText value.
		/// </summary>
		public string EmpDeptText
		{
			get { return empDeptText; }
			set { empDeptText = value; }
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
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}


		#endregion
}
}
