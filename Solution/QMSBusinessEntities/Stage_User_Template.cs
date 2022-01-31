using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Stage_User_Template
	{
		#region Fields

		private string loginName =String.Empty;
		private string userName =String.Empty;
		private string surName =String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string sex =String.Empty;
		private string email =String.Empty;
		private string salutation =String.Empty;
		private string status =String.Empty;
		private string maritalStatus =String.Empty;
		private string flag=String.Empty;
		private string qualification=String.Empty;
		private string role=String.Empty;
		private string encryptedPassword=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		public string LoginName
		{
			get { return loginName; }
			set { loginName = value; }
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
		/// Gets or sets the SurName value.
		/// </summary>
		public string SurName
		{
			get { return surName; }
			set { surName = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public DateTime DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		public string Sex
		{
			get { return sex; }
			set { sex = value; }
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
		/// Gets or sets the Salutation value.
		/// </summary>
		public string Salutation
		{
			get { return salutation; }
			set { salutation = value; }
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
		/// Gets or sets the MaritalStatus value.
		/// </summary>
		public string MaritalStatus
		{
			get { return maritalStatus; }
			set { maritalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Flag value.
		/// </summary>
		public string Flag
		{
			get { return flag; }
			set { flag = value; }
		}

		/// <summary>
		/// Gets or sets the Qualification value.
		/// </summary>
		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
		}

		/// <summary>
		/// Gets or sets the Role value.
		/// </summary>
		public string Role
		{
			get { return role; }
			set { role = value; }
		}

		/// <summary>
		/// Gets or sets the EncryptedPassword value.
		/// </summary>
		public string EncryptedPassword
		{
			get { return encryptedPassword; }
			set { encryptedPassword = value; }
		}


		#endregion
}
}
