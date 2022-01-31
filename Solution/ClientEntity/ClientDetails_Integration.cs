using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.ClientEntity
{
    public class ClientDetails_Integration
    {

        #region Fields
        
        private string clientcode = String.Empty;
        private string clientname = String.Empty;
        private int orgid = 0;
        private int clientType = 0;
        private long customerType = 0;
        private string countryCode = String.Empty;
        private string stateCode = String.Empty;
        private string emailID = String.Empty;
        private string phoneNo = String.Empty;
        private string mobileNo = String.Empty;
        private string addressDetails = String.Empty;
        private string city = String.Empty;
        private string iscash = String.Empty;
        
        #endregion


        #region Properties


        
        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public int OrgId
        {
            get { return orgid; }
            set { orgid = value; }
        }
        public int ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }
        public long CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }
        public string StateCode
        {
            get { return stateCode; }
            set { stateCode = value; }
        }
        public string EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
        public string AddressDetails
        {
            get { return addressDetails; }
            set { addressDetails = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        #endregion
        public string ISCash
        {
            get { return iscash; }
            set { iscash = value; }
        }
    }
}

