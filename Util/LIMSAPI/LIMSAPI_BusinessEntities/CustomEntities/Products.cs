using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   

    public class Products
    {
        public string OrgCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public long ProductID { get; set; }
        public string LeastSellingUnit { get; set; }
        public string ManufacturerName { get; set; } 	
        public int ProductCategoryId { get; set; }
        public int ProductTypeId { get; set; }
        public long ProductIntegarationID { get; set; }
        public string Status { get; set; }
        public string HasExpiryDate { get; set; }
        public string HasBatchNo { get; set; }
        public decimal TaxPercent { get; set; }
        public string IsLabAnalyser { get; set; }
        public int ShelfPeriod { get; set; }
        public string ShelfPeriodType { get; set; }
        public string IsScheduleDrug { get; set; }
        public string ScheduleDrugType { get; set; }
        public string IsNorcotic { get; set; }
        public string IsConsumable { get; set; }
        public string CostPrice { get; set; }
        public string SellingPrice { get; set; }
        public int TestCount { get; set; }
        public int ReorderLevelConsumption { get; set; }
        public decimal ConvesionQty { get; set; }
        public string PurchaseUomCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
