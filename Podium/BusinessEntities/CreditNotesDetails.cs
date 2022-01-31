using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CreditNotesDetails
	{
		#region Fields

        private long finalbillId = 0;
        private long billingDetailsId = 0;
        private long orgId = 0;
        private long patientVisitId = 0;
        private long serviceId = 0;
        private long clientId = 0;
        private long invoiceId = 0;

        private string invoiceNumber = String.Empty;
        private string clientCode = String.Empty;
        private string clientName = String.Empty;
        private string referenceType = String.Empty;
        private string visitNumber = String.Empty;
        private string billSupplyNumber = String.Empty;
        private string testCode = String.Empty;
        private string testName = String.Empty;
        private string creditNote = String.Empty;
        private string invoicegenBy = String.Empty;
        private string extraNote = String.Empty;
        private string command = String.Empty;

        private DateTime cancelledDate = DateTime.MaxValue;
        private DateTime invoioceDate = DateTime.MaxValue;

        private Decimal amountCharged = Decimal.Zero;
        private Decimal netAmount = Decimal.Zero;
        private Decimal grossAmount = Decimal.Zero;
        private Decimal invoiceAmount = Decimal.Zero;

		#endregion

		#region Properties		
        public long FinalbillId
		{
            get { return finalbillId; }
            set { finalbillId = value; }
		}
        public long BillingDetailsId
        {
            get { return billingDetailsId; }
            set { billingDetailsId = value; }
        }
        public long OrgId
        {
            get { return orgId; }
            set { orgId = value; }
        }
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }
        public long ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }
        public long ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        public long InvoiceId
        {
            get { return invoiceId; }
            set { invoiceId = value; }
        }
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }
        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string ReferenceType
        {
            get { return referenceType; }
            set { referenceType = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }
        public string BillSupplyNumber
        {
            get { return billSupplyNumber; }
            set { billSupplyNumber = value; }
        }
        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }
        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }
        public string CreditNote
        {
            get { return creditNote; }
            set { creditNote = value; }
        }
        public string InvoicegenBy
        {
            get { return invoicegenBy; }
            set { invoicegenBy = value; }
        }
        public string ExtraNote
        {
            get { return extraNote; }
            set { extraNote = value; }
        }
        public string Command
        {
            get { return command; }
            set { command = value; }
        }
        public DateTime CancelledDate
        {
            get { return cancelledDate; }
            set { cancelledDate = value; }
        }
        public DateTime InvoioceDate
        {
            get { return invoioceDate; }
            set { invoioceDate = value; }
        }
        public Decimal AmountCharged
        {
            get { return amountCharged; }
            set { amountCharged = value; }
        }
        public Decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }
        public Decimal GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }
        public Decimal InvoiceAmount
        {
            get { return invoiceAmount; }
            set { invoiceAmount = value; }
        }

		#endregion
}
}
    