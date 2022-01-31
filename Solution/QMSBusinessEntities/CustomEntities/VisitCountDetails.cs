using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class VisitCountDetails
    {
        private string name = string.Empty;
        private long patientVisitId = 0;
        private DateTime visitDate = DateTime.MaxValue;
        private string visitNumber = string.Empty;
        private string referingPhysicianName = string.Empty;
        private string location = string.Empty;
        private string isStat = string.Empty;
        private string isCritical = string.Empty;
        private int orgID = 0;
        private string patientNumber = string.Empty;
        private string Uid = string.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }
        public string ReferingPhysicianName
        {
            get { return referingPhysicianName; }
            set { referingPhysicianName = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string IsStat
        {
            get { return isStat ; }
            set { isStat = value; }
        }
        public string IsCritical
        {
            get { return isCritical; }
            set { isCritical = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public string UID
        {
            get { return Uid; }
            set { Uid = value; }
        }
    }
}
