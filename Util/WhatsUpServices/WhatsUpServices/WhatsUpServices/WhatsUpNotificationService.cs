using MessageBird;
using MessageBird.Exceptions;
using MessageBird.Net.ProxyConfigurationInjector;
using MessageBird.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace WhatsUpServices
{
    public partial class WhatsUpNotificationService : ServiceBase
    {
        System.Timers.Timer _whatsupTimers;
        const string ChannelId = "";
        const string YourAccessKey = "";
        const string Namespace = "";
        public WhatsUpNotificationService()
        {
            InitializeComponent();
            _whatsupTimers = new System.Timers.Timer(90000);
            _whatsupTimers.Elapsed += new System.Timers.ElapsedEventHandler(_whatsupTimers_Elapsed);
        }

        private void _whatsupTimers_Elapsed(object sender, ElapsedEventArgs e)
        {

            //string strTo = "+919994420645";
            //string strTemplateName = "hcbookingconfirmation";

            string strTo = string.Empty;
            string strTemplateName = "hcbookingconfirmation";
            string strTemplateParamJSON = string.Empty;
            long WhatsUpNotificationId = -1;

            using (Entities db = new Entities())
            {
                WhatsUpNotification notification = db.WhatsUpNotifications.Where(x => x.IsSentYN == "N"
                  && x.IsErrorYN == "N").FirstOrDefault();
                
                if (notification!=null)
                {
                    strTo = notification.MobileNo;
                    WhatsUpNotificationId = notification.WhatsUpNotificationId;
                    strTemplateParamJSON = notification.TemplateParamJSON;

                    var master = (from m in db.WhatsUpTemplateMasters
                                  join n in db.WhatsUpNotifications on m.TemplateMasterNo
                                  equals n.TemplateMasterNo
                                  where n.WhatsUpNotificationId == WhatsUpNotificationId
                                  select new
                                  {
                                      TemplateName = m.TemplateName,
                                      NoofParameters = m.NoofParameters
                                  }).FirstOrDefault();

                    strTemplateName = master.TemplateName;
                    if (!strTo.Equals(string.Empty) && WhatsUpNotificationId > 0)
                    {
                        SendWhatsUpTextMessage(strTo, strTemplateName, WhatsUpNotificationId, strTemplateParamJSON);
                    }
                    else if (true)
                    {
                        SendWhatsUpMediaMessage(strTo, strTemplateName, WhatsUpNotificationId, strTemplateParamJSON)
                    }

                }

                
            }
                
           
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
        }

        private void SendWhatsUpMediaMessage(string strTo, string strTemplateName, long whatsUpNotificationId, string strTemplateParamJSON)
        {

        }

        private static void SendWhatsUpTextMessage(string strTo, string strTemplateName,long WhatsUpNotificationId,string strTemplateParamJSON)
        {

            string[] templateParamArray;
            templateParamArray = strTemplateParamJSON.Split('|').ToArray();
            IProxyConfigurationInjector proxyConfigurationInjector = null;
            Client client = Client.CreateDefault(YourAccessKey, proxyConfigurationInjector);
            MessageBird.Objects.Conversations.ConversationStartRequest message = new MessageBird.Objects.Conversations.ConversationStartRequest();
            MessageBird.Objects.Conversations.Content content = new MessageBird.Objects.Conversations.Content();
            message.Type = MessageBird.Objects.Conversations.ContentType.Hsm;
            message.To = strTo;

            message.ChannelId = ChannelId;
            MessageBird.Objects.Conversations.HsmLocalizableParameter obj = new MessageBird.Objects.Conversations.HsmLocalizableParameter();
            List<MessageBird.Objects.Conversations.HsmLocalizableParameter> lstparam = new List<MessageBird.Objects.Conversations.HsmLocalizableParameter>();
            foreach (var item in templateParamArray)
            {
                obj = new MessageBird.Objects.Conversations.HsmLocalizableParameter();
                obj.Default = item;
                lstparam.Add(obj);
            }
          
            content.Hsm = new MessageBird.Objects.Conversations.HsmContent
            {
                Namespace = Namespace,
                TemplateName = strTemplateName,
                Language = new MessageBird.Objects.Conversations.HsmLanguage
                {
                    Policy = MessageBird.Objects.Conversations.HsmLanguagePolicy.Deterministic,
                    Code = "en"
                },
                Params = lstparam
            };
            message.Content = content;

            try
            {
                MessageBird.Objects.Conversations.Conversation conversation = client.StartConversation(message);
                //var jsonString = JsonConvert.SerializeObject(
                //        conversation, Formatting.Indented,
                //        new JsonConverter[] { });

                Entities entities = new Entities();
                WhatsUpNotification objNotification = entities
                    .WhatsUpNotifications
                    .Single(x => x.WhatsUpNotificationId == WhatsUpNotificationId);
                objNotification.IsErrorYN = "Y";
                objNotification.IsSentYN = "Y";
                entities.SaveChanges();
             
            }
            catch (ErrorException e)
            {
                // Either the request fails with error descriptions from the endpoint.
                if (e.HasErrors)
                {
                    foreach (Error error in e.Errors)
                    {
                        Entities entities = new Entities();
                        WhatsUpNotification objNotification = entities
                            .WhatsUpNotifications
                            .Single(x => x.WhatsUpNotificationId == WhatsUpNotificationId);
                        objNotification.IsErrorYN = "Y";
                        objNotification.IsSentYN = "N";
                        entities.SaveChanges();
                        //Console.WriteLine("code: {0} description: '{1}' parameter: '{2}'", error.Code, error.Description, error.Parameter);
                    }
                }
                // or fails without error information from the endpoint, in which case the reason contains a 'best effort' description.
                if (e.HasReason)
                {

                    Entities entities = new Entities();
                    WhatsUpNotification objNotification = entities
                        .WhatsUpNotifications
                        .Single(x => x.WhatsUpNotificationId == WhatsUpNotificationId);
                    objNotification.IsErrorYN = "Y";
                    objNotification.IsSentYN = "N";
                    entities.SaveChanges();
                    //Console.WriteLine(e.Reason);

                }
            }
        }

        protected override void OnStart(string[] args)
        {
            _whatsupTimers.Enabled = true;

        }

        protected override void OnStop()
        {
            _whatsupTimers.Enabled = false;
        }
    }
}
