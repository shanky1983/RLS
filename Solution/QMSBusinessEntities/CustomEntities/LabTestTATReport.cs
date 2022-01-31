using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Attune.Solution.QMSBusinessEntities
{
    public class LabTestTATReport
    {
        #region Fields
        private string patientNumber = String.Empty;
        private string patientName = String.Empty;
        private string investigationName = String.Empty;
        private long investigationID=0;
        private DateTime orderedTime = DateTime.MaxValue;
        private DateTime sampleTime = DateTime.MaxValue;
        private DateTime valuesEnterTime = DateTime.MaxValue;
        private DateTime valuesModifiedTime = DateTime.MaxValue;
        private DateTime completedTime = DateTime.MaxValue;
        private DateTime approvedDateAndTime = DateTime.MaxValue;
        private string status = String.Empty;
        private string location = String.Empty;
        private string deptName = String.Empty;
        private string visitID = String .Empty;
        private DateTime recSampleTime = DateTime.MaxValue;
        private string processingLocation = String.Empty;
        private long orgID = 0;
        private string elapsedTime = String.Empty;
        #endregion

        #region Properties
    
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

        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }

        public DateTime OrderedTime
        {
            get { return orderedTime; }
            set { orderedTime = value; }
        }
        public DateTime SampleTime
        {
            get { return sampleTime; }
            set { sampleTime = value; }
        }
        public DateTime ValuesEnterTime
        {
            get { return valuesEnterTime; }
            set { valuesEnterTime = value; }
        }
        public DateTime ValuesModifiedTime
        {
            get { return valuesModifiedTime; }
            set { valuesModifiedTime = value; }
        }
        public DateTime CompletedTime
        {
            get { return completedTime; }
            set { completedTime = value; }
        }
        public DateTime ApprovedDateAndTime
        {
            get { return approvedDateAndTime; }
            set { approvedDateAndTime = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        public string VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }
        public DateTime RecSampleTime
        {
            get { return recSampleTime; }
            set { recSampleTime = value; }
        }
        public string ProcessingLocation
        {
            get { return processingLocation; }
            set { processingLocation = value; }
        }
        public long OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public string ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }
        #endregion

    }
}
