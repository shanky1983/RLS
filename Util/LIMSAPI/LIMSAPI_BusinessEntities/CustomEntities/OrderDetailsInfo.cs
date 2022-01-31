using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrderDetailsInfo
    {
        public long PatientVisitID { get; set; }
        public string TestID { get; set; }
        public string TestCode { get; set; }
        public string ExternalVisitID { get; set; }
        public string OrderedDate { get; set; }
        public string TestType { get; set; }
        public string TestName { get; set; }
        public string TestValue { get; set; }
        public string UOMCode { get; set; }
        public string MethodName { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string ResultCapturedAt { get; set; }
        public string TestStatus { get; set; }
    }
}