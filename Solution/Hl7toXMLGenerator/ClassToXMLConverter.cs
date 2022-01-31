using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Hl7toXMLGenerator
{
    class ClassToXMLConverter
    {
    }
    public class data
    {
        public List<dataLabDetails> LabDetails = new List<dataLabDetails>();
        public List<dataPatientDetails> PatientDetails = new List<dataPatientDetails>();
        public List<dataPatientAddress> PatientAddress = new List<dataPatientAddress>();
        public List<dataVisitDetails> VisitDetails = new List<dataVisitDetails>();
        public List<dataInvestigationDetails> InvestigationDetails = new List<dataInvestigationDetails>();
       
    }
    public class dataLabDetails
    {
        
        private string orgName = string.Empty;
        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }
        
        private string orgaddressName = string.Empty;
        public string OrgAddressName
        {
            get { return orgaddressName; }
            set { orgaddressName = value; }
        }

    }
    public class dataPatientDetails
    {
        private string patientnumber = string.Empty;
        public string PatientNumber
        {
            get { return patientnumber; }
            set { patientnumber = value; }
        }

        private string age = string.Empty;
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        private string sex = string.Empty;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private DateTime dOB = DateTime.MaxValue;
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

    }

    public class dataPatientAddress
    {
        /// <remarks/>
        private string addresstype = string.Empty;
        public string AddressType
        {
            get { return addresstype; }
            set { addresstype = value; }
        }

        /// <remarks/>
        private string addressline1 = string.Empty;
        public string AddressLine1
        {
            get { return addressline1; }
            set { addressline1 = value; }
        }

        private string addressline2 = string.Empty;
        public string AddressLine2
        {
            get { return addressline2; }
            set { addressline2 = value; }
        }

        private string addressline3 = string.Empty;
        public string AddressLine3
        {
            get { return addressline3; }
            set { addressline3 = value; }
        }

        private string mobileNo = string.Empty;
        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }

        private string landlineno = string.Empty;
        public string LandLineNo
        {
            get { return landlineno; }
            set { landlineno = value; }
        }

        private string city = string.Empty;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string stateID = string.Empty;
        public string StateID
        {
            get { return stateID; }
            set { stateID = value; }
        }
        private string statename = string.Empty;
        public string StateName
        {
            get { return statename; }
            set { statename = value; }
        }



        private string countryiD = string.Empty;
        public string CountryID
        {
            get { return countryiD; }
            set { countryiD = value; }
        }

        private string countryname = string.Empty;
        public string CountryName
        {
            get { return countryname; }
            set { countryname = value; }
        }



    }
    public class dataVisitDetails
    {
        /// <remarks/>
        private string externalvisitID = string.Empty;
        public string ExternalVisitID
        {
            get { return externalvisitID; }
            set { externalvisitID = value; }
        }
        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool Patient_MobilePhoneSpecified;
        /// <remarks/>

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool Patient_SalutationSpecified;
        /// <remarks/>
        private string collectioncentreid = string.Empty;
        public string CollectionCentreID
        {
            get { return collectioncentreid; }
            set { collectioncentreid = value; }
        }

        /// <remarks/>
        private string referingphysicianname = string.Empty;
        public string ReferingPhysicianName
        {
            get { return referingphysicianname; }
            set { referingphysicianname = value; }
        }
        /// <remarks/>
        private string clientcode = string.Empty;
        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }

    }
    public class dataInvestigationDetails
    {
        public List<dataInvestigation> InvestigationList = new List<dataInvestigation>();


    }
    public class dataInvestigation
    {
        private long investigationid = -1;
        public long InvestigationID
        {
            get { return investigationid; }
            set { investigationid = value; }
        }

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type = string.Empty;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
