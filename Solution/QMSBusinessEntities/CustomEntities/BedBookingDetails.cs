using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class BedBookingDetails
    {
        #region Fields

        private long bookingID = 0;
        private int bedID = 0;
        private long patientID = 0;
        private int orgAddID = 0;
        private int orgID = 0;
        private int visitID = 0;

        private string fromDate = DateTime.MaxValue.ToString();
        private string toDate = DateTime.MaxValue.ToString();
        private string status = String.Empty;
        private string description = String.Empty;
        private string patientName = String.Empty;
        private int treatmentPlanID = 0;

        private long clientID = 0;

        public int TreatmentPlanID
        {
            get { return treatmentPlanID; }
            set { treatmentPlanID = value; }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the BookingID value.
        /// </summary>
        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
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
        public string FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        public string ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
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
        public int OrgAddID
        {
            get { return orgAddID; }
            set { orgAddID = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
            
        }
        /// <summary>
        /// Gets or sets the PatientName value.
        /// </summary>
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public int VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }


        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        #endregion
    }
}
