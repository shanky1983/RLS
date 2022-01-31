using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
  public class SalesTax
  {
    
        #region Fields

        private long finalBillID = 0;
        private string receiptno = String.Empty;
        private decimal netamount = 0;
        private decimal grossamount = 0;
        private decimal receivedamount = 0;
        private decimal dueamount = 0;
        private decimal taxamount4 = 0;
        public decimal TaxAmount145 { get; set; }
        public decimal TaxAmount55 { get; set; }
        private decimal taxamount5 = Decimal.Zero;
        private decimal taxamount12 = Decimal.Zero;
        private decimal taxamount13 = Decimal.Zero;
        private decimal taxamount14 = Decimal.Zero;
        private decimal taxamount0 = Decimal.Zero;

        private decimal taxpayable4 = 0;
        private decimal taxpayable5 = Decimal.Zero;
        private decimal taxpayable12 = Decimal.Zero;
        private decimal taxpayable13 = Decimal.Zero;
        private decimal taxpayable14 = Decimal.Zero;
        private decimal taxpayable0 = Decimal.Zero;
        private decimal others = Decimal.Zero;


        private DateTime createdAt = DateTime.MaxValue;
        private string comments = String.Empty;
        private string type = String.Empty;
        private string name = String.Empty;
        //newly added 
        private decimal billamount = Decimal.Zero;
        private decimal previousdue = Decimal.Zero;
        private decimal creditdue = Decimal.Zero;

        private decimal discount = Decimal.Zero;
        private decimal netValue = Decimal.Zero;
        private decimal receivedAmountsummary = Decimal.Zero;
        private decimal cash = Decimal.Zero;
        private decimal cards = Decimal.Zero;
        private decimal cheque = Decimal.Zero;
        private decimal dd = Decimal.Zero;
        private decimal due = Decimal.Zero;
        private string  visitType = String.Empty;
        private decimal amountRefund = Decimal.Zero;
        private decimal depositUsed = Decimal.Zero;
        private decimal coPayment = Decimal.Zero;
        private string billNumber = String.Empty;
        private decimal grossBillValue = Decimal.Zero;
        private decimal taxAmount = Decimal.Zero;
        private decimal advanceRecieved = Decimal.Zero;
        private decimal taxPercent = Decimal.Zero;
        private decimal amountReceived = Decimal.Zero;
        private decimal serviceCharge = Decimal.Zero;
        private decimal currentDue = Decimal.Zero;
        private long referenceBillID = 0;
      
        #endregion 


        #region Properties
        /// <summary>
        /// Gets or sets the FinalBillID value.
        /// </summary>
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }

        /// <summary>
        /// Gets or sets the ReceiptNo value.
        /// </summary>
        public string ReceiptNo
        {
            get { return receiptno; }
            set { receiptno = value; }
        }



        public DateTime CreatedAt
        {
            get { return createdAt ; }
            set { createdAt = value; }
        }
       

        /// <summary>
        /// Gets or sets the NetAmount value.
        /// </summary>
        public decimal NetAmount
        {
            get { return netamount; }
            set { netamount = value; }
        }

        public decimal GrossAmount
        {
            get { return grossamount; }
            set { grossamount = value; }
        }

        public decimal DueAmount
        {
            get { return dueamount ; }
            set { dueamount = value; }
        }

        /// <summary>
        /// Gets or sets the TaxAmount4 value.
        /// </summary>
        public decimal TaxAmount4
        {
            get { return taxamount4; }
            set { taxamount4 = value; }
        }



        /// <summary>
        /// Gets or sets the TaxAmount5 value.
        /// </summary>
        public decimal TaxAmount5
        {
            get { return taxamount5; }
            set { taxamount5 = value; }
        }


        public decimal ReceivedAmount
        {
            get { return receivedamount; }
            set { receivedamount = value; }
        }


        /// <summary>
        /// Gets or sets the TaxAmount12 value.
        /// </summary>
        public decimal TaxAmount12
        {
            get { return taxamount12; }
            set { taxamount12 = value; }
        }



        /// <summary>
        /// Gets or sets the TaxAmount13 value.
        /// </summary>
        public decimal TaxAmount13
        {
            get { return taxamount13; }
            set { taxamount13 = value; }
        }

        /// <summary>
        /// Gets or sets the TaxAmount5 value.
        /// </summary>
        public decimal TaxAmount14
        {
            get { return taxamount14; }
            set { taxamount14 = value; }
        }


        /// <summary>
        /// Gets or sets the TaxAmount0 value.
        /// </summary>
        public decimal TaxAmount0
        {
            get { return taxamount0; }
            set { taxamount0 = value; }
        }



       
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

      


        //taxable amounts 


        public decimal TaxableAmount4
        {
            get { return taxpayable4; }
            set { taxpayable4 = value; }
        }



        /// <summary>
        /// Gets or sets the TaxableAmount5 value.
        /// </summary>
        public decimal TaxableAmount5
        {
            get { return taxpayable5; }
            set { taxpayable5 = value; }
        }


        /// <summary>
        /// Gets or sets the TaxableAmount12 value.
        /// </summary>
        public decimal TaxableAmount12
        {
            get { return taxpayable12; }
            set { taxpayable12 = value; }
        }



        /// <summary>
        /// Gets or sets the TaxAmount13 value.
        /// </summary>
        public decimal TaxableAmount13
        {
            get { return taxpayable13; }
            set { taxpayable13 = value; }
        }

        /// <summary>
        /// Gets or sets the TaxAmount5 value.
        /// </summary>
        public decimal TaxableAmount14
        {
            get { return taxpayable14; }
            set { taxpayable14 = value; }
        }


        /// <summary>
        /// Gets or sets the TaxableAmount0 value.
        /// </summary>
        public decimal TaxableAmount0
        {
            get { return taxpayable0; }
            set { taxpayable0 = value; }
        }

        public decimal Others
        {
            get { return others; }
            set { others = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
      


      


        public string Type
        {
            get { return type; }
            set { type = value; }
        }




        public decimal BillAmount
        {
            get { return billamount ; }
            set { billamount = value; }
        }

        public decimal PreviousDue
        {
            get { return previousdue; }
            set { previousdue = value; }
        }

        public decimal CreditDue
        {
            get { return creditdue; }
            set { creditdue = value; }
        }



        public decimal Discount
        {
            get { return discount ; }
            set { discount = value; }
        }

        public decimal NetValue
        {
            get { return netValue ; }
            set { netValue = value; }
        }

        public decimal ReceivedAmountsummary
        {
            get { return receivedAmountsummary; }
            set { receivedAmountsummary = value; }
        }


        public decimal Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public decimal Cards
        {
            get { return cards ; }
            set { cards = value; }
        }

        public decimal Cheque
        {
            get { return cheque ; }
            set { cheque = value; }
        }



      

        public decimal DD
        {
            get { return dd; }
            set { dd = value; }
        }

        public decimal Due
        {
            get { return due ; }
            set { due = value; }
        }

        public string VisitType
        {
            get { return visitType ; }
            set { visitType = value; }
        }

        public decimal AmountRefund
        {
            get { return amountRefund ; }
            set { amountRefund = value; }
        }

        public decimal DepositUsed
        {
            get { return depositUsed ; }
            set { depositUsed = value; }
        }

        public decimal CoPayment
        {
            get { return coPayment; }
            set { coPayment = value; }
        }
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        public decimal GrossBillValue
        {
            get { return grossBillValue; }
            set { grossBillValue = value; }
        }
        public decimal TaxAmount
        {
            get { return taxAmount; }
            set { taxAmount = value; }
        }
        public decimal AdvanceRecieved
        {
            get { return advanceRecieved; }
            set { advanceRecieved = value; }
        }
        public decimal TaxPercent
        {
            get { return taxPercent; }
            set { taxPercent = value; }
        }
        public decimal AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }

        public decimal ServiceCharge
        {
            get { return serviceCharge; }
            set { serviceCharge = value; }
        }
        public decimal CurrentDue
        {
            get { return currentDue; }
            set { currentDue = value; }
        }
        public long ReferenceBillID
        {
            get { return referenceBillID; }
            set { referenceBillID = value; }
        }
        string _ClientName = string.Empty;
        public string ClientName
        {
            get { return _ClientName; }
            set { _ClientName = value; }
        }


        #endregion




    }
}
