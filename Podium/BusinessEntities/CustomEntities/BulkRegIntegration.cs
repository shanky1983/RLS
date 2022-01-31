using System;
using System.Collections.Generic; 
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BulkRegIntegration
    {
        #region Fields
        private long _NotificationID = 0;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private DateTime _dob = DateTime.MaxValue;
        private string _gender = string.Empty;
        private string _phoneNumber = string.Empty;
        private string _externalPatientId = string.Empty;
        private string _emailid = string.Empty;
        private string _relation = string.Empty;
        private string _healthHubId = string.Empty;
        private string _visitId = string.Empty;
        private DateTime _visitDate = DateTime.MaxValue;
        private string _location = string.Empty;

        private string _ErrorDescription = string.Empty;
        private string _Status = string.Empty;

        private string template = String.Empty;
        private string attachmentName = String.Empty;

        #endregion

        #region Properties
        public long NotificationID
        {
            get { return _NotificationID; }
            set { _NotificationID = value; }
        }
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string externalPatientId
        {
            get { return _externalPatientId; }
            set { _externalPatientId = value; }
        }
        public string emailid
        {
            get { return _emailid; }
            set { _emailid = value; }
        }
        public string relation
        {
            get { return _relation; }
            set { _relation = value; }
        }
        public string healthHubId
        {
            get { return _healthHubId; }
            set { _healthHubId = value; }
        }
        public string visitId
        {
            get { return _visitId; }
            set { _visitId = value; }
        }
        public DateTime visitDate
        {
            get { return _visitDate; }
            set { _visitDate = value; }
        }
        public string location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string ErrorDescription
        {
            get { return _ErrorDescription; }
            set { _ErrorDescription = value; }
        }

        public string Template
        {
            get { return template; }
            set { template = value; }
        }
        public string AttachmentName
        {
            get { return attachmentName; }
            set { attachmentName = value; }
        }
        private string _bookingNo = string.Empty;
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private string _labAddress = string.Empty;
        public string labAddress
        {
            get { return _labAddress; }
            set { _labAddress = value; }
        }
        private string _OrgCode = string.Empty;
        public string OrgCode
        {
            get { return _OrgCode; }
            set { _OrgCode = value; }
        }
        public List<BulkRegFileDetails> lstFile { get; set; }
        #endregion

    }
}
