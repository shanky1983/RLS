
using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class RoomDetails
    {
        #region Fields

        private int roomID = 0;
        private string roomName= String.Empty;
        private int roomTypeID = 0;
        private int wardid = 0;
        private string roomTypeName= String.Empty;
        private long feeID = 0;

        private string description = String.Empty;
        private long roomTypeFeeMappingID = 0;
        private decimal amount = 0;
        private int bedID = 0;
        private string bedName= String.Empty;
        private int floorID = 0;
        private string floorName = String.Empty;
        private string isSlotable = String.Empty;
        private string wardName = String.Empty;
        private string isvariable = String.Empty;
        private string isoptional = String.Empty;
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        private int rateID { get; set; }
        private string feelogicID { get; set; }
        private string feebasedOn { get; set; }
        private string allowSlotBooking { get; set; }
        private string isAnOT { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the BookingID value.
        /// </summary>
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        /// <summary>
        /// Gets or sets the BedID value.
        /// </summary>
        public int BedID
        {
            get { return bedID; }
            set { bedID = value; }
        }

        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        public int RoomTypeID
        {
            get { return roomTypeID; }
            set { roomTypeID = value; }
        }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        public string RoomTypeName
        {
            get { return roomTypeName; }
            set { roomTypeName = value; }
        }
        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }
        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public long FeeID
        {
            get { return feeID; }
            set { feeID = value; }
        }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Gets or sets the OrgAddID value.
        /// </summary>
        public long RoomTypeFeeMappingID
        {
            get { return roomTypeFeeMappingID; }
            set { roomTypeFeeMappingID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientName value.
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string BedName
        {
            get { return bedName; }
            set { bedName = value; }
        }
        public int FloorID
        {
            get { return floorID; }
            set { floorID = value; }
        }
        public string FloorName
        {
            get { return floorName; }
            set { floorName = value; }
        }
        public string IsSlotable
        {
            get { return isSlotable; }
            set { isSlotable = value; }
        }
        public string ISVariable
        {
            get { return isvariable; }
            set { isvariable = value; }
        }
        public string ISOptional
        {
            get { return isoptional; }
            set { isoptional = value; }
        }
        public int WardID
        {
            get { return wardid; }
            set { wardid = value; }
        }
        /// <summary>
        /// Gets or sets the NoBeds value.
        /// </summary>
        int _nobeds;
        public int NoBeds
        {
            get { return _nobeds; }
            set { _nobeds = value; }
        }

        public int RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }
        public string FeelogicID
        {
            get { return feelogicID; }
            set { feelogicID = value; }
        }
        public string FeebasedOn
        {
            get { return feebasedOn; }
            set { feebasedOn = value; }
        }
        public string AllowSlotBooking
        {
            get { return allowSlotBooking; }
            set { allowSlotBooking = value; }
        }
        public string IsAnOT
        {
            get { return isAnOT; }
            set { isAnOT = value; }
        }
        int _noRows;
        public int NoRows
        {
            get { return _noRows; }
            set { _noRows = value; }
        }

        int _noColumns;
        public int NoColumns
        {
            get { return _noColumns; }
            set { _noColumns = value; }
        }
        private string dayNames = String.Empty;
        public string DayNames
        {
            get { return dayNames; }
            set { dayNames = value; }
        }

        private string rackType = String.Empty;
        public string RackType
        {
            get { return rackType; }
            set { rackType = value; }
        }
        private long sampleGroupID = 0;      
        public long SampleGroupID
        {
            get { return sampleGroupID; }
            set { sampleGroupID = value; }
        }
        private long sampleCode = 0;
        public long SampleCode
        {
            get { return sampleCode; }
            set { sampleCode = value; }
        }
        #endregion
    }
}
