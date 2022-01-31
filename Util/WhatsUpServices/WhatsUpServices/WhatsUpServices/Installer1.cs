using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsUpServices
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller serviceInstaller1;
        public Installer1()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            this.serviceInstaller1.Description = "WhatsUpNotificationService";
            this.serviceInstaller1.DisplayName = "WhatsUpNotificationService";
            this.serviceInstaller1.ServiceName = "WhatsUpNotificationService";
            this.Installers.AddRange(new System.Configuration.Install.Installer[]
           {
                this.serviceProcessInstaller1,this.serviceInstaller1

           }
           );
            //InitializeComponent();
        }
    }
}
