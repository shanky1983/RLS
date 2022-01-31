using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TaskEntityMap
	{
		#region Fields

		private long taskEntityMapID=0;
		private string mappingType=String.Empty;
		private int mappingID=0;
		private int taskActionID=0;
		private int orgID=0;
		private string isPrimary=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaskEntityMapID value.
		/// </summary>
		public long TaskEntityMapID
		{
			get { return taskEntityMapID; }
			set { taskEntityMapID = value; }
		}

		/// <summary>
		/// Gets or sets the MappingType value.
		/// </summary>
		public string MappingType
		{
			get { return mappingType; }
			set { mappingType = value; }
		}

		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public int MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the TaskActionID value.
		/// </summary>
		public int TaskActionID
		{
			get { return taskActionID; }
			set { taskActionID = value; }
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
		/// Gets or sets the IsPrimary value.
		/// </summary>
		public string IsPrimary
		{
			get { return isPrimary; }
			set { isPrimary = value; }
		}


		#endregion
}
}
