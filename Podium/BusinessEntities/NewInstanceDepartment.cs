using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class NewInstanceDepartment
	{
		#region Fields

		private int newInstanceWaitID=0;
		private string deptID=String.Empty;
		private string deptName=String.Empty;
		private string defaultOrgID=String.Empty;
		private string newOrgID=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewInstanceWaitID value.
		/// </summary>
		public int NewInstanceWaitID
		{
			get { return newInstanceWaitID; }
			set { newInstanceWaitID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public string DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultOrgID value.
		/// </summary>
		public string DefaultOrgID
		{
			get { return defaultOrgID; }
			set { defaultOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the NewOrgID value.
		/// </summary>
		public string NewOrgID
		{
			get { return newOrgID; }
			set { newOrgID = value; }
		}


		#endregion
}
}
