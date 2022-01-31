using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvestigationStatusReport
    {
        #region fields

        private string patientnumber = string.Empty;
        private string patientname = string.Empty;
        private string externalvisitid = string.Empty;
        private long patientid = 0;
        private long patientvisitid = 0;
        private long investigationID = 0;
        private string investigationName = string.Empty;
        private string location = string.Empty;
        private string samplecollection = string.Empty;
        private string resultcapture = string.Empty;
        private string approval = string.Empty;
        private DateTime registrationdttm = DateTime.MaxValue;
        private DateTime createdat = DateTime.MaxValue;
        private string deptName = string.Empty;
        private long deptID = 0;
        private string performLocation = string.Empty;
        private int orgID = 0;
        private long locationID = 0;


        private int normalTestCount = 0;
        private int abnormalTestCount = 0;
        private int criticalTestCount = 0;
        private int unSpecifiedTestCount = 0;
        private int reTestCount = 0;
        private int reflexTestCount = 0;
        private int dilutionTestCount = 0;
        private int qCTestCount = 0;
        private int manualTestCount = 0;
        private int interfacedTestCount = 0;

        private DateTime tATClosingTime = DateTime.MaxValue;
        private string tATLeft = string.Empty;
        private string testCategory = string.Empty;
        private string clientName = string.Empty;
        private string clientTypeName = string.Empty;
        private int accessionnumber = 0;
        private int rowid = 0;
        private DateTime delaytime = DateTime.MaxValue;
        private string modifiedUser = string.Empty;
        private string updateuser = string.Empty;
        private string delaylogger = string.Empty;
        private long visitno = 0; 
        private string refHospital = string.Empty;
        private string refPhysician = string.Empty;

        #endregion


        #region Properties
        public long LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public string PerformLocation
        {
            get { return performLocation; }
            set { performLocation = value; }
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        public long DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        /// <summary>
        /// Gets or sets the InvestigationID value.
        /// </summary>
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }
        public string SampleCollection
        {
            get { return samplecollection; }
            set { samplecollection = value; }
        }
        public string ResultCapture
        {
            get { return resultcapture; }
            set { resultcapture = value; }
        }
        public string Approval
        {
            get { return approval; }
            set { approval = value; }
        }
        public string PatientNumber
        {
            get { return patientnumber; }
            set { patientnumber = value; }
        }
        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }
        }
        public string ExternalVisitid
        {
            get { return externalvisitid; }
            set { externalvisitid = value; }
        }
        public long PatientVisitID
        {
            get { return patientvisitid; }
            set { patientvisitid = value; }
        }
        public long PatientID
        {
            get { return patientid; }
            set { patientid = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdat; }
            set { createdat = value; }
        }
        public DateTime RegistrationDTTM
        {
            get { return registrationdttm; }
            set { registrationdttm = value; }
        }

        public int NormalTestCount
        {
            get { return normalTestCount; }
            set { normalTestCount = value; }
        }
        public int AbnormalTestCount
        {
            get { return abnormalTestCount; }
            set { abnormalTestCount = value; }
        }
        public int CriticalTestCount
        {
            get { return criticalTestCount; }
            set { criticalTestCount = value; }
        }
        public int UnSpecifiedTestCount
        {
            get { return unSpecifiedTestCount; }
            set { unSpecifiedTestCount = value; }
        }

        public int ReTestCount
        {
            get { return reTestCount; }
            set { reTestCount = value; }
        }

        public int ReflexTestCount
        {
            get { return reflexTestCount; }
            set { reflexTestCount = value; }
        }

        public int DilutionTestCount
        {
            get { return dilutionTestCount; }
            set { dilutionTestCount = value; }
        }

        public int QCTestCount
        {
            get { return qCTestCount; }
            set { qCTestCount = value; }
        }

        public int ManualTestCount
        {
            get { return manualTestCount; }
            set { manualTestCount = value; }
        }

        public int InterfacedTestCount
        {
            get { return interfacedTestCount; }
            set { interfacedTestCount = value; }
        }
        public DateTime TATClosingTime
        {
            get { return tATClosingTime; }
            set { tATClosingTime = value; }
        }
        public string TATLeft
        {
            get { return tATLeft; }
            set { tATLeft = value; }
        }
        public string TestCategory
        {
            get { return testCategory; }
            set { testCategory = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string ClientTypeName
        {
            get { return clientTypeName; }
            set { clientTypeName = value; }
        }
        public int AccessionNumber
        {
            get { return accessionnumber; }
            set { accessionnumber = value; }
        }
        public int RowID
        {
            get { return rowid; }
            set { rowid = value; }
        }
        //private DateTime delaytime = DateTime.MaxValue;
        //private string updateuser = string.Empty;
        //private string delaylogger = string.Empty;
        public DateTime DelayTime
        {
            get { return delaytime; }
            set { delaytime = value; }
        }
        public string DelayLogger
        {
            get { return delaylogger; }
            set { delaylogger = value; }
        }
        public string ModifiedUser
        {
            get { return modifiedUser; }
            set { modifiedUser = value; }
        }
        public string UpdateUser
        {
            get { return updateuser; }
            set { updateuser = value; }
        }
        public long VisitNo
        {
            get { return visitno; }
            set { visitno = value; }
        } 
        public string RefHospital
        {
            get { return refHospital; }
            set { refHospital = value; }
        }
        public string RefPhysician
        {
            get { return refPhysician; }
            set { refPhysician = value; }
        }
        #endregion
    }
}
