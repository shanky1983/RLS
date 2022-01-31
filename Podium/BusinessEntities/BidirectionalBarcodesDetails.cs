using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BidirectionalBarcodesDetails
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
        private string attFlag = string.Empty;
        private string isProcessed = string.Empty;
        private string deviceid = string.Empty;
        private DateTime Devicedate = DateTime.MaxValue;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime dob = DateTime.MaxValue;
        private string age = string.Empty;
        private string samplename = string.Empty;
        private string physicianname = string.Empty;
        private string clientname = string.Empty;
        private string visitNumber = string.Empty;
        private string remarks = string.Empty;
        private long accessionnumber = 0;
        private int RowID = 0;
        private long patientvisitid = 0;
        private string string1 = string.Empty;
        private string string2 = string.Empty;
        private int int1 = 0;
        private int int2 = 0;
        private long long1 = 0;

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

        public long AccessionNumber
        {
            get { return accessionnumber; }
            set { accessionnumber = value; }
        }

        public string AttFlag
        {
            get { return attFlag; }
            set { attFlag = value; }
        }

        public string IsProcessed
        {
            get { return isProcessed; }
            set { isProcessed = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public string String1
        {
            get { return string1; }
            set { string1 = value; }
        }

        public string String2
        {
            get { return string2; }
            set { string2 = value; }
        }

        public int Int1
        {
            get { return int1; }
            set { int1 = value; }
        }

        public int Int2
        {
            get { return int2; }
            set { int2 = value; }
        }

        public long Long1
        {
            get { return long1; }
            set { long1 = value; }
        }
    }
}
