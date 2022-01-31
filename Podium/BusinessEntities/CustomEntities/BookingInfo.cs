using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BookingInfo
    {
        #region Fields
        private DateTime dateofBirth = DateTime.MaxValue;
        private DateTime bookingDTTM = DateTime.MaxValue;
        private DateTime sampleCollectionTime = DateTime.MaxValue;
        private DateTime followUpDTTM = DateTime.MaxValue;
        private DateTime collectionTime = DateTime.MaxValue;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long bookingID = 0;
        private string age = String.Empty;
        private string gender = String.Empty;
        private string address = String.Empty;
      

        #endregion

        #region Property
        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        private string firstName = String.Empty;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string middleName = String.Empty;
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        private string lastName = String.Empty;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string salutation = String.Empty;
        public string Salutation
        {
            get { return salutation; }
            set { salutation = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
      
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }
       
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string mobileNumber = String.Empty;
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        private string email = String.Empty;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string city = String.Empty;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state = String.Empty;
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string country = String.Empty;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string postalCode = String.Empty;
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        private string clientCode = String.Empty;
        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }
        private string uRNType = String.Empty;
        public string URNType
        {
            get { return uRNType; }
            set { uRNType = value; }
        }
        private string uRNNo = String.Empty;
        public string URNNo
        {
            get { return uRNNo; }
            set { uRNNo = value; }
        }
        private string tRFFile = String.Empty;
        public string TRFFile
        {
            get { return tRFFile; }
            set { tRFFile = value; }
        }
        private string dispatchType = String.Empty;
        public string DispatchType
        {
            get { return dispatchType; }
            set { dispatchType = value; }
        }
        public DateTime BookingDTTM
        {
            get { return bookingDTTM; }
            set { bookingDTTM = value; }
        }
        private long sampleID = 0;
        public long SampleID
        {
            get { return sampleID; }
            set { sampleID = value; }
        }
        private string sampleName = String.Empty;
        public string SampleName
        {
            get { return sampleName; }
            set { sampleName = value; }
        }
        private long containerID = 0;
        public long ContainerID
        {
            get { return containerID; }
            set { containerID = value; }
        }
        private string containerName = String.Empty;
        public string ContainerName
        {
            get { return containerName; }
            set { containerName = value; }
        }
        private string sampleContainerColour = String.Empty;
        public string SampleContainerColour
        {
            get { return sampleContainerColour; }
            set { sampleContainerColour = value; }
        }
        public DateTime SampleCollectionTime {
            get { return sampleCollectionTime; }
            set { sampleCollectionTime = value; }
        }
        private string sampleStatus = String.Empty;
        public string SampleStatus
        {
            get { return sampleStatus; }
            set { sampleStatus = value; }
        }
        private string reason = String.Empty;
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        private string followUpTest = String.Empty;
        public string FollowUpTest
        {
            get { return followUpTest; }
            set { followUpTest = value; }
        }
        public DateTime FollowUpDTTM
        {
            get { return followUpDTTM; }
            set { followUpDTTM = value; }
        }
        private string testCode = String.Empty;
        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }
        private string testName = String.Empty;
        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }
        private decimal price = decimal.Zero;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        private decimal totalGrossAmount = decimal.Zero;
        public decimal TotalGrossAmount
        {
            get { return totalGrossAmount; }
            set { totalGrossAmount = value; }
        }
        private decimal discountAmount = decimal.Zero;
        public decimal DiscountAmount
        {
            get { return discountAmount; }
            set { discountAmount = value; }
        }
        private decimal netAmount = decimal.Zero;
        public decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }
        private decimal receivedAmount = decimal.Zero;
        public decimal ReceivedAmount
        {
            get { return receivedAmount; }
            set { receivedAmount = value; }
        }
        private decimal dueAmount = decimal.Zero;
        public decimal DueAmount
        {
            get { return dueAmount; }
            set { dueAmount = value; }
        }
        private string paymentStatus = String.Empty;
        public string PaymentStatus
        {
            get { return paymentStatus; }
            set { paymentStatus = value; }
        }
        private string paymentMode = String.Empty;
        public string PaymentMode
        {
            get { return paymentMode; }
            set { paymentMode = value; }
        }
        private string cardDetails = String.Empty;
        public string CardDetails
        {
            get { return cardDetails; }
            set { cardDetails = value; }
        }
        private string referenceNo = String.Empty;
        public string ReferenceNo
        {
            get { return referenceNo; }
            set { referenceNo = value; }
        }
        private long inventoryCount = 0;
        public long InventoryCount
        {
            get { return inventoryCount; }
            set { inventoryCount = value; }
        }
        private string inventoryDetails = String.Empty;
        public string InventoryDetails
        {
            get { return inventoryDetails; }
            set { inventoryDetails = value; }
        }
        //    public decimal TotalAmount { get; set; }
        //  public string ExternalVisitID { get; set; }
        private long orgID = 0;
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        private long locationID = 0;
        public long LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        private long userID = 0;
        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string status = String.Empty;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string clientID = String.Empty;
        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        private string createdBy = String.Empty;
        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        private string modifiedBy = String.Empty;
        public string ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }
        private string iSProcessed = String.Empty;
        public string ISProcessed
        {
            get { return iSProcessed; }
            set { iSProcessed = value; }
        }
        //public string Source { get; set; }
        private string error = String.Empty;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        private string remarks = String.Empty;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        private string name = String.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private long patientID = 0;
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        private string externalPatientNumber = String.Empty;
        public string ExternalPatientNumber
        {
            get { return externalPatientNumber; }
            set { externalPatientNumber = value; }
        }
        public DateTime CollectionTime {
            get { return collectionTime; }
            set { collectionTime = value; }
        }
        private string orderedFrom = String.Empty;
        public string OrderedFrom
        {
            get { return orderedFrom; }
            set { orderedFrom = value; }
        }
        private long cardNumber = 0;
        public long CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        private string currencyType = String.Empty;
        public string CurrencyType
        {
            get { return currencyType; }
            set { currencyType = value; }
        }
        private string jsonValue = String.Empty;
        public string JsonValue
        {
            get { return jsonValue; }
            set { jsonValue = value; }
        }
        private long cityID = 0;
        public long CityID
        {
            get { return cityID; }
            set { cityID = value; }
        }
        private long stateID = 0;
        public long StateID
        {
            get { return stateID; }
            set { stateID = value; }
        }
        private long countryID = 0;
        public long CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }
        private long loginID = 0;
        public long LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }
        private string addressType = String.Empty;
        public string AddressType
        {
            get { return addressType; }
            set { addressType = value; }
        }
        private string type = String.Empty;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion
    }
}
