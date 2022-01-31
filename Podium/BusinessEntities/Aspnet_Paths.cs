using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_Paths
	{
		#region Fields

		private Guid applicationId=Guid.Empty;
		private Guid pathId=Guid.Empty;
		private string path=String.Empty;
		private string loweredPath=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ApplicationId value.
		/// </summary>
		public Guid ApplicationId
		{
			get { return applicationId; }
			set { applicationId = value; }
		}

		/// <summary>
		/// Gets or sets the PathId value.
		/// </summary>
		public Guid PathId
		{
			get { return pathId; }
			set { pathId = value; }
		}

		/// <summary>
		/// Gets or sets the Path value.
		/// </summary>
		public string Path
		{
			get { return path; }
			set { path = value; }
		}

		/// <summary>
		/// Gets or sets the LoweredPath value.
		/// </summary>
		public string LoweredPath
		{
			get { return loweredPath; }
			set { loweredPath = value; }
		}


		#endregion
}
}
