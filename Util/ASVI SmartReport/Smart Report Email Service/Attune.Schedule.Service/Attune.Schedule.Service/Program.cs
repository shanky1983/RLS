﻿using System;
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
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] 
            // { 
            //     new ScheduleProcess()
            // };
            //ServiceBase.Run(ServicesToRun);
//#if(!DEBUG)
//            ServiceBase[] ServicesToRun;
//            ServicesToRun = new ServiceBase[] 
//            { 
//            new ProcessMessages() 
//            };
//            ServiceBase.Run(ServicesToRun);
//#else
            ScheduleProcess myServ = new ScheduleProcess();
            string[] args = null;
            myServ.OnStart(args);
            // here Process is my Service function
            // that will run when my service onstart is call
            // you need to call your own method or function name here instead of Process();
//#endif
        }
    }
}
