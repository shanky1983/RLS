using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class NewInstanceCreationTracker
	{
		#region Fields

		private int newInstanceWaitID=0;
		private int waitingList=0;
		private string status=String.Empty;
		private string defaultLoginName=String.Empty;
		private string defaultPassword=String.Empty;
		private int orgID=0;
		private int noofTries=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime completedAt=DateTime.MaxValue;
		private string isApproved=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewInstanceWaitID value.
		/// </summary>
		public int NewInstanceWaitID
		{
			get { return newInstanceWaitID; }
			set { newInstanceWaitID = value; }
		}

		/// <summary>
		/// Gets or sets the WaitingList value.
		/// </summary>
		public int WaitingList
		{
			get { return waitingList; }
			set { waitingList = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultLoginName value.
		/// </summary>
		public string DefaultLoginName
		{
			get { return defaultLoginName; }
			set { defaultLoginName = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultPassword value.
		/// </summary>
		public string DefaultPassword
		{
			get { return defaultPassword; }
			set { defaultPassword = value; }
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
		/// Gets or sets the NoofTries value.
		/// </summary>
		public int NoofTries
		{
			get { return noofTries; }
			set { noofTries = value; }
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
		/// Gets or sets the CompletedAt value.
		/// </summary>
		public DateTime CompletedAt
		{
			get { return completedAt; }
			set { completedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsApproved value.
		/// </summary>
		public string IsApproved
		{
			get { return isApproved; }
			set { isApproved = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the InstanceID value.
		/// </summary>
		private int _instanceID=0;
		public int InstanceID
		{
			get { return  _instanceID; }
			set { _instanceID = value; }
		}

		/// <summary>
		/// Gets or sets the LogoPath value.
		/// </summary>
		private string _logoPath=String.Empty;
		public string LogoPath
		{
			get { return  _logoPath; }
			set { _logoPath = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayName value.
		/// </summary>
		private string _displayName=String.Empty;
		public string DisplayName
		{
			get { return  _displayName; }
			set { _displayName = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyID value.
		/// </summary>
		private int _currencyID=0;
		public int CurrencyID
		{
			get { return  _currencyID; }
			set { _currencyID = value; }
		}

		/// <summary>
		/// Gets or sets the Isdefaultorg value.
		/// </summary>
		private string _isdefaultorg=String.Empty;
		public string Isdefaultorg
		{
			get { return  _isdefaultorg; }
			set { _isdefaultorg = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultOrgID value.
		/// </summary>
		private long _defaultOrgID=0;
		public long DefaultOrgID
		{
			get { return  _defaultOrgID; }
			set { _defaultOrgID = value; }
		}


		#endregion
}
}
