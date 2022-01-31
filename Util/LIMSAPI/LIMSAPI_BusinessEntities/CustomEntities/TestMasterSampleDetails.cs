using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities 
{
    public class TestMasterSampleDetails:Paging
    {
        public string OrgCode { get; set; }
        public List<TestResultdetails> TestMasterListInfo { get; set; }
       
    }
    public class TestResultdetails
    { 
        public string InvestigationName { get; set; }
        public string InvestigationCode { get; set; }
        public long TestID { get; set; }
        public string TestName { get; set; }
        public string TestCode { get; set; }
        public decimal Price { get; set; }
        public string Gender { get; set; }
        public long DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public List<TestContentDetails> TestContentInfo { get; set; }
        public List<TestSampledetails> SampleListInfo { get; set; }
    }
    public class TestAllResultdetails
    {
        public long InvestigationID { get; set; }
        public string InvestigationName { get; set; }
        public string InvestigationCode { get; set; }
        public long TestID { get; set; }
        public string TestName { get; set; }
        public string TestCode { get; set; }
        public decimal Price { get; set; }
        public long DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColor { get; set; }
        public decimal GRPPrice { get; set; }
        public decimal PKGPrice { get; set; }
        public string InvStatus { get; set; }

    }
    public class TestContentDetails
    {
        public string TestCode { get; set; }
        public long TestID { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        //public long SampleID { get; set; }
        //public string SampleName { get; set; }
        //public long SampleContainerID { get; set; }
        //public long ContainerName { get; set; }
        //public long SampleContainerColor { get; set; }
        public long DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Status { get; set; }
    }
    public class TestAllSampledetails
    {
        public long PackageID { get; set; }
        public string PackageName { get; set; }
        public string TestCode { get; set; }
        public long TestID { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long SampleContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColor { get; set; }
        public List<SampleList> TestInfoList { get; set; }
    }
    public class TestSampledetails
    {  
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public List<SampleList> TestInfoList { get; set; }
    }
    public class SampleList
    {
        public string TestCode { get; set; } 
        public string TestName { get; set; }
        public string Type { get; set; }

    }
}
