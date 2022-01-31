using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class StockOutModel
    {
       public string OrgCode { get; set; }
       public List<StockDetailsList> StockDetailsList { get; set; }
        
         
    }
    public class StockDetails
    {

        public string OrgLocationCode { get; set; }
        public string InventoryLocationName { get; set; }
        public string InventoryLocationCode { get; set; }
        public string ProductCode { get; set; }
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
        public int OpeningBalance { get; set; }        
        public int StockOutQty { get; set; }
        public int StockInhandQty { get; set; }
        public long ReceivedUniqueNumber { get; set; }     

    }

    public class StockOutflowDetailList
    {
        public string StockOutType { get; set; }
        public string BatchNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LeastSellingUnit { get; set; }        
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }

    }
    public class StockDetailsList
    {
        public StockDetails StockDetails { get; set; }
        public List<StockOutflowDetailList> StockOutflowDetailList { get; set; }
    }
}