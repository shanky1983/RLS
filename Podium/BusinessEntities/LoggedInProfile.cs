using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoggedInProfile
	{
		#region Fields

		private long loginID=0;
		private int orgID=0;
		private int orgAddressID=0;
		private string iPAddress=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long iD=0;
		private string browserName=String.Empty;
		private string browserversion=String.Empty;
		private string oS=String.Empty;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long loggedInUsersID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IPAddress value.
		/// </summary>
		public string IPAddress
		{
			get { return iPAddress; }
			set { iPAddress = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the BrowserName value.
		/// </summary>
		public string BrowserName
		{
			get { return browserName; }
			set { browserName = value; }
		}

		/// <summary>
		/// Gets or sets the Browserversion value.
		/// </summary>
		public string Browserversion
		{
			get { return browserversion; }
			set { browserversion = value; }
		}

		/// <summary>
		/// Gets or sets the OS value.
		/// </summary>
		public string OS
		{
			get { return oS; }
			set { oS = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the LoggedInUsersID value.
		/// </summary>
		public long LoggedInUsersID
		{
			get { return loggedInUsersID; }
			set { loggedInUsersID = value; }
		}


		#endregion
}
}
