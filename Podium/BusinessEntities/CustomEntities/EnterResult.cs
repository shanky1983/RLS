using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class EnterResult
    {
        private long patientVisitId = 0;
        private string patientName = String.Empty;
        private long patientID = 0;
        private DateTime visitDate = DateTime.MaxValue;
        private string uID = String.Empty;
        private string patientVisitType = String.Empty;
        private string age = String.Empty;
        private string patientNumber = String.Empty;
        private string titleName = String.Empty;
        private string visitNotes = String.Empty;
        private string labno = string.Empty;
        private string visitnumber = String.Empty;
        private string state = string.Empty;
        private long deptID = 0;
        private string complaintName = string.Empty;
        private long rateID = 0;
        private string externalVisitID = String.Empty;
        private string accompaniedBy = String.Empty;
        private string nextReviewDate = String.Empty;
        private string status = String.Empty;
        private string resultEntryType = String.Empty;
        private int TATstatus = 0;
        private DateTime reporttat = DateTime.MaxValue;

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
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        public string UID
        {
            get { return uID; }
            set { uID = value; }
        }
        public string PatientVisitType
        {
            get { return patientVisitType; }
            set { patientVisitType = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public string TitleName
        {
            get { return titleName; }
            set { titleName = value; }
        }
        public string VisitNotes
        {
            get { return visitNotes; }
            set { visitNotes = value; }
        }
        public string Labno
        {
            get { return labno; }
            set { labno = value; }
        }
        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public long DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        public string ComplaintName
        {
            get { return complaintName; }
            set { complaintName = value; }
        }
        public long RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }
        public string ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }
        public string AccompaniedBy
        {
            get { return accompaniedBy; }
            set { accompaniedBy = value; }
        }
        public string NextReviewDate
        {
            get { return nextReviewDate; }
            set { nextReviewDate = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string ResultEntryType
        {
            get { return resultEntryType; }
            set { resultEntryType = value; }
        }
        public int TATStatus
        {
            get { return TATstatus; }
            set { TATstatus = value; }
        }
        public DateTime ReportTat
        {
            get { return reporttat; }
            set { reporttat = value; }
        }
    }
}
