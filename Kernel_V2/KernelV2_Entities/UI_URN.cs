using System.Collections.Generic;


namespace Attune.KernelV2.Entities
{
    public class UI_URNTypes
    {
        public long URNTypeId { get; set; }
        public long URNofId { get; set; }
        public string URN { get; set; }
        public string Displaytext { get; set; }
    }

    public class UI_URNof
    {
        public string URNOf { get; set; }
        public long URNOfId { get; set; }
        public string LangCode { get; set; }
    }

    public class UI_URN
    {
        public List<UI_URNTypes> lstURNTypes { get; set; }
        public List<UI_URNof> lstURNof { get; set; }
    }
}
