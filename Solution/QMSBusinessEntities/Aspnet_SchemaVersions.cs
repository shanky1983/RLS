using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Aspnet_SchemaVersions
	{
		#region Fields

		private string feature=String.Empty;
		private string compatibleSchemaVersion=String.Empty;
		private bool isCurrentVersion=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Feature value.
		/// </summary>
		public string Feature
		{
			get { return feature; }
			set { feature = value; }
		}

		/// <summary>
		/// Gets or sets the CompatibleSchemaVersion value.
		/// </summary>
		public string CompatibleSchemaVersion
		{
			get { return compatibleSchemaVersion; }
			set { compatibleSchemaVersion = value; }
		}

		/// <summary>
		/// Gets or sets the IsCurrentVersion value.
		/// </summary>
		public bool IsCurrentVersion
		{
			get { return isCurrentVersion; }
			set { isCurrentVersion = value; }
		}


		#endregion
}
}
