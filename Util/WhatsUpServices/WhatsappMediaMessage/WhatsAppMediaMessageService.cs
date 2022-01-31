using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.ServiceProcess;
using System.Text;

using System.Timers;
using WhatsappMediaMessage.Entities;
using MessageBird;
using MessageBird.Exceptions;
using MessageBird.Net.ProxyConfigurationInjector;
using MessageBird.Objects;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Configuration;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;



namespace WhatsappMediaMessage
{
    public partial class WhatsAppMediaMessageService : ServiceBase
    {
        //CLogger ObjLogger = new CLogger();
        System.Timers.Timer _whatsupTimers;
        //private object JsonConvert;
        //static readonly string ChannelId;
        //static readonly string YourAccessKey;
        //static readonly string Namespace;
        //static readonly double ServiceInterval;
        static List<CommunicationConfig> staticCommunicationList = new List<CommunicationConfig>();
        static WhatsAppMediaMessageService()
        {
            using (MediaEntities db = new MediaEntities())
            {
                //var channelID = db.CommunicationConfigs.Where(c => c.Type == "WhatsApp" && c.Name == "ChannelID").FirstOrDefault();
                //var yourAccessKey = db.CommunicationConfigs.Where(c => c.Type == "WhatsApp" && c.Name == "YourAccessKey").FirstOrDefault();
                //var @namespace = db.CommunicationConfigs.Where(c => c.Type == "WhatsApp" && c.Name == "Namespace").FirstOrDefault();
                //var serviceInterval = db.CommunicationConfigs.Where(c => c.Type == "WhatsApp" && c.Name == "ServiceInterval").FirstOrDefault();
                //ChannelId = channelID.Value.ToString();
                //YourAccessKey = yourAccessKey.Value.ToString();
                //Namespace = @namespace.Value.ToString();
                //ServiceInterval = Convert.ToDouble(serviceInterval.Value);
                staticCommunicationList = db.CommunicationConfigs.Where(o => o.Type == "WhatsApp").ToList();
            }


        }
        public WhatsAppMediaMessageService()
        {
            InitializeComponent();
            //Double Timer = Convert.ToDouble(ConfigurationManager.AppSettings["TimerSchedule"]);
            _whatsupTimers = new System.Timers.Timer(10000);
            _whatsupTimers.Elapsed += new System.Timers.ElapsedEventHandler(_whatsupTimers_Elapsed);
        }
        

