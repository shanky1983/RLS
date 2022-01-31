using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class CollectedSample
    {
        string deptName = string.Empty;
        string _sampledesc=string.Empty;
        string invSampleStatusDesc = string.Empty;
        private DateTime createdAt = DateTime.MaxValue;
        string barcodeNumber = string.Empty;
        private int sampleContainerID = 0;
        string sampleContainerName = string.Empty;
        string reason = string.Empty;
        string fromDate = string.Empty; 
        string toDate = string.Empty; 
        string sampleStatus = string.Empty;
        string outSourcedOrgName = string.Empty;
        string locationName = string.Empty;
        string collectedlocationName = string.Empty;
        private long taskID = 0;
        string patientNumber = string.Empty;
        string visitnumber = string.Empty;
        private long _accessionNumber = 0;
        private DateTime collectedDate = DateTime.MaxValue;
        //added by sudhakar addressID
        private long addressID = 0;
        string externalVisitID = string.Empty;


        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }
        public string CollectedLocationName
        {
            get { return collectedlocationName; }
            set { collectedlocationName = value; }
        }


        public string FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        public string ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        public string SampleStatus
        {
            get { return sampleStatus; }
            set { sampleStatus = value; }
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        
        
        public string SampleDesc
        {
            get { return _sampledesc; }
            set { _sampledesc = value; }
        }
        public string InvSampleStatusDesc
        {
            get { return invSampleStatusDesc; }
            set { invSampleStatusDesc = value; }
        }
       
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public DateTime CollectedDate
        {
            get { return collectedDate; }
            set { collectedDate = value; }
        }

        public string BarcodeNumber
        {
            get { return barcodeNumber; }
            set { barcodeNumber = value; }
        }

         public int SampleContainerID
        {
            get { return sampleContainerID; }
            set { sampleContainerID = value; }
        }

        public string SampleContainerName
        {
            get { return sampleContainerName; }
            set { sampleContainerName = value; }
        }

        string patientName = string.Empty;
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        long patientVisitID =0;
        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }

        int sampleID = 0;
        public int SampleID
        {
            get { return sampleID; }
            set { sampleID = value; }
        }

        string guid = string.Empty;
        public string gUID
        {
            get { return guid; }
            set { guid = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value;}
        }

        int sampleTrackerID = 0;
        public int SampleTrackerID
        {
            get { return sampleTrackerID; }
            set { sampleTrackerID = value; }
        }

        string investigationName = string.Empty;
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }

        long investigationID = 0;
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }

        string investigationType = string.Empty;
        public string InvestigationType
        {
            get { return investigationType; }
            set { investigationType = value; }
        }
        int deptID = 0;
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        long invSampleStatusID = 0;
        public long InvSampleStatusID
        {
            get { return invSampleStatusID; }
            set { invSampleStatusID = value; }
        }
        string patientStatus = string.Empty;
        public string PatientStatus
        {
            get { return patientStatus; }
            set { patientStatus = value; }
        }
        public string OutSourcedOrgName
        {
            get { return outSourcedOrgName; }
            set { outSourcedOrgName = value; }
        }
        public long TaskID
        {
            get { return taskID; }
            set { taskID = value; }
        }
   string _testStatus;
        public string TestStatus
        {
            get { return _testStatus; }
            set { _testStatus = value; }
        }


        string _patientnumber;
        public string PatientNumber
        {
            get { return _patientnumber; }
            set { _patientnumber = value; }
        }
        
        DateTime _sampickupdate;
        public DateTime SamplePickupDate
        {
            get { return _sampickupdate; }
            set { _sampickupdate = value; }
        }



        string _processedat;
        public string ProcessedAT
        {
            get { return _processedat; }
            set { _processedat = value; }
        }


        string _Clientname;
        public string ClientName
        {
            get { return _Clientname; }
            set { _Clientname = value; }
        }

        int _collectedLocID;
        public int CollectedLocID
        {
            get { return _collectedLocID; }
            set { _collectedLocID = value; }
        }

        long _InvestigationID;
        public long INVID
        {
            get { return _InvestigationID; }
            set { _InvestigationID = value; }
        }

        string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        string _reforgName;
        public string RefOrgName
        {
            get { return _reforgName; }
            set { _reforgName = value; }
        }

         public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        
         DateTime _expectedtime;
         public DateTime ExpectedTime
         {
             get { return _expectedtime; }
             set { _expectedtime = value; }
         }
         string _delaytime;
         public string DelayTime
         {
             get { return _delaytime; }
             set { _delaytime = value; }
         }
        public long AccessionNumber
        {
            get { return _accessionNumber; }
            set { _accessionNumber = value; }
        }
        long _outSourcingLocationID;
        public long OutSourcingLocationID
        {
            get { return _outSourcingLocationID; }
            set { _outSourcingLocationID = value; }
        }
        public long AddressID
        {
            get { return addressID;}
            set { addressID = value;}
        }

        string _accessionNumberList;
        public string AccessionNumberList
        {
            get { return _accessionNumberList; }
            set { _accessionNumberList = value; }
        }



        string _investigationIDListist;
        public string InvestigationIDList
        {
            get { return _investigationIDListist; }
            set { _investigationIDListist = value; }
        }
        public string ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }
    }
}
