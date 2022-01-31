using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class WorkOrder
    {
        private long billNumber = 0;
        private long visitID = 0;
        private long externalVisitID = 0;
        private string strbillNumber = String.Empty;
        private string strvisitID = String.Empty;
        private string strexternalVisitID = String.Empty;
        private string collectedOn = String.Empty;
        private string receivedOn = String.Empty;
        private string patientNumber = String.Empty;
        private string patientName = String.Empty;
        private string age = String.Empty;
        private string sex = String.Empty;
        private string referingPhysicianName = String.Empty;
        private string description = String.Empty;
        private string investigationName = string.Empty;
        private long deptID = 0;
        private string _status = String.Empty;
        private string source = String.Empty;
        private string destination = String.Empty;
        private string protocolname = String.Empty;
        private string loginname = String.Empty;

        public long DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        public long BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        public string StrBillNumber
        {
            get { return strbillNumber; }
            set { strbillNumber = value; }
        }
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }
        public string StrVisitID
        {
            get { return strvisitID; }
            set { strvisitID = value; }
        }
        public long ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }
        public string StrExternalVisitID
        {
            get { return strexternalVisitID; }
            set { strexternalVisitID = value; }
        }
        public string CollectedOn
        {
            get { return collectedOn; }
            set { collectedOn = value; }
        }
        public string ReceivedOn
        {
            get { return receivedOn; }
            set { receivedOn = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string ReferingPhysicianName
        {
            get { return referingPhysicianName; }
            set { referingPhysicianName = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Source
        {
            get { return source; }
            set { source = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public string Protocolname
        {
            get { return protocolname; }
            set { protocolname = value; }
        }
        public string Loginname
        {
            get { return loginname; }
            set { loginname = value; }
        }
    }
}
