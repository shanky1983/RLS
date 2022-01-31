using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.BusinessComponent;
using Attune.Podium.BusinessEntities;


namespace ConsoleApplication1
{
    class ScheduleGenerator
    {
        const int OCCURANCECOUNT = 365;

        public List<PhysicianSchedule> GetResources(int orgID,int OrgAddressID)
        {
            Schedule_BL sBL = new Schedule_BL();
            List<PhysicianSchedule> pSch = new List<PhysicianSchedule>();
            List<PhysicianSpeciality> pSpl = new List<PhysicianSpeciality>();
            DateTime[] nxtOccurance = new DateTime[365];
            DateTime cOccruance = DateTime.Today;
            sBL.GetSchedules(0, orgID, out pSch, out pSpl, OrgAddressID, DateTime.Now.AddMonths(-3), DateTime.Now.AddYears(2));
            return pSch;
        }


        public List<int> GetScheduleTemplates(long resourceTemplateID,int orgID)
        {
            long retCode = -1;
            Schedule_BL schBL = new Schedule_BL();
            List<int> sTemplates = new List<int>();
            schBL.GetScheduleTemplates(resourceTemplateID,orgID,out sTemplates);
            return sTemplates;
        }

        public DateTime[] GetNxtOccurances(int scheduleTemplateID,DateTime occDate)
        {
           
            List<RecurrenceRelative> rrelative = new List<RecurrenceRelative>();
            List<RecurrenceAbsolute> rabsolute = new List<RecurrenceAbsolute>();
            Schedule_BL scheduleBL = new Schedule_BL();
            DateTime[] nxtOccurance = new DateTime[OCCURANCECOUNT];
            nxtOccurance = scheduleBL.GetNxtOccurances(scheduleTemplateID, occDate);
            return nxtOccurance;
        }

        public long SaveOccurances(DateTime[] nxtOccurance,long RTID,DateTime prevOccurance)
        {
            long returnCode = -1;
            Schedule_BL sBL = new Schedule_BL();
            Schedules schedule = new Schedules();
            schedule.ResourceTemplateID = RTID;
            schedule.Status = "A";
            schedule.CreatedBy = 1;
            schedule.PreviousOccurance = prevOccurance;
            foreach (DateTime nxtOcc in nxtOccurance)
            {
                if (nxtOcc > DateTime.MinValue)
                {
                    schedule.NextOccurance = nxtOcc.Date;
                    returnCode = sBL.SaveOccurances(schedule);
                }
            }
            return returnCode;
        }

        public long DeleteSchedule(long RTID)
        {
            long returnCode = -1;
            Schedule_BL sBL = new Schedule_BL();
            returnCode = sBL.DeleteSchedule(RTID);
            return returnCode;
        }




    }
}
