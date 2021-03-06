using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;


namespace Attune.Schedule.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ////ServiceBase[] ServicesToRun;
            ////ServicesToRun = new ServiceBase[] 
            //// { 
            ////     new Attune_FeedbackNotifi_Service_Metropolis()
            //// };
            ////ServiceBase.Run(ServicesToRun);
            //////#if(!DEBUG)
            //             ServiceBase[] ServicesToRun;
            //             ServicesToRun = new ServiceBase[] 
            //             { 
            //             new ProcessMessages() 
            //             };
            //             ServiceBase.Run(ServicesToRun);
            //#else




            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
             { 
                 new Attune_RLSIntegration.ProcessMessages()  ,
                 new Attune_RLSIntegration.SmartReportMessage(),
                 new Attune_RLSIntegration.UploadMedicalRecordPDF(),
                 new Attune_RLSIntegration.CovidIntegrationMessage()
             };
            ServiceBase.Run(ServicesToRun);





            //Attune_FeedbackNotifi_Service_Metropolis ser = new Attune_FeedbackNotifi_Service_Metropolis();
            //ser.Process_PdfGeneratingEvent();



            //            string[] args = null;
            //            myServ.OnStart(args);
            //            // here Process is my Service function
            //            // that will run when my service onstart is call
            //            // you need to call your own method or function name here instead of Process();
            //#endif
        }
    }
}