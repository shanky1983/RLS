using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_PersonalizationAllUsers
	{
		#region Fields

		private Guid pathId=Guid.Empty;
		private byte[] pageSettings=new byte[0];
		private DateTime lastUpdatedDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PathId value.
		/// </summary>
		public Guid PathId
		{
			get { return pathId; }
			set { pathId = value; }
		}

		/// <summary>
		/// Gets or sets the PageSettings value.
		/// </summary>
		public byte[] PageSettings
		{
			get { return pageSettings; }
			set { pageSettings = value; }
		}

		/// <summary>
		/// Gets or sets the LastUpdatedDate value.
		/// </summary>
		public DateTime LastUpdatedDate
		{
			get { return lastUpdatedDate; }
			set { lastUpdatedDate = value; }
		}


		#endregion
}
}
