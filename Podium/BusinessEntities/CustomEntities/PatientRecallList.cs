
using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientRecallList
    {
        private string _Name;
        private string _EMail;
        private string _MobileNumber;
        private string _URNO;
        private long _PhysicianID;
        private string _PhysicianName;
        private string _actual_review_date;

        private long _patientvisitid;

        private long _ComplaintID;
        private long _OrderTaskID;

        private long _PatientID;
        private long _BookingStatusId;

        private string _BookingTime;
        public long BookingStatusId
        {
            get { return _BookingStatusId; }
            set { _BookingStatusId = value; }
        }

        public string BookingTime
        {
            get { return _BookingTime; }
            set { _BookingTime = value; }
        }


        public long PatientVisitId
        {
            get { return _patientvisitid; }
            set { _patientvisitid = value; }
        }


        public long ComplaintID
        {
            get { return _ComplaintID; }
            set { _ComplaintID = value; }
        }



        public long PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public long OrderTaskID
        {
            get { return _OrderTaskID; }
            set { _OrderTaskID = value; }
        }



        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public long PhysicianID
        {
            get { return _PhysicianID; }
            set { _PhysicianID = value; }
        }


        public string PhysicianName
        {
            get { return _PhysicianName; }
            set { _PhysicianName = value; }
        }

        public string actual_review_date
        {
            get { return _actual_review_date; }
            set { _actual_review_date = value; }
        }

        public string EMail
        {
            get { return _EMail; }
            set { _EMail = value; }
        }
        public string MobileNumber
        {
            get { return _MobileNumber; }
            set { _MobileNumber = value; }
        }
        public string URNO
        {
            get { return _URNO; }
            set { _URNO = value; }
        }

    }
}
