using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class DoctorPayoutDetails
    {
        private Int32 referingPhysicianID = 0;
        private string physicianCode = String.Empty;
        private string physicianName = String.Empty;
        private Int32 billCount = 0;
        private decimal billAmount = 0;
        private decimal disCount = 0;
        private decimal netAmount = 0;
        private decimal payableAmount = 0;
        private decimal outStanding = 0;
        private decimal paidamount = 0;
        private string status = string.Empty;
        private Int64 finalbillid = 0;
        private string patientNumber = string.Empty;
        private string patientName = string.Empty;
        private string visitNumber = string.Empty;
        private String billNumber = string.Empty;
        public decimal amount = 0;
        private string cancel = string.Empty;
        private decimal billDiscount = 0;
        private string remarks = string.Empty;
        private Int64 finalbillblock = 0;
        private string servicename = string.Empty;
        public Int32 ReferingPhysicianID
        {
            get { return referingPhysicianID; }
            set { referingPhysicianID = value; }
        }
        public string PhysicianCode
        {
            get { return physicianCode; }
            set { physicianCode = value; }
        }
        public string PhysicianName
        {
            get { return physicianName; }
            set { physicianName = value; }
        }
        public Int32 BillCount
        {
            get { return billCount; }
            set { billCount = value; }

        }
        public decimal BillAmount
        {
            get { return billAmount; }
            set { billAmount = value; }

        }
        public decimal DisCount
        {
            get { return disCount; }
            set { disCount = value; }

        }
        public decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }

        }
        public decimal PayableAmount
        {
            get { return payableAmount; }
            set { payableAmount = value; }

        }
        public decimal OutStanding
        {
            get { return outStanding; }
            set { outStanding = value; }

        }
        public decimal Paidamount
        {
            get { return paidamount; }
            set { paidamount = value; }

        }
        public string Status
        {
            get { return status; }
            set { status = value; }

        }
        public Int64 Finalbillid
        {
            get { return finalbillid; }
            set { finalbillid = value; }
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
            get { return visitNumber; }
            set { visitNumber = value; }

        }
        public String BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }

        }
        public string Cancel
        {
            get { return cancel; }
            set { cancel = value; }

        }
        public decimal BillDiscount
        {
            get { return billDiscount; }
            set { billDiscount = value; }

        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public Int64 Finalbillblock
        {
            get { return finalbillblock; }
            set { finalbillblock = value; }
        }
        public string Servicename
        {
            get { return servicename; }
            set { servicename = value; }
        }
    }
}
