using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class NotificationMaster
    {
        #region Fields

        private int notificationID = 0;
        private string name = string.Empty;
        private int contactNo = 0;
        private string labNumber = string.Empty;
        private string actionType = string.Empty;
        private string status = string.Empty;
        private string location = string.Empty;
        private string clientNames = string.Empty;
        private string reason = string.Empty;
        private string createdDate = string.Empty;
        private string reportingCenter = string.Empty;
        private string reportType = string.Empty;
        private string zone = string.Empty;
        private string destination = string.Empty;
        private string patientVisitId = string.Empty;
        private string completionTime = string.Empty;

        #endregion


        #region Properties


        public int NotificationID
        {
            get { return notificationID; }
            set { notificationID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public string LabNumber
        {
            get { return labNumber; }
            set { labNumber = value; }
        }
        public string ActionType
        {
            get { return actionType; }
            set { actionType = value; }
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
        public string ClientNames
        {
            get { return clientNames; }
            set { clientNames = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        public string CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        public string ReportingCenter
        {
            get { return reportingCenter; }
            set { reportingCenter = value; }
        }
        public string ReportType
        {
            get { return reportType; }
            set { reportType = value; }
        }
        public string Zone
        {
            get { return zone; }
            set { zone = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }


        public string PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        public string CompletionTime
        {
            get { return completionTime; }
            set { completionTime = value; }
        }

        
        #endregion
    }
}
