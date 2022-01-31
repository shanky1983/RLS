using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Configuration;

namespace WindowsService
{
    [RunInstaller(true)]
    public class WindowsServiceInstaller : Installer
    {
        /// <summary>
        /// Public Constructor for WindowsServiceInstaller.
        /// - Put all of your Initialization code here.
        /// </summary>
        public WindowsServiceInstaller()
        {
            ServiceProcessInstaller serviceProcessInstaller = new ServiceProcessInstaller();
            ServiceInstaller serviceScheduleInstaller = new ServiceInstaller();
            //# Service Account Information
            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
            serviceProcessInstaller.Username = null;
            serviceProcessInstaller.Password = null;
            //# Service Information
            // string ServiceName1 = System.Configuration.ConfigurationSettings.AppSettings["ServiceName1"].Trim();
            serviceScheduleInstaller.DisplayName = "Attune-SmartReportCreation-V1.0";
           //serviceScheduleInstaller.DisplayName = GetConfigurationValue("ServiceName1");
            serviceScheduleInstaller.StartType = ServiceStartMode.Automatic;

            //# This must be identical to the WindowsService.ServiceBase namess
            //# set in the constructor of WindowsService.cs
            serviceScheduleInstaller.ServiceName = "Attune-SmartReportCreation-V1.0";
           // serviceScheduleInstaller.ServiceName = GetConfigurationValue("ServiceName1");
            this.Installers.Add(serviceProcessInstaller);
            this.Installers.Add(serviceScheduleInstaller);
        }

        private string GetConfigurationValue(string key)
        {
            System.Reflection.Assembly service = System.Reflection.Assembly.GetAssembly(typeof(Attune.Schedule.Service.ScheduleProcess));
            Configuration config = ConfigurationManager.OpenExeConfiguration(service.Location);
            if (config.AppSettings.Settings[key] != null)
            {
                return config.AppSettings.Settings[key].Value;
            }
            else
            {
                // throw new IndexOutOfRangeException
                // ("Settings collection does not contain the requested key: " + key);
            }
            return key;
        }

    }
}
