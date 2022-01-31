using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientCommunicationDetLastVisitDet
    {
        private string _lastvisitdate;
        private string _nextreviewdate;
        private string _reviewedby;
        private string _lastbookedby;
        private string _dueamount;
        private string _billingmode;
        private string _lastadvisedinstruction;
        private string _patientname;
        private string _patientaddress;
        private string _email;
        private string _location;
        private string _mobilenumber;
        private long _patientid;
        private long _age;
        private string _sex;
        private long _orgId;
        private long _titleCode;
        private string _altmobilenoone;
        private string _altmobilenotwo;

        public string LastVisitDate
        {
            get            {                return _lastvisitdate;            }
            set            {                _lastvisitdate = value;            }
        }
        public string NextReviewDate
        {
            get { return _nextreviewdate; }
            set { _nextreviewdate = value; }
        }
        public string ReviewedBy
        {
            get { return _reviewedby; }
            set { _reviewedby = value; }
        }
        public string LastBookedBy
        {
            get
            {
                return _lastbookedby;
            }
            set { _lastbookedby = value; }
        }
        public string DueAmount {
            get { return _dueamount; }
            set { _dueamount = value; }
        }
        public string BillingMode
        {
            get { return _billingmode; }
            set { _billingmode = value; }
        }
        public string LastAdvisedInstruction
        {
            get { return _lastadvisedinstruction; }
            set { _lastadvisedinstruction = value; }
        }
        public string PatientName
        {
            get
            {
                return _patientname;
            }
            set
            {
                _patientname = value;
            }
        }
        public string PatientAddress {
            get { return _patientaddress; }
            set { _patientaddress = value; }
        }
        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public string MobileNumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; }
        }
        public long patientid
        {
            get { return _patientid; }
            set { _patientid = value; }
        }
        public long AGE
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public long OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }
        public long TitleCode
        {
            get { return _titleCode; }
            set { _titleCode = value; }
        }
        public string Altmobilenoone
        {
            get { return _altmobilenoone; }
            set { _altmobilenoone = value; }
        }
        public string Altmobilenotwo
        {
            get { return _altmobilenotwo; }
            set { _altmobilenotwo = value; }
        }
    }
}
