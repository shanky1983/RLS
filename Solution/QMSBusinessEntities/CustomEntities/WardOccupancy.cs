using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class WardOccupancy
    {
        #region Fields
        private int age = 0;
        private string sex = String.Empty;
        private string clientName = String.Empty;
        private string roomandBedName = String.Empty;
        private string roomTypeName = String.Empty;        
        private DateTime dOA = DateTime.MinValue;
        private DateTime visitDate = DateTime.MinValue;
        private string name = String.Empty;
        private string nationality = String.Empty;
        private string purposeOfAdmissionName = String.Empty;
        private string specialityName = String.Empty;
        private string wardName = String.Empty;
        private string referingphysician = String.Empty;
        private int orgID = 0;
        private long patientVisitId = 0;
        private Int64 patientId = 0;
        private string patientNumber = String.Empty;
        private string floorName = String.Empty;
        private decimal preAuthAmount = 0;
        private decimal grossBillValue = 0;
        private string physicianName = String.Empty;
        private long ipNumber = 0;
        private DateTime fromDate = DateTime.MaxValue;
        private DateTime toDate = DateTime.MaxValue;
        #endregion
        #region methods
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public string PurposeOfAdmissionName
        {
            get { return purposeOfAdmissionName; }
            set { purposeOfAdmissionName = value; }
        }
        public string SpecialityName
        {
            get { return specialityName; }
            set { specialityName = value; }
        }
        public string RoomandBedName
        {
            get { return roomandBedName; }
            set { roomandBedName = value; }
        }
        public string RoomTypeName
        {
            get { return roomTypeName; }
            set { roomTypeName = value; }
        }        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public DateTime DOA
        {
            get { return dOA; }
            set { dOA = value; }
        }
        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }        
        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }
        public string FloorName
        {
            get { return floorName; }
            set { floorName = value; }
        }
        public string Referingphysician
        {
            get { return referingphysician; }
            set { referingphysician = value; }
        }
        public string PhysicianName
        {
            get { return physicianName; }
            set { physicianName = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        } 
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }
        public long IPNumber
        {
            get { return ipNumber; }
            set { ipNumber = value; }
        }
        
        public decimal GrossBillValue
        {
            get { return grossBillValue; }
            set { grossBillValue = value; }
        }
        public decimal PreAuthAmount
        {
            get { return preAuthAmount; }
            set { preAuthAmount = value; }
        }
        public Int64 PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        #endregion
    }
}
