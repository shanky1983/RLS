using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ReportPrinting
    {
        #region Fields
        private long patientID = 0;
        private long _patientvisitid = 0;
        private int organizationID = 0;
        private string visitNumber = String.Empty;

        private string titleName = String.Empty;
        private string patientName = String.Empty;
        private string age = String.Empty;
        private string gender = String.Empty;
        private DateTime visitDate = DateTime.MaxValue;
        private string referingPhysicianName = String.Empty;
        private long addressID = 0;
        private long finalBillID = 0;
        private decimal netValue = Decimal.Zero;
        private decimal amountReceived = Decimal.Zero;
        private string status = String.Empty;
        private string investigationName = String.Empty;
        private string displayStatus = String.Empty;

        private long printerCode =  0;
        private string reportStatus = String.Empty;
        private string printingStatus = String.Empty;
        private string dueStatus = string.Empty;
        #endregion


        #region Properties
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public int OrganizationID
        {
            get { return organizationID; }
            set { organizationID = value; }
        }
        
        public long PatientVisitID
        {
            get { return _patientvisitid; }
            set { _patientvisitid = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }
        string _mobilenumber;
        public string MobileNumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; }
        }

        public string TitleName
        {
            get { return titleName; }
            set { titleName = value; }
        }

        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string ReferingPhysicianName
        {
            get { return referingPhysicianName; }
            set { referingPhysicianName = value; }
        }

        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }

        public long AddressID
        {
            get { return addressID; }
            set { addressID = value; }
        }
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }
        public decimal NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }
        public decimal AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string DisplayStatus
        {
            get { return displayStatus; }
            set { displayStatus = value; }
        }

        public long PrinterCode
        {
            get { return printerCode; }
            set { printerCode = value; }
        }

        public string ReportStatus
        {
            get { return reportStatus; }
            set { reportStatus = value; }
        }
        public string PrintingStatus
        {
            get { return printingStatus; }
            set { printingStatus = value; }
        }
        public string DueStatus
        {
            get { return dueStatus; }
            set { dueStatus = value; }
        }
        #endregion

    }
}
