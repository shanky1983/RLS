
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class SCPTimeinfo
    {

        public string WorkingDays { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan SlotDuration { get; set; }
        public int DeleteType { get; set; }
    }

    public class SCPBookingslot
    {
        public string CheckingDate { get; set; }
        public string Available { get; set; }

        public DateTime ClickDate { get; set; }
    }

    public class SCPBookingCount
    {
        public int AutoID { get; set; }
        public long ResourceTemplateID { get; set; }
        public string ResourceName { get; set; }
        public int SCPCount { get; set; }

    }




    public class SCPBookingTimeWiseSlot
    {
        public int AutoID { get; set; }
        public long ResourceID { get; set; }
        public string ResourceName { get; set; }
        public long ResourceTemplateID { get; set; }
        public DateTime ClickDate { get; set; }
        public string SlotDuration { get; set; }
        public int BookedSlot { get; set; }

    }

    public class SCPBookingFinalSlot
    {
        public List<SCPBookingslot> SCPBookingTable1 { get; set; }
        public List<SCPBookingTimeWiseSlot> SCPBookingTable2 { get; set; }
        public List<SCPBookingCount> SCPBookingTable3 { get; set; }
        
    }

        public class SCPTime
    {

        public long ResourceTemplateID { get; set; }
        //public TimeSpan StartTime { get; set; }
        //public TimeSpan EndTime { get; set; }
        //public TimeSpan SlotDuration { get; set; }
        
        public List<SCPTimeinfo> SCPTimeInfoDet { get; set; }
        public List<SCPLeave> SCPLeave { get; set; }
        public List<SCPPinCodeinfo> SCPPinCode { get; set; }
    }


    public class SCPResourceTemplate
    {
        long ResourceTemplateID { get; set; }
    }


        public class SCPLeaveinfo
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public DateTime Holidays { get; set; }

    }


    public class SCPPinCodeinfo
    {
      public long PinCode { get; set; }

    }


    public class SCPLeave
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public DateTime Holidays { get; set; }

    }



}



