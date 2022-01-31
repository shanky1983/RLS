using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class DeviceImportData
    {
        private string barcode = String.Empty;
        private string testcode = String.Empty;
        private string devicesampledesc = String.Empty;
        private string patientname = string.Empty;
        private string patientnumber = string.Empty;
        private string externalvisitid = string.Empty;
        private string patientage = string.Empty;
        private string patientsex = string.Empty;
        private long visitID = 0;
        private string deviceID = String.Empty;
        private int orgID = 0;
        private long orgAddressID = 0;
        private string visitnumber = string.Empty;
        private string referingPhysicianName = String.Empty;
        private string wardNo = String.Empty;
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the OrgAddressID value.
        /// </summary>
        public long OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }


        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        public string BarCode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string TestCode
        {
            get { return testcode; }
            set { testcode = value; }
        }
        public string DeviceSampleDesc
        {
            get { return devicesampledesc; }
            set { devicesampledesc = value; }
        }
        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }
        }
        public string PatientNumber
        {
            get { return patientnumber; }
            set { patientnumber = value; }
        }
        public string ExternalVisitID
        {
            get { return externalvisitid; }
            set { externalvisitid = value; }
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
        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        public string WardNo
        {
            get { return wardNo; }
            set { wardNo = value; }
        }
        public string ReferingPhysicianName
        {
            get { return referingPhysicianName; }
            set { referingPhysicianName = value; }
        }
    }
}
