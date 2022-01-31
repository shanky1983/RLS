using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DependentInvestigation
	{
		#region Fields

		private long dID=0;
		private long groupID=0;
		private long investigationID=0;
		private long dependentInvestigationID=0;
		private int orgID=0;
		private string dependentType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DID value.
		/// </summary>
		public long DID
		{
			get { return dID; }
			set { dID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public long GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the DependentInvestigationID value.
		/// </summary>
		public long DependentInvestigationID
		{
			get { return dependentInvestigationID; }
			set { dependentInvestigationID = value; }
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
		/// Gets or sets the DependentType value.
		/// </summary>
		public string DependentType
		{
			get { return dependentType; }
			set { dependentType = value; }
		}


		#endregion
}
}
