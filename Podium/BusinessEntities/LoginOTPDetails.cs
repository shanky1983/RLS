using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoginOTPDetails
	{
		#region Fields

		private long oTPDetailsID=0;
		private long loginID=0;
		private string oTP=String.Empty;
		private string oTPMode=String.Empty;
		private string oTPModeValue=String.Empty;
		private DateTime expiredAt=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool isActive=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OTPDetailsID value.
		/// </summary>
		public long OTPDetailsID
		{
			get { return oTPDetailsID; }
			set { oTPDetailsID = value; }
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
		/// Gets or sets the OTP value.
		/// </summary>
		public string OTP
		{
			get { return oTP; }
			set { oTP = value; }
		}

		/// <summary>
		/// Gets or sets the OTPMode value.
		/// </summary>
		public string OTPMode
		{
			get { return oTPMode; }
			set { oTPMode = value; }
		}

		/// <summary>
		/// Gets or sets the OTPModeValue value.
		/// </summary>
		public string OTPModeValue
		{
			get { return oTPModeValue; }
			set { oTPModeValue = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiredAt value.
		/// </summary>
		public DateTime ExpiredAt
		{
			get { return expiredAt; }
			set { expiredAt = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
