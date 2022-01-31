using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappMediaMessage.Entities
{
    public class MediaMessage
    {
        public string type { get; set; }
        public string to { get; set; }
        public string channelId { get; set; }
        public Content content { get; set; }
    }
}
