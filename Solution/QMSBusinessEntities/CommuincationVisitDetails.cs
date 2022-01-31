using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CommuincationVisitDetails
	{
		#region Fields

		private long commVisitID=0;
		private long commID=0;
		private long visitID=0;
		private long orgID=0;
		private DateTime createdAT=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CommVisitID value.
		/// </summary>
		public long CommVisitID
		{
			get { return commVisitID; }
			set { commVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the CommID value.
		/// </summary>
		public long CommID
		{
			get { return commID; }
			set { commID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the CreatedAT value.
		/// </summary>
		public DateTime CreatedAT
		{
			get { return createdAT; }
			set { createdAT = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}


		#endregion
}
}
