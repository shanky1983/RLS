using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MetaType_Common
	{
		#region Fields

		private long metaTypeId=0;
		private string typeName=String.Empty;
		private string description=String.Empty;
		private string code=String.Empty;
		private int orgID=0;
		private string isActive=String.Empty;
		private string systemLevel=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MetaTypeId value.
		/// </summary>
		public long MetaTypeId
		{
			get { return metaTypeId; }
			set { metaTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		public string TypeName
		{
			get { return typeName; }
			set { typeName = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the SystemLevel value.
		/// </summary>
		public string SystemLevel
		{
			get { return systemLevel; }
			set { systemLevel = value; }
		}


		#endregion
}
}
