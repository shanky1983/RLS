using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WidgetUserDetails
	{
		#region Fields
        private long roleID = 0;
        private long loginID = 0;
        private string loginName = string.Empty;
        private string roleName = string.Empty;
        private string email = string.Empty;
        private string mobileNumber = string.Empty;
        private string str1 = string.Empty;
        private string str2 = string.Empty;
        private string str3 = string.Empty;
        private string str4 = string.Empty;
        private string str5 = string.Empty;

		#endregion

		#region Properties
        /// <summary>
        /// Gets or sets the RoleID value.
        /// </summary>
        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        /// <summary>
        /// Gets or sets the RoleID value.
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
        /// Gets or sets the RoleName value.
        /// </summary>
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
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
        /// Gets or sets the MobileNumber value.
        /// </summary>
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }
        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        public string Str3
        {
            get { return str3; }
            set { str3 = value; }
        }
        public string Str4
        {
            get { return str4; }
            set { str4 = value; }
        }
        public string Str5
        {
            get { return str5; }
            set { str5 = value; }
        }
		#endregion
}
}
