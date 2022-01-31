using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Aspnet_Membership
	{
		#region Fields

		private Guid applicationId=Guid.Empty;
		private Guid userId=Guid.Empty;
		private string password=String.Empty;
		private int passwordFormat=0;
		private string passwordSalt=String.Empty;
		private string mobilePIN=String.Empty;
		private string email=String.Empty;
		private string loweredEmail=String.Empty;
		private string passwordQuestion=String.Empty;
		private string passwordAnswer=String.Empty;
		private bool isApproved=false;
		private bool isLockedOut=false;
		private DateTime createDate=DateTime.MaxValue;
		private DateTime lastLoginDate=DateTime.MaxValue;
		private DateTime lastPasswordChangedDate=DateTime.MaxValue;
		private DateTime lastLockoutDate=DateTime.MaxValue;
		private int failedPasswordAttemptCount=0;
		private DateTime failedPasswordAttemptWindowStart=DateTime.MaxValue;
		private int failedPasswordAnswerAttemptCount=0;
		private DateTime failedPasswordAnswerAttemptWindowStart=DateTime.MaxValue;
		private string comment=String.Empty;

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
		/// Gets or sets the Password value.
		/// </summary>
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		/// <summary>
		/// Gets or sets the PasswordFormat value.
		/// </summary>
		public int PasswordFormat
		{
			get { return passwordFormat; }
			set { passwordFormat = value; }
		}

		/// <summary>
		/// Gets or sets the PasswordSalt value.
		/// </summary>
		public string PasswordSalt
		{
			get { return passwordSalt; }
			set { passwordSalt = value; }
		}

		/// <summary>
		/// Gets or sets the MobilePIN value.
		/// </summary>
		public string MobilePIN
		{
			get { return mobilePIN; }
			set { mobilePIN = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the LoweredEmail value.
		/// </summary>
		public string LoweredEmail
		{
			get { return loweredEmail; }
			set { loweredEmail = value; }
		}

		/// <summary>
		/// Gets or sets the PasswordQuestion value.
		/// </summary>
		public string PasswordQuestion
		{
			get { return passwordQuestion; }
			set { passwordQuestion = value; }
		}

		/// <summary>
		/// Gets or sets the PasswordAnswer value.
		/// </summary>
		public string PasswordAnswer
		{
			get { return passwordAnswer; }
			set { passwordAnswer = value; }
		}

		/// <summary>
		/// Gets or sets the IsApproved value.
		/// </summary>
		public bool IsApproved
		{
			get { return isApproved; }
			set { isApproved = value; }
		}

		/// <summary>
		/// Gets or sets the IsLockedOut value.
		/// </summary>
		public bool IsLockedOut
		{
			get { return isLockedOut; }
			set { isLockedOut = value; }
		}

		/// <summary>
		/// Gets or sets the CreateDate value.
		/// </summary>
		public DateTime CreateDate
		{
			get { return createDate; }
			set { createDate = value; }
		}

		/// <summary>
		/// Gets or sets the LastLoginDate value.
		/// </summary>
		public DateTime LastLoginDate
		{
			get { return lastLoginDate; }
			set { lastLoginDate = value; }
		}

		/// <summary>
		/// Gets or sets the LastPasswordChangedDate value.
		/// </summary>
		public DateTime LastPasswordChangedDate
		{
			get { return lastPasswordChangedDate; }
			set { lastPasswordChangedDate = value; }
		}

		/// <summary>
		/// Gets or sets the LastLockoutDate value.
		/// </summary>
		public DateTime LastLockoutDate
		{
			get { return lastLockoutDate; }
			set { lastLockoutDate = value; }
		}

		/// <summary>
		/// Gets or sets the FailedPasswordAttemptCount value.
		/// </summary>
		public int FailedPasswordAttemptCount
		{
			get { return failedPasswordAttemptCount; }
			set { failedPasswordAttemptCount = value; }
		}

		/// <summary>
		/// Gets or sets the FailedPasswordAttemptWindowStart value.
		/// </summary>
		public DateTime FailedPasswordAttemptWindowStart
		{
			get { return failedPasswordAttemptWindowStart; }
			set { failedPasswordAttemptWindowStart = value; }
		}

		/// <summary>
		/// Gets or sets the FailedPasswordAnswerAttemptCount value.
		/// </summary>
		public int FailedPasswordAnswerAttemptCount
		{
			get { return failedPasswordAnswerAttemptCount; }
			set { failedPasswordAnswerAttemptCount = value; }
		}

		/// <summary>
		/// Gets or sets the FailedPasswordAnswerAttemptWindowStart value.
		/// </summary>
		public DateTime FailedPasswordAnswerAttemptWindowStart
		{
			get { return failedPasswordAnswerAttemptWindowStart; }
			set { failedPasswordAnswerAttemptWindowStart = value; }
		}

		/// <summary>
		/// Gets or sets the Comment value.
		/// </summary>
		public string Comment
		{
			get { return comment; }
			set { comment = value; }
		}


		#endregion
}
}
