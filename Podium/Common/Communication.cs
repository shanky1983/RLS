using System;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;


namespace Attune.Podium.Common
{
    public class Communication
    {
        public static long SendMail(string toAddress, string ccAddress, string bccAddress, string subject, string body, List<MailAttachment> lstAttachment, MailConfig oMailConfig)
        {
            long returnCode = -1;
            MailMessage mMailMessage = null;
            try
            {
                if (oMailConfig != null && !String.IsNullOrEmpty(oMailConfig.Host))
                {
                    if (!String.IsNullOrEmpty(oMailConfig.FromAddress) && !String.IsNullOrEmpty(toAddress))
                    {
                        mMailMessage = new MailMessage();
                        mMailMessage.From = new MailAddress(oMailConfig.FromAddress, oMailConfig.FromDisplayText);
                        mMailMessage.To.Add(toAddress);
                        if (!String.IsNullOrEmpty(ccAddress))
                        {
                            mMailMessage.CC.Add(ccAddress);
                        }
                        if (!String.IsNullOrEmpty(bccAddress))
                        {
                            mMailMessage.Bcc.Add(bccAddress);
                        }
                        mMailMessage.Subject = subject;
                        mMailMessage.Body = body;

                        mMailMessage.IsBodyHtml = true;
                        if (lstAttachment != null)
                        {
                            foreach (MailAttachment objAttachment in lstAttachment)
                            {
                                mMailMessage.Attachments.Add(new Attachment(objAttachment.ContentStream, objAttachment.FileName, MediaTypeNames.Application.Octet));
                            }
                        }
                        SmtpClient mSmtpClient = new SmtpClient();
                        mSmtpClient.Host = oMailConfig.Host;
                        mSmtpClient.Credentials = new System.Net.NetworkCredential(oMailConfig.UserName, oMailConfig.Password);
                        mSmtpClient.Port = oMailConfig.Port;
                        mSmtpClient.EnableSsl = true;
                        ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                        mSmtpClient.Send(mMailMessage);
                        returnCode = 0;
                    }
                }
                else
                {
                    throw new Exception("Server settings not found");
                }
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while sending E-Mail: ", ex);
            }
            finally
            {
                if (mMailMessage != null)
                    mMailMessage.Dispose();
            }
            return returnCode;
        }


        public static long SendMail(string fromAddress, string toAddress, string ccAddress, string bccAddress, string subject, string body, string fromDisplay, List<MailAttachment> lstAttachment, MailConfig oMailConfig)
        {
            long returnCode = -1;
            MailMessage mMailMessage = null;
            try
            {
                if (oMailConfig != null && !String.IsNullOrEmpty(oMailConfig.Host))
                {
                    if (!String.IsNullOrEmpty(fromAddress) && !String.IsNullOrEmpty(toAddress))
                    {
                        mMailMessage = new MailMessage();
                        mMailMessage.From = new MailAddress(fromAddress, fromDisplay);
                        mMailMessage.To.Add(toAddress);
                        if (!String.IsNullOrEmpty(ccAddress))
                        {
                            mMailMessage.CC.Add(ccAddress);
                        }
                        if (!String.IsNullOrEmpty(bccAddress))
                        {
                            mMailMessage.Bcc.Add(bccAddress);
                        }
                        mMailMessage.Subject = subject;
                        mMailMessage.Body = body;

                        mMailMessage.IsBodyHtml = true;
                        if (lstAttachment != null)
                        {
                            foreach (MailAttachment objAttachment in lstAttachment)
                            {
                                mMailMessage.Attachments.Add(new Attachment(objAttachment.ContentStream, objAttachment.FileName, MediaTypeNames.Application.Octet));
                            }
                        }
                        SmtpClient mSmtpClient = new SmtpClient();
                        mSmtpClient.Host = oMailConfig.Host;
                        mSmtpClient.Credentials = new System.Net.NetworkCredential(oMailConfig.UserName, oMailConfig.Password);
                        mSmtpClient.Port = oMailConfig.Port;
                        mSmtpClient.EnableSsl = true;
                        mSmtpClient.Send(mMailMessage);
                        returnCode = 0;
                    }
                }
                else
                {
                    throw new Exception("Server settings not found");
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while sending E-Mail: ", ex);
            }
            finally
            {
                if (mMailMessage != null)
                    mMailMessage.Dispose();
            }
            return returnCode;
        }

        public static void SendSMS(string URL, string Message, string ToMobileNo)
        {
            HttpWebResponse myResp = null;
            StreamReader respStreamReader = null;
            try
            {
                if (!String.IsNullOrEmpty(URL))
                {
                    URL = URL.Replace("{Message}", Message).Replace("{MobileNo}", ToMobileNo);
                    HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(URL);

                    myResp = (HttpWebResponse)myReq.GetResponse();
                    respStreamReader = new StreamReader(myResp.GetResponseStream());
                    string responseString = respStreamReader.ReadToEnd();
                }
                else
                {
                    throw new Exception("Server settings not found");
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while sending SMS: ", ex);
            }
            finally
            {
                if (myResp != null)
                    myResp.Close();
                if (respStreamReader != null)
                    respStreamReader.Dispose();
            }
        }
    }
    public class MailAttachment
    {
        public Stream ContentStream { get; set; }
        public string FileName { get; set; }
    }

    public class MailConfig
    {
        public string FromAddress { get; set; }
        public string FromDisplayText { get; set; }
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
    }
}