using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Login_patient
	{
		#region Fields

		private long loginID=0;
		private string loginName=String.Empty;
		private string password=String.Empty;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private string isLocked=String.Empty;
		private string hasUserChangedPassword=String.Empty;
		private int passwordChangeCount=0;
		private DateTime lastPasswordModifiedDTTM=DateTime.MaxValue;
		private int noOfFailureAttempts=0;
		private int orgID=0;
		private string secretAnswer=String.Empty;
		private string secretQuestion=String.Empty;
		private DateTime lastAccessedDTTM=DateTime.MaxValue;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string filePath=String.Empty;
		private byte[] imageSource=new byte[0];
		private int themeID=0;
		private string isFirstLogin=String.Empty;
		private string transactionpasssword=String.Empty;
		private DateTime loginPwdExpDate=DateTime.MaxValue;
		private DateTime transPwdExpDate=DateTime.MaxValue;
		private DateTime blockedFrom=DateTime.MaxValue;
		private DateTime blockedTo=DateTime.MaxValue;
		private string blockReason=String.Empty;
		private string trans_USER_CODE=String.Empty;
		private string taskNotification=String.Empty;
		private bool isInstanceCreated=false;

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
		/// Gets or sets the LoginName value.
		/// </summary>
		public string LoginName
		{
			get { return loginName; }
			set { loginName = value; }
		}

		/// <summary>
		/// Gets or sets the Password value.
		/// </summary>
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		public DateTime StartDTTM
		{
			get { return startDTTM; }
			set { startDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		public DateTime EndDTTM
		{
			get { return endDTTM; }
			set { endDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the IsLocked value.
		/// </summary>
		public string IsLocked
		{
			get { return isLocked; }
			set { isLocked = value; }
		}

		/// <summary>
		/// Gets or sets the HasUserChangedPassword value.
		/// </summary>
		public string HasUserChangedPassword
		{
			get { return hasUserChangedPassword; }
			set { hasUserChangedPassword = value; }
		}

		/// <summary>
		/// Gets or sets the PasswordChangeCount value.
		/// </summary>
		public int PasswordChangeCount
		{
			get { return passwordChangeCount; }
			set { passwordChangeCount = value; }
		}

		/// <summary>
		/// Gets or sets the LastPasswordModifiedDTTM value.
		/// </summary>
		public DateTime LastPasswordModifiedDTTM
		{
			get { return lastPasswordModifiedDTTM; }
			set { lastPasswordModifiedDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfFailureAttempts value.
		/// </summary>
		public int NoOfFailureAttempts
		{
			get { return noOfFailureAttempts; }
			set { noOfFailureAttempts = value; }
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
		/// Gets or sets the SecretAnswer value.
		/// </summary>
		public string SecretAnswer
		{
			get { return secretAnswer; }
			set { secretAnswer = value; }
		}

		/// <summary>
		/// Gets or sets the SecretQuestion value.
		/// </summary>
		public string SecretQuestion
		{
			get { return secretQuestion; }
			set { secretQuestion = value; }
		}

		/// <summary>
		/// Gets or sets the LastAccessedDTTM value.
		/// </summary>
		public DateTime LastAccessedDTTM
		{
			get { return lastAccessedDTTM; }
			set { lastAccessedDTTM = value; }
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

		/// <summary>
		/// Gets or sets the FilePath value.
		/// </summary>
		public string FilePath
		{
			get { return filePath; }
			set { filePath = value; }
		}

		/// <summary>
		/// Gets or sets the ImageSource value.
		/// </summary>
		public byte[] ImageSource
		{
			get { return imageSource; }
			set { imageSource = value; }
		}

		/// <summary>
		/// Gets or sets the ThemeID value.
		/// </summary>
		public int ThemeID
		{
			get { return themeID; }
			set { themeID = value; }
		}

		/// <summary>
		/// Gets or sets the IsFirstLogin value.
		/// </summary>
		public string IsFirstLogin
		{
			get { return isFirstLogin; }
			set { isFirstLogin = value; }
		}

		/// <summary>
		/// Gets or sets the Transactionpasssword value.
		/// </summary>
		public string Transactionpasssword
		{
			get { return transactionpasssword; }
			set { transactionpasssword = value; }
		}

		/// <summary>
		/// Gets or sets the LoginPwdExpDate value.
		/// </summary>
		public DateTime LoginPwdExpDate
		{
			get { return loginPwdExpDate; }
			set { loginPwdExpDate = value; }
		}

		/// <summary>
		/// Gets or sets the TransPwdExpDate value.
		/// </summary>
		public DateTime TransPwdExpDate
		{
			get { return transPwdExpDate; }
			set { transPwdExpDate = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedFrom value.
		/// </summary>
		public DateTime BlockedFrom
		{
			get { return blockedFrom; }
			set { blockedFrom = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedTo value.
		/// </summary>
		public DateTime BlockedTo
		{
			get { return blockedTo; }
			set { blockedTo = value; }
		}

		/// <summary>
		/// Gets or sets the BlockReason value.
		/// </summary>
		public string BlockReason
		{
			get { return blockReason; }
			set { blockReason = value; }
		}

		/// <summary>
		/// Gets or sets the Trans_USER_CODE value.
		/// </summary>
		public string Trans_USER_CODE
		{
			get { return trans_USER_CODE; }
			set { trans_USER_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the TaskNotification value.
		/// </summary>
		public string TaskNotification
		{
			get { return taskNotification; }
			set { taskNotification = value; }
		}

		/// <summary>
		/// Gets or sets the IsInstanceCreated value.
		/// </summary>
		public bool IsInstanceCreated
		{
			get { return isInstanceCreated; }
			set { isInstanceCreated = value; }
		}


		#endregion
}
}
