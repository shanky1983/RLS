using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BidirectionalBarcodes
    {       
        private string patientname = string.Empty;
        private string patientage = string.Empty;
        private string patientsex = string.Empty;
        private string testcode = string.Empty;
        private string barcode = string.Empty;
        //private string uid = string.Empty;
        //private long patientvisitid = 0;
        //private long accessionnumber = 0;
        private long patientinvid = 0;
        private int orgid = 0;
        private string deviceid = string.Empty;
        private DateTime Devicedate = DateTime.MaxValue;
        private DateTime dob = DateTime.MaxValue;
        private string age = string.Empty;
        private string samplename = string.Empty;
        private string physicianname = string.Empty;
        private string clientname = string.Empty;
        private string visitNumber = string.Empty;
        private string remarks = string.Empty; 
        private int RowID = 0;
        private long patientvisitid = 0;

        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }
        }

        public string PatientAge
        {
            get { return patientage; }
            set { patientage = value; }
        }

        public string PatientSex
        {
            get { return patientsex; }
            set { patientsex = value; }
        }       

        public string TestCode
        {
            get { return testcode; }
            set { testcode = value; }
        }

        public string BarCode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        //public string UID
        //{
        //    get { return uid; }
        //    set { uid = value; }
        //}

        //public long PatientVisitId
        //{
        //    get { return patientvisitid; }
        //    set { patientvisitid = value; }
        //}

        //public long AccessionNumber
        //{
        //    get { return accessionnumber; }
        //    set { accessionnumber = value; }
        //}

        public long PatientInvID
        {
            get { return patientinvid; }
            set { patientinvid = value; }
        }
        public int OrgID
        {
            get { return orgid; }
            set { orgid = value; }
        }
        public string DeviceID
        {
            get { return deviceid; }
            set { deviceid = value; }
        }
        public DateTime DeviceDate
        {
            get { return Devicedate; }
            set { Devicedate = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string SampleName
        {
            get { return samplename; }
            set { samplename = value; }
        }
        public string PhysicianName
        {
            get { return physicianname; }
            set { physicianname = value; }
        }
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public int rowid
        {
            get { return RowID; }
            set { RowID = value; }
        }
        public long PatientVisitId
        {
            get { return patientvisitid; }
            set { patientvisitid = value; }
        }
    }
}
