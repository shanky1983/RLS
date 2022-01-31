#if KernelV2
namespace Attune.KernelV2.Entities
#else   
namespace Attune.Kernel.BusinessEntities
#endif
{
    public class UI_Department
    {
        public long EmpDeptID { get; set; }
        public string EmpDeptName { get; set; }
        public string Code { get; set; }
        public int OrgID { get; set; }
    }
}
