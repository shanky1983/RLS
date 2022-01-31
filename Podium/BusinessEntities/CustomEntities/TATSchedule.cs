using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class TATSchedule
    {
        #region Fields

        private int scheduleid = 0;
        private string schedulecode = string.Empty;
        private string schedulename = string.Empty;
        private string reportedon = string.Empty;
        private int processinghours = 0;
        private int processingmins = 0;
        private string earlyreporttime = string.Empty;
        private int tatprocesstype = 0;
        private string scheduleday = string.Empty;
        private int tatmode = 0;
        private int tatcalculationbase = 0;

        private int totalRows = 0;
        private long sno = 0;

        private string tatprocesstypecode = string.Empty;
        private string tatmodecode = string.Empty;
        private string tatcalculationbasecode = string.Empty;
       
        private int randombatchid = 0;
        private int orgID = 0;

        private int THolidayid = 0;
        private string THolidayname = string.Empty;

        private string isSlotTAT = string.Empty;
        private int flag = 0;


        private string scheduledayCode = string.Empty;
        private string scheduledayName = string.Empty;

        #endregion

        #region Properties

        public string ScheduledayCode
        {
            get { return scheduledayCode; }
            set { scheduledayCode = value; }
        }
        public string ScheduledayName
        {
            get { return scheduledayName; }
            set { scheduledayName = value; }
        }
        public int THolidayiD
        {
            get { return THolidayid; }
            set { THolidayid = value; }
        }
        public string THolidayName
        {
            get { return THolidayname; }
            set { THolidayname = value; }
        }
        /// <summary>
        /// Gets or sets the Scheduleid value.
        /// </summary>
        public int Scheduleid
        {
            get { return scheduleid; }
            set { scheduleid = value; }
        }
        public string Schedulecode
        {
            get { return schedulecode; }
            set { schedulecode = value; }
        }
        public string Schedulename
        {
            get { return schedulename; }
            set { schedulename = value; }
        }
        public string Reportedon
        {
            get { return reportedon; }
            set { reportedon = value; }
        }

        public int Processinghours
        {
            get { return processinghours; }
            set { processinghours = value; }
        }
        public int Processingmins
        {
            get { return processingmins; }
            set { processingmins = value; }
        }
        public string Earlyreporttime
        {
            get { return earlyreporttime; }
            set { earlyreporttime = value; }
        }
        public int Tatprocesstype
        {
            get { return tatprocesstype; }
            set { tatprocesstype = value; }
        }
        public string Scheduleday
        {
            get { return scheduleday; }
            set { scheduleday = value; }
        }
        public int Tatmode
        {
            get { return tatmode; }
            set { tatmode = value; }
        }
        public int Tatcalculationbase
        {
            get { return tatcalculationbase; }
            set { tatcalculationbase = value; }
        }

        private string batchstarttime = string.Empty;
        public string Batchstarttime
        {
            get { return batchstarttime; }
            set { batchstarttime = value; }
        }

        private string cutofftime = string.Empty;
        public string Cutofftime
        {
            get { return cutofftime; }
            set { cutofftime = value; }
        }

        public int TotalRows
        {
            get { return totalRows; }
            set { totalRows = value; }
        }
        public long SNO
        {
            get { return sno; }
            set { sno = value; }
        }

        public string TatprocesstypeCode
        {
            get { return tatprocesstypecode; }
            set { tatprocesstypecode = value; }
        }

        public string Tatmodecode
        {
            get { return tatmodecode; }
            set { tatmodecode = value; }
        }

        public string Tatcalculationbasecode
        {
            get { return tatcalculationbasecode; }
            set { tatcalculationbasecode = value; }
        }



       
        /// <summary>
        /// Gets or sets the Randombatchid value.
        /// </summary>
        public int Randombatchid
        {
            get { return randombatchid; }
            set { randombatchid = value; }
        }



        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int Orgid
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public string IsSlotTAT
        {
            get { return isSlotTAT; }
            set { isSlotTAT = value; }
        }
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public List<SlotValue> SlotValue { get; set; }
    }
    public class SlotValue
    {
        public int scheduleid { get; set; }
        public string Batchstarttime { get; set; }
        public string Cutofftime { get; set; }
    }

    public class SlotConfig
    {
        public string Batchstarttime { get; set; }
        public string Cutofftime { get; set; }
    }

   
        #endregion
}








