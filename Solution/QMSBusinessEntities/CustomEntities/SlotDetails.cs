using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class SlotDetails
    {
        DateTime nextOccurance=DateTime.MaxValue;
        long PhyID;
        long totalSlots;
        long Open;
        long booked;
        long waiting;
        string PhysicianName;
        int slotNumber = 0;
        string _BookingStatus;
        string _DoctorBlock;
        TimeSpan startTime = TimeSpan.MinValue;
        //TimeSpan startTime = TimeSpan.MinValue;
        TimeSpan endTime = TimeSpan.MinValue;
        string slotDesc = string.Empty;
        string slotAttributes = string.Empty;
        string phoneNumber = string.Empty;
        string patientName = string.Empty;
        int icurorgID = 0;
        int ibookOrgID = 0;
        string patientNumber = string.Empty;
        long bookingID = 0;
        long patientID = 0;

        long resourceTemplateID = 0;
        long scheduleID = 0;
        int tokenNo = 0;
        string _sdttime;
        string _edttime;
        int _bookedWaiting;
        string _blockReason;
        int bookingstatusid;
        public string sdttime
        {
            get
            {
                return _sdttime;
            }
            set
            {
                _sdttime = value;
            }
        }
        public string edttime
        {
            get
            {
                return _edttime;
            }
            set
            {
                _edttime = value;
            }
        }
        public DateTime NextOccurance
        {
            get { return nextOccurance; }
            set { nextOccurance = value; }
        }

        public TimeSpan StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private DateTime _slotDate = DateTime.MaxValue;

        public DateTime SlotDate
        {
            get
            {
                if (_slotDate == DateTime.MinValue)
                {
                    _slotDate = _slotDate.AddYears(1900);
                }
                return _slotDate;
            }
            set { _slotDate = value; }
        }

        private DateTime _scheduleDate = DateTime.MaxValue;
        public DateTime ScheduleDate
        {
            get
            {
                if (_scheduleDate == DateTime.MinValue)
                {
                    _scheduleDate = _scheduleDate.AddYears(1900);
                }
                return _scheduleDate;
            }
            set { _scheduleDate = value; }
        }

        public long phyID
        {
            get { return PhyID; }
            set { PhyID = value; }
        }

        public string physicianName
        {
            get { return PhysicianName; }
            set { PhysicianName = value; }
        }

        public long open
        {
            get { return Open; }
            set { Open = value; }
        }

        public long Booked
        {
            get { return booked; }
            set { booked = value; }
        }

        public long Waiting
        {
            get { return waiting; }
            set { waiting = value; }
        }

        public long TotalSlots
        {
            get { return totalSlots; }
            set { totalSlots = value; }
        }

        public string BookingStatus
        {
            get { return _BookingStatus; }
            set { _BookingStatus = value; }
        }

        public string DoctorBlock
        {
            get { return _DoctorBlock; }
            set { _DoctorBlock = value; }
        }

        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public int SlotNumber
        {
            get { return slotNumber; }
            set { slotNumber = value; }
        }

        public TimeSpan EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public string SlotDescription
        {
            get { return slotDesc; }
            set { slotDesc = value; }
        }
        public string SlotAttributes
        {
            get { return slotAttributes; }
            set { slotAttributes = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public int UcurorgID
        {
            get { return icurorgID; }
            set { icurorgID = value; }
        }
        public int IbookOrgID
        {
            get { return ibookOrgID; }
            set { ibookOrgID = value; }
        }
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public long ResourceTemplateID
        {
            get { return resourceTemplateID; }
            set { resourceTemplateID = value; }
        }

        public long ScheduleID
        {
            get { return scheduleID; }
            set { scheduleID = value; }
        }

        public int TokenNo
        {
            get { return tokenNo; }
            set { tokenNo = value; }
        }
        // public string title { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string location { get; set; }
        // public long tockenNo { get; set; }
        // public int patientId { get; set; }
        // public long bookingId { get; set; }
        // public long ResourcetemplateId { get; set; }
        // public long ScheduleID { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public int duration { get; set; }
        public string orgid { get; set; }

        public int BookedWaiting
        {
            get { return _bookedWaiting; }
            set { _bookedWaiting = value; }
        }
        public string BlockReason
        {
            get { return _blockReason; }
            set { _blockReason = value; }
        }
        public int BookingStatusId
        {
            get { return bookingstatusid; }
            set { bookingstatusid = value; }
        }
    }
}
