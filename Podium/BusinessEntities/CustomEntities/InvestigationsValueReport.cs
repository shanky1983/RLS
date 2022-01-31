using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvestigationsValueReport
    {
        #region Fields

        private string clientName = string.Empty;
        private long clientID = 0;
        private string createdAt = string.Empty;
        private string patientName = string.Empty;
        private long patientID = 0;
        private string patientNumber = string.Empty;
        private long patientVisitID = 0;
        private string externalVisitID = string.Empty;
        private int orgID = 0;
        private string orgName = string.Empty;
        private long accessionNumber = 0;
        private int groupID = 0;
        private string groupName = string.Empty;
        private string investigationName = string.Empty;
        private string values = string.Empty;
        private long investigationID = 0;
        private string sampleName = string.Empty;
        private string cultureResultPOS = string.Empty;
        private string cultureResultNeg = string.Empty;
        private string drugName = string.Empty;

        #endregion

        #region Properties

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
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
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }
        public string ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }

        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }
        public long AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }
        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string Value
        {
            get { return values; }
            set { values = value; }
        }
        public long InvestigationID
        {
            get { return investigationID ; }
            set { investigationID = value; }
        }
        public string SampleName
        {
            get { return sampleName ; }
            set { sampleName  = value; }
        }
        public string CultureResultPOS
        {
            get { return cultureResultPOS ; }
            set { cultureResultPOS = value; }
        }
        public string CultureResultNeg
        {
            get { return cultureResultNeg ; }
            set { cultureResultNeg = value; }
        }
        public string DrugName
        {
            get { return drugName; }
            set { drugName  = value; }
        }
       
        #endregion
    }
}
