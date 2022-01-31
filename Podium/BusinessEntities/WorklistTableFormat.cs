using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WorklistTableFormat
	{
		#region Fields

		private long id=0;
		private long deptID=0;
		private string formatType=String.Empty;
		private string formatDescription=String.Empty;
		private string testCode=String.Empty;
		private long orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the FormatType value.
		/// </summary>
		public string FormatType
		{
			get { return formatType; }
			set { formatType = value; }
		}

		/// <summary>
		/// Gets or sets the FormatDescription value.
		/// </summary>
		public string FormatDescription
		{
			get { return formatDescription; }
			set { formatDescription = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}


		#endregion
}
}
