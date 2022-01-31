using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class PaymentModel
    {
        public string PaymentMode { get; set; }
        public decimal ReceivedAmount { get; set; }
        public string TransactionID { get; set; }
        public long CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CurrencyType { get; set; }
    }
}