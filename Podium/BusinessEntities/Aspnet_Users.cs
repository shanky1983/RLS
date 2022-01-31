using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_Users
	{
		#region Fields

		private Guid applicationId=Guid.Empty;
		private Guid userId=Guid.Empty;
		private string userName=String.Empty;
		private string loweredUserName=String.Empty;
		private string mobileAlias=String.Empty;
		private bool isAnonymous=false;
		private DateTime lastActivityDate=DateTime.MaxValue;

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
		/// Gets or sets the UserId value.
		/// </summary>
		public Guid UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		/// <summary>
		/// Gets or sets the LoweredUserName value.
		/// </summary>
		public string LoweredUserName
		{
			get { return loweredUserName; }
			set { loweredUserName = value; }
		}

		/// <summary>
		/// Gets or sets the MobileAlias value.
		/// </summary>
		public string MobileAlias
		{
			get { return mobileAlias; }
			set { mobileAlias = value; }
		}

		/// <summary>
		/// Gets or sets the IsAnonymous value.
		/// </summary>
		public bool IsAnonymous
		{
			get { return isAnonymous; }
			set { isAnonymous = value; }
		}

		/// <summary>
		/// Gets or sets the LastActivityDate value.
		/// </summary>
		public DateTime LastActivityDate
		{
			get { return lastActivityDate; }
			set { lastActivityDate = value; }
		}


		#endregion
}
}
