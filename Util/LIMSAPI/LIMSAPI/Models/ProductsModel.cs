using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LIMSAPI.Models
{
    public class ProductsModel
    {
        public string OrgCode { get; set; }
        public List<ProductListInfo> ProductListInfo { get; set; }
    }

    public class ProductListInfo
    {
        public ProductInfo ProductInfo { get; set; }
        public ProductAttribute ProductAttributeList { get; set; }
        public List<ProductUom> PurchaseUomList { get; set; }
    }
    public class ProductInfo
    {   
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductID { get; set; }
        public string LeastSellingUnit { get; set; }
        public string ManufacturerName { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductTypeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class ProductAttribute
    {    
        public string HasExpiryDate { get; set; }
        public string HasBatchNo { get; set; }
        public string TaxPercent { get; set; }
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

    }
    public class ProductUom
    {
        public string PurchaseUomCode { get; set; }     
        public int ConvesionQty { get; set; }
     

    }
}