using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Bk_sep23_InvestigationMethod
	{
		#region Fields

		private int methodID=0;
		private string methodName=String.Empty;
		private long femaleLowerLimit=0;
		private long femaleUpperLimit=0;
		private long maleLowerLimit=0;
		private long maleUpperLimit=0;
		private string severity=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MethodID value.
		/// </summary>
		public int MethodID
		{
			get { return methodID; }
			set { methodID = value; }
		}

		/// <summary>
		/// Gets or sets the MethodName value.
		/// </summary>
		public string MethodName
		{
			get { return methodName; }
			set { methodName = value; }
		}

		/// <summary>
		/// Gets or sets the FemaleLowerLimit value.
		/// </summary>
		public long FemaleLowerLimit
		{
			get { return femaleLowerLimit; }
			set { femaleLowerLimit = value; }
		}

		/// <summary>
		/// Gets or sets the FemaleUpperLimit value.
		/// </summary>
		public long FemaleUpperLimit
		{
			get { return femaleUpperLimit; }
			set { femaleUpperLimit = value; }
		}

		/// <summary>
		/// Gets or sets the MaleLowerLimit value.
		/// </summary>
		public long MaleLowerLimit
		{
			get { return maleLowerLimit; }
			set { maleLowerLimit = value; }
		}

		/// <summary>
		/// Gets or sets the MaleUpperLimit value.
		/// </summary>
		public long MaleUpperLimit
		{
			get { return maleUpperLimit; }
			set { maleUpperLimit = value; }
		}

		/// <summary>
		/// Gets or sets the Severity value.
		/// </summary>
		public string Severity
		{
			get { return severity; }
			set { severity = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
