using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Attune.Solution.QMSBusinessEntities
{
    public class TSPClientDetails
    {
        #region Fields

        private long clientID = 0;
        private string clientCode = String.Empty;
        private string clientName = String.Empty;
        private string contactPerson = String.Empty;
        private string panNo = String.Empty;
        private string clientStatus = String.Empty;
        private int orgID = 0;
        private long addressID = 0;
        private string addressType = String.Empty;
        private string add1 = String.Empty;
        private string add2 = String.Empty;
        private string add3 = String.Empty;
        private long postalCode = 0;
        private int countryID = 0;
        private string city = String.Empty;
        private int stateID = 0;
        private string contactName = String.Empty;
        private string mobileNumber = String.Empty;
        private string landLineNumber = String.Empty;
        private string email = String.Empty;
        private string emd = String.Empty;
        

        
       
        #endregion
        #region Properties

        public string EMD
        {
            get { return emd; }
            set { emd = value; }
        }
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

   
        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }

   
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

    
        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }
        public string PanNo
        {
            get { return panNo; }
            set { panNo = value; }
        }
        public string ClientStatus
        {
            get { return clientStatus; }
            set { clientStatus = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public long AddressID
        {
            get { return addressID; }
            set { addressID = value; }
        }

 
        public string AddressType
        {
            get { return addressType; }
            set { addressType = value; }
        }


        public string Add1
        {
            get { return add1; }
            set { add1 = value; }
        }

        public string Add2
        {
            get { return add2; }
            set { add2 = value; }
        }

        
        public string Add3
        {
            get { return add3; }
            set { add3 = value; }
        }

        
        public long PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        
        public int CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }

   
        public string City
        {
            get { return city; }
            set { city = value; }
        }

       
        public int StateID
        {
            get { return stateID; }
            set { stateID = value; }
        }

        
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        
        public string LandLineNumber
        {
            get { return landLineNumber; }
            set { landLineNumber = value; }
        }

        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        #endregion
    }

}
