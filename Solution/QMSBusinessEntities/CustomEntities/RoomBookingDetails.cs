using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class RoomBookingDetails
    {
        private string floorName = String.Empty;
        private string roomName = String.Empty;
        private string bedName = String.Empty;
        private string roomTypeName = String.Empty;
        private string patientName = String.Empty;
        private string fromDate = String.Empty;
        private string toDate = String.Empty;
        private string patientStatus = String.Empty;
        private string roomStatus = String.Empty;
        private string buildingName = String.Empty;
        private string allowSlotBooking = String.Empty;
        private string wardName = String.Empty;


        private Int64 roomTypeID = 0;
        private Int64 patientID = 0;
        private Int64 floorID = 0;
        private Int64 roomID = 0;
        private Int64 bedID = 0;
        private Int64 bookingID = 0;
        private Int64 visitID = 0;
        private Int64 wardID = 0;
        private Int64 clientID = 0;

        private string primaryConsultant = String.Empty;
        private string patientInfo = String.Empty;

        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }

        public Int64 WardID
        {
            get { return wardID; }
            set { wardID = value; }
        }

        public Int64 ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string PatientStatus
        {
            get { return patientStatus; }
            set { patientStatus = value; }
        }
        public string FloorName
        {
            get { return floorName; }
            set { floorName = value; }
        }
        public Int64 FloorID
        {
            get { return floorID; }
            set { floorID = value; }
        }
        public Int64 RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }

        }
        public string BedName
        {
            get { return bedName; }
            set { bedName = value; }

        }
        public Int64 BedID
        {
            get { return bedID; }
            set { bedID = value; }

        }
        public string RoomTypeName
        {
            get { return roomTypeName; }
            set { roomTypeName = value; }
        }
        public Int64 RoomTypeID
        {
            get { return roomTypeID; }
            set { roomTypeID = value; }
        }

        public Int64 PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        public string FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        public string ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        public Int64 BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public Int64 VisitID
        {
            get { return visitID; }
            set { visitID = value; }

        }

        public string PrimaryConsultant
        {
            get { return primaryConsultant; }
            set { primaryConsultant = value; }
        }

        public string PatientInfo
        {
            get { return patientInfo; }
            set { patientInfo = value; }
        }

        public string RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
        public string AllowSlotBooking
        {
            get { return allowSlotBooking; }
            set { allowSlotBooking = value; }
        }
    }
}
