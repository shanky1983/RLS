using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class Schedule_BL
    {
        ContextDetails globalContextDetails;
        public Schedule_BL()
        {

        }
        public Schedule_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        private const int NoofOccurance = 15;

        public long GetBookings(long resourceTemplateID, int OrgID, DateTime startTime, long scheduleID, out int scheduleTemplateID, out List<Bookings> bookings, out List<ScheduleTemplate> stemplate)
        {
            long returnCode = -1;
            scheduleTemplateID = -1;
            bookings = null;
            stemplate = null;

            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                bookings = new List<Bookings>();
                stemplate = new List<ScheduleTemplate>();
                scheduleTemplateID = 0;
                returnCode = scheduleDAL.GetBookings(resourceTemplateID, OrgID, startTime, scheduleID, out scheduleTemplateID, out bookings, out stemplate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBookings", excp);
            }

            return returnCode;
        }


        public long GetScheduleTemplates(long resourceTemplateID, int orgID, out List<int> schTemplates)
        {
            long returnCode = -1;
            schTemplates = null;
            try
            {
                Schedule_DAL sDal = new Schedule_DAL(globalContextDetails);
                schTemplates = new List<int>();
                returnCode = sDal.GetScheduleTemplates(resourceTemplateID, orgID, out schTemplates);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetScheduleTemplates", excp);
            }

            return returnCode;
        }

        public DateTime[] GetNxtOccurances(int scheduleTemplateID, DateTime occDate)
        {
            DateTime lastOccurance = DateTime.MinValue;
            List<RecurrenceRelative> rrelative = new List<RecurrenceRelative>();
            List<RecurrenceAbsolute> rabsolute = new List<RecurrenceAbsolute>();
            Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
            int i = 0;
            int month = 0;
            int year;
            int day = 0;
            int week = 0;
            int monthNumber = 0;
            string sWD = string.Empty;
            string sWN = string.Empty;
            DateTime nextOccurance = new DateTime();
            DateTime[] nextOccurances = new DateTime[NoofOccurance];

            try
            {
                scheduleDAL.GetRecurrencePattern(scheduleTemplateID, out lastOccurance, out rrelative, out rabsolute);

                switch (rrelative[0].Type)
                {
                    case "D":
                        week = rrelative[0].Interval;
                        break;
                    case "M":
                        month = rrelative[0].Interval;
                        break;
                    case "Y":
                        year = rrelative[0].Interval;
                        break;
                    case "W":
                        week = rrelative[0].Interval;
                        break;
                }
                foreach (RecurrenceAbsolute ra in rabsolute)
                {
                    switch (ra.Unit)
                    {
                        case "MD":
                            Int32.TryParse(ra.Value, out day);
                            break;
                        case "MN":
                            Int32.TryParse(ra.Value, out monthNumber);
                            break;
                        case "WD":
                            sWD = ra.Value;
                            break;
                        case "WN":
                            sWN = ra.Value;
                            break;
                        case "DD":
                            sWD = ra.Value;
                            break;
                    }
                }

                if (occDate > DateTime.MinValue)
                    lastOccurance = occDate;
                nextOccurance = InferRelativeDate(lastOccurance, month, week);
                nextOccurances = InferAbsoluteDate(lastOccurance, nextOccurance, day, monthNumber, sWN, sWD, out nextOccurances);
                lastOccurance = nextOccurances[0];

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetNxtOccurances", excp);
            }

            return nextOccurances;

        }

        public long GetPhysicians(int OrgID, out List<PhysicianSchedule> physicianschedule)
        {
            long returnCode = -1;
            physicianschedule = null;

            try
            {
                physicianschedule = new List<PhysicianSchedule>();
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                scheduleDAL.GetPhysicianList(OrgID, out physicianschedule);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicians", excp);
            }

            returnCode = 0;
            return returnCode;
        }

        public long GetSchedules(long resourceTID, int orgID,
            out List<PhysicianSchedule> physicianschedule,
            out List<PhysicianSpeciality> phySpeciality,
            int LocationID,
            DateTime sFromDate, DateTime sToDate)
        {
            long returnCode = -1;
            physicianschedule = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetSchedules(resourceTID, orgID, out physicianschedule, out phySpeciality, LocationID, sFromDate, sToDate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSchedules", excp);
            }

            return returnCode;
        }

        public long SaveBooking(Bookings book)
        {
            long returnCode = -1;

            try
            {
                Schedule_DAL sDAL = new Schedule_DAL(globalContextDetails);
                returnCode = sDAL.SaveBooking(book);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveBooking", excp);
            }
            return returnCode;
        }

        private DateTime GetDateforWeek(DateTime date, int WeekNumber, DayOfWeek dow)
        {
            DateTime finalDate = date;

            if (WeekNumber == 0)
            {

                while (finalDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    finalDate = finalDate.AddDays(-1);
                }
                while (finalDate.DayOfWeek != dow)
                {
                    finalDate = finalDate.AddDays(1);
                }

            }
            else
            {
                WeekNumber--;
                finalDate = finalDate.AddDays(1 - finalDate.Day);
                while (finalDate.DayOfWeek != dow)
                {
                    finalDate = finalDate.AddDays(1);
                }
                finalDate = finalDate.AddDays(WeekNumber * 7);
                if (finalDate.Day >= date.Day && finalDate.Month == date.Month)
                {
                    return finalDate;
                }
                else
                {
                    finalDate = finalDate.AddDays(1 - finalDate.Day);
                    finalDate = finalDate.AddMonths(1);
                    while (finalDate.DayOfWeek != dow)
                    {
                        finalDate = finalDate.AddDays(1);
                    }
                    finalDate = finalDate.AddDays(WeekNumber * 7);
                }
            }
            return finalDate;

        }

        private DateTime InferRelativeDate(DateTime lastOccurance, int intervalinMonths, int intervalinWeeks)
        {

            DateTime nextOccurance = new DateTime();
            if (intervalinMonths > 0)
            {
                lastOccurance = lastOccurance.AddMonths(intervalinMonths);
                lastOccurance = lastOccurance.AddDays(1 - lastOccurance.Day);
                nextOccurance = lastOccurance;
            }
            if (intervalinWeeks > 0)
            {
                lastOccurance = lastOccurance.AddDays(intervalinWeeks * 7);
                nextOccurance = lastOccurance;
            }


            return nextOccurance;

        }

        private DateTime[] InferAbsoluteDate(DateTime lastOccurance, DateTime nextOccurance, int day, int monthNumber, string sWN, string sWD, out DateTime[] nextOccurances)
        {
            int iWN, iWD, i = 0;
            DateTime tempDate = new DateTime();
            DateTime iDate = new DateTime();
            nextOccurances = new DateTime[NoofOccurance];
            if (day > 0)
            {
                if (monthNumber > 0)
                    iDate = new DateTime(DateTime.Now.Year, monthNumber, day);
                else
                    iDate = new DateTime(DateTime.Now.Year, nextOccurance.Month, day);
                nextOccurances[i++] = iDate;
            }
            else
            {
                DayOfWeek[] dWeek = new DayOfWeek[] {DayOfWeek.Sunday,DayOfWeek.Monday,DayOfWeek.Tuesday,DayOfWeek.Wednesday,
            DayOfWeek.Thursday,DayOfWeek.Friday,DayOfWeek.Saturday};
                //Check if theres any day pending in the week of LastOccurancedate
                if (lastOccurance.CompareTo(DateTime.Now) != -1)
                {
                    tempDate = lastOccurance;
                    foreach (string wkday in sWD.Split(','))
                    {
                        iWD = Convert.ToInt32(wkday);
                        if (tempDate.DayOfWeek <= dWeek[iWD])
                        {
                            nextOccurances[i++] = tempDate;
                            tempDate = tempDate.AddDays(1);
                        }

                    }
                }
                if (sWN != string.Empty)
                {
                    foreach (string wknum in sWN.Split(','))
                    {
                        iWN = Convert.ToInt32(wknum);
                        foreach (string wkday in sWD.Split(','))
                        {
                            iWD = Convert.ToInt32(wkday);
                            nextOccurances[i] = GetDateforWeek(nextOccurance, iWN, dWeek[iWD]);
                            i++;
                        }
                    }
                }
                //Relative week already added in InferRelativeWeek)
                else
                {
                    //Check if theres any day pending in the week of LastOccurancedate
                    tempDate = lastOccurance;
                    foreach (string wkday in sWD.Split(','))
                    {
                        iWD = Convert.ToInt32(wkday);
                        tempDate = GetDateforWeek(lastOccurance, 0, dWeek[iWD]);
                        if (tempDate.CompareTo(DateTime.Today) != -1)
                        {
                            nextOccurances[i] = tempDate;
                            i++;
                        }
                    }
                    foreach (string wkday in sWD.Split(','))
                    {
                        iWD = Convert.ToInt32(wkday);
                        nextOccurances[i] = GetDateforWeek(nextOccurance, 0, dWeek[iWD]);
                        i++;
                    }
                }
            }
            return nextOccurances;
        }

        private bool has10occurances(DateTime[] nextOccurances)
        {
            int i = 0;
            bool hasValue = true;
            for (i = 0; i < 10; i++)
            {
                if (nextOccurances[i] == DateTime.MinValue)
                {
                    hasValue = false;
                    break;
                }
            }

            return hasValue;
        }


        public long InsertSchedules(List<RecurrenceAbsolute> lstRAbsolute, List<RecurrenceRelative> lstRelative,
            List<ScheduleTemplate> lstScheduleTemp, List<SchedulableResource> lstResource, List<Schedules> lstSchedules,
            int stid, int rtid, int RecurrenceID)
        {
            long resultCode = -1;
            try
            {
                Schedule_DAL ScheduleDAL = new Schedule_DAL(globalContextDetails);
                resultCode = ScheduleDAL.InsertSchedules(lstRAbsolute, lstRelative, lstScheduleTemp, lstResource, lstSchedules, stid, rtid, RecurrenceID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertSchedule", ex);
            }

            return resultCode;
        }


        public long SaveOccurances(Schedules Schedule)
        {
            long resultCode = -1;
            try
            {
                Schedule_DAL ScheduleDAL = new Schedule_DAL(globalContextDetails);
                resultCode = ScheduleDAL.SaveSchedule(Schedule);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertSchedule", ex);
            }

            return resultCode;
        }


        public long DeleteSchedule(long RTID)
        {
            long resultCode = -1;
            try
            {
                Schedule_DAL ScheduleDAL = new Schedule_DAL(globalContextDetails);
                resultCode = ScheduleDAL.DeleteSchedule(RTID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteSchedule", ex);
            }

            return resultCode;
        }

        public long CancelBooking(long bookID, string description)
        {
            long resultCode = -1;
            try
            {
                Schedule_DAL ScheduleDAL = new Schedule_DAL(globalContextDetails);
                resultCode = ScheduleDAL.CancelBooking(bookID, description);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertSchedule", ex);
            }

            return resultCode;
        }

        public long GetDoctorsSchedule(int pOrgAddID, string FromDate, string ToDate, int ResourceID, string ResourceType, out List<DoctorSchedule> lstDoctorSchedule)
        {
            long returnCode = -1;
            lstDoctorSchedule = null;

            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                lstDoctorSchedule = new List<DoctorSchedule>();
                returnCode = scheduleDAL.GetDoctorsSchedule(pOrgAddID, FromDate, ToDate, ResourceID, ResourceType, out lstDoctorSchedule);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBookings", excp);
            }

            return returnCode;
        }

        public long GetSchedulesForEdit(long resourceID, int orgID, out List<PhysicianSchedule> physicianschedule, out List<PhysicianSpeciality> phySpeciality, string sType, DateTime FromDate, DateTime ToDate, int LocationID)
        {
            long returnCode = -1;
            physicianschedule = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetSchedulesForEdit(resourceID, orgID, out physicianschedule, out phySpeciality, sType, FromDate, ToDate, LocationID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSchedules", excp);
            }

            return returnCode;
        }

        public long SaveExceptionSchedule(long lRTID, long lSID, DateTime dDateofChange, DateTime sStartTime, DateTime sEndTime, int iSDuration, int LID)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.SaveExceptionSchedule(lRTID, lSID, dDateofChange, sStartTime, sEndTime, iSDuration, LID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSchedules", excp);
            }

            return returnCode;
        }


        public long InsertVacation(int iVacationID, long lPhyID, DateTime sFromDate, DateTime sToDate, string sCancelledSchedules, string sStatus, int iCreatedBy)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.InsertVacation(iVacationID, lPhyID, sFromDate, sToDate, sCancelledSchedules, sStatus, iCreatedBy);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing Insert Vacation", excp);
            }

            return returnCode;
        }

        public long GetPhysicianVacations(long resourceID, int orgID, out List<PhysicianSchedule> physicianschedule,
                                        out List<PhysicianSpeciality> phySpeciality, string sType, DateTime FromDate,
                                        DateTime ToDate, out List<DoctorSchedule> lstDocSchedule, out List<PhysicianVacationDetails> lstVacationDetails)
        {
            long returnCode = -1;
            physicianschedule = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            lstDocSchedule = new List<DoctorSchedule>();
            lstVacationDetails = new List<PhysicianVacationDetails>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetPhysicianVacations(resourceID, orgID, out physicianschedule, out phySpeciality, sType, FromDate, ToDate, out lstDocSchedule, out lstVacationDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSchedules", excp);
            }

            return returnCode;
        }

        public long UpdatePhysicianVacation(int iVacationID, int iCreatedBy)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.UpdatePhysicianVacation(iVacationID, iCreatedBy);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdatePhysicianVacation", excp);
            }

            return returnCode;
        }

        public long UpdateindSchedules(int ischdeuleID)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.UpdateindSchedules(ischdeuleID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateindSchedules", excp);
            }

            return returnCode;
        }

        //public long getTrustedOrgs(int iOrgID, out List<TrustedOrgs> lsttrust)
        //{
        //    long returnCode = -1;
        //    lsttrust = new List<TrustedOrgs>();
        //    try
        //    {
        //        Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
        //        returnCode = scheduleDAL.getTrustedOrgs(iOrgID, out lsttrust);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing UpdateindSchedules", excp);
        //    }

        //    return returnCode;
        //}

        public long getOrganizations(out List<Organization> lstOrganization)
        {
            long returnCode = -1;
            lstOrganization = new List<Organization>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.getOrganizations(out lstOrganization);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateindSchedules", excp);
            }

            return returnCode;
        }

        public long getOrganizationAddress(out List<OrganizationAddress> lstOrganizationAddress)
        {
            long returnCode = -1;
            lstOrganizationAddress = new List<OrganizationAddress>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.getOrganizationAddress(out lstOrganizationAddress);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateindSchedules", excp);
            }

            return returnCode;
        }

        public long GetSchedulesAndBookings(string resourceTemplateID, int orgID,
            out List<PhysicianSchedule> schedules,
            out List<PhysicianSpeciality> phySpeciality,
            int LocationID,
            //DateTime sFromDate, DateTime sToDate,
            //out int scheduleTemplateID, 
            out List<Bookings> bookings
            //, out List<ScheduleTemplate> stemplate
            )
        {
            long returnCode = -1;
            bookings = null;
            bookings = new List<Bookings>();

            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();

            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetSchedulesAndBookings(resourceTemplateID, orgID,
                                out  schedules, out  phySpeciality, LocationID //,sFromDate, sToDate
                                , out  bookings);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSchedulesAndBookings", excp);
            }

            return returnCode;
        }

        public long SaveBookingBulkSchedules(List<Bookings> book)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.SaveBookingBulkSchedules(book);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveBookingBulkSchedules", excp);
            }

            return returnCode;
        }

        public long GetSchedulesForDateRange(DateTime sFromDate, int orgID, DateTime sToDate,
           out List<PhysicianSchedule> schedules)
        {
            long returnCode = -1;

            schedules = new List<PhysicianSchedule>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetSchedulesForDateRange(sFromDate, orgID, sToDate,
                                out  schedules);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSchedulesForDateRange", excp);
            }

            return returnCode;
        }
        public long UpdateScedules(long ibookingid, int orgid, string premarks, string pstatus)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.UpdateScedules(ibookingid, orgid, premarks, pstatus);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateScedules", excp);
            }

            return returnCode;
        }
        public void DeletePhysicianSchedule(long Stid, long rtid)
        {
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                scheduleDAL.DeletePhysicianSchedule(Stid, rtid);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing DeletePhysicianSchedule", excp);
            }
        }

        public long GetScheduleDetails(long resourceID, string ResourceType, int orgID, int OrgAddressID, out List<Bookings> bookings)
        {
            long returnCode = -1;
            bookings = new List<Bookings>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetScheduleDetails(resourceID, ResourceType, orgID, OrgAddressID, out bookings);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing DeletePhysicianSchedule", excp);
            }
            return returnCode;

        }



        public long GetClientSchedules(int orgID, int customerTypeID, string Client, long ClientID, int LocationID,
                 DateTime sFromDate, DateTime sToDate, out List<Schedulesinvoice> schedules, int PageSize, int startRowIndex, out int totalRows, string searchtype)
        {
            long returnCode = -1;
            totalRows = 0;
            schedules = new List<Schedulesinvoice>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetClientSchedules(orgID, customerTypeID, Client, ClientID, LocationID, sFromDate, sToDate, out schedules, PageSize, startRowIndex, out totalRows, searchtype);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetClientSchedules", excp);
            }

            return returnCode;
        }



        public long GetClientList(int pOrgID, string prefixText, out List<ClientMaster> lstClientMaster)
        {

            lstClientMaster = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetClientList(pOrgID, prefixText, out lstClientMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetClientList  ", ex);
            }
            return returnCode;
        }

        public long GetOrgInvestigationsGroupandPKG(int Orgid, int Locationid, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetOrgInvestigationsGroupandPKG(Orgid, Locationid, prefixText, ItemType, out lstBillingFeeDetails);
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetQuickBillItems", ex);
            }

            return returnCode;

        }

        public long getOrganizationsWithType(int refClientID, out List<Organization> lstOrganization)
        {
            long returnCode = -1;
            lstOrganization = new List<Organization>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.getOrganizationsWithType(refClientID, out lstOrganization);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing getOrganizationsWithType", excp);
            }

            return returnCode;
        }

        public long SaveServiceQuotationDetails(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.SaveServiceQuotationDetails(oBookings, lstOrderedInves, OrgID, LID, out bookingID);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in SaveServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }



        public long GetServiceQuotationDetails(long bookingID, int OrgID, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetServiceQuotationDetails(bookingID, OrgID, out lstBookings);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in GetServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }

        public long GetHubName(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            lstLOCAL = new List<Localities>();
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL();
                returnCode = scheduleDAL.GetHubName(OrgID, prefixText, out lstLOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetHubName BL", ex);
            }
            return returnCode;
        }


        public long GetZoneName(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            lstLOCAL = new List<Localities>();
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL();
                returnCode = scheduleDAL.GetZoneName(OrgID, prefixText, out lstLOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetZoneName BL", ex);
            }
            return returnCode;
        }


        public long GetHubCode(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            lstLOCAL = new List<Localities>();
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL();
                returnCode = scheduleDAL.GetHubCode(OrgID, prefixText, out lstLOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetHubCode BL", ex);
            }
            return returnCode;
        }

        public long GetZoneCode(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            lstLOCAL = new List<Localities>();
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL();
                returnCode = scheduleDAL.GetZoneCode(OrgID, prefixText, out lstLOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetZoneCode BL", ex);
            }
            return returnCode;
        }

        public long GetRouteCode(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            lstLOCAL = new List<Localities>();
            long returnCode = -1;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL();
                returnCode = scheduleDAL.GetRouteCode(OrgID, prefixText, out lstLOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRouteCode BL", ex);
            }
            return returnCode;
        }

        public long GetBookingsDt(long BookingID, out List<Bookings> bookings, out List<Bookings> bookingsQuat)
        {
            long returnCode = -1;
            bookings = null;
            bookingsQuat = null;
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                bookings = new List<Bookings>();
                bookingsQuat = new List<Bookings>();
                returnCode = scheduleDAL.GetBookingsDt(BookingID, out bookings, out bookingsQuat);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBookings", excp);
            }

            return returnCode;
        }
        public long GetOrgInvestigations(int Orgid, int Locationid, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetOrgInvestigations(Orgid, Locationid, prefixText, ItemType, out lstBillingFeeDetails);
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in LibraryCodes", ex);
            }

            return returnCode;

        }

        public long GetWatersClientSchedules(int orgID, int customerTypeID, string Client, long ClientID, int LocationID,
                DateTime sFromDate, DateTime sToDate, out List<Schedulesinvoice> schedules, int PageSize, int startRowIndex, out int totalRows, string searchtype)
        {
            long returnCode = -1;
            totalRows = 0;
            schedules = new List<Schedulesinvoice>();
            try
            {
                Schedule_DAL scheduleDAL = new Schedule_DAL(globalContextDetails);
                returnCode = scheduleDAL.GetWatersClientSchedules(orgID, customerTypeID, Client, ClientID, LocationID, sFromDate, sToDate, out schedules, PageSize, startRowIndex, out totalRows, searchtype);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetWatersClientSchedules", excp);
            }

            return returnCode;
        }


    }
}
