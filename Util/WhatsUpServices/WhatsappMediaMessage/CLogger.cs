using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhatsappMediaMessage
{
    public class CLogger
    {

        public void LogErrorMessage(string Error)
        {
            string sFileName = CreateLogFile();
            //
            File.AppendAllText(sFileName, Environment.NewLine);
            File.AppendAllText(sFileName, DateTime.Now.ToString("G") + Environment.NewLine);
            File.AppendAllText(sFileName, "------------------------" + Environment.NewLine);
            File.AppendAllText(sFileName, Error);
        }

        public void LogError(Exception oExp)
        {
            string sFileName = CreateLogFile();
            //
            File.AppendAllText(sFileName, Environment.NewLine);
            File.AppendAllText(sFileName, DateTime.Now.ToString("G") + Environment.NewLine);
            File.AppendAllText(sFileName, "------------------------" + Environment.NewLine);
            File.AppendAllText(sFileName, oExp.Source + Environment.NewLine);
            File.AppendAllText(sFileName, oExp.Message + Environment.NewLine);
            File.AppendAllText(sFileName, oExp.Data.ToString() + Environment.NewLine);
            File.AppendAllText(sFileName, (oExp.InnerException != null) ? oExp.InnerException.ToString() : string.Empty);
            File.AppendAllText(sFileName, Environment.NewLine);
            File.AppendAllText(sFileName, oExp.StackTrace + Environment.NewLine);
        }
        private string CreateLogFile()
        {
            string sFileName = System.Configuration.ConfigurationManager.AppSettings["LogFile"];
            if (!File.Exists(sFileName))
            {
                // Reason for creating the File through Filestream is because if File.Create is used, it is throwing access
                // violation error in the subsequent call to File.AppendAllText. Hence FileStream is used for creating the 
                // file if it doesn't exist and immediately close it. Then use the normal File.AppendAllText for 
                // appending the texts
                FileStream obj = new FileStream(sFileName, FileMode.Create, FileAccess.ReadWrite);
                obj.Close();
            }
            return sFileName;
        }

        internal static void LogError(string p, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
