using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientWaitTime
    {
        private int patientVisitId;
        private string patientName;
        private string visitPurposeName;
        private DateTime startTime;
        private DateTime endTime;
        private decimal elapsedTime;

        public int PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public string VisitPurposeName
        {
            get { return visitPurposeName; }
            set { visitPurposeName = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public decimal ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }
    }
}
