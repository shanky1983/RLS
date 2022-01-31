using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EODDeptAmount
	{
		#region Fields

		private string deptName=String.Empty;
		private long amount=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public long Amount
		{
			get { return amount; }
			set { amount = value; }
		}


		#endregion
}
}
