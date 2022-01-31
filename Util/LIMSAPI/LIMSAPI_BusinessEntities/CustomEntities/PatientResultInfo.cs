using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public class PatientResultInfo
    {
        public long PatientId { get; set; }
        public string VisitNumber { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string Type { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public string ResultType { get; set; }
        public string ResultValue { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string IsCritical { get; set; }
        public string Status { get; set; }
        public long OrgID { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDateTime { get; set; }
        public long LocationID { get; set; }
        public string PackageName { get; set; }
    }

    public class PatientResultDetails
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public string PackageName { get; set; }
        public string ResultType { get; set; }
        public string ResultValue { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string IsCritical { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDateTime { get; set; }
    }
}
