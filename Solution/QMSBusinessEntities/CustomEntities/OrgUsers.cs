using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class OrgUsers
    {

        #region Fields
        private string titleCode = string.Empty;
        private long loginID = 0;
        private long roleID = 0;
        private long specialityID = 0;
        private string roleName = string.Empty;
        private string specialityName = string.Empty;
        private long orgUID = 0;
        private string name = string.Empty;
        private string sEX = String.Empty;
        private string email = String.Empty;
        private string dOB = String.Empty;
        private string relegion = String.Empty;
        private string weddingDt = String.Empty;
        private string qualification = String.Empty;
        private string maritalStatus = String.Empty;
        

        private long addressID = 0;

        private string add1 = String.Empty;
        private string add2 = String.Empty;
        private string add3 = String.Empty;
        private long countryID = 0;
        private string city = String.Empty;
        private long stateID = 0;
        private string postalCode = String.Empty;
        private string mobileNumber = String.Empty;
        private string landLineNumber = String.Empty;
        private string otherCountryName = String.Empty;
        private string otherStateName = String.Empty;
        private string loginStatus = String.Empty;


        private int countryCode = 0;
        private int stateCode = 0;
        private int cityCode = 0;
        private int addLevel1 = 0;
        private int addLevel2 = 0; 

        #endregion

        #region Properties
        
        /// <summary>
        /// Gets or sets the TitleCode value.
        /// </summary>
        public string TitleCode
        {
            get { return titleCode; }
            set { titleCode = value; }
        }

        /// <summary>
        /// Gets or sets the LoginID value.
        /// </summary>
        public long LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }
        public long SpecialityID
        {
            get { return specialityID; }
            set { specialityID = value; }
        }

        /// <summary>
        /// Gets or sets the RoleID value.
        /// </summary>
        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        /// <summary>
        /// Gets or sets the OrgUID value.
        /// </summary>
        public long OrgUID
        {
            get { return orgUID; }
            set { orgUID = value; }
        }

        /// <summary>
        /// Gets or sets the RoleName value.
        /// </summary>
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
        public string SpecialityName
        {
            get { return specialityName; }
            set { specialityName = value; }
        }
        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the SEX value.
        /// </summary>
        public string SEX
        {
            get { return sEX; }
            set { sEX = value; }
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
        /// Gets or sets the DOB value.
        /// </summary>
        public string DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

        /// <summary>
        /// Gets or sets the Relegion value.
        /// </summary>
        public string Relegion
        {
            get { return relegion; }
            set { relegion = value; }
        }

        /// <summary>
        /// Gets or sets the WeddingDt value.
        /// </summary>
        public string WeddingDt
        {
            get { return weddingDt; }
            set { weddingDt = value; }
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
        /// Gets or sets the MaritalStatus value.
        /// </summary>
        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        /// <summary>
        /// Gets or sets the AddressID value.
        /// </summary>
        public long AddressID
        {
            get { return addressID; }
            set { addressID = value; }
        }

        /// <summary>
        /// Gets or sets the Add1 value.
        /// </summary>
        public string Add1
        {
            get { return add1; }
            set { add1 = value; }
        }

        /// <summary>
        /// Gets or sets the Add2 value.
        /// </summary>
        public string Add2
        {
            get { return add2; }
            set { add2 = value; }
        }

        /// <summary>
        /// Gets or sets the Add3 value.
        /// </summary>
        public string Add3
        {
            get { return add3; }
            set { add3 = value; }
        }

        /// <summary>
        /// Gets or sets the CountryID value.
        /// </summary>
        public long CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }

        /// <summary>
        /// Gets or sets the City value.
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Gets or sets the StateID value.
        /// </summary>
        public long StateID
        {
            get { return stateID; }
            set { stateID = value; }
        }

        /// <summary>
        /// Gets or sets the PostalCode value.
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        /// <summary>
        /// Gets or sets the MobileNumber value.
        /// </summary>
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        /// <summary>
        /// Gets or sets the LandLineNumber value.
        /// </summary>
        public string LandLineNumber
        {
            get { return landLineNumber; }
            set { landLineNumber = value; }
        }
        private string physicianType = String.Empty;
        /// <summary>
        /// Gets or sets the PhysicianType value.
        /// </summary>
        public string PhysicianType
        {
            get { return physicianType; }
            set { physicianType = value; }
        }
        public string OtherStateName
        {
            get { return otherStateName; }
            set { otherStateName = value; }
        }
        public string OtherCountryName
        {
            get { return otherCountryName; }
            set { otherCountryName = value; }
        }

        public string Loginstatus
        {
            get { return loginStatus; }
            set { loginStatus = value; }
        }

        public int CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        public int StateCode
        {
            get { return stateCode; }
            set { stateCode = value; }
        }
        public int CityCode
        {
            get { return cityCode; }
            set { cityCode = value; }
        }
        public int AddLevel1
        {
            get { return addLevel1; }
            set { addLevel1 = value; }
        }

        public int AddLevel2
        {
            get { return addLevel2; }
            set { addLevel2 = value; }
        }
        int _EMPID = 0;
        public int EMPID
        {
            get { return _EMPID; }
            set { _EMPID = value; }
        }
        decimal _dailySalary = Decimal.Zero;
        public decimal DailySalary
        {
            get { return _dailySalary; }
            set { _dailySalary = value; }
        }
        decimal _monthlySalary = Decimal.Zero;
        public decimal MonthlySalary
        {
            get { return _monthlySalary; }
            set { _monthlySalary = value; }
        }
        #endregion
    }
}
