using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GroupValue
	{
		#region Fields

		private long groupValueID=0;
		private long groupTypeId=0;
		private string valu=String.Empty;
		private string code=String.Empty;
		private int orgID=0;
		private string description=String.Empty;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GroupValueID value.
		/// </summary>
		public long GroupValueID
		{
			get { return groupValueID; }
			set { groupValueID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupTypeId value.
		/// </summary>
		public long GroupTypeId
		{
			get { return groupTypeId; }
			set { groupTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
