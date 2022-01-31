using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PatientMRDDetails
    {
        #region Fields
        private long patientID = 0;
        private long patientVisitId = 0;
        private string patientName = String.Empty;
        private string patientNumber = String.Empty;
        private string visitNumber = String.Empty;
        private string address = String.Empty;
        private string mobileNo = String.Empty;
        private string specialityName = String.Empty;
        private string status = String.Empty;

        private string categoryType = String.Empty;
        private string fromPerson = String.Empty;
        private string toPerson = String.Empty;
        private DateTime visitDate = DateTime.MinValue; 
        #endregion


        #region Properties

        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }

        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }


        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }

        public string SpecialityName
        {
            get { return specialityName; }
            set { specialityName = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string CategoryType
        {
            get { return categoryType; }
            set { categoryType = value; }
        }


        public string FromPerson
        {
            get { return fromPerson; }
            set { fromPerson = value; }
        }

        public string ToPerson
        {
            get { return toPerson; }
            set { toPerson = value; }
        }

        #endregion
    }
}

