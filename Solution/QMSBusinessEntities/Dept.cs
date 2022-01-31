using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Dept
	{
		#region Fields

		private float deptID=0.0F;
		private string deptName=String.Empty;
		private float orgID=0.0F;
		private string display=String.Empty;
		private float sequenceNo=0.0F;
		private float deptCode=0.0F;
		private string code=String.Empty;
		private string type=String.Empty;
		private string codetype=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public float DeptID
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public float OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public float SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the DeptCode value.
		/// </summary>
		public float DeptCode
		{
			get { return deptCode; }
			set { deptCode = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Codetype value.
		/// </summary>
		public string Codetype
		{
			get { return codetype; }
			set { codetype = value; }
		}


		#endregion
}
}
