using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Attune.Podium.BusinessEntities
{
    public class IPSettlementTransaction
    {
        private decimal receivedAmount = Decimal.Zero;
        private decimal iPAdvance = 0;
        private decimal surgeryAdvance = 0;
        private decimal surgery = 0;
        private decimal tPAPaidAmount = 0;
        private decimal refundAmt = Decimal.Zero;
        private decimal treatmentAmount = Decimal.Zero;
        private decimal tMedicalAmountAmount = Decimal.Zero;
        private decimal tNonMedicalAmountAmount = Decimal.Zero;
        private decimal tCosharingtotal = Decimal.Zero;
        private decimal parmacyAmount = Decimal.Zero;
        private decimal parmacyMedicalAmount = Decimal.Zero;
        private decimal parmacyNonMedicalAmount = Decimal.Zero;
        private DateTime admissionDate = DateTime.MaxValue;

        public decimal ReceivedAmount
        {
            get { return receivedAmount; }
            set { receivedAmount = value; }
        }

        public decimal IPAdvance
        {
            get { return iPAdvance; }
            set { iPAdvance = value; }
        }

        public decimal SurgeryAdvance
        {
            get { return surgeryAdvance; }
            set { surgeryAdvance = value; }
        }

        public decimal Surgery
        {
            get { return surgery; }
            set { surgery = value; }
        }

        public decimal TPAPaidAmount
        {
            get { return tPAPaidAmount; }
            set { tPAPaidAmount = value; }
        }
        public decimal RefundAmt
        {
            get { return refundAmt; }
            set { refundAmt = value; }
        }
        public decimal TreatmentAmount
        {
            get { return treatmentAmount; }
            set { treatmentAmount = value; }
        }
        public decimal TMedicalAmountAmount
        {
            get { return tMedicalAmountAmount; }
            set { tMedicalAmountAmount = value; }
        }
        public decimal TNonMedicalAmountAmount
        {
            get { return tNonMedicalAmountAmount; }
            set { tNonMedicalAmountAmount = value; }
        }
        public decimal TCosharingtotal
        {
            get { return tCosharingtotal; }
            set { tCosharingtotal = value; }
        }
        public decimal ParmacyAmount
        {
            get { return parmacyAmount; }
            set { parmacyAmount = value; }
        }
        public decimal ParmacyMedicalAmount
        {
            get { return parmacyMedicalAmount; }
            set { parmacyMedicalAmount = value; }
        }
        public decimal ParmacyNonMedicalAmount
        {
            get { return parmacyNonMedicalAmount; }
            set { parmacyNonMedicalAmount = value; }
        }
        public DateTime AdmissionDate
        {
            get { return admissionDate; }
            set { admissionDate = value; }
        }
        
    }
}
