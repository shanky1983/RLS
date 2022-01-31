using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CommunicationConfigEmailAlert
	{
		#region Fields

		private int iD=0;
		private string notificationType=String.Empty;
		private string notificationCategory=String.Empty;
		private string valu=String.Empty;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifedAt=DateTime.MaxValue;
		private long modifedBy=0;
		private DateTime mSRNUM=DateTime.Now;
		private string langCode=String.Empty;
		private string emailType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationType value.
		/// </summary>
		public string NotificationType
		{
			get { return notificationType; }
			set { notificationType = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationCategory value.
		/// </summary>
		public string NotificationCategory
		{
			get { return notificationCategory; }
			set { notificationCategory = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the ModifedAt value.
		/// </summary>
		public DateTime ModifedAt
		{
			get { return modifedAt; }
			set { modifedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifedBy value.
		/// </summary>
		public long ModifedBy
		{
			get { return modifedBy; }
			set { modifedBy = value; }
		}

		/// <summary>
		/// Gets or sets the MSRNUM value.
		/// </summary>
		public DateTime MSRNUM
		{
			get { return mSRNUM; }
			set { mSRNUM = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the EmailType value.
		/// </summary>
		public string EmailType
		{
			get { return emailType; }
			set { emailType = value; }
		}


		#endregion
}
}
