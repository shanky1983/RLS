using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Metavalues_vommon
	{
		#region Fields

		private long metaValueID=0;
		private long metaTypeId=0;
		private string valu=String.Empty;
		private string code=String.Empty;
		private int orgID=0;
		private string description=String.Empty;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MetaValueID value.
		/// </summary>
		public long MetaValueID
		{
			get { return metaValueID; }
			set { metaValueID = value; }
		}

		/// <summary>
		/// Gets or sets the MetaTypeId value.
		/// </summary>
		public long MetaTypeId
		{
			get { return metaTypeId; }
			set { metaTypeId = value; }
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
