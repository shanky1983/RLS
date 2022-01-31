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
            serviceScheduleInstaller.DisplayName = "Attune_uploadStructureData_RLS_V1.0";
            //serviceScheduleInstaller.DisplayName = "Attune-Metropolis_Feedback-Service-Metropolis_QA_V1.5";
            //serviceScheduleInstaller.DisplayName = GetConfigurationValue("ServiceName1");
            serviceScheduleInstaller.StartType = ServiceStartMode.Manual;

            //# This must be identical to the WindowsService.ServiceBase namess
            //# set in the constructor of WindowsService.cs
            serviceScheduleInstaller.ServiceName = "Attune_uploadStructureData_RLS_V1.0";
            //serviceScheduleInstaller.ServiceName = "AAttune-Metropolis_Feedback-Service-Metropolis_QA_V1.5";
            // serviceScheduleInstaller.ServiceName = GetConfigurationValue("ServiceName1");
            this.Installers.Add(serviceProcessInstaller);
            this.Installers.Add(serviceScheduleInstaller);


            ServiceProcessInstaller serviceProcessInstallerSmart = new ServiceProcessInstaller();
            ServiceInstaller serviceScheduleInstallerSmart = new ServiceInstaller();
            //# Service Account Information
            serviceProcessInstallerSmart.Account = ServiceAccount.LocalSystem;
            serviceProcessInstallerSmart.Username = null;
            serviceProcessInstallerSmart.Password = null;
            serviceScheduleInstallerSmart.DisplayName = "Attune_uploadSmartReport_RLS_V1.0";
            serviceScheduleInstallerSmart.StartType = ServiceStartMode.Manual;
             
            serviceScheduleInstallerSmart.ServiceName = "Attune_uploadSmartReport_RLS_V1.0"; 
            this.Installers.Add(serviceProcessInstallerSmart);
            this.Installers.Add(serviceScheduleInstallerSmart);

            ServiceProcessInstaller serviceProcessInstallerPdf = new ServiceProcessInstaller();
            ServiceInstaller serviceScheduleInstallerPdf = new ServiceInstaller();
            //# Service Account Information
            serviceProcessInstallerPdf.Account = ServiceAccount.LocalSystem;
            serviceProcessInstallerPdf.Username = null;
            serviceProcessInstallerPdf.Password = null;
            serviceScheduleInstallerPdf.DisplayName = "Attune_uploadMedicalRecord_RLS_V1.0";
            serviceScheduleInstallerPdf.StartType = ServiceStartMode.Manual;

            serviceScheduleInstallerPdf.ServiceName = "Attune_uploadMedicalRecord_RLS_V1.0";
            this.Installers.Add(serviceProcessInstallerPdf);
            this.Installers.Add(serviceScheduleInstallerPdf);


            ServiceProcessInstaller serviceProcessInstallerCovid = new ServiceProcessInstaller();
            ServiceInstaller serviceScheduleInstallerCovid = new ServiceInstaller();
            //# Service Account Information
            serviceProcessInstallerCovid.Account = ServiceAccount.LocalSystem;
            serviceProcessInstallerCovid.Username = null;
            serviceProcessInstallerCovid.Password = null;
            serviceScheduleInstallerCovid.DisplayName = "Attune_uploadCovidtestReport_RLS_V1.0";
            serviceScheduleInstallerCovid.StartType = ServiceStartMode.Manual;

            serviceScheduleInstallerCovid.ServiceName = "Attune_uploadCovidtestReport_RLS_V1.0";
            this.Installers.Add(serviceProcessInstallerCovid);
            this.Installers.Add(serviceScheduleInstallerCovid);
        }

        private string GetConfigurationValue(string key)
        {
            System.Reflection.Assembly service = System.Reflection.Assembly.GetAssembly(typeof(Attune.Schedule.Service.Program));
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