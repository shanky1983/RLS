using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_Applications
	{
		#region Fields

		private string applicationName=String.Empty;
		private string loweredApplicationName=String.Empty;
		private Guid applicationId=Guid.Empty;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ApplicationName value.
		/// </summary>
		public string ApplicationName
		{
			get { return applicationName; }
			set { applicationName = value; }
		}

		/// <summary>
		/// Gets or sets the LoweredApplicationName value.
		/// </summary>
		public string LoweredApplicationName
		{
			get { return loweredApplicationName; }
			set { loweredApplicationName = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationId value.
		/// </summary>
		public Guid ApplicationId
		{
			get { return applicationId; }
			set { applicationId = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}


		#endregion
}
}
