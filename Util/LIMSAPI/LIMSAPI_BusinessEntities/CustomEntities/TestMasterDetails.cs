using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public class TestMasterDetails
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
       public List<TestInv> TestInfo { get; set; }
        public string Gender { get; set; }

        public int SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
    public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public decimal Price { get; set; }
        public string DepartmentName { get; set; }
        public long DepartmentID { get; set; }
        public string Status { get; set; }
     

    }
    public class TestMasterDetInfo
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
        public string INVTestCode { get; set; }
        public string INVInvestigationName { get; set; }
        public string Gender { get; set; }

        public int SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public decimal Price { get; set; }
        public decimal GRPPrice { get; set; }
        public decimal PKGPrice { get; set; }
        public string DepartmentName { get; set; }
        public long DepartmentID { get; set; }
        public string Status { get; set; }

    }
    public class TestMasterinvInfo
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
 
        public string Gender { get; set; }

        public int SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public decimal Price { get; set; }
        public string DepartmentName { get; set; }
        public long DepartmentID { get; set; }
        public string Status { get; set; }

    }
    public class TestInv
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
   
        public string Gender { get; set; }

        public int SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
     //   public decimal Price { get; set; }
        public string DepartmentName { get; set; }
        public long DepartmentID { get; set; }
        public string Status { get; set; }
    }
}
