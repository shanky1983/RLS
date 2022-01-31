using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class pGetBookingsForAppointments
    {
        private long _BookingID;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private long _TokenNumber;
        private long _Description;
        private long _ScheduleID;
        private string _BookingStatus;
        private long _PatientNumber;
        private string _PatientName;
        private long _PhoneNumber;
        private string _CancelRemarks;
        private long _OrgID;
        private long _BookingOrgID;
        private long _PatientID;
        private string _SEX;
        private long _Age;

        public long BookingID
        {
            get { return _BookingID; }
            set { _BookingID = value; }
        }
        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        public DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }
        public long TokenNumber
        {
            get { return _TokenNumber; }
            set { _TokenNumber = value; }
        }
        public long Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public long ScheduleID
        {
            get { return _ScheduleID; }
            set { _ScheduleID = value; }
        }
        public string BookingStatus
        {
            get { return _BookingStatus; }
            set { _BookingStatus = value; }
        }
        public long PatientNumber
        {
            get { return _PatientNumber; }
            set { _PatientNumber = value; }
        }
        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }
        public long PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public string CancelRemarks
        {
            get { return _CancelRemarks; }
            set { _CancelRemarks = value; }
        }
        public long OrgID
        {
            get { return _OrgID; }
            set { _OrgID = value; }
        }
        public long BookingOrgID
        {
            get { return _BookingOrgID; }
            set { _BookingOrgID = value; }
        }
        public long PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        public string SEX
        {
            get { return _SEX; }
            set { _SEX = value; }
        }
        public long Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
    }
}