        private void _whatsupTimers_Elapsed(object sender, ElapsedEventArgs e)
        {
            int NotificationId = -1;

            using (MediaEntities db = new MediaEntities())
            {
                MediaMessage message = new MediaMessage();
                Content content = new Content();
                HSM hsm = new HSM();
                Languages language = new Languages();
                List<Components> components = new List<Components>();
                Components objcompo;
                WhatsappMediaMessage.Entities.Parameter objparam;
                List<WhatsappMediaMessage.Entities.Parameter> parameters = new List<WhatsappMediaMessage.Entities.Parameter>();
                Document document = new Document();

                var notification = (from n in db.Notifications
                                    join w in db.WhatsUpTemplateMasters on n.Template equals w.TemplateName
                                    where w.MessageType == "WhatsAppMediaMessge" && n.Category == "whatsapp"
                         && n.ActionType == "WhatsApp" && n.IsAttachment == "Y" && n.Status == ""
                                   select n

                             ).Take(20);

                List<Notification> pickedNotification = (from x in db.Notifications
                                                         join y in notification on x.NotificationID equals y.NotificationID
                                                         select x).ToList();

                foreach (var item in pickedNotification)
                {
                    item.Status = "Picked";
                    item.RetryCount = +1;
                    item.CompletionTime = DateTime.Now;
                }
                db.SaveChanges();
                foreach (var item in pickedNotification)
                {
                    string ChannelId;
                    string YourAccessKey;
                    string Namespace;
                    double ServiceInterval;
                    var channelID = staticCommunicationList.Where(c => c.Type == "WhatsApp" && c.Name == "ChannelID" && c.OrgID == item.OrgID).FirstOrDefault();
                    var yourAccessKey = staticCommunicationList.Where(c => c.Type == "WhatsApp" && c.Name == "YourAccessKey" && c.OrgID == item.OrgID).FirstOrDefault();
                    var nameSpace = staticCommunicationList.Where(c => c.Type == "WhatsApp" && c.Name == "Namespace" && c.OrgID == item.OrgID).FirstOrDefault();
                    var serviceInterval = staticCommunicationList.Where(c => c.Type == "WhatsApp" && c.Name == "ServiceInterval" && c.OrgID == item.OrgID).FirstOrDefault();
                    ChannelId = channelID.Value.ToString();
                    YourAccessKey = yourAccessKey.Value.ToString();
                    Namespace = nameSpace.Value.ToString();
                    ServiceInterval = Convert.ToDouble(serviceInterval.Value);

                    NotificationId = item.NotificationID;

                        //PickedAt 
                        //MediaEntities mmedb = new MediaEntities();
                        //Notification objNotification = mmedb.Notifications
                        //    .Single(x => x.NotificationID == NotificationId);
                        //objNotification.Status = "Picked";
                        //objNotification.RetryCount = 1;
                        //objNotification.CompletionTime = DateTime.Now;
                        //mmedb.SaveChanges();

                        var orgName = (from o in db.Organizations
                                       where o.OrgID == item.OrgID
                                       select new
                                       {
                                           OrgName = o.Name,

                                       }).FirstOrDefault();

                        var reportpath = item.AdditionalContext.Split('|');
                        reportpath = reportpath.Where(s => !string.IsNullOrEmpty(s)).ToArray();

                        document.url = reportpath[1].ToString();
                        document.caption = reportpath[2].ToString();

                        components.Add(GetParametersList(document));

                        language.policy = "deterministic";
                        language.code = "en";

                        hsm.@namespace = Namespace;
                        hsm.templateName = item.Template;
                        hsm.language = language;

                        objcompo = new Components();
                        objcompo.type = "body";
                        objparam = new WhatsappMediaMessage.Entities.Parameter();
                        objparam.type = "text";
                        objparam.text = reportpath[3].ToString();
                        parameters.Add(objparam);
                        objcompo.parameters = parameters;

                        objparam = new WhatsappMediaMessage.Entities.Parameter();
                        objparam.type = "text";
                        objparam.text = reportpath[4].ToString();
                        parameters.Add(objparam);
                        objcompo.parameters = parameters;

                        objparam = new WhatsappMediaMessage.Entities.Parameter();
                        objparam.type = "text";
                        objparam.text = (reportpath[5].ToString() + " " + reportpath[6].ToString());
                        parameters.Add(objparam);
                        objcompo.parameters = parameters;

                        objparam = new WhatsappMediaMessage.Entities.Parameter();
                        objparam.type = "text";
                        objparam.text = orgName.OrgName;
                        parameters.Add(objparam);
                        objcompo.parameters = parameters;
                        //components.Add(objcompo);

                        objparam = new WhatsappMediaMessage.Entities.Parameter();
                        objparam.type = "text";
                        objparam.text = orgName.OrgName;
                        parameters.Add(objparam);
                        objcompo.parameters = parameters;
                        components.Add(objcompo);

                        hsm.components = components.ToList();

                        content.hsm = hsm;

                        message.type = "hsm";
                        message.to = item.Value;
                        message.channelId = ChannelId;
                        message.content = content;

                        if (message != null)
                        {
                            //var jsonmessage = JsonConvert.SerializeObject(message); 
                            var jsonmessage = JsonConvert.SerializeObject(message, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                            SendWhatsAppMediatMessage(YourAccessKey, NotificationId, jsonmessage);
                        }
                    
                }

                

            }
        }

        private static void SendWhatsAppMediatMessage(string YourAccessKey, long NotificationId, string jsonmessage)
        {
            try
            {



                //client.Timeout = -1;
                //var request = new RestRequest(Method.POST);
                //string aKey = String.Empty;
                //request.AddHeader("Authorization", string.Concat("AccessKey ", YourAccessKey));
                //request.AddHeader("Content-Type", "application/json");
                //request.AddParameter("application/json", jsonmessage, ParameterType.RequestBody);
                //IRestResponse response = client.Execute(request);

                //client.BaseAddress = new Uri(url);
                using (var client = new WebClient()) //WebClient  
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    var baseAddress = @"https://conversations.messagebird.com/v1/conversations/start";

                    var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
                    http.Headers.Add("Authorization", string.Concat("AccessKey ", YourAccessKey));
                    http.Accept = "application/json";
                    http.ContentType = "application/json";
                    http.Method = "POST";

                    string parsedContent = jsonmessage;
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    Byte[] bytes = encoding.GetBytes(parsedContent);

                    Stream newStream = http.GetRequestStream();
                    newStream.Write(bytes, 0, bytes.Length);
                    newStream.Close();

                    var response = http.GetResponse();

                    var stream = response.GetResponseStream();
                    var sr = new StreamReader(stream);
                    var content = sr.ReadToEnd();
                }

                MediaEntities mmedb = new MediaEntities();
                Notification objNotification = mmedb.Notifications
                    .Single(x => x.NotificationID == NotificationId);
                objNotification.Status = "Completed";
                objNotification.CompletionTime = DateTime.Now;
                mmedb.SaveChanges();
            }
            catch (ErrorException e)
            {
                // Either the request fails with error descriptions from the endpoint.
                if (e.HasErrors)
                {
                    foreach (Error error in e.Errors)
                    {
                        MediaEntities mmedb = new MediaEntities();
                        Notification objNotification = mmedb.Notifications
                            .Single(x => x.NotificationID == NotificationId);
                        objNotification.Status = "ERROR";
                        objNotification.CompletionTime = DateTime.Now;
                        mmedb.SaveChanges();
                    }
                }
                // or fails without error information from the endpoint, in which case the reason contains a 'best effort' description.
                if (e.HasReason)
                {

                    MediaEntities mmedb = new MediaEntities();
                    Notification objNotification = mmedb.Notifications
                        .Single(x => x.NotificationID == NotificationId);
                    objNotification.Status = "ERROR";
                    objNotification.CompletionTime = DateTime.Now;
                    mmedb.SaveChanges();
                    //Console.WriteLine(e.Reason);

                }
            }
        }
        
        public Components GetParametersList(Document document)
        {
            List< WhatsappMediaMessage.Entities.Parameter > parameters = new List<WhatsappMediaMessage.Entities.Parameter>();
            WhatsappMediaMessage.Entities.Parameter objpram = new WhatsappMediaMessage.Entities.Parameter();
            Components objcompo = new Components();
            List<Components> components = new List<Components>();
            objpram.type = "document";
            objpram.document = document;
            parameters.Add(objpram);

            objcompo.type = "header";
            objcompo.parameters = parameters.ToList();

            return objcompo;
        }
        

        protected override void OnStart(string[] args)
        {
            try
            {
                _whatsupTimers.Enabled = true;
            }
            catch (Exception objExp)
            {

               // ObjLogger.LogError(objExp);
            }
            
        }

        protected override void OnStop()
        {
            _whatsupTimers.Enabled = false;
        }
    }
}
