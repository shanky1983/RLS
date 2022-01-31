using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoginFCMMapping
	{
		#region Fields

		private long id=0;
		private long loginID=0;
		private string fCMInstanceId=String.Empty;
		private string deviceId=String.Empty;
		private string appName=String.Empty;
		private string appVersion=String.Empty;
		private bool isLogged=false;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the FCMInstanceId value.
		/// </summary>
		public string FCMInstanceId
		{
			get { return fCMInstanceId; }
			set { fCMInstanceId = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceId value.
		/// </summary>
		public string DeviceId
		{
			get { return deviceId; }
			set { deviceId = value; }
		}

		/// <summary>
		/// Gets or sets the AppName value.
		/// </summary>
		public string AppName
		{
			get { return appName; }
			set { appName = value; }
		}

		/// <summary>
		/// Gets or sets the AppVersion value.
		/// </summary>
		public string AppVersion
		{
			get { return appVersion; }
			set { appVersion = value; }
		}

		/// <summary>
		/// Gets or sets the IsLogged value.
		/// </summary>
		public bool IsLogged
		{
			get { return isLogged; }
			set { isLogged = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
