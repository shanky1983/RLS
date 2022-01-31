using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class SampleDataInfo
    {
        public long PackageID { get; set; }
        public string PackageName { get; set; }
        public long InvestigationID { get; set; }
        public string InvestigationCode { get; set; }
        public string InvestigationName { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public long TestID { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public long SampleID { get; set; }
        public string SampleCode { get; set; }
        public string SampleName { get; set; }
        public long SampleContainerID { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public decimal Price { get; set; }
        public decimal GRPPrice { get; set; }
        public decimal PKGPrice { get; set; }
        public long DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public long OrgID { get; set; }
        public string Status { get; set; }
        public string InvStatus { get; set; }
        public long BookingID { get; set; }
        public string TestType { get; set; }
        public string OrderType { get; set; }
    }
}
