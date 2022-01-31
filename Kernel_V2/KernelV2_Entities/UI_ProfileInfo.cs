using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_ProfileInfo
    {
        public UI_Login UserProfile { get; set; }
        public List<UI_Organization> Organization { get; set; }
        public List<UI_Role> Role { get; set; }
        public List<UI_Location> Location { get; set; }
        public List<UI_InvLocation> InvLocation { get; set; }
        public List<UI_Department> Department { get; set; }
    }
    public class UI_Login
    {
        public string Name { get; set; }
        public string PhotoName { get; set; }
        public string PhotoPath { get; set; }
        public string RoleDescription { get; set; }
        public string OrgDisplayName { get; set; }
        public string LocationName { get; set; }
        public string LogoPath { get; set; }
    }
    
    public class UI_Role
    {
        public int OrgID { get; set; }
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public long SelectedRoleID { get; set; }
    }

    public class UI_Location
    {
        public int OrgID { get; set; }
        public long RoleID { get; set; }
        public long AddressID { get; set; }
        public string Location { get; set; }
        public long SelectedAddressID { get; set; }
    }

    public class UI_InvLocation
    {
        public int OrgAddressID { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int LocationTypeID { get; set; }
        public bool IsDefault { get; set; }
    }
    public class UI_Profile
    {
        public int OrgID { get; set; }
        public long RoleID { get; set; }
        public long AddressID { get; set; }
    }

    public class MenuClass
    {
        public List<UI_Alacarte> lstMenu { get; set; }
        public List<UI_InventoryPageMap> lstInvPageMap { get; set; }
    }

}
