using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProcedureMasterSub
	{
		#region Fields

		private long runningID=0;
		private long procMainID=0;
		private long orgID=0;
		private string isVisitPurpose=String.Empty;
		private string procDesc=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RunningID value.
		/// </summary>
		public long RunningID
		{
			get { return runningID; }
			set { runningID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcMainID value.
		/// </summary>
		public long ProcMainID
		{
			get { return procMainID; }
			set { procMainID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsVisitPurpose value.
		/// </summary>
		public string IsVisitPurpose
		{
			get { return isVisitPurpose; }
			set { isVisitPurpose = value; }
		}

		/// <summary>
		/// Gets or sets the ProcDesc value.
		/// </summary>
		public string ProcDesc
		{
			get { return procDesc; }
			set { procDesc = value; }
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


		#endregion
}
}
