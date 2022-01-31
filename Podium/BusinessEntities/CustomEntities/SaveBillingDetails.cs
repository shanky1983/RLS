using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class SaveBillingDetails
    {

        private long id = 0;
        private decimal amount = 0;
        private string description = String.Empty;
        private string isGroup = String.Empty;
        private string status = String.Empty;
        private decimal quantity = 0;
        private decimal rate = 0;
        private string isReimbursable = string.Empty;
        private string isTaxable = string.Empty;
        private string serviceCode = string.Empty;
        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string IsGroup
        {
            get { return isGroup; }
            set { isGroup = value; }

        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public string FeeType
        {
            get;
            set;
        }

        public string IsReimbursable
        {
            get { return isReimbursable; }
            set { isReimbursable = value; }
        }

        public string IsTaxable
        {
            get { return isTaxable; }
            set { isTaxable = value; }
        }

        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }

    }

}
