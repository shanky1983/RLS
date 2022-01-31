using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{

    public  class ConsumptionReportDetail
    {
        public string OrgCode { get; set; }
        public string OrgLocationCode { get; set; }
        public string InventoryLocationCode { get; set; }

        public string Barcode { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string DeviceName { get; set; }
        public string DeviceCode { get; set; }
        public int TestCount { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
        public int ActualTestsCount { get; set; }
        public int Calibration { get; set; }
        public int QC { get; set; }
        public int Rerun { get; set; }
        public int Others { get; set; }
        public int TotalTests { get; set; }
        public int Variance { get; set; }
        public int PatientCount { get; set; }

        public string ItemBarcode { get; set; }
        public string Remarks { get; set; }
        public string Commends { get; set; }
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }


    public class ConsumptionDetailListItem
    {
        public string OrgCode { get; set; }
        public string OrgLocationCode { get; set; }
        public string InventoryLocationCode { get; set; }
        public List<ConsumptionItemlList> ConsumptionDetailList { get; set; }

    }
    public class ConsumptionItemlList
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string DeviceName { get; set; }
        public string DeviceCode { get; set; }
        public int TestCount { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
        public int ActualTestsCount { get; set; }
        public int Calibration { get; set; }
        public int QC { get; set; }
        public int Rerun { get; set; }
        public int Others { get; set; }
        public int TotalTests { get; set; }
        public int Variance { get; set; }
        public int PatientCount { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}


