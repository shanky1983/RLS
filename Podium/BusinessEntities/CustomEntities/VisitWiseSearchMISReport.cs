using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class VisitWiseSearchMISReport
    {

        private Int64 SNo;
        private Int64 finalBillID;
        private string patientNumber;
        private string patientName;
        private Int64 patientVisitId;
        private Int64 patientID;
        private DateTime visitDate;
        private string location;
        private string physicianName;
        private int orgID;
        private string externalVisitID;
        private string visitNumber;
        private string age;
        private Int64 orgAddressID;
        private string clientName;
        private string billNumber;
        private Decimal amount;
        private string receiptStatus;
        private string emailStatus;
        private string smsStatus;
        private string printStatus;
        private string isAbnormal;
        private string pdf;
        private string testDescription;
        private string orderedservices;
        private string printpdf;
        private string col1;

        public Int64 SNO
        {
            get { return SNo; }
            set { SNo = value; }
        }

        public Int64 FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
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


        public Int64 PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }


        public Int64 PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }


        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }


        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string PhysicianName
        {
            get { return physicianName; }
            set { physicianName = value; }
        }


        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public string ExternalVisitID
        {
            get { return externalVisitID; }
            set { externalVisitID = value; }
        }

        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }


        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public Int64 OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        

        public Decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string ReceiptStatus
        {
            get { return receiptStatus; }
            set { receiptStatus = value; }
        }

        public string EmailStatus
        {
            get { return emailStatus; }
            set { emailStatus = value; }
        }

        public string SmsStatus
        {
            get { return smsStatus; }
            set { smsStatus = value; }
        }

        public string PrintStatus
        {
            get { return printStatus; }
            set { printStatus = value; }
        }
        public string IsAbnormal
        {
            get { return isAbnormal; }
            set { isAbnormal = value; }
        }

        public string Pdf
        {
            get { return pdf; }
            set { pdf = value; }
        }

        public string TestDescription
        {
            get { return testDescription; }
            set { testDescription = value; }
        }
        public string OrderedServices
        {
            get { return orderedservices; }
            set { orderedservices = value; }
        }
        public string Printpdf
        {
            get { return printpdf; }
            set { printpdf = value; }
        }
        public string Col1
        {
            get { return col1; }
            set { col1 = value; }
        }

    }
}
