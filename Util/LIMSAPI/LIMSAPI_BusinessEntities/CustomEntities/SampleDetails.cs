using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class SampleDetails
    {
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public string TestCode { get; set; }
        public decimal Price { get; set; }
    }
    public class SampleData
    {
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public List<SampleContentData> TestInfoList { get; set; }
    }

    public class SampleContentData
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string TestType { get; set; }
    }
}
