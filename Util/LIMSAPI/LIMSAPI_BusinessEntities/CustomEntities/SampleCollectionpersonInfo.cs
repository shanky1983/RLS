
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class SampleCollectionpersonInfo
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
        //    public string ClientID { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string RoleName { get; set; }
    }
  
  public class Users
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
        //    public string ClientID { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public List<RoleIn> RoleInfo { get; set; }
    }
    public class RoleIn
    {

        public long RoleID { get; set; }
        public string RoleName { get; set; }
    //    public string LoginID { get; set; }
       public List<DeptIn> DeptInfo { get; set; }
        public List<LocationIn> LocationInfo { get; set; }
    }
        public class Dept

    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

    }


    public class PinCodeList

    {

        public string Pincode { get; set; }

    }

    public class Location
    {
        //public int LocationID { get; set; }
        // public string LocationName { get; set; }

        #region Fields

        private long locationID = 0;
        private string locationName = String.Empty;
        private long pincode = 0;
        private long cityID = 0;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string isDefault = String.Empty;
        private short stateID = 0;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the LocationID value.
        /// </summary>
        public long LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }

        /// <summary>
        /// Gets or sets the LocationName value.
        /// </summary>
        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }

        /// <summary>
        /// Gets or sets the Pincode value.
        /// </summary>
        public long Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        /// <summary>
        /// Gets or sets the CityID value.
        /// </summary>
        public long CityID
        {
            get { return cityID; }
            set { cityID = value; }
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
        /// Gets or sets the IsDefault value.
        /// </summary>
        public string IsDefault
        {
            get { return isDefault; }
            set { isDefault = value; }
        }

        /// <summary>
        /// Gets or sets the StateID value.
        /// </summary>
        public short StateID
        {
            get { return stateID; }
            set { stateID = value; }
        }

        /// <summary>
        /// Gets or sets the StateName value.
        /// </summary>
        private string _stateName = String.Empty;
        public string StateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        /// <summary>
        /// Gets or sets the CityName value.
        /// </summary>
        private string _cityName = String.Empty;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }


        #endregion
    }


    public class Role1
    {
        #region Fields

        private long roleID = 0;
        private string roleName = String.Empty;
        private string description = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long parentID = 0;
        private int orgID = 0;
        private string sortedrole = String.Empty;
        private string langCode = String.Empty;
        private string displayText = String.Empty;

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
        /// Gets or sets the RoleName value.
        /// </summary>
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
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
        /// Gets or sets the ParentID value.
        /// </summary>
        public long ParentID
        {
            get { return parentID; }
            set { parentID = value; }
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
        /// Gets or sets the Sortedrole value.
        /// </summary>
        public string Sortedrole
        {
            get { return sortedrole; }
            set { sortedrole = value; }
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
        /// Gets or sets the DisplayText value.
        /// </summary>
        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }

        /// <summary>
        /// Gets or sets the OrgName value.
        /// </summary>
        private string _orgName = String.Empty;
        public string OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        /// <summary>
        /// Gets or sets the LogoPath value.
        /// </summary>
        private string _logoPath = String.Empty;
        public string LogoPath
        {
            get { return _logoPath; }
            set { _logoPath = value; }
        }

        /// <summary>
        /// Gets or sets the OrgAddressID value.
        /// </summary>
        private long _orgAddressID = 0;
        public long OrgAddressID
        {
            get { return _orgAddressID; }
            set { _orgAddressID = value; }
        }

        /// <summary>
        /// Gets or sets the IntegrationName value.
        /// </summary>
        private string _integrationName = String.Empty;
        public string IntegrationName
        {
            get { return _integrationName; }
            set { _integrationName = value; }
        }

        /// <summary>
        /// Gets or sets the IsDefault value.
        /// </summary>
        private bool _isDefault = false;
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        /// <summary>
        /// Gets or sets the OrgDisplayName value.
        /// </summary>
        private string _orgDisplayName = String.Empty;
        public string OrgDisplayName
        {
            get { return _orgDisplayName; }
            set { _orgDisplayName = value; }
        }

        /// <summary>
        /// Gets or sets the ParentOrgID value.
        /// </summary>
        private int _parentOrgID = 0;
        public int ParentOrgID
        {
            get { return _parentOrgID; }
            set { _parentOrgID = value; }
        }

        /// <summary>
        /// Gets or sets the LoginName value.
        /// </summary>
        private string _loginName = String.Empty;
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        /// <summary>
        /// Gets or sets the OrgTimeZone value.
        /// </summary>
        private string _orgTimeZone = String.Empty;
        public string OrgTimeZone
        {
            get { return _orgTimeZone; }
            set { _orgTimeZone = value; }
        }

        /// <summary>
        /// Gets or sets the OrgDateTimeZone value.
        /// </summary>
        private string _orgDateTimeZone = String.Empty;
        public string OrgDateTimeZone
        {
            get { return _orgDateTimeZone; }
            set { _orgDateTimeZone = value; }
        }

        /// <summary>
        /// Gets or sets the RoleDescription value.
        /// </summary>
        private string _roleDescription = String.Empty;
        public string RoleDescription
        {
            get { return _roleDescription; }
            set { _roleDescription = value; }
        }


        #endregion
    }

    public class MetaDataFormat
    {
        public long MetaDataID { get; set; }
        public string Domain { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string LangName { get; set; }
        public string LangCode { get; set; }

    }




    public class HolidayList

    {
        public long HolidayID { get; set; }
        public string HolidayDate { get; set; }
        public string Description { get; set; }

    }

}
