using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class StockOutProductIntegarationDetails
    {
        public string OrgCode { get; set; }
        public string OrgLocationCode { get; set; }
        public string OrgLocation { get; set; }
        public string InventoryLocationName { get; set; }
        public string InventoryLocationCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string StockOutType { get; set; }
        public string BatchNo { get; set; }
        public string LeastSellingUnit { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string Commands { get; set; } 
        
        public int OpeningBalance { get; set; }
        public int StockInhandQty { get; set; }
        public int StockOutQty { get; set; }
        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }

        public long ProductID { get; set; }
        public long ReceivedUniqueNumber { get; set; }
        public int LocationID { get; set; }
        public long StockOutFlowID { get; set; }
        public long StockOutMappingDetailsID { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }


    }

   
}
