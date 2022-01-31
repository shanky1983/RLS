using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class EventSlotData
    {
        public string title { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string location { get; set; }
        public string tockenNo { get; set; }
        public string patientId { get; set; }
        public string BookingStatus { get; set; }
        public string DoctorBlock { get; set; }
        public string bookingId { get; set; }
        public string ResourcetemplateId { get; set; }
        public string ScheduleID { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public int duration { get; set; }
        public string orgid { get; set; }
        public string physicianId { get; set; }
        public string physicianName { get; set; }
        public string open { get; set; }
        public string booked { get; set; }
        public string waiting { get; set; }
        public bool allDay { get; set; }
        public int BookedWaiting { get; set; }
        public string BlockReason { get; set; }
        public int BookingStatusId { get; set; }
    }
}
