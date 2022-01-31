using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientDemography
    {

        #region Fields

        private long patientVisitId = 0;
        private long orgID = 0;
        private string patientname = string.Empty;
        private DateTime visitdate = DateTime.MaxValue;
        private string sex = string.Empty;
        private string visitno = String.Empty;
        private string visittype = string.Empty;
        private string age = string.Empty;
        private string referingphysicianName = string.Empty;
        private string patientid = string.Empty;
        private string constultantname = string.Empty;
        private DateTime collectedon = DateTime.MaxValue;
        private DateTime reportedon = DateTime.MaxValue;
        private DateTime printedon = DateTime.MaxValue;
        private string contactno = string.Empty;
        private string clientName = string.Empty;
        private string detailHistory = string.Empty;
        private string hospitalName = string.Empty;

        private string externalVisitId = string.Empty;
        private string externalPatientNumber = string.Empty;
        private DateTime dob = DateTime.MaxValue;

        #endregion

        #region Properties

        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }

        }

        public DateTime VisitDate
        {
            get { return visitdate; }
            set { visitdate = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string VisitNo
        {
            get { return visitno; }
            set { visitno = value; }
        }

        public string VisitType
        {
            get { return visittype; }
            set { visittype = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string ReferingPhysicianName
        {
            get { return referingphysicianName; }
            set { referingphysicianName = value; }
        }

        public string ConstultantName
        {
            get { return constultantname; }
            set { constultantname = value; }
        }


        public string PatientID
        {
            get { return patientid; }
            set { patientid = value; }
        }


        public DateTime CollectedOn
        {
            get { return collectedon; }
            set { collectedon = value; }
        }

        public DateTime ReportedOn
        {
            get { return reportedon; }
            set { reportedon = value; }
        }

        public DateTime PrintedOn
        {
            get { return printedon; }
            set { printedon = value; }
        }

        public string ContactNo
        {
            get { return contactno; }
            set { contactno = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string DetailHistory
        {
            get { return detailHistory; }
            set { detailHistory = value; }
        }

        public string HospitalName
        {
            get { return hospitalName; }
            set { hospitalName = value; }
        }

        public string ExternalVisitId
        {
            get { return externalVisitId; }
            set { externalVisitId = value; }
        }

        public string ExternalPatientNumber
        {
            get { return externalPatientNumber; }
            set { externalPatientNumber = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }


        #endregion
    }
}
