using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class DeviceInfoModel
    {
        public string OrgCode { get; set; }
        public List<DeviceInfoDetails> DeviceListInfo { get; set; }
        
    }
    public class DeviceInfoDetails
    {
        public ModelDeviceInfo DeviceInfo { get; set; }
        public List<ModelDeviceProductInfoList> DeviceProductInfoList { get; set; }
    }

    public class ModelDeviceInfo
    {       
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string MethodName { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }

    public class ModelDeviceProductInfoList
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int ProductCategoryId { get; set; }
        public decimal ConsumptionQty { get; set; }
        public string UOMCode { get; set; }
        public decimal CalibrationQty { get; set; }
        public string IsActive { get; set; }

    }

}