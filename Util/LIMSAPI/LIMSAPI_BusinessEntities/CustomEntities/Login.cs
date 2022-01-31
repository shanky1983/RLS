using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
	public class Login
	{
		public long LoginID { get; set; }
		public string LoginName { get; set; }
		public string Password { get; set; }
		public string IsLocked { get; set; }
		public long OrgID { get; set; }
		public string Status { get; set; }
		public DateTime BlockedFrom { get; set; }
		public DateTime BlockedTo { get; set; }
		public string BlockReason { get; set; }
		public string IsExpired { get; set; }
		public string Token { get; set; }
		public string OrganizationDisplayName { get; set; }
		public string OrganizationName { get; set; }
		public string OrgCode { get; set; }
		

	}

	public class LoginOrgRoles
	{
		public long RoleID { get; set; }
		public string RoleName { get; set; }
		public string Description { get; set; }
		public long OrgID { get; set; }
		public string OrgName { get; set; }
		public string OrgDisplayName { get; set; }
		public string LogoPath { get; set; }
		public int IsDefault { get; set; }
	}
	public class LoginUserAccessDetail
    {
		public Login LoginInfo { get; set; }
		public List<LoginOrgRoles> RoleInfoList { get; set; }
    }
	
}
