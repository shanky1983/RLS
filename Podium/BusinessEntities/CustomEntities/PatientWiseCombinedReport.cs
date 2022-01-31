using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable()]
    public class PatientWiseCombinedReport
    {
        #region Fields

        private string year = String.Empty;
        private string month = String.Empty;
        private string date = String.Empty;
        private string screenedAt = String.Empty;
        private string revenueCentre = String.Empty;
         private string drName = String.Empty;
         private string drCategory = String.Empty;
         private string referedBy = String.Empty;
         private string billNo = String.Empty;
         private string receiptNo = String.Empty;
         private string patientName = String.Empty;
         private string visitType = String.Empty;
         private string modeOfPayment = String.Empty;
         private string panelName = String.Empty;
         private string surgeryName = String.Empty;
         private string surgeryType = String.Empty;
         private string lenseName = String.Empty;
         private decimal lensePrice = 0;
         private decimal surgicalFee = 0;
         private string discountRemarks = String.Empty;
          private decimal oPDCredit = 0;
         private decimal oPDCash = 0;
          private decimal surgeryCredit = 0;
         private decimal surgeryCash = 0;
          private decimal oPDPROCredit = 0;
         private decimal oPDPROCash = 0;
          private decimal creditCardPayment = 0;
         private decimal chequePayment = 0;
         private string billStatus = String.Empty;
         private decimal billAmount = 0;
         private decimal referralCommission = 0;
         private DateTime billSubDate = DateTime.MaxValue;
         private decimal billSubAmount = 0;
         private string paymentStatus = String.Empty;
         private DateTime payRecDate = DateTime.MaxValue;
         private decimal receiptAmount = 0;
         private long chequeNo = 0;
         private DateTime chequeDate = DateTime.MaxValue;
         private string bankName = String.Empty;
         private string bankCity = String.Empty;
         private string aRAgeing = String.Empty;
         private decimal dedNonPayItems = 0;
         private decimal discount = 0;
         private decimal tDSDeduction = 0;
         private decimal totalDeduction = 0;
         private decimal packaging = 0;
        
        #endregion

        #region Properties
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string ScreenedAt
        {
            get { return screenedAt; }
            set { screenedAt = value; }
        }
        public string RevenueCentre
        {
            get { return revenueCentre; }
            set { revenueCentre = value; }
        }
         public string DrName
        {
            get { return drName; }
            set { drName = value; }
        }
         public string DrCategory
        {
            get { return drCategory; }
            set { drCategory = value; }
        }
         public string ReferedBy
        {
            get { return referedBy; }
            set { referedBy = value; }
        }
         public string BillNo
        {
            get { return billNo; }
            set { billNo = value; }
        }
         public string ReceiptNo
        {
            get { return receiptNo; }
            set { receiptNo = value; }
        }
         public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
         public string VisitType
        {
            get { return visitType; }
            set { visitType = value; }
        }
         public string ModeOfPayment
        {
            get { return modeOfPayment; }
            set { modeOfPayment = value; }
        }
         public string PanelName
        {
            get { return panelName; }
            set { panelName = value; }
        }
         public string SurgeryName
        {
            get { return surgeryName; }
            set { surgeryName = value; }
        }
         public string SurgeryType
        {
            get { return surgeryType; }
            set { surgeryType = value; }
        }
         public string LenseName
        {
            get { return lenseName; }
            set { lenseName = value; }
        }
         public decimal LensePrice
        {
            get { return lensePrice; }
            set { lensePrice = value; }
        }
         public decimal SurgicalFee
        {
            get { return surgicalFee; }
            set { surgicalFee = value; }
        }
         public string DiscountRemarks
        {
            get { return discountRemarks; }
            set { discountRemarks = value; }
        }
      public decimal OPDCredit
        {
            get { return oPDCredit; }
            set { oPDCredit = value; }
        }   
          public decimal OPDCash
        {
            get { return oPDCash; }
            set { oPDCash = value; }
        }  
          public decimal SurgeryCredit
        {
            get { return surgeryCredit; }
            set { surgeryCredit = value; }
        }
          public decimal SurgeryCash
        {
            get { return surgeryCash; }
            set { surgeryCash = value; }
        }  
          public decimal OPDPROCredit
        {
            get { return oPDPROCredit; }
            set { oPDPROCredit = value; }
        }  
           public decimal OPDPROCash
        {
            get { return oPDPROCash; }
            set { oPDPROCash = value; }
        }  
          public decimal CreditCardPayment
        {
            get { return creditCardPayment; }
            set { creditCardPayment = value; }
        }  
         public decimal ChequePayment
        {
            get { return chequePayment; }
            set { chequePayment = value; }
        }
         public string BillStatus
        {
            get { return billStatus; }
            set { billStatus = value; }
        }
         public decimal BillAmount
        {
            get { return billAmount; }
            set { billAmount = value; }
        }
         public decimal ReferralCommission
        {
            get { return referralCommission; }
            set { referralCommission = value; }
        }
         public DateTime BillSubDate
        {
            get { return billSubDate; }
            set { billSubDate = value; }
        }
         public decimal BillSubAmount
        {
            get { return billSubAmount; }
            set { billSubAmount = value; }
        }
         public string PaymentStatus
        {
            get { return paymentStatus; }
            set { paymentStatus = value; }
        }
         public DateTime PayRecDate
        {
            get { return payRecDate; }
            set { payRecDate = value; }
        }
         public decimal ReceiptAmount
        {
            get { return receiptAmount; }
            set { receiptAmount = value; }
        }
         public long ChequeNo
        {
            get { return chequeNo; }
            set { chequeNo = value; }
        }
         public DateTime ChequeDate
        {
            get { return chequeDate; }
            set { chequeDate = value; }
        }
         public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
         public string BankCity
        {
            get { return bankCity; }
            set { bankCity = value; }
        }
         public string ARAgeing
        {
            get { return aRAgeing; }
            set { aRAgeing = value; }
        }
         public decimal DedNonPayItems
        {
            get { return dedNonPayItems; }
            set { dedNonPayItems = value; }
        }
         public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
         public decimal TDSDeduction
        {
            get { return tDSDeduction; }
            set { tDSDeduction = value; }
        }
         public decimal TotalDeduction
        {
            get { return totalDeduction; }
            set { totalDeduction = value; }
        }
         public decimal Packaging
        {
            get { return packaging; }
            set { packaging = value; }
        }
        
        #endregion
    }
}
