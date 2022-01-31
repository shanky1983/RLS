using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IntegrationHistory121
	{
		#region Fields

		private long integrationHistoryID=0;
		private string integrationValue=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string externalID=String.Empty;
		private string type=String.Empty;
		private string xMLType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IntegrationHistoryID value.
		/// </summary>
		public long IntegrationHistoryID
		{
			get { return integrationHistoryID; }
			set { integrationHistoryID = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationValue value.
		/// </summary>
		public string IntegrationValue
		{
			get { return integrationValue; }
			set { integrationValue = value; }
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
		/// Gets or sets the ExternalID value.
		/// </summary>
		public string ExternalID
		{
			get { return externalID; }
			set { externalID = value; }
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
		/// Gets or sets the XMLType value.
		/// </summary>
		public string XMLType
		{
			get { return xMLType; }
			set { xMLType = value; }
		}


		#endregion
}
}
