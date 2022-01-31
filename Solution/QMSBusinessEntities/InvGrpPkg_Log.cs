using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvGrpPkg_Log
	{
		#region Fields

		private long logID=0;
		private long orgID=0;
		private long locationID=0;
		private string locationName=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string testType=String.Empty;
		private string uploadedFilename=String.Empty;
		private long createdBy=0;
		private string username=String.Empty;
		private string uploadedStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LogID value.
		/// </summary>
		public long LogID
		{
			get { return logID; }
			set { logID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		public string LocationName
		{
			get { return locationName; }
			set { locationName = value; }
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
		/// Gets or sets the TestType value.
		/// </summary>
		public string TestType
		{
			get { return testType; }
			set { testType = value; }
		}

		/// <summary>
		/// Gets or sets the UploadedFilename value.
		/// </summary>
		public string UploadedFilename
		{
			get { return uploadedFilename; }
			set { uploadedFilename = value; }
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
		/// Gets or sets the Username value.
		/// </summary>
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		/// <summary>
		/// Gets or sets the UploadedStatus value.
		/// </summary>
		public string UploadedStatus
		{
			get { return uploadedStatus; }
			set { uploadedStatus = value; }
		}


		#endregion
}
}
