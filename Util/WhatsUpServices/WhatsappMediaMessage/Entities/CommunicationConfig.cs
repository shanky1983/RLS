using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappMediaMessage.Entities
{
    public class CommunicationConfig
    {
        private string channelID;
        private string yourAccessKey;
        private string _namespace;

        public string ChannelID
        {
            get { return channelID; }
            set { channelID = value; }
        }
        public string YourAccessKey
        {
            get { return yourAccessKey; }
            set { yourAccessKey = value; }
        }
        public string _Namespace
        {
            get { return _namespace; }
            set { _namespace = value; }
        }
    }
}
