using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class DeviceInfo
    {
        public long InvestigationProductMapID { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string MethodName { get; set; }
        public string OrgCode { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }

    public class DeviceProductInfoList
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal ConsumptionQty { get; set; }
        public string UOMCode { get; set; }
        public decimal CalibrationQty { get; set; }
        public string IsActive { get; set; }
        public long ProductConsumptionMappingID { get; set; }
        public long InvestigationProductMapDetailID { get; set; }
        public long InvestigationProductMapID { get; set; }
        public string Status { get; set; }
        public int CategoryID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

            
    }
    
}
