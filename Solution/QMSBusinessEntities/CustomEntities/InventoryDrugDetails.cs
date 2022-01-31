using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InventoryDrugDetails
    {
        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private decimal _stockInHand;

        public decimal StockInHand
        {
            get { return _stockInHand; }    
            set { _stockInHand = value; }
        }

        private string _productID;

        public string ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private char _transactionBlock;

        public char TransactionBlock
        {
            get { return _transactionBlock; }
            set { _transactionBlock = value; }
        }

        private char _isGenericName;

        public char IsGenericName
        {
            get { return _isGenericName; }
            set { _isGenericName = value; }
        }

        private long _genericID;

        public long GenericID
        {
            get { return _genericID; }
            set { _genericID = value; }
        }

        private long _drugFrequencyID;

        public long DrugFrequencyID
        {
            get { return _drugFrequencyID; }
            set { _drugFrequencyID = value; }
        }

        private int _drugInstructionID;

        public int DrugInstructionID
        {
            get { return _drugInstructionID; }
            set { _drugInstructionID = value; }
        }

        private decimal _quantity;

        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private string _durationType;

        public string DurationType
        {
            get { return _durationType; }
            set { _durationType = value; }
        }

        private string _duration;

        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
