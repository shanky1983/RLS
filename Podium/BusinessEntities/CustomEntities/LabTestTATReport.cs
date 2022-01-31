using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Attune.Podium.BusinessEntities
{
    public class LabTestTATReport
    {
        #region Fields
        private long sno = 0;
        private string patientNumber = String.Empty;
        private string patientName = String.Empty;
        private string visitnumber = String.Empty;
        private string testname = String.Empty;
        private string deptname = String.Empty;
        private string registerlocation = String.Empty;
        private string processedlocation = String.Empty;
        private string orderedTime = String.Empty;
        private string collecteddatetime = String.Empty;
        private string transfereddatetime = String.Empty;
        private string receiveddatetime = String.Empty;
        private string transittime = String.Empty;
        private string valuesenteredtime = String.Empty;
        private string valuesmodifiedtime = String.Empty;
        private string completedTime = String.Empty;
        private string validatedtime = String.Empty;
        private string approvedtime = String.Empty;
        private string coauthorizedtime = String.Empty;
        private string status = String.Empty;
        private string expectedtat = String.Empty;
        private string actualtat = String.Empty;
        private string elapsedTime = String.Empty;
        private long   orgID = 0;
        private string valuesenteredby = string.Empty;
        private string receivedby = string.Empty;
        private string transferedby = string.Empty;
        private string completedby = string.Empty;
        private string coauthorizedby = string.Empty;
        private string validatedby = string.Empty;
        private string approvedby = string.Empty;
        private string clientname = string.Empty;


        #endregion

        #region Properties

        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }

        public long SNo
        {
            get { return sno; }
            set { sno = value; }
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

        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        public string TestName
        {
            get { return testname; }
            set { testname = value; }
        }
        public string DeptName
        {
            get { return deptname; }
            set { deptname = value; }
        }
        public string RegisterLocation
        {
            get { return registerlocation; }
            set { registerlocation = value; }
        }
        public string ProcessedLocation
        {
            get { return processedlocation; }
            set { processedlocation = value; }
        }
        public string OrderedTime
        {
            get { return orderedTime; }
            set { orderedTime = value; }
        }
        public string CollectedDateTime
        {
            get { return collecteddatetime; }
            set { collecteddatetime = value; }
        }
        public string TransferedDatetime
        {
            get { return transfereddatetime; }
            set { transfereddatetime = value; }
        }
        public string ReceivedDatetime
        {
            get { return receiveddatetime; }
            set { receiveddatetime = value; }
        }
        public string Transittime
        {
            get { return transittime; }
            set { transittime = value; }
        }
        public string ValuesEnteredtime
        {
            get { return valuesenteredtime; }
            set { valuesenteredtime = value; }
        }
        public string ValuesModifiedTime
        {
            get { return valuesmodifiedtime; }
            set { valuesmodifiedtime = value; }
        }
        public string CompletedTime
        {
            get { return completedTime; }
            set { completedTime = value; }
        }
        public string ValidatedTime
        {
            get { return validatedtime; }
            set { validatedtime = value; }
        }
        public string ApprovedTime
        {
            get { return approvedtime; }
            set { approvedtime = value; }
        }
        public string CoauthorizedTime
        {
            get { return coauthorizedtime; }
            set { coauthorizedtime = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string ExpectedTAT
        {
            get { return expectedtat; }
            set { expectedtat = value; }
        }
        public string ActualTAT
        {
            get { return actualtat; }
            set { actualtat = value; }
        }
        public string ElaspedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public string ValuesEnteredby
        {
            get { return valuesenteredby; }
            set { valuesenteredby = value; }
        }

        public string Transferedby
        {
            get { return transferedby; }
            set { transferedby = value; }
        }
        public string Receivedby
        {
            get { return receivedby; }
            set { receivedby = value; }
        }
        public string Completedby
        {
            get { return completedby; }
            set { completedby = value; }
        }
        public string Coauthorizedby
        {
            get { return coauthorizedby; }
            set { coauthorizedby = value; }
        }
        public string Validatedby
        {
            get { return validatedby; }
            set { validatedby = value; }
        }
        public string Approvedby
        {
            get { return approvedby; }
            set { approvedby = value; }
        }

        #endregion

    }
}
