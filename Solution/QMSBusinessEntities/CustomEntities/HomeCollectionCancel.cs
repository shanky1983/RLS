using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class HomeCollectionCancel
    {
        #region Fields

            
        private Int64 visitID = 0;
        private Int64 patientID = 0;
        private Int64 orgID = 0;
        private long loginid = 0;
        private long bookingID = 0;
        private long id = 0;
        private string patientname = String.Empty;
        private string city = String.Empty;
        private string testcode = String.Empty;
        private string testname = String.Empty;
        private DateTime bookingdate = DateTime.MaxValue;
        private string bookedby = String.Empty;
        private DateTime cancelleddate = DateTime.MaxValue;
        private string cancelledby = String.Empty;
        private decimal amount = 0;
        private Int64 status = 0;


        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the FinalBillID value.
        /// </summary>
        /// 


        public Int64 VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }
        public Int64 PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public Int64 OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public long LoginID
        {
            get { return loginid; }
            set { loginid = value; }
        }


        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
          public long ID
        {
            get { return id; }
            set { id = value; }
        }

          public decimal Amount
        {
            get { return amount; }
            set { amount = value; }

        }


        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }
        }

        /// <summary>
        /// Gets or sets the Age value.
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Gets or sets the VisitDate value.
        /// </summary>
        public string Testcode
        {
            get { return testcode; }
            set { testcode = value; }
        }

        public string Name
        {
            get { return testname; }
            set { testname = value; }
        }



        /// <summary>
        /// Gets or sets the Consultation value.
        /// </summary>
        public DateTime BookingDate
        {
            get { return bookingdate; }
            set { bookingdate = value; }
        }

        public DateTime CancelledDate
        {
            get { return cancelleddate; }
            set { cancelleddate = value; }
        }


        public string BookedBy
        {
            get { return bookedby; }
            set { bookedby = value; }
        }

        public string CancelledBy
        {
            get { return cancelledby; }
            set { cancelledby = value; }
        }


        public Int64 Status
        {
            get { return status; }
            set { status = value; }
        }



        #endregion


    }
}
