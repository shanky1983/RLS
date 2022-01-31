using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class AllVisitDetails_EMR
    {
        #region Fields

        private long patientID = 0;

        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        private long patientVisitId = 0;

        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }
        private DateTime visitDate = DateTime.MaxValue;

        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        private long physicianID = 0;

        public long PhysicianID
        {
            get { return physicianID; }
            set { physicianID = value; }
        }
        private string physicianName = String.Empty;

        public string PhysicianName
        {
            get { return physicianName; }
            set { physicianName = value; }
        }
        private string chiefComplaints = string.Empty;

        public string ChiefComplaints
        {
            get { return chiefComplaints; }
            set { chiefComplaints = value; }
        }

        #endregion
    }
}
