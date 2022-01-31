using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappMediaMessage.Entities
{
    public class HSM
    {
        private List<Components> Components = null;
        public string @namespace { get; set; }
        public string templateName { get; set; }
        public Languages language { get; set; }
        public List<Components> components
        {
            get { return Components; }
            set { Components = value; }
        }

    }
}
