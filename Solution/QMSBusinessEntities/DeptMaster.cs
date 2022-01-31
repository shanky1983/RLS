using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DeptMaster
	{
		#region Fields

		private long deptCode=0;
		private string deptName=String.Empty;
		private string code=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptCode value.
		/// </summary>
		public long DeptCode
		{
			get { return deptCode; }
			set { deptCode = value; }
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
