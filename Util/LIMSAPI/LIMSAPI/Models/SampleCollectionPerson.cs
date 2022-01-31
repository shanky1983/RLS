using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class SampleCollectionPerson
    {

        public List<TimeslotModel> TimeInfoList { get; set; }
        public List<LeaveslotModel> LeaveInfoList { get; set; }
    }


    public class TimeslotModel
    {
        public string WorkingDays { get; set; }

      //  private DateTime startTime = DateTime.MaxValue;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
     
        public TimeSpan SlotDuration { get; set; }
    }



    public class LeaveslotModel
    {

    
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime Holidays { get; set; }
      
    }


}