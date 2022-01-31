using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class EventsData
    {
        public long resourceTemplateID { get; set; }
        public DateTime SlotDay { get; set; }
        public long ScheduleID { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string patientName { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string location { get; set; }
        public string tockenNo { get; set; }
        public string patientId { get; set; }
        public string BookingStatus { get; set; }
        public string DoctorBlock { get; set; }
        public string bookingId { get; set; }
        public string templateResourceId { get; set; }
        public string otherId { get; set; }
        public long physicianId { get; set; }
        public string physicianName { get; set; }
        public string open { get; set; }
        public string booked { get; set; }
        public string waiting { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public bool allDay { get; set; }
        public int BookingStatusId { get; set; }
        public string resourceType { get; set; }
        public int VisitPurposeID { get; set; }
    }
}
