using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;


namespace Attune.KernelV2
{
    public class IntegrationPartnerDetails
    {

        public int PartnerID { get; set; }
        public string Secret { get; set; }
        public string Name { get; set; }
        public int ApplicationType { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public string AllowedOrigin { get; set; }
        [Key]
        [Required]
        public string AppName { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        public string PartnerType { get; set; }
    }
    public class login
    {
        public long loginID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public DateTime? StartDTTM { get; set; }
        public DateTime? EndDTTM { get; set; }
        public string IsLocked { get; set; }
        public string HasUserChangedPassword { get; set; }
        public int? PasswordChangeCount { get; set; }
        public DateTime? LastPasswordModifiedDTTM { get; set; }
        public int? NoOfFailureAttempts { get; set; }
        public int? OrgID { get; set; }
        public string SecretAnswer { get; set; }
        public string SecretQuestion { get; set; }
        public DateTime? LastAccessedDTTM { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string FilePath { get; set; }
        public byte[] ImageSource { get; set; }
        public string IsFirstLogin { get; set; }
        public int? ThemeID { get; set; }
        public string Transactionpasssword { get; set; }
        public DateTime? LoginPwdExpDate { get; set; }
        public DateTime? TransPwdExpDate { get; set; }
        public DateTime? BlockedFrom { get; set; }
        public DateTime? BlockedTo { get; set; }
        public string BlockReason { get; set; }
        public string TaskNotification { get; set; }
        public int? RepliedMsgDaysConfig { get; set; }
        public bool IsInstanceCreated { get; set; }
    }
    public class LoggedInUsers
    {
        public long LoginID { get; set; }
        public string IsLogged { get; set; }
        public DateTime CreatedAt { get; set; }
        public string SessionID { get; set; }
        public int? RoleID { get; set; }
        public int? DeptID { get; set; }
        public long ID { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public int? InventoryLocationID { get; set; }
        public string isAccessChanged { get; set; }
        public Guid? UniqueKey { get; set; }
        public int? OrgID { get; set; }
        public string LoginName { get; set; }
        public string LoginType { get; set; }
        public int OrgAddressID { get; set; }
    }




    public class VendorMaster
    {
        [Key]
        public int VendorID { get; set; }
        [Required]
        public string VendorName { get; set; }
        public string Status { get; set; }
        public string PartnerType { get; set; }

    }
    public class IntegrationTypeMaster
    {
        [Key]
        public int IntegrationTypeID { get; set; }
        [Required]
        public string IntegrationTypeName { get; set; }
        public string IntegrationTypeCode { get; set; }
        public bool Status { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }

    }
    public class VendorOrgMapping
    {
        [Key]
        public int VendorMappingID { get; set; }
        public int VendorID { get; set; }
        public string OrgName { get; set; }
        public long AttuneOrgID { get; set; }
        public long? VendorOrgID { get; set; }
        public string IntegrationTypeCode { get; set; }
        public string AppName { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public string AllowedOrigin { get; set; }
        public Guid UniqueKey { get; set; }
        public bool Status { get; set; }
        public int? SessionTokenLifeTime { get; set; }
        [NotMapped]
        public string PartnerType { get; set; }
        public bool RequiredRefreshToken { get; set; }
        public Guid AttGuId { get; set; }
        public string RoleName { get; set; }

    }
    public class VendorLocationMpping
    {
        public string LocationName { get; set; }
        public Guid AttLocationId { get; set; }

    }


    public class VendorOrgAddressMapping
    {
        [Key]
        public long MappingID { get; set; }
        public long? VendorID { get; set; }
        public long? AttuneOrgAddressID { get; set; }
        public long? VendorOrgAddressID { get; set; }
        public bool? Status { get; set; }
        public long? LoginID { get; set; }
        public int? RoleID { get; set; }
        public long? LocationID { get; set; }
        public int? InvLocationID { get; set; }

        public Guid AttGuId { get; set; }

    }

    public class LocationUserMap
    {
        public long LocationUserMapID { get; set; }
        public long LoginID { get; set; }
        public int LocationID { get; set; }
        public int OrgAddressID { get; set; }
        public int OrgID { get; set; }
        public string IsActive { get; set; }
        public string IsDefault { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }

    public class LoginRole
    {
        public long? RoleID { get; set; }
        public long? LoginID { get; set; }
        public DateTime? StartDTTM { get; set; }
        public DateTime? EndDTTM { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDefault { get; set; }
        public long LoginRoleID { get; set; }
    }

    public class LoggedInProfile
    {
        [Key]
        public long ID { get; set; }
        public long? LoginID { get; set; }
        public int? OrgID { get; set; }
        public int? OrgAddressID { get; set; }
        public string IPAddress { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string BrowserName { get; set; }
        public string Browserversion { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public string OS { get; set; }
        public long? LoggedInUsersID { get; set; }
     
    }

    public class Role
    {
        [Key]
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public long? ParentID { get; set; }
        public int? OrgID { get; set; }
        public string DisplayText { get; set; }
        public string LangCode { get; set; }
        public string RoleCode { get; set; }
    }

    public class organization
    {
        [Key]
        public int OrgID { get; set; }
        public string Name { get; set; }
        public int? OrganizationTypeID { get; set; }
        public int? AddressID { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public string LogoPath { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string IntegrationName { get; set; }
        public string OrgDisplayName { get; set; }
        public int? ParentOrgID { get; set; }
        public int? RootOrgID { get; set; }
        public string ReferType { get; set; }
        public long? ReferTypeID { get; set; }
        public string OrgCode { get; set; }
        public long? CentreCode { get; set; }
        public string TimeZone { get; set; }
        public int? OrgCategoryID { get; set; }
        public int? InvParentOrgID { get; set; }
        public string IsBaseorg { get; set; }
        public TimeSpan? TimeDifference { get; set; }
   
    }

    public class organizationAddress
    {
        [Key]
        public long AddressID { get; set; }
        public int OrgID { get; set; }
        public string AddressType { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string PostalCode { get; set; }
        public long? CountryID { get; set; }
        public string City { get; set; }
        public long? StateID { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public DateTime? StartDTTM { get; set; }
        public DateTime? EndDTTM { get; set; }
        public string Comments { get; set; }
        public string Location { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Status { get; set; }
        public string OtherCountryName { get; set; }
        public string OtherStateName { get; set; }
        public string LocationCode { get; set; }
        public string ReferType { get; set; }
        public long? ReferTypeID { get; set; }
        public string IsDefault { get; set; }
        public string CenterTypeCode { get; set; }
        public string CityCode { get; set; }
        public int? CutOffTimeValue { get; set; }
        public string CutOffTimeType { get; set; }
        public int? AddLevel1 { get; set; }
        public int? AddLevel2 { get; set; }
        public TimeSpan? TimeDifference { get; set; }
        public string TimeZone { get; set; }
        public string TimeFormat { get; set; }
        public string DateFormat { get; set; }
        public string HasHealthcoupon { get; set; }
    }
    public class ApiResponse
    {
        public string status { get; set; }
        public object response { get; set; }
        // public string ErrorMessage { get; set; }
        public ApiResponse(HttpStatusCode statusco, object data = null)
        {
            status = statusco.ToString();
            response = data;
        }
    }
}