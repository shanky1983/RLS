using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Runtime.Serialization;

namespace Attune.Podium.BusinessEntities
{
    [DataContract]
    public class InsertAppointment
    {

        private long _resourceTemplateID = 0;
        private long _tokenNumber = 0;
        private string _sTime;
        private int _eTime;
        private string _strdescription;
        private long _scheduleID;
        private long _sPhoneNumber;
        private string _lPatientNumber;
        private string _patientName;
        private int _OrgID;
        private long _iOrgID;
        private long _CreatedBy;
        private long _referalID;
        private long _ParentID;
        private long _bookingStatusId;
        private long _PaymentTypeID;
        private long _age;
        private string _gender;
        private string _city;
        private long _bookingId;
        private long _titlecode;
        private string _email;
        private string _address;
        private int _visitpurpose;
        private string _remarks;
        private string _altmobilenoone;
        private string _altmobilenotwo;

        [DataMember]
        public long iOrgID
        {
            get { return _iOrgID; }
            set { _iOrgID = value; }
        }
        [DataMember]
        public int OrgID
        {
            get { return _OrgID; }
            set { _OrgID = value; }
        }
        [DataMember]
        public long CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        [DataMember]
        public string sTime
        {
            get { return _sTime; }
            set { _sTime = value; }
        }
        [DataMember]
        public int eTime
        {
            get { return _eTime; }
            set { _eTime = value; }
        }
        [DataMember]
        public long resourceTemplateID
        {
            get { return _resourceTemplateID; }
            set { _resourceTemplateID = value; }
        }
        [DataMember]
        public long tokenNumber
        {
            get { return _tokenNumber; }
            set { _tokenNumber = value; }
        }
        [DataMember]
        public string strdescription
        {
            get { return _strdescription; }
            set { _strdescription = value; }
        }
        [DataMember]
        public long scheduleID
        {
            get { return _scheduleID; }
            set { _scheduleID = value; }
        }
        [DataMember]
        public long sPhoneNumber
        {
            get { return _sPhoneNumber; }
            set { _sPhoneNumber = value; }
        }
        [DataMember]
        public string lPatientNumber
        {
            get { return _lPatientNumber; }
            set { _lPatientNumber = value; }
        }
        [DataMember]
        public string patientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        [DataMember]
        public long bookingStatusId
        {
            get { return _bookingStatusId; }
            set { _bookingStatusId = value; }
        }
        [DataMember]
        public long referalID
        {
            get { return _referalID; }
            set { _referalID = value; }
        }
        [DataMember]
        public long ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }
        [DataMember]
        public long PaymentTypeID
        {
            get { return _PaymentTypeID; }
            set { _PaymentTypeID = value; }
        }
        [DataMember]
        public long age
        {
            get { return _age; }
            set { _age = value; }
        }
        [DataMember]
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [DataMember]
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
        [DataMember]
        public long bookingId
        {
            get { return _bookingId; }
            set { _bookingId = value; }
        }
        [DataMember]
        public long titlecode
        {
            get { return _titlecode; }
            set { _titlecode = value; }
        }
        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        [DataMember]
        public int visitpurpose
        {
            get
            {
                return _visitpurpose;
            }
            set
            {
                _visitpurpose = value;
            }
        }
        [DataMember]
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        [DataMember]
        public string altmobilenoone
        {
            get { return _altmobilenoone; }
            set { _altmobilenoone = value; }
        }
        [DataMember]
        public string altmobilenotwo
        {
            get { return _altmobilenotwo; }
            set { _altmobilenotwo = value; }
        }
    }
}
