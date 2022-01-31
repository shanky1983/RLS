using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ClientOutStanding
    {
        
        private string clientName = String.Empty;
        private decimal openingBalance = 0;
        private decimal bill = 0;
        private decimal credit = 0;
        private decimal debit = 0;
        private decimal receipt = 0;
        private decimal outstanding = 0;
        private string clientCode= String.Empty;
        private decimal closingBalance = 0;
        private DateTime date = DateTime.MaxValue;
        private int patientcount = 0;
        private int workload = 0;
        private string currencyCode = String.Empty;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }

        }

        public decimal OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }

        }
        public decimal Bill
        {
            get { return bill; }
            set { bill = value; }

        }
        public decimal Credit
        {
            get { return credit; }
            set { credit = value; }

        }
        public decimal Debit
        {
            get { return debit; }
            set { debit = value; }

        }
        public decimal Receipt
        {
            get { return receipt; }
            set { receipt = value; }

        }
        public decimal OutStanding
        {
            get { return outstanding; }
            set { outstanding = value; }

        }
        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }

        }
        public decimal ClosingBalance
        {
            get { return closingBalance; }
            set { closingBalance = value; }

        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int PatientCount
        {
            get { return patientcount; }
            set { patientcount = value; }
        }
        public int WorkLoad
        {
            get { return workload; }
            set { workload = value; }
        }
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }

        }

    }
}
