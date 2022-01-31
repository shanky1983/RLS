using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public  class TestMasterData:Paging
    {
        public string OrgCode { get; set; }

        //public string TestCode { get; set; }
        //public string TestName { get; set; }
        //public string Type { get; set; }
        //public string Gender { get; set; }

        //public int SampleID { get; set; }
        //public string SampleName { get; set; }
        //public long SampleContainerID { get; set; }
        //public string ContainerName { get; set; }

        //public string DepartmentName { get; set; }
        //public long DepartmentID { get; set; }
        //public string Status { get; set; }

       public List<TestMasterinvInfo> ParameterInfoList { get; set; }
    }
    public class TestMasterDataGRP : Paging
    {
        public string OrgCode { get; set; }

        //public string TestCode { get; set; }
        //public string TestName { get; set; }
        public List<TestMasterDetails> ParameterInfoList { get; set; }
    }
    public class TestMasterDataPKG : Paging
    {
        public string OrgCode { get; set; }

        //public string TestCode { get; set; }
        //public string TestName { get; set; }
        public List<TestMasterDetails> ParameterInfoList { get; set; }
    }
}
