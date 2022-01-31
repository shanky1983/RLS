using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Attune.Podium.BusinessEntities;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Attune.Solution.BusinessComponent;
namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [STAThread()]
        static void Main(string[] args)
        {
            //string orgIds = string.Empty;

            Console.Title = "ScheduleGenerator";
            setConsoleWindowVisibility(false, Console.Title);     
            ScheduleGenerator schGen = new ScheduleGenerator();
            List<PhysicianSchedule> pSchedules = new List<PhysicianSchedule>();
            Schedule_BL objSchBL = new Schedule_BL();

            List<int> sTemplates = new List<int>();
            List<OrganizationAddress> lstOrganisation = new List<OrganizationAddress>();

            long lresult = objSchBL.getOrganizations(out lstOrganisation);

            DateTime[] nxtOccurances = new DateTime[Int16.MaxValue];

            //foreach (OrganizationAddress orgVal in lstOrganisation)
            //{
            //    orgIds += orgVal.Comments.ToString() + ",";
            //}

            //orgIds = "12";
            int IorgID;
            int IOrgAddressID;
            DateTime nxtOccurance = DateTime.Today;
            try
            {
                foreach (OrganizationAddress orgVal in lstOrganisation)
                {
                    Int32.TryParse(orgVal.Comments.Split('~')[0], out IorgID);
                    Int32.TryParse(orgVal.Comments.Split('~')[1], out IOrgAddressID);

                    pSchedules = schGen.GetResources(IorgID, IOrgAddressID);
                    foreach (PhysicianSchedule pSch in pSchedules)
                    {
                        sTemplates = schGen.GetScheduleTemplates(pSch.ResourceTemplateID, IorgID);
                        foreach (int sTID in sTemplates)
                        {
                            if (pSch.NextOccurance.CompareTo(DateTime.Today) < 0)
                            {
                                schGen.DeleteSchedule(pSch.ScheduleID);
                            }
                            nxtOccurance = pSch.NextOccurance;
                            nxtOccurances = schGen.GetNxtOccurances(sTID, nxtOccurance);
                            schGen.SaveOccurances(nxtOccurances, pSch.ResourceTemplateID, nxtOccurance);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void setConsoleWindowVisibility(bool visible, string title)
        {
            // below is Brandon's code            
            //Sometimes System.Windows.Forms.Application.ExecutablePath works for the caption depending on the system you are running under.           
            IntPtr hWnd = FindWindow(null, title);

            if (hWnd != IntPtr.Zero)
            {
                if (!visible)
                    //Hide the window                    
                    ShowWindow(hWnd, 0); // 0 = SW_HIDE                
                else
                    //Show window again                    
                    ShowWindow(hWnd, 1); //1 = SW_SHOWNORMA           
            }
        }
    }
}

