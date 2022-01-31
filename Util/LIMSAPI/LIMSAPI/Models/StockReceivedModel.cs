using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class StockReceivedModel
    {
		public string OrgCode { get; set; }
        public long ReceiptId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public List<items> Items { get; set; }
    }

    public class items
    {
        public string ItemCode { get; set; }
        public long ProductID { get; set; }
        public string lotNumber { get; set; }
        public string PurchaseUom { get; set; }
        public int PurchaseQuantity { get; set; }
        public int Converstionqty { get; set; }
        public string LeastSellingUnit { get; set; }
        public int BaseQuantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ManufactureDate { get; set; }
    }
}