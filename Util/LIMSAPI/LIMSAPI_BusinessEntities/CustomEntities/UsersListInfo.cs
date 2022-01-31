using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class UsersListInfo
    {
        public int OrgID { get; set; }
        public string Type { get; set; }
        public long RoleID { get; set; }
        public int LocationID { get; set; }
        public long UserID { get; set; }
        public string TitleName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string LoginID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string EmailID { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ClientID { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string RoleName { get; set; }
        public string ServerName { get; set; }
        public string URL { get; set; }
        public string LoginPwd { get; set; }
    }

    public class UsersList
    {
        public long UserID { get; set; }
        public string TitleName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string LoginID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string EmailID { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        //   public string ClientID { get; set; }
        //     public long RoleID { get; set; }

        public string ServerName { get; set; }
        public string URL { get; set; }
        public string LoginPwd { get; set; }
        public List<RoleInfo> RoleInfo { get; set; }

    }
    public class RoleLogin   {

        public string LoginID { get; set; }
        public string LoginName { get; set; }
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }

    public class RoleInfo
    {

        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public List<DeptIn> DeptInfo { get; set; }
        public List<LocationIn> LocationInfo { get; set; }
    }

    public class DeptIn

    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

    }

    public class RoleDeptIn

    {
        public string LoginID { get; set; }
        public long RoleID { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Status { get; set; }

    }
    public class LocationIn
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
    }
    public class RoleLocationIn
    {
        public long LoginID { get; set; }
        public long RoleID { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string DeptName { get; set; }
        public string Comments { get; set; }
        public long OrgID { get; set;}
    }
}
