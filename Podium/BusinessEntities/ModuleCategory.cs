using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ModuleCategory
	{
		#region Fields

		private int moduleID=0;
		private string moduleName=String.Empty;
		private string moduleCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ModuleID value.
		/// </summary>
		public int ModuleID
		{
			get { return moduleID; }
			set { moduleID = value; }
		}

		/// <summary>
		/// Gets or sets the ModuleName value.
		/// </summary>
		public string ModuleName
		{
			get { return moduleName; }
			set { moduleName = value; }
		}

		/// <summary>
		/// Gets or sets the ModuleCode value.
		/// </summary>
		public string ModuleCode
		{
			get { return moduleCode; }
			set { moduleCode = value; }
		}


		#endregion
}
}
