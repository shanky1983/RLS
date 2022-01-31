using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PackageMasterDetails:Paging
    {
        public string OrgCode { get; set; }
        public  List<PackageMaster> TestMasterListInfo { get; set; }
    }
    public class TestMasterList
    {
        public PackageMaster TestMasterInfo { get; set; }
    }
    public class PackageMaster
    {
        public string TestCode { get; set; }
		public string TestName { get; set; }
        public string Type { get; set; }
        public string TestID { get; set; }
        public string Gender { get; set; }
        public string SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public decimal Price { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Orderable { get; set; }
        public List<PackageGroupMaster> TestContentListInfo { get; set; }
    }
    public class PackageGroupMaster
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
        public string TestID { get; set; }
        public string Gender { get; set; }
        public string SampleID { get; set; }
        public string SampleName { get; set; }
        public int ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; } 
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public List<PackageTestMaster> ParameterListInfo { get; set; }
    }
    public class PackageTestMaster
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
        public string TestID { get; set; }
        public string Gender { get; set; }
        public string SampleID { get; set; }
        public string SampleName { get; set; }
        public int ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; } 
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
    public class PackageDetail
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
        public string TestID { get; set; }
        public string Gender { get; set; }
        public string SampleID { get; set; }
        public string SampleName { get; set; }
        public int ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public string Status { get; set; } 
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GroupGender { get; set; }
        public string PkgCode { get; set; }
        public string PkgName { get; set; }
        public string PkgType { get; set; }
        public string PKGGender { get; set; }
        public string PkgStatus { get; set; }
        public decimal Price { get; set; }
        public long PkgID { get; set; }
        public long GroupID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AttGroupID { get; set; }
        public string TimeZone { get; set; }
        public string Orderable { get; set; }
    }
}
